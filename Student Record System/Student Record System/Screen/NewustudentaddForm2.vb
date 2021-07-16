Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class NewustudentaddForm2

    Private Property FileDialog As Boolean


    Private Sub NewuseraddForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtenrollmentno.Text = ""
        txtfullname.Text = ""
        txtmothername.Text = ""
        dobpiker.Text = ""
        txtmob.Text = ""
        txtemail.Text = ""
        cmbgender.SelectedIndex = 0
        cmbbranch.SelectedIndex = 0
        cmbsemester.SelectedIndex = 0
        cmbmrandmiss.SelectedIndex = 0
        cmbcategory.SelectedIndex = 0
        txtaaddharno.Text = ""
        txtsubcaste.Text = ""
        txtaddress.Text = ""
        txtcollegename.Text = ""
        dateofadmissionpicker.Text = ""
        cmbmrandmiss.Focus()
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        ''connect()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        ''Try
        Dim acsconn As New OleDbConnection
        ''acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        acsconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb"
        acsconn.Open()
        Dim acscmd As New OleDbCommand("INSERT INTO tblstd([Mr/Ms],[Full_Name],[Mother_Name],[DOB],[Gender],[MOB],[Email],[Aaddhar_No],[Category],[Sub_Caste],[Address],[Enrollment_No],[College_Name],[Branch],[Semester],[Date_of_Admission],[Picturefile])VALUES('" & cmbmrandmiss.SelectedItem & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & cmbgender.SelectedItem & "','" & txtmob.Text & "','" & txtemail.Text & "','" & txtaaddharno.Text & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & txtaddress.Text & "','" & txtenrollmentno.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & dateofadmissionpicker.Value.Date & "',@dtaname)", acsconn)

        'acscmd.CommandType = CommandType.Text
        '' strsql = "INSERT INTO TBLDBSTUDENT(Enrollment_No,Full_Name,Mother_Name,DOB,MOB,Gender,Email,Aaddhar_No,Caste,Address,College_Name,Branch,Semester,Year_of_Admission,picturefile)values('" & txtenrollmentno.Text & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & txtmob.Text & '", & cmbgender.SelectedItem & "' & txtemail.Text & "','" & txtaaddharno.Text & "','" & txtcaste.Text & "','" & txtaddress.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & txtyearofadmission.Text & "',@dtaname)"
        ''strsql =
        ''acscmd.CommandText = strsql
        '' acscmd.Connection = acsconn
        ' acscmd.Parameters.AddWithValue("@dtaname", txtfilename.Text)
        '' =============================================================================
        ''ADDINTING PHOTO
        Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        Dim breader As New BinaryReader(fsreader)
        Dim imgbuffer(fsreader.Length) As Byte
        breader.Read(imgbuffer, 0, fsreader.Length)
        fsreader.Close()
        acscmd.Parameters.AddWithValue("@dtafile", imgbuffer)
        ''============================================================================================
        acscmd.ExecuteNonQuery()
        ''acscmd.Dispose()

        MessageBox.Show("Data Added Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.clear()
        Me.cmbgender.SelectedIndex = 0
        Me.cmbbranch.SelectedIndex = 0
        Me.cmbsemester.SelectedIndex = 0
        Me.cmbmrandmiss.SelectedIndex = 0
        Me.cmbcategory.SelectedIndex = 0
        acsconn.Close()
        bindgrid()
        '' Catch ex As Exception

        ''End Try

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        AllRecordForm3.Show()


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        AllRecordForm3.Show()

    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png|*.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ' If OpenFileDialog1.FileName <> Nothing Or OpenFileDialog1.FileName <> "" Then
        'txtfilename.Text = OpenFileDialog1.FileName.Substring( _
        'OpenFileDialog1.FileName.LastIndexOf("\") + 1, _
        '(OpenFileDialog1.FilessName.LastIndexOf(".", 0) - (OpenFileDialog1.FileName.LastIndexOf("\") + 1)))
        'End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.txtenrollmentno.Text = ""
        Me.txtfullname.Text = ""
        Me.txtmothername.Text = ""
        Me.dobpiker.Text = ""
        Me.txtmob.Text = ""
        Me.txtemail.Text = ""
        Me.cmbgender.SelectedIndex = 0
        Me.cmbbranch.SelectedIndex = 0
        Me.cmbsemester.SelectedIndex = 0
        Me.cmbmrandmiss.SelectedIndex = 0
        Me.cmbcategory.SelectedIndex = 0
        Me.txtaaddharno.Text = ""
        Me.txtsubcaste.Text = ""
        Me.txtaddress.Text = ""
        Me.txtcollegename.Text = ""
        Me.dateofadmissionpicker.Text = ""
        Me.cmbmrandmiss.Focus()


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        '' ''Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CO-04\Desktop\VS PRACTICALS\DATABASEAPP\DATABASEAPP\COSTUDENTS.mdb")
        ''Dim acsconn As New OleDbConnection
        ''acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KING_PC\Desktop\Student Record System\DATABASE\DBSTUDENT.mdb")
        ''Dim olecommand As New OleDbCommand

        ''olecommand.Connection = acsconn
        ''If Not acsconn.State = ConnectionState.Open Then
        ''    acsconn.Open()
        ''End If
        '' ''Query = "UPDATE tblstd SET ENROLLMENT_NO='" & txtenroll.Text & "',NAME='" & txtname.Text & "',BRANCH='" & cmbbranch.SelectedItem & "',MOBILE_NUMBER='" & txtmob.Text & "',ADMISSION_YEAR='" & txtadmyr.Text & "',DOB='" & txtdate.Value.Date & "',PICTURE=@PICTURE where COLLEGE_ID=" & Gridrowselect
        ''Dim acscmd As New OleDbCommand("Update tblstd set([Mr/Miss],[Full_Name],[Mother_Name],[DOB],[Gender],[MOB],[Email],[Aaddhar_No],[Category],[Sub_Caste],[Address],[Enrollment_No],[College_Name],[Branch],[Semester],[Date_of_Admission],[Picturefile])VALUES('" & cmbmrandmiss.SelectedItem & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & cmbgender.SelectedItem & "','" & txtmob.Text & "','" & txtemail.Text & "','" & txtaaddharno.Text & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & txtaddress.Text & "','" & txtenrollmentno.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & dateofadmissionpicker.Value.Date & "',@dtaname)", acsconn)
        ' ''olecommand.Parameters.AddWithValue("@ENROLLMENT_NO", txtenroll.Text)
        ' ''olecommand.Parameters.AddWithValue("@NAME", txtname.Text)
        ' ''olecommand.Parameters.AddWithValue("@BRANCH", cmbbranch.SelectedText)
        ' ''olecommand.Parameters.AddWithValue("@MOBILE_NUMBER", txtmob.Text)
        ' ''olecommand.Parameters.AddWithValue("@ADMISSION_YEAR", txtadmyr.Text)
        ' ''olecommand.Parameters.AddWithValue("@DOB", txtdate.Value.Date)
        '' ''====================================================================
        '' ''INSERT PHOTO
        '' '' Dim fsreader As New FileStream(PictureBox1., FileMode.Open, FileAccess.Read)
        '' '' If OpenFileDialog1.ShowDialog() = True Then

        ''If FileDialog = True Then
        ''    Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        ''    Dim breader As New BinaryReader(fsreader)
        ''    Dim imgbuffer(fsreader.Length) As Byte
        ''    breader.Read(imgbuffer, 0, fsreader.Length)
        ''    fsreader.Close()
        ''    olecommand.Parameters.AddWithValue("@PICTURE", imgbuffer)
        ''Else
        ''    'Dim fsreader As New FileStream("C:\Users\CO-04\Desktop\VS PRACTICALS\DATABASEAPP\PHOTOS\avtar.png", FileMode.Open)
        ''    Dim fsreader As New FileStream("C:\Users\KING_PC\Desktop\Student Record System\img.jpg", FileMode.Open)
        ''    Dim breader As New BinaryReader(fsreader)
        ''    Dim imgbuffer(fsreader.Length) As Byte
        ''    breader.Read(imgbuffer, 0, fsreader.Length)
        ''    fsreader.Close()
        ''    olecommand.Parameters.AddWithValue("@PICTURE", imgbuffer)
        ''End If

        '' ''End If

        '' ''=====================================================================
        '' '' olecommand.CommandText = acsconn
        ''olecommand.Connection = acsconn
        ''olecommand.ExecuteNonQuery()
        ' ''DataGridView.Refresh()
        '' ''Dim sda As New OleDbDataAdapter(SQLCOMMANDE)
        '' ''Dim dt As New DataTable()
        '' ''olda.Fill(dt)
        '' ''sda.Fill(ds, "TBLSTUDENTS")
        ' ''olda.SelectCommand = olecommand
        ' ''olda.Fill(ds, "TBLSTUDENTS")
        ' ''olda.Fill(dt)
        ' ''Dim img As New DataGridViewImageColumn()
        ' ''img = DataGridView1.Columns(7)
        ' ''img.ImageLayout = DataGridViewImageCellLayout.Stretch
        ' ''DataGridView1.DataSource = dt
        ''acsconn.Close()
        ''clear()
        ''DataGrid()
        ''MsgBox("RECORD ADDED SUCCESSFULLY")



        ''End If
        acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb")
        acsconn.Open()
        Dim acscmd As New OleDbCommand("Update tblstd set([Mr/Ms],[Full_Name],[Mother_Name],[DOB],[Gender],[MOB],[Email],[Aaddhar_No],[Category],[Sub_Caste],[Address],[Enrollment_No],[College_Name],[Branch],[Semester],[Date_of_Admission],[Picturefile])VALUES('" & cmbmrandmiss.SelectedItem & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & cmbgender.SelectedItem & "','" & txtmob.Text & "','" & txtemail.Text & "','" & txtaaddharno.Text & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & txtaddress.Text & "','" & txtenrollmentno.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & dateofadmissionpicker.Value.Date & "',@dtaname)", acsconn)
        'acscmd = New OleDbCommand, acsconn)
        'Dim fsreader As New FileStream(PictureBox1., FileMode.Open, FileAccess.Read)
        '' If OpenFileDialog1.ShowDialog() = True Then

        If FileDialog = True Then
            Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim breader As New BinaryReader(fsreader)
            Dim imgbuffer(fsreader.Length) As Byte
            breader.Read(imgbuffer, 0, fsreader.Length)
            fsreader.Close()
            acscmd.Parameters.AddWithValue("@PICTURE", imgbuffer)
        Else
            'Dim fsreader As New FileStream("C:\Users\CO-04\Desktop\VS PRACTICALS\DATABASEAPP\PHOTOS\avtar.png", FileMode.Open)
            Dim fsreader As New FileStream("C:\Users\KING_PC\Desktop\Student Record System\img.jpg", FileMode.Open)
            Dim breader As New BinaryReader(fsreader)
            Dim imgbuffer(fsreader.Length) As Byte
            breader.Read(imgbuffer, 0, fsreader.Length)
            fsreader.Close()
            acscmd.Parameters.AddWithValue("@PICTURE", imgbuffer)
        End If

        acscmd.ExecuteNonQuery()
        MessageBox.Show("Update Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()
        Me.bindgrid()
        acsconn.Close()



    End Sub

    Private Sub txtmob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmob.KeyPress
       

    End Sub

    Private Sub txtfullname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfullname.KeyPress

    End Sub

    Private Sub txtfullname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfullname.TextChanged

    End Sub

    Private Sub txtenrollmentno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtenrollmentno.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '    MsgBox("This is Not Number Plz enter Number ", MsgBoxStyle.Information)
        '    e.KeyChar = Nothing

        'End If
    End Sub

    Private Sub txtaaddharno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaaddharno.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '    MsgBox("this is Not Number Plz enter Number ", MsgBoxStyle.Information)
        '    e.KeyChar = Nothing

        'End If
    End Sub

    Private Sub DataGrid()
        Throw New NotImplementedException
    End Sub

    Private Sub clear()
        txtenrollmentno.Text = ""
        txtfullname.Text = ""
        txtmothername.Text = ""
        dobpiker.Text = ""
        txtmob.Text = ""
        txtemail.Text = ""
        cmbgender.SelectedItem = 1
        cmbbranch.SelectedItem = 1
        cmbsemester.SelectedItem = 1
        cmbmrandmiss.SelectedItem = 1

        txtaaddharno.Text = ""
        txtsubcaste.Text = ""
        txtaddress.Text = ""
        txtcollegename.Text = ""
        dateofadmissionpicker.Text = ""
        cmbmrandmiss.Focus()
    End Sub
    Private Sub bindgrid()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb")

        Dim oledbcommand As New OleDbCommand("select * from tblstd", con)
        oledbcommand.CommandType = CommandType.Text
        Dim olda As New OleDbDataAdapter(oledbcommand)
        Dim dt As New DataTable()
        olda.Fill(dt)
        '' DataGridView1.DataSource = dt


    End Sub

    Private Sub cmbsemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsemester.SelectedIndexChanged

    End Sub
End Class
