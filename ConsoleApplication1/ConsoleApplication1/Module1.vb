Module Module1
    Class overload
        Dim r As Double
        Public Overloads Sub area(ByVal r)
            Console.Write("Area of the Circle :")
            Console.WriteLine(1 / 3 * 3.14 * r * r * r)
        End Sub
        Dim length As Integer
        Dim width As Integer
        Public Overloads Sub area(ByVal length, ByVal width)
            Console.Write("area of the console: ")
            Console.WriteLine(length * width)
        End Sub
    End Class
    Sub Main()
        Dim r As New overload()
        r.area(3.1)
        r.area(4, 5)

    End Sub

End Module
