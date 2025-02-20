public class Peao : Peca
{
    public Peao(string cor, int linha, int coluna) : base(cor, linha, coluna) { }

    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // O Peão se move para frente uma casa (ou duas casas se for o primeiro movimento)
        if (Cor == "branco")
            return (novaLinha == Posicao.linha + 1 && novaColuna == Posicao.coluna);
        else
            return (novaLinha == Posicao.linha - 1 && novaColuna == Posicao.coluna);
    }
}