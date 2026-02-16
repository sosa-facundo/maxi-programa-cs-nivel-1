using System;
namespace ej_03;

class Program
{
    static void Main(string[] args)
    {   
        int lista = 1;
        Console.WriteLine("ingresar una lista de numeros, finalizar con 0. Lista " + lista + ":");
        int numero = int.Parse(Console.ReadLine());
        int contador = 0;
        while (numero >= 0)
        {
    
            while (numero != 0 && numero >0)
            {
                contador++;
                Console.WriteLine("ingresar otro numero de la lista " +lista+":");
                numero = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("la cantidad de numeros ingresados es: " + contador);
            contador=0;
            lista++;
            Console.WriteLine("ingresar otro numero de la lista " +lista+":");
                numero = int.Parse(Console.ReadLine()); 
        }
    }
}
