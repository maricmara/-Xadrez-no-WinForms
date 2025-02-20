public class Rei : Peca
{
    public Rei(string cor, int linha, int coluna) : base(cor, linha, coluna) { }

    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // O Rei pode mover-se uma casa em qualquer direção
        return Math.Abs(novaLinha - Posicao.linha) <= 1 && Math.Abs(novaColuna - Posicao.coluna) <= 1;
    }
}