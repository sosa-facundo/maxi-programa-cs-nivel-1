using System;
namespace ej_03;

class Program
{
    static void Main(string[] args)
    {   
        int cantidadNumeros = 0;
        int numero;

        
        Console.WriteLine("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());
        while (true)
        {
            while (numero >0)
                {
                    Console.WriteLine("El número ingresado es: " + numero);
                    cantidadNumeros++;

                    Console.WriteLine("Ingrese otro número (0 para pasar a la otra lista/ numero negativo corta.): ");
                    numero = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("La cantidad de números ingresados es: " + (cantidadNumeros));
            cantidadNumeros = 0;
            if (numero<0)
            {
                Console.WriteLine("El número ingresado es negativo. Gracias, hasta pronto..");
                break;
            }
            Console.WriteLine("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());
        }
    }
}