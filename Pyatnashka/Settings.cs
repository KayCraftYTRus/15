using Pyatnashka.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyatnashka
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }

        private void musicBox_CheckedChanged(object sender, EventArgs e)
        {
            if (musicBox.Checked == true)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\\Pyatnashka\\Pyatnashka\\Resources\\Nightmare.wav");
                simpleSound.PlayLooping();
            }
            else if (musicBox.Checked == false)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\\Pyatnashka\\Pyatnashka\\Resources\\Nightmare.wav");
                simpleSound.Stop();
            }
        }

        
    }
}
