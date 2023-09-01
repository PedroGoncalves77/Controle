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
[JsonPropertyName("song")]
public string? Nome{get; set;}
[JsonPropertyName("artists")]
public string? Artista {get; set;}
[JsonPropertyName("genre")]
public string? Genero{get; set;}
[Json PropertyName("duration_ms")]
public string? Duracao{get; set;}

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
{   var saida = client.GetStringAsync("URL");
    var musicas = JsonSerialize.Decerializer<List<Musica>>(saida);

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
public static void FiltrarTodosGeneros(List<Musica> musicas)
{
var generos = musicas.Select(x => x.Genero).Distinct().ToList();
}...
}
# LinqOrder.cs
{
public static void OrdenarListaDeArtista(List<Musica> musicas){
var artistas = musicas.OrderBy(x => x.Artista).Select(x => x.Artista).Distinct().ToList();
}
# LinqFilter.cs
{
public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero){
var artistas = musicas.Where( x => x.Genero.Contains(genero)).Select(x => x.Artista).ToList();
}
}
# LinqFilter.cs
{
public static void FiltrarMusicasDeArtista(List<Musica> musicas, string artista){
var musicasArtista = musicas.Where(x => x.Artista.Equals(artista).Select( x => x.Nome).ToList();
}
}
# LinqFilter.cs
{
public static void FiltrarMusicaPeloAno(List<Musica> musicas, int ano){
var musicasAno = musicas.Where(x => x.Ano == ano).Select(x => x.Nome).ToList();
var musicas = musicas.Where(x => x.Ano.Equals(ano).Select(x => x.Nome).ToList(); // No caso de (string) ano.
}

----------------------------
Revisao 7 dias
---------------------------
# MusicasFavoritas.cs
{
public string Nome {get; set;}
public List<Musica> MusicasFavoritas{get;}

public MusicasFavoritas(string nome)
{
Nome = nome;
MusicasFavoritas = new List<Muisca>();
}
public void AdicionarMusica(Musica musica) => MusicasFavoritas.Add(musica);

public void GerarArquivoJson()
{
var json = JsonSerializer.Serialize(new{nome = Nome, musica = MusicasFavoritas});
File.WriteAllText($@"C:\Projetos\{Nome}.json",json);
}
public void GerarArquivoTxt()
string path = @"C:\Projetos";
{
using (StreamWrite write = new (path)
{
write.WriteLine(Nome);
foreach (var m in MusicasFavoritas)
{
write.WriteLine(m);
}
}
# Musica.cs
{
string[] tonalidade = {"C", "C#", "D", "D#", "E","F", "F#", "G","G#", "A" ,"A#", "B"};
public int key {get; set;}
public string Tonalidades {get {return tonalidade[key];}}
}
# LinqFilter.cs
{
public static void ExibirMusicasCSharp(Musica musicas)
{
var musicaCSharp = musicas.Where(x => x.Tonalidade.Equals("C#")).Select(x => x.Nome).ToList();
}

using (Httpclient client = new HttpClient)
{
 var saida = client.GetStringAsync("URL");
}

