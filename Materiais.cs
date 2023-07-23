namespace ControleDeMaterial;

internal class Materiais
{
    public Materiais()
    {
        ListarMateria();
    }
    Dictionary<string, List<string>> Listado = new();
    List<string> lista = new();

    public Dictionary<string, List<string>> Materias() { return Listado; }
    public List<string> Registro() => lista;
    public void ListarMateria() 
    {
        string revisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";
        if (File.Exists(revisao))
        {
            Console.Clear();

            Stream stream = File.Open(revisao, FileMode.Open);
            StreamReader leitor = new StreamReader(stream);
            string linha = leitor.ReadLineAsync().GetAwaiter().GetResult()!;
            while (linha != null)
            {
                linha = leitor.ReadLineAsync().GetAwaiter().GetResult()!;
                lista.Add(linha);
            }
            
            List<string> listado = new();
            string data = String.Empty;
            string materia = string.Empty;

            foreach (var i in lista)
            {
                if (i != null)
                {
                    data = i.Substring(0, 10).Trim();
                    materia = i.Substring(11).Trim();
                    listado.Add(materia);
                    if (Listado.ContainsKey(data) == false)
                    {
                        Listado.Add(data, new List<string>());
                        Listado[data].Add(materia);
                    }
                    if (Listado.ContainsKey(data))
                    {
                       if (!(Listado[data].Contains(materia))) 
                        {
                            Listado[data].Add(materia);
                        }
                        else { };
                    }
                    
                }
            }         
            stream.Close();
            leitor.Close();
        }
        
    }

    public string LerAnotacao(string materia)
    {
        string pathAnot = $@"C:\Projetos\ControleDeMaterial\Anot\{materia}.md";
        if (File.Exists(pathAnot))
        {
            Materia conteudo = new();
            
            using (var file = new StreamReader(pathAnot))
            {
                conteudo.Anotacao = file.ReadToEnd();
            }
            return conteudo.Anotacao;
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
