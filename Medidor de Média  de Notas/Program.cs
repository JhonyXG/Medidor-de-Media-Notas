using System;


Dictionary<string, List<int>> AlunosNotas = new Dictionary<string, List<int>>();
exibirMenu();
exibirNota();
calcularMedia();

void exibirMenu()
{
    Console.WriteLine(@"

                            Seja Bem Vindo ao 

███╗░░░███╗███████╗██████╗░██╗██████╗░░█████╗░██████╗░  ██████╗░███████╗
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░██║██║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
██║░╚═╝░██║███████╗██████╔╝██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

███╗░░░███╗███████╗██████╗░██╗░█████╗░  ██████╗░███████╗  ███╗░░██╗░█████╗░████████╗░█████╗░░██████╗
████╗░████║██╔════╝██╔══██╗██║██╔══██╗  ██╔══██╗██╔════╝  ████╗░██║██╔══██╗╚══██╔══╝██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░██║██║███████║  ██║░░██║█████╗░░  ██╔██╗██║██║░░██║░░░██║░░░███████║╚█████╗░
██║╚██╔╝██║██╔══╝░░██║░░██║██║██╔══██║  ██║░░██║██╔══╝░░  ██║╚████║██║░░██║░░░██║░░░██╔══██║░╚═══
██║░╚═╝░██║███████╗██████╔╝██║██║░░██║  ██████╔╝███████╗  ██║░╚███║╚█████╔╝░░░██║░░░██║░░██║██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝  ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░ ");

    Thread.Sleep(4000);

    Console.Clear();
    Console.WriteLine("\n Digite o nome do aluno: ");
    string nome = Console.ReadLine();
    AlunosNotas.Add(nome, new List<int>());
    
    
    Console.WriteLine(" \nDigite a primeira nota do aluno: ");
    int nota1 = int.Parse(Console.ReadLine());
    AlunosNotas[nome].Add(nota1);

    Console.WriteLine(" \nDigite a segunda nota do aluno: ");
    int nota2 = int.Parse(Console.ReadLine());
    AlunosNotas[nome].Add(nota2);

    Console.WriteLine(" \nDigite a terceira nota do aluno: ");
    int nota3 = int.Parse(Console.ReadLine());
    AlunosNotas[nome].Add(nota3);





}
void exibirNota()
{
    Console.Clear();
    foreach (var aluno in AlunosNotas)
    {
        Console.WriteLine($"Aluno: {aluno.Key}, e as notas foram: {string.Join(",", aluno.Value)}");
    }
}

void calcularMedia()
{
    Console.Clear();
    Console.WriteLine("Calculando a média do aluno...\n");
    Thread.Sleep(2000);
    foreach (var aluno in AlunosNotas)
    {
        int soma = aluno.Value.Sum();
       int media = soma / aluno.Value.Count;
        Console.WriteLine($"a media do aluno {aluno.Key} é de: {media}");
    }
}