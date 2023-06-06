using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarme01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hora, min, seg;
        string alhora, alamin;
        

        private void btnStop_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
          
        }
        private void btn_programar_Click(object sender, EventArgs e)
        {

            timer1.Start();
            alhora = cbHora.Text;
            alamin = cbMinutos.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++)
            {
                cbHora.Items.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                cbMinutos.Items.Add(j);
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            hora = DateTime.Now.Hour;
            lblHora.Text = hora.ToString();
            lblMinuto.Text = min.ToString();
            lblSegundo.Text = seg.ToString();
            Ring_Alarm();
        }

        private void RingAlarm()
        {
            throw new NotImplementedException();
        }

        void Ring_Alarm()
        {
            if (alhora == hora.ToString() && alamin == min.ToString() && seg.ToString() == "0")
            {

                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                    MessageBox.Show("deseja desligar ? (-_-)");
                    Application.Exit();
                }

                catch (Exception ex)
                {


                }

            }
        }
    }
}
