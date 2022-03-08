Module Module1

    Sub Main()

        'Definimos un array con 11 posiciones (10 en realidad)
        Dim numeros(10) As Integer

        Dim multiplo As Integer = 5

        'Recorremos el array
        'array.lenght indica la longitud del array
        For i As Integer = 0 To numeros.Length - 1
            numeros(i) = multiplo * i
            Console.WriteLine("5 x " & i & " = " & numeros(i))
        Next

        Console.ReadLine()

    End Sub

End Module
