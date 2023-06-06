using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double valor;
        string Separador;
        bool check;


        decimal Valor1 = 0, Valor2 = 0;
        string Resultado = " ";


        private void PNumber(object sender, EventArgs e)

        {
            if ((Separador == "+") || (Separador == "-") || (Separador == "*") || (Separador == "/"))
            {
                if (check)
                {
                    check = false;
                    txt_resultado.Text = "0";
                }
            }

            Button b = sender as Button;
            if (txt_resultado.Text == "0")
                txt_resultado.Text = b.Text;
            else
            {
                txt_resultado.Text += b.Text;
            }

        }

        private void POperacao(object sender, EventArgs e)

        {
            if (txt_resultado.Text != "")
            {


                Button b = sender as Button;
                valor = double.Parse(txt_resultado.Text);
                Separador = b.Text;
                txt_resultado.Text += b.Text;
                check = true;

            }
        }
        private void btn_resultado_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Separador)
                {
                    case "+":
                        txt_resultado.Text = (valor + double.Parse(txt_resultado.Text)).ToString();
                        break;
                    case "-":
                        txt_resultado.Text = (valor - double.Parse(txt_resultado.Text)).ToString();
                        break;
                    case "*":
                        txt_resultado.Text = (valor * double.Parse(txt_resultado.Text)).ToString();
                        break;
                    case "/":
                        txt_resultado.Text = (valor / double.Parse(txt_resultado.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";
            valor = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text.Contains("-"))
            {
                txt_resultado.Text = txt_resultado.Text.Remove(0, 1);
            }
            else
            {
                txt_resultado.Text = "-" + txt_resultado.Text;
            }
        }

    }
}

    

