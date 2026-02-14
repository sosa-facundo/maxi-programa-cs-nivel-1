using System;
namespace ej_04;
/*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.*/
class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3;
        Console.WriteLine("Ingrese el primer numero:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero:");    
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero:");
        n3 = int.Parse(Console.ReadLine());
        if(n1+n2 > n2*n3)
        {
            Console.WriteLine("La suma del primer y segundo numero es mayor al producto del segundo y tercer numero.");
        }
        else
        {
            Console.WriteLine("La suma del primer y segundo numero NO es mayor al producto del segundo y tercer numero.");
        }
    }
}
