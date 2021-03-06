﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mastermind
{
    public partial class Paavalikko : Form
    {
        private static SoundPlayer _menu = new SoundPlayer(Properties.Resources.MastermindMenu8bit);
        private static bool _mute = true;

        //mute-nappi, jota voi käyttää kaikissa formeissa
        public static bool mute
        {
            get
            {
                return _mute;
            }

            set{
                _mute = value;
            }
        }

        //menun musiikki, jota voi käyttää kaikissa formeissa
        public static SoundPlayer menu
        {
            get
            {
                return _menu;
            }

            set
            {
                _menu = value;
            }
        }

        public Paavalikko()
        {
            InitializeComponent();

            if (mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                menu.PlayLooping();
            }
            

            if (mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                menu.Stop();
            }

        }

        //Avaa käyttäjävalikon
        private void btYksinpeli_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var kayttajavalikko = new Kayttajavalikko(this))
            {
                kayttajavalikko.ShowDialog();
                this.Show();

                if (mute == true)
                {
                    btMute.BackgroundImage = Properties.Resources.on;
                }

                else if(mute == false)
                {
                    btMute.BackgroundImage = Properties.Resources.off;
                }
            }
        }

        //Avaa creditsit
        private void btCredits_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var credits = new Credits(this))
            {
                credits.ShowDialog();
                this.Show();

                if (mute == true)
                {
                    btMute.BackgroundImage = Properties.Resources.on;
                }

                else if (mute == false)
                {
                    btMute.BackgroundImage = Properties.Resources.off;
                }
            }
        }

        //Avaa saavutukset
        private void btSaavutukset_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var saavutukset = new Saavutukset(this))
            {
                saavutukset.ShowDialog();
                this.Show();

                if (mute == true)
                {
                    btMute.BackgroundImage = Properties.Resources.on;
                }

                else if (mute == false)
                {
                    btMute.BackgroundImage = Properties.Resources.off;
                }
            }
        }

        //Avaa tulokset
        private void btTulokset_Click(object sender, EventArgs e)
        {

            this.Hide();

            using (var tulokset = new Pisteporssi(this))
            {
                tulokset.ShowDialog();
                this.Show();

                if (mute == true)
                {
                    btMute.BackgroundImage = Properties.Resources.on;
                }

                else if (mute == false)
                {
                    btMute.BackgroundImage = Properties.Resources.off;
                }
            }
        }

        private void Paavalikko_Load(object sender, EventArgs e)
        {
            
        }

        //Musiikin hiljennys napin toiminnot.
        private void btMute_Click(object sender, EventArgs e)
        {

            if (mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                menu.Stop();
                mute = false;
            }

            else if (mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                menu.PlayLooping();
                mute = true;
            }                         
        }


    }
}
