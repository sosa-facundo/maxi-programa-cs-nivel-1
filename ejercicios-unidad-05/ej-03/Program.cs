using System;
    
namespace ej_03;

class Program
{
    static void Main(string[] args)
    {
        
        int edad;
        int sumaEdades = 0;
         int contador=0;
        Console.WriteLine("Ingrese 20 edades:");
        for (int i = 0; i < 20; i++)
        {
            edad = int.Parse(Console.ReadLine());
            if(edad > 18)
            {
                contador++;
                sumaEdades += edad;
            }
        }
        Console.WriteLine($"El promedio de las edades es: "+ (sumaEdades/contador));
    }
}