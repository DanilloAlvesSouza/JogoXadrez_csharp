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
        public void IncrementaQteMovimentos()
        {
            QteMovimento++;
        }
        public void DecrementaQteMovimentos()
        {
            QteMovimento--;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPosiveis();
            for(int i = 0;i<tab.linhas;i++)
            {
                for(int j = 0; j<tab.colunas;j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPosiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPosiveis();
        

       

       
    }
}
