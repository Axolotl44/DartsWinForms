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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Betölti a gameRules usercontrolt
            GameRulesControl gameRulesControl = new GameRulesControl();
            MainControl.ShowControl(gameRulesControl, MainContent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Még nem elérhető");
        }

    }
}
