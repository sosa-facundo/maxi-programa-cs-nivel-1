namespace ej_01;

class Program
{
    static void Main(string[] args)
    {
        SolicitarPrecioYCantidad();
    }
    static void SolicitarPrecioYCantidad()
    {
       Console.WriteLine("Ingrese el precio del producto: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        int b = int.Parse(Console.ReadLine());
        Producto(a, b);
    }
    static void Producto(int num1, int num2)
    {
        Console.WriteLine($"El total de la venta es: {num1 * num2}");
    }
}
