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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Checking if the player name is saved
            if(GameData.playerName != "" && GameData.playerName != null)
            {
                TxtBox_Name.Text = GameData.playerName;
            }
        }

        // Instructions button
        private void Btn_Instructions_Click(object sender, EventArgs e)
        {
            // Create new instructions controls
            Instructions instructions = new Instructions();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add instructions control to the form
            instructions.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(instructions);
        }

        // 1 round button
        private void Btn_RoundsNumber1_Click(object sender, EventArgs e)
        {
            // Set the amount of rounds in GameData script
            GameData.numberOfRounds = 1;
            // Create new game controls
            HackDayGame hackDayGame = new HackDayGame();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add game controls to the form
            hackDayGame.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(hackDayGame);
        }

        // 3 rounds button
        private void Btn_RoundsNumber3_Click(object sender, EventArgs e)
        {
            // Set the amount of rounds in GameData script
            GameData.numberOfRounds = 3;
            // Create new game controls
            HackDayGame hackDayGame = new HackDayGame();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add game controls to the form
            hackDayGame.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(hackDayGame);
        }

        // 5 rounds button
        private void Btn_RoundsNumber5_Click(object sender, EventArgs e)
        {
            // Set the amount of rounds in GameData script
            GameData.numberOfRounds = 5;
            // Create new game controls
            HackDayGame hackDayGame = new HackDayGame();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add game controls to the form
            hackDayGame.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(hackDayGame);
        }

        // Quit button
        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBox_Name_TextChanged(object sender, EventArgs e)
        {
            GameData.playerName = TxtBox_Name.Text;
        }
    }
}
