using JogoDeXadrez.Entities.Tabuleiro;

namespace JogoDeXadrez.Entities.Xadrez
{
	internal class Torre : Peca
	{
		public Torre(Cor cor, Tab tab) : base(cor, tab)
		{


		}
		public override string ToString()
		{
			return "T";
		}

		private bool podeMover(Posicao pos)
		{
			Peca p = Tab.peca(pos);
			return p == null || p.Cor != Cor;
		}

		public override bool[,] movimentosPossiveis()
		{
			bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

			Posicao pos = new Posicao(0, 0);



			//verifica acima

			pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
			while(Tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.Linha, pos.Coluna] = true;
				if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
				{
					break;
				}
				pos.Linha -= 1;
			}

			//verifica abaixo

			pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
			while (Tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.Linha, pos.Coluna] = true;
				if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
				{
					break;
				}
				pos.Linha += 1;
			}

			//verifica direita

			pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
			while (Tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.Linha, pos.Coluna] = true;
				if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
				{
					break;
				}
				pos.Coluna += 1;
			}

			//verifica esquerda

			pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
			while (Tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.Linha, pos.Coluna] = true;
				if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
				{
					break;
				}
				pos.Coluna -= 1;
			}


			return mat;
		}

		}
	}
