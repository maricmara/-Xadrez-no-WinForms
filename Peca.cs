public abstract class Peca
{
    public string Cor {get;set;}
    public (int linha, int coluna) Posicao {get;set;}
    public Peca (string cor, int linha, int coluna)
{
    Cor = Cor = cor;
    Posicao = (linha,coluna);
}
    public abstract bool MovimentoValido(int novaLinha, int novaCouna);
}
