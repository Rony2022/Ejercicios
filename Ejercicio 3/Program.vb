Imports System

Module Program
	Sub Main()
		Console.Title = "Ejercicio 3"
		Dim v1, v2 As Decimal
		Dim seleccion As Integer

		Console.WriteLine("Ingrese el primer numero")
		v1 = Console.ReadLine()
		Console.WriteLine("Ingrese el segundo numero")
		v2 = Console.ReadLine()

		Console.WriteLine("ELIJA UNA OPCION :")
		Console.WriteLine("1) Suma")
		Console.WriteLine("2) Resta")
		Console.WriteLine("3) Multiplicacion")
		Console.WriteLine("4) Division")

		seleccion = Console.ReadLine

		If (seleccion = 1) Then
			Console.WriteLine("La Suma es: " & v1 + v2)

		ElseIf (seleccion = 2) Then
			Console.WriteLine("La Resta es: " & v1 - v2)
		ElseIf (seleccion = 3) Then
			Console.WriteLine("La Multiplicacion es: " & v1 * v2)
		ElseIf (seleccion = 4) Then
			Console.WriteLine("La Division es: " & v1 / v2)
		Else
			Console.WriteLine("Opcion invalida")

		End If
		Console.ReadKey()
	End Sub
End Module
