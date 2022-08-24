using JogoDeXadrez.Entities.Tabuleiro;
using JogoDeXadrez.Exceptions;
using System.Collections.Generic;

namespace JogoDeXadrez.Entities.Xadrez
{
	class PartidaDeXadrez
	{
		public Tab Tab { get; private set; }
		public int Turno { get; private set; }
		public Cor JogadorAtual { get; private set; }
		public bool Terminada { get; private set; }

		private HashSet<Peca> pecas;
		private HashSet<Peca> capturadas;

		public PartidaDeXadrez()
		{
			Tab = new Tab(8, 8);
			Turno = 1;
			JogadorAtual = Cor.Branca;
			ColocarPecas();
			Terminada = false;
			pecas = new HashSet<Peca>();
			capturadas = new HashSet<Peca>();
		}


		public void executarMovimento(Posicao origem, Posicao destino)
		{
			Peca p = Tab.retirarPeca(origem);
			p.incrementarMovimento();
			Peca pecaCapturada = Tab.retirarPeca(destino);
			Tab.colocarPeca(p, destino);
			if (pecaCapturada != null)
			{
				capturadas.Add(pecaCapturada);
			}
		}
		public void validarPosicaoDeOrigem(Posicao pos)
		{
			if (Tab.peca(pos) == null)
			{
				throw new TabuleiroExceptions("Não existe peça na posição de origem escolhida");

			}
			if (JogadorAtual != Tab.peca(pos).Cor)
			{
				throw new TabuleiroExceptions("A peça de origem escolhida não é sua");
			}

			if (!Tab.peca(pos).existeMovimentosPossiveis())
			{
				throw new TabuleiroExceptions("Não há movimentos possiveis para a peça de origem escolhida");
			}
		}

		public void validarPosicaodeDestino(Posicao origem, Posicao destino)
		{
			if (!Tab.peca(origem).podeMoverPara(destino))
			{
				throw new TabuleiroExceptions("Posição de destino inválida!");

			}
		}

		public void realizaJogada(Posicao origem, Posicao destino)
		{
			executarMovimento(origem, destino);
			Turno++;
			mudaJogador();

		}

		private void mudaJogador()
		{
			if (JogadorAtual == Cor.Branca)
			{
				JogadorAtual = Cor.Preta;
			}
			else
			{
				JogadorAtual = Cor.Branca;
			}
		}

		public HashSet<Peca> pecasCapturadas(Cor cor)
		{
			HashSet<Peca> aux = new HashSet<Peca>();
			foreach (Peca x in capturadas)
			{
				aux.Add(x);
			}

			return aux;
		}

		public HashSet<Peca> pecasEmJogo(Cor cor)
		{
			HashSet<Peca> aux = new HashSet<Peca>();
			foreach (Peca x in pecas)
			{
				if (x.Cor == cor)
				{
					aux.Add(x);
				}
			}
			aux.ExceptWith(pecasCapturadas(cor));
			return aux;
		}

		public void ColocarNovaPeca(char coluna, int linha, Peca peca)
		{
			Tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
			//pecas.Add(peca);
		}
		public void ColocarPecas()
		{
			ColocarNovaPeca('c', 1, new Torre(Cor.Branca, Tab));
			ColocarNovaPeca('c', 2, new Torre(Cor.Branca, Tab));
			ColocarNovaPeca('c', 7, new Torre(Cor.Preta, Tab));


		}
	}
}
