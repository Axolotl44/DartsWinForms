using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DartsDotNetFrameWork
{
    public partial class GameControl : UserControl
    {
        private Game game;

        public GameControl(Game game)
        {
            InitializeComponent();
            this.game = game;
            CreatePlayerControls();
            CurrentPlayerEmphasize(0);
        }

        PlayerControl[] playerControl;
        private void CreatePlayerControls()
        {
            playerControl = new PlayerControl[game.NumOfPlayers];

            for (int i = 0; i < playerControl.Length; i++)
            {
                playerControl[i] = new PlayerControl();
                playerControl[i].NameP = $"{game.Players[i].Name}";
                playerControl[i].PointP = $"{game.Players[i].Point}";

                //kezdéskor 0
                playerControl[i].LegP = $"{game.Players[i].LegsWon}";
                playerControl[i].SetP = $"{game.Players[i].SetsWon}";

                flowLayoutPanel1.Controls.Add(playerControl[i]);  
            }
            //először az első a kezdő player, őt kiemeljük
            CurrentPlayerEmphasize(0);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThrownNumHandler();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThrownNumHandler();
        }

        int dobottSzam;
        int currentPlayer = 0;
        private void ThrownNumHandler()
        {
            if (textBox1.Text == "") //van-e érték beírva check
            {
                textBox1.Clear();
                MessageBox.Show("Adj meg értéket");
                return;
            }
            if (int.TryParse(textBox1.Text, out dobottSzam)) //szám-e check
            {
                if (dobottSzam > 180 || dobottSzam < 0) //ha nagyobbat dobna mint 180
                {
                    MessageBox.Show("Cheater, dobj újra");
                    textBox1.Clear();
                    return;
                }
                if (dobottSzam > game.Players[currentPlayer].Point) //Ha nagyobbat dobna mint amennyi pontja van
                {
                    MessageBox.Show("Nagyobbat dobtál mint amennyi pontod volt");
                    textBox1.Clear();
                    return;
                }
                //Ha valós értéket dobott be, akkor számoljuk hogy ki a soros, amúgy nem. és az dob ezután
                textBox1.Clear();
               
                ThrowExtra(dobottSzam, currentPlayer);
                //miután dobtunk, újraszámoljuk a következő playert és kiemeljük
                currentPlayer = CurrentPlayerCalc();
                CurrentPlayerEmphasize(currentPlayer);
            }
            else //van érték beírva, de nem szám
            {
                textBox1.Clear();
                MessageBox.Show("Valós értéket adj meg");
            }
        }

        
        int legStarterPlayerTESZT = 0;
        int setStarterPlayerTESZT = 0;
        private int currentLegTESZT = 1;
        private int currentSetTESZT = 1;
        bool playerWonLegTESZT = false;
        bool playerWonSetTESZT = false;
        bool playerWonGameTESZT = false;
        private int CurrentPlayerCalc()
        {
            //NE BASZOGTASD JÓ
            if (playerWonSetTESZT) //fordított sorrendben először a set kezdőt kell megnézni
            {
                playerWonSetTESZT = false;
                playerWonLegTESZT = false;

                if (setStarterPlayerTESZT < game.NumOfPlayers - 1)
                { setStarterPlayerTESZT++; }
                else
                { setStarterPlayerTESZT = 0; }

                currentPlayer = setStarterPlayerTESZT;
                return currentPlayer;
            }
            else if (playerWonLegTESZT) //ha player nyert leget, de nem nyert setet
            {
                playerWonLegTESZT = false;

                if (legStarterPlayerTESZT < game.NumOfPlayers - 1)
                { legStarterPlayerTESZT++; }
                else
                { legStarterPlayerTESZT = 0; }

                currentPlayer = legStarterPlayerTESZT;
                return currentPlayer;
            }
            else //Ha player még nem nyert leget, sem szetet
            {
                if (currentPlayer < game.NumOfPlayers - 1)
                { currentPlayer++; }
                else
                { currentPlayer = 0; }

                return currentPlayer;
            } 
        }

        private void ThrowExtra(int pointThrown, int currentP) //enter után hívódik, bementként megadott számmal, current playerrel
        {
            game.Players[currentP].Point -= pointThrown;
            game.Players[currentP].PointsThrown.Add(pointThrown); //egybe 3 dobás pontja
            game.Players[currentP].NumOfThrows += 3;

            playerControl[currentP].PointP = $"{game.Players[currentPlayer].Point}";

            //Checkout lehetőség kiírás
            if (game.Players[currentP].Point <= 170)
            {
                try
                {
                    playerControl[currentP].OutP = CheckOut.Checkout(game.Players[currentP].Point);
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("elkúrtam a kiszállókat");
                    return;
                }
                playerControl[currentP].CheckOutPossible();
            }
            
            CheckAll(currentP); //előbb mindent is ellenőrzünk
        }

        private void CurrentPlayerEmphasize(int currentP)
        {
            playerControl[currentP].SetCurrentPlayer();
            //kell még egy scroll to element

            for (int c = 0; c < game.NumOfPlayers; c++)
            {
                if (c != currentP)
                {
                    playerControl[c].NotCurrentPlayer();
                }   
            }
        }

        private void CheckAll(int currentP)
        {
            if (game.Players[currentP].Point <= 0) //Leg win
            {
                //üzenet
                MessageBox.Show($"{game.Players[currentP].Name} nyerte a leget!");

                //számolás+logika
                game.Players[currentP].LegsWon++;
                playerWonLegTESZT = true;

                //controlra való kiírás
                playerControl[currentP].LegP = $"{game.Players[currentP].LegsWon}";

                //pontok, checkout visszaállítása
                PointReset();
                CheckoutLabelReset();
            }
            if (game.Players[currentP].LegsWon == game.LegToSet) //Set win
            {
                //üzenet
                MessageBox.Show($"{game.Players[currentP].Name} nyerte a setet!");

                //számolás+logika
                game.Players[currentP].SetsWon++;
                playerWonSetTESZT = true;

                //controlra való kiírás
                playerControl[currentP].SetP = $"{game.Players[currentP].SetsWon}";

                //pontok, checkout visszaállítása
                PointReset();
                LegReset();
                CheckoutLabelReset();
            }
            if (game.Players[currentP].SetsWon == game.SetToWin) //GAME WIN
            {
                MessageBox.Show($"{game.Players[currentP].Name} nyerte a gamet!");
                playerWonGameTESZT = true;
            }

        }

        private void PointReset() //nyert leg után
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                game.Players[i].Point = game.PointToWin;
                game.Players[i].PointsThrown.Clear();
                game.Players[i].NumOfThrows = 0;

                playerControl[i].PointP = $"{game.PointToWin}";
            }
        }

        private void LegReset() //nyert set után, csak a nyert legeket állítja vissza
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                game.Players[i].LegsWon = 0;

                playerControl[i].LegP = "0";
            }
        }

        private void CheckoutLabelReset()
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                playerControl[i].CheckOutNotPossible();
            }
        }


        //UNUSED SHITS... YET
        //private void NyertLeg(int i) //adhatnék playert is bemenetként de így most egyszerűbb volt
        //{
        //    //playerWonLeg = true;

        //    MessageBox.Show($"{game.Players[i].Name} nyerte a leget!");

        //    //NOT YET IMPLEMENTED
        //    //Stats.Kiszallo(i, game); //kiszálló dartsok számát intézi, megkell adni melyik playerre, melyik gamere

        //    game.Players[i].LegsWon += 1;

        //    //Átlag számolások
        //    //Stats.AvgLeg(i, this); NOT YET IMPLEMENTED

        //    game.PointReset(); //Mindenki pontjának visszaállítása, mindig lefut kör végén, elég egyszer nullázni ezért
        //}

        //private void GameEnd(int winner)
        //{
        //    MessageBox.Show($"{game.Players[winner].Name} nyerte a játékot. GG!");

        //    //Console.WriteLine("\nÚj játék? Y/N"); //Ugyanezekkel az emberekkel + szabályokkal egyelőre
        //    //string newgame = Console.ReadLine();
        //    //switch (newgame)
        //    //{
        //    //    case "Y":
        //    //    case "y":
        //    //        Console.Clear();
        //    //        game.GameReset();
        //    //        break;

        //    //    case "N":
        //    //    case "n":
        //    //        Console.Clear();
        //    //        //SaveGame();
        //    //        Environment.Exit(0);
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("Adjon meg valós lehetőséget");
        //    //        GameEnd(winner);
        //    //        break;
        //    //}
        //}
    }
}
