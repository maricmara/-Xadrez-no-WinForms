public class Program
{
    public static void Main(string[] args)
    {
        Tabuleiro meuTabuleiro = new Tabuleiro();
        
        meuTabuleiro.MostrarTabuleiro();
        
        Console.WriteLine("Movendo a peça da posição (1,0) para (3,0):");
        
        if (meuTabuleiro.MoverPeca(1, 0, 3, 0))
            Console.WriteLine("Movimento realizado com sucesso!");
        
        meuTabuleiro.MostrarTabuleiro();
    }
}