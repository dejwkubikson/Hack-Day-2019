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
            this.Btn_RoundsNumber5 = new System.Windows.Forms.Button();
            this.Btn_RoundsNumber3 = new System.Windows.Forms.Button();
            this.Lbl_RoundsNumber = new System.Windows.Forms.Label();
            this.Btn_RoundsNumber1 = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
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
            // Btn_RoundsNumber5
            // 
            this.Btn_RoundsNumber5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_RoundsNumber5.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_RoundsNumber5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RoundsNumber5.Location = new System.Drawing.Point(419, 262);
            this.Btn_RoundsNumber5.Name = "Btn_RoundsNumber5";
            this.Btn_RoundsNumber5.Size = new System.Drawing.Size(80, 80);
            this.Btn_RoundsNumber5.TabIndex = 4;
            this.Btn_RoundsNumber5.Text = "5";
            this.Btn_RoundsNumber5.UseVisualStyleBackColor = false;
            this.Btn_RoundsNumber5.Click += new System.EventHandler(this.Btn_RoundsNumber5_Click);
            // 
            // Btn_RoundsNumber3
            // 
            this.Btn_RoundsNumber3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_RoundsNumber3.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_RoundsNumber3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RoundsNumber3.Location = new System.Drawing.Point(259, 262);
            this.Btn_RoundsNumber3.Name = "Btn_RoundsNumber3";
            this.Btn_RoundsNumber3.Size = new System.Drawing.Size(80, 80);
            this.Btn_RoundsNumber3.TabIndex = 3;
            this.Btn_RoundsNumber3.Text = "3";
            this.Btn_RoundsNumber3.UseVisualStyleBackColor = false;
            this.Btn_RoundsNumber3.Click += new System.EventHandler(this.Btn_RoundsNumber3_Click);
            // 
            // Lbl_RoundsNumber
            // 
            this.Lbl_RoundsNumber.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_RoundsNumber.Location = new System.Drawing.Point(11, 210);
            this.Lbl_RoundsNumber.Name = "Lbl_RoundsNumber";
            this.Lbl_RoundsNumber.Size = new System.Drawing.Size(580, 25);
            this.Lbl_RoundsNumber.TabIndex = 11;
            this.Lbl_RoundsNumber.Text = "Choose number of rounds you want to play";
            this.Lbl_RoundsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_RoundsNumber1
            // 
            this.Btn_RoundsNumber1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_RoundsNumber1.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_RoundsNumber1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RoundsNumber1.Location = new System.Drawing.Point(89, 262);
            this.Btn_RoundsNumber1.Name = "Btn_RoundsNumber1";
            this.Btn_RoundsNumber1.Size = new System.Drawing.Size(80, 80);
            this.Btn_RoundsNumber1.TabIndex = 2;
            this.Btn_RoundsNumber1.Text = "1";
            this.Btn_RoundsNumber1.UseVisualStyleBackColor = false;
            this.Btn_RoundsNumber1.Click += new System.EventHandler(this.Btn_RoundsNumber1_Click);
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Instructions);
            this.Controls.Add(this.Lbl_EnterName);
            this.Controls.Add(this.TxtBox_Name);
            this.Controls.Add(this.Btn_RoundsNumber5);
            this.Controls.Add(this.Btn_RoundsNumber3);
            this.Controls.Add(this.Lbl_RoundsNumber);
            this.Controls.Add(this.Btn_RoundsNumber1);
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
        private System.Windows.Forms.Button Btn_RoundsNumber5;
        private System.Windows.Forms.Button Btn_RoundsNumber3;
        private System.Windows.Forms.Label Lbl_RoundsNumber;
        private System.Windows.Forms.Button Btn_RoundsNumber1;
        private System.Windows.Forms.Label Lbl_Title;
    }
}
