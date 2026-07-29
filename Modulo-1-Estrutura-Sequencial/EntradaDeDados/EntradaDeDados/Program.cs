using System.Globalization;

namespace EntradaDeDados;

class Program
{
    static void Main(string[] args)
    {
        double x = 1.35784;
        int idade = 40;
        string nomeCompleto = "Emerson Matos Oliveira";
        char sexo = 'M';

        Console.WriteLine(x);
        Console.WriteLine(x.ToString("F2"));
        Console.WriteLine(x.ToString("F4"));
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("+-------------------------------+");
        Console.WriteLine($"O valor do troco é R$ {x.ToString("F2", CultureInfo.InvariantCulture)} reais");
        Console.WriteLine($"O funcionario {nomeCompleto} tem {idade} anos e é do sexo, {sexo}");
    }
}