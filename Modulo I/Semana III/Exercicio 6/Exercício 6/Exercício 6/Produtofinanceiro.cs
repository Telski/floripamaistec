using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_6.Entidades;

namespace Exercício_6
{
    internal class Produtofinanceiro : Produtos
    {
        public void acesso() 
        {
            Produtofinanceiro PF1 = new Produtofinanceiro();
            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "Verde";
            Console.WriteLine("Nome: " + PF1.nome + "Cor"+ PF1.cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alterarAtributosPrivados(99, 100.0);
        }
    }
}
