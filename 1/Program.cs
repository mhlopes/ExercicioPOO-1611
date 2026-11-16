using _1;
using System.Security.Cryptography;

string RandomString()
{
    Random random = new Random();
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    return new string(Enumerable.Repeat(chars, 10)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}

Carro[] carros = new Carro[4];

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("defina o fabricante do carro {0}", i + 1);
    string fabricante = RandomString();
    Console.WriteLine("\ndefina o modelo do carro {0}", i + 1);
    string modelo = RandomString();
    Console.WriteLine("\ndefina o ano de fabricação do carro {0}", i + 1);
    int anoFabricacao = RandomNumberGenerator.GetInt32(1900, 2024);
    Console.WriteLine("\ndefina o ano do modelo do carro {0}", i + 1);
    int anoModelo = RandomNumberGenerator.GetInt32(1900, 2024);
    Console.WriteLine("\ndefina o valor de venda do carro {0}", i + 1);
    float valorVenda = RandomNumberGenerator.GetInt32(0, 100000);
    Console.WriteLine("\ndefina o tipo do motor do carro {0}", i + 1);
    string tipoMotor = RandomString();
    Console.WriteLine("\ndefina a cilindrada do motor do carro {0}", i + 1);
    int cilindradaMotor = RandomNumberGenerator.GetInt32(0, 10000);
    Console.WriteLine("\ndefina a potência do motor do carro {0}", i + 1);
    int potenciaMotor = RandomNumberGenerator.GetInt32(0, 1000);

    carros[i] = new Carro(fabricante, modelo, anoFabricacao, anoModelo, valorVenda);
    carros[i].Motor = new Motor(tipoMotor, cilindradaMotor, potenciaMotor);

    Console.Clear();
}

foreach (Carro carro in carros)
{
    Console.WriteLine($"carro {Array.IndexOf(carros, carro) + 1}");
    Console.WriteLine(carro.GetCarro());
    Console.WriteLine($"Motor: {carro.Motor.Tipo}, Cilindrada: {carro.Motor.Cilindrada}, Potência: {carro.Motor.Potencia}");
    Console.WriteLine($"ipva: {carro.CalculoIpva()}");
    Thread.Sleep(2000);
    Console.WriteLine();
}