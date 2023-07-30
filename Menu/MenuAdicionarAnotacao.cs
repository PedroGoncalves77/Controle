namespace ControleDeMaterial.Menu;

internal class MenuAdicionarAnotacao : Menu
{
    public override void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Digite a materia que deseja adicionar a anotação:");
        var nome = Console.ReadLine()!;
        Materiais materiais= new Materiais();
        Materia materia = new Materia();
        materia.Nome = nome;
        materia.Anotacao = materiais.LerAnotacao(nome);
        if (materia.Anotacao.Equals(string.Empty))
        {
            Console.WriteLine("Materia não encontrada!");
            Console.ReadKey();
        }
        else
        {
            materia.AddAnotacao();
            materia.Registrar();
        }

    }
}
