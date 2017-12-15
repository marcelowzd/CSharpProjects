using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoUpdate
{
    public partial class CadastroDeCliente : Form
    {
        public CadastroDeCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Equals("") ||
                textBox11.Text.Equals("") ||
                textBox12.Text.Equals("") ||
                textBox13.Equals("") ||
                textBox14.Equals("") ||
                textBox15.Equals("") ||
                textBox16.Equals("") ||
                textBox9.Equals(""))
                MessageBox.Show("Preencha todos os campos");
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Equals("") ||
                textBox5.Equals("") ||
                textBox6.Equals("") ||
                textBox7.Equals("") ||
                textBox8.Equals(""))
                MessageBox.Show("Preencha todos os campos");
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
            textBox16.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox17.Text = null;
            textBox18.Text = null;
            textBox19.Text = null;
            textBox20.Text = null;
            textBox21.Text = null;
            textBox22.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com Sucesso");
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
