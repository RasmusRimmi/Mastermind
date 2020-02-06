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

namespace Mastermind
{
    public partial class Saavutukset : Form
    {
        private Paavalikko paavalikko;
        Ohjain registerHandler = new Ohjain();

        public Saavutukset(Paavalikko paavalikko)
        {
            InitializeComponent();

            this.paavalikko = paavalikko;
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Saavutukset_Load(object sender, EventArgs e)
        {
            cbKayttaja.DataSource = registerHandler.KaikkiKayttajat();
            cbKayttaja.DisplayMember = "kayttaja";
            cbKayttaja.ValueMember = "kayttajaId";
        }
    }
}
