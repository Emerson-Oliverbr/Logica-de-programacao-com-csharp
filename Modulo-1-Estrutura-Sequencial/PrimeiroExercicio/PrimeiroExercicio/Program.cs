using System.Globalization;

namespace PrimeiroExercicio;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com o nome completo:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quantidadeQuartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com seu último nome, sua idade e sua altura (mesma linha)");

        string[] dadosCadastrais = Console.ReadLine().Split(' ');
        string ultimoNome = dadosCadastrais[0];
        int idade = int.Parse(dadosCadastrais[1]);
        double altura = double.Parse(dadosCadastrais[2]);
        Console.WriteLine("--------------");
        Console.WriteLine($"{nome}");
        Console.WriteLine($"{quantidadeQuartos}");
        Console.WriteLine($"{preco.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine("--------------");
        Console.WriteLine($"{ultimoNome}");
        Console.WriteLine($"{idade}");
        Console.WriteLine($"{altura.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
} 
