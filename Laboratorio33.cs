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
    }
}
