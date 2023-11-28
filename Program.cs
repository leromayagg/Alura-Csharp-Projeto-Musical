string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
List<string> listaDeBandas = new List<string>{};

void ExibirLogo(){

    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu(){

    ExibirLogo();
    Console.WriteLine("\n1 - Registrar banda");
    Console.WriteLine("2 - Ver todas bandas");
    Console.WriteLine("3 - Avaliar banda");
    Console.WriteLine("4 - Média da banda");
    Console.WriteLine("0 - Sair\n");

    Console.Write("\n Digite a opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // o ! é para indica ao compilador que você está garantindo explicitamente que o resultado não será nulo (null)
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica){
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
};

void RegistrarBanda(){

    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"\n A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);// Esse codigo faz com que o usuario aguarde 2 segundos
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

};

void MostrarBandasRegistradas(){

    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("**********************************************\n");

    // for (int i = 0; i < listaDeBandas.Count; i++)
    // {

    //     Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nAperte uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

};

ExibirLogo();
ExibirOpcoesDoMenu();