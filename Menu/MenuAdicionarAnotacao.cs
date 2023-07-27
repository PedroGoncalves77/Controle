namespace ControleDeMaterial.Menu;

internal class MenuAdicionarAnotacao : Menu
{
    public override void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Digite a materia que deseja adicionar a anotação:");
        var path = Console.ReadLine()!;
        Materiais materiais= new Materiais();
        var p = new Paths(path);
        Materia materia = new Materia();
        materia.Nome = path;
        materia.Anotacao = materiais.LerAnotacao(path).ToString()!;
        Console.WriteLine(materia.Anotacao);
        materia.AddAnotacao();
        Salvar.Registrar(path, materia.Anotacao);
        
    }
}
