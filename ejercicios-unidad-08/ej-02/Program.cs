using System;
namespace ej_02;

class Program
{
    static void Main(string[] args)
    {
        ProcesarNumeros();
    }
    static int PedirUnNumero()
    {
        Console.WriteLine("Ingrese un numero: ");
        int num1 = int.Parse(Console.ReadLine());
        return num1;
        ///EsPar(int num1);
    }
    static bool EsPar(int num1)
    {
        if (num1 % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void ProcesarNumeros()
    {
        for(int x=0; x<20; x++)
        {
            int num1 = PedirUnNumero();
            string impresion = "¿El numero es par?  " + EsPar(num1);
            Console.WriteLine(impresion);
        }
    }
}

