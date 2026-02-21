namespace ej_03;

class Program
{
    static void Main(string[] args)
    {
        const int TAM = 10;
        char Caracter1='a';
        char Caracter2='i';
        char[] CadenaFuente = new char[TAM];
        Console.WriteLine("escribe un texto de 10 caracteres");
        for (int i=0; i<TAM; i++)
        {
            Console.Write("Ingrese el carácter {0}: ", i + 1);
            CadenaFuente[i] = char.Parse(Console.ReadLine());
        }
        for (int i=0; i<TAM; i++)
        {
            Console.WriteLine("El carácter {0} es: {1}", i + 1, CadenaFuente[i]);
        }
        for (int i=0; i<TAM; i++)
        {
            if(CadenaFuente[i]==Caracter1)
            {
                CadenaFuente[i]=Caracter2;
            }
        }
        for (int i=0; i<TAM; i++)
        {
            Console.WriteLine("El carácter {0} es: {1}", i + 1, CadenaFuente[i]);
        }
    }
}