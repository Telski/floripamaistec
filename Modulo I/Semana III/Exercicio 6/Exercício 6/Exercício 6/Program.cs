using Exercício_6;
using Exercício_6.Entidades;

Produtos produto1 = new Produtos();

produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine("O nome de produto é: " + produto1.nome);

Console.WriteLine("------- Abaixo será valores e ações de uma classe filha");

Produtofinanceiro classefilha = new Produtofinanceiro();

classefilha.nome = "Produto Financeiro";
classefilha.verificarEstoque();

classefilha.acesso();
