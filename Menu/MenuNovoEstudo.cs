namespace ControleDeMaterial.Menu;

internal class MenuNovoEstudo : Menu
{
    public override void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("1 - Para uma materia existente.");
        Console.WriteLine("2 - Para nova anotação.");
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
        foreach(var m in materiais.MateriaDoDia()) 
        {
            Console.WriteLine(m);
            Console.WriteLine("--------------");
        }
        Console.WriteLine("Digite o nome da materia:");
        string mat = Console.ReadLine()!;
       foreach (var m in materiais.Materias().Values) 
        {
            foreach (var n in m)
            {
                if (n.Equals(mat))
                {
                    materia.Nome = n;
                    materia.Anotacao = materiais.LerAnotacao(n).ToString()!;
                    break;
                }
            }
        
        }
       if (materia.Nome == String.Empty) 
        {
            Console.WriteLine("Materia não encontrada");
            Console.ReadKey();
            Iniciar();
        }
        Console.WriteLine(materia.Nome);
        Console.WriteLine(materia.Anotacao);
        Console.ReadKey();
        Novo(materia);
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
            Revisao revisao = new Revisao();
            revisao.ProximaRevisao(d);
            materia.Revisar = revisao;
            Console.Clear();
            Console.WriteLine($"Agendamento confirmado para {materia.Revisar.DiaDeRevisar.ToString("M/d/yyyy")} ");
            Console.ReadKey();
        }
        else {
            Console.Clear();
            Console.WriteLine("formato inválido!");
            Console.ReadKey();
            Finalizar(materia);
        }
        Console.Clear();
        if (materia.Nome == String.Empty)
        {
            Console.WriteLine("Digite o nome da materia:\n");
            materia.Nomear(Console.ReadLine()!);
        }
        Salvar.Finalizar(materia);
        

    }

}
