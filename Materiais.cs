namespace ControleDeMaterial;

internal class Materiais
{
    public Materiais()
    {
        ListarMateria();
    }
    Dictionary<string, List<string>> Listado = new();
    List<string> lista = new();

    public Dictionary<string, List<string>> Materias() => Listado;
    public List<string> Registro() => lista;
    
    public void ListarMateria()
    {
        try
        {
            string linha = " ";
            string revisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";
            Console.Clear();
            var leitura = File.ReadAllLines(revisao);
            lista = leitura.ToList();
            Listando();
        }
        catch(Exception ex) 
        {   

            Console.WriteLine(ex.Message);
        }
    }
    public void Listando() 
    {
            string data = string.Empty;
            string materia = string.Empty;
        foreach (var i in lista)
        {
          if (!(string.IsNullOrEmpty(i)))
          {
             data = i.Substring(0, 10).Trim();
             materia = i.Substring(11).Trim();
             if (! (Listado.ContainsKey(data)))
             {
             Listado.Add(data, new List<string>());
             Listado[data].Add(materia);
             }
             if (Listado.ContainsKey(data) && (!(Listado[data].Contains(materia))))
             {
              Listado[data].Add(materia);             
             }

          }
        }  
    }
    public string LerAnotacao(string materia)
    {
        try
        {
            Materia conteudo = new();
            string pathAnot = $@"C:\Projetos\ControleDeMaterial\Anot\{materia}.md";
            if (File.Exists(pathAnot))
            {
                var anot = File.ReadAllText(pathAnot);
                return anot;
            }
            else { return String.Empty; }
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message);
            return String.Empty;
        }
    }
    public List<string> MateriaDoDia() 
    {
        var list = new List<string>();
        try
        {
            string d = DateTime.Now.ToString("M/d/yyyy");
            if (Listado.ContainsKey(d))
            {
                list = Listado[d];
                return list;
            }
            else { return list; }
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message);
            return list;
        }
    }
   
}
