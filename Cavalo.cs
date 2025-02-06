public class Cavalo : Peca
{
   public Cavalo (string cor, int linha, int coluna): base(cor,linha,coluna)
   {
   }
    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        //o cavalo se move em L 
          return Math.Abs(novaLinha - Posicao.linha) == 2 && (Math.Abs(novaColuna - Posicao.coluna) == 1) || (Math.Abs(novaLinha - Posicao.linha) == 1 && Math.Abs(novaColuna - Posicao.coluna) == 2);



}
}