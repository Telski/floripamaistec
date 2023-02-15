
namespace NumeroPrimoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];

            Console.WriteLine("Digite dez números inteiros: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números primos e suas respectivas posições:");

            for (int i = 0; i < 10; i++)
            {
                if (EPrimo(numero[i]))
                {
                    Console.WriteLine("{0} na posição {1}", numero[i], i);
                }
            }

            Console.ReadLine();
        }

        static bool EPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
