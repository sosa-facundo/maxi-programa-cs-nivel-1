using System;
namespace ej_02;
/*Hacer un programa para ingresar un número y luego se emita un cartel por pantalla
 “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero”
  si el número es igual a cero.*/
class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Ingrese un número:");
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            Console.WriteLine("positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("negativo");
        }
        else
        {
            Console.WriteLine("cero");
        }
    }
}
