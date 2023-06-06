using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class JOGO_DA_VELHA : Form
    {
        int empate = 0, rodadas = 0, Xplayer = 0, Oplayer = 0;
        bool turn = true, jogo_final = false;
        string[] texto = new string[9];
        int xv = 0, xp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public JOGO_DA_VELHA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            rodadas = 0;
            jogo_final = false;
            for(int i = 0 ; i < 9 ; i ++)
            {
                texto[i] = "";
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttunIndex = btn.TabIndex;
            
            if (btn.Text == "" && jogo_final == false)
               
            {
                if (turn)
                {
                    btn.Text = "X";
                    texto[buttunIndex] = btn.Text;
                    rodadas++;
                    turn = !turn;
                    C(1);
                    xv++;
                }
                else
                {
                    btn.Text = "O";
                    texto[buttunIndex] = btn.Text;
                    rodadas++;
                    turn = !turn;
                    C(2);
                    xp++;
                }
            }
        }
        void Vencedor(int PlayerQueGanhou)
        {
            jogo_final = true;
            if (xv == 3)
            {
                Xplayer++;
                XPonto.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogado 1 ganhou");
                turn = true;
            }
            else if (xp == 3)
            {
                Oplayer++;
                OPonto.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador 2 ganhou");
                turn = false;
            }
            else if (PlayerQueGanhou == 1)
            {
                Xplayer++;
                XPonto.Text = Convert.ToString (Xplayer);
                MessageBox.Show("Jogado 1 ganhou");
                turn = true;
            }
            else
            {
                Oplayer++;
                OPonto.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador 2 ganhou");
                turn = false;
            }
        }
        void C(int Cplayer)
        {
            string S = "";
            if (Cplayer == 1)
            {
                S = "X";
            }
            else
            {
                S = "O";
            }
            for (int h = 0; h <= 8; h += 3)
            {
                if (S == texto[h])
                {
                    if (texto[h] == texto[h + 1] && texto[h] == texto[h + 2])
                    { 
                        Vencedor(Cplayer);
                        return;
                    }
                }
            }
            for (int v = 0; v < 3; v++)
            {
                if (S == texto[v])
                {
                    if (texto[v] == texto[v + 3] && texto[v] == texto[v + 6])
                    {
                        Vencedor(Cplayer);
                        return;
                    }
                }
            }
            if (texto[0] == S)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(Cplayer);
                    return;
                }
            }
            if(texto[2]==S)
            {
                if(texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(Cplayer);
                    return;
                }
            }
            if(rodadas==9 && jogo_final==false)
            {
                empate++;
                Empat.Text = Convert.ToString(empate);
                MessageBox.Show("empatados");
                MessageBox.Show("desejam repitir (-_-)? ");
                btn.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                rodadas = 0;
                jogo_final = true;
                return;
            }
        }
    }
}
