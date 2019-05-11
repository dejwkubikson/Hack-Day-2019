namespace HackDay
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("Caviar Dreams", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Title.Location = new System.Drawing.Point(10, 2);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(580, 44);
            this.Lbl_Title.TabIndex = 10;
            this.Lbl_Title.Text = "Instructions";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_MainMenu
            // 
            this.Btn_MainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_MainMenu.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_MainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_MainMenu.Location = new System.Drawing.Point(220, 465);
            this.Btn_MainMenu.Name = "Btn_MainMenu";
            this.Btn_MainMenu.Size = new System.Drawing.Size(160, 80);
            this.Btn_MainMenu.TabIndex = 17;
            this.Btn_MainMenu.Text = "Main Menu";
            this.Btn_MainMenu.UseVisualStyleBackColor = false;
            this.Btn_MainMenu.Click += new System.EventHandler(this.Btn_MainMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 407);
            this.label1.TabIndex = 18;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_MainMenu);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "Instructions";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_MainMenu;
        private System.Windows.Forms.Label label1;
    }
}
