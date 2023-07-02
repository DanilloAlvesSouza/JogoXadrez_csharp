namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }

        public int QteMovimento { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tab = tabuleiro;
            Cor = cor;
            QteMovimento = 0;
        }

        public void IncrementaQteMovimentos()
        {
            QteMovimento++;
        }

       
    }
}
