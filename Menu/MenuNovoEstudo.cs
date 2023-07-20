namespace ControleDeMaterial.Menu;

internal class MenuNovoEstudo : Menu
{
    public override void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("1 - Para uma materia ja existente.");
        Console.WriteLine("2 - Para fazer novas anotações.");
        var escolha = Console.ReadLine();
        switch (escolha) 
        {
            case "1" :
                Existente();break;
            case "2" : Novo(new Materia());break;
        }
    }
    public void Existente() 
    {   Console.Clear();
        Materia materia = new();
        Materiais materiais = new();
        Console.WriteLine("Digite o nome da materia:");
        string mat = Console.ReadLine()!;
       foreach (var m in materiais.Materias().Values) 
        {
            if (m.Contains(mat))
            {
                var path = new Paths(mat);
                materia.Nome = mat;
                materia.Anotacao = materiais.LerAnotacao(path.pathAnotacoes);
                break;

            }
           
        }
    }
    public void Novo(Materia materia) 
    {
        Console.Clear();
        Console.WriteLine("Estudo iniciado.");
        Console.WriteLine("'A' para fazer uma anotação.");
        Console.WriteLine("'Q' para finalizar.");
        string escolha = Console.ReadLine()!;
        switch (escolha.ToLower())
        {
            case "a":
                materia.AddAnotacao();
                Novo(materia); break;
            case "q": Finalizar(materia);break;
            default : Novo(materia);break;
        }
    } 
    public void Finalizar(Materia materia) 
        {
        Console.WriteLine("Digite o numero de dias até a proxima revisão:");
        string dias = Console.ReadLine()!;
        if (int.TryParse(dias, out int d))
        {
            materia.Revisar.ProximaRevisao(d);
            Console.WriteLine("Agendamento confirmado.");
        }
        else { Console.WriteLine("formato inválido!");
            Finalizar(materia);
        }
        var path = new Paths(materia.Nome);
        Salvar.Registrar(path.pathAnotacoes, materia.Anotacao);
        Salvar.Finalizar(materia);
        

    }

}
