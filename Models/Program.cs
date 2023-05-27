Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento");

// Pedir os valores do estacionamento
Console.WriteLine("Digite o preço inicial: ");
int.TryParse(Console.ReadLine(), out int pi);

Console.WriteLine("Digite o preço por hora: ");
int.TryParse(Console.ReadLine(), out int ph);

Console.Clear();

List<string> estacionamento = new List<string>();

int op;

do
{
    Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículos\n2 - Remover veículos\n3 - Listar veículos\n4 - Encerrar");
    int.TryParse(Console.ReadLine(), out op);

    if (op == 1)
    {
        Console.WriteLine("Digite a placa do carro que deseja estacionar:");
        var placa = Console.ReadLine();

        estacionamento.Add(placa);

        Console.Clear();
    }
    else if (op == 2)
    {
        Console.WriteLine("Digite a placa do carro que deseja remover: ");
        var placa = Console.ReadLine();

        Console.WriteLine("Digite quantas horas o veículo ficou estacionado: ");
        int he; 
        int.TryParse(Console.ReadLine(), out he);

        estacionamento.Remove(placa);

        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de {pi + (ph * he)} reais");

        Console.WriteLine("Pressione enter para continuar");
        Console.ReadLine();

        Console.Clear();
    }
    else if (op == 3)
    {
        Console.WriteLine("Lista de veículos:");
        
        // Iterar sobre os elementos da lista e exibir cada um
        foreach (var veiculo in estacionamento)
        {
            Console.WriteLine(veiculo);
        }
        
        Console.WriteLine(); // Adicionar uma linha em branco para separar a lista

        Console.WriteLine("Pressione enter para continuar");
        Console.ReadLine();
        
        Console.Clear();
    }
} while (op != 4);

Console.WriteLine("O programa se encerrou");



