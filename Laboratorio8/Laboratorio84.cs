//propiedades de lectura escritura
public class Empleado
{
    private string nombre;

    public string Nombre
    {
        get {return nombre;}
        set {nombre = value;}
    }
}

//propiedades con validacion
public class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        if (value >= 0)
            saldo = value;
        else
        {
            throw new ArgumentException("EL saldo no puede ser negativo");
        }
    }
}

//propiedades de solo lectura
public class Cobertura
{
    private double radio;

    public Cobertura(double radio)
    {
        this.radio = radio;
    }

    public double Radio
    {
        get {return radio;}
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "John Doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        CuentaBancaria cta = new CuentaBancaria();
        cta.saldo = 100;
        Console.WriteLine($"El saldo del empleado: {cta.Saldo}");
        //probar desppues con un saldo negativo, para ver la excepcion

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Con una cobertura de: {c.Radio}")
    }
}