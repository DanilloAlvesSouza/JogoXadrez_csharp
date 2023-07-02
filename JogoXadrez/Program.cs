using JogoXadrez;
using xadrez;
using tabuleiro;
using JogoXadrez.xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();


            while (!partida.Terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partida.Turno);
                    Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ValidarPosicaoOrigem(origem);

                    bool[,] posicoesPossiveis = partida.Tab.peca(origem).MovimentosPosiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ValidarPosicaoDestino(origem, destino);

                    partida.RealizaJogada(origem, destino);
                }
                catch (TabuleiroException e)
                { 
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                

            }
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}