<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendSMS))
        Me.txtPDSNO = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFloor = New System.Windows.Forms.ComboBox
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.txtMessage = New System.Windows.Forms.RichTextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lvReceiver = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveAll = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblcountReceiver = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtConsole = New System.Windows.Forms.RichTextBox
        Me.lblEnterp = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.grpSpecial = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtContactno = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.picSend = New System.Windows.Forms.PictureBox
        Me.chkLocked = New System.Windows.Forms.CheckBox
        Me.ssMessage = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstTxtCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstSuccess = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstFail = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblPDSNO = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.grpSpecial.SuspendLayout()
        CType(Me.picSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssMessage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPDSNO
        '
        Me.txtPDSNO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDSNO.Location = New System.Drawing.Point(132, 47)
        Me.txtPDSNO.MaxLength = 15
        Me.txtPDSNO.Name = "txtPDSNO"
        Me.txtPDSNO.Size = New System.Drawing.Size(254, 26)
        Me.txtPDSNO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Template:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(390, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description:"
        '
        'cboFloor
        '
        Me.cboFloor.DropDownHeight = 500
        Me.cboFloor.DropDownWidth = 500
        Me.cboFloor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.IntegralHeight = False
        Me.cboFloor.Location = New System.Drawing.Point(8, 213)
        Me.cboFloor.MaxDropDownItems = 99
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(378, 27)
        Me.cboFloor.TabIndex = 9
        '
        'cboLocation
        '
        Me.cboLocation.DropDownHeight = 500
        Me.cboLocation.DropDownWidth = 500
        Me.cboLocation.Enabled = False
        Me.cboLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.IntegralHeight = False
        Me.cboLocation.Location = New System.Drawing.Point(394, 212)
        Me.cboLocation.MaxDropDownItems = 99
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(343, 27)
        Me.cboLocation.TabIndex = 10
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(6, 245)
        Me.txtMessage.MaxLength = 2500
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(729, 128)
        Me.txtMessage.TabIndex = 13
        Me.txtMessage.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(741, 339)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 34)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lvReceiver
        '
        Me.lvReceiver.AllowDrop = True
        Me.lvReceiver.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvReceiver.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvReceiver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiver.FullRowSelect = True
        Me.lvReceiver.GridLines = True
        Me.lvReceiver.Location = New System.Drawing.Point(6, 379)
        Me.lvReceiver.Name = "lvReceiver"
        Me.lvReceiver.Size = New System.Drawing.Size(796, 230)
        Me.lvReceiver.TabIndex = 56
        Me.lvReceiver.Tag = ""
        Me.lvReceiver.UseCompatibleStateImageBehavior = False
        Me.lvReceiver.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PDSNO"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Full Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ContactNo."
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Message"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 300
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Template"
        Me.ColumnHeader5.Width = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(6, 615)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(61, 49)
        Me.btnRemoveAll.TabIndex = 57
        Me.btnRemoveAll.Text = "Clear"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(658, 615)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "List Count:"
        '
        'lblcountReceiver
        '
        Me.lblcountReceiver.AutoSize = True
        Me.lblcountReceiver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountReceiver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcountReceiver.Location = New System.Drawing.Point(768, 615)
        Me.lblcountReceiver.Name = "lblcountReceiver"
        Me.lblcountReceiver.Size = New System.Drawing.Size(18, 19)
        Me.lblcountReceiver.TabIndex = 63
        Me.lblcountReceiver.Text = "0"
        Me.lblcountReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsole.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtConsole.Location = New System.Drawing.Point(6, 50)
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.Size = New System.Drawing.Size(545, 579)
        Me.txtConsole.TabIndex = 122
        Me.txtConsole.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtConsole, "Message Console Log")
        '
        'lblEnterp
        '
        Me.lblEnterp.AutoSize = True
        Me.lblEnterp.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterp.ForeColor = System.Drawing.Color.White
        Me.lblEnterp.Location = New System.Drawing.Point(150, 625)
        Me.lblEnterp.Name = "lblEnterp"
        Me.lblEnterp.Size = New System.Drawing.Size(221, 24)
        Me.lblEnterp.TabIndex = 66
        Me.lblEnterp.Text = "Click Here to Send-->"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripProgressBar1, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1394, 25)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel1.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel2.Text = "&Maintenance"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(286, 22)
        Me.ToolStripButton1.Text = "Note: Once sent, items can't be changed or undone."
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripButton3.Text = "&Show Message Log"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Message Log"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Console Log"
        '
        'grpSpecial
        '
        Me.grpSpecial.Controls.Add(Me.Label11)
        Me.grpSpecial.Controls.Add(Me.txtContactno)
        Me.grpSpecial.Controls.Add(Me.txtSurname)
        Me.grpSpecial.Controls.Add(Me.Label17)
        Me.grpSpecial.Controls.Add(Me.Label18)
        Me.grpSpecial.Location = New System.Drawing.Point(8, 78)
        Me.grpSpecial.Name = "grpSpecial"
        Me.grpSpecial.Size = New System.Drawing.Size(378, 105)
        Me.grpSpecial.TabIndex = 113
        Me.grpSpecial.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(7, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 19)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Applicant Details"
        '
        'txtContactno
        '
        Me.txtContactno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactno.Location = New System.Drawing.Point(105, 72)
        Me.txtContactno.MaxLength = 15
        Me.txtContactno.Name = "txtContactno"
        Me.txtContactno.Size = New System.Drawing.Size(258, 26)
        Me.txtContactno.TabIndex = 116
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(105, 38)
        Me.txtSurname.MaxLength = 150
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(258, 26)
        Me.txtSurname.TabIndex = 115
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 19)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "ContactNo."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(8, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 19)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Full Name:"
        '
        'picSend
        '
        Me.picSend.Image = Global.SendM360_.NET_2008_.My.Resources.Resources.send
        Me.picSend.Location = New System.Drawing.Point(377, 611)
        Me.picSend.Name = "picSend"
        Me.picSend.Size = New System.Drawing.Size(80, 51)
        Me.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSend.TabIndex = 3
        Me.picSend.TabStop = False
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Checked = True
        Me.chkLocked.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLocked.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocked.ForeColor = System.Drawing.Color.White
        Me.chkLocked.Location = New System.Drawing.Point(34, 49)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(92, 23)
        Me.chkLocked.TabIndex = 119
        Me.chkLocked.Text = "PDSNO:"
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'ssMessage
        '
        Me.ssMessage.BackColor = System.Drawing.Color.Black
        Me.ssMessage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel6, Me.tstUser, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel1, Me.tstTxtCount, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.tstSuccess, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel5, Me.tstFail, Me.ToolStripStatusLabel7})
        Me.ssMessage.Location = New System.Drawing.Point(0, 669)
        Me.ssMessage.Name = "ssMessage"
        Me.ssMessage.Size = New System.Drawing.Size(1394, 23)
        Me.ssMessage.TabIndex = 120
        Me.ssMessage.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(47, 18)
        Me.ToolStripStatusLabel6.Text = "Login:"
        '
        'tstUser
        '
        Me.tstUser.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstUser.ForeColor = System.Drawing.Color.White
        Me.tstUser.Name = "tstUser"
        Me.tstUser.Size = New System.Drawing.Size(50, 18)
        Me.tstUser.Text = "USER"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel8.Text = "|"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(103, 18)
        Me.ToolStripStatusLabel1.Text = "Message Count:"
        '
        'tstTxtCount
        '
        Me.tstTxtCount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstTxtCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tstTxtCount.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tstTxtCount.Name = "tstTxtCount"
        Me.tstTxtCount.Size = New System.Drawing.Size(32, 18)
        Me.tstTxtCount.Text = "###"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(101, 18)
        Me.ToolStripStatusLabel4.Text = "Success Count:"
        '
        'tstSuccess
        '
        Me.tstSuccess.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstSuccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tstSuccess.Name = "tstSuccess"
        Me.tstSuccess.Size = New System.Drawing.Size(32, 18)
        Me.tstSuccess.Text = "###"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(77, 18)
        Me.ToolStripStatusLabel5.Text = "Failed Count:"
        '
        'tstFail
        '
        Me.tstFail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstFail.ForeColor = System.Drawing.Color.Red
        Me.tstFail.Name = "tstFail"
        Me.tstFail.Size = New System.Drawing.Size(32, 18)
        Me.tstFail.Text = "###"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel7.Text = "|"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtConsole)
        Me.GroupBox1.Location = New System.Drawing.Point(828, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 638)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Green
        Me.Label13.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightYellow
        Me.Label13.Location = New System.Drawing.Point(6, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(545, 36)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Message Console Log"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPDSNO
        '
        Me.lblPDSNO.AutoSize = True
        Me.lblPDSNO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDSNO.ForeColor = System.Drawing.Color.White
        Me.lblPDSNO.Location = New System.Drawing.Point(53, 50)
        Me.lblPDSNO.Name = "lblPDSNO"
        Me.lblPDSNO.Size = New System.Drawing.Size(73, 19)
        Me.lblPDSNO.TabIndex = 123
        Me.lblPDSNO.Text = "PDSNO:"
        '
        'frmSendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1394, 692)
        Me.Controls.Add(Me.lblPDSNO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ssMessage)
        Me.Controls.Add(Me.chkLocked)
        Me.Controls.Add(Me.grpSpecial)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblEnterp)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cboFloor)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblcountReceiver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPDSNO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.picSend)
        Me.Controls.Add(Me.lvReceiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSendSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLEC-SendM360 App Version:"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpSpecial.ResumeLayout(False)
        Me.grpSpecial.PerformLayout()
        CType(Me.picSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssMessage.ResumeLayout(False)
        Me.ssMessage.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPDSNO As System.Windows.Forms.TextBox
    Friend WithEvents picSend As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lvReceiver As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblcountReceiver As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblEnterp As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpSpecial As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContactno As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
    Friend WithEvents ssMessage As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstTxtCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstSuccess As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConsole As System.Windows.Forms.RichTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstFail As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPDSNO As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class
