namespace ControleDeMaterial.Menu;

internal class MenuMaterias 
{
    public void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("Lista de todas as materias:");
        Materiais materiais = new();
        foreach(var m in materiais.Materias()) 
        {
            foreach (var v in m.Value) 
            {
                Console.WriteLine(v);
            }
        }
        Console.ReadKey();

    }
}
