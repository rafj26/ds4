Module Laboratorio104
    Sub Main()
        Dim num1, num2 As Double
        Dim operacion As String

        Console.WriteLine("Ingrese el primer número:")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        num2 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese la operación (+, -, *, /):")
        operacion = Console.ReadLine()

        Select Case operacion
            Case "+"
                Console.WriteLine("El resultado es: " & (num1 + num2))
            Case "-"
                Console.WriteLine("El resultado es: " & (num1 - num2))
            Case "*"
                Console.WriteLine("El resultado es: " & (num1 * num2))
            Case "/"
                If num2 <> 0 Then
                    Console.WriteLine("El resultado es: " & (num1 / num2))
                Else
                    Console.WriteLine("Error: División por cero.")
                End If
            Case Else
                Console.WriteLine("Operación no válida.")
        End Select
    End Sub
End Module
