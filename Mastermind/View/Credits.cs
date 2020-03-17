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
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 2);

            if (label1.Location.Y > this.Height)
            {
                label1.Location = new Point(label1.Location.X, 0 - label1.Height);
            }
        }
    }
}
