using System;
namespace ej_02;
/*Hacer un programa que solicite el ingreso de 10 números y
 que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 10 números:");
        int mayor = int.MinValue; // Inicializamos el mayor con el valor mínimo posible
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > mayor)
            {
                mayor = numero; // Actualizamos el mayor si el número ingresado es mayor
            }
        }
        Console.WriteLine($"El mayor número ingresado es: {mayor}");
    }
}
