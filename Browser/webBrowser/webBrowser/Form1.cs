using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Form1 : Form
    {
        string home;
        public Form1()
        {
            InitializeComponent();
        }
         private void navegar()
        {
            if(txt_url.Text != "")
            {
              
                webBrowser1.Navigate(txt_url.Text);
            }
            else
            {
                MessageBox.Show("digite uma url! ");
                txt_url.Focus();
            }
            
         }
        private void bttn_ir_Click(object sender, EventArgs e)
        {
            navegar();
        }

        private void txt_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                navegar();
            }
        }

        private void bttn_home_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(txt_url.Text);
            }
           
        }

        private void bttn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void bttn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardchanged(object sender, EventArgs e)
        {
            bttn_proximo.Enabled = webBrowser1.CanGoForward;

        }
        private void webBrowser1_CanGoBackdchanged(object sender, EventArgs e)
        {
            bttn_voltar.Enabled = webBrowser1.CanGoForward;

        }

        private void bttn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void bttn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bttn_pesquisa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void bttn_definir_home_Click(object sender, EventArgs e)
        {
            home = txt_url.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
