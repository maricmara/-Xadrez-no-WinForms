using System.Diagnostics.Contracts;

public class Tabuleiro
{
    private string[,] tabuleiro;

    public Tabuleiro()
    {
        tabuleiro = new string[8,8];
        InicializarTabuleiro();
    }
    private void InicializarTabuleiro()
    {
        //peças nas posiçoes corretas
        tabuleiro[0,0] = "T"; // torre
        tabuleiro[0,1] = "C"; //cavalo
        tabuleiro[0,2] = "B"; // bispo
        tabuleiro[0,3] = "R"; // rei
        tabuleiro[0,4] = "Ra"; // rainha
        tabuleiro[0,5] = "B"; // bispo
        tabuleiro[0,6] = "C"; // cavalo
        tabuleiro[0,7] = "T"; // torre

        for(int i = 0; i<8; i++)
        {
            tabuleiro[1,i] ="P";//Peoes na segunda linha
            tabuleiro[6,i] = "p";//peoes na setima linha (minusculo pq a peça é preta
        }

        tabuleiro[7,0] = "t";//torre
        tabuleiro[7,1] = "c";//cavalo
        tabuleiro[7,2] = "b";//bispo
        tabuleiro[7,3] = "r";//rei
        tabuleiro[7,4] = "ra";//rainha
        tabuleiro[7,5] = "b";//bispo
        tabuleiro[7,6] = "c";//cavalo
        tabuleiro[7,7] = "t";//torre
    }
    public void MostrarTabuleiro()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(tabuleiro[i, j] != null ? $"{tabuleiro[i, j]} " : ". ");
            }
            Console.WriteLine();
        }
    }

    public bool MoverPeca(int origemX, int origemY, int destinoX, int destinoY)
    {
        if (VerificarMovimento(origemX, origemY, destinoX, destinoY))
        {
            string pecaMovida = tabuleiro[origemX, origemY];
            tabuleiro[destinoX, destinoY] = pecaMovida;
            tabuleiro[origemX, origemY] = null;
            return true;
        }
        
        return false;
    }

    private bool VerificarMovimento(int origemX, int origemY, int destinoX, int destinoY)
    {
        // Aqui você deve implementar as regras de movimentação de cada peça de xadrez.
        // Para simplificar o exemplo, vamos apenas verificar se a posição de destino está vazia.
        
        if (destinoX < 0 || destinoX >= 8 || destinoY < 0 || destinoY >= 8)
            return false; // Movimento fora do tabuleiro

        if (tabuleiro[destinoX, destinoY] != null)
            return false; // Destino já ocupado

        return true; 
    }
}




