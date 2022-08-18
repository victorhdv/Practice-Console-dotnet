// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("=====CALCULATOR=====");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Exponentiation");
    Console.WriteLine("6 - Factorial");
    Console.WriteLine("7 - Exit");
    Console.WriteLine("\nHi, select an option to execute!");
    short response = short.Parse(Console.ReadLine());

    switch (response)
    {
        case 1:
            Addition();
            break;
        case 2:
            Subtraction();
            break;
        case 3:
            Multiplication();
            break;
        case 4:
            Division();
            break;
        case 5:
            Exponentiation();
            break;
        case 6:
            Factorial();
            break;
        case 7:
            System.Environment.Exit(0);
            break;
        default:
            Menu();
            break;
    }

}

static void Addition()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 + v2;

    // Console.WriteLine("O result da soma é: " + result);
    Console.WriteLine($"\nO resultado da soma é: {result}");
    Console.ReadKey();
    Menu();
}

static void Subtraction()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 - v2;

    // Console.WriteLine("O result da soma é: " + result);
    Console.WriteLine($"\nO resultado da subtração é: {result}");
    Console.ReadKey();
    Menu();
}

static void Multiplication()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 * v2;

    // Console.WriteLine("O resultado da soma é: " + resultado);
    Console.WriteLine($"\nO resultado da multiplicação é: {result}");
    Console.ReadKey();
    Menu();
}

static void Division()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());
    if (v2 == 0)
    {
        Console.WriteLine("Impossível dividir por zero");
        Console.WriteLine("Informe um valor diferente de zero!");
        Console.ReadKey();
        Menu();
    }
    float result = v1 / v2;

    // Console.WriteLine("O result da soma é: " + result);
    Console.WriteLine($"\nO resultado da divisão é: {result}");
    Console.ReadKey();
    Menu();
}

static void Exponentiation()
{
    Console.Clear();
    Console.WriteLine("Escolha a base: ");
    double bas = double.Parse(Console.ReadLine());
    Console.WriteLine("Escolha a potência: ");
    double potencia = double.Parse(Console.ReadLine());
    if (potencia == 0)
    {
        Console.WriteLine($"\nO result de {bas} elevado à {potencia} é: 1");
        Console.ReadKey();
        Menu();
    }

    double result = bas;
    //double result = Math.Pow(bas, potencia);
    for (int i = 1; i < potencia; i++)
    {
        result *= bas;
    }
    // Console.WriteLine("O result da soma é: " + resultado);
    Console.WriteLine($"\nO resultado de {bas} elevado à {potencia} é: {result}");
    Console.ReadKey();
    Menu();
}

static void Factorial()
{
    Console.Clear();
    Console.WriteLine("Escolha um numero inteiro: ");
    int v1 = int.Parse(Console.ReadLine());
    int result = v1;
    
    //double resultado = Math.Pow(bas, potencia);
    for (int i = (v1-1); i > 0 ; i--)
    {
        result *= i;
    }
    // Console.WriteLine("O result da soma é: " + resultado);
    Console.WriteLine($"\nO resultado de {v1}! é: {result}");
    Console.ReadKey();
    Menu();
}
