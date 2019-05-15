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
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
        }

        // 'Main Menu' button
        private void Btn_MainMenu_Click(object sender, EventArgs e)
        {
            // Create new main menu controls
            MainMenu mainMenu = new MainMenu();
            // Get the form
            Form hackDayForm = (this.Parent as Form);
            // Clear current form controls
            hackDayForm.Controls.Clear();
            // Add game controls to the form
            mainMenu.Dock = DockStyle.Fill;
            hackDayForm.Controls.Add(mainMenu);
        }
    }
}
