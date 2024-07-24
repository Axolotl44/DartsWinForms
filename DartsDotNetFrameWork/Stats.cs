using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsDotNetFrameWork
{
    internal static class Stats //TO BE UPDATED
    {
        //public static void Kiszallo(int player, Game g) //a throw fucntion 3 dobást ad hozzá már ez előtt fixen, úgyhogy kivonja inkább; 99 és 101től csak 3-mal lehet kiszállni
        //{
        //    Player p = g.Players[player];
        //    //pointsThrownban az utolsó elem a most dobott szám
        //    if (!(p.PointsThrown.Last() > 100 || p.PointsThrown.Last() == 99))
        //    {
        //        Console.WriteLine("\nKiszállás: 1/2/3?");
        //        int outIn = int.Parse(Console.ReadLine());
        //        switch (outIn)
        //        {
        //            case 1:
        //                p.NumOfThrows -= 2;
        //                break;

        //            case 2:
        //                p.NumOfThrows -= 1;
        //                break;

        //            case 3:
        //                break;

        //            default:
        //                Console.WriteLine("\nAdjon meg valós értéket");
        //                Kiszallo(player, g);
        //                break;
        //        }
        //    }
        //}

        ////(501 – point left) / Darts Thrown: kör közben
        ////(501 / Darts Thrown) x 3: kör vége ha nyert
        ////(501 – point Left) / Darts Thrown x 3: kör végén a loseolt
        ////(point / Darts Thrown) 1-dart average
        //public static void AvgLeg(int player, Game g) //1 leg átlaga
        //{
        //    Player p = g.Players[player];

        //    if (p.Point == 0) //winner átlaga
        //    {
        //        double avgWin = (g.PointsToLeg / p.NumOfThrows) * 3;
        //        Console.WriteLine($"\n{p.Name} átlag dobása: {Math.Round(avgWin, 2)}");
        //    }
        //    else //loser átlaga, egyelőre unused. A game logic miatt, csak a winner hívja meg
        //    {
        //        double avgLose = (g.PointsToLeg - p.Point) / p.NumOfThrows * 3;
        //        Console.WriteLine($"\n{p.Name} átlag dobása: {Math.Round(avgLose, 2)}");
        //    }
        //}

        //public static void OneDartAvg(int player, Game g)
        //{
        //    Player p = g.Players[player];

        //    double avgOne = (g.PointsToLeg - p.Point) / p.NumOfThrows;
        //    Console.WriteLine($"\n{p.Name} 1-dart átlaga: {Math.Round(avgOne),2}");
        //}


    }
}
