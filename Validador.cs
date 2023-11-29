using System;
using System.Text.RegularExpressions;

public class Cpf
{
    public string CPF{ get; set; }

    public Cpf(string CPF)
    {
        this.CPF = CPF;
    }

    public static bool ValidacaoCPF(string Cpf)
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
    public class ValidarEmail
    {
        public string Email { get; set; }
    }
    public static bool ValidacaoEmail(string Email)
    {
        //essa expressao é utilizada para validar o formato do email
        string  pattern = @"[a-zA-ZO-9_.+-]+@[a_zA-ZO_9]+\.[a_zA_ZO-9-.]+$";

        return Regex.IsMatch(Email, pattern);


        Console.WriteLine("Digite o e-mail para validar: ");
        string emailToValidate = Console.ReadLine();

        if(ValidacaoEmail(emailToValidate))
        {
            Console.WriteLine("E-mail válido!");
        }
        else
        {
            Console.WriteLine("E-mail inválido!");
        }
    }
}
