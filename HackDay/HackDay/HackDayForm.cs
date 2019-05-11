using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackDay
{
    public partial class HackDay : Form
    {
        public HackDay()
        {
            InitializeComponent();
        }

        private void HackDay_Load(object sender, EventArgs e)
        {
            // Use Main Menu controls at the start
            MainMenu mainMenu = new MainMenu();
            mainMenu.Dock = DockStyle.Fill;
            this.Controls.Add(mainMenu);
        }
    }
}
