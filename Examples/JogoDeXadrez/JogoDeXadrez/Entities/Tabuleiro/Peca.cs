
namespace JogoDeXadrez.Entities.Tabuleiro
{
	abstract class Peca
	{
		public Posicao Posicao { get; set; }
		public Cor Cor { get; protected set; }
		public int QteMovimentos { get; protected set; }
		public Tab Tab { get; set; }

		public Peca( Cor cor, Tab tab)
		{
			Posicao = null;
			Cor = cor;
			QteMovimentos = 0;
			Tab = tab;
		}

		public void incrementarMovimento()
		{
			QteMovimentos++;
		}
		public bool existeMovimentosPossiveis()
		{
			bool[,] mat = movimentosPossiveis();
			for(int i = 0; i< Tab.Linhas; i++)
			{
				for(int j = 0; j< Tab.Colunas; j++)
				{
					if (mat[i, j])
					{
						return true;
					}
				}
			}
			return false;
		}

		public bool podeMoverPara(Posicao pos)
		{
			return movimentosPossiveis()[pos.Linha, pos.Coluna];
		}

		public abstract bool[,] movimentosPossiveis();
		
	}
}
