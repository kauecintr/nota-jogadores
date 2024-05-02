
string mensagemBoasVindas = "Seja bem vindo a lista de atacantes do São Paulo FC";
//List<string> jogadores = new List<string> { "Calleri", "André Silva", "Lucas Moura", "Luciano" };

Dictionary<string, List<int>> jogadoresRegistrados = new Dictionary<string, List<int>>();
jogadoresRegistrados.Add("Calleri", new List<int> { 10, 8, 6 });
jogadoresRegistrados.Add("André Silva", new List<int> { 9, 7, 5 });


void ExibirIntro()
{
    Console.WriteLine("Jogadores do São Paulo");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirMenu()
{
    ExibirIntro();
    Console.WriteLine("\nDigite 1 para adicionar jogadores");
    Console.WriteLine("Digite 2 para ver jogadores adicionados");
    Console.WriteLine("Digite 3 para dar nota aos jogadores");
    Console.WriteLine("Digite 4 para ver a média de um jogador");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1:
            AdicionarJogador();
            break;
        case 2:
            ExibirJogadores();
            break;
        case 3:
            AvaliarUmJogador();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Até mais!");
            break;
    }
}

void AdicionarJogador()
{
    Console.Clear();
    ExibirTituloDaOpcao("Adicionar jogador");
    Console.WriteLine("Digite o nome do jogador: ");
    string jogadorAdicionado = Console.ReadLine();
    jogadoresRegistrados.Add(jogadorAdicionado, new List<int>());
    Console.WriteLine($"{jogadorAdicionado} adicionado com sucesso!");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirMenu();
}

void ExibirJogadores()
{
    Console.Clear();
    ExibirTituloDaOpcao("Jogadores adicionados: ");

    foreach(string jogador in jogadoresRegistrados.Keys)
    {
        Console.WriteLine(jogador);
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmJogador()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar um jogador");
    Console.Write("Digite o nome do jogador que deseja avaliar: ");
    string nomeJogador = Console.ReadLine()!;
    if (jogadoresRegistrados.ContainsKey(nomeJogador))
    {
        Console.WriteLine($"\nDigite a nota para o jogador {nomeJogador}: ");
        int nota = int.Parse(Console.ReadLine()!);
        jogadoresRegistrados[nomeJogador].Add(nota);
        Console.WriteLine($"\nNota {nota} adicionada com sucesso para o jogador {nomeJogador}");
        Thread.Sleep(1500);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nO jogador {nomeJogador} não foi encontrado, fdp dos inferno!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média de notas dos jogadores");
    Console.Write("Digite o nome do jogador que deseja ver a média: ");
    string nomeJogador = Console.ReadLine()!;
    if (jogadoresRegistrados.ContainsKey(nomeJogador))
    {
        List<int> notas = jogadoresRegistrados[nomeJogador];
        double media = notas.Average();
        Console.WriteLine($"\nA média de notas do jogador {nomeJogador} é {media}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nO jogador {nomeJogador} não foi encontrado.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu(); 