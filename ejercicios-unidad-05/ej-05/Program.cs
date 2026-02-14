using System;

namespace ej_05;

class Program
{
    static void Main(string[] args)
    {
        int maximo = int.MinValue;
        int minimo = int.MaxValue;
        int numero=0;
        for (int i=0; i<5; i++)
        {
            Console.WriteLine("ingresar el numero"+(i+1)+"/20:");
            numero = int.Parse(Console.ReadLine());
            if (numero > maximo)
            {
                maximo = numero;
            }
            if (numero < minimo)
            {
                minimo = numero;
            }
        }
        Console.WriteLine("el numero maximo es: " + maximo);
        Console.WriteLine("el numero minimo es: " + minimo);
    }
}
