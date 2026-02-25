namespace ej_04;

class Program
{
    static void Main(string[] args)
    {
        char letraRef=' ';
        int numero;
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        PositivoNegativoCero(numero, ref letraRef);

        Console.WriteLine(letraRef);
    }
    static void PositivoNegativoCero(int numero, ref char letraRef)
    {
        if (numero>0)
        {
            letraRef ='a';
        }
        if (numero<0)
        {
            letraRef ='b';
        }
        if (numero==0)
        {
            letraRef ='c';
        }
    }
}
