class Program
{
    static void checkAge(int age)
    {
        if (age < 15)
        {
            throw new ArithmeticException("Acceso negado - No cumple con el criterio de edad");
        }
        else 
        {
            Console.WriteLine("Acceso Concedido");
        }
    }

    static void Main(string[] args)
    {
        checkAge(15);
    }
}