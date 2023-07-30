using System.Diagnostics;

namespace ControleDeMaterial;

internal class Materia
    
{
    public string Nome = String.Empty;
    public string  Anotacao { get; set; }
    public Revisao Revisar  { get; set; }

    public void AddAnotacao() 
    {
        var path = $@"C:\Projetos\ControleDeMaterial\Anot\{Nome}.md";
        Console.Clear();
        string command = $@"Start-Process vim {path}";
        Process.Start("powershell.exe", command);
        Registrar();
    }
    public void Nomear(string nome) 
    {
        Nome = nome;
        string command = $@"C:\Projetos\ControleDeMaterial\Scripts\nomear.ps1 {nome}";
        Process.Start("powershell.exe", command);
    }
    public void Registrar() 
    {
        string command = $@"C:\Projetos\ControleDeMaterial\Scripts\registrar.ps1 {Nome}";
        Process.Start("powershell.exe", command);
    } 
}
