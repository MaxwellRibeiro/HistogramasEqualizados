using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HistogramasEqualizados
{
    public partial class Form1 : MaterialForm
    {
        private Bitmap _imagem;

        private bool _imagemEqualizada;
        private bool _graficoHistograma;
        private bool _graficoEqualizado;

        private List<HistogramaDto> _bdGraficoHistogramaRed;
        private List<HistogramaDto> _bdGraficoHistogramaGreen;
        private List<HistogramaDto> _bdGraficoHistogramaBlue;

        private List<EqualizacaoDto> _bdGraficoEqualizacaoRed;
        private List<EqualizacaoDto> _bdGraficoEqualizacaoGreen;
        private List<EqualizacaoDto> _bdGraficoEqualizacaoBlue;

        public Form1()
        {
            InitializeComponent();

            _imagemEqualizada = false;
            _graficoHistograma = false;
            _graficoEqualizado = false;

            _bdGraficoHistogramaRed = new List<HistogramaDto>();
             _bdGraficoHistogramaGreen = new List<HistogramaDto>();
             _bdGraficoHistogramaBlue = new List<HistogramaDto>();

             _bdGraficoEqualizacaoRed = new List<EqualizacaoDto>();
             _bdGraficoEqualizacaoGreen = new List<EqualizacaoDto>();
            _bdGraficoEqualizacaoBlue = new List<EqualizacaoDto>();
    }

        private void btCarregarImagem_Click(object sender, EventArgs e)
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 0;
            }
            else if (e.Error != null)
            {
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 0;
            }
            else
            {
                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 100;
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if(_imagemEqualizada || _graficoHistograma || _graficoEqualizado)
            {
                if (!CarregarGraficoHistograma(e)) return;
            }
        }

        private bool CarregarGraficoHistograma(System.ComponentModel.DoWorkEventArgs e)
        {
            if (_imagem == null) return false;

            if (!Histograma(e)) return false;

            graficoHistogramaR.BeginInvoke(
               new Action(() =>
               {
                   graficoHistogramaR.Series.Add(new Series
                   {
                       Color = Color.Red,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoHistogramaR.DataSource = _bdGraficoHistogramaRed;
               }
            ));

            graficoHistogramaG.BeginInvoke(
               new Action(() =>
               {
                   graficoHistogramaG.Series.Add(new Series
                   {
                       Color = Color.Green,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoHistogramaG.DataSource = _bdGraficoHistogramaGreen;
               }
            ));

            graficoHistogramaB.BeginInvoke(
               new Action(() =>
               {
                   graficoHistogramaB.Series.Add(new Series
                   {
                       Color = Color.Blue,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoHistogramaB.DataSource = _bdGraficoHistogramaBlue;
               }
            ));

            return true;
        }

        private bool Histograma(System.ComponentModel.DoWorkEventArgs e)
        {
            _bdGraficoHistogramaRed.Clear();
            _bdGraficoHistogramaGreen.Clear();
            _bdGraficoHistogramaBlue.Clear();

            Color pixel;
            for (int x = 0; x < _imagem.Width; x++)
            {
                for (int y = 0; y < _imagem.Height; y++)
                {
                    if (VerificarIsCancelamento(e)) return false;
                    pixel = _imagem.GetPixel(x, y);

                    var pixelRed = _bdGraficoHistogramaRed.FirstOrDefault(r => r.K == pixel.R);
                    if (pixelRed == null)
                    {
                        pixelRed = new HistogramaDto
                        {
                            K = pixel.R,
                            N = _imagem.Width * _imagem.Height
                        };
                        _bdGraficoHistogramaRed.Add(pixelRed);
                    }
                    pixelRed.NK++;
                    pixelRed.PR = pixelRed.NK / pixelRed.N;

                    var pixelGreen = _bdGraficoHistogramaGreen.FirstOrDefault(r => r.K == pixel.G);
                    if (pixelGreen == null)
                    {
                        pixelGreen = new HistogramaDto
                        {
                            K = pixel.R,
                            N = _imagem.Width * _imagem.Height
                        };
                        _bdGraficoHistogramaGreen.Add(pixelGreen);
                    }
                    pixelGreen.NK++;
                    pixelGreen.PR = pixelGreen.NK / pixelGreen.N;

                    var pixelBlue = _bdGraficoHistogramaBlue.FirstOrDefault(r => r.K == pixel.B);
                    if (pixelBlue == null)
                    {
                        pixelBlue = new HistogramaDto
                        {
                            K = pixel.R,
                            N = _imagem.Width * _imagem.Height
                        };
                        _bdGraficoHistogramaBlue.Add(pixelBlue);
                    }
                    pixelBlue.NK++;
                    pixelBlue.PR = pixelBlue.NK / pixelBlue.N;
                }
            }
            _bdGraficoHistogramaRed = _bdGraficoHistogramaRed.OrderBy(o => o.K).ToList();
            _bdGraficoHistogramaGreen = _bdGraficoHistogramaGreen.OrderBy(o => o.K).ToList();
            _bdGraficoHistogramaBlue = _bdGraficoHistogramaBlue.OrderBy(o => o.K).ToList();

            return true;
        }

        private void CarregarGraficoEqualizacao(System.ComponentModel.DoWorkEventArgs e)
        {
            if (!Equalizar(e)) return;

            //Continue
        }

        private bool Equalizar(System.ComponentModel.DoWorkEventArgs e)
        {
            _bdGraficoEqualizacaoRed.Clear();
            _bdGraficoEqualizacaoGreen.Clear();
            _bdGraficoEqualizacaoBlue.Clear();
            
            decimal soma = 0;
            foreach (var histoRed in _bdGraficoHistogramaRed)
            {
                if (VerificarIsCancelamento(e)) return false;

                soma += histoRed.PR;

                _bdGraficoEqualizacaoRed.Add(new EqualizacaoDto
                {
                    K = histoRed.K,
                    S = soma,
                    NEWK = (int)Math.Round(soma * 255, 0)
                });
            }

            soma = 0;
            foreach (var histoGreen in _bdGraficoHistogramaGreen)
            {
                if (VerificarIsCancelamento(e)) return false;

                soma += histoGreen.PR;

                _bdGraficoEqualizacaoGreen.Add(new EqualizacaoDto
                {
                    K = histoGreen.K,
                    S = soma,
                    NEWK = (int)Math.Round(soma * 255, 0)
                });
            }

            soma = 0;
            foreach (var histoBlue in _bdGraficoHistogramaBlue)
            {
                if (VerificarIsCancelamento(e)) return false;

                soma += histoBlue.PR;

                _bdGraficoEqualizacaoBlue.Add(new EqualizacaoDto
                {
                    K = histoBlue.K,
                    S = soma,
                    NEWK = (int)Math.Round(soma * 255, 0)
                });
            }

            return true;
        }

        private void CarregarNovaImagem()
        {
            Color pixel1;
            int r, g, b;
            for (int x = 0; x < _imagem.Width; x++)
                for (int y = 0; y < _imagem.Height; y++)
                {


                    pixel1 = _imagem.GetPixel(x, y);
                    r = pixel1.R + 100;
                    g = pixel1.G + 100;
                    b = pixel1.B + 100;
                    _imagem.SetPixel(x, y, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }
            pbImagemEqualizada.Image = _imagem;
        }

        private bool VerificarIsCancelamento(System.ComponentModel.DoWorkEventArgs e)
        {
            //Verifica se houve uma requisição para cancelar a operação.
            if (backgroundWorker.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return true;
            }
            return false;
        }

        private void btGraficoHistograma_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 5;
        }

        private void btEqualizarImagem_Click(object sender, EventArgs e)
        {
            //desabilita os botões enquanto a tarefa é executada.
            backgroundWorker.RunWorkerAsync();

            //define a progressBar para Marquee
            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 5;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }
    }
    
}
