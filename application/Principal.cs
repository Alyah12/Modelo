namespace TesteNovo.application;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome do dono da conta ");
        String name = Console.ReadLine()!;
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        Console.Write("Digite seu CPF: ");
        String cpf = Console.ReadLine()!;
        Console.Write("Qual o seu sálario ?");
        int balance = int.Parse(Console.ReadLine()!);
        Console.Write("Você é uma pessoa júridica? (S/M) ");
        char juridica = char.Parse(Console.ReadLine()!);

        Boolean pessoaJuridica = true;
        if (juridica == 'S')
        {
            pessoaJuridica = true;
        }
        else
        {
            pessoaJuridica = false;
        }

        Conta cc = new Conta(name, idade, cpf, balance, pessoaJuridica);

    }
}