/** Hacer un programa que muestre en pantalla la siguiente serie de números: 20 25 30 35… 70 75 80 **/

using System;
class SecuenciaNum
{
	static void Main(string [] args)
	{
		int i;
		for (i = 20; i <= 80; i += 5)
		{
			Console.Write(i + ", ");
		}
	}
}
