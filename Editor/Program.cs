using System.IO;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que voce deseja fazer?");
    Console.WriteLine("1 - Criar novo arquivo");
    Console.WriteLine("2 - Abrir aquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
            Create();
            break;
        case 2:
            Open();
            break;
        default:
            Menu();
            break;
    }

}

static void Create()
{
    Console.Clear();
    Console.WriteLine("Digite seu Texto abaixo (ESC para sair)\n====================================");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);

}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("\n Qual caminho para salvar arquivo?");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo?");
    string path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}
