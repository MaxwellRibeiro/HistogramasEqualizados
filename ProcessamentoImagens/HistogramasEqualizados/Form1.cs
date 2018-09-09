using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HistogramasEqualizados
{
    public partial class Form1 : MaterialForm
    {
        private Bitmap _imagem;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCarregarImagem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog File1 = new OpenFileDialog();
            File1.Filter = "JPEG files (*.jpg)|*.jpg";
            if (File1.ShowDialog() == DialogResult.OK)
            {
                if (_imagem != null)
                {
                    _imagem.Dispose();
                }
                _imagem = new Bitmap(File1.FileName);
                pbImagemOriginal.Image = _imagem;
            }
        }

        private void EqualizarImagem(System.ComponentModel.DoWorkEventArgs e)
        {
            Color pixel1;
            int r, g, b;
            for (int x = 0; x < _imagem.Width; x++)
                for (int y = 0; y < _imagem.Height; y++)
                {
                    VerificarCancelamento(e);

                    pixel1 = _imagem.GetPixel(x, y);
                    r = pixel1.R + 100;
                    g = pixel1.G + 100;
                    b = pixel1.B + 100;
                    _imagem.SetPixel(x, y, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }
            pbImagemEqualizada.Image = _imagem;

        }

        private void VerificarCancelamento(System.ComponentModel.DoWorkEventArgs e)
        {
            //Verifica se houve uma requisição para cancelar a operação.
            if (backgroundWorker1.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;
            }
        }

        private void btEqualizarImagem_Click(object sender, System.EventArgs e)
        {
            //desabilita os botões enquanto a tarefa é executada.
            backgroundWorker1.RunWorkerAsync();

            //define a progressBar para Marquee
            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 5;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            EqualizarImagem(e);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //Caso cancelado...
            if (e.Cancelled)
            {
                // reconfigura a progressbar para o padrao.
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 0;
                
            }
            else if (e.Error != null)
            {
                // reconfigura a progressbar para o padrao.
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 0;
            }
            else
            {
                //Carrega todo progressbar.
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 100;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                // notifica a thread que o cancelamento foi solicitado.
                // Cancela a tarefa DoWork 
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
