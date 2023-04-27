//exercicio 3 início
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1ao6.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            //PF
            if (cliente.TipoPessoa != enums.TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Insira um cliente pessoa física");
            }

        }

    }
}// exercicio 3 fim