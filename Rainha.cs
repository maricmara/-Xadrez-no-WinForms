public class Rainha : Peca
{
   public Rainha (string cor, int linha, int coluna): base(cor,linha,coluna)
   {
   }
    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // a rainha so se move na horizontal, vertical ou diagonal
        return Math.Abs(novaLinha - Posicao.linha) == Math.Abs(novaColuna - Posicao.coluna);

}
}