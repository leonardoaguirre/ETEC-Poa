using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroOndas
{
    public partial class Microondas : Form
    {
        int min, seg, i;

     
        public Microondas()
        {
            InitializeComponent();
        }
        private void btn30seg_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer pal = new System.Media.SoundPlayer(
            MicroOndas.Properties.Resources.btn);
            pal.Play();
            if (min < 60)
            {

 
                seg+=30;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            seg = seg % 60;
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btncanelar_Click(object sender, EventArgs e)
        {

            lbTimer.Text = "00:00";
            seg = 0;
            min = 0;
            i = 0;
            btnligar.Text = "Iniciar";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 59;
            }
            else
           if (seg > 0)
            {
                seg--; 
            }
            else
            {
                timer1.Stop();
            }



            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);
        }

        private void btnligar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                MessageBox.Show("Para sua segurança, o microondas funciona somente com a porta fechada!");
            }
            else
            {
                if (seg > 0 || min > 0)
                {
                    i++;
                    if (i % 2 == 1)
                    {
                        timer1.Start(); 
                        btnligar.Text = "Pausar";
                    }
                    else
                    {
                        timer1.Stop();
                        btnligar.Text = "Iniciar";
                    }
                }
            }


        }

        private void btn2min_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 2;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btn5min_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 5;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);
        }

        private void btn10min_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 10;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }

            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnarroz_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 16;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnleite_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {
                min += 1;
                seg += 10;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            seg = seg % 60;
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnpipoca_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {
                min += 2;
                seg += 50;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            seg = seg % 60;
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnmacarrao_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 6;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btncarnemoida_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 8;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }

            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btndoces_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                seg += 7;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }

            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btngratinar_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {

                min += 3;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }

            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnbovina_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {
                min += 13;
                seg += 25;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            seg = seg % 60;
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btnfrango_Click(object sender, EventArgs e)
        {
            if (min < 60)
            {
                min += 11;
                seg += 30;
                if (seg > 59)
                {
                    min += 1;
                }
            }
            else
            {
                min = 60;
                seg = 00;
                MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
            }
            seg = seg % 60;
            lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

        }

        private void btn1min_Click(object sender, EventArgs e)
        {
            {
                if (min < 60)
                {

                    min += 1;
                    if (seg > 59)
                    {
                        min += 1;
                    }
                }
                else
                {
                    min = 60;
                    seg = 00;
                    MessageBox.Show("Para sua segurança, esse microondas foi programado para funcionar apenas até 60 minutos!");
                }

                lbTimer.Text = String.Format("{0:00}:{1:00}", min, seg);

            }
        }

        private void btnabfec_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                timer1.Stop();
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                btnabfec.Text = "Fechar";
                btnligar.Text = "Iniciar";
                i = 0;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                btnabfec.Text = "Abrir";
            }
        }
    }
}
