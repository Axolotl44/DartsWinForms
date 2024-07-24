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
        private int pointsToLeg;
        private int legToSet; //egyelőre first to reach, később best of is
        private int setToWin; //same ^
        private int numOfPlayers;
        private List<Player> players;

        public int PointsToLeg { get { return pointsToLeg; } } 
        public int LegToSet { get { return legToSet; } }
        public int SetToWin { get { return setToWin; } }
        public int NumOfPlayers { get { return numOfPlayers; } }
        public List<Player> Players { get { return players; } }

        public Game(int pointsToLeg, int legToSet, int setToWin, int numOfPlayers)
        {
            this.pointsToLeg = pointsToLeg;
            this.legToSet = legToSet;
            this.setToWin = setToWin;
            this.numOfPlayers = numOfPlayers;
            players = new List<Player>();
        }

    }
}
