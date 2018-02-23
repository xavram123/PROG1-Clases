/** Haga un programa, que dados como datos la categoría y el sueldo de los empleados administrativos de una empresa, 
calcule el aumento correspondiente teniendo en cuenta la siguiente tabla. Imprimir el código del empleado, el 
nombre completo, la categoría y el nuevo sueldo.

Categoría 		Aumento
	1 			      20%
	2 			      15%
	3 			      10%
	4 			       5% **/

using System;
class sueldos
{
	static void Main(string []args)
	{
	string nombre, codigo;
	int categ;
	double sueldo, nuevoSueldo;

	Console.Write("Introduzca la categoria del trabajador: ");
	categ = Convert.ToInt32(Console.ReadLine());
	Console.Write("Introduzca el numero de codigo del trabajador: ");
	codigo = Console.ReadLine();
	Console.Write("Introduzca el nombre completo del trabajador: ");
	nombre = Console.ReadLine();
	Console.Write("Introduzca el sueldo actual del trabajador: ");
	sueldo = Convert.ToDouble(Console.ReadLine());

	switch (categ)
	{
	case 1:
	nuevoSueldo = sueldo + sueldo * 0.20;
	Console.Write("Codigo Empleado: " + codigo + " | " + "Nombre: " + nombre + " | " + "Categoría: " + categ + " | " + "Nuevo Salario: " + nuevoSueldo);
	break;
	case 2:
	nuevoSueldo = sueldo + sueldo * 0.15;
	Console.Write("Codigo Empleado: " + codigo + " | " + "Nombre: " + nombre + " | " + "Categoría: " + categ + " | " + "Nuevo Salario: " + nuevoSueldo);
	break;
	case 3:
	nuevoSueldo = sueldo + sueldo * 0.10;
	Console.Write("Codigo Empleado: " + codigo + " | " + "Nombre: " + nombre + " | " + "Categoría: " + categ + " | " + "Nuevo Salario: " + nuevoSueldo);
	break;
	case 4:
	nuevoSueldo = sueldo + sueldo * 0.05;
	Console.Write("Codigo Empleado: " + codigo + " | " + "Nombre: " + nombre + " | " + "Categoría: " + categ + " | " + "Nuevo Salario: " + nuevoSueldo);
	break;
	default:
	Console.Write("Categoria seleccionada incorrecta, favor introduzca la categoria apropiada segun sea el caso: 1, 2, 3 o 4.");
	break;
	}
	}
}

