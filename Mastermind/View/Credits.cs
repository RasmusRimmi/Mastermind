using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastermind.Controller;
using Mastermind.Model;
using System.Media;

namespace Mastermind
{
    public partial class Credits : Form
    {
        Timer timer = new Timer();
        Label label = new Label();
        SoundPlayer credit = new SoundPlayer(Properties.Resources.Credits);

        public Credits(Paavalikko paavalikko)
        {
            InitializeComponent();

            //Musiikki napin toiminnot
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                credit.Play();
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                credit.Stop();
            }

            lbTitle.Hide();

            //Timerin säädökset liikkuvaan label tekstiin 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 141;         
            timer.Enabled = true;                      
            timer.Start();

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);

            //labeleiden lähtökoordinaatit pystysuunnassa.
            lbTekijat.Top = 400;
            lbNimi1.Top = 400;
            lbNimi2.Top = 430;

        }

        //timer muuttaa koordinaatteja tikittäessään säädetyllä nopeudella
        void timer_Tick(object sender, EventArgs e)
        {
            lbTekijat.Location = new Point(lbTekijat.Location.X, lbTekijat.Location.Y - 1);
            if (lbTekijat.Location.Y > this.Height)
            {
                lbTekijat.Location = new Point(lbTekijat.Location.X, 0 - lbTekijat.Height);
            }

            lbNimi1.Location = new Point(lbNimi1.Location.X, lbNimi1.Location.Y - 1);
            if (lbNimi1.Location.Y > this.Height)
            {
                lbNimi1.Location = new Point(lbNimi1.Location.X, 0 - lbNimi1.Height);
            }

            lbNimi2.Location = new Point(lbNimi2.Location.X, lbNimi2.Location.Y - 1);
            if (lbNimi2.Location.Y > this.Height)
            {
                lbNimi2.Location = new Point(lbNimi2.Location.X, 0 - lbNimi2.Height);
            }

            //Tietty korkeus saavutettu pysäytetään timer ja tuodaan title näkyviin
            if (lbTekijat.Location.Y == 180)
            {
                timer.Stop();
                
                lbTitle.Show();

            }

        }

        //Päävalikkoon vievän napin toiminnot.
        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Paavalikko paavalikko = ((Paavalikko)Owner);

            credit.Stop();
            //Testi soiko musiikki päävalikossa ja laittaa saman asetuksen
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

        //Musiikin hiljennys napin toiminnot
        private void btMute_Click(object sender, EventArgs e)
        {
            //Nappia klikatessa musiikki pysähtyy tai jatkuu
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                credit.Stop();
                Paavalikko.mute = false;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                credit.PlayLooping();
                Paavalikko.mute = true;
            }
        }
    }
}
