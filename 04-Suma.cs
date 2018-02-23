/** Obtener la suma total de 10 numeros ingresados por el usuario: **/

using System;
class suma
{
	static void Main(string []args)
	{
		int sum = 0, num = 0, contador = 0;
		while (num <= 10)
		{
			Console.Write("Digite un numero: ");
			num = Convert.ToInt32(Console.ReadLine());
			sum = sum + num++;
			contador++;
		}
		Console.Write("El total de la suma de los 10 numeros ingresados es de: " + sum);
	}
}

