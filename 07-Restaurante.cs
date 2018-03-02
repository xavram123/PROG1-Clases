/** En un restaurante de desea saber la venta total del dia, pero dependera de los diferentes 
	platillos que elija el cliente los cuales son:

		1. El desayuno cuesta      $2.50
		2. El plato de cereal      $1.50
		3. El plato de Pescado     $3.00
		4. Plato filete de carne   $3.50
		5. Pupusas (Precio Indv)   $0.50
		6. Porcion Arroz Cantones  $0.75

	Desplegar un menu en pantalla con las diferente opciones que ofrece el restaurante y 
	determine la cantidad de clientes que obtuvo en el dia, el total recaudado por plato, el 
	total de clientes por plato y el total recaudado en el dia. **/

using System;

class Restaurante
{
	static void Main(string []args)
	{
		double Opcion, CantClient=0, CanTipico=0, CantCereal=0, CantPez=0, CantCarne=0, CantPupas=0, CantArroz=0;
		double TotalDia=0, TotTipico=0, TotCereal=0, TotPez=0, TotCarne=0, TotPupas=0, TotArroz=0;
		string Resp = "No";

		Console.Write("Seleccione una de las siguientes opciones del menu: ");
		Console.Write("Opcion 1 >> Plato Desayuno Tipico  - $2.50");
		Console.Write("Opcion 2 >> Plato de Cereal        - $1.50");
		Console.Write("Opcion 3 >> Plato de Pescado       - $3.00");
		Console.Write("Opcion 4 >> Plato Filete de Carne  - $3.50");
		Console.Write("Opcion 5 >> Pupusas Maiz/Arroz     - $0.50");
		Console.Write("Opcion 6 >> Porcion Arroz Cantones - $0.75");
		Opcion = int.Parse(Console.ReadLine());

		Console.Write("Otra orden? Si/No: ");
		while(Resp.ToLower()=="No")
		{
			switch (Opcion)
			{
				case 1:
				CanTipico = CanTipico + 1;
				TotTipico = CanTipico * 2.50;
				break;
				case 2:
				CantCereal = CantCereal + 1;
				TotCereal = CantCereal * 1.50;
				break;
				case 3:
				CantPez = CantPez + 1;
				TotPez = CantPez * 3.00;
				break;
				case 4:
				CantCarne = CantCarne + 1;
				TotCarne = CantCarne * 3.50;
				break;
				case 5:
				CantPupas = CantPupas + 1;
				TotPupas = CantPupas * 0.50;
				break;
				case 6:
				CantArroz = CantArroz + 1;
				TotArroz = CantArroz * 0.75;
				break;
				default:
				Console.Write("Opcion incorrecta, Seleccione una de las opciones del menu: ");
				break;
			}
			CantClient = CantClient + 1;
			TotalDia = TotTipico + TotCereal + TotPez + TotCarne + TotPupas + TotArroz;

			Console.WriteLine("Total de clientes del dia: " + CantClient);
			Console.WriteLine("Total recaudado por Platos Tipicos: " + "$"TotTipico + " | Numero de clientes que lo ordenaron: " + CanTipico);
			Console.WriteLine("Total recaudado por Platos de Cereal: " + "$"TotCereal + " | Numero de clientes que lo ordenaron: " + CantCereal);
			Console.WriteLine("Total recaudado por Platos de Pescado: " + "$"TotPez + " | Numero de clientes que lo ordenaron: " + CantPez);
			Console.WriteLine("Total recaudado por Platos de Carne: " + "$"TotCarne + " | Numero de clientes que lo ordenaron: " + CantCarne);
			Console.WriteLine("Total recaudado por Platos de Pupusas: " + "$"TotPupas + " | Numero de clientes que lo ordenaron: " + CantPupas);
			Console.WriteLine("Total recaudado por Platos de Arroz Cantones: " + "$"TotArroz + " | Numero de clientes que lo ordenaron: " + CantArroz);
			Console.WriteLine("Total recaudado durante el transcurso del dia: " + "$"TotalDia);
		}
    }
}
