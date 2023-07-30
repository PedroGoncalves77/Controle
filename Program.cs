using ControleDeMaterial;
using ControleDeMaterial.Menu;

Console.Clear();
Dictionary<int, Menu> escolha = new();
escolha.Add(3, new MenuAdicionarAnotacao());
escolha.Add(4, new MenuAnotacao());
escolha.Add(2, new MenuDoDia());
escolha.Add(5, new MenuMaterias());
escolha.Add(1, new MenuNovoEstudo());
escolha.Add(6, new MenuRegistro());

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    Console.WriteLine("1 - Para iniciar um novo estudo.");
    Console.WriteLine("2 - Materias a serem revisadas.");
    Console.WriteLine("3 - Adicionar uma anotação.");
    Console.WriteLine("4 - Para obter uma anotação. ");
    Console.WriteLine("5 - Para ver a lista de todas as materias.");
    Console.WriteLine("6 - Para ver o registro de todas as materias.\n");
    Console.WriteLine("0 - Exit.");
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
        if (opcaoEscolhidaNumerica == 0) 
        {
            Salvar.Final();
            System.Environment.Exit(0); 
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

