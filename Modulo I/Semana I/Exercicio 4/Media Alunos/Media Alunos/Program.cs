// Declarando arrays para armazenar nomes e médias dos alunos
string[] nomeAluno = new string[5];
decimal[] mediaAluno = new decimal[5];

// Lendo nomes e médias de cada aluno
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o nome do aluno " + (i + 1) + ":");
    nomeAluno[i] = Console.ReadLine();

    Console.WriteLine("Informe a média do aluno " + (i + 1) + ":");
    mediaAluno[i] = decimal.Parse(Console.ReadLine());
}

// Exibindo resultado para cada aluno
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Aluno: " + nomeAluno[i]);
    if (mediaAluno[i] > 6)
    {
        Console.WriteLine("APROVADO");
    }
    else
    {
        Console.WriteLine("REPROVADO");
    }
}