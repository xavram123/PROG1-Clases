/** Realizar un programa que permita pedir 10 numeros y determine
e imprime cuantos son pares, impares y ceros. **/

using System;
class paresimpares
{
	static void Main(string []args)
	{
		int i=1, numero, cont_pares=0, cont_imp=0, cont_cero=0;
		while (i<=10)
		{
			Console.Write("Digite un numero: ");
			numero=Convert.ToInt32(Console.ReadLine());
			if (numero==0)
				cont_cero++;
			else if (numero%2==0)
				cont_pares++;
			else
				cont_imp++;
			i++;
		}
		Console.WriteLine("Cantidad de ceros: " + cont_cero);
		Console.WriteLine("Cantidad de pares: " + cont_pares);
		Console.WriteLine("Cantidad de impares: " + cont_imp);
	}
}

