using System;
using System.Runtime.CompilerServices;
/*Hacer un programa para ingresar 10 números.
 El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.*/
namespace ej_01;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int contador = 0;
        
        for (int i = 0; i< 10; i++)
        {
            
            Console.WriteLine("Ingrese el numero ["+(i+1)+"/10]");
            numero = int.Parse(Console.ReadLine());
            for (int y = 2; y < numero; y++)
            {
                if (numero % y == 0)
                {
                    contador++;
                }
            }
            if(contador == 0)
            {
                Console.WriteLine("El numero "+numero+" es primo");
                Console.WriteLine("contador: "+contador);
            }
             else
            {
                Console.WriteLine("El numero "+numero+" no es primo");
                    Console.WriteLine("contador: "+contador);
            }
             contador = 0;

        }

    }
}
