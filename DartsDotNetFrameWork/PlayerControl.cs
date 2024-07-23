using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsDotNetFrameWork
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
            currentPlayer.Hide();
            label4.Hide();
            ControlLabelCheckOut.Hide();
        }

        private string nameP;
        private string pointP;
        private string legP;
        private string setP;
        private string outP;
        public string NameP
        {
            get { return nameP; }
            set { nameP = value; ControlLabelName.Text = value; }
        }

        public string PointP
        {
            get { return pointP; }
            set { pointP = value; ControlLabelPoint.Text = value; }
        }

        public string LegP
        {
            get { return legP; }
            set { legP = value; ControlLabelLeg.Text = value; }
        }

        public string SetP
        {
            get { return setP; }
            set { setP = value; ControlLabelSet.Text = value; }
        }

        public string OutP
        {
            get { return outP; }
            set { outP = value; ControlLabelCheckOut.Text = value; }
        }

        public void SetCurrentPlayer()
        {
            currentPlayer.Show();
        }
        public void NotCurrentPlayer()
        {
            currentPlayer.Hide();
        }
        public void CheckOutPossible()
        {
            label4.Show();
            ControlLabelCheckOut.Show();
        }
        public void CheckOutNotPossible()
        {
            label4.Hide();
            ControlLabelCheckOut.Hide();
        }

    }
}
