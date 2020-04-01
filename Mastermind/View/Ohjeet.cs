using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Ohjeet : Form
    {
        public Ohjeet(Kayttajavalikko kayttajavalikko)
        { 
            InitializeComponent();
        }

        private void Ohjeet_Load(object sender, EventArgs e)
        {
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
            }
        }

        private void btSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMute_Click(object sender, EventArgs e)
        {
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                Paavalikko.menu.Stop();
                Paavalikko.mute = false;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                Paavalikko.menu.PlayLooping();
                Paavalikko.mute = true;
            }
        }
    }
}
