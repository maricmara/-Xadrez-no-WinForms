public class Tabuleiro
{
    private Peca[,] peças;

    public Tabuleiro()
    {
        peças = new Peca[8, 8];
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        
        peças[0, 0] = new Torre("preto", 0, 0);
        peças[0, 1] = new Cavalo("preto", 0, 1);
        peças[7, 0] = new Torre("branco", 7, 0);
        peças[7, 1] = new Cavalo("branco", 7, 1);
        peças[7, 1] = new Bispo("preto", 0, 2);
        peças[7, 1] = new Bispo("branco", 7, 2);
        peças[7, 1] = new Rei("branco", 7, 3);
        peças[7, 1] = new Rei("preto", 0, 3);
        peças[7, 1] = new Rainha("branco", 7, 4);
        peças[7, 1] = new Rainha("preto", 0, 4);
        peças[7, 1] = new Peao("branco", 6, 0);
         peças[7, 1] = new Peao("preto", 0, 0);
    }

    public bool MovimentoValido(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
    {
        Peca peca = peças[linhaOrigem, colunaOrigem];
        
        if (peca != null)
            return peca.MovimentoValido(linhaDestino, colunaDestino);

        return false;
    }
}