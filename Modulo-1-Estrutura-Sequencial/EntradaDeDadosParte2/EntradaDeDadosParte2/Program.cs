using System.Globalization;
//Entrada de dados parte 2 explicação teoria
namespace EntradaDeDadosParte2;
class Program
{
    static void Main(String[] args)
    {
        int n1 = int.Parse(Console.ReadLine() ?? "0");
        char inicialNome = char.Parse(Console.ReadLine() ?? "0");
        double n2 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Voce digitou:");
        Console.WriteLine($"{n1}");
        Console.WriteLine($"{inicialNome}");
        Console.WriteLine($"{n2}");
        Console.WriteLine($"{n2.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine("---------------");

        string[] dadosPessoais = Console.ReadLine().Split(' ');
        string? nome = dadosPessoais[0];
        char sexo = char.Parse(dadosPessoais[1]);
        int idade = int.Parse(dadosPessoais[2]);
        double altura = double.Parse(dadosPessoais[3], CultureInfo.InvariantCulture);
        Console.WriteLine("---------------");

        Console.WriteLine("Dados do cliente: ");
        Console.WriteLine($"{nome}");
        Console.WriteLine($"{sexo}");
        Console.WriteLine($"{idade}");
        Console.WriteLine($"{altura.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}