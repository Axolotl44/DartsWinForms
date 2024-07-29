using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DartsDotNetFrameWork
{
    public class Player
    {
        private string name;
        private int point;
        private int legsWon;
        private int setsWon;
        private int numOfThrows;
        private List<int> pointsThrown;
        private Dictionary<string, double> stats;
        //private bool winner; nem feltétlen kell, mehet esetleg statsba {"winner", 1/0}

        public string Name 
        {
            get { return name; }
        } 
        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        public int LegsWon
        {
            get { return legsWon; }
            set { legsWon = value; }
        }
        public int SetsWon
        {
            get { return setsWon; }
            set { setsWon = value; }
        }
        public int NumOfThrows
        {
            get { return numOfThrows; }
            set { numOfThrows = value; }
        }
        public List<int> PointsThrown
        {
            get { return pointsThrown; }
        }

        public Dictionary<string, double> Stats
        {
            get { return stats; }
            set { stats = value; }
        }

        public Player(string name, Game g)
        {
            this.name = name;
            point = g.PointsToLeg;
            legsWon = 0;
            setsWon = 0;
            numOfThrows = 0;
            pointsThrown = new List<int>();
            stats = new Dictionary<string, double>()
            {
                {"legAvg", 0 },
                {"oneDartAvg", 0 },
                {"180", 0 },
                {"egyéb", 0 }
            };
        }

        [JsonConstructor]
        public Player(string name)
        {
            this.name = name;
            point = 0;
            legsWon = 0;
            setsWon = 0;
            numOfThrows = 0;
            pointsThrown = new List<int>();
            stats = new Dictionary<string, double>()
            {
                {"legAvg", 0 },
                {"oneDartAvg", 0 },
                {"180", 0 },
                {"egyéb", 0 }
            };
        }

    }
}
