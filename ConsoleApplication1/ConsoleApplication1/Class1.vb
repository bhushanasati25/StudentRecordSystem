Public Class shadow
    Shared x As Integer = 1
    Shared Sub main()
        Dim x As Integer = 10
        Console.WriteLine("main: X" & x)
        Console.WriteLine("main sahdow x:" & shadow.x)

    End Sub

End Class
