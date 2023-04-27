using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Classes_e_Construtor.Models;

namespace Classes_e_Construtor.Programs
{
    class Program
    {
        static void Main()
        {
            Produto produto1 = new Produto("Notebook", 1500.00, 5);
            Produto produto2 = new Produto();

            Console.WriteLine("Produto 1:");
            Console.WriteLine("Nome: " + produto1.Nome);
            Console.WriteLine("Preço: " + produto1.Preco);
            Console.WriteLine("Quantidade: " + produto1.Quantidade);

            Console.WriteLine("\nProduto 2:");
            Console.WriteLine("Nome: " + produto2.Nome);
            Console.WriteLine("Preço: " + produto2.Preco);
            Console.WriteLine("Quantidade: " + produto2.Quantidade);
        }
    }
}
