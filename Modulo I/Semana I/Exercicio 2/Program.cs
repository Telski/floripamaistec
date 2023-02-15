List<string> listaDeFrutas = new List<string>();
bool continuar = true;
while (continuar)
{
    if (listaDeFrutas.Count == 15)
    {
        continuar = false;
    }
    Console.Write("Digite o nome de uma fruta: ");
    listaDeFrutas.Add(Console.ReadLine());
    Console.Write("Deseja continuar? Responda [s] para sim ou [n] para não: ");
    string resposta = Console.ReadLine();
    if (resposta.ToLower() == "n" || resposta.ToLower() == "nao")
    {
        continuar = false;
    }
}
listaDeFrutas.Sort();
Console.WriteLine("Lista de frutas em ordem alfabética:");
foreach (string fruta in listaDeFrutas)
{
    Console.WriteLine(fruta);
}
Console.ReadLine();