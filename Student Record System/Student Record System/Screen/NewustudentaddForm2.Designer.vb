<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewustudentaddForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewustudentaddForm2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbladdnewstudent = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateofadmissionpicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbmrandmiss = New System.Windows.Forms.ComboBox()
        Me.lblmrandmiss = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.lblSubcaste = New System.Windows.Forms.Label()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lblyearofadd = New System.Windows.Forms.Label()
        Me.cmbsemester = New System.Windows.Forms.ComboBox()
        Me.lblsemester = New System.Windows.Forms.Label()
        Me.cmbbranch = New System.Windows.Forms.ComboBox()
        Me.txtenrollmentno = New System.Windows.Forms.TextBox()
        Me.lblbranch = New System.Windows.Forms.Label()
        Me.lblenrollmentno = New System.Windows.Forms.Label()
        Me.txtcollegename = New System.Windows.Forms.TextBox()
        Me.lblcollegename = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtsubcaste = New System.Windows.Forms.TextBox()
        Me.txtaaddharno = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblaaddharno = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblmob = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.dobpiker = New System.Windows.Forms.DateTimePicker()
        Me.txtmothername = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.lblmothername = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnback = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lbladdnewstudent)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1383, 68)
        Me.Panel1.TabIndex = 0
        '
        'lbladdnewstudent
        '
        Me.lbladdnewstudent.AutoSize = True
        Me.lbladdnewstudent.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdnewstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbladdnewstudent.Location = New System.Drawing.Point(482, 23)
        Me.lbladdnewstudent.Name = "lbladdnewstudent"
        Me.lbladdnewstudent.Size = New System.Drawing.Size(414, 29)
        Me.lbladdnewstudent.TabIndex = 0
        Me.lbladdnewstudent.Text = "ADD NEW STUDENT RECORD"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox.BackgroundImage = CType(resources.GetObject("PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.ErrorImage = CType(resources.GetObject("PictureBox.ErrorImage"), System.Drawing.Image)
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(508, 74)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(126, 138)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 63
        Me.PictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dateofadmissionpicker)
        Me.GroupBox1.Controls.Add(Me.cmbmrandmiss)
        Me.GroupBox1.Controls.Add(Me.lblmrandmiss)
        Me.GroupBox1.Controls.Add(Me.cmbcategory)
        Me.GroupBox1.Controls.Add(Me.lblSubcaste)
        Me.GroupBox1.Controls.Add(Me.cmbgender)
        Me.GroupBox1.Controls.Add(Me.btnupload)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.lblyearofadd)
        Me.GroupBox1.Controls.Add(Me.PictureBox)
        Me.GroupBox1.Controls.Add(Me.cmbsemester)
        Me.GroupBox1.Controls.Add(Me.lblsemester)
        Me.GroupBox1.Controls.Add(Me.cmbbranch)
        Me.GroupBox1.Controls.Add(Me.txtenrollmentno)
        Me.GroupBox1.Controls.Add(Me.lblbranch)
        Me.GroupBox1.Controls.Add(Me.lblenrollmentno)
        Me.GroupBox1.Controls.Add(Me.txtcollegename)
        Me.GroupBox1.Controls.Add(Me.lblcollegename)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtsubcaste)
        Me.GroupBox1.Controls.Add(Me.txtaaddharno)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtmob)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.lblcategory)
        Me.GroupBox1.Controls.Add(Me.lblaaddharno)
        Me.GroupBox1.Controls.Add(Me.lbladdress)
        Me.GroupBox1.Controls.Add(Me.lblmob)
        Me.GroupBox1.Controls.Add(Me.lblgender)
        Me.GroupBox1.Controls.Add(Me.dobpiker)
        Me.GroupBox1.Controls.Add(Me.txtmothername)
        Me.GroupBox1.Controls.Add(Me.txtfullname)
        Me.GroupBox1.Controls.Add(Me.lblmothername)
        Me.GroupBox1.Controls.Add(Me.lblfullname)
        Me.GroupBox1.Controls.Add(Me.lbldob)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(353, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 595)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Information Screen"
        '
        'dateofadmissionpicker
        '
        Me.dateofadmissionpicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateofadmissionpicker.Location = New System.Drawing.Point(191, 494)
        Me.dateofadmissionpicker.Name = "dateofadmissionpicker"
        Me.dateofadmissionpicker.Size = New System.Drawing.Size(283, 22)
        Me.dateofadmissionpicker.TabIndex = 91
        '
        'cmbmrandmiss
        '
        Me.cmbmrandmiss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmrandmiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmrandmiss.FormattingEnabled = True
        Me.cmbmrandmiss.Items.AddRange(New Object() {"Select", "Mr.", "Mrs.", "Ms.", "Other"})
        Me.cmbmrandmiss.Location = New System.Drawing.Point(191, 33)
        Me.cmbmrandmiss.Name = "cmbmrandmiss"
        Me.cmbmrandmiss.Size = New System.Drawing.Size(283, 23)
        Me.cmbmrandmiss.TabIndex = 90
        '
        'lblmrandmiss
        '
        Me.lblmrandmiss.AutoSize = True
        Me.lblmrandmiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmrandmiss.Location = New System.Drawing.Point(57, 33)
        Me.lblmrandmiss.Name = "lblmrandmiss"
        Me.lblmrandmiss.Size = New System.Drawing.Size(55, 15)
        Me.lblmrandmiss.TabIndex = 89
        Me.lblmrandmiss.Text = "Mr/Ms :"
        '
        'cmbcategory
        '
        Me.cmbcategory.BackColor = System.Drawing.SystemColors.Info
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Select", "SC", "ST", "OBC", "General"})
        Me.cmbcategory.Location = New System.Drawing.Point(191, 279)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(283, 23)
        Me.cmbcategory.TabIndex = 88
        '
        'lblSubcaste
        '
        Me.lblSubcaste.AutoSize = True
        Me.lblSubcaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubcaste.Location = New System.Drawing.Point(57, 311)
        Me.lblSubcaste.Name = "lblSubcaste"
        Me.lblSubcaste.Size = New System.Drawing.Size(80, 15)
        Me.lblSubcaste.TabIndex = 87
        Me.lblSubcaste.Text = "Sub Caste :"
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.SystemColors.Info
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Select", "Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(191, 158)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(283, 24)
        Me.cmbgender.TabIndex = 86
        '
        'btnupload
        '
        Me.btnupload.BackColor = System.Drawing.Color.LightCoral
        Me.btnupload.Location = New System.Drawing.Point(508, 219)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(126, 28)
        Me.btnupload.TabIndex = 85
        Me.btnupload.Text = "Upload"
        Me.btnupload.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Location = New System.Drawing.Point(6, 524)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 56)
        Me.Panel2.TabIndex = 67
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.LightCoral
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdate.Location = New System.Drawing.Point(211, 11)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 37)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightCoral
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnclear.Location = New System.Drawing.Point(320, 11)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(103, 37)
        Me.btnclear.TabIndex = 6
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightCoral
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnexit.Location = New System.Drawing.Point(429, 11)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(103, 37)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightCoral
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsave.Location = New System.Drawing.Point(102, 11)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 37)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lblyearofadd
        '
        Me.lblyearofadd.AutoSize = True
        Me.lblyearofadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyearofadd.Location = New System.Drawing.Point(57, 494)
        Me.lblyearofadd.Name = "lblyearofadd"
        Me.lblyearofadd.Size = New System.Drawing.Size(131, 15)
        Me.lblyearofadd.TabIndex = 82
        Me.lblyearofadd.Text = "Date of Admission :"
        '
        'cmbsemester
        '
        Me.cmbsemester.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemester.FormattingEnabled = True
        Me.cmbsemester.Items.AddRange(New Object() {"Select", "1st Semester", "2st Semester", "3st Semester", "4st Semester", "5st Semester", "6st Semester"})
        Me.cmbsemester.Location = New System.Drawing.Point(191, 463)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.Size = New System.Drawing.Size(283, 23)
        Me.cmbsemester.TabIndex = 81
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.Location = New System.Drawing.Point(57, 463)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(76, 15)
        Me.lblsemester.TabIndex = 80
        Me.lblsemester.Text = "Semester :"
        '
        'cmbbranch
        '
        Me.cmbbranch.BackColor = System.Drawing.SystemColors.Info
        Me.cmbbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranch.FormattingEnabled = True
        Me.cmbbranch.Items.AddRange(New Object() {"Select", "Computer Engineering", "Information Technology", "Electrical Engineering", "Civil Engineering", "Mechanical Engineering", "Electronics Engineering"})
        Me.cmbbranch.Location = New System.Drawing.Point(191, 432)
        Me.cmbbranch.Name = "cmbbranch"
        Me.cmbbranch.Size = New System.Drawing.Size(283, 23)
        Me.cmbbranch.TabIndex = 79
        '
        'txtenrollmentno
        '
        Me.txtenrollmentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenrollmentno.Location = New System.Drawing.Point(191, 375)
        Me.txtenrollmentno.Name = "txtenrollmentno"
        Me.txtenrollmentno.Size = New System.Drawing.Size(283, 22)
        Me.txtenrollmentno.TabIndex = 78
        '
        'lblbranch
        '
        Me.lblbranch.AutoSize = True
        Me.lblbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblbranch.Location = New System.Drawing.Point(57, 432)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.Size = New System.Drawing.Size(60, 15)
        Me.lblbranch.TabIndex = 77
        Me.lblbranch.Text = "Branch :"
        '
        'lblenrollmentno
        '
        Me.lblenrollmentno.AutoSize = True
        Me.lblenrollmentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenrollmentno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblenrollmentno.Location = New System.Drawing.Point(57, 375)
        Me.lblenrollmentno.Name = "lblenrollmentno"
        Me.lblenrollmentno.Size = New System.Drawing.Size(107, 15)
        Me.lblenrollmentno.TabIndex = 76
        Me.lblenrollmentno.Text = "Enrollment No :"
        '
        'txtcollegename
        '
        Me.txtcollegename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcollegename.Location = New System.Drawing.Point(191, 403)
        Me.txtcollegename.Name = "txtcollegename"
        Me.txtcollegename.Size = New System.Drawing.Size(283, 21)
        Me.txtcollegename.TabIndex = 75
        '
        'lblcollegename
        '
        Me.lblcollegename.AutoSize = True
        Me.lblcollegename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollegename.Location = New System.Drawing.Point(57, 403)
        Me.lblcollegename.Name = "lblcollegename"
        Me.lblcollegename.Size = New System.Drawing.Size(106, 15)
        Me.lblcollegename.TabIndex = 74
        Me.lblcollegename.Text = "College Name :"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(191, 220)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(283, 21)
        Me.txtemail.TabIndex = 73
        '
        'txtsubcaste
        '
        Me.txtsubcaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubcaste.Location = New System.Drawing.Point(191, 311)
        Me.txtsubcaste.Name = "txtsubcaste"
        Me.txtsubcaste.Size = New System.Drawing.Size(283, 21)
        Me.txtsubcaste.TabIndex = 72
        '
        'txtaaddharno
        '
        Me.txtaaddharno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaaddharno.Location = New System.Drawing.Point(191, 249)
        Me.txtaaddharno.Name = "txtaaddharno"
        Me.txtaaddharno.Size = New System.Drawing.Size(283, 22)
        Me.txtaaddharno.TabIndex = 71
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(191, 337)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(283, 33)
        Me.txtaddress.TabIndex = 70
        '
        'txtmob
        '
        Me.txtmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmob.Location = New System.Drawing.Point(191, 191)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(283, 21)
        Me.txtmob.TabIndex = 69
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(57, 219)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(52, 15)
        Me.lblemail.TabIndex = 68
        Me.lblemail.Text = "Email :"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblcategory.Location = New System.Drawing.Point(57, 279)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(71, 15)
        Me.lblcategory.TabIndex = 67
        Me.lblcategory.Text = "Category :"
        '
        'lblaaddharno
        '
        Me.lblaaddharno.AutoSize = True
        Me.lblaaddharno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaaddharno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblaaddharno.Location = New System.Drawing.Point(57, 249)
        Me.lblaaddharno.Name = "lblaaddharno"
        Me.lblaaddharno.Size = New System.Drawing.Size(90, 15)
        Me.lblaaddharno.TabIndex = 66
        Me.lblaaddharno.Text = "Aaddhar No :"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbladdress.Location = New System.Drawing.Point(57, 337)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(66, 15)
        Me.lbladdress.TabIndex = 65
        Me.lbladdress.Text = "Address :"
        '
        'lblmob
        '
        Me.lblmob.AutoSize = True
        Me.lblmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmob.Location = New System.Drawing.Point(57, 191)
        Me.lblmob.Name = "lblmob"
        Me.lblmob.Size = New System.Drawing.Size(46, 15)
        Me.lblmob.TabIndex = 64
        Me.lblmob.Text = "MOB :"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(57, 158)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(62, 15)
        Me.lblgender.TabIndex = 61
        Me.lblgender.Text = "Gender :"
        '
        'dobpiker
        '
        Me.dobpiker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dobpiker.Location = New System.Drawing.Point(191, 128)
        Me.dobpiker.Name = "dobpiker"
        Me.dobpiker.Size = New System.Drawing.Size(283, 21)
        Me.dobpiker.TabIndex = 60
        Me.dobpiker.Value = New Date(2019, 3, 13, 11, 29, 55, 0)
        '
        'txtmothername
        '
        Me.txtmothername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmothername.Location = New System.Drawing.Point(191, 98)
        Me.txtmothername.Name = "txtmothername"
        Me.txtmothername.Size = New System.Drawing.Size(283, 21)
        Me.txtmothername.TabIndex = 59
        '
        'txtfullname
        '
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(191, 68)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(283, 22)
        Me.txtfullname.TabIndex = 58
        '
        'lblmothername
        '
        Me.lblmothername.AutoSize = True
        Me.lblmothername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmothername.Location = New System.Drawing.Point(57, 98)
        Me.lblmothername.Name = "lblmothername"
        Me.lblmothername.Size = New System.Drawing.Size(102, 15)
        Me.lblmothername.TabIndex = 57
        Me.lblmothername.Text = "Mother Name :"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfullname.Location = New System.Drawing.Point(57, 68)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(81, 15)
        Me.lblfullname.TabIndex = 56
        Me.lblfullname.Text = "Full Name :"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldob.Location = New System.Drawing.Point(57, 128)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(44, 15)
        Me.lbldob.TabIndex = 55
        Me.lbldob.Text = "DOB :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnback, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1380, 25)
        Me.ToolStrip1.TabIndex = 66
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnback
        '
        Me.btnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnback.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(36, 22)
        Me.btnback.Text = "Back"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NewustudentaddForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 750)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewustudentaddForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Student Record "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbladdnewstudent As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblyearofadd As System.Windows.Forms.Label
    Friend WithEvents cmbsemester As System.Windows.Forms.ComboBox
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents cmbbranch As System.Windows.Forms.ComboBox
    Friend WithEvents txtenrollmentno As System.Windows.Forms.TextBox
    Friend WithEvents lblbranch As System.Windows.Forms.Label
    Friend WithEvents lblenrollmentno As System.Windows.Forms.Label
    Friend WithEvents txtcollegename As System.Windows.Forms.TextBox
    Friend WithEvents lblcollegename As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtsubcaste As System.Windows.Forms.TextBox
    Friend WithEvents txtaaddharno As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents lblaaddharno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblmob As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents dobpiker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmothername As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents lblmothername As System.Windows.Forms.Label
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnback As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubcaste As System.Windows.Forms.Label
    Friend WithEvents cmbmrandmiss As System.Windows.Forms.ComboBox
    Friend WithEvents lblmrandmiss As System.Windows.Forms.Label
    Friend WithEvents dateofadmissionpicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
