
Imports System.IO
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class Report
    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KING_PC\Desktop\Student Record System\DATABASE\DBSTUDENT.mdb"
        con.Open()
        Dim cmd As New OleDbCommand("select * from tblstd", con)
        Dim oleadp As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        oleadp.Fill(ds, "tblstd")
        '' Dim crpt As New CrystalReport1
        ''crpt.SetDataSource(ds.Tables("tblstd"))
        '' CrystalReportViewer1.ReportSource = crpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        DashBoardForm4.Show()

    End Sub
End Class