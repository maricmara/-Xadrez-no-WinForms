public class Peca
   {
       public EnumCor Cor { get; set; }
       public int Linha { get; set; }
       public int Coluna { get; set; }

       public virtual bool MovimentoValido(int novaLinha, int novaColuna)
       {
           // Lógica básica para validação de movimento
           return true;
       }
   }
