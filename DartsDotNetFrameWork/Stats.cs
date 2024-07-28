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

        public static void LegAvg(Player legWinner, Game g) //1 leg átlaga mindenkinek
        {
            double avg;
            for (int i = 0; i < g.NumOfPlayers; i++)
            {
                if (g.Players[i] == legWinner) //winner átlaga
                {
                    avg = (g.PointsToLeg / legWinner.NumOfThrows) * 3;
                    legWinner.LegAvg = Math.Round(avg, 3);

                }
                else //többiek átlaga
                {
                    avg = (g.PointsToLeg - g.Players[i].Point) / g.Players[i].NumOfThrows * 3;
                    g.Players[i].LegAvg = Math.Round(avg, 3);
                }
            }
        }

        public static void OneDartAvg(Game g)
        {
            for (int i = 0; i < g.NumOfPlayers;i++)
            {
                double oneAvg = (g.PointsToLeg - g.Players[i].Point) / g.Players[i].NumOfThrows;
                g.Players[i].OneDartAvg = Math.Round(oneAvg, 3);
            }
        }





    }
}
