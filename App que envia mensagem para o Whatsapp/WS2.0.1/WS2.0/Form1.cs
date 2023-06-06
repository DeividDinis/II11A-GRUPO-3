using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS2._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void envMW(string numero,string mensagem)
        {
            try
            {
                if (numero == "")
                {
                    MessageBox.Show("Digite o número de destino.");
                    txtdestino.Focus();
                }
              else  if (mensagem == "")
                {
                    MessageBox.Show("Digite a mensagem que deseja enviar.");
                    txtsms.Focus(); 
                }
                if (numero.Length==9)
                {   
                    numero = "+244" + numero;
                    numero = numero.Replace(" ","");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone="+numero+"&text="+mensagem) ;
                }

              

            }
            catch(Exception ex)
            {

            }
        }


        private void btnenviar_Click(object sender, EventArgs e)
        {
            envMW(txtdestino.Text,txtsms.Text);
           
        }
    }
}
