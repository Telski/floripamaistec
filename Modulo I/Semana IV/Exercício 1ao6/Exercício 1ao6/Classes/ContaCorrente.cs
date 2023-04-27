// exercicio 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1ao6.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero,agencia, cliente) 
        {
            //PF
            if (cliente.TipoPessoa != enums.TipoPessoaEnum.FISICA) 
            {
                throw new ArgumentException("Insira um cliente pessoa física");
            }

        }


    }
}
