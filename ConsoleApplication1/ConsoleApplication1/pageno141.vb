Module pageno141
    Sub main()
        Try
            Throw New Exception("mega-error")
        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try
    End Sub
End Module
