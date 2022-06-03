Menu();

static void Menu()
{

    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("3 - Leitura por linha do arquivo");
    Console.WriteLine("4 - Apagar um arquivo");
    Console.WriteLine("5 - Copiar um arquivo");
    Console.WriteLine("6 - Mover um arquivo");

    Console.WriteLine("0 - Sair");

    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
            Abrir();
            break;
        case 2:
            Criar();
            break;
        case 3:
            LeituraPorLinha();
            break;
        case 4:
            ApagarArquivo();
            break;
        case 5:
            CopiarArquivo();
            break;    
        case 6:
            MoverArquivo();
            break;  
        default:
            Menu();
            break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");

    string path = Console.ReadLine();
    Console.WriteLine("");
    //using abre e fecha o arquivo
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd(); // Le o texto até o final
        Console.WriteLine(text);


    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();


};

static void Criar()
{

    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
    Console.WriteLine("-----------------");

    /*Ele vai chamar o editor de texto, incluindo os enters*/
    string text = ""; // armarzenar o que o usuário vai digitar

    // O que vamos usar para ler multiplas linhas? Precisamos informar as quebras de linhas

    // se o usuário apertar esc
    // Console.Readkey().key verifica uma tecla, ConsoleKet.Escape seleciona uma tecla
    //Redkey le tecla, key vai ser a tecla, enquanto for diferente da tecla escape ele continua no laço

    do
    {

        text += Console.ReadLine();
        text += Environment.NewLine; // quebrando a linha no fim de cada leitura

    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

static void Salvar(string text)
{


    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");

    var path = Console.ReadLine();
    //Pegar texto e salvar no path

    // Sempre precisamos abrir e fechar arquivos para trabalhar
    // todo objeto criado dentro do using é fechado automaticamente
    // Streamwriter sempre vai pedir um caminbho
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso");
    Console.ReadLine();
    Menu();


}

// usamos o using para abrir e fechar aquivos
// leitura de arquivos com StreamReader - espera caminho
// ReadToEnd
// Como ver os caracteres diferentes e também como sair da execução com o esc
// StreamWriter - espera um caminho - para salvar um arquivo no disco

// Tentar ler linha por linha
// Editor mais customizado
// Colocar funcionalidade no editor

// Adicionadas após o curso

static void LeituraPorLinha()
{


    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");

    string path = Console.ReadLine();
    Console.WriteLine("");

    using (var file = new StreamReader(path))
    {
        string linha = " ";
        while ((linha = file.ReadLine()) != null) //aqui a linha recebe o arquivo e ela vai ler equanto estiver diferente de nulo
        {
            Console.WriteLine(linha);
            Thread.Sleep(500);
        }
    }
    Console.ReadLine();
    Menu();
}

static void ApagarArquivo()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");

    string path = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Qual o nome do arquivo?");

    string nomeArquivo = Console.ReadLine();
    Console.WriteLine("");

    if(File.Exists(Path.Combine(path,nomeArquivo))){

        File.Delete(Path.Combine(path,nomeArquivo));

        Console.WriteLine("Arquivo Deletado!");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("Voltando para o menu...");
        Thread.Sleep(1000);

        Menu();
    }
    else{
        Console.WriteLine("Arquivo não encontrado");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("Voltando para o menu...");
        Thread.Sleep(1000);

        Menu();
    }
 
}

static void CopiarArquivo(){

    Console.Clear();

    Console.WriteLine("Digite o caminho do arquivo que deseja copiar: ");

    string initialPath = Console.ReadLine();
    
    Console.WriteLine("Digite o caminho de destino do arquivo copiado: ");

    string finalPath = Console.ReadLine();

    File.Copy(initialPath, finalPath, true);

    Console.WriteLine("Arquivo copiado com sucesso!");

    Thread.Sleep(1000);

    Menu();
}

static void MoverArquivo(){

    Console.Clear();

    Console.WriteLine("Digite o caminho do arquivo que deseja mover: ");

    string initialPath = Console.ReadLine();
    
    Console.WriteLine("Digite o caminho de destino do arquivo movido: ");

    string finalPath = Console.ReadLine();

    File.Move(initialPath, finalPath);

    Console.WriteLine("Arquivo Movido com sucesso!");

    Thread.Sleep(1000);

    Menu();
}

