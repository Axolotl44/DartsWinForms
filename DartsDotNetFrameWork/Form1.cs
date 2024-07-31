using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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
            DialogResult res = openFileDialog1.ShowDialog();
            
            if( res == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string data = File.ReadAllText(file);

                //filterelve van, csak json filet tud olvasni, DE később kell check, hogy game szempontból értelmezhető-e a file
                Game game = JsonConvert.DeserializeObject<Game>(data);

                GameControl gameControl = new GameControl(game);
                MainControl.ShowControl(gameControl, MainContent);
            }  
        }



    }
}
