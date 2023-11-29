using funcionario;
using System;
using System.ComponentModel;

public class Cadastro_empresa
{
    public string RazaoSocial { get; private set; }
    public string NomeFantasia { get; set; }
    public string SituacaoCadastral { get; set; }
    public string  RegimeTributario{ get; set;}
    public DateTime DataInicio { get; set; } 
    public string Telefonee { get; set; }
    public double CapitalSocial { get; set; }
    public string Endereçoo {  get; set; }
    public string Tipo { get; set; }
    public string PorteEmpresa { get; set; }
    public string NaturezaJuridica { get; set; }
    public string NomeProprietario { get; set; }
    public int CpfProprietarrio {  get; set; }

    public Cadastro_empresa()
    {

    }

    public Cadastro_empresa(string RazaoSocial, string NomeFantasia, string SituacaoCadastral,  string RegimeTributario, DateTime DataInicio, double CapitalSocial, string Endereco, string tipo, string PorteEmpresa, string NaturezaJuridica, 
        string NomeProprietario, int CpfProprietario)
    {
        this.RazaoSocial = RazaoSocial;
        this.NomeFantasia = NomeFantasia;
        this.SituacaoCadastral = SituacaoCadastral;
        this.RegimeTributario = RegimeTributario;
        this.DataInicio = DataInicio;
        this.Telefonee = Telefonee;
        this.CapitalSocial = CapitalSocial;
        this.Endereçoo = Endereco;
        this.Tipo = tipo;
        this.PorteEmpresa = PorteEmpresa;
        this.NaturezaJuridica = NaturezaJuridica;
        this.NomeProprietario = NomeProprietario;
        this.CpfProprietarrio = CpfProprietarrio;
    }

  internal static void Add(Empresa empresa)
    {

    }


}

