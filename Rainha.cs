public class Rainha : Peca
{
    public Rainha(string cor, int linha, int coluna) : base(cor, linha, coluna) { }

    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // A Rainha pode mover-se horizontalmente, verticalmente ou diagonalmente
        return (novaLinha == Posicao.linha || novaColuna == Posicao.coluna ||
                Math.Abs(novaLinha - Posicao.linha) == Math.Abs(novaColuna - Posicao.coluna));
    }
}