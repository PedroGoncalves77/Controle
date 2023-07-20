using ControleDeMaterial;
using ControleDeMaterial.Menu;

Console.Clear();
Dictionary<int, Menu> escolha = new();
escolha.Add(1, new MenuAdicionarAnotacao());
escolha.Add(2, new MenuAnotacao());
escolha.Add(3, new MenuDoDia());
escolha.Add(4, new MenuMaterias());
escolha.Add(5, new MenuNovoEstudo());
escolha.Add(6, new MenuRegistro());

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Bem vindo!");
Console.WriteLine("1 - Para Adicionar uma anotação.");
Console.WriteLine("2 - Para obter uma anotação. ");
Console.WriteLine("3 - Para saber as materias a serem revisadas.");
Console.WriteLine("4 - Para ver a lista de todas as materias.");
Console.WriteLine("5 - Para iniciar um novo estudo.");
Console.WriteLine("6 - Para ver o registro de todas as materias.\n");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
    {

        if (escolha.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menu menuDeExibicao = escolha[opcaoEscolhidaNumerica];
            menuDeExibicao.Iniciar();
            if (opcaoEscolhidaNumerica > 0) { ExibirOpcoesDoMenu(); }
        }
        else
        {
            Console.WriteLine("Opção inválida");
            ExibirOpcoesDoMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção invalida!");
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();

