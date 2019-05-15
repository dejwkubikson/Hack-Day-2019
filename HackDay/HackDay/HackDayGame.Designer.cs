namespace HackDay
{
    partial class HackDayGame
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_PlayerSelection = new System.Windows.Forms.Label();
            this.Lbl_ComputerSelection = new System.Windows.Forms.Label();
            this.Btn_NxtRound = new System.Windows.Forms.Button();
            this.Lbl_RoundWinner = new System.Windows.Forms.Label();
            this.PictBox_ComputerSelection = new System.Windows.Forms.PictureBox();
            this.PictBox_PlayerSelection = new System.Windows.Forms.PictureBox();
            this.Lbl_Divider = new System.Windows.Forms.Label();
            this.Lbl_PointsToWin = new System.Windows.Forms.Label();
            this.Lbl_ComputerScore = new System.Windows.Forms.Label();
            this.Lbl_PlayerScore = new System.Windows.Forms.Label();
            this.Btn_MainMenu = new System.Windows.Forms.Button();
            this.Btn_Spock = new System.Windows.Forms.Button();
            this.Btn_Paper = new System.Windows.Forms.Button();
            this.Btn_Rock = new System.Windows.Forms.Button();
            this.Btn_Lizard = new System.Windows.Forms.Button();
            this.Btn_Scissors = new System.Windows.Forms.Button();
            this.Lbl_Round = new System.Windows.Forms.Label();
            this.Lbl_GameWinner = new System.Windows.Forms.Label();
            this.Btn_PlayAgain = new System.Windows.Forms.Button();
            this.Lbl_Rock = new System.Windows.Forms.Label();
            this.Lbl_Paper = new System.Windows.Forms.Label();
            this.Lbl_Scissors = new System.Windows.Forms.Label();
            this.Lbl_Lizard = new System.Windows.Forms.Label();
            this.Lbl_Spock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_ComputerSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_PlayerSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_PlayerSelection
            // 
            this.Lbl_PlayerSelection.AutoSize = true;
            this.Lbl_PlayerSelection.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_PlayerSelection.Location = new System.Drawing.Point(271, 352);
            this.Lbl_PlayerSelection.Name = "Lbl_PlayerSelection";
            this.Lbl_PlayerSelection.Size = new System.Drawing.Size(0, 14);
            this.Lbl_PlayerSelection.TabIndex = 35;
            // 
            // Lbl_ComputerSelection
            // 
            this.Lbl_ComputerSelection.AutoSize = true;
            this.Lbl_ComputerSelection.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_ComputerSelection.Location = new System.Drawing.Point(271, 102);
            this.Lbl_ComputerSelection.Name = "Lbl_ComputerSelection";
            this.Lbl_ComputerSelection.Size = new System.Drawing.Size(0, 14);
            this.Lbl_ComputerSelection.TabIndex = 34;
            // 
            // Btn_NxtRound
            // 
            this.Btn_NxtRound.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_NxtRound.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_NxtRound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NxtRound.Location = new System.Drawing.Point(213, 468);
            this.Btn_NxtRound.Name = "Btn_NxtRound";
            this.Btn_NxtRound.Size = new System.Drawing.Size(160, 80);
            this.Btn_NxtRound.TabIndex = 7;
            this.Btn_NxtRound.Text = "Next Round";
            this.Btn_NxtRound.UseVisualStyleBackColor = false;
            this.Btn_NxtRound.Click += new System.EventHandler(this.Btn_NxtRound_Click);
            // 
            // Lbl_RoundWinner
            // 
            this.Lbl_RoundWinner.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_RoundWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_RoundWinner.Location = new System.Drawing.Point(3, 42);
            this.Lbl_RoundWinner.Name = "Lbl_RoundWinner";
            this.Lbl_RoundWinner.Size = new System.Drawing.Size(580, 50);
            this.Lbl_RoundWinner.TabIndex = 32;
            this.Lbl_RoundWinner.Text = "Scissors decapitates Lizard. Player wins!";
            this.Lbl_RoundWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictBox_ComputerSelection
            // 
            this.PictBox_ComputerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictBox_ComputerSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictBox_ComputerSelection.Location = new System.Drawing.Point(233, 122);
            this.PictBox_ComputerSelection.Name = "PictBox_ComputerSelection";
            this.PictBox_ComputerSelection.Size = new System.Drawing.Size(120, 100);
            this.PictBox_ComputerSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictBox_ComputerSelection.TabIndex = 31;
            this.PictBox_ComputerSelection.TabStop = false;
            // 
            // PictBox_PlayerSelection
            // 
            this.PictBox_PlayerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictBox_PlayerSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictBox_PlayerSelection.Location = new System.Drawing.Point(233, 244);
            this.PictBox_PlayerSelection.Name = "PictBox_PlayerSelection";
            this.PictBox_PlayerSelection.Size = new System.Drawing.Size(120, 100);
            this.PictBox_PlayerSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictBox_PlayerSelection.TabIndex = 30;
            this.PictBox_PlayerSelection.TabStop = false;
            // 
            // Lbl_Divider
            // 
            this.Lbl_Divider.AutoSize = true;
            this.Lbl_Divider.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Divider.Location = new System.Drawing.Point(3, 222);
            this.Lbl_Divider.Name = "Lbl_Divider";
            this.Lbl_Divider.Size = new System.Drawing.Size(751, 19);
            this.Lbl_Divider.TabIndex = 29;
            this.Lbl_Divider.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // Lbl_PointsToWin
            // 
            this.Lbl_PointsToWin.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_PointsToWin.Location = new System.Drawing.Point(153, 1);
            this.Lbl_PointsToWin.Name = "Lbl_PointsToWin";
            this.Lbl_PointsToWin.Size = new System.Drawing.Size(280, 50);
            this.Lbl_PointsToWin.TabIndex = 28;
            this.Lbl_PointsToWin.Text = "Playing to 5 points";
            this.Lbl_PointsToWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ComputerScore
            // 
            this.Lbl_ComputerScore.AutoSize = true;
            this.Lbl_ComputerScore.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_ComputerScore.Location = new System.Drawing.Point(468, 122);
            this.Lbl_ComputerScore.Name = "Lbl_ComputerScore";
            this.Lbl_ComputerScore.Size = new System.Drawing.Size(112, 54);
            this.Lbl_ComputerScore.TabIndex = 27;
            this.Lbl_ComputerScore.Text = "Computer\r\n0";
            this.Lbl_ComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PlayerScore
            // 
            this.Lbl_PlayerScore.AutoSize = true;
            this.Lbl_PlayerScore.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_PlayerScore.Location = new System.Drawing.Point(15, 244);
            this.Lbl_PlayerScore.Name = "Lbl_PlayerScore";
            this.Lbl_PlayerScore.Size = new System.Drawing.Size(75, 54);
            this.Lbl_PlayerScore.TabIndex = 26;
            this.Lbl_PlayerScore.Text = "Player\r\n0\r\n";
            this.Lbl_PlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_MainMenu
            // 
            this.Btn_MainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_MainMenu.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_MainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_MainMenu.Location = new System.Drawing.Point(393, 468);
            this.Btn_MainMenu.Name = "Btn_MainMenu";
            this.Btn_MainMenu.Size = new System.Drawing.Size(160, 80);
            this.Btn_MainMenu.TabIndex = 8;
            this.Btn_MainMenu.Text = "Main Menu";
            this.Btn_MainMenu.UseVisualStyleBackColor = false;
            this.Btn_MainMenu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Btn_Spock
            // 
            this.Btn_Spock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Spock.BackgroundImage = global::HackDay.Properties.Resources.Spock;
            this.Btn_Spock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Spock.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Spock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Spock.Location = new System.Drawing.Point(473, 372);
            this.Btn_Spock.Name = "Btn_Spock";
            this.Btn_Spock.Size = new System.Drawing.Size(80, 80);
            this.Btn_Spock.TabIndex = 5;
            this.Btn_Spock.UseVisualStyleBackColor = false;
            this.Btn_Spock.Click += new System.EventHandler(this.Btn_Spock_Click);
            // 
            // Btn_Paper
            // 
            this.Btn_Paper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Paper.BackgroundImage = global::HackDay.Properties.Resources.Paper;
            this.Btn_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Paper.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Paper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Paper.Location = new System.Drawing.Point(143, 372);
            this.Btn_Paper.Name = "Btn_Paper";
            this.Btn_Paper.Size = new System.Drawing.Size(80, 80);
            this.Btn_Paper.TabIndex = 2;
            this.Btn_Paper.UseVisualStyleBackColor = false;
            this.Btn_Paper.Click += new System.EventHandler(this.Btn_Paper_Click);
            // 
            // Btn_Rock
            // 
            this.Btn_Rock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Rock.BackgroundImage = global::HackDay.Properties.Resources.Rock;
            this.Btn_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Rock.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Rock.Location = new System.Drawing.Point(33, 372);
            this.Btn_Rock.Name = "Btn_Rock";
            this.Btn_Rock.Size = new System.Drawing.Size(80, 80);
            this.Btn_Rock.TabIndex = 1;
            this.Btn_Rock.UseVisualStyleBackColor = false;
            this.Btn_Rock.Click += new System.EventHandler(this.Btn_Rock_Click);
            // 
            // Btn_Lizard
            // 
            this.Btn_Lizard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Lizard.BackgroundImage = global::HackDay.Properties.Resources.Lizard;
            this.Btn_Lizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Lizard.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Lizard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Lizard.Location = new System.Drawing.Point(363, 372);
            this.Btn_Lizard.Name = "Btn_Lizard";
            this.Btn_Lizard.Size = new System.Drawing.Size(80, 80);
            this.Btn_Lizard.TabIndex = 4;
            this.Btn_Lizard.UseVisualStyleBackColor = false;
            this.Btn_Lizard.Click += new System.EventHandler(this.Btn_Lizard_Click);
            // 
            // Btn_Scissors
            // 
            this.Btn_Scissors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Scissors.BackgroundImage = global::HackDay.Properties.Resources.Scissors;
            this.Btn_Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Scissors.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Scissors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Scissors.Location = new System.Drawing.Point(253, 372);
            this.Btn_Scissors.Name = "Btn_Scissors";
            this.Btn_Scissors.Size = new System.Drawing.Size(80, 80);
            this.Btn_Scissors.TabIndex = 3;
            this.Btn_Scissors.UseVisualStyleBackColor = false;
            this.Btn_Scissors.Click += new System.EventHandler(this.Btn_Scissors_Click);
            // 
            // Lbl_Round
            // 
            this.Lbl_Round.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Round.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Round.Location = new System.Drawing.Point(3, 1);
            this.Lbl_Round.Name = "Lbl_Round";
            this.Lbl_Round.Size = new System.Drawing.Size(120, 48);
            this.Lbl_Round.TabIndex = 37;
            this.Lbl_Round.Text = "Round 1";
            // 
            // Lbl_GameWinner
            // 
            this.Lbl_GameWinner.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_GameWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_GameWinner.Location = new System.Drawing.Point(3, 377);
            this.Lbl_GameWinner.Name = "Lbl_GameWinner";
            this.Lbl_GameWinner.Size = new System.Drawing.Size(580, 80);
            this.Lbl_GameWinner.TabIndex = 36;
            this.Lbl_GameWinner.Text = "Congratulations, Player!\r\n You have won!";
            this.Lbl_GameWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_PlayAgain
            // 
            this.Btn_PlayAgain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_PlayAgain.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_PlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PlayAgain.Location = new System.Drawing.Point(33, 468);
            this.Btn_PlayAgain.Name = "Btn_PlayAgain";
            this.Btn_PlayAgain.Size = new System.Drawing.Size(160, 80);
            this.Btn_PlayAgain.TabIndex = 6;
            this.Btn_PlayAgain.Text = "Play Again";
            this.Btn_PlayAgain.UseVisualStyleBackColor = false;
            this.Btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // Lbl_Rock
            // 
            this.Lbl_Rock.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Rock.Location = new System.Drawing.Point(49, 452);
            this.Lbl_Rock.Name = "Lbl_Rock";
            this.Lbl_Rock.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Rock.TabIndex = 38;
            this.Lbl_Rock.Text = "Rock";
            this.Lbl_Rock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Paper
            // 
            this.Lbl_Paper.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Paper.Location = new System.Drawing.Point(159, 452);
            this.Lbl_Paper.Name = "Lbl_Paper";
            this.Lbl_Paper.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Paper.TabIndex = 39;
            this.Lbl_Paper.Text = "Paper";
            this.Lbl_Paper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Scissors
            // 
            this.Lbl_Scissors.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Scissors.Location = new System.Drawing.Point(268, 452);
            this.Lbl_Scissors.Name = "Lbl_Scissors";
            this.Lbl_Scissors.Size = new System.Drawing.Size(50, 14);
            this.Lbl_Scissors.TabIndex = 40;
            this.Lbl_Scissors.Text = "Scissors";
            this.Lbl_Scissors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Lizard
            // 
            this.Lbl_Lizard.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Lizard.Location = new System.Drawing.Point(379, 452);
            this.Lbl_Lizard.Name = "Lbl_Lizard";
            this.Lbl_Lizard.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Lizard.TabIndex = 41;
            this.Lbl_Lizard.Text = "Lizard";
            this.Lbl_Lizard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Spock
            // 
            this.Lbl_Spock.Font = new System.Drawing.Font("Caviar Dreams", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Spock.Location = new System.Drawing.Point(489, 452);
            this.Lbl_Spock.Name = "Lbl_Spock";
            this.Lbl_Spock.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Spock.TabIndex = 42;
            this.Lbl_Spock.Text = "Spock";
            this.Lbl_Spock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HackDayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Spock);
            this.Controls.Add(this.Lbl_Lizard);
            this.Controls.Add(this.Lbl_Scissors);
            this.Controls.Add(this.Lbl_Paper);
            this.Controls.Add(this.Lbl_Rock);
            this.Controls.Add(this.Btn_PlayAgain);
            this.Controls.Add(this.Lbl_Round);
            this.Controls.Add(this.Lbl_GameWinner);
            this.Controls.Add(this.Lbl_PlayerSelection);
            this.Controls.Add(this.Lbl_ComputerSelection);
            this.Controls.Add(this.Btn_NxtRound);
            this.Controls.Add(this.Lbl_RoundWinner);
            this.Controls.Add(this.PictBox_ComputerSelection);
            this.Controls.Add(this.PictBox_PlayerSelection);
            this.Controls.Add(this.Lbl_Divider);
            this.Controls.Add(this.Lbl_PointsToWin);
            this.Controls.Add(this.Lbl_ComputerScore);
            this.Controls.Add(this.Lbl_PlayerScore);
            this.Controls.Add(this.Btn_MainMenu);
            this.Controls.Add(this.Btn_Spock);
            this.Controls.Add(this.Btn_Paper);
            this.Controls.Add(this.Btn_Rock);
            this.Controls.Add(this.Btn_Lizard);
            this.Controls.Add(this.Btn_Scissors);
            this.Name = "HackDayGame";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.HackDayGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_ComputerSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_PlayerSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_PlayerSelection;
        private System.Windows.Forms.Label Lbl_ComputerSelection;
        private System.Windows.Forms.Button Btn_NxtRound;
        private System.Windows.Forms.Label Lbl_RoundWinner;
        private System.Windows.Forms.PictureBox PictBox_ComputerSelection;
        private System.Windows.Forms.PictureBox PictBox_PlayerSelection;
        private System.Windows.Forms.Label Lbl_Divider;
        private System.Windows.Forms.Label Lbl_PointsToWin;
        private System.Windows.Forms.Label Lbl_ComputerScore;
        private System.Windows.Forms.Label Lbl_PlayerScore;
        private System.Windows.Forms.Button Btn_MainMenu;
        private System.Windows.Forms.Button Btn_Spock;
        private System.Windows.Forms.Button Btn_Paper;
        private System.Windows.Forms.Button Btn_Rock;
        private System.Windows.Forms.Button Btn_Lizard;
        private System.Windows.Forms.Button Btn_Scissors;
        private System.Windows.Forms.Label Lbl_Round;
        private System.Windows.Forms.Label Lbl_GameWinner;
        private System.Windows.Forms.Button Btn_PlayAgain;
        private System.Windows.Forms.Label Lbl_Rock;
        private System.Windows.Forms.Label Lbl_Paper;
        private System.Windows.Forms.Label Lbl_Scissors;
        private System.Windows.Forms.Label Lbl_Lizard;
        private System.Windows.Forms.Label Lbl_Spock;
    }
}
