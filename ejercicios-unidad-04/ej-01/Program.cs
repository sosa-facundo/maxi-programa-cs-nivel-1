using System;   
namespace ej_01;
/* Hacer un programa que solicite el ingreso de dos números y luego calcular:

La resta si el primero es mayor que el segundo.
La suma si son iguales.
El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.*/
class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;   
        Console.WriteLine("ingrese el primer numero:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero:");
        num2 = int.Parse(Console.ReadLine());
        if (num1>num2)
        {
            Console.WriteLine("la resta es: " + (num1 - num2));
        }
        else if (num1==num2)
        {
            Console.WriteLine("la suma es: " + (num1 + num2));
        }
        else
        {
            Console.WriteLine("el producto es: " + (num1 * num2));
        }
    }
}
