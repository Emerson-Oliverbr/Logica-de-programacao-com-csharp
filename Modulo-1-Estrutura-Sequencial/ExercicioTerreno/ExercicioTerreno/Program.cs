using System.Globalization;

//Exercicio fixação explica,ão teoria 

namespace ExercicioTerreno;

class Program
{
    static void Main(string[] args)
    {
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("--------------");
        double area = largura * comprimento;
        double preco = area * valorMetroQuadrado;

        Console.WriteLine($"AREA: {area}");
        Console.WriteLine($"PRECO: {preco.ToString("F2",CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}
