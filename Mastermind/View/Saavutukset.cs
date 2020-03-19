using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Mastermind.Controller;
using Mastermind.Model;

namespace Mastermind
{
    public partial class Saavutukset : Form
    {
        private Paavalikko paavalikko;
        Ohjain registerHandler = new Ohjain();
        SoundPlayer musa = new SoundPlayer(Properties.Resources.SaavutusTilasto);
        SoundPlayer menu = new SoundPlayer(Properties.Resources.MastermindMenu8bit);

        public Saavutukset(Paavalikko paavalikko)
        {
            InitializeComponent();

            this.paavalikko = paavalikko;

            ShowData();

            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                musa.PlayLooping();
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                musa.Stop();
            }
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Paavalikko paavalikko = ((Paavalikko)Owner);

            musa.Stop();

            if (Paavalikko.mute == true)
            {
                Paavalikko.menu.PlayLooping();
            }

            else if (Paavalikko.mute == false)
            {
                Paavalikko.menu.Stop();
            }

            Close();
        }

        private void Saavutukset_Load(object sender, EventArgs e)
        {
            cbKayttaja.DataSource = registerHandler.KaikkiKayttajat();
            cbKayttaja.DisplayMember = "kayttaja";
            cbKayttaja.ValueMember = "kayttajaId";
        }

        private void ShowData()
        {
            Kayttajat user = new Kayttajat();
            user.Kayttaja = cbKayttaja.Text;

            dgvSaavutukset.DataSource = registerHandler.Saavutukset(user);
        }

        private void cbKayttaja_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btMute_Click(object sender, EventArgs e)
        {
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                musa.Stop();
                Paavalikko.mute = false;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;


                musa.PlayLooping();
                Paavalikko.mute = true;
            }
        }
    }
}
