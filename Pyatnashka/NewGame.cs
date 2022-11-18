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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }

        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("В разработке");
            
        }
    }
}
