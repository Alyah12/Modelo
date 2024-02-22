using System.Collections;

namespace TesteNovo;

public class Conta : IEnumerable
{
    private String name;  
    private int idade;
    private String cpf;
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

    public string Cpf
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

    public Conta(String name, int idade, string cpf, bool pessoaJuridica)
    {
        this.name = name;
        this.idade = idade;
        this.cpf = cpf;
        this.pessoaJuridica = pessoaJuridica;
    }

    public Conta(string name, int idade, string cpf, int balance, bool pessoaJuridica)
    {
        this.name = name;
        this.idade = idade;
        this.cpf = cpf;
        this.balance = balance;
        this.pessoaJuridica = pessoaJuridica;
    }

    public int jurosSobConta()
    {
        return balance - 5 * 100;
    }

    public int Sacar(int desconto)
    {
        return jurosSobConta() - desconto;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}