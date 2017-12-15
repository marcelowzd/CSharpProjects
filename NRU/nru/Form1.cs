using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRU
{
    public partial class Form1 : Form
    {
        int[] iPaginas = new int[10]; // Inteiro que guarda número da página (P/ tabela apenas)
        int[] iRef = new int[10];     // Inteiro que guarda a referência (0 ou 1)
        int[] iMod = new int[10];     // Inteiro que guarda a modificação (0 ou 1)

        int[] iClass = new int[10];   // Guarda a classe da página (0 a 3)
        int[] iClassDiv = new int[4]; // Contador de cada classe

        int giCounter = 1; // Inteiro que modifica o número da próxima página;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Quando o form carrega
        {
            Random iRand = new Random();

            for (int i = 0; i < iPaginas.Length; i++) // Faz até 10 páginas aleatoriamente
            {
                iPaginas[i] = i + 1; // Número da página
                iRef[i] = iRand.Next(0, 2); // Número aleatório de 0 a 1
                iMod[i] = iRand.Next(0, 2); // Same

                if (iRef[i] == 0 && iMod[i] == 0) // Cadeia de IFs para qualificar cada página
                {
                    iClass[i] = 0; // Classifica a classe
                    dataGridView2.Rows.Add(iPaginas[i], "Sim", "Não", "Não", "Não"); // Tabela
                    iClassDiv[0]++; // Adiciona um ao contador da classe 0
                }
                else if (iRef[i] == 0 && iMod[i] == 1)
                {
                    iClass[i] = 1; // Classifica a classe
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Sim", "Não", "Não");
                    iClassDiv[1]++; // Adiciona um ao contador da classe 1
                }
                else if (iRef[i] == 1 && iMod[i] == 0)
                {
                    iClass[i] = 2; // Classifica a classe
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Não", "Sim", "Não");
                    iClassDiv[2]++; // Adiciona um ao contador da classe 2
                }
                else if (iRef[i] == 1 && iMod[i] == 1)
                {
                    iClass[i] = 3; // Classifica a classe
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Não", "Não", "Sim");
                    iClassDiv[3]++; // Adiciona um ao contador da classe 3
                }

                dataGridView1.Rows.Add(iPaginas[i], iRef[i], iMod[i]);
            }
        }

        private void RefreshList() // Atualiza a tabela de acordo com as novas informações
        {
            for (int i = 0; i < iClassDiv.Length; i++)
                iClassDiv[i] = 0;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            for (int i = 0; i < iPaginas.Length; i++)
            {
                if (iRef[i] == 0 && iMod[i] == 0)
                {
                    iClass[i] = 0;
                    dataGridView2.Rows.Add(iPaginas[i], "Sim", "Não", "Não", "Não");
                    iClassDiv[0]++;
                }
                else if (iRef[i] == 0 && iMod[i] == 1)
                {
                    iClass[i] = 1;
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Sim", "Não", "Não");
                    iClassDiv[1]++;
                }
                else if (iRef[i] == 1 && iMod[i] == 0)
                {
                    iClass[i] = 2;
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Não", "Sim", "Não");
                    iClassDiv[2]++;
                }
                else if (iRef[i] == 1 && iMod[i] == 1)
                {
                    iClass[i] = 3;
                    dataGridView2.Rows.Add(iPaginas[i], "Não", "Não", "Não", "Sim");
                    iClassDiv[3]++;
                }

                dataGridView1.Rows.Add(iPaginas[i], iRef[i], iMod[i]);
            }
        }

        private void Form1_Click(object sender, EventArgs e) // Clicar no FORM troca página
        {
            if (iClassDiv[0] > 0) // Se existir a classe 0
            {
                int[] IDs = new int[iClassDiv[0]]; int iCounter = 0; // Salva todos os IDs da classe 0

                for (int i = 0; i < iPaginas.Length; i++)
                    if (iClass[i] == 0)
                        IDs[iCounter++] = i; // Adiciona os IDs aqui

                Random iRandom = new Random();

                int iNum = iRandom.Next(0, IDs.Length); // Número aleatório entre os IDs

                MessageBox.Show("Trocando página: " + iPaginas[IDs[iNum]], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                iPaginas[IDs[iNum]] = 10 + giCounter++; // Adiciona uma nova página
                iRef[IDs[iNum]] = 0; // Referência é 0 pois acabou de chegar
                iMod[IDs[iNum]] = 0; // Modificador é 0 pois acabou de chegar

                RefreshList();
            }
            else if (iClassDiv[1] > 0)
            {
                int[] IDs = new int[iClassDiv[1]]; int iCounter = 0;

                for (int i = 0; i < iPaginas.Length; i++)
                    if (iClass[i] == 1)
                        IDs[iCounter++] = i;

                Random iRandom = new Random();

                int iNum = iRandom.Next(0, IDs.Length);

                MessageBox.Show("Trocando página: " + iPaginas[IDs[iNum]], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                iPaginas[IDs[iNum]] = 10 + giCounter++;
                iRef[IDs[iNum]] = 0;
                iMod[IDs[iNum]] = 0;

                RefreshList();
            }
            else if (iClassDiv[2] > 0)
            {
                int[] IDs = new int[iClassDiv[2]]; int iCounter = 0;

                for (int i = 0; i < iPaginas.Length; i++)
                    if (iClass[i] == 2)
                        IDs[iCounter++] = i;

                Random iRandom = new Random();

                int iNum = iRandom.Next(0, IDs.Length);

                MessageBox.Show("Trocando página: " + iPaginas[IDs[iNum]], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                iPaginas[IDs[iNum]] = 10 + giCounter++;
                iRef[IDs[iNum]] = 0;
                iMod[IDs[iNum]] = 0;

                RefreshList();
            }
            else if (iClassDiv[3] > 0)
            {
                int[] IDs = new int[iClassDiv[3]]; int iCounter = 0;

                for (int i = 0; i < iPaginas.Length; i++)
                    if (iClass[i] == 3)
                        IDs[iCounter++] = i;

                Random iRandom = new Random();

                int iNum = iRandom.Next(0, IDs.Length);

                MessageBox.Show("Trocando página: " + iPaginas[IDs[iNum]], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                iPaginas[IDs[iNum]] = 10 + giCounter++;
                iRef[IDs[iNum]] = 0;
                iMod[IDs[iNum]] = 0;

                RefreshList();
            }
        }
    }
}
