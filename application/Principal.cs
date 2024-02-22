namespace TesteNovo.application;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome do dono da conta ");
        String name = Console.ReadLine()!;
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        String cpf = null;
        int balance = 0;

        if (idade >= 18)
        {
            Console.Write("Digite seu CPF: ");
            cpf = Console.ReadLine()!;
            Console.Write("Qual o seu sálario ?");
            balance = int.Parse(Console.ReadLine()!);

        }
        Console.Write("Você é uma pessoa júridica? (S/N) ");
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