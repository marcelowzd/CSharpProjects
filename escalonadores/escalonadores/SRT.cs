using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Escalonadores
{
    public partial class SRT : Form
    {
        ArrayList iChegada = new ArrayList();
        ArrayList iDuracao = new ArrayList();

        Int32 iProcessos = 0;
        Int32 iTempoTotal = 0;
        Int32 iTempoAtual = 0;

        Boolean bRodando = false;
        Boolean bRelatorio = false;

        //String sPath = @"C:\Users\Marcelo\Desktop\SRT_Relatorio.txt";
        String sPath;

        public SRT()
        {
            InitializeComponent();
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            String sChegada = txtChegada.Text;
            String sDuracao = txtDuracao.Text;

            if (String.IsNullOrEmpty(sChegada) || String.IsNullOrEmpty(sDuracao))
                MessageBox.Show("Digite algo nos campos", "Falta de informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int iChegada = int.Parse(sChegada);
                    int iDuracao = int.Parse(sDuracao);

                    if (iChegada < 0 || iDuracao <= 0)
                        MessageBox.Show("Digite apenas valores válidos", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        iProcessos++;

                        dgvTabelaProcessos.Rows.Add(iProcessos, iDuracao, iChegada);

                        if (!bRodando)
                        {
                            btnIniciar.Enabled = true;
                            btnLimpar.Enabled = true;
                        }
                        else
                        {
                            this.iDuracao.Add(iDuracao);
                            this.iChegada.Add(iChegada);

                            chGrafico.Series.Add("P" + iProcessos.ToString());
                            chGrafico.Series["P" + iProcessos.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                            chGrafico.Series["P" + iProcessos.ToString()].Points.AddY(iDuracao);

                            iTempoTotal += iDuracao;
                        }
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Digite apenas números", "Caractere identificado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            iProcessos = 0;
            iTempoTotal = 0;
            iTempoAtual = 0;

            iDuracao.Clear();
            iChegada.Clear();

            btnIniciar.Enabled = false;
            btnLimpar.Enabled = false;
            btnParar.Enabled = false;

            cbRelatorio.Enabled = true;

            if(bRodando)
            {
                btnAddProcess.Enabled = true;

                bRodando = false;
            }

            bRelatorio = false;

            dgvTabelaProcessos.Rows.Clear();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int iTempDuracao; String sProcesso;

            if (cbRelatorio.Checked)
            {
                try
                {
                    SaveFileDialog svfFile = new SaveFileDialog();

                    svfFile.Filter = "Arquivos de texto (*.txt)|*.txt|Todos arquivos (*.*)|*.*";
                    svfFile.Title = "Salvar relatório";
                    svfFile.DefaultExt = "txt";

                    DateTime now = DateTime.Now;
                    DateTime dt = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);

                    if (svfFile.ShowDialog() == DialogResult.OK)
                    {
                        sPath = @svfFile.FileName;

                        if (File.Exists(sPath))
                            using (StreamWriter swFile = new StreamWriter(sPath, true))
                                swFile.WriteLine("// Horário: " + dt.Hour + "h" + dt.Minute + " Data: " + dt.Day + "/" + dt.Month + "/" + dt.Year);
                        else
                            using (StreamWriter swFile = new StreamWriter(sPath))
                            {
                                swFile.WriteLine("// Criado pelo eslonador SRT");
                                swFile.WriteLine("// Horário: " + dt.Hour + "h" + dt.Minute + " Data: " + dt.Day + "/" + dt.Month + "/" + dt.Year);
                            }

                        bRelatorio = true;
                    }

                }
                catch(UnauthorizedAccessException)
                {
                    MessageBox.Show("Não foi possível criar o arquivo de relatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            foreach (DataGridViewRow row in dgvTabelaProcessos.Rows)
            {
                sProcesso = "P" + row.Cells["clnProcesso"].Value.ToString();
                iTempDuracao = int.Parse(row.Cells["clnDuracao"].Value.ToString());

                iDuracao.Add(iTempDuracao);
                iChegada.Add(int.Parse(row.Cells["clnChegada"].Value.ToString()));

                chGrafico.Series.Add(sProcesso);
                chGrafico.Series[sProcesso].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chGrafico.Series[sProcesso].Points.AddY(iTempDuracao);

                iTempoTotal += iTempDuracao;
            }

            bRodando = true;

            btnAddProcess.Enabled = false;
            btnLimpar.Enabled = false;
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;

            txtChegada.Enabled = false;
            cbRelatorio.Enabled = false;

            tmrExecuta.Start();
        }

        private void tmrExecuta_Tick(object sender, EventArgs e)
        {
            if (iTempoAtual < iTempoTotal)
            {
                int iIndex = -1;

                for (int i = 0; i < iDuracao.Count; i++ )
                {
                    if(int.Parse(iDuracao[i].ToString()) > 0 && iTempoAtual >= int.Parse(iChegada[i].ToString()))
                    {
                        if (iIndex >= 0)
                        {
                            if (int.Parse(iDuracao[iIndex].ToString()) > int.Parse(iDuracao[i].ToString()))
                                iIndex = i;
                            else if (int.Parse(iDuracao[iIndex].ToString()) == int.Parse(iDuracao[i].ToString()))
                                if (iIndex > i)
                                    iIndex = i;
                        }
                        else
                            iIndex = i;
                    }
                }

                if(iIndex >= 0)
                {
                    iDuracao[iIndex] = int.Parse(iDuracao[iIndex].ToString()) - 1;

                    lblTempoRestante.Text = "Tempo restante: " + iDuracao[iIndex].ToString();
                    lblProcessoAtual.Text = "Processo atual: " + (iIndex + 1).ToString();

                    if(bRelatorio)
                        using (System.IO.StreamWriter swFile = new System.IO.StreamWriter(sPath, true))
                            swFile.WriteLine("Executando processo: " + (iIndex + 1) + " - Tempo restante: " + iDuracao[iIndex].ToString());
                }
                else
                {
                    iTempoTotal += 1;

                    lblTempoRestante.Text = "Tempo restante: Indisponível";
                    lblProcessoAtual.Text = "Processo atual: CPU livre";

                    if(bRelatorio)
                        using (System.IO.StreamWriter swFile = new System.IO.StreamWriter(sPath, true))
                            swFile.WriteLine("Executando processo: Indisponível - Tempo restante: CPU Livre");
                }

                iTempoAtual++;

                lblTempoAtual.Text = "Tempo atual: " + iTempoAtual;

                prbProgresso.Value = Convert.ToInt32((Convert.ToDouble(iTempoAtual) / Convert.ToDouble(iTempoTotal)) * 100);

                txtChegada.Text = iTempoAtual.ToString();
            }
            else
            {
                tmrExecuta.Stop();

                MessageBox.Show("O escalonamento terminou", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                for (int i = 9; i >= 0; i--)
                {
                    prbProgresso.Value = i * 10;
                    System.Threading.Thread.Sleep(75);
                }

                btnParar.Enabled = false;
                btnIniciar.Enabled = false;
                btnAddProcess.Enabled = true;
                btnContinuar.Enabled = false;
                btnLimpar.Enabled = false;
                txtChegada.Text = null;
                txtDuracao.Text = null;
                txtChegada.Enabled = true;
                lblTempoAtual.Text = "Tempo atual: 0";
                lblTempoRestante.Text = "Tempo restante: 0";
                lblProcessoAtual.Text = "Processo atual: Não encontrado";
                cbRelatorio.Enabled = true;

                iProcessos = 0;
                iTempoTotal = 0;
                iTempoAtual = 0;

                iDuracao.Clear();
                iChegada.Clear();

                chGrafico.Series.Clear();

                bRodando = false;
                bRelatorio = false;

                dgvTabelaProcessos.Rows.Clear();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmrExecuta.Stop();

            btnAddProcess.Enabled = true;
            btnParar.Enabled = false;
            btnContinuar.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            tmrExecuta.Start();

            btnParar.Enabled = true;
            btnContinuar.Enabled = false;
            btnAddProcess.Enabled = false;
        }
    }
}
