using System.Collections;

namespace TesteNovo.entities;

public class Conta : IEnumerable
{
    protected int balance;
    public Boolean pessoaJuridica;

    public Conta(int balance, bool pessoaJuridica)
    {
        this.balance = balance;
        this.pessoaJuridica = pessoaJuridica;
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

    public int JurosSobConta()
    {
        return balance - 5 / 100;
    }

    public int Sacar(int descontoSaque)
    {
        return JurosSobConta() - descontoSaque;
    }

    public Conta()
    {
        
    }

    public int Deposito(int valor)
    {
        return valor =+ balance;
    }

    public int value()
    {
        return balance;
    }

    public IEnumerator GetEnumerator() => throw new NotImplementedException();
}