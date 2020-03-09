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

            tilasto();
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tilasto()
        {
            foreach(DataRow dr in registerHandler.Tilastot().Tables[0].Rows)
            {
                label3.Text = registerHandler.Tilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                label4.Text = registerHandler.Tilastot().Tables[0].Rows[0]["Voitot"].ToString();
                label5.Text = registerHandler.Tilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                label6.Text = registerHandler.Tilastot().Tables[0].Rows[1]["Voitot"].ToString();
                label7.Text = registerHandler.Tilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                label8.Text = registerHandler.Tilastot().Tables[0].Rows[2]["Voitot"].ToString();
                label9.Text = registerHandler.Tilastot().Tables[0].Rows[3]["Kayttaja"].ToString().ToUpper();
                label10.Text = registerHandler.Tilastot().Tables[0].Rows[3]["Voitot"].ToString();
                label11.Text = registerHandler.Tilastot().Tables[0].Rows[4]["Kayttaja"].ToString().ToUpper();
                label12.Text = registerHandler.Tilastot().Tables[0].Rows[4]["Voitot"].ToString();
            }

        }

    }
}
