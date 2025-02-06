public class Bispo : Peca
{
   public Bispo (string cor, int linha, int coluna): base(cor,linha,coluna)
   {
   }
    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        // Bispo so pode se movimentar na diagonal
        return Math.Abs(novaLinha - Posicao.linha) == Math.Abs(novaColuna - Posicao.coluna);

}
}