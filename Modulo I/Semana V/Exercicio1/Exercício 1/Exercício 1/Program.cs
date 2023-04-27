using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 0, num2 = 0;

        while (true)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                double result = num1 / num2;
                Console.WriteLine("O resultado da divisão é: {0}", result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro!");
            }
            finally
            {
                num1 = 0;
                num2 = 0;
            }
        }
    }
}
