using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
        {

        
			double numero = 0;
			Console.Write("Digite um número: ");
			numero = Convert.ToDouble(Console.ReadLine());

			if(numero % 2 == 0)
            {
				Console.WriteLine("par");
            }
            else
            {
				Console.WriteLine("impar");
			}

		}
	}
}
