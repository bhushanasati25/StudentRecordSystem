Imports System.Data.OleDb

Public Class LC

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblreligion.Click

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        ''Try
        Dim acsconn As New OleDbConnection
        ''acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBSTUDENT.mdb")
        acsconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb"
        acsconn.Open()
        ' Dim acscmd As New OleDbCommand("INSERT INTO tbl_LC([Registration_No],[Enrollment_No],[Name_of_Student],[Mother_Name],[Religion],[Category],[Sub_Caste],[Nationality],[Place_of_Birth],[Date_of_Birth],[last_Attended_School],[Date_of_Admission],[Progress],[Conduct],[Leaving_Date_of_Institute],[Year_in_Which_Studying_and_Since_When],[Reason_for_Leaving_Institute],[Remark])VALUES('" & txtregistrationno.Text & "','" & txtenrollmentno.Text & "','" & txtnameofstudent.Text & "','" & txtmothername.Text & "','" & cmbreligion.SelectedItem & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & cmbnationality.SelectedItem & "','" & txtplaceofbirth.Text & "','" & dobpicker.Value.Date & "','" & txtlastattendschool.Text & "','" & dateofadmissionpicker.Value.Date & "','" & cmbprogress.SelectedItem & "','" & txtconduct.Text & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & leavingdateofinstituepicker.Value.Date & "','" & txtyearinwhichstudyingandsincewhen.Text & "','" & txtreasonforleavinginstritute.Text & "','" & txtremark.Text & "')", acsconn)
        Dim acscmd As New OleDbCommand("INSERT INTO tbl_LC([Registration_No],[Enrollment_No],[Name_of_Student],[Mother_Name],[Religion],[Category],[Sub_Caste],[Nationality],[Place_of_Birth],[Date_of_Birth],[last_Attended_School],[Date_of_Admission],[Progress],[Conduct],[Leaving_Date_of_Institute],[Year_in_Which_Studying_and_Since_When],[Reason_for_Leaving_Institute],[Remark])VALUES('" & txtregistrationno.Text & "','" & txtenrollmentno.Text & "','" & txtnameofstudent.Text & "','" & txtmothername.Text & "','" & cmbreligion.SelectedItem & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & cmbnationality.SelectedItem & "','" & txtplaceofbirth.Text & "','" & dobpicker.Value.Date & "','" & txtlastattendschool.Text & "','" & dateofadmissionpicker.Value.Date & "','" & cmbprogress.SelectedItem & "','" & txtconduct.Text & "','" & leavingdateofinstituepicker.Value.Date & "','" & txtyearinwhichstudyingandsincewhen.Text & "','" & txtreasonforleavinginstritute.Text & "','" & txtremark.Text & "')", acsconn)
        'acscmd.CommandType = CommandType.Text
        '' strsql = "INSERT INTO TBLDBSTUDENT(Enrollment_No,Full_Name,Mother_Name,DOB,MOB,Gender,Email,Aaddhar_No,Caste,Address,College_Name,Branch,Semester,Year_of_Admission,picturefile)values('" & txtenrollmentno.Text & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & txtmob.Text & '", & cmbgender.SelectedItem & "' & txtemail.Text & "','" & txtaaddharno.Text & "','" & txtcaste.Text & "','" & txtaddress.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & txtyearofadmission.Text & "',@dtaname)"
        ''strsql =
        ''acscmd.CommandText = strsql
        '' acscmd.Connection = acsconn
        ' acscmd.Parameters.AddWithValue("@dtaname", txtfilename.Text)
        '' =============================================================================
        ''ADDINTING PHOTO
        'Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        'Dim breader As New BinaryReader(fsreader)
        'Dim imgbuffer(fsreader.Length) As Byte
        'breader.Read(imgbuffer, 0, fsreader.Length)
        'fsreader.Close()
        'acscmd.Parameters.AddWithValue("@dtafile", imgbuffer)
        ''============================================================================================
        acscmd.ExecuteNonQuery()
        ''acscmd.Dispose()
        clear()
        MessageBox.Show("Data Added Successfull..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()
        '' Catch ex As Exception

        ''End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        DashBoardForm4.Show()
        Me.Close()

    End Sub

    Private Sub btngenratereport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenratereport.Click
        Leaving_Certificate_form.Show()
        Me.Close()
       
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        DashBoardForm4.Show()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.txtregistrationno.Text = ""
        Me.txtenrollmentno.Text = ""
        Me.txtnameofstudent.Text = ""
        Me.txtmothername.Text = ""
        Me.cmbreligion.SelectedItem.text = ""
        Me.cmbcategory.SelectedItem.text = ""
        Me.txtsubcaste.Text = ""
        Me.cmbnationality.SelectedItem.text = ""
        Me.txtplaceofbirth.Text = ""
        Me.dobpicker.Text = ""
        Me.txtlastattendschool.Text = ""
        Me.dateofadmissionpicker.Text = ""
        Me.cmbprogress.SelectedItem.Text = ""
        Me.txtconduct.Text = ""
        Me.leavingdateofinstituepicker.Text = ""
        Me.txtyearinwhichstudyingandsincewhen.Text = ""
        Me.txtreasonforleavinginstritute.Text = ""
        Me.txtremark.Text = ""
        Me.txtregistrationno.Focus()

    End Sub
    Private Sub clear()
        txtregistrationno.Text = ""
        txtenrollmentno.Text = ""
        txtnameofstudent.Text = ""
        txtmothername.Text = ""
        cmbreligion.SelectedIndex = 0
        cmbcategory.SelectedIndex = 0
        txtsubcaste.Text = ""
        cmbnationality.SelectedIndex = 0
        txtplaceofbirth.Text = ""
        dobpicker.Text = ""
        txtlastattendschool.Text = ""
        dateofadmissionpicker.Text = ""
        cmbprogress.SelectedIndex = 0
        txtconduct.Text = ""
        leavingdateofinstituepicker.Text = ""
        txtyearinwhichstudyingandsincewhen.Text = ""
        txtreasonforleavinginstritute.Text = ""
        txtremark.Text = ""
        txtregistrationno.Focus()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        acsconn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Polytechnic Work\2nd Year\4th Sem\Micro Porject\VB.NET\Project\Student Record System\DATABASE\DBSTUDENT.mdb")
        acsconn.Open()
        'Dim acscmd As New OleDbCommand("Update tblstd set([Mr/Miss],[Full_Name],[Mother_Name],[DOB],[Gender],[MOB],[Email],[Aaddhar_No],[Category],[Sub_Caste],[Address],[Enrollment_No],[College_Name],[Branch],[Semester],[Date_of_Admission],[Picturefile])VALUES('" & cmbmrandmiss.SelectedItem & "','" & txtfullname.Text & "','" & txtmothername.Text & "','" & dobpiker.Value.Date & "','" & cmbgender.SelectedItem & "','" & txtmob.Text & "','" & txtemail.Text & "','" & txtaaddharno.Text & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & txtaddress.Text & "','" & txtenrollmentno.Text & "','" & txtcollegename.Text & "','" & cmbbranch.SelectedItem & "','" & cmbsemester.SelectedItem & "','" & dateofadmissionpicker.Value.Date & "',@dtaname)", acsconn)
        Dim acscmd As New OleDbCommand("INSERT INTO tbl_LC([Registration_No],[Enrollment_No],[Name_of_Student],[Mother_Name],[Religion],[Category],[Sub_Caste],[Nationality],[Place_of_Birth],[Date_of_Birth],[last_Attended_School],[Date_of_Admission],[Progress],[Conduct],[Leaving_Date_of_Institute],[Year_in_Which_Studying_and_Since_When],[Reason_for_Leaving_Institute],[Remark])VALUES('" & txtregistrationno.Text & "','" & txtenrollmentno.Text & "','" & txtnameofstudent.Text & "','" & txtmothername.Text & "','" & cmbreligion.SelectedItem & "','" & cmbcategory.SelectedItem & "','" & txtsubcaste.Text & "','" & cmbnationality.SelectedItem & "','" & txtplaceofbirth.Text & "','" & dobpicker.Value.Date & "','" & txtlastattendschool.Text & "','" & dateofadmissionpicker.Value.Date & "','" & cmbprogress.SelectedItem & "','" & txtconduct.Text & "','" & leavingdateofinstituepicker.Value.Date & "','" & txtyearinwhichstudyingandsincewhen.Text & "','" & txtreasonforleavinginstritute.Text & "','" & txtremark.Text & "')", acsconn)
        'acscmd = New OleDbCommand, acsconn)
        'Dim fsreader As New FileStream(PictureBox1., FileMode.Open, FileAccess.Read)
        '' If OpenFileDialog1.ShowDialog() = True Then

        'If FileDialog = True Then
        '    Dim fsreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        '    Dim breader As New BinaryReader(fsreader)
        '    Dim imgbuffer(fsreader.Length) As Byte
        '    breader.Read(imgbuffer, 0, fsreader.Length)
        '    fsreader.Close()
        '    acscmd.Parameters.AddWithValue("@PICTURE", imgbuffer)
        'Else
        'Dim fsreader As New FileStream("C:\Users\CO-04\Desktop\VS PRACTICALS\DATABASEAPP\PHOTOS\avtar.png", FileMode.Open)
        'Dim fsreader As New FileStream("C:\Users\KING_PC\Desktop\Student Record System\img.jpg", FileMode.Open)
        'Dim breader As New BinaryReader(fsreader)
        'Dim imgbuffer(fsreader.Length) As Byte
        'breader.Read(imgbuffer, 0, fsreader.Length)
        'fsreader.Close()
        'acscmd.Parameters.AddWithValue("@PICTURE", imgbuffer)
        'End If

        acscmd.ExecuteNonQuery()
        MessageBox.Show("Update Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()

    End Sub

    Private Sub LC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtregistrationno.Text = ""
        txtenrollmentno.Text = ""
        txtnameofstudent.Text = ""
        txtmothername.Text = ""
        cmbreligion.SelectedIndex = 0
        cmbcategory.SelectedIndex = 0
        txtsubcaste.Text = ""
        cmbnationality.SelectedIndex = 0
        txtplaceofbirth.Text = ""
        dobpicker.Text = ""
        txtlastattendschool.Text = ""
        dateofadmissionpicker.Text = ""
        cmbprogress.SelectedIndex = 0
        txtconduct.Text = ""
        leavingdateofinstituepicker.Text = ""
        txtyearinwhichstudyingandsincewhen.Text = ""
        txtreasonforleavinginstritute.Text = ""
        txtremark.Text = ""
        txtregistrationno.Focus()
    End Sub
End Class