using JogoDeXadrez.Entities.Tabuleiro;
using JogoDeXadrez;
using JogoDeXadrez.Entities.Xadrez;
using JogoDeXadrez.Exceptions;



namespace JogodeXadrez
{

	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				PartidaDeXadrez partida = new PartidaDeXadrez();
				while (!partida.Terminada)
				{
					try
					{
						Console.Clear();
						Tela.imprimirPartida(partida);
						Console.WriteLine();
						
						Console.WriteLine();
						Console.Write("Origem: ");
						Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
						partida.validarPosicaoDeOrigem(origem);
						bool[,] posicoesPossivels = partida.Tab.peca(origem).movimentosPossiveis();

						Console.Clear();
						Tela.imprimirTabuleiro(partida.Tab, posicoesPossivels);

						Console.WriteLine();
						Console.Write("Detino: ");
						Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
						partida.validarPosicaodeDestino(origem,destino);

						partida.realizaJogada(origem, destino);
					}
					catch(TabuleiroExceptions e)
					{
						Console.WriteLine(e.Message);
						Console.ReadLine();
					}


				}

				Tela.imprimirTabuleiro(partida.Tab);
			}
			catch (TabuleiroExceptions e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
