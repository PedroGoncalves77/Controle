using System.Diagnostics;


namespace ControleDeMaterial;

internal class Salvar
{
    
    public static async void Finalizar(Materia materia) 
    {
        string pathRevisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";
        string spc = "   ";
       string id = $"{materia.Revisar.DiaDeRevisar.ToString("M/d/yyyy")}{spc}{materia.Nome} \n";
       await File.AppendAllTextAsync(pathRevisao, id);
    }
    public static void Final()
    {
        string command = $@"C:\Projetos\ControleDeMaterial\Scripts\finally.ps1";
        Process.Start("powershell.exe", command);
    }
}
