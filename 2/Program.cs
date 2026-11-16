using _2;

string titular;
ContaBancaria conta1 = new ContaBancaria();

Console.WriteLine("Digite o nome do titular: ");
titular = Console.ReadLine();
conta1.Titular = titular;

while (true)
{
    Console.Clear();

    Console.WriteLine("1. Depositar");
    Console.WriteLine("2. Sacar");
    Console.WriteLine("3. Exibir Saldo");
    Console.WriteLine("4. Exibir Dados");
    Console.WriteLine("5. Alterar Dados");
    Console.WriteLine("6. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o valor a ser depositado: ");
            int valorDeposito = int.Parse(Console.ReadLine());
            conta1.Depositar(valorDeposito, conta1.Titular);
            break;
        case 2:
            Console.Write("Digite o valor a ser sacado: ");
            int valorSaque = int.Parse(Console.ReadLine());
            conta1.Sacar(valorSaque, conta1.Titular);
            break;
        case 3:
            Console.WriteLine($"Saldo: {conta1.ExibirSaldo()}");
            break;
        case 4:
            Console.WriteLine($"Titular: {conta1.Titular}");
            Console.WriteLine($"Saldo: {conta1.ExibirSaldo()}");
            break;
        case 5:
            Console.Write("Digite o novo nome do titular: ");
            string novoTitular = Console.ReadLine();
            conta1.Titular = novoTitular;
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();

}
