using System;
namespace ej_02;
/*Un importante negocio de desinfectante líquido realiza descuentos
 dependiendo de la cantidad de litros vendidos según la siguiente escala:

Si vende menos de 100 litros, no hay descuento.
Si vende entre 101 y 300 litros, el descuento es del 10%.
Si vende entre 301 y 500 litros, el descuento es del 15%.
Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y la 
cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el importe total de litros vendidos:");
        float litros = float.Parse(Console.ReadLine());
        if(litros<100)
        {
            Console.WriteLine("no hay descuento, el importe es: " + litros);
        }
        else if(litros>=101 && litros<=300)
        {
            Console.WriteLine("el importe con descuento es: " + (litros - (litros * 0.10)));
        }
        else if(litros>=301 && litros<=500)
        {
            Console.WriteLine("el importe con descuento es: " + (litros - (litros * 0.15)));
        }
        else
        {
            Console.WriteLine("el importe con descuento es: " + (litros - (litros * 0.25)));
        }
    }
}
