using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstatisticaVisual
{
    public partial class Resultados : Form
    {
        string[] sIntervalo;
        int[] iFrequencia;
        int[,] iIntervalo;
        int iTam;

        public Resultados()
        {
            InitializeComponent();
        }

        public Resultados( string[] sIntervalo, int[] iFrequencia, int[,] iIntervalo )
        {
            InitializeComponent();

            this.sIntervalo = sIntervalo;
            this.iFrequencia = iFrequencia;
            this.iIntervalo = iIntervalo;
            this.iTam = iFrequencia.Length;

            foreach (var series in chtGrafico.Series)
                series.Points.Clear();

            foreach (var series in chtGraficoPizza.Series)
                series.Points.Clear();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            int iFrequenciaTotal = 0;

            chtGraficoPizza.Series.Add("Pizza");
            chtGraficoPizza.Series["Pizza"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            for (int i = 0; i < iTam; i++)
            {
                chtGrafico.Series.Add(sIntervalo[i]);
                chtGrafico.Series[sIntervalo[i]].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chtGrafico.Series[sIntervalo[i]].Points.AddY(iFrequencia[i]);

                chtGraficoPizza.Series["Pizza"].Points.AddXY(sIntervalo[i], iFrequencia[i]);

                dgvTabela.Rows.Add("[" + sIntervalo[i] + "[", iFrequencia[i]);

                iFrequenciaTotal += iFrequencia[i];
            }

            /*chtGrafico.Series.Add("Teste");
            chtGrafico.Series["Teste"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int i = 0; i < iTam; i++)
            {
                chtGrafico.Series["Teste"].Points.AddY(iFrequencia[i]);
                chtGrafico.Series["Teste"].Points[i].AxisLabel = sIntervalo[i];
                chtGrafico.Legends.Add(sIntervalo[i]);
             
             //   iFrequenciaTotal += iFrequencia[i];
            }*/

            double[] dMultiQuartil = new Double[3] { 0.25, 0.50, 0.75 };
            double[] dMultiDecil = new Double[9] { 0.10, 0.20, 0.30, 0.40, 0.50, 0.60, 0.70, 0.80, 0.90 };

            int iModaPos = 0, iMedianaPos = 0, iMaior = 0;
            int[] iQuartilPos = new int[3];
            int[] iDecilPos = new int[9];
            int[] iFrequenciaAcumulada = new int[iTam];

            for (int i = 0; i < iTam; i++ )
            {
                if (iFrequencia[i] > iMaior)
                {
                    iMaior = iFrequencia[i];

                    iModaPos = i;
                }

                if (i == 0)
                    iFrequenciaAcumulada[i] = iFrequencia[i];
                else
                    iFrequenciaAcumulada[i] = iFrequenciaAcumulada[i - 1] + iFrequencia[i];

                if (iFrequenciaAcumulada[i] >= (iFrequenciaTotal / 2) && iMedianaPos == 0)
                {
                    iMedianaPos = i;

                    iQuartilPos[1] = i;
                }

                if (iFrequenciaAcumulada[i] >= (iFrequenciaTotal * 0.25) && iQuartilPos[0] == 0)
                    iQuartilPos[0] = i;

                if (iFrequenciaAcumulada[i] >= (iFrequenciaTotal * 0.75) && iQuartilPos[2] == 0)
                    iQuartilPos[2] = i;

                for (int j = 0; j < 9; j++)
                    if (iFrequenciaAcumulada[i] >= (iFrequenciaTotal * dMultiDecil[j]) && iDecilPos[j] == 0)
                        iDecilPos[j] = i;
            }

            double iMedia = 0.0, iModa = 0.0, iAmplitude = 0.0, iMediana = 0.0,
                   iDesvioMedio = 0.0, iValenciaAmostra = 0.0, iValencia = 0.0, 
                   iDesvioPadrao = 0.0, iDesvioPadraoAmostra = 0.0;
            double[] dQuartil = new Double[3];
            double[] dDecil = new Double[9];

            iAmplitude = iIntervalo[0, 1] - iIntervalo[0, 0];

            for (int i = 0; i < iTam; i++)
                iMedia = iMedia + ((iIntervalo[0, i] + iIntervalo[1, i]) / 2) * iFrequencia[i];

            iModa = iIntervalo[0, iModaPos] + (((iFrequencia[iModaPos] - iFrequencia[iModaPos - 1]) * iAmplitude) / ((iFrequencia[iModaPos] - iFrequencia[iModaPos - 1]) + (iFrequencia[iModaPos] - iFrequencia[iModaPos + 1])));
            iMediana = iIntervalo[0, iMedianaPos] + ((((iFrequenciaTotal / 2) - iFrequenciaAcumulada[iMedianaPos - 1]) * iAmplitude) / iFrequencia[iMedianaPos]);
            iMedia = iMedia / iFrequenciaTotal;

            double iRes = 0.0;

            for (int i = 0; i < iTam; i++)
            {
                iRes = ((iIntervalo[0, i] + iIntervalo[1, i]) / 2);

                if (iRes > iMedia)
                    iDesvioMedio += (iRes - iMedia) * iFrequencia[i];
                else
                    iDesvioMedio += (iMedia - iRes) * iFrequencia[i];

                iValencia = Math.Pow(iRes - iMedia, 2) * iFrequencia[i];
            }

            iDesvioMedio = iDesvioMedio / iFrequenciaTotal;
            iValenciaAmostra = iValencia / (iFrequenciaTotal - 1);
            iValencia = iValencia / iFrequenciaTotal;
            iDesvioPadrao = Math.Sqrt(iValencia);
            iDesvioPadraoAmostra = Math.Sqrt(iValenciaAmostra);

            for (int i = 0; i < 3; i++)
                dQuartil[i] = iIntervalo[0, iQuartilPos[i]] + ((((iFrequenciaTotal * dMultiQuartil[i]) - iFrequenciaAcumulada[iQuartilPos[i] - 1]) * iAmplitude) / iFrequencia[iQuartilPos[i]]);

            for (int i = 0; i < 9; i++)
                dDecil[i] = iIntervalo[0, iDecilPos[i]] + ((((iFrequenciaTotal * dMultiDecil[i]) - iFrequenciaAcumulada[iDecilPos[i] - 1]) * iAmplitude) / iFrequencia[iDecilPos[i]]);

            lblMedia.Text = "Média: " + String.Format("{0:0.00}", iMedia);
            lblMediana.Text = "Mediana: " + String.Format("{0:0.00}", iMediana);
            lblModa.Text = "Moda: " + String.Format("{0:0.00}", iModa);
            lblDesvioMedio.Text = "Desvio Médio: " + String.Format("{0:0.00}", iDesvioMedio);
            lblValencia.Text = "Valência: " + String.Format("{0:0.00}", iValencia);
            lblValenciaAmostra.Text = "Valência (Amostra): " + String.Format("{0:0.00}", iValenciaAmostra);
            lblDesvioPadrao.Text = "Desvio Padrão: " + String.Format("{0:0.00}", iDesvioPadrao);
            lblDesvioPadraoAmostra.Text = "Desvio Padrâo (Amostra): " + String.Format("{0:0.00}", iDesvioPadraoAmostra);
            lblQuartilOne.Text = "Quartil(25%): " + String.Format("{0:0.00}", dQuartil[0]);
            lblQuartilTwo.Text = "Quartil(50%): " + String.Format("{0:0.00}", dQuartil[1]);
            lblQuartilTres.Text = "Quartil(75%): " + String.Format("{0:0.00}", dQuartil[2]);
            lblDecilDez.Text = "Decil(10%): " + String.Format("{0:0.00}", dDecil[0]);
            lblDecilVinte.Text = "Decil(20%): " + String.Format("{0:0.00}", dDecil[1]);
            lblDecilTrinta.Text = "Decil(30%): " + String.Format("{0:0.00}", dDecil[2]);
            lblDecilQuarenta.Text = "Decil(40%): " + String.Format("{0:0.00}", dDecil[3]);
            lblDecilCinquenta.Text = "Decil(50%): " + String.Format("{0:0.00}", dDecil[4]);
            lblDecilSessenta.Text = "Decil(60%): " + String.Format("{0:0.00}", dDecil[5]);
            lblDecilSetenta.Text = "Decil(70%): " + String.Format("{0:0.00}", dDecil[6]);
            lblDecilOitenta.Text = "Decil(80%): " + String.Format("{0:0.00}", dDecil[7]);
            lblDecilNoventa.Text = "Decil(90%): " + String.Format("{0:0.00}", dDecil[8]);

            chtGrafico.Update();
            chtGraficoPizza.Update();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
