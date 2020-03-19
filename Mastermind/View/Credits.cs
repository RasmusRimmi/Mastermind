﻿using System;
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

        public Credits(Paavalikko paavalikko)
        {
            InitializeComponent();

            lbTitle.Hide();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = (70) * (1);         
            timer.Enabled = true;                      
            timer.Start();

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);

            lbTekijat.Top = 400;
            lbNimi1.Top = 400;
            lbNimi2.Top = 430;

        }

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

            if (lbTekijat.Location.Y == 180)
            {
                timer.Stop();
                
                lbTitle.Show();

            }

        }



        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Paavalikko paavalikko = ((Paavalikko)Owner);

            //musa.Stop();

            //if (Paavalikko.mute == true)
            //{
            //    Paavalikko.menu.PlayLooping();
            //}

            //else if (Paavalikko.mute == false)
            //{
            //    Paavalikko.menu.Stop();
            //}

            Close();
        }
    }
}
