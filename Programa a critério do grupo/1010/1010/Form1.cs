using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = conversorBP(textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        public string conversorPB(string dados)
        {
            StringBuilder pl = new StringBuilder();
            foreach (char c in dados.ToCharArray())
                pl.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return pl.ToString();
        }
        public  string conversorBP(string dado)
        {
            List<byte> bin = new List<byte>();
            for(int i=0; i<dado.Length;i+=8)
                bin.Add(Convert.ToByte(dado.Substring(i, 8), 2));
                return Encoding.ASCII.GetString(bin.ToArray());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
       // textBox2.Text = conversorPB(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = conversorPB(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = conversorBP(textBox2.Text);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = false;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = true;
            label3.Visible = false;
        }
    }
}
