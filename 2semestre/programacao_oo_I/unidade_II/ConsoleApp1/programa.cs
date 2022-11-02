using System;

namespace exemploConsoleApp
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello Word!");                
        }
    }
}

public class Pessoa
{
    public string PrimeiroNome { get; set; }
    public string SobreNome { get; set; }
    public string GetNomeCompleto ()

    {
        return PrimeiroNome + " " + GetNomeCompleto;
    }
}

public class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
}