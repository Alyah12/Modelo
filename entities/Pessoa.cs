namespace TesteNovo.entities;

public class Pessoa : Conta
{
   private String nome;
   private int conta;
   private string cpf;

   public new double JurosSobConta()
   {
      return balance - 4 / 100;
   }
}