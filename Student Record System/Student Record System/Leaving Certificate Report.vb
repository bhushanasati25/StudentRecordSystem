Imports System.IO
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class Leaving_Certificate_form

    Private Sub Leaving_Certificate_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KING_PC\Desktop\Student Record System\DATABASE\DBSTUDENT.mdb"
        con.Open()
        Dim cmd As New OleDbCommand("select * from tbl_LC", con)
        Dim oleadp As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        oleadp.Fill(ds, "tbl_LC")
        ''  Dim crpt As New CrystalReport1
        '' crpt.SetDataSource(ds.Tables("tbl_LC"))
        ''  CrystalReport2.ReportSource = crpt
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewerLC.Load

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        LC.Show()


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        DashBoardForm4.Show()

    End Sub

    Private Sub CrystalReport21_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class