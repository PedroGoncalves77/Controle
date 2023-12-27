namespace ControleDeMaterial.Menu;

internal class MenuNovoEstudo : Menu
{
    public override void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("1 - Revisão.");
        Console.WriteLine("2 - Nova anotação.");
        var escolha = Console.ReadLine();
        switch (escolha) 
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Digite o nome da materia:");
                var materia = Console.ReadLine();
                Existente(materia);break;
            case "2" : Novo(new Materia());break;
            default: Console.Clear(); break;
		        
                
        }
    }
    public void Existente(string mat) 
    {   Console.Clear();
        Materia materia = new();
        Materiais materiais = new();
        foreach(var m in materiais.MateriaDoDia()) 
        {
            Console.WriteLine(m);
            Console.WriteLine("--------------");
        }
        if (mat.Length == 0) 
        {
            Iniciar();
        }
       foreach (var m in materiais.Materias().Values) 
        {
            foreach (string n in m)
            {
                if (n.Equals(mat))
                {
                    materia.Nome = n;
                    materia.Anotacao = materiais.LerAnotacao(n).ToString()!;
                    break;
                }
            }
        
        }
        if(materia.Nome == String.Empty || materia.Nome == null)
        {
            Console.WriteLine("Materia não encontrada");
            Console.ReadKey();
            Iniciar();
        }
        else
        {
            Console.WriteLine(materia.Nome);
            Console.WriteLine(materia.Anotacao);
            Console.ReadKey();
            Novo(materia);
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
        Revisao revisao = new Revisao();
        
       
            Console.WriteLine("Digite o numero de dias até a proxima revisão:");
            string dias = Console.ReadLine()!;
            if (int.TryParse(dias, out int d))
            {
               
                revisao.ProximaRevisao(d);
                materia.Revisar = revisao;
                Console.Clear();
                Console.WriteLine($"Agendamento confirmado para {materia.Revisar.DiaDeRevisar.ToString("d")} ");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("formato inválido!");
                Console.ReadKey();
                Finalizar(materia);
            }
        Console.Clear();
        if (materia.Nome == String.Empty) 
        { 
            string nome = string.Empty;
            do {
                Console.WriteLine("Digite o nome da materia:\n"); 
                nome = Console.ReadLine()!;
            }
            while (nome == null || nome.Equals(string.Empty));
           
            materia.Nomear(nome);
            
        }
        Salvar.Finalizar(materia);
        

    }

}
