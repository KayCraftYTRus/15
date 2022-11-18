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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            NewGame NG = new NewGame();
            NG.Show();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("В разработке");
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Settings S = new Settings();
            S.Show();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("В разработке");
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
