using System;
namespace ej_03;

class Program
{
    static void Main(string[] args)
    {
        float kilometros, velocidad,horas;
        
        Console.WriteLine("ingrese los kilometros entre las ciudades:");
        kilometros = float.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese la velocidad promedio del vehiculo (km/h):");
        velocidad =float.Parse(Console.ReadLine()!);
        horas = kilometros / velocidad;
        Console.WriteLine("el tiempo estimado de viaje es de: " + horas + " horas");

    }
}
