namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }

        public int QteMovimento { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tab = tabuleiro;
            Cor = cor;
            QteMovimento = 0;
        }



       
    }
}
