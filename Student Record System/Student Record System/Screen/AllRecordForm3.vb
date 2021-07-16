Imports System.Data.OleDb
Imports System.Data
Imports System.FileStyleUriParser
Imports System.IO
Public Class AllRecordForm3

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        DashBoardForm4.Show()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        DashBoardForm4.Show()

    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        TblstdBindingSource2.MoveNext()


    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TblstdBindingSource2.MovePrevious()

    End Sub

    Private Sub btndelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TblstdBindingSource2.RemoveCurrent()




    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnewdata.Click
        Me.Hide()
        NewustudentaddForm2.Show()

    End Sub

    Private Sub btnconnection_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnection.Click

        Try
            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
            con.Open()
            MessageBox.Show("DataBase Connected Successfully..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cmd As New OleDbCommand("Select * From tblstd", con)
            Dim ADB As New OleDbDataAdapter
            Dim ds As New DataSet
            ADB.Fill(ds, "tblstd")
            DataGridView1.DataSource = ds.Tables("tblstd")
            DataGridView1.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AllRecordForm3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBSTUDENTDataSet2.tblstd' table. You can move, or remove it, as needed.
        '' Me.TblstdTableAdapter1.Fill(Me.DBSTUDENTDataSet2.tblstd)
        'TODO: This line of code loads data into the 'DBSTUDENTDataSet.TBLDBSTUDENT' table. You can move, or remove it, as needed.
        '' Me.TBLDBSTUDENTTableAdapter.Fill(Me.DBSTUDENTDataSet.TBLDBSTUDENT)
        'TODO: This line of code loads data into the 'DBSTUDENTDataSet1.tblstd' table. You can move, or remove it, as needed.
        ''    Me.TblstdTableAdapter.Fill(Me.DBSTUDENTDataSet2.tblstd)
        ''With DataGridView1

        ''End With
        ''  DataGridView1.ClearSelection()
        '' DataGridView1.MultiSelect = False
        ''Hide id Column
        '' DataGridView1.Columns(0).Visible = False
        '' End
        ''Me.TblstdTableAdapter1.Fill(Me.DBSTUDENTDataSet2.tblstd)
        'With DataGridView1
        '    .ClearSelection()
        '    .ReadOnly = True
        '    .MultiSelect = False

        'End With
        ''  Dim color() As String = [Enum].GetName(GetType(KnownColor))

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        cmbsearch.SelectedIndex = 0
        cmbsearch.SelectedIndex = 0
        con.Open()
        MessageBox.Show("DataBase Connected Successfully..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim query As String = "Select * from tblstd"
        DataGridView1.Refresh()

        Dim ADB As New OleDbDataAdapter(query, con)
        Dim ds As New DataSet
        'DataGridView1.DataSource = ds.Tables(0)
        ADB.Fill(ds, "tblstd")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = ds.Tables("tblstd")
        Dim img As New DataGridViewImageColumn()
        '' img = DataGridView1.Columns()
        img = DataGridView1.Columns(17)
        img.ImageLayout = DataGridViewImageCellLayout.Stretch
        con.Close()
        bindgrid()


    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        'Try
        '    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        '    con.Open()
        '    Dim oledbcommand As New OleDbCommand("select * from tblstd where Full_Name=@Full_Name", con)
        '    acscmd.Parameters.Add("@Full_Name", OleDbType.Integer).Value = txtsearch.Text
        '    Dim adp As New OleDbDataAdapter(acscmd)
        '    Dim table As New DataTable()
        '    adp.Fill(table)
        '    If (table.Rows.Count() > 0) Then
        '        DataGridView1.DataSource = table
        '        cmbsearch.SelectedIndex = 0

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("Execption.....! Sorry No Data Found !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

        On Error GoTo searcherr
        If txtsearch.Text = "" Then
            Exit Sub

        Else
            Dim cantFind As String = txtsearch.Text
            TblstdBindingSource1.Filter = "(convert(ID, 'System.string') LIKE '" & txtsearch.Text & "')" & _
                "OR (Full_Name LIKE '" & txtsearch.Text & "') OR (Mother_Name LIKE '" & txtsearch.Text & "')" & _
                "OR (MOB LIKE '" & txtsearch.Text & "') OR (Email LIKE '" & txtsearch.Text & "')" & _
                "OR (Aaddhar_No LIKE '" & txtsearch.Text & "') OR (College_Name LIKE '" & txtsearch.Text & "')" & _
                "OR (Branch LIKE '" & txtsearch.Text & "') OR (Semester LIKE '" & txtsearch.Text & "')" & _
                "OR (Date_of_Admission LIKE '" & txtsearch.Text & "')"

            If TblstdBindingSource1.Count <> 0 Then
                With DataGridView1
                    .DataSource = TblstdBindingSource1
                End With


            Else
                MsgBox("-->" & cantFind & vbNewLine & _
                       "The Search item was not found.", _
                       MsgBoxStyle.Information, "Hey Boss!")
                TblstdBindingSource1.Filter = Nothing
                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = TblstdBindingSource1


                End With


            End If



        End If



ErrRe:
        Exit Sub

searchErr:

        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrRe
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub DBSTUDENTDataSetBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBSTUDENTDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Click

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        'con.Open()
        'Dim acscmd As New OleDbCommand("Select * from tblstd")
        'acscmd = New OleDbCommand("select * from tblstd", con)
        'Dim oledbcommand As New OleDbCommand
        'oledbcommand.
        'Dim dt As New DataTable
        'oledbcommand.Fill(dt)
        '' Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CO-04\Desktop\VS PRACTICALS\DATABASEAPP\DATABASEAPP\COSTUDENTS.mdb")
        con.Open()
        ''Query = "select * from TBLSTUDENTS"
        Dim query As String = "Select * from tblstd"
        ''olecommand = New OleDbCommand("select * from TBLSTUDENTS", con)
        '' Dim oledbcommand As New OleDbCommand
        Dim ADB As New OleDbDataAdapter(query, con)
        'ADB.SelectCommand = OleDbCommand
        Dim dt As New DataTable
        ADB.Fill(dt)
        '' con.Close()
        Try
            If cmbsearch.SelectedIndex = 1 And String.IsNullOrEmpty(txtsearch.Text) = False Then
                'con.Open()
                query = "select * from tblstd where ID=@ID"
                'ADB = New OleDbDataAdapter(query, con)
                'olecommand.Parameters.AddWithValue("@ID", Val(txtsearch.Text))
                ''Dim oledbcommand As New OleDbCommand
                Dim ds As New DataSet
                'ADB.SelectCommand = olecommand
                'ADB.Fill(ds, "tblstd")
                ''olda.Fill(dt)
                ''=============DATAGRIDVIEW FILLING AS PER IMAGE DISPLAY===================================
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                DataGridView1.RowTemplate.Height = 100  ''==HEIGHT SETTING 100
                Dim img As New DataGridViewImageColumn()
                ''Dim ds As New DataSet
                '' Dim DV As New DataView(ds.Tables("TBLSTUDENTS"))
                DataGridView1.DataSource = ds.Tables("tblstd")
                img = DataGridView1.Columns(17)
                img.ImageLayout = DataGridViewImageCellLayout.Stretch
                con.Close()

                ''/textchanged event of texbox when user enter a word in the textbox then through this dataview object string format it will filter and attached the filter result in to the datagridview
                'Dim ADB As New OleDbDataAdapter
            ElseIf cmbsearch.SelectedIndex = 2 Then
                Dim DV As New DataView(dt)
                DV.RowFilter = String.Format("Enrollment_No LIKE '%{0}%'", txtsearch.Text)
                DataGridView1.DataSource = DV
                con.Close()
                ''//textchanged event of texbox when user enter a word in the textbox then through this dataview object string format it will filter and attached the filter result in to the datagridview

            ElseIf cmbsearch.SelectedIndex = 3 Then
                Dim DV As New DataView(dt)
                DV.RowFilter = String.Format("BRANCH LIKE '%{0}%'", txtsearch.Text)
                DataGridView1.DataSource = DV
                con.Close()

            ElseIf cmbsearch.SelectedIndex = 4 Then
                Dim DV As New DataView(dt)
                DV.RowFilter = String.Format("Date_of_Admission LIKE '%{0}%'", txtsearch.Text)
                DataGridView1.DataSource = DV
                con.Close()

            ElseIf cmbsearch.SelectedIndex = 5 Then
                Dim DV As New DataView(dt)
                DV.RowFilter = String.Format("Full_NAME LIKE '%{0}%'", txtsearch.Text)
                DataGridView1.DataSource = DV
                con.Close()
            ElseIf txtsearch.Text = "" Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TblstdBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblstdBindingSource.CurrentChanged
        Me.Validate()
        Me.TblstdBindingSource2.EndEdit()
        ''Me.TblstdTableAdapter.Update(Me.DBSTUDENTDataSet1)
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Select" Then
            DataGridView1.SelectAll()
        End If

    End Sub
    Private bitmap As Bitmap
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If
        'Dim height As Integer = DataGridView1.Height
        'DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        'bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        'DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        'PrintDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'PrintPreviewDialog1.ShowDialog()
        'DataGridView1.Height = height



    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 100, 100)
        Dim rectprint As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height - rectprint.Height > 0 Then e.HasMorePages = True

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim index As Integer
        'index = DataGridView1.CurrentCell.RowIndex
        'DataGridView1.Rows.RemoveAt(index)
        ''Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        ''Try
        ''    Dim datagrid As Integer
        ''    If Not datagrid  = 0 Then
        ''        con.Open()

        ''        ''olecommand.Connection = con
        ''        ''Close()
        ''        Dim oledbcommand As New OleDbCommand("delete from tblstd where ID=ID", con)
        ''        oledbcommand.Parameters.AddWithValue("@ID", con)
        ''        oledbcommand.ExecuteNonQuery()
        ''        con.Close()
        ''        ''Dim oledbcommand As New OleDbCommand
        ''        ''olda.SelectCommand = olecommand
        ''        '' olda.Fill(ds, "tblstd")
        ''        '' DatagridFill()
        ''        MessageBox.Show("Record Deleted Successfully!")
        ''        'Gridrowselect = 0
        ''        'CLEARALL()
        ''        'datagrid()
        ''    Else
        ''        MsgBox("PLEASE SELECT ATLEAST ONE RECORD TO PROCEED")
        ''    End If

        ''Catch ex As Exception
        ''    MsgBox(ex.Message)
        ''End Try

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        con.Open()
        Dim oledbcommand As New OleDbCommand("Delete from tblstd where Enrollment_No='" & txtsearch.Text & "' ", con)
        oledbcommand.ExecuteNonQuery()
        MessageBox.Show("Record Deleted Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.bindgrid()

    End Sub



    Private Sub btnreportgenrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KING_PC\Desktop\Student Record System\DATABASE\DBSTUDENT.mdb")
        '    If Not con.State = ConnectionState.Open Then
        '        con.Open()
        '    End If

        '    'Query = "select * from TBLSTUDENTS where COLLEGE_ID=@COLLEGE_ID"
        '    If cmbsearch.Selected = 1 Then
        '        query = "select * from  tblstd where ID=" & txtsearch.Text & ""
        '        Dim query As String = "Select * from tbl_LC where ID=" & txtsearch.Text & ""
        '    ElseIf cmbsearch.Selected = 2 Then
        '        query = "select * from TBLSTUDENTS where ENROLLMENT_NO='" & txtsearch.Text & "'"
        '        Dim query As String = "Select * from tbl_LC where Enrollment_No=" & txtsearch.Text & ""
        '    ElseIf cmbsearch.Selected = 3 Then
        '        query = "select * from TBLSTUDENTS where BRANCH='" & txtsearch.Text & "'"
        '        Dim query As String = "Select * from tbl_LC where Branch=" & txtsearch.Text & ""
        '    ElseIf cmbsearch.Selected = 4 Then
        '        query = "select * from TBLSTUDENTS where ADMISSION_YEAR='" & txtsearch.Text & "'"
        '        Dim query As String = "Select * from tbl_LC where Date_of_Admission=" & txtsearch.Text & ""
        '    ElseIf cmbsearch.Selected = 5 Then
        '        query = "select * from TBLSTUDENTS where NAME='" & txtsearch.Text & "'"
        '        Dim query As String = "Select * from tbl_LC where Full_Name=" & txtsearch.Text & ""

        '    End If
        '    ' Dim ADB As New OleDbDataAdapter(query, con)

        '    Dim ds As New DataSet
        '    Dim olecommand As New OleDbCommand(query, con)
        '    'olecommand.Parameters.AddWithValue("@COLLEGE_ID", Val(txtsearch.Text))
        '    Dim olda As New OleDbDataAdapter(olecommand)
        '    Dim ds As New DataSet
        '    'olda.SelectCommand = olecommand
        '    olda.Fill(ds, "tbl_LC")
        '    'olda.Fill(dt)
        '    Dim frm2 As New Report
        '    Dim rpt2 As New CrystalReport2
        '    rpt2.SetDataSource(ds.Tables("tbl_LC"))
        '    frm2.CrystalReportViewer1.ReportSource = rpt2
        '    frm2.Show()
        '    '===================================================
        '    con.Close()
        '    'Form2.crysrpt(rpt2)
        '    'Form2.Show()


        'End Sub
    End Sub
    Private Sub bindgrid()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb")

        Dim oledbcommand As New OleDbCommand("select * from tblstd", con)
        oledbcommand.CommandType = CommandType.Text
        Dim olda As New OleDbDataAdapter(oledbcommand)
        Dim ds As New DataTable()
        olda.Fill(ds)
        DataGridView1.DataSource = ds
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub DataGridView1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp
        If (txtsearch.Text = "") Then
            bindgrid()

        End If


    End Sub

   
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        'Dim from As New NewustudentaddForm2
        'Try
        '     DataGridView1. = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())
        '    from.txtfullname.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        '    from.txtenrollmentno.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        '    from.txtaaddharno.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        '    from.txtmob.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        '    from.txtmothername.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        '    from.dobpicker.values = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString())

        '    ''    '=========================================================
        '    ''    'geting image into picturebox
        '    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        '    con.Open()
        '    Dim getimg As String = "select * from tblstd where Enrollment_No=" & DataGridView1.Select
        '    Dim olda As New OleDbDataAdapter(getimg, con)
        '    Dim ds As New DataSet
        '    olda.Fill(ds)
        '    Dim picture As Byte() = (ds.Tables(0).Rows(0)("PICTURE"))
        '    Dim ms As New MemoryStream(picture)
        '    PictureBox.Image = Image.FromStream(ms)
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


    End Sub

    
    Private Sub AllRecordForm3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim form As New NewustudentaddForm2
        form.cmbmrandmiss.SelectedItem = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        form.txtfullname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        form.txtmothername.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        ''form.dobpiker.Date = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        form.cmbgender.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        form.txtmob.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        form.txtemail.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        form.txtaaddharno.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        form.cmbcategory.SelectedItem = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        form.txtsubcaste.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        form.txtaddress.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        form.txtenrollmentno.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        form.txtcollegename.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        form.cmbbranch.SelectedItem = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        form.cmbsemester.SelectedItem = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        ''  form.dateofadmissionpicker.Date = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        form.ShowDialog()

    End Sub

    Private Sub btndelete_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb")
        ''Try
        '  If Not  = 1 Then
        'con.Open()

        ''olecommand.Connection = con
        ''Close()
        '  Dim oledbcommand As New OleDbCommand("delete from tblstd where Fullname=@Fullname", con)
        '  oledbcommand.Parameters.AddWithValue("@COLLEGE_ID", )
        '  oledbcommand.ExecuteNonQuery()
        '  con.Close()
        ''Dim oledbcommand As New OleDbCommand
        ''olda.SelectCommand = olecommand
        '' olda.Fill(ds, "TBLSTUDENTS")
        '' DatagridFill()
        'MessageBox.Show("Record Deleted Successfully!")
        ' Gridrowselect = 0
        '  CLEARALL()
        ''  DatagridFill()
        '  Else
        '  MsgBox("PLEASE SELECT ATLEAST ONE RECORD TO PROCEED")
        '  End If

        '  Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try


    End Sub
End Class