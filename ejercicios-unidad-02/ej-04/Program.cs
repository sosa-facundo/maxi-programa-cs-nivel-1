using System;   
namespace ej_04;
/*Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5%
 sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un
  empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/
class Program
{
    static void Main(string[] args)
    {
        float sueldoFijo = 15000f;
        float comision = 0.05f;
        float totalFacturado ;
        float sueldoTotal ;

        Console.WriteLine("ingrese el total facturado por el empleado:");
        totalFacturado = float.Parse(Console.ReadLine()!);
        sueldoTotal = sueldoFijo + (totalFacturado * comision);
        Console.WriteLine("el sueldo total a cobrar es de: " + sueldoTotal + " ARS");
    }
}