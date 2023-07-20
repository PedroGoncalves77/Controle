namespace ControleDeMaterial.Menu;

internal class MenuAnotacao : Menu
{
    public override void Iniciar()
    {
        Console.Clear();
        Materiais materiais = new();
        Console.WriteLine("Digite o nome da materia que deseja obter a anotação:");
        string p = Console.ReadLine()!;  
        var path = new Paths(p);
        Console.WriteLine(materiais.LerAnotacao(p));
        Console.ReadLine();

    }
    

}
