Module Module1

    Sub Main()
        Console.Title = "Jacquelinne"
        Dim confirmacion As String
        confirmacion = "S"
        'bucle while
        While (confirmacion = "S" Or confirmacion = "s")
            Dim num1, num2, r As Integer
            Console.WriteLine("Ingresa un valor:")
            num1 = Console.ReadLine()

            Console.WriteLine("Ingresa un segundo valor:")
            num2 = Console.ReadLine()

            Dim opcion As Integer
            Console.WriteLine("1---- realizar suma")
            Console.WriteLine("2---- realizar resta")
            Console.WriteLine("3---- realizar multiplicacion")
            Console.WriteLine("4---- realizar division")
            opcion = Console.ReadLine

            Select Case opcion
                Case 1
                    Console.WriteLine("Resutado de la suma: " & Sumar(num1, num2))
                    Console.WriteLine("Ingrese 'S' si desea continuar: ")
                    confirmacion = Console.ReadLine
                Case 2
                    Console.WriteLine("Resultado de la resta: " & Resta(num1, num2))
                    Console.WriteLine("Ingrese 'S' si desea continuar: ")
                    confirmacion = Console.ReadLine
                Case 3
                    Multiplicar(num1, num2, r)
                    Console.WriteLine("Ingrese 'S' si desea continuar: ")
                    confirmacion = Console.ReadLine
                Case 4
                    Division(num1, num2, r)
                    Console.WriteLine("Ingrese 'S' si desea continuar: ")
                    confirmacion = Console.ReadLine
                Case Else
                    Console.WriteLine("Opcion Invalida :v")
                    Console.WriteLine("Ingrese 'S' para intentarlo nuevamente: ")
                    confirmacion = Console.ReadLine

            End Select
        End While

    End Sub

    Function Sumar(num1, num2) As Integer
        Return (num1 + num2)
    End Function
    Function Resta(num1, num2) As Integer
        Return (num1 - num2)
    End Function

    Sub Multiplicar(ByRef num1 As Integer, ByRef num2 As Integer, ByRef Res As Integer)
        Res = num1 * num2
        Console.WriteLine("Resultado de la multiplicacion: " & Res)
    End Sub

    Sub Division(ByRef num1 As Integer, ByRef num2 As Integer, ByRef Div As Integer)
        Div = num1 / num2
        Console.WriteLine("Resultado de la division: " & Div)
    End Sub

End Module
