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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.pbImagemOriginal = new System.Windows.Forms.PictureBox();
            this.btCarregarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btEqualizarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbImagemEqualizada = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.graficoHistogramaR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoHistogramaG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoHistogramaB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btGraficoHistograma = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGraficoEqualizado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.graficoEqualizadoR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoEqualizadoG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoEqualizadoB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemEqualizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoB)).BeginInit();
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
            this.btCarregarImagem.Location = new System.Drawing.Point(12, 362);
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
            this.btEqualizarImagem.Location = new System.Drawing.Point(12, 663);
            this.btEqualizarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEqualizarImagem.Name = "btEqualizarImagem";
            this.btEqualizarImagem.Primary = true;
            this.btEqualizarImagem.Size = new System.Drawing.Size(255, 33);
            this.btEqualizarImagem.TabIndex = 3;
            this.btEqualizarImagem.Text = "Imagem Equalizada";
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
            this.ProgressBar.Size = new System.Drawing.Size(1095, 23);
            this.ProgressBar.TabIndex = 4;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btCancelar
            // 
            this.btCancelar.Depth = 0;
            this.btCancelar.Location = new System.Drawing.Point(1092, 64);
            this.btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Primary = true;
            this.btCancelar.Size = new System.Drawing.Size(77, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // graficoHistogramaR
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistogramaR.ChartAreas.Add(chartArea1);
            this.graficoHistogramaR.Location = new System.Drawing.Point(273, 149);
            this.graficoHistogramaR.Name = "graficoHistogramaR";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.graficoHistogramaR.Series.Add(series1);
            this.graficoHistogramaR.Size = new System.Drawing.Size(440, 180);
            this.graficoHistogramaR.TabIndex = 15;
            this.graficoHistogramaR.Text = "chart1";
            // 
            // graficoHistogramaG
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoHistogramaG.ChartAreas.Add(chartArea2);
            this.graficoHistogramaG.Location = new System.Drawing.Point(273, 335);
            this.graficoHistogramaG.Name = "graficoHistogramaG";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.graficoHistogramaG.Series.Add(series2);
            this.graficoHistogramaG.Size = new System.Drawing.Size(440, 180);
            this.graficoHistogramaG.TabIndex = 16;
            this.graficoHistogramaG.Text = "chart1";
            // 
            // graficoHistogramaB
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoHistogramaB.ChartAreas.Add(chartArea3);
            this.graficoHistogramaB.Location = new System.Drawing.Point(273, 521);
            this.graficoHistogramaB.Name = "graficoHistogramaB";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.graficoHistogramaB.Series.Add(series3);
            this.graficoHistogramaB.Size = new System.Drawing.Size(440, 180);
            this.graficoHistogramaB.TabIndex = 17;
            this.graficoHistogramaB.Text = "chart2";
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
            this.btGraficoHistograma.Click += new System.EventHandler(this.btGraficoHistograma_Click);
            // 
            // btGraficoEqualizado
            // 
            this.btGraficoEqualizado.Depth = 0;
            this.btGraficoEqualizado.Location = new System.Drawing.Point(719, 106);
            this.btGraficoEqualizado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGraficoEqualizado.Name = "btGraficoEqualizado";
            this.btGraficoEqualizado.Primary = true;
            this.btGraficoEqualizado.Size = new System.Drawing.Size(440, 33);
            this.btGraficoEqualizado.TabIndex = 19;
            this.btGraficoEqualizado.Text = "Gráfico Equalizado";
            this.btGraficoEqualizado.UseVisualStyleBackColor = true;
            // 
            // graficoEqualizadoR
            // 
            chartArea4.Name = "ChartArea1";
            this.graficoEqualizadoR.ChartAreas.Add(chartArea4);
            this.graficoEqualizadoR.Location = new System.Drawing.Point(719, 149);
            this.graficoEqualizadoR.Name = "graficoEqualizadoR";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.graficoEqualizadoR.Series.Add(series4);
            this.graficoEqualizadoR.Size = new System.Drawing.Size(440, 180);
            this.graficoEqualizadoR.TabIndex = 20;
            this.graficoEqualizadoR.Text = "chart1";
            // 
            // graficoEqualizadoG
            // 
            chartArea5.Name = "ChartArea1";
            this.graficoEqualizadoG.ChartAreas.Add(chartArea5);
            this.graficoEqualizadoG.Location = new System.Drawing.Point(719, 335);
            this.graficoEqualizadoG.Name = "graficoEqualizadoG";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.graficoEqualizadoG.Series.Add(series5);
            this.graficoEqualizadoG.Size = new System.Drawing.Size(440, 180);
            this.graficoEqualizadoG.TabIndex = 21;
            this.graficoEqualizadoG.Text = "chart1";
            // 
            // graficoEqualizadoB
            // 
            chartArea6.Name = "ChartArea1";
            this.graficoEqualizadoB.ChartAreas.Add(chartArea6);
            this.graficoEqualizadoB.Location = new System.Drawing.Point(719, 521);
            this.graficoEqualizadoB.Name = "graficoEqualizadoB";
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.graficoEqualizadoB.Series.Add(series6);
            this.graficoEqualizadoB.Size = new System.Drawing.Size(440, 180);
            this.graficoEqualizadoB.TabIndex = 22;
            this.graficoEqualizadoB.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 708);
            this.Controls.Add(this.graficoEqualizadoB);
            this.Controls.Add(this.graficoEqualizadoG);
            this.Controls.Add(this.graficoEqualizadoR);
            this.Controls.Add(this.btGraficoEqualizado);
            this.Controls.Add(this.btGraficoHistograma);
            this.Controls.Add(this.graficoHistogramaB);
            this.Controls.Add(this.graficoHistogramaG);
            this.Controls.Add(this.graficoHistogramaR);
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
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistogramaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEqualizadoB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog AbrirImagem;
        private System.Windows.Forms.PictureBox pbImagemOriginal;
        private MaterialSkin.Controls.MaterialRaisedButton btCarregarImagem;
        private MaterialSkin.Controls.MaterialRaisedButton btEqualizarImagem;
        private System.Windows.Forms.PictureBox pbImagemEqualizada;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MaterialSkin.Controls.MaterialRaisedButton btCancelar;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistogramaR;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistogramaG;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistogramaB;
        private MaterialSkin.Controls.MaterialRaisedButton btGraficoHistograma;
        private MaterialSkin.Controls.MaterialRaisedButton btGraficoEqualizado;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEqualizadoR;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEqualizadoG;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEqualizadoB;
    }
}

