namespace ControleDeMaterial.Menu;

internal class MenuMaterias  : Menu
{
    public override void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("Lista de todas as materias:");
        Materiais materiais = new();
        var materias = materiais.Materias().Values;
        foreach(var m in materias) 
        {
            foreach (var v in m.Distinct()) 
            {
                Console.WriteLine(v);
                Console.WriteLine("----------------");
            }
        }
        Console.ReadKey();

    }
}
