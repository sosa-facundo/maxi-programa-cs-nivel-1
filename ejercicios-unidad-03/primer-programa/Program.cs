using System;
using System.Globalization;
namespace primer_programa;

class Program
{
    static void Main(string[] args)
    {
        float n1, n2, resultado;
        int opcion;
        while (true)
        {
        Console.WriteLine("- ¡Bienvenido! ingrese un numero: ");
        n1 =float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("menu de opciones: ");
        Console.WriteLine("1- suma ");
        Console.WriteLine("2- resta ");
        Console.WriteLine("3- multiplicacion ");
        Console.WriteLine("4- division ");
        Console.WriteLine("ingrese una opcion: ");
         opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("ingrese otro numero: ");
                n2 =float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                resultado = n1 + n2;
                Console.WriteLine("la suma es: " + resultado);
                break;
            case 2:
                Console.WriteLine("ingrese otro numero: ");
                n2 =float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                resultado = n1 - n2;
                Console.WriteLine("la resta es: " + resultado);
                break;
            case 3:
                Console.WriteLine("ingrese otro numero: ");
                n2 =float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                resultado = n1 * n2;
                Console.WriteLine("la multiplicacion es: " + resultado);        
                break;
            case 4:
                Console.WriteLine("ingrese otro numero: ");
                n2 =float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    Console.WriteLine("la division es: " + resultado);
                }
                else
                {
                    Console.WriteLine("error: division por cero");
                }
                break;
            default:
                Console.WriteLine("opcion invalida");
                break;
        }
        Console.WriteLine("presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        }
    }
}