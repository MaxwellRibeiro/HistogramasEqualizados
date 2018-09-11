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

        private List<HistogramaDto> _bdGraficoHistogramaRed;
        private List<HistogramaDto> _bdGraficoHistogramaGreen;
        private List<HistogramaDto> _bdGraficoHistogramaBlue;

        private List<HistogramaDto> _bdGraficoHistogramaRedNovo;
        private List<HistogramaDto> _bdGraficoHistogramaGreenNovo;
        private List<HistogramaDto> _bdGraficoHistogramaBlueNovo;

        private List<EqualizacaoDto> _bdGraficoEqualizacaoRed;
        private List<EqualizacaoDto> _bdGraficoEqualizacaoGreen;
        private List<EqualizacaoDto> _bdGraficoEqualizacaoBlue;

        public Form1()
        {
            InitializeComponent();
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

            _bdGraficoHistogramaRed = new List<HistogramaDto>();
            _bdGraficoHistogramaGreen = new List<HistogramaDto>();
            _bdGraficoHistogramaBlue = new List<HistogramaDto>();

            _bdGraficoHistogramaRedNovo = new List<HistogramaDto>();
            _bdGraficoHistogramaGreenNovo = new List<HistogramaDto>();
            _bdGraficoHistogramaBlueNovo = new List<HistogramaDto>();

            _bdGraficoEqualizacaoRed = new List<EqualizacaoDto>();
            _bdGraficoEqualizacaoGreen = new List<EqualizacaoDto>();
            _bdGraficoEqualizacaoBlue = new List<EqualizacaoDto>();
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
            if (!CarregarGraficoHistograma(e)) return;
            if (!CarregarImagemEqualizacao(e)) return;
            CarregarNovaImagem();
        }

        private bool CarregarGraficoHistograma(System.ComponentModel.DoWorkEventArgs e)
        {
            if (_imagem == null) return false;

            if (!Histograma(e, _imagem, _bdGraficoHistogramaRed, _bdGraficoHistogramaGreen, _bdGraficoHistogramaBlue)) return false;

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

        private bool Histograma(System.ComponentModel.DoWorkEventArgs e, Bitmap imagem,  List<HistogramaDto> graficoHistogramaRed, List<HistogramaDto> graficoHistogramaGreen, List<HistogramaDto> graficoHistogramaBlue)
        {
            graficoHistogramaRed.Clear();
            graficoHistogramaGreen.Clear();
            graficoHistogramaBlue.Clear();

            Color pixel;
            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    if (VerificarIsCancelamento(e)) return false;
                    pixel = imagem.GetPixel(x, y);

                    var pixelRed = graficoHistogramaRed.FirstOrDefault(r => r.K == pixel.R);
                    if (pixelRed == null)
                    {
                        pixelRed = new HistogramaDto
                        {
                            K = pixel.R,
                            N = imagem.Width * imagem.Height
                        };
                        graficoHistogramaRed.Add(pixelRed);
                    }
                    pixelRed.NK++;
                    pixelRed.PR = (decimal)pixelRed.NK / (decimal)pixelRed.N;

                    var pixelGreen = graficoHistogramaGreen.FirstOrDefault(r => r.K == pixel.G);
                    if (pixelGreen == null)
                    {
                        pixelGreen = new HistogramaDto
                        {
                            K = pixel.G,
                            N = imagem.Width * imagem.Height
                        };
                        graficoHistogramaGreen.Add(pixelGreen);
                    }
                    pixelGreen.NK++;
                    pixelGreen.PR = (decimal)pixelGreen.NK / (decimal)pixelGreen.N;

                    var pixelBlue = graficoHistogramaBlue.FirstOrDefault(r => r.K == pixel.B);
                    if (pixelBlue == null)
                    {
                        pixelBlue = new HistogramaDto
                        {
                            K = pixel.B,
                            N = imagem.Width * imagem.Height
                        };
                        graficoHistogramaBlue.Add(pixelBlue);
                    }
                    pixelBlue.NK++;
                    pixelBlue.PR = (decimal)pixelBlue.NK / (decimal)pixelBlue.N;
                }
            }

            return true;
        }

        private bool CarregarImagemEqualizacao(System.ComponentModel.DoWorkEventArgs e)
        {
            if (!Equalizar(e)) return false;
            if (!NovaImagemEqualizada(e)) return false;
            if (!CarregarGraficoEqualizado(e)) return false;

            return true;
        }

        private bool Equalizar(System.ComponentModel.DoWorkEventArgs e)
        {
            _bdGraficoEqualizacaoRed.Clear();
            _bdGraficoEqualizacaoGreen.Clear();
            _bdGraficoEqualizacaoBlue.Clear();
            
            decimal soma = 0;
            foreach (var histoRed in _bdGraficoHistogramaRed.OrderBy(o=> o.K))
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
            foreach (var histoGreen in _bdGraficoHistogramaGreen.OrderBy(o => o.K))
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
            foreach (var histoBlue in _bdGraficoHistogramaBlue.OrderBy(o => o.K))
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

        private bool NovaImagemEqualizada(System.ComponentModel.DoWorkEventArgs e)
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

        private bool CarregarGraficoEqualizado(System.ComponentModel.DoWorkEventArgs e)
        {
            if (_imagemNova == null) return false;

            if (!Histograma(e, _imagemNova, _bdGraficoHistogramaRedNovo, _bdGraficoHistogramaGreenNovo, _bdGraficoHistogramaBlueNovo)) return false;

            graficoEqualizadoR.BeginInvoke(
               new Action(() =>
               {
                   graficoEqualizadoR.Series.Add(new Series
                   {
                       Color = Color.Red,
                       XValueMember = "K",
                       YValueMembers = "NK"
                   });
                   graficoEqualizadoR.DataSource = _bdGraficoHistogramaRedNovo;
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
                   graficoEqualizadoG.DataSource = _bdGraficoHistogramaGreenNovo;
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
                   graficoEqualizadoB.DataSource = _bdGraficoHistogramaBlueNovo;
               }
            ));

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
        
        private void btEqualizarImagem_Click(object sender, EventArgs e)
        {
            if (_imagem == null) return;

            try
            {
                backgroundWorker.RunWorkerAsync();

                ProgressBar.Style = ProgressBarStyle.Marquee;
                ProgressBar.MarqueeAnimationSpeed = 5;
            }
            catch (Exception x)
            {
                MessageBox.Show(@"Não foi Possível Equalizar Imagem!");
            }
            
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
