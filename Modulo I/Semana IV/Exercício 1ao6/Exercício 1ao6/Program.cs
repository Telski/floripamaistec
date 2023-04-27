using Exercício_1ao6.Classes.enums;
using Exercício_1ao6.Classes;

Cliente pessoaFisica = new Cliente("Cesar Telski", DateTime.Parse("1995-02-28"), "Engenheiro", "Solteiro", TipoPessoaEnum.FISICA);

ContaCorrente contaCorrente = new ContaCorrente(0001, 6546, pessoaFisica);

contaCorrente.Depositar(10000);
contaCorrente.Sacar(2655);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(0001, 6952, pessoaFisica);

contaPoupanca.Depositar(900);
contaPoupanca.Transferir(contaCorrente, 500);
contaPoupanca.ExibirSaldo();

//-------------------------------------//---------------------------------//------------

Cliente pessoaJuridica = new Cliente("Augusto Godoy", DateTime.Parse("1995-02-28"), "Engenheiro", "Solteiro", TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(0001, 5454, pessoaJuridica, 1000000, 5, "06524236000105");

contaJuridica.FazerEmprestimo(80000);
contaJuridica.Depositar(3500);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();
