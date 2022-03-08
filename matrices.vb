Module Module1
    Sub Main()
        Dim confirmacion As String
        confirmacion = "S"
        While (confirmacion = "S" Or confirmacion = "s")
            Console.WriteLine("cuantos alumnos deseas ingresar")
            Dim cantidad As Integer = Convert.ToInt32(Console.ReadLine())
            Dim matriz(cantidad - 1, 2) As String
            For i = 0 To matriz.GetLength(0) - 1
                Console.WriteLine("Ingrese el Nombre del Alumno: " & (i + 1))
                matriz(i, 0) = Console.ReadLine()
                Console.WriteLine("Ingrese el carnet del alumno: " & (i + 1))
                matriz(i, 1) = Console.ReadLine()
                Console.WriteLine("Ingrese La carrera del alumno: " & (i + 1))
                matriz(i, 2) = Console.ReadLine()
                Console.WriteLine()
            Next
            For i = 0 To matriz.GetLength(0) - 1
                For j = 0 To matriz.GetLength(1) - 1
                    Console.Write(matriz(i, j) & " ")
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("Ingrese [S] si desea ingresar mas alumnos: ")
            confirmacion = Console.ReadLine
        End While
        Console.ReadLine()
    End Sub
End Module
