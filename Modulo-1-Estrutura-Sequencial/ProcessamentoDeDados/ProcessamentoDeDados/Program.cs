using System.Globalization;

namespace ProcessamentoDeDados;

class Program
{
    static void Main(string[] args)
    {
        int x, y;

        x = 5;
        y = 2 * x + 2;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine("+-----+");

        int v1;
        double v2;

        v1 = 5;
        v2 = 2 * v1;

        Console.WriteLine(v1);
        Console.WriteLine(v2);

        Console.WriteLine("+-----+");

        double b, B, h, area;

        b = 6.0;
        B = 8.0;
        h = 5.0;
        area = (b + B) / 2.0 * h;
        Console.WriteLine(area);
        Console.WriteLine("+-----+");

        int n1, n2;
        double resultado;

        n1 = 5;
        n2 = 2;        
        resultado = (double) n1 / n2;

        Console.WriteLine(resultado);
        Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
        Console.WriteLine("+-----+");        

        Console.ReadKey();
    }
}