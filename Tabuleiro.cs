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
        // Exemplo de inicialização das peças (apenas algumas peças para ilustrar)
        peças[0, 0] = new Torre("preto", 0, 0);
        peças[0, 1] = new Cavalo("preto", 0, 1);
        peças[7, 0] = new Torre("branco", 7, 0);
        peças[7, 1] = new Cavalo("branco", 7, 1);
        
        // Adicione mais peças conforme necessário...
    }

    public bool MovimentoValido(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
    {
        Peca peca = peças[linhaOrigem, colunaOrigem];
        
        if (peca != null)
            return peca.MovimentoValido(linhaDestino, colunaDestino);

        return false;
    }
}