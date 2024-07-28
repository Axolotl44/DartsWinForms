using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsDotNetFrameWork
{
    public partial class GameControl : UserControl
    {
        private Game game;
        private bool saveGame;
        public GameControl(Game game, bool saveGame)
        {
            InitializeComponent();
           
            this.game = game;
            this.saveGame = saveGame;

            CreatePlayerControls(); //első kiemelését is megcsinálja

            CurrentRoundLabelSetter();

            NewGamePanel.Hide();
            kiszalloPanel.Hide();

            this.ActiveControl = textBox1;
        }

        PlayerControl[] playerControls;
        private void CreatePlayerControls()
        {
            playerControls = new PlayerControl[game.NumOfPlayers];

            for (int i = 0; i < playerControls.Length; i++)
            {
                playerControls[i] = new PlayerControl()
                {
                    NameLabel = $"{game.Players[i].Name}",
                    PointLabel = $"{game.Players[i].Point}",

                    //kezdéskor 0
                    LegLabel = "0",
                    SetLabel = "0"
                };
                flowLayoutPanel1.Controls.Add(playerControls[i]);  
            }
            //első játékos kezd, őt kiemeljük
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
                MessageBox.Show("Adj meg értéket");
                return;
            }
            if (int.TryParse(textBox1.Text, out dobottSzam)) //szám-e check
            {
                if (dobottSzam > 180 || dobottSzam < 0) //valós dobás check
                {
                    MessageBox.Show("Cheater, dobj újra");
                    textBox1.Clear();
                    return;
                }
                if (dobottSzam > game.Players[currentPlayer].Point) //ha nagyobbat dobna mint amennyi pontja van
                {
                    MessageBox.Show("Nagyobbat dobtál mint amennyi pontod volt");
                    textBox1.Clear();
                    return;
                }
                //helyes bemenet, levonjuk a current playertől
                textBox1.Clear();
                ThrowExtra(dobottSzam, currentPlayer);

                //async method, ezutánik lefutnak, míg checkout gombnyomásra vár
                CheckAll(currentPlayer); 

                //dobás után számoljuk a soron következőt és kiemeljük
                currentPlayer = CurrentPlayerCalc();
                CurrentPlayerEmphasize(currentPlayer);
            }
            else //van érték beírva, de nem szám
            {
                MessageBox.Show("Valós értéket adj meg");
                textBox1.Clear();
            }
        }

        int legStarterPlayer = 0;
        int setStarterPlayer = 0;
        bool playerWonLeg = false;
        bool playerWonSet = false;
        private int CurrentPlayerCalc()
        {
            //LEHET, HOGY NEM TELJESEN JÓ. ÁTKELL NÉZNI A SET WINT
            if (playerWonSet) //fordított sorrendben először a set kezdőt kell megnézni
            {
                playerWonSet = false;
                playerWonLeg = false;

                if (setStarterPlayer < game.NumOfPlayers - 1)
                { setStarterPlayer++; }
                else
                { setStarterPlayer = 0; }

                currentPlayer = setStarterPlayer;
                return currentPlayer;
            }
            else if (playerWonLeg) //ha player nyert leget, de nem nyert setet
            {
                playerWonLeg = false;

                if (legStarterPlayer < game.NumOfPlayers - 1)
                { legStarterPlayer++; }
                else
                { legStarterPlayer = 0; }

                currentPlayer = legStarterPlayer;
                return currentPlayer;
            }
            else //ha player még nem nyert leget, sem szetet
            {
                if (currentPlayer < game.NumOfPlayers - 1)
                { currentPlayer++; }
                else
                { currentPlayer = 0; }

                return currentPlayer;
            }
        }

        private void ThrowExtra(int pointThrown, int currentP) //valós megadott dobott számra, adott jelenlegi playerre
        {
            game.Players[currentP].Point -= pointThrown;
            game.Players[currentP].PointsThrown.Add(pointThrown); //egybe 3 dobás pontja
            game.Players[currentP].NumOfThrows += 3;

            playerControls[currentP].PointLabel = $"{game.Players[currentP].Point}";

            //ha lehet, checkout lehetőség kiírás
            if (game.Players[currentP].Point <= 170)
            {
                try
                {
                    playerControls[currentP].CheckoutLabel = CheckOut.Checkout(game.Players[currentP].Point);
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("elkúrtam a kiszállókat");
                    return;
                }
                playerControls[currentP].CheckOutPossible(); //megjeleníti a checkout lehetőség labelt
            }
        }

        private async void CheckAll(int currentP)
        {
            if (game.Players[currentP].Point == 0) //Leg win
            {
                //üzenet
                MessageBox.Show($"{game.Players[currentP].Name} nyerte a leget!");

                //számolás+logika
                game.Players[currentP].LegsWon++;
                playerWonLeg = true;

                //controlra való kiírás
                playerControls[currentP].LegLabel = $"{game.Players[currentP].LegsWon}";

                //kiszálló dartsok számának számolása; 100 alatt, kivéve 99, lehet csak kevesebb mint 3-al kiszállni
                if (game.Players[currentP].PointsThrown.Last() < 100 && game.Players[currentP].PointsThrown.Last() != 99)
                {
                    kiszalloPanel.Show();
                    ThrowPanel.Enabled = false;

                    //megkell várni míg megadja mennyiből szállt ki
                    //CheckAll async, ezért amíg erre vár, addig ThrownNumHandler tovább megy, újraszámol
                    //ezért külön elkell menteni hogy újraszámolás előtti playerre vonja le a checkoutot
                    checkoutPlayer = currentP; 
                    await buttonPressed.Task;

                    //gombnyomás után létrehoz egy új példányt ugyanazon a változón, így újból működik (vagymi)
                }
                //3 dartos kiszállók esetén csak továbbmegyünk

                //MENTÉS HELYE
                LegEndStats();

                if (saveGame) //playersStart checkboxa alapján
                {
                    FileHandler.SavePlayer(game.Players[currentP], "playerTeszt");
                    FileHandler.SaveGame(game, "gameTeszt");
                }

                //pontok, checkout visszaállítása, előtte kell menteni
                PointReset();
                CheckoutLabelReset();

                //current round label számolás
                currentLeg++;
            }
            if (game.Players[currentP].LegsWon == game.LegToSet) //Set win
            {
                //üzenet
                MessageBox.Show($"{game.Players[currentP].Name} nyerte a setet!");

                //számolás+logika
                game.Players[currentP].SetsWon++;
                playerWonSet = true;

                //controlra való kiírás
                playerControls[currentP].SetLabel = $"{game.Players[currentP].SetsWon}";

                //pontok, checkout visszaállítása //pontok már ezelőtt visszalettek
                LegReset();

                //current round label számolás
                currentSet++;
                currentLeg = 1;
            }
            if (game.Players[currentP].SetsWon == game.SetToWin) //GAME WIN
            {
                Player gameWinner = game.Players[currentP];
                gameWinner.Winner = true;
                MessageBox.Show($"{gameWinner.Name} nyerte a gamet!");
                gameWinnerLabel.Text = $"{gameWinner.Name} nyert!";

                //GAME RESET/GAME END
                ThrowPanel.Hide();
                NewGamePanel.Show();
                return;
            }

            CurrentRoundLabelSetter();
        }


        private void PointReset() //nyert leg után visszaállítja a pontokat és labelt
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                game.Players[i].Point = game.PointsToLeg;
                game.Players[i].PointsThrown.Clear();
                game.Players[i].NumOfThrows = 0;

                playerControls[i].PointLabel = $"{game.PointsToLeg}";
            }
        }
        private void LegReset() //csak a legeket állítja vissza
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                game.Players[i].LegsWon = 0;

                playerControls[i].LegLabel = "0";
            }
        }
        private void SetReset() //csak a seteket állítja vissza
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                game.Players[i].SetsWon = 0;

                playerControls[i].SetLabel = "0";
            }
        }
        private void GameReset() //mindent resetel, biztosabb így
        {
            currentPlayer = 0;
            legStarterPlayer = 0;
            setStarterPlayer = 0;
            playerWonLeg = false; 
            playerWonSet = false;

            PointReset();
            LegReset();
            SetReset();
            CheckoutLabelReset();
            
            CurrentPlayerEmphasize(0);
            currentLeg = 1;
            currentSet = 1;
            CurrentRoundLabelSetter();

            ThrowPanel.Show();
            NewGamePanel.Hide();       
        }
        private void CheckoutLabelReset() //checkout label eltüntetés
        {
            for (int i = 0; i < game.NumOfPlayers; i++)
            {
                playerControls[i].CheckOutNotPossible();
            }
        }


        private void CurrentPlayerEmphasize(int currentP)
        {
            playerControls[currentP].SetCurrentPlayer(); //current kiemelés
            //FIX NEEDED, hogy középre scrollolja
            flowLayoutPanel1.ScrollControlIntoView(playerControls[currentP]);

            for (int c = 0; c < game.NumOfPlayers; c++)
            {
                if (c != currentP)
                {
                    playerControls[c].NotCurrentPlayer(); //nem current kiemelés eltüntetés
                }
            }
        }
        int currentLeg = 1;
        int currentSet = 1;
        private void CurrentRoundLabelSetter()
        {
            CurrentRoundLabel.Text = $"{currentSet}.Set {currentLeg}.Leg";
        }


        //game end gombok
        private void button2_Click(object sender, EventArgs e) //IGEN ÚJ GAME
        {
            GameReset();
        }

        private void button3_Click(object sender, EventArgs e) //NEM, BEZÁR
        {
            Environment.Exit(0);
        }

        //Kiszállók
        private TaskCompletionSource<bool> buttonPressed = new TaskCompletionSource<bool>();
        private int checkoutPlayer; //azért kell, mert újraszámolódna gombnyomás előtt, így meg ok
        private void outButton_Click(object sender, EventArgs e)
        {
            if (sender == outInOneButton)
            {
                game.Players[checkoutPlayer].NumOfThrows -= 2;

            }
            else if (sender == outInTwoButton)
            {
                game.Players[checkoutPlayer].NumOfThrows -= 1;

            }
            //egyéb esetben a sender az outInThreeButton, ahol nemkell levonni
            
            //minden esetben kell
            kiszalloPanel.Hide();
            ThrowPanel.Enabled = true;

            //gomb meglett nyomva, erre vár a CheckALL
            buttonPressed.SetResult(true);
            buttonPressed = new TaskCompletionSource<bool>(); //új task létrehozás, hogy újból lehessen ellenőrizni
        }

        private void LegEndStats()
        {
            //bemenetként kell a leg winner, aki a current player, mert utána hívódik meg ez
            Stats.LegAvg(game.Players[currentPlayer], game);
            Stats.OneDartAvg(game);
        }

    }
}
