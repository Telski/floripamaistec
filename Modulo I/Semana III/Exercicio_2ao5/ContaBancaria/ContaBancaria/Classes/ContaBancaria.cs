// não alterei o valores referente a numeração dos exercícios, como era para simplesmente "copiar e colar" não realizei essa alteração
using Exercicios03ao06.Classes.Enum;
using System;
using System.IO.IsolatedStorage;

namespace Exercicios03ao06.Classes
{
    public class ContaBancaria
    {
        // Resposta Exercício 03
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // Resposta Exercício 02
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }
        // Resposta exercício 04
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random();
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000,9999);
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }
        //respsta 05
        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor deve ser mais que 0!");
                return;
            }
            if(valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            _saldo = _saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Transferência realizada com sucesso! Valor total trasnferido = R$ {valor}");
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}