namespace ej_04;

class Program
{
    static void Main(string[] args)
    {
        int numeroArticulo = 0;
        int[] cantidadVendida = new int[15];
        int mayorCantidadVendida = 0;
        int numeroArticuloMayorVendida = 0;
        Console.WriteLine("Ingrese el número del artículo (0 para finalizar): ");
        numeroArticulo = int.Parse(Console.ReadLine());
        while(numeroArticulo!=0)
        {
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida[numeroArticulo-1] += int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número del artículo (0 para finalizar): ");
            numeroArticulo = int.Parse(Console.ReadLine());
        }

        mayorCantidadVendida=cantidadVendida[0];
        numeroArticuloMayorVendida=1;
        for (int i=1; i<15; i++)
        {
            if (cantidadVendida[i]>mayorCantidadVendida)
            {
                mayorCantidadVendida=cantidadVendida[i];
                numeroArticuloMayorVendida=i+1;
            }
        }
        Console.WriteLine($"El artículo con mayor cantidad vendida es el número {numeroArticuloMayorVendida} con {mayorCantidadVendida} unidades vendidas"); 
        
        for(int i=0; i<15; i++)
        {
            if (cantidadVendida[i]==0)
            Console.WriteLine($"El artículo {i+1} tiene: {cantidadVendida[i]} unidades vendidas");
        }

        Console.WriteLine($"El artículo 10 tiene: {cantidadVendida[9]} unidades vendidas");
        
    }
}