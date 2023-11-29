using System;

public class Cadastro
{
    public string Nome { get; set; }
    public string EstadoCivil { get; set; }
    public DateTime DataNascimento { get; set; }
    public int RG { get; set; }
    public int CPF { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Funcao { get; set; }
    public double Salario { get; set; }

    public Cadastro()
    {

    }
    public Cadastro(string Nome, string EstadoCivil, DateTime DataNascimento, int RG, int CPF, string Email, string Telefone, string Endereco, string Cidade, string Estado, string Funcao, double Salario)
    {
        this.Nome = Nome;
        this.EstadoCivil = EstadoCivil;
        this.DataNascimento = DataNascimento;
        this.RG = RG;
        this.CPF = CPF;
        this.Email = Email;
        this.Telefone = Telefone;
        this.Endereco = Endereco;
        this.Cidade = Cidade;
        this.Estado = Estado;
        this.Funcao = Funcao;
        this.Salario = Salario;

    }

    internal static void Add(Cadastro funcionario)
    {
       
    }
}