using JogoDeXadrez.Exceptions;

namespace JogoDeXadrez.Entities.Tabuleiro
{
	internal class Tab
	{

		public int Linhas { get; set; }
		public int Colunas { get; set; }

		private Peca[,] pecas;

		public Tab(int linhas, int colunas)
		{
			Colunas = colunas;
			Linhas = linhas;
			pecas = new Peca[linhas, colunas];

		}

		public Peca peca (int linha, int coluna)
		{
			return pecas[linha, coluna];
		}

		public Peca peca(Posicao pos)
		{
			return pecas[pos.Linha, pos.Coluna];
		}

		public void colocarPeca (Peca p, Posicao pos)
		{
			if (existePeca(pos))
			{
				throw new TabuleiroExceptions("Já existe uma peça nessa posição!");
			}
			pecas[pos.Linha, pos.Coluna] = p;
			p.Posicao = pos;
			

		}

		public Peca retirarPeca(Posicao pos)
		{
			if (peca(pos) == null)
			{
				return null;
			}
			Peca aux = peca(pos);
			aux.Posicao = null;
			pecas[pos.Linha, pos.Coluna] = null;
			return aux;
		}

		public bool posicaoValida (Posicao pos)
		{
			if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
			{
				return false;
			}
			return true;
		}
		public bool existePeca(Posicao pos)
		{
			validarPosicao(pos);
			return peca(pos) != null;
		}

		public void validarPosicao (Posicao pos)
		{
			if (!posicaoValida(pos))
			{
				throw new TabuleiroExceptions("Posição inválida");
			}
		}
	}
}
