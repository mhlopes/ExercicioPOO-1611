using _4;

bool loop = true;
ContaBancaria[] contas = new ContaBancaria[3];
contas[0] = new ContaCorrente(1);
contas[1] = new ContaPoupanca(2);
contas[2] = new ContaSalario(3);

Console.WriteLine("Selecione uma conta bancaria: ");
Console.WriteLine("1 - Conta Corrente\n2 - Conta Poupança\n3 - Conta Salário\n");
int escolha = int.Parse(Console.ReadLine());

while (escolha < 1 || escolha > 3)
{
    Console.WriteLine("resposta invalida");
    escolha = int.Parse(Console.ReadLine());
}

ContaBancaria contaSelecionada = contas[escolha - 1];


while (loop)
{
    Console.Clear();

    Console.WriteLine($"Conta selecionada: {contaSelecionada.Numero}\n");
    Console.WriteLine("1. Selecionar Conta");
    Console.WriteLine("2. Consultar Saldo");
    Console.WriteLine("3. Depositar");
    Console.WriteLine("4. Sacar");
    Console.WriteLine("5. Transferir");
    Console.WriteLine("6. Pagar");
    Console.WriteLine("7. Exibir Contas");
    Console.WriteLine("8. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {contas[i].ToString()}");
            }
            Console.Write("Escolha uma conta: ");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if (indice >= 0 && indice < contas.Length)
            {
                contaSelecionada = contas[indice];
            }
            else
            {
                Console.WriteLine("Conta inválida.");
            }
            break;
        case 2:
            Console.WriteLine($"Saldo: {contaSelecionada.Saldo}");
            break;
        case 3:
            Console.Write("Digite o valor a ser depositado: ");
            float valorDeposito = float.Parse(Console.ReadLine());
            contaSelecionada.Depositar(valorDeposito);
            break;
        case 4:
            Console.Write("Digite o valor a ser sacado: ");
            float valorSaque = float.Parse(Console.ReadLine());
            contaSelecionada.Sacar(valorSaque);
            break;
        case 5:
            Console.Write("Digite o número da conta de destino: ");
            int destino = int.Parse(Console.ReadLine()) - 1;
            if (destino < 0 || destino >= contas.Length || contas[destino] == contaSelecionada)
            {
                Console.WriteLine("Conta de destino inválida.");
                break;
            }
            Console.Write("Digite o valor a ser transferido: ");
            float valorTransferencia = float.Parse(Console.ReadLine());
            contaSelecionada.Transferir(valorTransferencia, contas[destino]);
            break;
        case 6:
            Console.Write("Digite o valor a ser pago: ");
            float valorPagamento = float.Parse(Console.ReadLine());
            contaSelecionada.Pagar(valorPagamento);
            break;
        case 7:
            foreach (ContaBancaria conta in contas)
            {
                Console.WriteLine(conta.ToString());
            }
            break;
        case 8:
            loop = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}
