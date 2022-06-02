
/* Função para iniciar o programa */


Menu();

static void Menu (){

    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 1m = 1 minuto");
    Console.WriteLine("H = Minuto => 1h = 1 minuto");

    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
    // pegar só s ou 1, tem que isolar o tempo do tipo
    string data = Console.ReadLine().ToLower();

    Console.WriteLine(data);
    // uso chamado substring, pega parte da cadeia de caractere, valor inicial e ultima parte
    // banana (1,1) vai na posição 1 e pega 1, um caractere e o ultimo
    // no caso abaixo ele ve quntas posições tem a string, subtrai um e a partir do penultimo ele conta 1
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    // todos os caracteres menos o ultimo
    int time = int.Parse(data.Substring(0, data.Length - 1 ));
    
    // Console.WriteLine(type);
    // Console.WriteLine(time);

    // base sempre vai ser segundos e o que muda é o multiplicador

    int multiplier;

    if(type == 'h'){
        multiplier = 3600;
    }
    else if (type == 'm'){
        multiplier = 60;
    }
    else{
        multiplier = 1;
    }

    if(time == 0){
        System.Environment.Exit(0); //p sair do sistema
    }
    // conversão implicita
    PreStart(time * multiplier);

}

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);
}

static void Start(int time)
{
    
    for (int currentTime = time; currentTime != 0; currentTime--){
        Console.Clear();
        Console.Write($"{currentTime}");
        
        Thread.Sleep(1000);//timeout
        }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500); // ele da um tempo
    Menu(); // p voltar para o menu

   
    }

