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
        private int currentRound = 1; // used to display current round
        private int pointsToWin = 0;  // used to determine how many points are needed to win the game
        private int playerPoints = 0; // used to determine the number of points the player has
        private int computerPoints = 0; // used to determine the number of points the computer has

        private string playerName = ""; // used to determine the player's name
        private string[] gestures = { "Rock", "Paper", "Scissors", "Lizard", "Spock" }; // used to generate random gesture from the computer
        private List<Button> gestureButtons; // holds all the gesture buttons to make it easier to perform actions on them

        private bool ableToClickNxtRound = false; // used for the purpose of making the 'Next Round' button active or not
        private bool ableToClickGesture = true; // used for the  purpose of making gesture button active or not

        public HackDayGame()
        {
            InitializeComponent();
        }

        // Setting the scene. Displaying the number of rounds, player name etc.
        private void HackDayGame_Load(object sender, EventArgs e)
        {
            // Getting the number of points to win from GameData script and displaying it
            pointsToWin = GameData.pointsToWin;
            if(pointsToWin == 1)
                Lbl_PointsToWin.Text = "Playing to 1 point.";
            else
            Lbl_PointsToWin.Text = "Playing to " + pointsToWin + " points.";

            // Erasing winner texts as they have default text for visual purposes
            Lbl_RoundWinner.Text = "";
            Lbl_GameWinner.Text = "";
            Lbl_GameWinner.Hide(); // this text needs to be hidden as it will display on top of the buttons

            // Getting the player's name from GameData script
            playerName = GameData.playerName;
            if (playerName == "" || playerName == null)
                playerName = "Player";

            // Displaying player's name
            Lbl_PlayerScore.Text = playerName + "\n 0";

            // Changing 'Next Round' button color to 'inactive'
            Btn_NxtRound.BackColor = SystemColors.ControlLight;

            // Storing all gesture buttons in List
            gestureButtons = new List<Button>();
            gestureButtons.Add(Btn_Rock);
            gestureButtons.Add(Btn_Paper);
            gestureButtons.Add(Btn_Scissors);
            gestureButtons.Add(Btn_Lizard);
            gestureButtons.Add(Btn_Spock);
        }

        // 'Rock' button click
        private void Btn_Rock_Click(object sender, EventArgs e)
        {
            CalculateRoundWinner("Rock");
        }

        // 'Paper' button click
        private void Btn_Paper_Click(object sender, EventArgs e)
        {
            CalculateRoundWinner("Paper");
        }

        // 'Scissors' button click
        private void Btn_Scissors_Click(object sender, EventArgs e)
        {
            CalculateRoundWinner("Scissors");
        }

        // 'Lizard' button click
        private void Btn_Lizard_Click(object sender, EventArgs e)
        {
            CalculateRoundWinner("Lizard");
        }

        // 'Spock' button click
        private void Btn_Spock_Click(object sender, EventArgs e)
        {
            CalculateRoundWinner("Spock");
        }

        // 'Next Round' button click
        private void Btn_NxtRound_Click(object sender, EventArgs e)
        {
            if(ableToClickNxtRound)
                NewRound();
        }

        // 'Play Again' button click
        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }

        // 'End Game' button click
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            // Create new menu controls
            MainMenu mainMenu = new MainMenu();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add game controls to the form
            mainMenu.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(mainMenu);
        }

        // Reseting the whole game
        private void PlayAgain()
        {
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

        // Generating random gesture from the computer
        private string ComputerGesture()
        {
            Random random = new Random();
            // Generating random number (from 0 to array length - 1)
            int gestureNumber = random.Next(gestures.Length);

            // Returning the randomly chosen gesture string
            return gestures[gestureNumber];
        }

        // Calculating and displaying the round winner based on player's selection
        private void CalculateRoundWinner(string playerGesture)
        {
            // If the player didn't get to the next round first he won't be able to click the gesture button
            if (ableToClickGesture == false)
                return;

            // Getting computer's gesture
            string computerGesture = ComputerGesture();

            // Creating variables to store the winner and winning conditions / statements
            string winner = "";
            string winningCondition = "";

            // Displaying what gesture player chose for clarification
            Lbl_PlayerSelection.Text = playerGesture;

            // Displaying what gesture was generated for the computer for clarification
            Lbl_ComputerSelection.Text = computerGesture;

            // Displaying generated gesture image for the computer selection
            switch(computerGesture)
            {
                case "Rock":
                    PictBox_ComputerSelection.Image = Properties.Resources.Rock;
                    break;

                case "Paper":
                    PictBox_ComputerSelection.Image = Properties.Resources.Paper;
                    break;

                case "Scissors":
                    PictBox_ComputerSelection.Image = Properties.Resources.Scissors;
                    break;

                case "Lizard":
                    PictBox_ComputerSelection.Image = Properties.Resources.Lizard;
                    break;

                case "Spock":
                    PictBox_ComputerSelection.Image = Properties.Resources.Spock;
                    break;

                default:
                    break;
            }

            // Checking for the winner
            switch (playerGesture)
            {
                case "Rock":
                    // Displaying chosen gesture image
                    PictBox_PlayerSelection.Image = Properties.Resources.Rock;

                    // Situation in which player wins
                    if (computerGesture == "Scissors" || computerGesture == "Lizard")
                    {
                        // Assigning player name
                        winner = playerName;
                        // Assigning winning statement
                        winningCondition = "Rock crushes " + computerGesture + ".";
                    }
                    // Situation in which player loses
                    else if(computerGesture == "Paper" || computerGesture == "Spock")
                    {
                        winner = "Computer";
                        // Checking which winning statement to assign
                        if (computerGesture == "Paper")
                            winningCondition = "Paper covers Rock.";
                        else
                            winningCondition = "Spock vaporizes Rock.";
                    }

                    break;

                case "Paper":
                    // Displaying chosen gesture image
                    PictBox_PlayerSelection.Image = Properties.Resources.Paper;

                    // Situation in which player wins
                    if (computerGesture == "Rock" || computerGesture == "Spock")
                    {
                        // Assigning player name
                        winner = playerName;
                        // Checking which winning statement to assign
                        if (computerGesture == "Rock")
                            winningCondition = "Paper covers Rock.";
                        else
                            winningCondition = "Paper disproves Spock.";
                    }
                    // Situation in which player loses
                    else if (computerGesture == "Scissors" || computerGesture == "Lizard")
                    {
                        winner = "Computer";
                        // Checking which winning statement to assign
                        if (computerGesture == "Scissors")
                            winningCondition = "Scissors cuts Paper.";
                        else
                            winningCondition = "Lizard eats Paper.";
                    }
                    break;

                case "Scissors":
                    // Displaying chosen gesture image
                    PictBox_PlayerSelection.Image = Properties.Resources.Scissors;

                    // Situation in which player wins
                    if (computerGesture == "Paper" || computerGesture == "Lizard")
                    {
                        // Assigning player name
                        winner = playerName;
                        // Checking which winning statement to assign
                        if (computerGesture == "Paper")
                            winningCondition = "Scissors cuts Paper.";
                        else
                            winningCondition = "Scissors decapitates Lizard.";
                    }
                    // Situation in which player loses
                    else if (computerGesture == "Spock" || computerGesture == "Rock")
                    {
                        winner = "Computer";
                        // Checking which winning statement to assign
                        if (computerGesture == "Spock")
                            winningCondition = "Spock smashes Scissors.";
                        else
                            winningCondition = "Rock crushes Scissors.";
                    }
                    break;

                case "Lizard":
                    // Displaying chosen gesture image
                    PictBox_PlayerSelection.Image = Properties.Resources.Lizard;

                    // Situation in which player wins
                    if (computerGesture == "Spock" || computerGesture == "Paper")
                    {
                        // Assigning player name
                        winner = playerName;
                        // Checking which winning statement to assign
                        if (computerGesture == "Spock")
                            winningCondition = "Lizard poisons Spock.";
                        else
                            winningCondition = "Lizard eats Paper.";
                    }
                    // Situation in which player loses
                    else if (computerGesture == "Rock" || computerGesture == "Scissors")
                    {
                        winner = "Computer";
                        // Checking which winning statement to assign
                        if (computerGesture == "Rock")
                            winningCondition = "Rock crushes Lizard.";
                        else
                            winningCondition = "Scissors decapitates Lizard.";
                    }
                    break;

                case "Spock":
                    // Displaying chosen gesture image
                    PictBox_PlayerSelection.Image = Properties.Resources.Spock;

                    // Situation in which player wins
                    if (computerGesture == "Scissors" || computerGesture == "Rock")
                    {
                        // Assigning player name
                        winner = playerName;
                        // Checking which winning statement to assign
                        if (computerGesture == "Scissors")
                            winningCondition = "Spock smashes Scissors.";
                        else
                            winningCondition = "Spock vaporizes Rock.";
                    }
                    // Situation in which player loses
                    else if (computerGesture == "Lizard" || computerGesture == "Paper")
                    {
                        winner = "Computer";
                        // Checking which winning statement to assign
                        if (computerGesture == "Lizard")
                            winningCondition = "Lizard poisons Spock.";
                        else
                            winningCondition = "Paper disproves Spock.";
                    }
                    break;

                default:
                    break;
            }

            // Checking who is the winner
            switch(winner)
            {
                // No winner
                case "":
                    Lbl_RoundWinner.ForeColor = Color.Black;
                    Lbl_RoundWinner.Text = "No winner. Play this round again.";
                    break;

                // Computer is the winner
                case "Computer":
                    Lbl_RoundWinner.ForeColor = Color.Red;
                    Lbl_RoundWinner.Text = winningCondition + " Computer wins!";
                    computerPoints++;
                    break;

                // Player is the winner 
                default:
                    Lbl_RoundWinner.ForeColor = Color.Green;
                    Lbl_RoundWinner.Text = winningCondition + " " + playerName + " wins!";
                    playerPoints++;
                    break;
            }

            // If there is a winner the gesture buttons will be hidden and 'Next Round' button will appear 
            if (winner != "")
            {
                // Changing all gesture buttons colour to 'inactive'
                foreach (Button button in gestureButtons)
                    button.BackColor = SystemColors.ControlLight;

                // Changing 'Next Round' button colour to active only if there is another round
                if (playerPoints < pointsToWin && computerPoints < pointsToWin)
                {
                    Btn_NxtRound.BackColor = SystemColors.ControlLightLight;
                    ableToClickNxtRound = true;
                }

                // Disabling the possibility to click on the gesture button (and run this function)
                ableToClickGesture = false;
            }

            // Showing the score
            Lbl_ComputerScore.Text = "Computer\n " + computerPoints;
            Lbl_PlayerScore.Text = playerName + "\n " + playerPoints;

            // Checking if the player or the computer reached the number of points to win
            if(playerPoints == pointsToWin)
                DisplayGameWinner(playerName);
            else if(computerPoints == pointsToWin)
                DisplayGameWinner("Computer");
        }

        // Displaying the winner of the whole game and blocking any further actions on buttons
        private void DisplayGameWinner(string winner)
        {
            // Hiding all gesture buttons
            foreach (Button button in gestureButtons)
                button.Hide();

            // Hiding all gesture labels (texts under buttons)
            Lbl_Rock.Hide();
            Lbl_Paper.Hide();
            Lbl_Scissors.Hide();
            Lbl_Lizard.Hide();
            Lbl_Spock.Hide();

            // Changing 'Next Round' button colour to 'inactive'
            Btn_NxtRound.BackColor = SystemColors.ControlLight;

            // Showing the winning message
            Lbl_GameWinner.Show();

            // If the computer has won
            if(winner == "Computer")
            {
                // Changing the colours of the texts
                Lbl_PlayerScore.ForeColor = Color.Red;
                Lbl_ComputerScore.ForeColor = Color.Green;
                Lbl_GameWinner.ForeColor = Color.Red;
                Lbl_GameWinner.Text = @"Computer wins! Try again ¯\_( ͡° ͜ʖ ͡°)_/¯";
            }else
            {
                // Changing the colours of the texts
                Lbl_PlayerScore.ForeColor = Color.Green;
                Lbl_ComputerScore.ForeColor = Color.Red;
                Lbl_GameWinner.ForeColor = Color.Green;
                Lbl_GameWinner.Text = "Congratulations, " + playerName + "!\n" + @"You have won! ᕦ( ͡° ͜ʖ ͡°)ᕤ";
            }
        }

        // Responsible for new round
        private void NewRound()
        {
            // Incrementing current round number
            currentRound++;

            // Changing 'Next Round' button colour to 'inactive'
            Btn_NxtRound.BackColor = SystemColors.ControlLight;
            
            // Changing button colours to 'active'
            foreach (Button button in gestureButtons)
                button.BackColor = SystemColors.ControlLightLight;

            // Displaying new round number
            Lbl_Round.Text = "Round " + currentRound;

            // Disabling the 'Next Round' button and enabling gesture buttons
            ableToClickGesture = true;
            ableToClickNxtRound = false;
        }
    }
}
