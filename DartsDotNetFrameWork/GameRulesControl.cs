using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DartsDotNetFrameWork
{
    public partial class GameRulesControl : UserControl
    {
        private static int gameType;
        private static int leg;
        private static int set;
        private static int numP;
        public GameRulesControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //van-e érték beírva mindenhova check
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Tölts ki minden adatot");
                return;
            }
            //szám-e mindegyik check
            if (int.TryParse(textBox1.Text, out leg) && int.TryParse(textBox2.Text, out set) && int.TryParse(textBox3.Text, out numP))
            {
                gameType = int.Parse(comboBox1.Text);
                PlayersStartControl teszt = new PlayersStartControl(gameType, leg, set, numP);
                MainControl.ShowControl(teszt, GameStartContent);
            }
            //mindenhol van érték beírva, de nem szám
            else
            {
                MessageBox.Show("Valós adatot adj meg");
            }   
        }



    }
}
