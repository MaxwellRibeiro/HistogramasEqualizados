namespace HistogramasEqualizados
{
    public class HistogramaDto
    {
        public int K { get; set; } // Corresponde a cor
        public int N { get; set; } // Número total de pixels da imagem
        public int NK { get; set; } // Númeiro de pixels cujo o nível de cinza corresponde a k
        public decimal PR { get; set; } // Percentual do nível de cinza
    }
}
