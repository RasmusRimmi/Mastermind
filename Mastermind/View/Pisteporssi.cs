using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastermind.Model;
using Mastermind.Controller;


namespace Mastermind
{
    public partial class Pisteporssi : Form
    {
        private Paavalikko paavalikko;
        Ohjain registerHandler = new Ohjain();

        public Pisteporssi(Paavalikko paavalikko)
        {
            InitializeComponent();

            this.paavalikko = paavalikko;

            showdata();
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showdata()
        {
            dgvPisteporssi.DataSource = registerHandler.Tilastot();
        }
    }
}
