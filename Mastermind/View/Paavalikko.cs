﻿using System;
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
    public partial class Paavalikko : Form
    {
        public Paavalikko()
        {
            InitializeComponent();
        }

        private void btYksinpeli_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var kayttajavalikko = new Kayttajavalikko(this))
            {
                kayttajavalikko.ShowDialog();
                this.Show();   
            }
        }

        private void btSaavutukset_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var saavutukset = new Saavutukset(this))
            {
                saavutukset.ShowDialog();
                this.Show();
            }
        }

        private void btTulokset_Click(object sender, EventArgs e)
        {

            this.Hide();

            using (var tulokset = new Pisteporssi(this))
            {
                tulokset.ShowDialog();
                this.Show();
            }
        }
    }
}
