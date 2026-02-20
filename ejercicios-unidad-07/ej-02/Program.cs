namespace ej_02;

class Program
{
    static void Main(string[] args)
    {   
        int numero;
        int[] numeros = new int[10];
        float promedio=0;
        Console.WriteLine("ingrese 10 numeros enteros");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número {0}: ", i + 1);
            numero = int.Parse(Console.ReadLine());
            numeros[i] = numero;
        }
        for (int i=0; i <10;i++)
        {
            promedio += numeros[i];
        }
        promedio /= 10;
        Console.WriteLine("El promedio es: {0}", promedio);
        for (int i=0; i <10;i++)
        {
            if (numeros[i] > promedio)
            {
                Console.WriteLine("El numero {0} es mayor al promedio", numeros[i]);
            }
        }
    }
}
