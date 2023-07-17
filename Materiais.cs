using System.Net.Http.Headers;

namespace ControleDeMaterial;

internal class Materiais
{
    Dictionary<string, List<string>> Listado = new();
    List<string> lista = new();
    public Dictionary<string, List<string>> Materias() => Listado;
    public List<string> Registro() => lista;
    public void ListarMateria() 
    {
        if (File.Exists(Paths.pathRevisao))
        {
            Console.Clear();

            Stream stream = File.Open(Paths.pathRevisao, FileMode.Open);
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
                    data = i.Substring(0, 10);
                    materia = i.Substring(11);
                    listado.Add(materia);
                    if (Listado.ContainsKey(data))
                    {
                        Listado[data].Add(materia);
                    }
                    else
                    {
                        Listado.Add(data, new List<string>());
                        Listado[data].Add(materia);
                    }
                }
            }         
            stream.Close();
            leitor.Close();
        }
        
    }

    public string LerAnotacao(string materia)
    {
        if (File.Exists(materia))
        {
            Materia conteudo = new();
            string pathAnot = $@"C:\Projetos\ControleDeMaterial\Anot\{materia}.md";
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
        string d = DateTime.Now.ToString("dd/mm/yyy");
        if (Listado.ContainsKey(d)) 
        {
            return Listado[d];
        }
        else { return null!; }
    }
   
}
