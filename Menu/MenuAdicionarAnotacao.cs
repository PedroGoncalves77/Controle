namespace ControleDeMaterial.Menu;

internal class MenuAdicionarAnotacao
{
    public void Iniciar(string path) 
    {
        Materiais materiais= new Materiais();
        var p = new Paths(path);
        Materia materia = new Materia();
        materia.Nome = path;
        materia.Anotacao = materiais.LerAnotacao(p.pathAnotacoes);
        materia.AddAnotacao();
    }
}
