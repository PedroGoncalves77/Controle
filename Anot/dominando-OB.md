# Avaliacao.cs
{
public Avaliacao(int nota)
{
Nota = nota
}
public int Nota {get;}

}

# Musica.cs
{
public List <Avaliacao> Avaliacoes { get; set;}
public void Avaliar(Avaliacao nota) => Avaliacoes.Add(nota);
public int Media { 
get{if (Avaliacoes.Count == 0) {return 0;}
else{ return Avaliacoes.Average( x => x.Nota);}
}

# Musica.cs
{
public Avaliacao Parse(string nota)
{
if (int.TryParse(nota, out int n))
{
   return new Avaliacao(n);
}else{ Console.Clear();
Console.WriteLine("Formato inválido");
Console.WriteLine("Tente novamente");
int tentativa = 3;
int nota = 0;
do{
nota = Console.ReadLine()!;
tentativa--;
}while(tentativa > 0 || (nota > 0 && nota < 10))
new Avaliacao(nota);

using OpenAI_API;
{
OpenAIAPI gpt = new ("key");
var chat = gpt.Chat.CreateConversation();
chat.AppendSystemmessage("mensagem");
var resposta = await  chat.GetResponseFromChatBotAsync() || var resposta = chat.GetResponseFromChatBot().GetAwaiter().GetResult();
}

