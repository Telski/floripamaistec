// Início exercício 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1ao6.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        // Inicio exercicio 4
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }
        // continua exercco 4

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            //exe 4 
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;
            // fim exercicio 4

            //PJ
            if (cliente.TipoPessoa != enums.TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Insira um cliente pessoa jurídica");
            }

        } // Fim exercício 3

        public void FazerEmprestimo(decimal valor) // exercicio 05
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor deve ser maior que 0."); return;
            }
            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui emprestímo.");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("Valor para empréstimo indisponível. Tente outro valor.");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo aprovado!!! Valor de R$ {valor} liberado com sucesso!");
        }

        //I exercicio 05
        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if (total > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar pagamento.");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Parabens!!! Você quitou seu empréstimo com o valor de R$ {total}.");
        } //F exercicio 05

        // I exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa saque = 1
            valor += 1;
            base.Sacar(valor);
        }
                
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa transferência = 0,5
            valor += 0.50M;
            base.Transferir(conta, valor);
        } //F exercício 06
    }
}