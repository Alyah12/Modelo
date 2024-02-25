namespace TesteNovo.entities;

public class PessoaJuridica : Conta
{
    private String _nome;
    private int _cnpj;

    public PessoaJuridica(int balance, bool pessoaJuridica, string nome, int cnpj) : base(balance, pessoaJuridica)
    {
        this._nome = nome;
        this._cnpj = cnpj;
    }

    public PessoaJuridica(string nome, int cnpj)
    {
        this._nome = nome;
        this._cnpj = cnpj;
    }

    public string Nome => _nome;

    public int Cnpj => _cnpj;

    public int Balance1 => balance;

    public bool PessoaJuridica1 => pessoaJuridica;

    public new double JurosSobConta()
    {
        return balance - 4 / 100;
    }

    public new double Sacar(int descontoSaque)
    {
        return JurosSobConta() - descontoSaque;
    }
}