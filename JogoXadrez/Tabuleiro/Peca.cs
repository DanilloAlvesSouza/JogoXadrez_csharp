namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }

        public int QteMovimento { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            tab = tabuleiro;
            Cor = cor;
            QteMovimento = 0;
        }
        public abstract bool[,] MovimentosPosiveis();
        

        public void IncrementaQteMovimentos()
        {
            QteMovimento++;
        }

       
    }
}
