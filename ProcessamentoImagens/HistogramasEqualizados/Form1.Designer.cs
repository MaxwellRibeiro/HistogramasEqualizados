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
            this.AbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.pbImagemOriginal = new System.Windows.Forms.PictureBox();
            this.btCarregarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btEqualizarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbImagemEqualizada = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemEqualizada)).BeginInit();
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
            this.pbImagemOriginal.Size = new System.Drawing.Size(186, 131);
            this.pbImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemOriginal.TabIndex = 0;
            this.pbImagemOriginal.TabStop = false;
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Depth = 0;
            this.btCarregarImagem.Location = new System.Drawing.Point(12, 243);
            this.btCarregarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Primary = true;
            this.btCarregarImagem.Size = new System.Drawing.Size(186, 33);
            this.btCarregarImagem.TabIndex = 1;
            this.btCarregarImagem.Text = "Carregar Imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // btEqualizarImagem
            // 
            this.btEqualizarImagem.Depth = 0;
            this.btEqualizarImagem.Location = new System.Drawing.Point(12, 419);
            this.btEqualizarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEqualizarImagem.Name = "btEqualizarImagem";
            this.btEqualizarImagem.Primary = true;
            this.btEqualizarImagem.Size = new System.Drawing.Size(186, 33);
            this.btEqualizarImagem.TabIndex = 3;
            this.btEqualizarImagem.Text = "Equalizar Imagem";
            this.btEqualizarImagem.UseVisualStyleBackColor = true;
            this.btEqualizarImagem.Click += new System.EventHandler(this.btEqualizarImagem_Click);
            // 
            // pbImagemEqualizada
            // 
            this.pbImagemEqualizada.Location = new System.Drawing.Point(12, 282);
            this.pbImagemEqualizada.Name = "pbImagemEqualizada";
            this.pbImagemEqualizada.Size = new System.Drawing.Size(186, 131);
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
            this.btCancelar.Location = new System.Drawing.Point(12, 489);
            this.btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Primary = true;
            this.btCancelar.Size = new System.Drawing.Size(186, 33);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 702);
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
    }
}

