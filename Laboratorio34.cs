using System;

public class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }

    public double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public int CalcularPerimetroRectangulo(int lado1, int lado2)
    {
        return 2 * (lado1 + lado2);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese el primer número (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();
        int resultado = calculos.Calcular(a, b);
        Console.WriteLine($"El resultado de la operación (a+b)*(a-b) es: {resultado}");

        Console.WriteLine("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = calculos.CalculoArea(radio);
        Console.WriteLine($"El área del círculo es: {area}");

        Console.WriteLine("Ingrese el primer lado del rectángulo: ");
        int lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado del rectángulo: ");
        int lado2 = Convert.ToInt32(Console.ReadLine());

        int perimetro = calculos.CalcularPerimetroRectangulo(lado1, lado2);
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }
}
