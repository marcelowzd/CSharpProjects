namespace EstatisticaVisual
{
    partial class Resultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell5 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.pnResultados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblDesvioMedio = new System.Windows.Forms.Label();
            this.lblValencia = new System.Windows.Forms.Label();
            this.lblValenciaAmostra = new System.Windows.Forms.Label();
            this.lblDesvioPadrao = new System.Windows.Forms.Label();
            this.lblDesvioPadraoAmostra = new System.Windows.Forms.Label();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblQuartilTwo = new System.Windows.Forms.Label();
            this.lblQuartilOne = new System.Windows.Forms.Label();
            this.lblQuartilTres = new System.Windows.Forms.Label();
            this.chtGraficoPizza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDecilDez = new System.Windows.Forms.Label();
            this.lblDecilVinte = new System.Windows.Forms.Label();
            this.lblDecilTrinta = new System.Windows.Forms.Label();
            this.lblDecilQuarenta = new System.Windows.Forms.Label();
            this.lblDecilCinquenta = new System.Windows.Forms.Label();
            this.lblDecilNoventa = new System.Windows.Forms.Label();
            this.lblDecilOitenta = new System.Windows.Forms.Label();
            this.lblDecilSetenta = new System.Windows.Forms.Label();
            this.lblDecilSessenta = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // pnResultados
            // 
            this.pnResultados.BackColor = System.Drawing.Color.Chartreuse;
            this.pnResultados.Controls.Add(this.label1);
            this.pnResultados.Location = new System.Drawing.Point(0, 0);
            this.pnResultados.Name = "pnResultados";
            this.pnResultados.Size = new System.Drawing.Size(857, 53);
            this.pnResultados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(23, 72);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(65, 23);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Média: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.Location = new System.Drawing.Point(23, 107);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(81, 23);
            this.lblMediana.TabIndex = 3;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(23, 143);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(60, 23);
            this.lblModa.TabIndex = 4;
            this.lblModa.Text = "Moda: ";
            // 
            // lblDesvioMedio
            // 
            this.lblDesvioMedio.AutoSize = true;
            this.lblDesvioMedio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioMedio.Location = new System.Drawing.Point(23, 177);
            this.lblDesvioMedio.Name = "lblDesvioMedio";
            this.lblDesvioMedio.Size = new System.Drawing.Size(118, 23);
            this.lblDesvioMedio.TabIndex = 5;
            this.lblDesvioMedio.Text = "Desvio Médio: ";
            // 
            // lblValencia
            // 
            this.lblValencia.AutoSize = true;
            this.lblValencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValencia.Location = new System.Drawing.Point(23, 211);
            this.lblValencia.Name = "lblValencia";
            this.lblValencia.Size = new System.Drawing.Size(80, 23);
            this.lblValencia.TabIndex = 6;
            this.lblValencia.Text = "Valência: ";
            // 
            // lblValenciaAmostra
            // 
            this.lblValenciaAmostra.AutoSize = true;
            this.lblValenciaAmostra.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValenciaAmostra.Location = new System.Drawing.Point(23, 246);
            this.lblValenciaAmostra.Name = "lblValenciaAmostra";
            this.lblValenciaAmostra.Size = new System.Drawing.Size(158, 23);
            this.lblValenciaAmostra.TabIndex = 7;
            this.lblValenciaAmostra.Text = "Valência (Amostra): ";
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioPadrao.Location = new System.Drawing.Point(23, 284);
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(122, 23);
            this.lblDesvioPadrao.TabIndex = 8;
            this.lblDesvioPadrao.Text = "Desvio Padrão: ";
            // 
            // lblDesvioPadraoAmostra
            // 
            this.lblDesvioPadraoAmostra.AutoSize = true;
            this.lblDesvioPadraoAmostra.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioPadraoAmostra.Location = new System.Drawing.Point(23, 320);
            this.lblDesvioPadraoAmostra.Name = "lblDesvioPadraoAmostra";
            this.lblDesvioPadraoAmostra.Size = new System.Drawing.Size(200, 23);
            this.lblDesvioPadraoAmostra.TabIndex = 9;
            this.lblDesvioPadraoAmostra.Text = "Desvio Padrão (Amostra): ";
            // 
            // chtGrafico
            // 
            chartArea9.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend9);
            this.chtGrafico.Location = new System.Drawing.Point(475, 84);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Size = new System.Drawing.Size(358, 300);
            this.chtGrafico.TabIndex = 10;
            this.chtGrafico.Text = "chart1";
            title9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "Title1";
            title9.Text = "Histograma";
            this.chtGrafico.Titles.Add(title9);
            // 
            // lblQuartilTwo
            // 
            this.lblQuartilTwo.AutoSize = true;
            this.lblQuartilTwo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartilTwo.Location = new System.Drawing.Point(23, 388);
            this.lblQuartilTwo.Name = "lblQuartilTwo";
            this.lblQuartilTwo.Size = new System.Drawing.Size(120, 23);
            this.lblQuartilTwo.TabIndex = 12;
            this.lblQuartilTwo.Text = "Quartil(50%): ";
            // 
            // lblQuartilOne
            // 
            this.lblQuartilOne.AutoSize = true;
            this.lblQuartilOne.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartilOne.Location = new System.Drawing.Point(23, 352);
            this.lblQuartilOne.Name = "lblQuartilOne";
            this.lblQuartilOne.Size = new System.Drawing.Size(120, 23);
            this.lblQuartilOne.TabIndex = 0;
            this.lblQuartilOne.Text = "Quartil(25%): ";
            // 
            // lblQuartilTres
            // 
            this.lblQuartilTres.AutoSize = true;
            this.lblQuartilTres.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartilTres.Location = new System.Drawing.Point(300, 388);
            this.lblQuartilTres.Name = "lblQuartilTres";
            this.lblQuartilTres.Size = new System.Drawing.Size(120, 23);
            this.lblQuartilTres.TabIndex = 13;
            this.lblQuartilTres.Text = "Quartil(75%): ";
            // 
            // chtGraficoPizza
            // 
            chartArea10.Name = "ChartArea1";
            this.chtGraficoPizza.ChartAreas.Add(chartArea10);
            legendCell5.Name = "Teste cell 1";
            legendItem5.Cells.Add(legendCell5);
            legendItem5.Name = "teste";
            legend10.CustomItems.Add(legendItem5);
            legend10.Name = "Legend1";
            this.chtGraficoPizza.Legends.Add(legend10);
            this.chtGraficoPizza.Location = new System.Drawing.Point(475, 409);
            this.chtGraficoPizza.Name = "chtGraficoPizza";
            this.chtGraficoPizza.Size = new System.Drawing.Size(358, 300);
            this.chtGraficoPizza.TabIndex = 14;
            this.chtGraficoPizza.Text = "chart1";
            title10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "Title1";
            title10.Text = "Gráfico de setores";
            this.chtGraficoPizza.Titles.Add(title10);
            // 
            // lblDecilDez
            // 
            this.lblDecilDez.AutoSize = true;
            this.lblDecilDez.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilDez.Location = new System.Drawing.Point(300, 72);
            this.lblDecilDez.Name = "lblDecilDez";
            this.lblDecilDez.Size = new System.Drawing.Size(95, 23);
            this.lblDecilDez.TabIndex = 15;
            this.lblDecilDez.Text = "Decil(10%):";
            // 
            // lblDecilVinte
            // 
            this.lblDecilVinte.AutoSize = true;
            this.lblDecilVinte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilVinte.Location = new System.Drawing.Point(300, 107);
            this.lblDecilVinte.Name = "lblDecilVinte";
            this.lblDecilVinte.Size = new System.Drawing.Size(103, 23);
            this.lblDecilVinte.TabIndex = 16;
            this.lblDecilVinte.Text = "Decil(20%): ";
            // 
            // lblDecilTrinta
            // 
            this.lblDecilTrinta.AutoSize = true;
            this.lblDecilTrinta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilTrinta.Location = new System.Drawing.Point(300, 143);
            this.lblDecilTrinta.Name = "lblDecilTrinta";
            this.lblDecilTrinta.Size = new System.Drawing.Size(103, 23);
            this.lblDecilTrinta.TabIndex = 17;
            this.lblDecilTrinta.Text = "Decil(30%): ";
            // 
            // lblDecilQuarenta
            // 
            this.lblDecilQuarenta.AutoSize = true;
            this.lblDecilQuarenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilQuarenta.Location = new System.Drawing.Point(300, 177);
            this.lblDecilQuarenta.Name = "lblDecilQuarenta";
            this.lblDecilQuarenta.Size = new System.Drawing.Size(98, 23);
            this.lblDecilQuarenta.TabIndex = 18;
            this.lblDecilQuarenta.Text = "Decil(40%):";
            // 
            // lblDecilCinquenta
            // 
            this.lblDecilCinquenta.AutoSize = true;
            this.lblDecilCinquenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilCinquenta.Location = new System.Drawing.Point(300, 211);
            this.lblDecilCinquenta.Name = "lblDecilCinquenta";
            this.lblDecilCinquenta.Size = new System.Drawing.Size(98, 23);
            this.lblDecilCinquenta.TabIndex = 19;
            this.lblDecilCinquenta.Text = "Decil(50%):";
            // 
            // lblDecilNoventa
            // 
            this.lblDecilNoventa.AutoSize = true;
            this.lblDecilNoventa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilNoventa.Location = new System.Drawing.Point(300, 352);
            this.lblDecilNoventa.Name = "lblDecilNoventa";
            this.lblDecilNoventa.Size = new System.Drawing.Size(98, 23);
            this.lblDecilNoventa.TabIndex = 23;
            this.lblDecilNoventa.Text = "Decil(90%):";
            // 
            // lblDecilOitenta
            // 
            this.lblDecilOitenta.AutoSize = true;
            this.lblDecilOitenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilOitenta.Location = new System.Drawing.Point(300, 320);
            this.lblDecilOitenta.Name = "lblDecilOitenta";
            this.lblDecilOitenta.Size = new System.Drawing.Size(103, 23);
            this.lblDecilOitenta.TabIndex = 22;
            this.lblDecilOitenta.Text = "Decil(80%): ";
            // 
            // lblDecilSetenta
            // 
            this.lblDecilSetenta.AutoSize = true;
            this.lblDecilSetenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilSetenta.Location = new System.Drawing.Point(300, 284);
            this.lblDecilSetenta.Name = "lblDecilSetenta";
            this.lblDecilSetenta.Size = new System.Drawing.Size(103, 23);
            this.lblDecilSetenta.TabIndex = 21;
            this.lblDecilSetenta.Text = "Decil(70%): ";
            // 
            // lblDecilSessenta
            // 
            this.lblDecilSessenta.AutoSize = true;
            this.lblDecilSessenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecilSessenta.Location = new System.Drawing.Point(300, 246);
            this.lblDecilSessenta.Name = "lblDecilSessenta";
            this.lblDecilSessenta.Size = new System.Drawing.Size(98, 23);
            this.lblDecilSessenta.TabIndex = 20;
            this.lblDecilSessenta.Text = "Decil(60%):";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(27, 599);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 138);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(253, 599);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 138);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 25;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.Frequencia});
            this.dgvTabela.Location = new System.Drawing.Point(60, 427);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.Size = new System.Drawing.Size(243, 153);
            this.dgvTabela.TabIndex = 26;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.MaxInputLength = 15;
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            this.Intervalo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Frequencia
            // 
            this.Frequencia.HeaderText = "Frequência";
            this.Frequencia.MaxInputLength = 3;
            this.Frequencia.Name = "Frequencia";
            this.Frequencia.ReadOnly = true;
            this.Frequencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(857, 749);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDecilNoventa);
            this.Controls.Add(this.lblDecilOitenta);
            this.Controls.Add(this.lblDecilSetenta);
            this.Controls.Add(this.lblDecilSessenta);
            this.Controls.Add(this.lblDecilCinquenta);
            this.Controls.Add(this.lblDecilQuarenta);
            this.Controls.Add(this.lblDecilTrinta);
            this.Controls.Add(this.lblDecilVinte);
            this.Controls.Add(this.lblDecilDez);
            this.Controls.Add(this.chtGraficoPizza);
            this.Controls.Add(this.lblQuartilTres);
            this.Controls.Add(this.lblQuartilTwo);
            this.Controls.Add(this.lblQuartilOne);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.lblDesvioPadraoAmostra);
            this.Controls.Add(this.lblDesvioPadrao);
            this.Controls.Add(this.lblValenciaAmostra);
            this.Controls.Add(this.lblValencia);
            this.Controls.Add(this.lblDesvioMedio);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.pnResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatística - Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.pnResultados.ResumeLayout(false);
            this.pnResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblDesvioMedio;
        private System.Windows.Forms.Label lblValencia;
        private System.Windows.Forms.Label lblValenciaAmostra;
        private System.Windows.Forms.Label lblDesvioPadrao;
        private System.Windows.Forms.Label lblDesvioPadraoAmostra;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Label lblQuartilTwo;
        private System.Windows.Forms.Label lblQuartilOne;
        private System.Windows.Forms.Label lblQuartilTres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficoPizza;
        private System.Windows.Forms.Label lblDecilDez;
        private System.Windows.Forms.Label lblDecilVinte;
        private System.Windows.Forms.Label lblDecilTrinta;
        private System.Windows.Forms.Label lblDecilQuarenta;
        private System.Windows.Forms.Label lblDecilCinquenta;
        private System.Windows.Forms.Label lblDecilNoventa;
        private System.Windows.Forms.Label lblDecilOitenta;
        private System.Windows.Forms.Label lblDecilSetenta;
        private System.Windows.Forms.Label lblDecilSessenta;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequencia;
    }
}