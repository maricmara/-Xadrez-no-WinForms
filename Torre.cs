using System.ComponentModel.DataAnnotations.Schema;

public class Torre : Peca
{
   public Torre (string cor, int linha, int coluna): base(cor,linha,coluna)
   {
   }
    public override bool MovimentoValido(int novaLinha, int novaColuna)
    {
        return novaLinha == Posicao.linha || novaColuna == Posicao.coluna;

}
}