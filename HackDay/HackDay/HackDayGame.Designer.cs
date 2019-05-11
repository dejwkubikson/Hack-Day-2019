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
            this.Lbl_Round = new System.Windows.Forms.Label();
            this.Lbl_ComputerScore = new System.Windows.Forms.Label();
            this.Lbl_PlayerScore = new System.Windows.Forms.Label();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Btn_Spock = new System.Windows.Forms.Button();
            this.Btn_Paper = new System.Windows.Forms.Button();
            this.Btn_Rock = new System.Windows.Forms.Button();
            this.Btn_Lizard = new System.Windows.Forms.Button();
            this.Btn_Scissors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_ComputerSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_PlayerSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_PlayerSelection
            // 
            this.Lbl_PlayerSelection.AutoSize = true;
            this.Lbl_PlayerSelection.Location = new System.Drawing.Point(105, 305);
            this.Lbl_PlayerSelection.Name = "Lbl_PlayerSelection";
            this.Lbl_PlayerSelection.Size = new System.Drawing.Size(43, 13);
            this.Lbl_PlayerSelection.TabIndex = 35;
            this.Lbl_PlayerSelection.Text = "Waiting";
            // 
            // Lbl_ComputerSelection
            // 
            this.Lbl_ComputerSelection.AutoSize = true;
            this.Lbl_ComputerSelection.Location = new System.Drawing.Point(105, 183);
            this.Lbl_ComputerSelection.Name = "Lbl_ComputerSelection";
            this.Lbl_ComputerSelection.Size = new System.Drawing.Size(43, 13);
            this.Lbl_ComputerSelection.TabIndex = 34;
            this.Lbl_ComputerSelection.Text = "Waiting";
            // 
            // Btn_NxtRound
            // 
            this.Btn_NxtRound.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_NxtRound.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_NxtRound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NxtRound.Location = new System.Drawing.Point(212, 382);
            this.Btn_NxtRound.Name = "Btn_NxtRound";
            this.Btn_NxtRound.Size = new System.Drawing.Size(160, 80);
            this.Btn_NxtRound.TabIndex = 7;
            this.Btn_NxtRound.Text = "Next Round";
            this.Btn_NxtRound.UseVisualStyleBackColor = false;
            // 
            // Lbl_RoundWinner
            // 
            this.Lbl_RoundWinner.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_RoundWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_RoundWinner.Location = new System.Drawing.Point(3, 82);
            this.Lbl_RoundWinner.Name = "Lbl_RoundWinner";
            this.Lbl_RoundWinner.Size = new System.Drawing.Size(580, 50);
            this.Lbl_RoundWinner.TabIndex = 32;
            this.Lbl_RoundWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictBox_ComputerSelection
            // 
            this.PictBox_ComputerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictBox_ComputerSelection.Location = new System.Drawing.Point(233, 142);
            this.PictBox_ComputerSelection.Name = "PictBox_ComputerSelection";
            this.PictBox_ComputerSelection.Size = new System.Drawing.Size(120, 100);
            this.PictBox_ComputerSelection.TabIndex = 31;
            this.PictBox_ComputerSelection.TabStop = false;
            // 
            // PictBox_PlayerSelection
            // 
            this.PictBox_PlayerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictBox_PlayerSelection.Location = new System.Drawing.Point(233, 264);
            this.PictBox_PlayerSelection.Name = "PictBox_PlayerSelection";
            this.PictBox_PlayerSelection.Size = new System.Drawing.Size(120, 100);
            this.PictBox_PlayerSelection.TabIndex = 30;
            this.PictBox_PlayerSelection.TabStop = false;
            // 
            // Lbl_Divider
            // 
            this.Lbl_Divider.AutoSize = true;
            this.Lbl_Divider.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Divider.Location = new System.Drawing.Point(3, 242);
            this.Lbl_Divider.Name = "Lbl_Divider";
            this.Lbl_Divider.Size = new System.Drawing.Size(751, 19);
            this.Lbl_Divider.TabIndex = 29;
            this.Lbl_Divider.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // Lbl_Round
            // 
            this.Lbl_Round.Font = new System.Drawing.Font("Caviar Dreams", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Round.Location = new System.Drawing.Point(233, 1);
            this.Lbl_Round.Name = "Lbl_Round";
            this.Lbl_Round.Size = new System.Drawing.Size(120, 80);
            this.Lbl_Round.TabIndex = 28;
            this.Lbl_Round.Text = "Round\r\n1 of 5";
            this.Lbl_Round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ComputerScore
            // 
            this.Lbl_ComputerScore.AutoSize = true;
            this.Lbl_ComputerScore.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_ComputerScore.Location = new System.Drawing.Point(468, 142);
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
            this.Lbl_PlayerScore.Location = new System.Drawing.Point(15, 264);
            this.Lbl_PlayerScore.Name = "Lbl_PlayerScore";
            this.Lbl_PlayerScore.Size = new System.Drawing.Size(75, 54);
            this.Lbl_PlayerScore.TabIndex = 26;
            this.Lbl_PlayerScore.Text = "Player\r\n0\r\n";
            this.Lbl_PlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Menu.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu.Location = new System.Drawing.Point(212, 472);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(160, 80);
            this.Btn_Menu.TabIndex = 6;
            this.Btn_Menu.Text = "End Game";
            this.Btn_Menu.UseVisualStyleBackColor = false;
            // 
            // Btn_Spock
            // 
            this.Btn_Spock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Spock.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Spock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Spock.Location = new System.Drawing.Point(473, 382);
            this.Btn_Spock.Name = "Btn_Spock";
            this.Btn_Spock.Size = new System.Drawing.Size(80, 80);
            this.Btn_Spock.TabIndex = 5;
            this.Btn_Spock.Text = "Spock";
            this.Btn_Spock.UseVisualStyleBackColor = false;
            this.Btn_Spock.Click += new System.EventHandler(this.Btn_Spock_Click);
            // 
            // Btn_Paper
            // 
            this.Btn_Paper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Paper.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Paper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Paper.Location = new System.Drawing.Point(143, 382);
            this.Btn_Paper.Name = "Btn_Paper";
            this.Btn_Paper.Size = new System.Drawing.Size(80, 80);
            this.Btn_Paper.TabIndex = 2;
            this.Btn_Paper.Text = "Paper";
            this.Btn_Paper.UseVisualStyleBackColor = false;
            this.Btn_Paper.Click += new System.EventHandler(this.Btn_Paper_Click);
            // 
            // Btn_Rock
            // 
            this.Btn_Rock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Rock.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Rock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Rock.Location = new System.Drawing.Point(33, 382);
            this.Btn_Rock.Name = "Btn_Rock";
            this.Btn_Rock.Size = new System.Drawing.Size(80, 80);
            this.Btn_Rock.TabIndex = 1;
            this.Btn_Rock.Text = "Rock";
            this.Btn_Rock.UseVisualStyleBackColor = false;
            this.Btn_Rock.Click += new System.EventHandler(this.Btn_Rock_Click);
            // 
            // Btn_Lizard
            // 
            this.Btn_Lizard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Lizard.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Lizard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Lizard.Location = new System.Drawing.Point(363, 382);
            this.Btn_Lizard.Name = "Btn_Lizard";
            this.Btn_Lizard.Size = new System.Drawing.Size(80, 80);
            this.Btn_Lizard.TabIndex = 4;
            this.Btn_Lizard.Text = "Lizard";
            this.Btn_Lizard.UseVisualStyleBackColor = false;
            this.Btn_Lizard.Click += new System.EventHandler(this.Btn_Lizard_Click);
            // 
            // Btn_Scissors
            // 
            this.Btn_Scissors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Scissors.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Scissors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Scissors.Location = new System.Drawing.Point(253, 382);
            this.Btn_Scissors.Name = "Btn_Scissors";
            this.Btn_Scissors.Size = new System.Drawing.Size(80, 80);
            this.Btn_Scissors.TabIndex = 3;
            this.Btn_Scissors.Text = "Scissors";
            this.Btn_Scissors.UseVisualStyleBackColor = false;
            this.Btn_Scissors.Click += new System.EventHandler(this.Btn_Scissors_Click);
            // 
            // HackDayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_PlayerSelection);
            this.Controls.Add(this.Lbl_ComputerSelection);
            this.Controls.Add(this.Btn_NxtRound);
            this.Controls.Add(this.Lbl_RoundWinner);
            this.Controls.Add(this.PictBox_ComputerSelection);
            this.Controls.Add(this.PictBox_PlayerSelection);
            this.Controls.Add(this.Lbl_Divider);
            this.Controls.Add(this.Lbl_Round);
            this.Controls.Add(this.Lbl_ComputerScore);
            this.Controls.Add(this.Lbl_PlayerScore);
            this.Controls.Add(this.Btn_Menu);
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
        private System.Windows.Forms.Label Lbl_Round;
        private System.Windows.Forms.Label Lbl_ComputerScore;
        private System.Windows.Forms.Label Lbl_PlayerScore;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Button Btn_Spock;
        private System.Windows.Forms.Button Btn_Paper;
        private System.Windows.Forms.Button Btn_Rock;
        private System.Windows.Forms.Button Btn_Lizard;
        private System.Windows.Forms.Button Btn_Scissors;
    }
}
