using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_1ao6.Classes.enums;

namespace Exercício_1ao6.Classes
{

    // respt 2
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0;
            Cliente = cliente;
        }
        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");
                return;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar a transação");
                return;
            }
            Saldo -=  valor; // alterei de   Saldo = Saldo - valor; para Saldo -= valor
            conta.Depositar(valor);

            Console.WriteLine($"Transferência realizada com sucesso! Valor da transferência: {valor}");
        }
        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Insira um valor maior que zero");   
                return;
            }
            else
            {
                Saldo += valor; // alterei de Saldo = Saldo + valor; para Saldo += valor 
            }
            Console.WriteLine($"R$ {valor} depositado com sucesso");
        }
       public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");
                return;
                            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Valor solicitado é maior que o saldo em sua conta. Insira um valor menor ou igual ao seu saldo. ");
                return;
            }
            else
            {
                Saldo -= valor; // alterei de (Saldo = Saldo - valor;); para Saldo -= valor 
            }

            Console.WriteLine($"Saque realizado com sucesso! Valor de R$ {valor}. Você possui agora em sua conta um total de R$ {Saldo - valor} ");
        }

        public virtual void ExibirSaldo()
            {
                Console.WriteLine($"O saldo de sua conta é de R$ {Saldo}");
            }
    }
}
        