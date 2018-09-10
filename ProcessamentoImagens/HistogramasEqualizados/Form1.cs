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
        private Bitmap _imagemNova;

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
            //if (_imagemEqualizada && _graficoHistograma || _graficoEqualizado)
            {
                if (!CarregarGraficoEqualizacao(e)) return;
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
                    pixelRed.PR = (decimal)pixelRed.NK / (decimal)pixelRed.N;

                    var pixelGreen = _bdGraficoHistogramaGreen.FirstOrDefault(r => r.K == pixel.G);
                    if (pixelGreen == null)
                    {
                        pixelGreen = new HistogramaDto
                        {
                            K = pixel.G,
                            N = _imagem.Width * _imagem.Height
                        };
                        _bdGraficoHistogramaGreen.Add(pixelGreen);
                    }
                    pixelGreen.NK++;
                    pixelGreen.PR = (decimal)pixelGreen.NK / (decimal)pixelGreen.N;

                    var pixelBlue = _bdGraficoHistogramaBlue.FirstOrDefault(r => r.K == pixel.B);
                    if (pixelBlue == null)
                    {
                        pixelBlue = new HistogramaDto
                        {
                            K = pixel.B,
                            N = _imagem.Width * _imagem.Height
                        };
                        _bdGraficoHistogramaBlue.Add(pixelBlue);
                    }
                    pixelBlue.NK++;
                    pixelBlue.PR = (decimal)pixelBlue.NK / (decimal)pixelBlue.N;
                }
            }
            _bdGraficoHistogramaRed = _bdGraficoHistogramaRed.OrderBy(o => o.K).ToList();
            _bdGraficoHistogramaGreen = _bdGraficoHistogramaGreen.OrderBy(o => o.K).ToList();
            _bdGraficoHistogramaBlue = _bdGraficoHistogramaBlue.OrderBy(o => o.K).ToList();

            return true;
        }

        private bool CarregarGraficoEqualizacao(System.ComponentModel.DoWorkEventArgs e)
        {
            if (!Equalizar(e)) return false;
            if (!NovaImagemEqualizadaImagem(e)) return false;

            graficoEqualizadoR.BeginInvoke(
               new Action(() =>
               {
                   graficoEqualizadoR.Series.Add(new Series
                   {
                       Color = Color.Red,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoEqualizadoR.DataSource = _bdGraficoEqualizacaoRed;
               }
            ));

            graficoEqualizadoG.BeginInvoke(
               new Action(() =>
               {
                   graficoEqualizadoG.Series.Add(new Series
                   {
                       Color = Color.Green,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoEqualizadoG.DataSource = _bdGraficoEqualizacaoGreen;
               }
            ));

            graficoEqualizadoB.BeginInvoke(
               new Action(() =>
               {
                   graficoEqualizadoB.Series.Add(new Series
                   {
                       Color = Color.Blue,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoEqualizadoB.DataSource = _bdGraficoEqualizacaoBlue;
               }
            ));

            return true;
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

        private bool NovaImagemEqualizadaImagem(System.ComponentModel.DoWorkEventArgs e)
        {
            int R, G, B;
            Color pixel;
            _imagemNova = new Bitmap(_imagem.Width, _imagem.Height);

            for (int i = 0; i < _imagem.Width; i++)
            {
                for (int j = 0; j < _imagem.Height; j++)
                {
                    if (VerificarIsCancelamento(e))
                    {
                        _imagemNova = null;
                        return false;
                    }

                    pixel = _imagem.GetPixel(i, j);

                    var pixelNovoRed = _bdGraficoEqualizacaoRed.First(x => x.K == pixel.R);
                    R = pixelNovoRed.NEWK;

                    var pixelNovoGreen = _bdGraficoEqualizacaoGreen.First(x => x.K == pixel.G);
                    G = pixelNovoGreen.NEWK;

                    var pixelNovoBlue = _bdGraficoEqualizacaoBlue.First(x => x.K == pixel.B);
                    B = pixelNovoBlue.NEWK;

                    _imagemNova.SetPixel(i, j, Color.FromArgb(R, G,B));
                }
            }

            return true;
        }

        private void CarregarNovaImagem()
        {
            if (_imagemNova == null) return;
            pbImagemEqualizada.Image = _imagemNova;
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
            _graficoHistograma = true;

            backgroundWorker.RunWorkerAsync();

            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 5;
            
        }

        private void btEqualizarImagem_Click(object sender, EventArgs e)
        {
            CarregarNovaImagem();
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
