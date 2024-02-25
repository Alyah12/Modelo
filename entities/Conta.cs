using System.Collections;

namespace TesteNovo.entities;

public class Conta : IEnumerable
{
    private String name;  
    private int idade;
    private string? cpf;
    private int balance;
    private Boolean pessoaJuridica;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Idade
    {
        get => idade;
        set => idade = value;
    }

    public string? Cpf
    {
        get => cpf;
        set => cpf = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Balance
    {
        get => balance;
        set => balance = value;
    }

    public bool PessoaJuridica
    {
        get => pessoaJuridica;
        set => pessoaJuridica = value;
    }

    public Conta()
    {
        
    }

    public Conta(String name, int idade, string? cpf, bool pessoaJuridica)
    {
        this.name = name;
        this.idade = idade;
        this.cpf = cpf;
        this.pessoaJuridica = pessoaJuridica;
    }

    public Conta(string name, int idade, string? cpf, int balance, bool pessoaJuridica)
    {
        this.name = name;
        this.idade = idade;
        this.cpf = cpf;
        this.balance = balance;
        this.pessoaJuridica = pessoaJuridica;
    }

    public int Deposito(int valor)
    {
        valor =+ balance;
        return 0;
    }

    public int value()
    {
        return balance;
    }

    public int JurosSobConta()
    {
        return balance - 5 * 100;
    }

    public int Sacar(int desconto)
    {
        return JurosSobConta() - desconto;
    }

    public IEnumerator GetEnumerator() => throw new NotImplementedException();
}