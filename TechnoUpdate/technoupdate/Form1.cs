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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Relatorio x = new Relatorio();
            x.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastroDeCliente x = new CadastroDeCliente();
            x.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeCliente x = new CadastroDeCliente();
            x.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Produtos x = new Produtos();
            x.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio x = new Relatorio();
            x.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos x = new Produtos();
            x.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores x = new Fornecedores();
            x.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fornecedores x = new Fornecedores();
            x.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Caixa x = new Caixa();
            x.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            x.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            x.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            x.Show();
        }
    }
}
