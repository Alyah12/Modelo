namespace TesteNovo.entities;

public class PessoaJuridica : Conta
{
    private String nome;
    private int cnpj;

    public PessoaJuridica(int balance, bool pessoaJuridica, string nome, int cnpj) : base(balance, pessoaJuridica)
    {
        this.nome = nome;
        this.cnpj = cnpj;
    }

    public PessoaJuridica(string nome, int cnpj)
    {
        this.nome = nome;
        this.cnpj = cnpj;
    }

    public string Nome => nome;

    public int Cnpj => cnpj;

    public int Balance1 => balance;

    public bool PessoaJuridica1 => pessoaJuridica;

    public double JurosSobConta()
    {
        return balance - 4 / 100;
    }

    public double Sacar(int descontoSaque)
    {
        return JurosSobConta() - descontoSaque;
    }
}