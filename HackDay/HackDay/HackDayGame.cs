using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackDay
{
    public partial class HackDayGame : UserControl
    {
        public HackDayGame()
        {
            InitializeComponent();
        }

        private void HackDayGame_Load(object sender, EventArgs e)
        {
            // Setting the scene. Displaying the number of rounds, player name etc.
            // Getting the number of rounds from GameData script
            int rounds = GameData.numberOfRounds;
            Lbl_Round.Text = "Round\n1 of " + rounds;

            // Getting the player's name from GameData script
            string player = GameData.playerName;
            if (player == "" || player == null)
                player = "Player";

            // Displaying player's name
            Lbl_PlayerScore.Text = player + "\n 0";

            // Hiding 'Next Round' button
            Btn_NxtRound.Hide();
        }

        // Rock button
        private void Btn_Rock_Click(object sender, EventArgs e)
        {
            Lbl_PlayerSelection.Text = "Rock";
        }

        // Paper button
        private void Btn_Paper_Click(object sender, EventArgs e)
        {
            Lbl_PlayerSelection.Text = "Paper";
        }

        // Scissors button
        private void Btn_Scissors_Click(object sender, EventArgs e)
        {
            Lbl_PlayerSelection.Text = "Scissors";
        }

        // Lizard button
        private void Btn_Lizard_Click(object sender, EventArgs e)
        {
            Lbl_PlayerSelection.Text = "Lizard";
        }

        // Spock button
        private void Btn_Spock_Click(object sender, EventArgs e)
        {
            Lbl_PlayerSelection.Text = "Spock";
        }
    }
}
