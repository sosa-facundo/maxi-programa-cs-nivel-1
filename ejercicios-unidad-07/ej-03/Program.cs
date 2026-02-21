namespace ej_03;

class Program
{
    static void Main(string[] args)
    {
        char letra;
        char letra2;
        char[] letras = new char[10];
        Console.WriteLine("escribe un texto de 10 caracteres");
        for (int i=0; i<10; i++)
        {
            Console.Write("Ingrese el carácter {0}: ", i + 1);
            letra = char.Parse(Console.ReadLine());
            letras[i] = letra;
        }
        for (int i=0; i<10; i++)
        {
            Console.WriteLine("El carácter {0} es: {1}", i + 1, letras[i]);
        }
    }
}