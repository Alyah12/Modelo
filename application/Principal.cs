using TesteNovo.entities;

namespace TesteNovo.application;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome do dono da conta: ");
        String nome = Console.ReadLine()!;
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        if (idade >= 18)
        {
            Console.Write("Digite seu CPF: ");
            string? cpf = Console.ReadLine()!;
            Console.Write("Qual o seu sálario ?");
            int balance = int.Parse(Console.ReadLine()!);

            Console.Write("Você é uma pessoa júridica? (S/N) ");
            char juridica = char.Parse(Console.ReadLine()!);
            Console.Clear();

            bool pessoaJuridica = juridica == 'S'; // quando tem um if com true no if e false no else, vc pode usar o próprio booleano como valor

            Conta cc = new Pessoa
            {
                Balance = balance,
                PessoaJuridica = pessoaJuridica
            }; // da pra inicializar o objeto assim msm, mas sei la as vezes é confuso

            Console.WriteLine("1.Depósito");
            Console.WriteLine("2.Sacar");
            Console.WriteLine("3.Extrato");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o valor: ");
                    var valor = Console.Read();
                    cc.Depositar(valor);
                    Console.WriteLine(cc.GetValue());
                    break;
                case "2":
                    Console.Write("Digite o valor que deseja sacar: ");
                    cc.Sacar(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(cc.GetValue());
                    break;
                case "3":
                    Console.WriteLine(cc.GetValue());
                    break;
                default:
                    Console.Write("Não identificado");
                    break;
            }
        }
        else
        {
            Console.Write("Você é menor de idade");
        }
    }
}