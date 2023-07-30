### Integrando uma API externa
using(HttpClient client = new HttpClient)
{
    try{
    var saida = client.GetStringAsync("site da API");
    Console.WriteLine(saida);
    }catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
# Erros
Respostas de informa��o (100-199)
Respostas de sucesso (200-299)
Redirecionamentos (300-399)
Erros do cliente (400-499)
Erros do servidor (500-599)
-----------------------------
200 - Requisi��o bem sucedia
201 - Recurso criado com sucesso
204 - Sem recurso para encontrar
400 - Requisi��o invalida
401 - Nao autorizada
403 - Acesso restrito
404 - Requisi��o n�o encontrada
500 - Erro interno no servidor
502 - Getway invalido
503 - Servidor fora do ar

# Linq e ordena��o 

internal class Musica
{
[JsonPropertyName("Song")]
public string? Nome {get; set;}

[JsonPropetyName("duration_ms")]
public int Duracao{get; set;}

[JsonPropertyName("genre")]
public string? Genero{get; set;}

[JsonPropertyName("artist")]
public string? Artista {get; set;}

public string? years {get; set;}
public int Ano{get
{
if (int.TryParse(years out x)
{
    Ano = x;
    return Ano;
}
else{ return 0;}
}
 public void Exibir()
 {
    Console.WriteLine($"Nome - {Nome}")
    Console.WriteLine($"Artista - {Artista}")
    Console.WriteLine($"Genero - {Genero}")
    Console.WriteLine($"Dura��o - {Duracao / 1000}")
    Console.WriteLine($"Ano - {Ano}")
 }

}
# Program.cs 
{
    var saida = await GetStringAsync("Url");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(saida);
    musicas.Exibir();
    //Exibe as propriedades.
}
### Desafio 
# Program.cs
 {
    var saida = GetStringAsync("https://anapioficeandfire.com/api/characters/16");
    var personagem = JsonSerializer.Deserialize<Personagem>(saida);
    prsonagem.Exibir();
 }
# Personagem.cs
{
    [JsonPropertyName("name")]
    public string? Nome{get; set;}
    [JsonPropertyName("culture")]
    public string? Cultura {get; set;}
    [JsonPropertyName("titles")]
    public List<string?> Titulos{get; set;}
    [JsonPropertyName("aliases")]
    public List<string?> Apelidos{get; set;}

    public void Exibir()
    {
        Console.WriteLine("Nome: {0}",Nome);
        Console.WriteLine("Cultura: {0}",Cultura);
        foreach(var t in Titulos)
        {
            Console.WriteLine("T�tulos: {0}", t);
        }
        foreach(var a in Apelidos)
        {
            Console.WriteLine("Apelidos: {0}", a)
        }
    }
}


# LinqFilter.cs
{ 
public static void FiltrarTodosGeneros(List<Musica> musicas){
var generos = musicas.Select(x => x.Genero).Distinct().ToList();
...
}
# LinqOrder.cs
{
public static void OrdenarListaDeArtista(List<Musica> musicas){
var artistas = musicas.OrderBy( x => x.Artista).Select(x => x.Artista).Distinct.ToList();
}
# LinqFilter.cs
{
public static void FiltrarArtistaPorGenero(List<Musica> musicas, string artista){
var artistas = musicas.Where( x => x.Artista.Contains(artista)).Select( x => x.Genero).Distinct().ToList();}
}
# LinqFilter.cs
{
public static void FiltrarMusicasDeArtista(List<Musica> musicas, string artista){
var musicas = musicas.Where(x => x.Artista.Equals(artista)).Select( x => x.Nome).ToList();}
}
# LinqFilter.cs
{
public static void FiltrarMusicaPeloAno(List<Musica> musicas, int ano){
var musicas = musicas.Where(x => x.Ano == ano).Select( x => x.Nome).ToList();
var musicas = musicas.Where(x => x.Ano.Equals(ano).Select(x => x.Nome).ToList(); // No caso de (string) ano.
}

----------------------------
Revisao 7 dias
---------------------------

