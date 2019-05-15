namespace HackDay
{
    partial class MainMenu
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
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Btn_Instructions = new System.Windows.Forms.Button();
            this.Lbl_EnterName = new System.Windows.Forms.Label();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.Btn_PointsNumber5 = new System.Windows.Forms.Button();
            this.Btn_PointsNumber3 = new System.Windows.Forms.Button();
            this.Lbl_PointsNumber = new System.Windows.Forms.Label();
            this.Btn_PointsNumber1 = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Quit.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Quit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Quit.Location = new System.Drawing.Point(339, 462);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(160, 80);
            this.Btn_Quit.TabIndex = 6;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_Instructions
            // 
            this.Btn_Instructions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Instructions.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Instructions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Instructions.Location = new System.Drawing.Point(89, 462);
            this.Btn_Instructions.Name = "Btn_Instructions";
            this.Btn_Instructions.Size = new System.Drawing.Size(160, 80);
            this.Btn_Instructions.TabIndex = 5;
            this.Btn_Instructions.Text = "Instructions";
            this.Btn_Instructions.UseVisualStyleBackColor = false;
            this.Btn_Instructions.Click += new System.EventHandler(this.Btn_Instructions_Click);
            // 
            // Lbl_EnterName
            // 
            this.Lbl_EnterName.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_EnterName.Location = new System.Drawing.Point(11, 93);
            this.Lbl_EnterName.Name = "Lbl_EnterName";
            this.Lbl_EnterName.Size = new System.Drawing.Size(580, 25);
            this.Lbl_EnterName.TabIndex = 15;
            this.Lbl_EnterName.Text = "Enter your name";
            this.Lbl_EnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(206, 138);
            this.TxtBox_Name.MaxLength = 20;
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(200, 20);
            this.TxtBox_Name.TabIndex = 1;
            this.TxtBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBox_Name.TextChanged += new System.EventHandler(this.TxtBox_Name_TextChanged);
            // 
            // Btn_PointsNumber5
            // 
            this.Btn_PointsNumber5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_PointsNumber5.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_PointsNumber5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PointsNumber5.Location = new System.Drawing.Point(419, 262);
            this.Btn_PointsNumber5.Name = "Btn_PointsNumber5";
            this.Btn_PointsNumber5.Size = new System.Drawing.Size(80, 80);
            this.Btn_PointsNumber5.TabIndex = 4;
            this.Btn_PointsNumber5.Text = "5";
            this.Btn_PointsNumber5.UseVisualStyleBackColor = false;
            this.Btn_PointsNumber5.Click += new System.EventHandler(this.Btn_RoundsNumber5_Click);
            // 
            // Btn_PointsNumber3
            // 
            this.Btn_PointsNumber3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_PointsNumber3.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_PointsNumber3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PointsNumber3.Location = new System.Drawing.Point(259, 262);
            this.Btn_PointsNumber3.Name = "Btn_PointsNumber3";
            this.Btn_PointsNumber3.Size = new System.Drawing.Size(80, 80);
            this.Btn_PointsNumber3.TabIndex = 3;
            this.Btn_PointsNumber3.Text = "3";
            this.Btn_PointsNumber3.UseVisualStyleBackColor = false;
            this.Btn_PointsNumber3.Click += new System.EventHandler(this.Btn_RoundsNumber3_Click);
            // 
            // Lbl_PointsNumber
            // 
            this.Lbl_PointsNumber.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_PointsNumber.Location = new System.Drawing.Point(11, 210);
            this.Lbl_PointsNumber.Name = "Lbl_PointsNumber";
            this.Lbl_PointsNumber.Size = new System.Drawing.Size(580, 25);
            this.Lbl_PointsNumber.TabIndex = 11;
            this.Lbl_PointsNumber.Text = "Choose number of points needed to win the game";
            this.Lbl_PointsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_PointsNumber1
            // 
            this.Btn_PointsNumber1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_PointsNumber1.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_PointsNumber1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PointsNumber1.Location = new System.Drawing.Point(89, 262);
            this.Btn_PointsNumber1.Name = "Btn_PointsNumber1";
            this.Btn_PointsNumber1.Size = new System.Drawing.Size(80, 80);
            this.Btn_PointsNumber1.TabIndex = 2;
            this.Btn_PointsNumber1.Text = "1";
            this.Btn_PointsNumber1.UseVisualStyleBackColor = false;
            this.Btn_PointsNumber1.Click += new System.EventHandler(this.Btn_RoundsNumber1_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("Caviar Dreams", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Title.Location = new System.Drawing.Point(8, 2);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(580, 44);
            this.Lbl_Title.TabIndex = 9;
            this.Lbl_Title.Text = "Arnold Clark Hack Day 2019";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Author
            // 
            this.Lbl_Author.AutoSize = true;
            this.Lbl_Author.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Author.Location = new System.Drawing.Point(427, 542);
            this.Lbl_Author.Name = "Lbl_Author";
            this.Lbl_Author.Size = new System.Drawing.Size(161, 21);
            this.Lbl_Author.TabIndex = 16;
            this.Lbl_Author.Text = "Dawid Kubiak 2019";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Author);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Instructions);
            this.Controls.Add(this.Lbl_EnterName);
            this.Controls.Add(this.TxtBox_Name);
            this.Controls.Add(this.Btn_PointsNumber5);
            this.Controls.Add(this.Btn_PointsNumber3);
            this.Controls.Add(this.Lbl_PointsNumber);
            this.Controls.Add(this.Btn_PointsNumber1);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Button Btn_Instructions;
        private System.Windows.Forms.Label Lbl_EnterName;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.Button Btn_PointsNumber5;
        private System.Windows.Forms.Button Btn_PointsNumber3;
        private System.Windows.Forms.Label Lbl_PointsNumber;
        private System.Windows.Forms.Button Btn_PointsNumber1;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Author;
    }
}
