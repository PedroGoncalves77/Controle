namespace ControleDeMaterial;

internal class Paths
{
    public Paths() { }
    public Paths(string materia)
    {
        pathAnotacoes = $@"C:\Projetos\Pestud\Anot\{materia}.md";
    }
    public string pathAnotacoes = $@"C:\Projetos\ControleDeMaterial\Anot\{string.Empty}.md";
    public static string pathMaterias = $@"C:\Projetos\ControleDeMaterial\Anot\materias.txt";
    public static string pathRevisao = @"C:\Projetos\ControleDeMaterial\Revisao.txt";

}
