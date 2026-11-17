using _3;

bool loop = true;

Console.Write("Digite a quantidade de livros: ");
int quantidade = int.Parse(Console.ReadLine());
Console.Clear();
Livro[] livros = new Livro[quantidade];

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Digite o título do livro {i + 1}: ");
    string titulo = Console.ReadLine();
    Console.WriteLine($"Digite o autor do livro {i + 1}: ");
    string autor = Console.ReadLine();
    Console.WriteLine($"Digite o número de páginas do livro {i + 1}: ");
    int numeroPaginas = int.Parse(Console.ReadLine());
    livros[i] = new Livro(titulo, autor, numeroPaginas);

    Console.Clear();
}

while (loop)
{
    Console.Clear();
    Console.WriteLine("1. Exibir todos os livros");
    Console.WriteLine("2. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            for (int i = 0; i < livros.Length; i++)
            {
                Console.WriteLine($"Livro {i+1} - {livros[i].ToString()}");
            }
            break;
        case 2:
            loop = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}