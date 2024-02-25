﻿using TesteNovo.entities;

namespace TesteNovo.application;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome do dono da conta: ");
        String nome = Console.ReadLine()!;
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        string? cpf = null;
        int balance = 0;

       if (idade >= 18)
        {
            Console.Write("Digite seu CPF: ");
            cpf = Console.ReadLine()!;
            Console.Write("Qual o seu sálario ?");
            balance = int.Parse(Console.ReadLine()!);

            Console.Write("Você é uma pessoa júridica? (S/N) ");
            char juridica = char.Parse(Console.ReadLine()!);
            Console.Clear();

            bool pessoaJuridica = true;
            if (juridica == 'S')
            {
                pessoaJuridica = true;
            }
            else
            {
                pessoaJuridica = false;
            }

            Conta cc = new Conta();

            Console.WriteLine("1.Depósito");
            Console.WriteLine("2.Sacar");
            Console.WriteLine("3.Extrato");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1" :
                    Console.Write("Digite o valor: ");
                    cc.Deposito(Console.Read());
                    Console.WriteLine(cc.value());
                    break;
                case "2":
                    Console.Write("Digite o valor que deseja sacar: ");
                    cc.Sacar(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(cc.value());
                    break;
                case "3":
                    Console.WriteLine(cc.value());
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