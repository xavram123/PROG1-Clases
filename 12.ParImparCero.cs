/** Hacer un programa que permita capturar 10 números y que muestre un mensaje 
	para determinar si el numero es par, impar o cero.  **/

using System;
class ParImparCero
{
	static void Main(string [] args)
	{
		int i, Num = 0;
		for (i = 1; i <= 10; i++)
		{
			Console.Write("Digite un numero: ");
			Num = Convert.ToInt32(Console.ReadLine());

			if(Num == 0)
				Console.WriteLine("El numero es cero");
			else if(Num % 2 == 0)
				Console.WriteLine(Num + "Es un numero par");
			else 
				Console.WriteLine(Num + "Es un numero impar");
		}
	}
}
