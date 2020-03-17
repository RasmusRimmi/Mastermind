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
            timer.Interval = (100) * (1);         
            timer.Enabled = true;                      
            timer.Start();                             

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbSuunnittelu.Location = new Point(lbSuunnittelu.Location.X, lbSuunnittelu.Location.Y - 2);
            lbToteutus.Location = new Point(lbToteutus.Location.X, lbToteutus.Location.Y - 2);

            if (lbSuunnittelu.Location.Y > this.Height)
            {
                lbSuunnittelu.Location = new Point(lbSuunnittelu.Location.X, 0 - lbSuunnittelu.Height);
            }

            if (lbToteutus.Location.Y > this.Height)
            {
                lbToteutus.Location = new Point(lbToteutus.Location.X, 0 - lbToteutus.Height);
            }
        }

    }
}
