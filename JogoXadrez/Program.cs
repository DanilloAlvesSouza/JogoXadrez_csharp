using JogoXadrez;
using xadrez;
using tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}