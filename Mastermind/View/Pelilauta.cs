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
    public partial class Pelilauta : Form
    {
        Ohjain registerHandler = new Ohjain();
        private Kayttajavalikko kayttajavalikko;
        string b;
        int y;
        PictureBox[] pictureBoxs = new PictureBox[4];
        PictureBox[] varit = new PictureBox[8];

        public Pelilauta(Kayttajavalikko kayttajavalikko)
        { 
            InitializeComponent();

            this.kayttajavalikko = kayttajavalikko;

            pictureBoxs[0] = pbOikea1;
            pictureBoxs[1] = pbOikea2;
            pictureBoxs[2] = pbOikea3;
            pictureBoxs[3] = pbOikea4;

            varit[0] = pbKeltainen;
            varit[1] = pbOranssi;
            varit[2] = pbPinkki;
            varit[3] = pbPunainen;
            varit[4] = pbSininen;
            varit[5] = pbTurkoosi;
            varit[6] = pbVihrea;
            varit[7] = pbVioletti;

        }

        private void Pelilauta_Load(object sender, EventArgs e)
        {
            lbKayttaja.Text = b;

            pb1R1.AllowDrop = true;
            pb2R1.AllowDrop = true;
            pb3R1.AllowDrop = true;
            pb4R1.AllowDrop = true;

            OikeaRivi();
        }

        public void ab(string a)
        {
            b = a.ToString();
        }

        public void yx(int x)
        {
            y = x;
        }

        private void btLuovuta_Click(object sender, EventArgs e)
        {
            Close();

            Kayttajat user = new Kayttajat();
            user.Haviot = y;

            registerHandler.Haviot(user);
        }

        public void OikeaRivi()
        {
            Random random = new Random();
            int vari;

            for (int i = 0; i < 4; i++)
            {
                vari = random.Next(1, 9);

                if (vari == 1)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.keltainenpampula;
                }

                else if (vari == 2)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.oranssipampula;
                }

                else if (vari == 3)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.pinkkipampula;
                }

                else if (vari == 4)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.punainenpampula;
                }

                else if (vari == 5)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.sininenpampula;
                }

                else if (vari == 6)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.turkoosipampula;
                }

                else if (vari == 7)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.vihreapampula;
                }

                else if (vari == 8)
                {
                    pictureBoxs[i].Image = Mastermind.Properties.Resources.violettipampula;
                }
            }

        }

        private void DragDrop1(object sender, DragEventArgs e)
        {
            pb1R1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDrop2(object sender, DragEventArgs e)
        {
            pb2R1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDrop3(object sender, DragEventArgs e)
        {
            pb3R1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDrop4(object sender, DragEventArgs e)
        {
            pb4R1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void Siirra1(object sender, MouseEventArgs e)
        {
            pbKeltainen.DoDragDrop(pbKeltainen.Image, DragDropEffects.Copy);
            this.pbKeltainen.Visible = true;
        }

        private void Siirra2(object sender, MouseEventArgs e)
        {
            pbOranssi.DoDragDrop(pbOranssi.Image, DragDropEffects.Copy);
            this.pbOranssi.Visible = true;
        }
        private void Siirra3(object sender, MouseEventArgs e)
        {
            pbPinkki.DoDragDrop(pbPinkki.Image, DragDropEffects.Copy);
            this.pbPinkki.Visible = true;
        }
        private void Siirra4(object sender, MouseEventArgs e)
        {
            pbPunainen.DoDragDrop(pbPunainen.Image, DragDropEffects.Copy);
            this.pbPunainen.Visible = true;
        }
        private void Siirra5(object sender, MouseEventArgs e)
        {
            pbSininen.DoDragDrop(pbSininen.Image, DragDropEffects.Copy);
            this.pbSininen.Visible = true;
        }
        private void Siirra6(object sender, MouseEventArgs e)
        {
            pbTurkoosi.DoDragDrop(pbTurkoosi.Image, DragDropEffects.Copy);
            this.pbTurkoosi.Visible = true;
        }
        private void Siirra7(object sender, MouseEventArgs e)
        {
            pbVihrea.DoDragDrop(pbVihrea.Image, DragDropEffects.Copy);
            this.pbVihrea.Visible = true;
        }
        private void Siirra8(object sender, MouseEventArgs e)
        {
            pbVioletti.DoDragDrop(pbVioletti.Image, DragDropEffects.Copy);
            this.pbVihrea.Visible = true;
        }

        private void btTarkista_Click(object sender, EventArgs e)
        {
            if (pb1R1.Image == pictureBoxs[0].Image)
            {
                MessageBox.Show("terve");
            }
        }
    }
}
