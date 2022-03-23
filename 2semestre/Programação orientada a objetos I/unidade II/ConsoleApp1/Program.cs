// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeiro_Programa
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá mundo em C# !!!");
        Console.ReadLine();
            string nome = "Caio";
            string sobrenome = " Alexandre";
            string str = nome + sobrenome;

            Console.WriteLine("str = {0}", str);
            
            Console.WriteLine("Olá qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("E Qual a sua idade?");
            int idade;
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0}, Você tem {1} anos de idade.", nome, idade);
            Console.ReadKey();

        }
    }
}