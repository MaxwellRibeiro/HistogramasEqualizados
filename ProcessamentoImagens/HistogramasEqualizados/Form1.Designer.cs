namespace HistogramasEqualizados
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.pbImagemOriginal = new System.Windows.Forms.PictureBox();
            this.btCarregarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btEqualizarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbImagemEqualizada = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bdGraficoHistogramaRed = new System.Windows.Forms.BindingSource(this.components);
            this.ctHistogramaR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btGraficoHistograma = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemEqualizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdGraficoHistogramaRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctHistogramaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // AbrirImagem
            // 
            this.AbrirImagem.FileName = "openFileDialog1";
            // 
            // pbImagemOriginal
            // 
            this.pbImagemOriginal.Location = new System.Drawing.Point(12, 106);
            this.pbImagemOriginal.Name = "pbImagemOriginal";
            this.pbImagemOriginal.Size = new System.Drawing.Size(255, 255);
            this.pbImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemOriginal.TabIndex = 0;
            this.pbImagemOriginal.TabStop = false;
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Depth = 0;
            this.btCarregarImagem.Location = new System.Drawing.Point(12, 368);
            this.btCarregarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Primary = true;
            this.btCarregarImagem.Size = new System.Drawing.Size(255, 33);
            this.btCarregarImagem.TabIndex = 1;
            this.btCarregarImagem.Text = "Carregar Imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // btEqualizarImagem
            // 
            this.btEqualizarImagem.Depth = 0;
            this.btEqualizarImagem.Location = new System.Drawing.Point(116, 668);
            this.btEqualizarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEqualizarImagem.Name = "btEqualizarImagem";
            this.btEqualizarImagem.Primary = true;
            this.btEqualizarImagem.Size = new System.Drawing.Size(151, 33);
            this.btEqualizarImagem.TabIndex = 3;
            this.btEqualizarImagem.Text = "Equalizar Imagem";
            this.btEqualizarImagem.UseVisualStyleBackColor = true;
            this.btEqualizarImagem.Click += new System.EventHandler(this.btEqualizarImagem_Click);
            // 
            // pbImagemEqualizada
            // 
            this.pbImagemEqualizada.Location = new System.Drawing.Point(12, 407);
            this.pbImagemEqualizada.Name = "pbImagemEqualizada";
            this.pbImagemEqualizada.Size = new System.Drawing.Size(255, 255);
            this.pbImagemEqualizada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemEqualizada.TabIndex = 2;
            this.pbImagemEqualizada.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(0, 64);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1314, 23);
            this.ProgressBar.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btCancelar
            // 
            this.btCancelar.Depth = 0;
            this.btCancelar.Location = new System.Drawing.Point(12, 668);
            this.btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Primary = true;
            this.btCancelar.Size = new System.Drawing.Size(98, 33);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ctHistogramaR
            // 
            chartArea1.Name = "ChartArea1";
            this.ctHistogramaR.ChartAreas.Add(chartArea1);
            this.ctHistogramaR.Location = new System.Drawing.Point(273, 149);
            this.ctHistogramaR.Name = "ctHistogramaR";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.ctHistogramaR.Series.Add(series1);
            this.ctHistogramaR.Size = new System.Drawing.Size(440, 180);
            this.ctHistogramaR.TabIndex = 15;
            this.ctHistogramaR.Text = "chart1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(273, 335);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(440, 180);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Location = new System.Drawing.Point(273, 521);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(440, 180);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // btGraficoHistograma
            // 
            this.btGraficoHistograma.Depth = 0;
            this.btGraficoHistograma.Location = new System.Drawing.Point(273, 106);
            this.btGraficoHistograma.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGraficoHistograma.Name = "btGraficoHistograma";
            this.btGraficoHistograma.Primary = true;
            this.btGraficoHistograma.Size = new System.Drawing.Size(440, 33);
            this.btGraficoHistograma.TabIndex = 18;
            this.btGraficoHistograma.Text = "Gráfico Histograma";
            this.btGraficoHistograma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 708);
            this.Controls.Add(this.btGraficoHistograma);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ctHistogramaR);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btEqualizarImagem);
            this.Controls.Add(this.pbImagemEqualizada);
            this.Controls.Add(this.btCarregarImagem);
            this.Controls.Add(this.pbImagemOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento de Imagens : Histograma e Equalização";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemEqualizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdGraficoHistogramaRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctHistogramaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog AbrirImagem;
        private System.Windows.Forms.PictureBox pbImagemOriginal;
        private MaterialSkin.Controls.MaterialRaisedButton btCarregarImagem;
        private MaterialSkin.Controls.MaterialRaisedButton btEqualizarImagem;
        private System.Windows.Forms.PictureBox pbImagemEqualizada;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialRaisedButton btCancelar;
        private System.Windows.Forms.BindingSource bdGraficoHistogramaRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctHistogramaR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MaterialSkin.Controls.MaterialRaisedButton btGraficoHistograma;
    }
}

