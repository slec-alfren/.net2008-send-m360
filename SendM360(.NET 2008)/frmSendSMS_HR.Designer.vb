<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS_HR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendSMS_HR))
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblFailed = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcountReceiver = New System.Windows.Forms.Label
        Me.lblSuccessCount = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.lvReceiver = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnRemoveAll = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMessage = New System.Windows.Forms.RichTextBox
        Me.lblCountText = New System.Windows.Forms.Label
        Me.lblContactno = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPDSNO = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtContactno = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lvMessageLog = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PicSearch = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.txtConsole = New System.Windows.Forms.RichTextBox
        Me.picSend = New System.Windows.Forms.PictureBox
        Me.picClear = New System.Windows.Forms.PictureBox
        Me.cmdCount = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tslMaintenance = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(647, 503)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 19)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Failed Count:"
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Location = New System.Drawing.Point(754, 503)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(108, 19)
        Me.lblFailed.TabIndex = 90
        Me.lblFailed.Text = "###########"
        Me.lblFailed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(218, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "List Count:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(395, 503)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 19)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Success Count:"
        '
        'lblcountReceiver
        '
        Me.lblcountReceiver.AutoSize = True
        Me.lblcountReceiver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountReceiver.ForeColor = System.Drawing.Color.Blue
        Me.lblcountReceiver.Location = New System.Drawing.Point(317, 184)
        Me.lblcountReceiver.Name = "lblcountReceiver"
        Me.lblcountReceiver.Size = New System.Drawing.Size(18, 19)
        Me.lblcountReceiver.TabIndex = 88
        Me.lblcountReceiver.Text = "0"
        Me.lblcountReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSuccessCount
        '
        Me.lblSuccessCount.AutoSize = True
        Me.lblSuccessCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccessCount.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblSuccessCount.Location = New System.Drawing.Point(533, 503)
        Me.lblSuccessCount.Name = "lblSuccessCount"
        Me.lblSuccessCount.Size = New System.Drawing.Size(108, 19)
        Me.lblSuccessCount.TabIndex = 86
        Me.lblSuccessCount.Text = "###########"
        Me.lblSuccessCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(16, 495)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(80, 27)
        Me.btnShow.TabIndex = 85
        Me.btnShow.Text = "---"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lvReceiver
        '
        Me.lvReceiver.AllowDrop = True
        Me.lvReceiver.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvReceiver.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvReceiver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiver.FullRowSelect = True
        Me.lvReceiver.GridLines = True
        Me.lvReceiver.Location = New System.Drawing.Point(353, 28)
        Me.lvReceiver.Name = "lvReceiver"
        Me.lvReceiver.Size = New System.Drawing.Size(505, 180)
        Me.lvReceiver.TabIndex = 83
        Me.lvReceiver.Tag = ""
        Me.lvReceiver.UseCompatibleStateImageBehavior = False
        Me.lvReceiver.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DTRNO"
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
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(297, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(46, 71)
        Me.btnAdd.TabIndex = 82
        Me.btnAdd.Text = ">>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(297, 113)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(46, 49)
        Me.btnRemoveAll.TabIndex = 84
        Me.btnRemoveAll.Text = "Clear"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 501)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Text Count:"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(12, 318)
        Me.txtMessage.MaxLength = 2500
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(751, 171)
        Me.txtMessage.TabIndex = 79
        Me.txtMessage.Text = ""
        '
        'lblCountText
        '
        Me.lblCountText.AutoSize = True
        Me.lblCountText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountText.ForeColor = System.Drawing.Color.Blue
        Me.lblCountText.Location = New System.Drawing.Point(206, 501)
        Me.lblCountText.Name = "lblCountText"
        Me.lblCountText.Size = New System.Drawing.Size(108, 19)
        Me.lblCountText.TabIndex = 80
        Me.lblCountText.Text = "###########"
        Me.lblCountText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactno
        '
        Me.lblContactno.AutoSize = True
        Me.lblContactno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactno.ForeColor = System.Drawing.Color.Blue
        Me.lblContactno.Location = New System.Drawing.Point(415, 291)
        Me.lblContactno.Name = "lblContactno"
        Me.lblContactno.Size = New System.Drawing.Size(108, 19)
        Me.lblContactno.TabIndex = 78
        Me.lblContactno.Text = "###########"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.ForeColor = System.Drawing.Color.Blue
        Me.lblSurname.Location = New System.Drawing.Point(415, 257)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(27, 19)
        Me.lblSurname.TabIndex = 77
        Me.lblSurname.Text = "<>"
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(113, 38)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(178, 27)
        Me.cboCategory.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "ContactNo."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "DTR NO:"
        '
        'txtPDSNO
        '
        Me.txtPDSNO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDSNO.Location = New System.Drawing.Point(113, 136)
        Me.txtPDSNO.MaxLength = 15
        Me.txtPDSNO.Name = "txtPDSNO"
        Me.txtPDSNO.Size = New System.Drawing.Size(178, 26)
        Me.txtPDSNO.TabIndex = 67
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(123, 250)
        Me.txtSurname.MaxLength = 150
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(269, 26)
        Me.txtSurname.TabIndex = 92
        '
        'txtContactno
        '
        Me.txtContactno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactno.Location = New System.Drawing.Point(123, 284)
        Me.txtContactno.MaxLength = 15
        Me.txtContactno.Name = "txtContactno"
        Me.txtContactno.Size = New System.Drawing.Size(269, 26)
        Me.txtContactno.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(415, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 19)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Applicant Details"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(25, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(174, 19)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Non-Applicant Details"
        '
        'lvMessageLog
        '
        Me.lvMessageLog.AllowDrop = True
        Me.lvMessageLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvMessageLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMessageLog.FullRowSelect = True
        Me.lvMessageLog.GridLines = True
        Me.lvMessageLog.Location = New System.Drawing.Point(6, 101)
        Me.lvMessageLog.Name = "lvMessageLog"
        Me.lvMessageLog.Size = New System.Drawing.Size(555, 336)
        Me.lvMessageLog.TabIndex = 96
        Me.lvMessageLog.Tag = ""
        Me.lvMessageLog.UseCompatibleStateImageBehavior = False
        Me.lvMessageLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DTRNO"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mobile No"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Message Content"
        Me.ColumnHeader7.Width = 400
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date Sent"
        Me.ColumnHeader8.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 69)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(354, 26)
        Me.TextBox1.TabIndex = 97
        Me.TextBox1.Visible = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(162, 10)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(153, 30)
        Me.dtpFrom.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(16, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Search by Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(16, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 19)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Search by Name:"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(875, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(570, 47)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Sent Message Log"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PicSearch)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lvMessageLog)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(875, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 441)
        Me.Panel1.TabIndex = 102
        '
        'PicSearch
        '
        Me.PicSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicSearch.Image = Global.SendM360_.NET_2008_.My.Resources.Resources.magnifying_glass
        Me.PicSearch.Location = New System.Drawing.Point(522, 10)
        Me.PicSearch.Name = "PicSearch"
        Me.PicSearch.Size = New System.Drawing.Size(39, 30)
        Me.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSearch.TabIndex = 105
        Me.PicSearch.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(367, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 19)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "To:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(315, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 32)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = " - "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(166, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 19)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "From:"
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(363, 10)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(153, 30)
        Me.dtpTo.TabIndex = 101
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsole.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtConsole.Location = New System.Drawing.Point(12, 540)
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.Size = New System.Drawing.Size(1429, 208)
        Me.txtConsole.TabIndex = 104
        Me.txtConsole.Text = ""
        '
        'picSend
        '
        Me.picSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSend.Image = Global.SendM360_.NET_2008_.My.Resources.Resources.send
        Me.picSend.Location = New System.Drawing.Point(778, 384)
        Me.picSend.Name = "picSend"
        Me.picSend.Size = New System.Drawing.Size(80, 51)
        Me.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSend.TabIndex = 69
        Me.picSend.TabStop = False
        '
        'picClear
        '
        Me.picClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picClear.Image = Global.SendM360_.NET_2008_.My.Resources.Resources.rubber
        Me.picClear.Location = New System.Drawing.Point(778, 318)
        Me.picClear.Name = "picClear"
        Me.picClear.Size = New System.Drawing.Size(80, 51)
        Me.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClear.TabIndex = 68
        Me.picClear.TabStop = False
        '
        'cmdCount
        '
        Me.cmdCount.Location = New System.Drawing.Point(343, 493)
        Me.cmdCount.Name = "cmdCount"
        Me.cmdCount.Size = New System.Drawing.Size(46, 30)
        Me.cmdCount.TabIndex = 105
        Me.cmdCount.Text = "Count"
        Me.cmdCount.UseVisualStyleBackColor = True
        Me.cmdCount.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tslMaintenance, Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1453, 25)
        Me.ToolStrip1.TabIndex = 106
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel1.Text = "&FILE"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'tslMaintenance
        '
        Me.tslMaintenance.Name = "tslMaintenance"
        Me.tslMaintenance.Size = New System.Drawing.Size(76, 22)
        Me.tslMaintenance.Text = "&Maintenance"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar1.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 19)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Gray
        Me.txtDescription.Location = New System.Drawing.Point(113, 73)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(178, 26)
        Me.txtDescription.TabIndex = 108
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(112, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 19)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "(Department / Section)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSendSMS_HR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1453, 525)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdCount)
        Me.Controls.Add(Me.txtConsole)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContactno)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblcountReceiver)
        Me.Controls.Add(Me.lblSuccessCount)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lvReceiver)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblCountText)
        Me.Controls.Add(Me.lblContactno)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picClear)
        Me.Controls.Add(Me.picSend)
        Me.Controls.Add(Me.txtPDSNO)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSendSMS_HR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR DEPARTMENT SendmyMessage"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFailed As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcountReceiver As System.Windows.Forms.Label
    Friend WithEvents lblSuccessCount As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lvReceiver As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCountText As System.Windows.Forms.Label
    Friend WithEvents lblContactno As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picSend As System.Windows.Forms.PictureBox
    Friend WithEvents picClear As System.Windows.Forms.PictureBox
    Friend WithEvents txtPDSNO As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtContactno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lvMessageLog As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtConsole As System.Windows.Forms.RichTextBox
    Friend WithEvents PicSearch As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCount As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslMaintenance As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
End Class
