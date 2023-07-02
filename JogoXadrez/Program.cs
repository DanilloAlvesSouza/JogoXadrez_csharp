using JogoXadrez;
using xadrez;
using tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {

        PosicaoXadrez pos = new PosicaoXadrez('c', 7);
        Console.WriteLine(pos);
        Console.WriteLine(pos.toPosicao());
        //try
        //{
        //    Tabuleiro tab = new Tabuleiro(8, 8);
        //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
        //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
        //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
        //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
        //    Tela.imprimirTabuleiro(tab);
        //    Console.ReadLine();
        //}
        //catch (TabuleiroException e)
        //{
        //    Console.WriteLine(e.Message);
        //}
    }
}