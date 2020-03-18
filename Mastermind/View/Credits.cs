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

        public Credits(Paavalikko paavalikko)
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = (70) * (1);         
            timer.Enabled = true;                      
            timer.Start();                             

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbSuunnittelu.Location = new Point(lbSuunnittelu.Location.X, lbSuunnittelu.Location.Y - 1);
            if (lbSuunnittelu.Location.Y > this.Height)
            {
                lbSuunnittelu.Location = new Point(lbSuunnittelu.Location.X, 0 - lbSuunnittelu.Height);
            }

            lbToteutus.Location = new Point(lbToteutus.Location.X, lbToteutus.Location.Y - 1);
            if (lbToteutus.Location.Y > this.Height)
            {
                lbToteutus.Location = new Point(lbToteutus.Location.X, 0 - lbToteutus.Height);
            }

            lbTitle.Location = new Point(lbTitle.Location.X, lbTitle.Location.Y - 1);
            if (lbTitle.Location.Y > this.Height)
            {
                lbTitle.Location = new Point(lbTitle.Location.X, 0 - lbTitle.Height);
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

            lbNimi3.Location = new Point(lbNimi3.Location.X, lbNimi3.Location.Y - 1);
            if (lbNimi3.Location.Y > this.Height)
            {
                lbNimi3.Location = new Point(lbNimi3.Location.X, 0 - lbNimi3.Height);
            }

            lbNimi4.Location = new Point(lbNimi4.Location.X, lbNimi4.Location.Y - 1);
            if (lbNimi4.Location.Y > this.Height)
            {
                lbNimi4.Location = new Point(lbNimi4.Location.X, 0 - lbNimi4.Height);
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
