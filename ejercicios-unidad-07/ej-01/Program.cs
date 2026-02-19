using System;
namespace ej_01;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int[] vNumeros = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            
            Console.WriteLine("ingrese [" +(i+1)+"/10] numeros enteros");
            numero = int.Parse(Console.ReadLine());
            vNumeros[i] = numero;
        }
        int maximo=vNumeros[0];
        int posicion=0;

        for (int i=1 ;i<10; i++)
        {
            if(vNumeros[i]>maximo)
            {
                maximo=vNumeros[i];
                posicion=i;
            }
        }
        Console.WriteLine("El maximo es: "+maximo+" y su posicion es: "+(posicion+1));
    }
}
