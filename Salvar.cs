using System.Diagnostics;


namespace ControleDeMaterial;

internal class Salvar
{
    public static void Limpar(Materia materia) 
    {
        List<DateTime> datas = new();
        Materiais materiais = new();
        var conteudo = materiais.Materias();
        foreach(var c in conteudo.Keys) 
        {
            var data = Convert.ToDateTime(c);
            if (data < DateTime.Now)
            { datas.Add(data); }
        }
        foreach (var d in datas) 
        {
            if (conteudo[d.ToString("d")].Contains(materia.Nome)) 
            {
                conteudo[d.ToString("d")].Remove(materia.Nome);
            }
        }
        var path = @"C:\Projetos\ControleDeMaterial\Revisao.txt"; 
        using (StreamWriter writer = new StreamWriter(path)) 
        {
            foreach (var c in conteudo.Keys)
            {
              foreach(var x in conteudo[c]) 
                {
                    writer.WriteLine($"{c}   {x}");
                   
                }
            }
        }
    }
    
    public static async void Finalizar(Materia materia)
    {
       Limpar(materia);
       string pathRevisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";
       string spc = "   ";
       string id = $"{materia.Revisar.DiaDeRevisar.ToString("d")}{spc}{materia.Nome} \n";
       await File.AppendAllTextAsync(pathRevisao, id);
    }
    public static void Final()
    {
        string command = $@"C:\Projetos\ControleDeMaterial\Scripts\finally.ps1";
        Process.Start("powershell.exe", command);
    }
}
