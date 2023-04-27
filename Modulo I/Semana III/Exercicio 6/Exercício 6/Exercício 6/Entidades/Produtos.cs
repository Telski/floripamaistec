using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_6;

namespace Exercício_6.Entidades
{
    internal class Produtos
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produtos(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produtos()
        {
        }

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe Produtos ");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acesando método vender da classe Produtos");
        }
        private void descartar()
        {
            Console.WriteLine("Descartando o produto");
        }

        protected void alterarAtributosPrivados(double peso2, double preco) 
        {
            peso = peso2;
            Console.WriteLine("Varíavel peso de escopo da classe: " + peso);

        }
       protected internal void teste()
        { Console.WriteLine("Acessado"); 
        }
        

    }
}
