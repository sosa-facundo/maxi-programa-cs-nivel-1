namespace ej_03;
/*Una casa de video juegos otorga un descuento dependiendo del importe
 de la compra realizada según los siguientes valores:

Si el importe es menor a ARS 1000, no hay descuento.
Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
Si el importe es ARS 5000 o más, aplica un descuento del 18%.
Hacer un programa para ingresar un importe de venta y luego muestre por pantalla
 el importe final con el descuento que corresponda.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el importe de la compra: ");
        float importe = float.Parse(Console.ReadLine());
        float descuento = 0;
        if (importe >= 5000)
        {
            descuento = importe * 0.18f;
        }
        else if (importe >= 1000)
        {
            descuento = importe * 0.1f;
        }
        Console.WriteLine("el importe final con el descuento es: " + (importe - descuento));
    }
}
