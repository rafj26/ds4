Module Laboratorio102
    Sub Main()
        Dim numero1 As Integer
        Dim numero2 As Integer

        Console.WriteLine("Ingrese el primer número:")
        numero1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        numero2 = Convert.ToInt32(Console.ReadLine())

        Dim resultado As Integer = numero1 + numero2
        Console.WriteLine("El resultado de la suma es: " & resultado)
    End Sub
End Module
