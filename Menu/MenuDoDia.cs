namespace ControleDeMaterial.Menu;

internal class MenuDoDia
{
    public void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Bem Vindo!");
        Console.WriteLine("\nMateria a ser revisada hoje: ");
        Materiais materiais = new Materiais();
        foreach (var m in materiais.MateriaDoDia()) 
        {
            if(m != null)
            Console.WriteLine(m);
            else
            Console.WriteLine("Dia livre!");
        }
        Console.WriteLine("\n1 - INICIAR.");
        Console.WriteLine("0 - SAIR.");
        Console.ReadLine();
    }
}
