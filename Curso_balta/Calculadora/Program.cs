// See https://aka.ms/new-console-template for more information

// Posso usar por conta do system


// método main

Calculadora();

static void Calculadora()
{

    Console.Clear();
    Console.WriteLine("Qual calculadora deseja utilizar?");

    Console.WriteLine("1 - Normal");
    Console.WriteLine("2 - Moeda");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("-----------------");
    int escolhaCalculadora = int.Parse(Console.ReadLine());

    switch (escolhaCalculadora)
    {
        case 1: calcNormal(); break;
        case 2: calcMoeda(); break;
        case 3: System.Environment.Exit(0);
            break;
        default: Calculadora(); break;

    }


}

/* CALCULADORA CONVERSÃO MOEDA*/

//Menu
static void calcMoeda()
{

    Console.Clear();
    Console.WriteLine("Escolha a primeira moeda");
    Console.WriteLine("1- Real");
    Console.WriteLine("2- Dolar");
    Console.WriteLine("3- Euro");
    Console.WriteLine("4- Voltar");

    Console.WriteLine("---------------");


    int escolhaMoeda1 = int.Parse(Console.ReadLine());
    int escolhaMoeda2;

    if (escolhaMoeda1 == 1)
    {
        Console.Clear();
        Console.WriteLine("---------------");
        Console.WriteLine("Escolha a segunda moeda");
        Console.WriteLine("1- Dolar");
        Console.WriteLine("2- Euro");
        Console.WriteLine("---------------");
        escolhaMoeda2 = int.Parse(Console.ReadLine());

        if (escolhaMoeda2 == 1)
        {

            RealDolar();
        }
        else
        {

            RealEuro();
        }
    }
    else if (escolhaMoeda1 == 2)
    {
        Console.Clear();
        Console.WriteLine("---------------");
        Console.WriteLine("Escolha a segunda moeda");
        Console.WriteLine("1- Real");
        Console.WriteLine("2- Euro");
        Console.WriteLine("---------------");

        escolhaMoeda2 = int.Parse(Console.ReadLine());
        if (escolhaMoeda2 == 1)
        {

            DolarReal();
        }
        else
        {

            DolarEuro();
        }
    }
    else if (escolhaMoeda1 == 3)
    {
        Console.Clear();
        Console.WriteLine("---------------");
        Console.WriteLine("Escolha a segunda moeda");
        Console.WriteLine("1- Real");
        Console.WriteLine("2- Dolar");
        Console.WriteLine("---------------");

        escolhaMoeda2 = int.Parse(Console.ReadLine());
        if (escolhaMoeda2 == 1)
        {

            EuroReal();
        }
        else
        {

            EuroDolar();
        }
    }

    else
    {
        Calculadora();
    }


}
// Real para dolar
static void RealDolar()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em real para saber quantos doláres são: ");
    double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double dolar = 4.80;

    double conversao = real / dolar;

    Console.WriteLine("Você tem " + conversao.ToString("F2",CultureInfo.InvariantCulture) + "dólares");

    Console.ReadKey();
    calcMoeda();

}
// Dolar para real
static void DolarReal()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em dolar para saber quantos reais são: ");
    double dolarentrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double dolarcot = 4.80;

    double real = dolarentrada * dolarcot;

    Console.WriteLine("Você tem " + real.ToString("F2", CultureInfo.InvariantCulture) + "reais");
    Console.ReadKey();
    calcMoeda();

}
// Euro para dolar
static void EuroDolar()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em euro para saber quantos doláres são: ");
    double euroEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double dolar = euroEntrada / 0.94;

    Console.WriteLine("Você tem " + dolar.ToString("F2", CultureInfo.InvariantCulture) + " dolares");


    Console.ReadKey();
    calcMoeda();
}
// Dolar para euro
static void DolarEuro()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em dolar para saber quantos euro são: ");

    double dolarEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double euro = dolarEntrada * 0.94;

    Console.WriteLine($"Você tem " + euro.ToString("F2", CultureInfo.InvariantCulture) + " euros");


    Console.ReadKey();
    calcMoeda();
}
// Euro para real
static void EuroReal()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em euro para saber quantos reais são: ");


    double euroEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double eurocot = 5.14;

    double real = euroEntrada * eurocot;

    Console.WriteLine("Você tem" + real.ToString("F2",CultureInfo.InvariantCulture) + " reais");
    Console.ReadKey();
    calcMoeda();
}
// Real para euro
static void RealEuro()
{

    Console.Clear();

    Console.WriteLine("Digite o valor em real para saber quantos euros são: ");
    double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double euro = 5.14;

    double conversao = real / euro;

    Console.WriteLine($"Você tem " + conversao.ToString("F2", CultureInfo.InvariantCulture) + " euros");
    Console.ReadKey();
    calcMoeda();
}




/*CALCULADORA NORMAL*/

// Menu
static void calcNormal()
{
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Raiz quadrada");
        Console.WriteLine("6 - Potencialização");
        Console.WriteLine("7 - Voltar");
        Console.WriteLine("-----------------");
        Console.WriteLine("Selecione uma opção: ");
        short valorSelecionado = short.Parse(Console.ReadLine());
        Console.WriteLine("");

        switch (valorSelecionado)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Divisao();
                break;
            case 4:
                Multiplicacao();
                break;
            case 5:
                RaizQuadrada();
                break;
            case 6:
                Potencia();
                break;
            case 7:
                Calculadora();
                break;
            default:
                calcNormal();
                break;
        }
    }

}

//void n retorna nada
static void Soma()

{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double resultado = valor1 + valor2;
    Console.WriteLine("");

    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
    calcNormal();
}

// void n retorna nada
static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("");

    double resultado = valor1 - valor2;

    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();

    calcNormal();
}

// divisão
static void Divisao()
{

    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double resultado;

    if (valor2 != 0)
    {
        resultado = valor1 / valor2;

        Console.WriteLine("");

        Console.WriteLine($"O resultado da divisao é {resultado}");

        Console.ReadKey();
        Console.ReadKey();
        calcNormal();


    }

    else
    {
        Console.WriteLine("Operação incorreta");
        Console.ReadKey();
        calcNormal();


    }

}

// multiplicacao
static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite o segundo valor");
    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double resultado = valor1 * valor2;
    Console.WriteLine("");

    Console.WriteLine($"O resultado é {resultado}");
    Console.ReadKey();

    calcNormal();

}

// Raiz quadrada
static void RaizQuadrada()
{

    Console.Clear();

    Console.WriteLine("Digite um valor que deseja saber a raiz: ");
    int raiz = int.Parse(Console.ReadLine());

    double raizQuadrada = Math.Sqrt(raiz);

    Console.WriteLine($"A raiz quadrada de {raiz} é: {raizQuadrada}");

    Console.ReadKey();
    calcNormal();

}

// Potenciação
static void Potencia()
{
    Console.Clear();

    Console.WriteLine("Digite um valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual a potencia que deseja elevar o número?");
    int valor2 = int.Parse(Console.ReadLine());

    double potencia = Math.Pow(valor1, valor2);

    Console.WriteLine($"{valor1} na potencia de {valor2} é: {potencia}");

    Console.ReadKey();
    calcNormal();
}
