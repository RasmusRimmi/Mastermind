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
using System.Media;


namespace Mastermind
{
    public partial class Pisteporssi : Form
    {
        private Paavalikko paavalikko;
        Ohjain registerHandler = new Ohjain();
        bool kato = true;
        SoundPlayer musa = new SoundPlayer(Properties.Resources.TilastoMusic);
        SoundPlayer menu = new SoundPlayer(Properties.Resources.MastermindMenu8bit);

        Label lb1Pel = new Label();
        Label lb2Pel = new Label();
        Label lb3Pel = new Label();
        Label lb4Pel = new Label();
        Label lb5Pel = new Label();

        Label lb1Voit = new Label();
        Label lb2Voit = new Label();        
        Label lb3Voit = new Label();     
        Label lb4Voit = new Label();       
        Label lb5Voit = new Label();

        Label lb1Pel1 = new Label();
        Label lb2Pel1 = new Label();
        Label lb3Pel1 = new Label();
        Label lb4Pel1 = new Label();
        Label lb5Pel1 = new Label();

        Label lb1Hav1 = new Label();       
        Label lb2Hav1 = new Label();       
        Label lb3Hav1 = new Label();       
        Label lb4Hav1 = new Label();      
        Label lb5Hav1 = new Label();

        public Pisteporssi(Paavalikko paavalikko)
        {
            InitializeComponent();

            this.paavalikko = paavalikko;

            VoittoTilasto();

            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                musa.PlayLooping();
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                musa.Stop();
            }
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Paavalikko paavalikko = ((Paavalikko)Owner);

            musa.Stop();

            if (Paavalikko.mute == true)
            {
                Paavalikko.menu.PlayLooping();
            }

            else if (Paavalikko.mute == false)
            {
                Paavalikko.menu.Stop();
            }

            this.Close();
        }

        public void VoittoTilasto()
        {
            if (registerHandler.VoittoTilastot().Tables[0].Rows.Count == 1)
            {
                lb1Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel.Location = new Point(12, 177);
                lb1Pel.ForeColor = Color.LightCoral;
                lb1Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel.AutoSize = true;

                lb1Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Voitot"].ToString();
                lb1Voit.Location = new Point(221, 177);
                lb1Voit.ForeColor = Color.LightCoral;
                lb1Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Voit.AutoSize = true;

                this.Controls.Add(lb1Pel);
                this.Controls.Add(lb1Voit);
            }

            if (registerHandler.VoittoTilastot().Tables[0].Rows.Count == 2)
            {
                lb1Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel.Location = new Point(12, 177);
                lb1Pel.ForeColor = Color.LightCoral;
                lb1Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel.AutoSize = true;

                lb1Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Voitot"].ToString();
                lb1Voit.Location = new Point(221, 177);
                lb1Voit.ForeColor = Color.LightCoral;
                lb1Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Voit.AutoSize = true;

                lb2Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel.Location = new Point(12, 218);
                lb2Pel.ForeColor = Color.LightCoral;
                lb2Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel.AutoSize = true;

                lb2Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Voitot"].ToString();
                lb2Voit.Location = new Point(221, 218);
                lb2Voit.ForeColor = Color.LightCoral;
                lb2Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Voit.AutoSize = true;

                this.Controls.Add(lb1Pel);
                this.Controls.Add(lb1Voit);
                this.Controls.Add(lb2Pel);
                this.Controls.Add(lb2Voit);
            }

            if(registerHandler.VoittoTilastot().Tables[0].Rows.Count == 3)
            {
                lb1Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel.Location = new Point(12, 177);
                lb1Pel.ForeColor = Color.LightCoral;
                lb1Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel.AutoSize = true;

                lb1Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Voitot"].ToString();
                lb1Voit.Location = new Point(221, 177);
                lb1Voit.ForeColor = Color.LightCoral;
                lb1Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Voit.AutoSize = true;

                lb2Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel.Location = new Point(12, 218);
                lb2Pel.ForeColor = Color.LightCoral;
                lb2Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel.AutoSize = true;

                lb2Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Voitot"].ToString();
                lb2Voit.Location = new Point(221, 218);
                lb2Voit.ForeColor = Color.LightCoral;
                lb2Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Voit.AutoSize = true;

                lb3Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel.Location = new Point(12, 257);
                lb3Pel.ForeColor = Color.LightCoral;
                lb3Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel.AutoSize = true;

                lb3Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Voitot"].ToString();
                lb3Voit.Location = new Point(221, 257);
                lb3Voit.ForeColor = Color.LightCoral;
                lb3Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Voit.AutoSize = true;

                this.Controls.Add(lb1Pel);
                this.Controls.Add(lb1Voit);
                this.Controls.Add(lb2Pel);
                this.Controls.Add(lb2Voit);
                this.Controls.Add(lb3Pel);
                this.Controls.Add(lb3Voit);
            }

            if (registerHandler.VoittoTilastot().Tables[0].Rows.Count == 4)
            {
                lb1Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel.Location = new Point(12, 177);
                lb1Pel.ForeColor = Color.LightCoral;
                lb1Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel.AutoSize = true;

                lb1Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Voitot"].ToString();
                lb1Voit.Location = new Point(221, 177);
                lb1Voit.ForeColor = Color.LightCoral;
                lb1Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Voit.AutoSize = true;

                lb2Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel.Location = new Point(12, 218);
                lb2Pel.ForeColor = Color.LightCoral;
                lb2Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel.AutoSize = true;

                lb2Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Voitot"].ToString();
                lb2Voit.Location = new Point(221, 218);
                lb2Voit.ForeColor = Color.LightCoral;
                lb2Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Voit.AutoSize = true;

                lb3Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel.Location = new Point(12, 257);
                lb3Pel.ForeColor = Color.LightCoral;
                lb3Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel.AutoSize = true;

                lb3Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Voitot"].ToString();
                lb3Voit.Location = new Point(221, 257);
                lb3Voit.ForeColor = Color.LightCoral;
                lb3Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Voit.AutoSize = true;

                lb4Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[3]["Kayttaja"].ToString().ToUpper();
                lb4Pel.Location = new Point(12, 296);
                lb4Pel.ForeColor = Color.LightCoral;
                lb4Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Pel.AutoSize = true;

                lb4Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[3]["Voitot"].ToString();
                lb4Voit.Location = new Point(221, 296);
                lb4Voit.ForeColor = Color.LightCoral;
                lb4Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Voit.AutoSize = true;

                this.Controls.Add(lb1Pel);
                this.Controls.Add(lb1Voit);
                this.Controls.Add(lb2Pel);
                this.Controls.Add(lb2Voit);
                this.Controls.Add(lb3Pel);
                this.Controls.Add(lb3Voit);
                this.Controls.Add(lb4Pel);
                this.Controls.Add(lb4Voit);
            }

            if (registerHandler.VoittoTilastot().Tables[0].Rows.Count >= 5)
            {
                lb1Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel.Location = new Point(12, 177);
                lb1Pel.ForeColor = Color.LightCoral;
                lb1Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel.AutoSize = true;

                lb1Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[0]["Voitot"].ToString();
                lb1Voit.Location = new Point(221, 177);
                lb1Voit.ForeColor = Color.LightCoral;
                lb1Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Voit.AutoSize = true;

                lb2Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel.Location = new Point(12, 218);
                lb2Pel.ForeColor = Color.LightCoral;
                lb2Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel.AutoSize = true;

                lb2Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[1]["Voitot"].ToString();
                lb2Voit.Location = new Point(221, 218);
                lb2Voit.ForeColor = Color.LightCoral;
                lb2Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Voit.AutoSize = true;

                lb3Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel.Location = new Point(12, 257);
                lb3Pel.ForeColor = Color.LightCoral;
                lb3Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel.AutoSize = true;

                lb3Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[2]["Voitot"].ToString();
                lb3Voit.Location = new Point(221, 257);
                lb3Voit.ForeColor = Color.LightCoral;
                lb3Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Voit.AutoSize = true;

                lb4Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[3]["Kayttaja"].ToString().ToUpper();
                lb4Pel.Location = new Point(12, 296);
                lb4Pel.ForeColor = Color.LightCoral;
                lb4Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Pel.AutoSize = true;

                lb4Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[3]["Voitot"].ToString();
                lb4Voit.Location = new Point(221, 296);
                lb4Voit.ForeColor = Color.LightCoral;
                lb4Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Voit.AutoSize = true;

                lb5Pel.Text = registerHandler.VoittoTilastot().Tables[0].Rows[4]["Kayttaja"].ToString().ToUpper();
                lb5Pel.Location = new Point(12, 335);
                lb5Pel.ForeColor = Color.LightCoral;
                lb5Pel.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb5Pel.AutoSize = true;

                lb5Voit.Text = registerHandler.VoittoTilastot().Tables[0].Rows[4]["Voitot"].ToString();
                lb5Voit.Location = new Point(221, 335);
                lb5Voit.ForeColor = Color.LightCoral;
                lb5Voit.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb5Voit.AutoSize = true;

                this.Controls.Add(lb1Pel);
                this.Controls.Add(lb1Voit);
                this.Controls.Add(lb2Pel);
                this.Controls.Add(lb2Voit);
                this.Controls.Add(lb3Pel);
                this.Controls.Add(lb3Voit);
                this.Controls.Add(lb4Pel);
                this.Controls.Add(lb4Voit);
                this.Controls.Add(lb5Pel);
                this.Controls.Add(lb5Voit);
            }

        }

        private void HavioTilasto()
        {
            if(registerHandler.HavioTilastot().Tables[0].Rows.Count == 1)
            {
                lb1Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel1.Location = new Point(12, 177);
                lb1Pel1.ForeColor = Color.LightCoral;
                lb1Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel1.AutoSize = true;

                lb1Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Haviot"].ToString();
                lb1Hav1.Location = new Point(221, 177);
                lb1Hav1.ForeColor = Color.LightCoral;
                lb1Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Hav1.AutoSize = true;
            }

            if (registerHandler.HavioTilastot().Tables[0].Rows.Count == 2)
            {
                lb1Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel1.Location = new Point(12, 177);
                lb1Pel1.ForeColor = Color.LightCoral;
                lb1Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel1.AutoSize = true;

                lb1Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Haviot"].ToString();
                lb1Hav1.Location = new Point(221, 177);
                lb1Hav1.ForeColor = Color.LightCoral;
                lb1Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Hav1.AutoSize = true;

                lb2Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel1.Location = new Point(12, 218);
                lb2Pel1.ForeColor = Color.LightCoral;
                lb2Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel1.AutoSize = true;

                lb2Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Haviot"].ToString();
                lb2Hav1.Location = new Point(221, 218);
                lb2Hav1.ForeColor = Color.LightCoral;
                lb2Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Hav1.AutoSize = true;
            }

            if (registerHandler.HavioTilastot().Tables[0].Rows.Count == 3)
            {
                lb1Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel1.Location = new Point(12, 177);
                lb1Pel1.ForeColor = Color.LightCoral;
                lb1Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel1.AutoSize = true;

                lb1Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Haviot"].ToString();
                lb1Hav1.Location = new Point(221, 177);
                lb1Hav1.ForeColor = Color.LightCoral;
                lb1Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Hav1.AutoSize = true;

                lb2Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel1.Location = new Point(12, 218);
                lb2Pel1.ForeColor = Color.LightCoral;
                lb2Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel1.AutoSize = true;

                lb2Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Haviot"].ToString();
                lb2Hav1.Location = new Point(221, 218);
                lb2Hav1.ForeColor = Color.LightCoral;
                lb2Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Hav1.AutoSize = true;

                lb3Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel1.Location = new Point(12, 257);
                lb3Pel1.ForeColor = Color.LightCoral;
                lb3Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel1.AutoSize = true;

                lb3Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Haviot"].ToString();
                lb3Hav1.Location = new Point(221, 257);
                lb3Hav1.ForeColor = Color.LightCoral;
                lb3Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Hav1.AutoSize = true;
            }

            if (registerHandler.HavioTilastot().Tables[0].Rows.Count == 4)
            {
                lb1Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel1.Location = new Point(12, 177);
                lb1Pel1.ForeColor = Color.LightCoral;
                lb1Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel1.AutoSize = true;

                lb1Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Haviot"].ToString();
                lb1Hav1.Location = new Point(221, 177);
                lb1Hav1.ForeColor = Color.LightCoral;
                lb1Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Hav1.AutoSize = true;

                lb2Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel1.Location = new Point(12, 218);
                lb2Pel1.ForeColor = Color.LightCoral;
                lb2Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel1.AutoSize = true;

                lb2Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Haviot"].ToString();
                lb2Hav1.Location = new Point(221, 218);
                lb2Hav1.ForeColor = Color.LightCoral;
                lb2Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Hav1.AutoSize = true;

                lb3Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel1.Location = new Point(12, 257);
                lb3Pel1.ForeColor = Color.LightCoral;
                lb3Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel1.AutoSize = true;

                lb3Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Haviot"].ToString();
                lb3Hav1.Location = new Point(221, 257);
                lb3Hav1.ForeColor = Color.LightCoral;
                lb3Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Hav1.AutoSize = true;

                lb4Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[3]["Kayttaja"].ToString().ToUpper();
                lb4Pel1.Location = new Point(12, 296);
                lb4Pel1.ForeColor = Color.LightCoral;
                lb4Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Pel1.AutoSize = true;

                lb4Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[3]["Haviot"].ToString();
                lb4Hav1.Location = new Point(221, 296);
                lb4Hav1.ForeColor = Color.LightCoral;
                lb4Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Hav1.AutoSize = true;
            }

            if (registerHandler.HavioTilastot().Tables[0].Rows.Count >= 5)
            {
                lb1Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Kayttaja"].ToString().ToUpper();
                lb1Pel1.Location = new Point(12, 177);
                lb1Pel1.ForeColor = Color.LightCoral;
                lb1Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Pel1.AutoSize = true;

                lb1Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[0]["Haviot"].ToString();
                lb1Hav1.Location = new Point(221, 177);
                lb1Hav1.ForeColor = Color.LightCoral;
                lb1Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb1Hav1.AutoSize = true;

                lb2Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Kayttaja"].ToString().ToUpper();
                lb2Pel1.Location = new Point(12, 218);
                lb2Pel1.ForeColor = Color.LightCoral;
                lb2Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Pel1.AutoSize = true;

                lb2Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[1]["Haviot"].ToString();
                lb2Hav1.Location = new Point(221, 218);
                lb2Hav1.ForeColor = Color.LightCoral;
                lb2Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb2Hav1.AutoSize = true;

                lb3Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Kayttaja"].ToString().ToUpper();
                lb3Pel1.Location = new Point(12, 257);
                lb3Pel1.ForeColor = Color.LightCoral;
                lb3Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Pel1.AutoSize = true;

                lb3Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[2]["Haviot"].ToString();
                lb3Hav1.Location = new Point(221, 257);
                lb3Hav1.ForeColor = Color.LightCoral;
                lb3Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb3Hav1.AutoSize = true;

                lb4Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[3]["Kayttaja"].ToString().ToUpper();
                lb4Pel1.Location = new Point(12, 296);
                lb4Pel1.ForeColor = Color.LightCoral;
                lb4Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Pel1.AutoSize = true;

                lb4Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[3]["Haviot"].ToString();
                lb4Hav1.Location = new Point(221, 296);
                lb4Hav1.ForeColor = Color.LightCoral;
                lb4Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb4Hav1.AutoSize = true;

                lb5Pel1.Text = registerHandler.HavioTilastot().Tables[0].Rows[4]["Kayttaja"].ToString().ToUpper();
                lb5Pel1.Location = new Point(12, 335);
                lb5Pel1.ForeColor = Color.LightCoral;
                lb5Pel1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb5Pel1.AutoSize = true;

                lb5Hav1.Text = registerHandler.HavioTilastot().Tables[0].Rows[4]["Haviot"].ToString();
                lb5Hav1.Location = new Point(221, 335);
                lb5Hav1.ForeColor = Color.LightCoral;
                lb5Hav1.Font = new Font("Mistral", 24.75F, FontStyle.Bold);
                lb5Hav1.AutoSize = true;
            }

            this.Controls.Add(lb1Pel1);
            this.Controls.Add(lb1Hav1);
            this.Controls.Add(lb2Pel1);
            this.Controls.Add(lb2Hav1);
            this.Controls.Add(lb3Pel1);
            this.Controls.Add(lb3Hav1);
            this.Controls.Add(lb4Pel1);
            this.Controls.Add(lb4Hav1);
            this.Controls.Add(lb5Pel1);
            this.Controls.Add(lb5Hav1);

        }

        private void btVoitotHaviot_Click(object sender, EventArgs e)
        {
            if(kato == true)
            {
                HavioTilasto();
                kato = false;
                btVoitotHaviot.Text = "VOITOT";
                label13.Text = "HÄVIÖT";

                lb1Pel.Hide();
                lb1Voit.Hide();
                lb2Pel.Hide();
                lb2Voit.Hide();
                lb3Pel.Hide();
                lb3Voit.Hide();
                lb4Pel.Hide();
                lb4Voit.Hide();
                lb5Pel.Hide();
                lb5Voit.Hide();

                lb1Pel1.Show();
                lb1Hav1.Show();
                lb2Pel1.Show();
                lb2Hav1.Show();
                lb3Pel1.Show();
                lb3Hav1.Show();
                lb4Pel1.Show();
                lb4Hav1.Show();
                lb5Pel1.Show();
                lb5Hav1.Show();
            }

            else if(kato == false)
            {
                VoittoTilasto();
                kato = true;
                btVoitotHaviot.Text = "HÄVIÖT";
                label13.Text = "VOITOT";

                lb1Pel1.Hide();
                lb1Hav1.Hide();
                lb2Pel1.Hide();
                lb2Hav1.Hide();
                lb3Pel1.Hide();
                lb3Hav1.Hide();
                lb4Pel1.Hide();
                lb4Hav1.Hide();
                lb5Pel1.Hide();
                lb5Hav1.Hide();

                lb1Pel.Show();
                lb1Voit.Show();
                lb2Pel.Show();
                lb2Voit.Show();
                lb3Pel.Show();
                lb3Voit.Show();
                lb4Pel.Show();
                lb4Voit.Show();
                lb5Pel.Show();
                lb5Voit.Show();
            }
        }

        private void btMute_Click(object sender, EventArgs e)
        {
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                musa.Stop();
                Paavalikko.mute = false;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                musa.PlayLooping();
                Paavalikko.mute = true;
            }
        }
    }
}
