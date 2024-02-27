using System.Collections;

namespace TesteNovo.entities;

public class Conta : IEnumerable
{
    protected int balance;
    public bool pessoaJuridica;

    public Conta(int balance, bool pessoaJuridica)
    {
        this.balance = balance;
        this.pessoaJuridica = pessoaJuridica;
    }

    public Conta()
    {

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

    public void Depositar(int valor)
    {
        balance += valor;
    }

    public int GetValue()
    {
        return balance;
    }

    public IEnumerator GetEnumerator() => throw new NotImplementedException();
}