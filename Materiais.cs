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
    
    public async void ListarMateria()
    {
        string linha = " ";
        string revisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";
            Console.Clear();
        var leitura = await File.ReadAllLinesAsync(revisao);
        lista = leitura.ToList();
        
        
    }
    public void Listando() 
    {
       List<string> listado = new();
            string data = string.Empty;
            string materia = string.Empty;
        foreach (var i in lista)
        {
          if (i != null)
          {
             data = i.Substring(0, 10).Trim();
             materia = i.Substring(11).Trim();
             listado.Add(materia);
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
        Materia conteudo = new();
        string pathAnot = $@"C:\Projetos\ControleDeMaterial\Anot\{materia}.md";
        if (File.Exists(pathAnot))
        {
           var anot = File.ReadAllText(pathAnot);
            return anot;
        }
        else { return "Materia não encontrada"; }
    }
    public List<string> MateriaDoDia() 
    {
        var list = new List<string>();
        string d = DateTime.Now.ToString("M/d/yyyy");
        if (Listado.ContainsKey(d)) 
        {
            list = Listado[d];
            return list;
        }
        else { return list; }
    }
   
}
