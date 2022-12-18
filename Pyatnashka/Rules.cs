using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyatnashka
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }
    }
}
