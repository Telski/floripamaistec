int n; // Variável que armazenará a quantidade de números da sequência de Fibonacci a ser exibida
int x = 1, y = 0, z = 0; // Variáveis que representam os números da sequência de Fibonacci

Console.WriteLine("Quantidade de números calculados pela sequência de Fibonacci?");
string number = Console.ReadLine(); // Recebe a quantidade de números desejados pelo usuário

n = int.Parse(number); // Converte a string recebida para inteiro

Console.WriteLine("A sequência de Fibonacci com " + n + " números é:");
for (int i = 0; i < n; i++)
{
    z = x + y; // // "formula" para realizar o cálculo.
    Console.Write(z + " "); // Exibe o número na tela
    y = x;
    x = z;
}