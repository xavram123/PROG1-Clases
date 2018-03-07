/** A una fiesta asistieron 50 personas de diferentes edades y sexos. Hacer un 
programa que dadas las edades y sexo de las personas permita calcular: 

1. Cuantos hombres y mujeres asistieron
2. Promedio de edades por sexo.
3. La edad de la persona mas joven que existio. **/

using System;
class fiesta {
	public static void Main(string []args) {

		int personas = 5, edad, edadH, edadM, promEdadH, promEdadM, edadJoven, totalH = 0, totalM = 0;
		string sexo;
		char resp;

		Console.Write("Para ingresar a la fiesta especifique su genero, (M) para Masculino o (F) para Femenino: ");
		sexo = Console.ReadLine();
		Console.Write("Ingrese su edad: ");
		edad = Convert.ToInt32(Console.ReadLine());

		while (resp == 'S') {

			switch (sexo) {
				case M:
				case m:
				case Masculino:
				case masculino:
					edadH = edadH + edad;
					totalH++;
				break;
				case F:
				case f:
				case Femenino:
				case femenino:
					edadM = edadM + edad;
					totalM++;
				break;
				default;
					Console.WriteLine("Datos ingresados incorrectos, Introduzca M o F segun sea su caso: ");
				break;
			}
			Console.Write("Desear ingresar otra persona? S/N: ");
			resp = Convert.ToLower(Console.ReadLine());
			resp++;
		}

		promEdadH = edadH / totalH;
		promEdadM = edadM / totalM; 

		Console.WriteLine("\n", "Numero de hombres que asistieron a la fiesta: " + totalH);
		Console.WriteLine("\n", "Numero de mujeres que asistieron a la fiesta: " + totalM);
		Console.WriteLine("\n", "Edad promedio de los hombres que asistieron: " + promEdadH);
		Console.WriteLine("\n", "Edad promedio de las mujeres que asistieron: " + promEdadM);
		Console.WriteLine("\n", "Edad de la persona(s) mas joven que asistio(eron): ");
	}
}
