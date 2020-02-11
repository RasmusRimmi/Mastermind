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
        PictureBox[] oikeaRivi = new PictureBox[4];
        PictureBox[] varit = new PictureBox[8];
        PictureBox[] rivi = new PictureBox[40];
        PictureBox[,] Rivit = new PictureBox[10,4];
        PictureBox[,] Tarkistus = new PictureBox[10, 4];

        public Pelilauta(Kayttajavalikko kayttajavalikko)
        { 
            InitializeComponent();

            this.kayttajavalikko = kayttajavalikko;

            oikeaRivi[0] = pbOikea1;
            oikeaRivi[1] = pbOikea2;
            oikeaRivi[2] = pbOikea3;
            oikeaRivi[3] = pbOikea4;

            varit[0] = pbKeltainen;
            varit[1] = pbOranssi;
            varit[2] = pbPinkki;
            varit[3] = pbPunainen;
            varit[4] = pbSininen;
            varit[5] = pbTurkoosi;
            varit[6] = pbVihrea;
            varit[7] = pbVioletti;

            Rivit[0, 0] = pb1R1;
            Rivit[0, 1] = pb2R1;
            Rivit[0, 2] = pb3R1;
            Rivit[0, 3] = pb4R1;
            Rivit[1, 0] = pb1R2;
            Rivit[1, 1] = pb2R2;
            Rivit[1, 2] = pb3R2;
            Rivit[1, 3] = pb4R2;
            Rivit[2, 0] = pb1R3;
            Rivit[2, 1] = pb2R3;
            Rivit[2, 2] = pb3R3;
            Rivit[2, 3] = pb4R3;
            Rivit[3, 0] = pb1R4;
            Rivit[3, 1] = pb2R4;
            Rivit[3, 2] = pb3R4;
            Rivit[3, 3] = pb4R4;
            Rivit[4, 0] = pb1R5;
            Rivit[4, 1] = pb2R5;
            Rivit[4, 2] = pb3R5;
            Rivit[4, 3] = pb4R5;
            Rivit[5, 0] = pb1R6;
            Rivit[5, 1] = pb2R6;
            Rivit[5, 2] = pb3R6;
            Rivit[5, 3] = pb4R6;
            Rivit[6, 0] = pb1R7;
            Rivit[6, 1] = pb2R7;
            Rivit[6, 2] = pb3R7;
            Rivit[6, 3] = pb4R7;
            Rivit[7, 0] = pb1R8;
            Rivit[7, 1] = pb2R8;
            Rivit[7, 2] = pb3R8;
            Rivit[7, 3] = pb4R8;
            Rivit[8, 0] = pb1R9;
            Rivit[8, 1] = pb2R9;
            Rivit[8, 2] = pb3R9;
            Rivit[8, 3] = pb4R9;
            Rivit[9, 0] = pb1R10;
            Rivit[9, 1] = pb2R10;
            Rivit[9, 2] = pb3R10;
            Rivit[9, 3] = pb4R10;


            Tarkistus[0, 0] = pbTark1R1;
            Tarkistus[0, 1] = pbTark2R1;
            Tarkistus[0, 2] = pbTark3R1;
            Tarkistus[0, 3] = pbTark4R1;
            Tarkistus[1, 0] = pbTark1R2;
            Tarkistus[1, 1] = pbTark2R2;
            Tarkistus[1, 2] = pbTark3R2;
            Tarkistus[1, 3] = pbTark4R2;
            Tarkistus[2, 0] = pbTark1R3;
            Tarkistus[2, 1] = pbTark2R3;
            Tarkistus[2, 2] = pbTark3R3;
            Tarkistus[2, 3] = pbTark4R3;
            Tarkistus[3, 0] = pbTark1R4;
            Tarkistus[3, 1] = pbTark2R4;
            Tarkistus[3, 2] = pbTark3R4;
            Tarkistus[3, 3] = pbTark4R4;
            Tarkistus[4, 0] = pbTark1R5;
            Tarkistus[4, 1] = pbTark2R5;
            Tarkistus[4, 2] = pbTark3R5;
            Tarkistus[4, 3] = pbTark4R5;
            Tarkistus[5, 0] = pbTark1R6;
            Tarkistus[5, 1] = pbTark2R6;
            Tarkistus[5, 2] = pbTark3R6;
            Tarkistus[5, 3] = pbTark4R6;
            Tarkistus[6, 0] = pbTark1R7;
            Tarkistus[6, 1] = pbTark2R7;
            Tarkistus[6, 2] = pbTark3R7;
            Tarkistus[6, 3] = pbTark4R7;
            Tarkistus[7, 0] = pbTark1R8;
            Tarkistus[7, 1] = pbTark2R8;
            Tarkistus[7, 2] = pbTark3R8;
            Tarkistus[7, 3] = pbTark4R8;
            Tarkistus[8, 0] = pbTark1R9;
            Tarkistus[8, 1] = pbTark2R9;
            Tarkistus[8, 2] = pbTark3R9;
            Tarkistus[8, 3] = pbTark4R9;
            Tarkistus[9, 0] = pbTark1R10;
            Tarkistus[9, 1] = pbTark2R10;
            Tarkistus[9, 2] = pbTark3R10;
            Tarkistus[9, 3] = pbTark4R10;
        }

        private void Pelilauta_Load(object sender, EventArgs e)
        {
            lbKayttaja.Text = b;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Rivit[i, j].AllowDrop = true;
                }
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Rivit[i, j].Hide();
                }
            }

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
        /// <summary>
        /// 
        /// </summary>
        public void OikeaRivi()
        {
            Random random = new Random();
            int vari;

            for (int i = 0; i < 4; i++)
            {
                vari = random.Next(1, 9);

                if (vari == 1)
                {
                    oikeaRivi[i].Image = pbKeltainen.Image;
                }

                else if (vari == 2)
                {
                    oikeaRivi[i].Image = pbOranssi.Image;
                }

                else if (vari == 3)
                {
                    oikeaRivi[i].Image = pbPinkki.Image;
                }

                else if (vari == 4)
                {
                    oikeaRivi[i].Image = pbPunainen.Image;
                }

                else if (vari == 5)
                {
                    oikeaRivi[i].Image = pbSininen.Image;
                }

                else if (vari == 6)
                {
                    oikeaRivi[i].Image = pbTurkoosi.Image;
                }

                else if (vari == 7)
                {
                    oikeaRivi[i].Image = pbVihrea.Image;
                }

                else if (vari == 8)
                {
                    oikeaRivi[i].Image = pbVioletti.Image;
                }
            }

        }

        private void DragDropR1P1(object sender, DragEventArgs e)
        {
            Rivit[0, 0].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR1P2(object sender, DragEventArgs e)
        {
            Rivit[0, 1].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR1P3(object sender, DragEventArgs e)
        {
            Rivit[0, 2].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR1P4(object sender, DragEventArgs e)
        {
            Rivit[0, 3].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR2P1(object sender, DragEventArgs e)
        {
            pb1R2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR2P2(object sender, DragEventArgs e)
        {
            pb2R2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR2P3(object sender, DragEventArgs e)
        {
            pb3R2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR2P4(object sender, DragEventArgs e)
        {
            pb4R2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR3P1(object sender, DragEventArgs e)
        {
            pb1R3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR3P2(object sender, DragEventArgs e)
        {
            pb2R3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR3P3(object sender, DragEventArgs e)
        {
            pb3R3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR3P4(object sender, DragEventArgs e)
        {
            pb4R3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR4P1(object sender, DragEventArgs e)
        {
            pb1R4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR4P2(object sender, DragEventArgs e)
        {
            pb2R4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR4P3(object sender, DragEventArgs e)
        {
            pb3R4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR4P4(object sender, DragEventArgs e)
        {
            pb4R4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR5P1(object sender, DragEventArgs e)
        {
            pb1R5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR5P2(object sender, DragEventArgs e)
        {
            pb2R5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR5P3(object sender, DragEventArgs e)
        {
            pb3R5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR5P4(object sender, DragEventArgs e)
        {
            pb4R5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR6P1(object sender, DragEventArgs e)
        {
            pb1R6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap); 
        }

        private void DragDropR6P2(object sender, DragEventArgs e)
        {
            pb2R6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR6P3(object sender, DragEventArgs e)
        {
            pb3R6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR6P4(object sender, DragEventArgs e)
        {
            pb4R6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR7P1(object sender, DragEventArgs e)
        {
            pb1R7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR7P2(object sender, DragEventArgs e)
        {
            pb2R7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR7P3(object sender, DragEventArgs e)
        {
            pb3R7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR7P4(object sender, DragEventArgs e)
        {
            pb4R7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR8P1(object sender, DragEventArgs e)
        {
            pb1R8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR8P2(object sender, DragEventArgs e)
        {
            pb2R8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR8P3(object sender, DragEventArgs e)
        {
            pb3R8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR8P4(object sender, DragEventArgs e)
        {
            pb4R8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR9P1(object sender, DragEventArgs e)
        {
            pb1R9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR9P2(object sender, DragEventArgs e)
        {
            pb2R9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR9P3(object sender, DragEventArgs e)
        {
            pb3R9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR9P4(object sender, DragEventArgs e)
        {
            pb4R9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void DragDropR10P1(object sender, DragEventArgs e)
        {
            pb1R10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR10P2(object sender, DragEventArgs e)
        {
            pb2R10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR10P3(object sender, DragEventArgs e)
        {
            pb3R10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void DragDropR10P4(object sender, DragEventArgs e)
        {
            pb4R10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
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
            

            for (int i = 0; i < 2; i++)
            {
                if (oikeaRivi[0].Image == Rivit[i, 0].Image && oikeaRivi[1].Image == Rivit[i, 1].Image && oikeaRivi[2].Image == Rivit[i, 2].Image && oikeaRivi[3].Image == Rivit[i, 3].Image)
                {
                    Kayttajat user = new Kayttajat();
                    user.Haviot = y;

                    registerHandler.Voitot(user);
                    //Close();

                    lbLoppu.Text = "VOITIT";
                    lbLoppu.ForeColor = Color.Lime;

                    Tarkistus[i,0].Image = pbPunainen.Image;
                    Tarkistus[i,1].Image = pbPunainen.Image;
                    Tarkistus[i,2].Image = pbPunainen.Image;
                    Tarkistus[i,3].Image = pbPunainen.Image;
                }

                else
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (Rivit[i, k].Image == oikeaRivi[0].Image || Rivit[i, k].Image == oikeaRivi[1].Image || Rivit[i, k].Image == oikeaRivi[2].Image || Rivit[i, k].Image == oikeaRivi[3].Image)
                        {
                            Tarkistus[0, k].Image = Properties.Resources.valkoinenpampula;

                            if (Rivit[i, 0].Image == oikeaRivi[0].Image)
                            {
                                Tarkistus[i, 0].Image = pbPunainen.Image;
                            }

                            if (Rivit[i, 1].Image == oikeaRivi[1].Image)
                            {
                                Tarkistus[i, 1].Image = pbPunainen.Image;
                            }

                            if (Rivit[i, 2].Image == oikeaRivi[2].Image)
                            {
                                Tarkistus[i, 2].Image = pbPunainen.Image;
                            }

                            if (Rivit[i, 3].Image == oikeaRivi[3].Image)
                            {
                                Tarkistus[i, 3].Image = pbPunainen.Image;
                            }
                      
                        }

                        for (int l = 0; l < 4; l++)
                        {
                            Rivit[0, l].AllowDrop = false;
                        }
                        
                        Rivit[i, k].Show();
                    }

                }

                //ekan rivin eka pallo
               

            }
            
            

            //else
            //{
            //    lbLoppu.Text = "HÄVISIT";
            //    lbLoppu.ForeColor = Color.Red;

            //    Kayttajat user = new Kayttajat();
            //    user.Haviot = y;

            //    registerHandler.Haviot(user);

            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (Rivit[0, j].Image == pictureBoxs[j].Image)
            //        {
            //            Tarkistus[0, j].Image = pbPunainen.Image;

            //        }

            //        else if (Rivit[0, j].Image == pbOikea1.Image || Rivit[0, j].Image == pbOikea2.Image || Rivit[0, j].Image == pbOikea3.Image || Rivit[0, j].Image == pbOikea4.Image)
            //        {

            //            Tarkistus[0, j].Image = Properties.Resources.valkoinenpampula;

            //        }

            //    }

            //}

        }


    }
}
