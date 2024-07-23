using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name 
        { 
            get => name; //nem szeretem ezt a fajta írásmódot, de tanultuk, úgyhogy mintának itt így lesz
        } 
        public int Point
        {
            get => point;
            set => point = value;
        }
        public int LegsWon
        {
            get => legsWon;
            set => legsWon = value;
        }
        public int SetsWon
        {
            get => setsWon;
            set => setsWon = value;
        }
        public int NumOfThrows
        {
            get => numOfThrows;
            set => numOfThrows = value;
        }
        public List<int> PointsThrown
        {
            get => pointsThrown;
        }

        public Player(string name, Game g)
        {
            this.name = name;
            point = g.PointToWin;
            legsWon = 0;
            setsWon = 0;
            numOfThrows = 0;
            pointsThrown = new List<int>();
        }

        //[JsonConstructor]
        //public Player(string name)
        //{
        //    this.name = name;
        //    point = 0;
        //    legsWon = 0;
        //    setsWon = 0;
        //    numOfThrows = 0;
        //    pointsThrown = new List<int>();
        //}


        //public void Thorw(int pointThrown)
        //{
        //    point -= pointThrown;
        //    pointsThrown.Add(pointThrown); //egybe 3 dobás pontja

        //    numOfThrows += 3;

        //    //Console.WriteLine($"Maradt: {point}");
        //    //if (point <= 170 && point > 0)
        //    //{
        //        //Console.WriteLine("Kiszállás:");
        //        //CheckPoint.Checkout(point); NOT YET IMPLEMENTED
        //    //}
        //}



    }
}
