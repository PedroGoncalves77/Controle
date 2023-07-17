namespace ControleDeMaterial;

internal class Materia
{
    public string  Nome { get; set; }
    public string  Anotacao { get; set; }
    public Revisao Revisar  { get; set; }

    public void AddAnotacao() 
    {
        Console.Clear();
        Console.WriteLine("***********");
        Console.WriteLine("Anote aqui:");
        Console.WriteLine("***********");
        Console.WriteLine("'ESC' - Sair");
        string a = String.Empty;
        do 
        {
            a = Console.ReadLine()!;
            a += Environment.NewLine;
            Anotacao += a;
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

    }
}
