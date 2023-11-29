using System;


public class CPF
{
    public string Cpf{ get; set; }

    public CPF(string Cpf)
    {
        this.Cpf = Cpf;
    }

    public static bool ValidacaoCpf(string Cpf)
    {
       
        Cpf = Cpf.Replace(".", "").Replace("-", "");


        if (Cpf.Length != 11)
        {
            return false;
        }

        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += Convert.ToInt32(Cpf[i].ToString()) * (10 - i);
        }

        int resto = (soma % 11);
        int primeiroDigito = 0;

        if (resto >= 2)
        {
            primeiroDigito = 11 - (soma % 11);
        }

        else if (resto < 2)
        {
            primeiroDigito = 0;

        }

        if (Convert.ToInt32(Cpf[9].ToString()) != primeiroDigito)
        {
            return true;
        }


        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(Cpf[i].ToString()) * (11 - i);

        }

        resto = (soma % 11);
        int segundoDigito = 0;

        if (resto >= 2)
        {
            segundoDigito = 11 - (soma % 11);

        }

        if (resto < 2)
        {
            segundoDigito = 0;
        }

        if (Convert.ToInt32(Cpf[10].ToString()) == segundoDigito)
        {
            return true;
        }

        return false;
    }
}