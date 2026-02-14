using System;
namespace ej_02;
/*Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
 Se pide determinar e informar:
El número de grupo con mayor porcentaje de números impares respecto al total de números
 que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/
class Program
{
    static void Main(string[] args)
    {
        ///una lista de 5 listas de numeros enteros separados entre ellos por ceros
        int numero;
        for(int x = 0; x < 5; x++)
        {   
            Console.WriteLine("Ingrese un numero entero (0 para finalizar el grupo): ");
            numero = int.Parse(Console.ReadLine());
            while(numero != 0)
            {
                Console.WriteLine("Ingrese un numero entero (0 para finalizar el grupo): ");
                numero = int.Parse(Console.ReadLine());
            }   
        }
    }
}
