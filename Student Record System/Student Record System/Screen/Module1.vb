﻿Imports System.Data.OleDb
Module Module1
    Public acsconn As New OleDbConnection
    Public acsdr As OleDbDataReader
    Public acsda As New OleDbDataAdapter
    Public acscmd As New OleDbCommand
    Public strsql As String
    Public acsds As New DataSet
    Public Sub connect()
        acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        acsconn.Open()
        If acsconn.State = ConnectionState.Open Then
            MsgBox("Connected !")
        Else
            MsgBox("Error !")


        End If

    End Sub
End Module
