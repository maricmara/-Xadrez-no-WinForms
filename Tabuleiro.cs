public class Tabuleiro
   {
       private Peca[,] peças = new Peca[8, 8];

       public void InicializarTabuleiro()
       {
           // Colocar cada peça na posição correta
           peças[0, 0] = new Torre { Cor = EnumCor.Preto, Linha = 0, Coluna = 0 };
           // Continue com outras peças...
       }

       public bool MoverPeca(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
       {
           // Verifica se o movimento é válido e realiza a movimentação
           return true;
       }
   }