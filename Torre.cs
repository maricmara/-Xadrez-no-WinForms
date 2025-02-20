public class Torre : Peca
{
    public Torre(string cor, int linha, int coluna) : base(cor, linha, coluna) { }

    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // A Torre pode mover-se em linha reta
        return novaLinha == Posicao.linha || novaColuna == Posicao.coluna;
    }
}

public class Bispo : Peca
{
    public Bispo(string cor, int linha, int coluna) : base(cor, linha, coluna) { }

    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // O Bispo pode mover-se na diagonal
        return Math.Abs(novaLinha - Posicao.linha) == Math.Abs(novaColuna - Posicao.coluna);
    }
}