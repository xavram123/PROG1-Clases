using System;
class Numeros
{
	static void Main(string [] args)
	{
		int num, suma=0, cont=0;
		Console.Write("Digite un numero: ");
		num=Convert.ToInt32(Console.ReadLine());
		while (num!=0)
		{
			suma+=num;
			cont++;
			Console.Write("Digite otro numero o cero para salir: ");
			num=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("La suma es: " + suma);
		Console.WriteLine("La cantidad de numeros es: " + cont);
	}
}
