<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LC))
        Me.lblreligion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.leavingdateofinstituepicker = New System.Windows.Forms.DateTimePicker()
        Me.dateofadmissionpicker = New System.Windows.Forms.DateTimePicker()
        Me.lblyearofadmission = New System.Windows.Forms.Label()
        Me.dobpicker = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtsubcaste = New System.Windows.Forms.TextBox()
        Me.lblsubcaste = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.txtmothername = New System.Windows.Forms.TextBox()
        Me.lblmothername = New System.Windows.Forms.Label()
        Me.txtnameofstudent = New System.Windows.Forms.TextBox()
        Me.lblnameofstudent = New System.Windows.Forms.Label()
        Me.txtenrollmentno = New System.Windows.Forms.TextBox()
        Me.lblenrollmentno = New System.Windows.Forms.Label()
        Me.txtregistrationno = New System.Windows.Forms.TextBox()
        Me.lblregistrationno = New System.Windows.Forms.Label()
        Me.txtyearinwhichstudyingandsincewhen = New System.Windows.Forms.TextBox()
        Me.lblyearinwhichstudyingandsincewhen = New System.Windows.Forms.Label()
        Me.txtremark = New System.Windows.Forms.TextBox()
        Me.lblremark = New System.Windows.Forms.Label()
        Me.txtreasonforleavinginstritute = New System.Windows.Forms.TextBox()
        Me.lblreasonforleavinginstitute = New System.Windows.Forms.Label()
        Me.lblleavingdateofinstitute = New System.Windows.Forms.Label()
        Me.txtconduct = New System.Windows.Forms.TextBox()
        Me.lblconduct = New System.Windows.Forms.Label()
        Me.cmbprogress = New System.Windows.Forms.ComboBox()
        Me.lblprogress = New System.Windows.Forms.Label()
        Me.txtlastattendschool = New System.Windows.Forms.TextBox()
        Me.lbllastattendschool = New System.Windows.Forms.Label()
        Me.txtplaceofbirth = New System.Windows.Forms.TextBox()
        Me.lblplaceofbirth = New System.Windows.Forms.Label()
        Me.cmbnationality = New System.Windows.Forms.ComboBox()
        Me.lblnationality = New System.Windows.Forms.Label()
        Me.cmbreligion = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnback = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btngenratereport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblreligion
        '
        Me.lblreligion.AutoSize = True
        Me.lblreligion.Location = New System.Drawing.Point(43, 136)
        Me.lblreligion.Name = "lblreligion"
        Me.lblreligion.Size = New System.Drawing.Size(61, 15)
        Me.lblreligion.TabIndex = 0
        Me.lblreligion.Text = "Religion"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnexit)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.leavingdateofinstituepicker)
        Me.GroupBox1.Controls.Add(Me.dateofadmissionpicker)
        Me.GroupBox1.Controls.Add(Me.lblyearofadmission)
        Me.GroupBox1.Controls.Add(Me.dobpicker)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.txtsubcaste)
        Me.GroupBox1.Controls.Add(Me.lblsubcaste)
        Me.GroupBox1.Controls.Add(Me.cmbcategory)
        Me.GroupBox1.Controls.Add(Me.lblcategory)
        Me.GroupBox1.Controls.Add(Me.txtmothername)
        Me.GroupBox1.Controls.Add(Me.lblmothername)
        Me.GroupBox1.Controls.Add(Me.txtnameofstudent)
        Me.GroupBox1.Controls.Add(Me.lblnameofstudent)
        Me.GroupBox1.Controls.Add(Me.txtenrollmentno)
        Me.GroupBox1.Controls.Add(Me.lblenrollmentno)
        Me.GroupBox1.Controls.Add(Me.txtregistrationno)
        Me.GroupBox1.Controls.Add(Me.lblregistrationno)
        Me.GroupBox1.Controls.Add(Me.txtyearinwhichstudyingandsincewhen)
        Me.GroupBox1.Controls.Add(Me.lblyearinwhichstudyingandsincewhen)
        Me.GroupBox1.Controls.Add(Me.txtremark)
        Me.GroupBox1.Controls.Add(Me.lblremark)
        Me.GroupBox1.Controls.Add(Me.txtreasonforleavinginstritute)
        Me.GroupBox1.Controls.Add(Me.lblreasonforleavinginstitute)
        Me.GroupBox1.Controls.Add(Me.lblleavingdateofinstitute)
        Me.GroupBox1.Controls.Add(Me.txtconduct)
        Me.GroupBox1.Controls.Add(Me.lblconduct)
        Me.GroupBox1.Controls.Add(Me.cmbprogress)
        Me.GroupBox1.Controls.Add(Me.lblprogress)
        Me.GroupBox1.Controls.Add(Me.txtlastattendschool)
        Me.GroupBox1.Controls.Add(Me.lbllastattendschool)
        Me.GroupBox1.Controls.Add(Me.txtplaceofbirth)
        Me.GroupBox1.Controls.Add(Me.lblplaceofbirth)
        Me.GroupBox1.Controls.Add(Me.cmbnationality)
        Me.GroupBox1.Controls.Add(Me.lblnationality)
        Me.GroupBox1.Controls.Add(Me.cmbreligion)
        Me.GroupBox1.Controls.Add(Me.lblreligion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(405, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 602)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leaving Certificate"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightCoral
        Me.btnclear.Location = New System.Drawing.Point(315, 549)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(102, 35)
        Me.btnclear.TabIndex = 41
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.LightCoral
        Me.btnupdate.Location = New System.Drawing.Point(200, 549)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(102, 35)
        Me.btnupdate.TabIndex = 40
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightCoral
        Me.btnexit.Location = New System.Drawing.Point(423, 549)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(102, 35)
        Me.btnexit.TabIndex = 39
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightCoral
        Me.btnsave.Location = New System.Drawing.Point(82, 549)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(102, 35)
        Me.btnsave.TabIndex = 38
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'leavingdateofinstituepicker
        '
        Me.leavingdateofinstituepicker.Location = New System.Drawing.Point(235, 414)
        Me.leavingdateofinstituepicker.Name = "leavingdateofinstituepicker"
        Me.leavingdateofinstituepicker.Size = New System.Drawing.Size(287, 21)
        Me.leavingdateofinstituepicker.TabIndex = 37
        '
        'dateofadmissionpicker
        '
        Me.dateofadmissionpicker.Location = New System.Drawing.Point(235, 331)
        Me.dateofadmissionpicker.Name = "dateofadmissionpicker"
        Me.dateofadmissionpicker.Size = New System.Drawing.Size(287, 21)
        Me.dateofadmissionpicker.TabIndex = 36
        '
        'lblyearofadmission
        '
        Me.lblyearofadmission.AutoSize = True
        Me.lblyearofadmission.Location = New System.Drawing.Point(43, 331)
        Me.lblyearofadmission.Name = "lblyearofadmission"
        Me.lblyearofadmission.Size = New System.Drawing.Size(123, 15)
        Me.lblyearofadmission.TabIndex = 35
        Me.lblyearofadmission.Text = "Date of Admission"
        '
        'dobpicker
        '
        Me.dobpicker.Location = New System.Drawing.Point(235, 277)
        Me.dobpicker.Name = "dobpicker"
        Me.dobpicker.Size = New System.Drawing.Size(287, 21)
        Me.dobpicker.TabIndex = 34
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(43, 277)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(87, 15)
        Me.lblDOB.TabIndex = 33
        Me.lblDOB.Text = "Date of Birth"
        '
        'txtsubcaste
        '
        Me.txtsubcaste.Location = New System.Drawing.Point(235, 194)
        Me.txtsubcaste.Name = "txtsubcaste"
        Me.txtsubcaste.Size = New System.Drawing.Size(289, 21)
        Me.txtsubcaste.TabIndex = 32
        '
        'lblsubcaste
        '
        Me.lblsubcaste.AutoSize = True
        Me.lblsubcaste.Location = New System.Drawing.Point(43, 194)
        Me.lblsubcaste.Name = "lblsubcaste"
        Me.lblsubcaste.Size = New System.Drawing.Size(72, 15)
        Me.lblsubcaste.TabIndex = 31
        Me.lblsubcaste.Text = "Sub Caste"
        '
        'cmbcategory
        '
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Select", "General", "SC", "ST", "OBC", "Other"})
        Me.cmbcategory.Location = New System.Drawing.Point(235, 165)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(289, 23)
        Me.cmbcategory.TabIndex = 30
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Location = New System.Drawing.Point(43, 165)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(63, 15)
        Me.lblcategory.TabIndex = 29
        Me.lblcategory.Text = "Category"
        '
        'txtmothername
        '
        Me.txtmothername.Location = New System.Drawing.Point(235, 109)
        Me.txtmothername.Name = "txtmothername"
        Me.txtmothername.Size = New System.Drawing.Size(289, 21)
        Me.txtmothername.TabIndex = 28
        '
        'lblmothername
        '
        Me.lblmothername.AutoSize = True
        Me.lblmothername.Location = New System.Drawing.Point(43, 109)
        Me.lblmothername.Name = "lblmothername"
        Me.lblmothername.Size = New System.Drawing.Size(94, 15)
        Me.lblmothername.TabIndex = 27
        Me.lblmothername.Text = "Mother Name"
        '
        'txtnameofstudent
        '
        Me.txtnameofstudent.Location = New System.Drawing.Point(235, 82)
        Me.txtnameofstudent.Name = "txtnameofstudent"
        Me.txtnameofstudent.Size = New System.Drawing.Size(289, 21)
        Me.txtnameofstudent.TabIndex = 26
        '
        'lblnameofstudent
        '
        Me.lblnameofstudent.AutoSize = True
        Me.lblnameofstudent.Location = New System.Drawing.Point(43, 82)
        Me.lblnameofstudent.Name = "lblnameofstudent"
        Me.lblnameofstudent.Size = New System.Drawing.Size(114, 15)
        Me.lblnameofstudent.TabIndex = 25
        Me.lblnameofstudent.Text = "Name of Student"
        '
        'txtenrollmentno
        '
        Me.txtenrollmentno.Location = New System.Drawing.Point(235, 56)
        Me.txtenrollmentno.Name = "txtenrollmentno"
        Me.txtenrollmentno.Size = New System.Drawing.Size(289, 21)
        Me.txtenrollmentno.TabIndex = 24
        '
        'lblenrollmentno
        '
        Me.lblenrollmentno.AutoSize = True
        Me.lblenrollmentno.Location = New System.Drawing.Point(43, 56)
        Me.lblenrollmentno.Name = "lblenrollmentno"
        Me.lblenrollmentno.Size = New System.Drawing.Size(99, 15)
        Me.lblenrollmentno.TabIndex = 23
        Me.lblenrollmentno.Text = "Enrollment No"
        '
        'txtregistrationno
        '
        Me.txtregistrationno.Location = New System.Drawing.Point(235, 29)
        Me.txtregistrationno.Name = "txtregistrationno"
        Me.txtregistrationno.Size = New System.Drawing.Size(289, 21)
        Me.txtregistrationno.TabIndex = 22
        '
        'lblregistrationno
        '
        Me.lblregistrationno.AutoSize = True
        Me.lblregistrationno.Location = New System.Drawing.Point(43, 29)
        Me.lblregistrationno.Name = "lblregistrationno"
        Me.lblregistrationno.Size = New System.Drawing.Size(107, 15)
        Me.lblregistrationno.TabIndex = 21
        Me.lblregistrationno.Text = "Registration No"
        '
        'txtyearinwhichstudyingandsincewhen
        '
        Me.txtyearinwhichstudyingandsincewhen.Location = New System.Drawing.Point(235, 441)
        Me.txtyearinwhichstudyingandsincewhen.Name = "txtyearinwhichstudyingandsincewhen"
        Me.txtyearinwhichstudyingandsincewhen.Size = New System.Drawing.Size(289, 21)
        Me.txtyearinwhichstudyingandsincewhen.TabIndex = 20
        '
        'lblyearinwhichstudyingandsincewhen
        '
        Me.lblyearinwhichstudyingandsincewhen.AutoSize = True
        Me.lblyearinwhichstudyingandsincewhen.Location = New System.Drawing.Point(43, 441)
        Me.lblyearinwhichstudyingandsincewhen.Name = "lblyearinwhichstudyingandsincewhen"
        Me.lblyearinwhichstudyingandsincewhen.Size = New System.Drawing.Size(150, 30)
        Me.lblyearinwhichstudyingandsincewhen.TabIndex = 19
        Me.lblyearinwhichstudyingandsincewhen.Text = "Year in which studying" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and since when"
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(235, 515)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(289, 21)
        Me.txtremark.TabIndex = 18
        '
        'lblremark
        '
        Me.lblremark.AutoSize = True
        Me.lblremark.Location = New System.Drawing.Point(43, 515)
        Me.lblremark.Name = "lblremark"
        Me.lblremark.Size = New System.Drawing.Size(57, 15)
        Me.lblremark.TabIndex = 17
        Me.lblremark.Text = "Remark"
        '
        'txtreasonforleavinginstritute
        '
        Me.txtreasonforleavinginstritute.Location = New System.Drawing.Point(235, 478)
        Me.txtreasonforleavinginstritute.Name = "txtreasonforleavinginstritute"
        Me.txtreasonforleavinginstritute.Size = New System.Drawing.Size(289, 21)
        Me.txtreasonforleavinginstritute.TabIndex = 16
        '
        'lblreasonforleavinginstitute
        '
        Me.lblreasonforleavinginstitute.AutoSize = True
        Me.lblreasonforleavinginstitute.Location = New System.Drawing.Point(43, 484)
        Me.lblreasonforleavinginstitute.Name = "lblreasonforleavinginstitute"
        Me.lblreasonforleavinginstitute.Size = New System.Drawing.Size(186, 15)
        Me.lblreasonforleavinginstitute.TabIndex = 15
        Me.lblreasonforleavinginstitute.Text = "Reason for Leaving Institute"
        '
        'lblleavingdateofinstitute
        '
        Me.lblleavingdateofinstitute.AutoSize = True
        Me.lblleavingdateofinstitute.Location = New System.Drawing.Point(43, 414)
        Me.lblleavingdateofinstitute.Name = "lblleavingdateofinstitute"
        Me.lblleavingdateofinstitute.Size = New System.Drawing.Size(162, 15)
        Me.lblleavingdateofinstitute.TabIndex = 13
        Me.lblleavingdateofinstitute.Text = "Leaving Date of Institute"
        '
        'txtconduct
        '
        Me.txtconduct.Location = New System.Drawing.Point(235, 387)
        Me.txtconduct.Name = "txtconduct"
        Me.txtconduct.Size = New System.Drawing.Size(289, 21)
        Me.txtconduct.TabIndex = 12
        '
        'lblconduct
        '
        Me.lblconduct.AutoSize = True
        Me.lblconduct.Location = New System.Drawing.Point(43, 387)
        Me.lblconduct.Name = "lblconduct"
        Me.lblconduct.Size = New System.Drawing.Size(59, 15)
        Me.lblconduct.TabIndex = 11
        Me.lblconduct.Text = "Conduct"
        '
        'cmbprogress
        '
        Me.cmbprogress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprogress.FormattingEnabled = True
        Me.cmbprogress.Items.AddRange(New Object() {"Select", "Excellent", "Good", "Satisfactory"})
        Me.cmbprogress.Location = New System.Drawing.Point(235, 358)
        Me.cmbprogress.Name = "cmbprogress"
        Me.cmbprogress.Size = New System.Drawing.Size(287, 23)
        Me.cmbprogress.TabIndex = 10
        '
        'lblprogress
        '
        Me.lblprogress.AutoSize = True
        Me.lblprogress.Location = New System.Drawing.Point(43, 358)
        Me.lblprogress.Name = "lblprogress"
        Me.lblprogress.Size = New System.Drawing.Size(64, 15)
        Me.lblprogress.TabIndex = 9
        Me.lblprogress.Text = "Progress"
        '
        'txtlastattendschool
        '
        Me.txtlastattendschool.Location = New System.Drawing.Point(235, 304)
        Me.txtlastattendschool.Name = "txtlastattendschool"
        Me.txtlastattendschool.Size = New System.Drawing.Size(289, 21)
        Me.txtlastattendschool.TabIndex = 7
        '
        'lbllastattendschool
        '
        Me.lbllastattendschool.AutoSize = True
        Me.lbllastattendschool.Location = New System.Drawing.Point(43, 304)
        Me.lbllastattendschool.Name = "lbllastattendschool"
        Me.lbllastattendschool.Size = New System.Drawing.Size(126, 15)
        Me.lbllastattendschool.TabIndex = 6
        Me.lbllastattendschool.Text = "Last Attend School"
        '
        'txtplaceofbirth
        '
        Me.txtplaceofbirth.Location = New System.Drawing.Point(235, 250)
        Me.txtplaceofbirth.Name = "txtplaceofbirth"
        Me.txtplaceofbirth.Size = New System.Drawing.Size(289, 21)
        Me.txtplaceofbirth.TabIndex = 5
        '
        'lblplaceofbirth
        '
        Me.lblplaceofbirth.AutoSize = True
        Me.lblplaceofbirth.Location = New System.Drawing.Point(43, 250)
        Me.lblplaceofbirth.Name = "lblplaceofbirth"
        Me.lblplaceofbirth.Size = New System.Drawing.Size(93, 15)
        Me.lblplaceofbirth.TabIndex = 4
        Me.lblplaceofbirth.Text = "Place of Birth"
        '
        'cmbnationality
        '
        Me.cmbnationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnationality.FormattingEnabled = True
        Me.cmbnationality.Items.AddRange(New Object() {"Select", "Indian"})
        Me.cmbnationality.Location = New System.Drawing.Point(235, 221)
        Me.cmbnationality.Name = "cmbnationality"
        Me.cmbnationality.Size = New System.Drawing.Size(289, 23)
        Me.cmbnationality.TabIndex = 3
        '
        'lblnationality
        '
        Me.lblnationality.AutoSize = True
        Me.lblnationality.Location = New System.Drawing.Point(43, 221)
        Me.lblnationality.Name = "lblnationality"
        Me.lblnationality.Size = New System.Drawing.Size(75, 15)
        Me.lblnationality.TabIndex = 2
        Me.lblnationality.Text = "Nationality"
        '
        'cmbreligion
        '
        Me.cmbreligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreligion.FormattingEnabled = True
        Me.cmbreligion.Items.AddRange(New Object() {"Select", "Hindu", "Buddhism", "Christianity", "Sikhism", "Islam", "Other"})
        Me.cmbreligion.Location = New System.Drawing.Point(235, 136)
        Me.cmbreligion.Name = "cmbreligion"
        Me.cmbreligion.Size = New System.Drawing.Size(289, 23)
        Me.cmbreligion.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnback, Me.ToolStripSeparator1, Me.btngenratereport, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1380, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnback
        '
        Me.btnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(36, 22)
        Me.btnback.Text = "Back"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btngenratereport
        '
        Me.btngenratereport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btngenratereport.Image = CType(resources.GetObject("btngenratereport.Image"), System.Drawing.Image)
        Me.btngenratereport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btngenratereport.Name = "btngenratereport"
        Me.btngenratereport.Size = New System.Drawing.Size(71, 22)
        Me.btngenratereport.Text = "Genrate_LC"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 58)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(518, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LEAVING CERTIFICATE"
        '
        'LC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaving Certificate Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblreligion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbprogress As System.Windows.Forms.ComboBox
    Friend WithEvents lblprogress As System.Windows.Forms.Label
    Friend WithEvents txtlastattendschool As System.Windows.Forms.TextBox
    Friend WithEvents lbllastattendschool As System.Windows.Forms.Label
    Friend WithEvents txtplaceofbirth As System.Windows.Forms.TextBox
    Friend WithEvents lblplaceofbirth As System.Windows.Forms.Label
    Friend WithEvents cmbnationality As System.Windows.Forms.ComboBox
    Friend WithEvents lblnationality As System.Windows.Forms.Label
    Friend WithEvents cmbreligion As System.Windows.Forms.ComboBox
    Friend WithEvents lblconduct As System.Windows.Forms.Label
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents lblremark As System.Windows.Forms.Label
    Friend WithEvents txtreasonforleavinginstritute As System.Windows.Forms.TextBox
    Friend WithEvents lblreasonforleavinginstitute As System.Windows.Forms.Label
    Friend WithEvents lblleavingdateofinstitute As System.Windows.Forms.Label
    Friend WithEvents txtconduct As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtyearinwhichstudyingandsincewhen As System.Windows.Forms.TextBox
    Friend WithEvents lblyearinwhichstudyingandsincewhen As System.Windows.Forms.Label
    Friend WithEvents leavingdateofinstituepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateofadmissionpicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblyearofadmission As System.Windows.Forms.Label
    Friend WithEvents dobpicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtsubcaste As System.Windows.Forms.TextBox
    Friend WithEvents lblsubcaste As System.Windows.Forms.Label
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents txtmothername As System.Windows.Forms.TextBox
    Friend WithEvents lblmothername As System.Windows.Forms.Label
    Friend WithEvents txtnameofstudent As System.Windows.Forms.TextBox
    Friend WithEvents lblnameofstudent As System.Windows.Forms.Label
    Friend WithEvents txtenrollmentno As System.Windows.Forms.TextBox
    Friend WithEvents lblenrollmentno As System.Windows.Forms.Label
    Friend WithEvents txtregistrationno As System.Windows.Forms.TextBox
    Friend WithEvents lblregistrationno As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btngenratereport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
