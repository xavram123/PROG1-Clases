/** Hacer un programa que muestre los numeros pares entre el 2 al 100 **/

using System;
class numeros
{
	static void Main(string []args)
	{
		int num = 2; /** Contador i = num **/
		while (num <= 100) /** Limita el acumulador hasta 100 **/
		{
			Console.Write(num + " ");
			num+=2;
		}
	}
}

