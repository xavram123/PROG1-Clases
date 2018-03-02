using System;
class Tablas
{
	static void Main(string [] args)
	{
		int tabla, i = 1;
		string resp;
		Console.Write("Desea iniciar con una tabla s/n: ");
		resp = Console.ReadLine();
		while(resp.ToLower() == "s")
		{
			Console.Write("Digite la tabla que desea: ");
			tabla = Convert.ToInt32(Console.ReadLine());
			i = 1;
			while(i <= 10)
			{
				Console.WriteLine(tabla + " x " + i + " = " + tabla*i);
				i++;
			}
			Console.Write("Desea continuar con otra tabla s/n: ");
			resp = Console.ReadLine();
		}	
	}
}
