namespace Escalonadores
{
    partial class SRT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvTabelaProcessos = new System.Windows.Forms.DataGridView();
            this.clnProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDuracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.txtChegada = new System.Windows.Forms.TextBox();
            this.lblChegada = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.prbProgresso = new System.Windows.Forms.ProgressBar();
            this.tmrExecuta = new System.Windows.Forms.Timer(this.components);
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblProcessoAtual = new System.Windows.Forms.Label();
            this.lblTempoAtual = new System.Windows.Forms.Label();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.cbRelatorio = new System.Windows.Forms.CheckBox();
            this.chGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaProcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelaProcessos
            // 
            this.dgvTabelaProcessos.AllowUserToAddRows = false;
            this.dgvTabelaProcessos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaProcessos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelaProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnProcesso,
            this.clnDuracao,
            this.clnChegada});
            this.dgvTabelaProcessos.Location = new System.Drawing.Point(304, 12);
            this.dgvTabelaProcessos.Name = "dgvTabelaProcessos";
            this.dgvTabelaProcessos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaProcessos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabelaProcessos.Size = new System.Drawing.Size(344, 150);
            this.dgvTabelaProcessos.TabIndex = 0;
            this.dgvTabelaProcessos.TabStop = false;
            // 
            // clnProcesso
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clnProcesso.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnProcesso.HeaderText = "Processo";
            this.clnProcesso.MaxInputLength = 2;
            this.clnProcesso.Name = "clnProcesso";
            this.clnProcesso.ReadOnly = true;
            // 
            // clnDuracao
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clnDuracao.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnDuracao.HeaderText = "Duração";
            this.clnDuracao.MaxInputLength = 3;
            this.clnDuracao.Name = "clnDuracao";
            this.clnDuracao.ReadOnly = true;
            // 
            // clnChegada
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clnChegada.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnChegada.HeaderText = "Chegada";
            this.clnChegada.MaxInputLength = 3;
            this.clnChegada.Name = "clnChegada";
            this.clnChegada.ReadOnly = true;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.Location = new System.Drawing.Point(14, 84);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(86, 33);
            this.btnAddProcess.TabIndex = 0;
            this.btnAddProcess.TabStop = false;
            this.btnAddProcess.Text = "Adicionar";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // txtChegada
            // 
            this.txtChegada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChegada.Location = new System.Drawing.Point(216, 13);
            this.txtChegada.MaxLength = 3;
            this.txtChegada.Name = "txtChegada";
            this.txtChegada.Size = new System.Drawing.Size(77, 20);
            this.txtChegada.TabIndex = 1;
            // 
            // lblChegada
            // 
            this.lblChegada.AutoSize = true;
            this.lblChegada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChegada.Location = new System.Drawing.Point(12, 12);
            this.lblChegada.Name = "lblChegada";
            this.lblChegada.Size = new System.Drawing.Size(198, 18);
            this.lblChegada.TabIndex = 2;
            this.lblChegada.Text = "Digite o tempo de chegada";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(12, 39);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(194, 18);
            this.lblDuracao.TabIndex = 4;
            this.lblDuracao.Text = "Digite o tempo de duração";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(216, 39);
            this.txtDuracao.MaxLength = 3;
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(77, 20);
            this.txtDuracao.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(15, 123);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 33);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(196, 123);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(86, 33);
            this.btnParar.TabIndex = 6;
            this.btnParar.TabStop = false;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(107, 84);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // prbProgresso
            // 
            this.prbProgresso.Location = new System.Drawing.Point(15, 340);
            this.prbProgresso.Name = "prbProgresso";
            this.prbProgresso.Size = new System.Drawing.Size(633, 23);
            this.prbProgresso.TabIndex = 8;
            // 
            // tmrExecuta
            // 
            this.tmrExecuta.Interval = 1000;
            this.tmrExecuta.Tick += new System.EventHandler(this.tmrExecuta_Tick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Enabled = false;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(107, 123);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(86, 33);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.TabStop = false;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblProcessoAtual
            // 
            this.lblProcessoAtual.AutoSize = true;
            this.lblProcessoAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessoAtual.Location = new System.Drawing.Point(12, 209);
            this.lblProcessoAtual.Name = "lblProcessoAtual";
            this.lblProcessoAtual.Size = new System.Drawing.Size(231, 18);
            this.lblProcessoAtual.TabIndex = 10;
            this.lblProcessoAtual.Text = "Processo atual: Não encontrado";
            // 
            // lblTempoAtual
            // 
            this.lblTempoAtual.AutoSize = true;
            this.lblTempoAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoAtual.Location = new System.Drawing.Point(12, 275);
            this.lblTempoAtual.Name = "lblTempoAtual";
            this.lblTempoAtual.Size = new System.Drawing.Size(109, 18);
            this.lblTempoAtual.TabIndex = 11;
            this.lblTempoAtual.Text = "Tempo atual: 0";
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.Location = new System.Drawing.Point(12, 242);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(132, 18);
            this.lblTempoRestante.TabIndex = 12;
            this.lblTempoRestante.Text = "Tempo restante: 0";
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.AutoSize = true;
            this.cbRelatorio.Location = new System.Drawing.Point(214, 92);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(68, 17);
            this.cbRelatorio.TabIndex = 13;
            this.cbRelatorio.Text = "Relatório";
            this.cbRelatorio.UseVisualStyleBackColor = true;
            // 
            // chGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGrafico.Legends.Add(legend1);
            this.chGrafico.Location = new System.Drawing.Point(304, 180);
            this.chGrafico.Name = "chGrafico";
            this.chGrafico.Size = new System.Drawing.Size(344, 151);
            this.chGrafico.TabIndex = 14;
            this.chGrafico.Text = "chart1";
            // 
            // SRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(669, 375);
            this.Controls.Add(this.chGrafico);
            this.Controls.Add(this.cbRelatorio);
            this.Controls.Add(this.lblTempoRestante);
            this.Controls.Add(this.lblTempoAtual);
            this.Controls.Add(this.lblProcessoAtual);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.prbProgresso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.lblChegada);
            this.Controls.Add(this.txtChegada);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.dgvTabelaProcessos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SRT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortest Remaining Time";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaProcessos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabelaProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDuracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnChegada;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.TextBox txtChegada;
        private System.Windows.Forms.Label lblChegada;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ProgressBar prbProgresso;
        private System.Windows.Forms.Timer tmrExecuta;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblProcessoAtual;
        private System.Windows.Forms.Label lblTempoAtual;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.CheckBox cbRelatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafico;
    }
}