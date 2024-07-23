using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsDotNetFrameWork
{
    public class Game
    {
        private int pointToWin;
        private int legToSet; //egyelőre first to reach, később best of
        private int setToWin; //same ^
        private int numOfPlayers;
        private List<Player> players;

        public int PointToWin { get { return pointToWin; } } 
        public int LegToSet { get { return legToSet; } }
        public int SetToWin { get { return setToWin; } }
        public int NumOfPlayers { get { return numOfPlayers; } }
        public List<Player> Players { get { return players; } }

        public Game(int pointsToWin, int legToSet, int setToWin, int numOfPlayers)
        {
            pointToWin = pointsToWin;
            this.legToSet = legToSet;
            this.setToWin = setToWin;
            this.numOfPlayers = numOfPlayers;
            players = new List<Player>();
        }

        //public void NewGameStart() //MAGA A GAME
        //{
        //    //PlayersStart(); Megvalósítva

        //    while (!playerWonGame)
        //    {
        //        Leg();
        //    }
        //}

        //MEGVALÓSÍTVA
        //public void PlayersStart()
        //{
        //    for (int i = 0; i < numOfPlayers; i++)
        //    {
        //        //Console.WriteLine($"{i + 1}. játékos neve: ");
        //        players.Add(new Player(Console.ReadLine(), this));
        //    }
        //    //Console.Clear();
        //}

        //GAME LOGIC #JÓVANAZÚGY
        //int currentLeg = 1;
        //int currentSet = 1;

        //int legStarterPlayer = 0;
        //int setStarterPlayer = 0;

        //bool playerWonLeg = false;
        //bool playerWonGame = false;
        //private void Leg() //1db leg, mindig a soron következő kezdésével loopolva a dobások, addig megy amíg nem nyeri valaki a leget, setWint,GameWint ellenőriz
        //{
        //    playerWonLeg = false;

        //    while (!playerWonLeg) //x.játékos kezdi a kört, addig megyünk amíg valaki nem nyerte a leget
        //    {
        //        for (int i = legStarterPlayer; i < numOfPlayers; i++)
        //        {
        //            //
        //            //Console.WriteLine($"{players[i].Name} dobása: ");
        //            //
        //            //players[i].Thorw(int.Parse(Console.ReadLine()));

        //            if (players[i].Point <= 0) //LEG nyerés ellenőrzés
        //            {
        //                NyertLeg(i); //Mindenki pontjának visszaállítása (többek között)

        //                if (players[i].LegsWon == legToSet) //SET nyerés ellenőrzés
        //                {
        //                    //
        //                    //Console.WriteLine($"\n{players[i].Name} nyerte a setet!");
        //                    //

        //                    players[i].SetsWon++;

        //                    if (players[i].SetsWon == setToWin) //WIN ellenőrzés
        //                    {
        //                        playerWonGame = true;
        //                        GameEnd(i);

        //                        break;
        //                    }
        //                    else
        //                    {
        //                        if (setStarterPlayer < numOfPlayers) { setStarterPlayer++; } //külön változó menti a setkezdő játékost

        //                        else { setStarterPlayer = 0; }

        //                        legStarterPlayer = setStarterPlayer; //ezzel elvileg jó
        //                        LegReset(); //csak a legek számát állítja vissza 0-ra

        //                        //RoundEndConsoleClear();

        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    if (legStarterPlayer < numOfPlayers) { legStarterPlayer++; } //LEG első dobása átadása a következő playernek

        //                    else { legStarterPlayer = 0; }

        //                    //RoundEndConsoleClear();

        //                    break;
        //                }
        //            }
        //            else 
        //            { 
        //                //
        //                //Console.WriteLine();
        //            } //dobásonként üres sor hogy olvasható legyen
        //        }

        //        if (legStarterPlayer != 0 && !playerWonLeg) //végigkell menni az x. előtti maradék játékoson is
        //        {
        //            for (int j = 0; j < legStarterPlayer; j++)
        //            {
        //                Console.WriteLine($"{players[j].Name} dobása: ");
        //                //players[j].Thorw(int.Parse(Console.ReadLine()));

        //                if (players[j].Point <= 0) //LEG nyerés ellenőrzés
        //                {
        //                    NyertLeg(j); //Mindenki pontját visszaállítása (többet között)

        //                    if (players[j].LegsWon == legToSet) //SET nyerés ellenőrzés
        //                    {
        //                        Console.WriteLine($"\n{players[j].Name} nyerte a setet!");
        //                        players[j].SetsWon++;

        //                        if (players[j].SetsWon == setToWin) //WIN ellenőrzés
        //                        {
        //                            playerWonGame = true;
        //                            GameEnd(j);

        //                            break;
        //                        }
        //                        else
        //                        {
        //                            if (setStarterPlayer < numOfPlayers) { setStarterPlayer++; } //külön változó menti a setkezdő játékost

        //                            else { setStarterPlayer = 0; }

        //                            legStarterPlayer = setStarterPlayer; //ezzel elvileg jó
        //                            LegReset(); //csak a legek számát állítja vissza 0-ra

        //                            //RoundEndConsoleClear();

        //                            break;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (legStarterPlayer < numOfPlayers) { legStarterPlayer++; }//LEG első dobása átadása a következő playernek

        //                        else { legStarterPlayer = 0; }

        //                        //RoundEndConsoleClear();

        //                        break;
        //                    }
        //                }
        //                else { Console.WriteLine(); } //dobásonként üres sor hogy olvasható legyen
        //            }
        //        }
        //    }
        //}

        //private void NyertLeg(int i) //adhatnék playert is bemenetként de így most egyszerűbb volt
        //{
        //    playerWonLeg = true;

        //    //
        //    //Console.WriteLine($"\n{players[i].Name} nyerte a leget!");
        //    //

        //    //Stats.Kiszallo(i, this); //kiszálló dartsok számát intézi, megkell adni melyik playerre, melyik gamere, ez a game a this NOT YET IMPLEMENTED

        //    players[i].LegsWon += 1;

        //    //Átlag számolások
        //    //Stats.AvgLeg(i, this); NOT YET IMPLEMENTED

        //    PointReset(); //Mindenki pontjának visszaállítása, mindig lefut kör végén, elég egyszer nullázni ezért
        //}

        //private void RoundEndConsoleClear()
        //{
        //    Console.WriteLine("\nPress enter to continue...");
        //    Console.ReadLine();
        //    Console.Clear();
        //}

        //public void PointReset() //nyert leg után
        //{
        //    for (int i = 0; i < numOfPlayers; i++)
        //    {
        //        players[i].Point = pointToWin;
        //        players[i].PointsThrown.Clear();
        //        players[i].NumOfThrows = 0;
        //    }
        //}

        //public void LegReset() //nyert set után, csak a nyert legeket állítja vissza
        //{
        //    for (int i = 0; i < numOfPlayers; i++)
        //    {
        //        players[i].LegsWon = 0;
        //    }
        //}

        //public void GameReset() //mindent resetel, jobb így
        //{
        //    legStarterPlayer = 0;
        //    setStarterPlayer = 0;
        //    playerWonLeg = false; //kör elején amúgy false lesz, de biztosabb ez
        //    playerWonGame = false;

        //    for (int i = 0; i < numOfPlayers; i++)
        //    {
        //        players[i].Point = pointToWin;
        //        players[i].LegsWon = 0;
        //        players[i].SetsWon = 0;
        //        players[i].NumOfThrows = 0;
        //        players[i].PointsThrown.Clear();
        //    }
        //}

        //private void GameEnd(int winner)
        //{
        //    //Console.WriteLine($"\n{players[winner].Name} nyerte a játékot!");
        //    MessageBox.Show($"{players[winner].Name} nyerte a játékot. GG!");
        //    Console.WriteLine("\nÚj játék? Y/N"); //Ugyanezekkel az emberekkel + szabályokkal egyelőre
        //    string newgame = Console.ReadLine();
        //    switch (newgame)
        //    {
        //        case "Y":
        //        case "y":
        //            Console.Clear();
        //            //GameReset();
        //            break;

        //        case "N":
        //        case "n":
        //            Console.Clear();
        //            //SaveGame();
        //            Environment.Exit(0);
        //            break;

        //        default:
        //            Console.WriteLine("Adjon meg valós lehetőséget");
        //            GameEnd(winner);
        //            break;
        //    }
        //}


        //NOT YET IMPLEMENTED
        //private void SaveGame()
        //{
        //    Console.WriteLine("Menti a játékot? Y/N");
        //    string savegame = Console.ReadLine();

        //    switch (savegame)
        //    {
        //        case "Y":
        //        case "y":
        //            //FileHandler.SaveGame(this, "gameData"); NOT YET IMPLEMENTED
        //            break;

        //        case "N":
        //        case "n":
        //            break;

        //        default:
        //            Console.WriteLine("Adjon meg valós lehetőséget");
        //            SaveGame();
        //            break;
        //    }
        //}



    }
}
