using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsDotNetFrameWork
{
    internal static class Stats //TO BE UPDATED
    {
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
