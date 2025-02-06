using System.Diagnostics.Contracts;

public class Tabuleiro
{
    private Peca[,] peças;
}
public Tabuleiro()
{
    peças = new Peca [8,8];
    InicializarTabuleiro();
}