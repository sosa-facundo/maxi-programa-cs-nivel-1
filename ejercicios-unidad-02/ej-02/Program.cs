using System;
namespace ej_02;

class Program
{
    static void Main(string[] args)
    {
        int numero, cubo;
        Console.WriteLine("ingrese un numero para elevar al cubo:");
        numero=int.Parse(Console.ReadLine());
        cubo=numero*numero*numero;
        Console.WriteLine("el resultado de elevar "+numero+" al cubo es: " + cubo);    
    }
}
