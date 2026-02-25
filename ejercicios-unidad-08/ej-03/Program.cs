namespace ej_03;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int contador = 0;
        int numerosPrimos = 0;
        Console.WriteLine("Ingrese un numero: ");
        numero= int.Parse(Console.ReadLine());
        while(numero !=0)
        {
            string resultado = EsPrimo(numero, ref contador, ref numerosPrimos) ? "es primo" : "no es primo";
            Console.WriteLine(resultado);
            
            Console.WriteLine("Ingrese un numero: ");
            numero= int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Cantidad de numeros primos ingresados: {contador} y la suma de los numeros primos ingresados es: {numerosPrimos}");
        int resultadoFinal= numerosPrimos/contador;
        Console.WriteLine($"Promedio de numeros primos ingresados: {resultadoFinal}");
    }
    static bool EsPrimo(int numero, ref int contadorMain, ref int numeroPrimos)
    {
        int contador = 0;
        for(int i=2; i<numero; i++)
        {
            if(numero%i == 0)
            {
                contador++;
            }
        }
        if (contador == 0)
        {
            contadorMain++;
            numeroPrimos = numeroPrimos + numero;
            return true;
        }
        else
        {
            return false;
        }
    }
}
