namespace ControleDeMaterial.Menu;

internal class MenuDoDia : Menu
{
    public override void Iniciar()
    {
        Controle();
        Console.Clear();
        Console.WriteLine("Materia a ser revisada hoje: ");
        Materiais materiais = new Materiais();
        if (materiais.MateriaDoDia().Count == 0)
        {
            Console.WriteLine("Dia livre!");
            Console.ReadKey();
        }
        else
        {
            foreach (var m in materiais.MateriaDoDia())
            {
            if (m != null)
            {
             Console.WriteLine(m);
             Console.WriteLine("-----------");
             Go(m);
            }

            }
        }
    }
        public void Go(string materia)
        {
            Console.WriteLine("\n1 - INICIAR.");
            var escolha = Console.ReadLine();
            if (int.TryParse(escolha, out int n))
            {
            switch (n)
            {
              case 1: MenuNovoEstudo menuNovoEstudo = new();
                        menuNovoEstudo.Existente(materia); break;
            }
            } 
        }

    private void Controle()
    {
        Materiais materia = new();
        var dados = materia.Materias();
        List<DateTime> datas = new();
        foreach (var d in dados.Keys)
        {
            datas.Add(Convert.ToDateTime(d));
        }
        var retorno = datas.MinBy(x => x);
        var dias = retorno - DateTime.Now.Date;
        if (dias.Days > 0) 
        { Console.WriteLine("Numero de dias até a proxima revisão:");
            Console.WriteLine(dias.Days);
            Console.ReadLine();
        }
        else {
            Console.WriteLine("Materias em pendencia:");
            foreach (var d in datas) 
            {   
                if (d.Date < DateTime.Now.Date)
                {
                    Console.WriteLine(d.ToString("d"));
                    foreach (var da in dados[d.ToString("d")]) 
                    { Console.WriteLine(da); }
                    Console.WriteLine("----------");
                }
            }
            Console.ReadKey();
        }
    } 
}
