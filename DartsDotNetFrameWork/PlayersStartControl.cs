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
    public partial class PlayersStartControl : UserControl
    {
        private Game game; //első példány
        private int counter = 1;
        public PlayersStartControl(int gameType, int leg, int set, int numOfPlayers)
        {
            InitializeComponent();

            gameStartButton.Hide();

            gameTypeLabel.Text += $" {gameType}";
            legLabel.Text += $" {leg}";
            setLabel.Text += $" {set}";
            label5.Text = $"{counter}.játékos neve:";

            game = new Game(gameType, leg, set, numOfPlayers);
        }

        //régi consoleos playersStart method megvalósítása (lefutás után updatelődik a label)
        private void button1_Click(object sender, EventArgs e)
        {
            Player tmp;
            ++counter;
            if(counter <= game.NumOfPlayers)
            {
                label5.Text = $"{counter}.játékos neve:";

                tmp = new Player(playerNameInput.Text, game);
                game.Players.Add(tmp);

                playersListBox.Items.Add($"{counter - 1}. {tmp.Name}");
                playerNameInput.Clear();
            }
            else if(counter == game.NumOfPlayers + 1)
            {
                tmp = new Player(playerNameInput.Text, game);
                game.Players.Add(tmp);

                playersListBox.Items.Add($"{counter - 1}. {tmp.Name}");
                playerNameInput.Clear();

                label5.Hide();
                gameStartButton.Show();
            }
        }

        //Maga a játék felület betöltése; csak minden adat helyes megadása után jelenik meg a gomb
        //button3 = gameStartButton, később ha érdekel átnevezni mindenhol
        private void button3_Click(object sender, EventArgs e)
        {
            GameControl gameControl = new GameControl(game);
            MainControl.ShowControl(gameControl, MagaAGame);
        }

    }
}
