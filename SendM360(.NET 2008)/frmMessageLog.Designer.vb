<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageLog))
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTemp = New System.Windows.Forms.ComboBox
        Me.chkTemplate = New System.Windows.Forms.CheckBox
        Me.chkPDSNo = New System.Windows.Forms.CheckBox
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.PicSearch = New System.Windows.Forms.PictureBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.lvMessageLog = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.txtPDSNo = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.PicSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1145, 47)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Sent Message Log"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboTemp)
        Me.Panel1.Controls.Add(Me.chkTemplate)
        Me.Panel1.Controls.Add(Me.chkPDSNo)
        Me.Panel1.Controls.Add(Me.chkDate)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PicSearch)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.lvMessageLog)
        Me.Panel1.Controls.Add(Me.txtPDSNo)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1145, 611)
        Me.Panel1.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1126, 23)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "List Of Message Log"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTemp
        '
        Me.cboTemp.DropDownHeight = 500
        Me.cboTemp.DropDownWidth = 500
        Me.cboTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTemp.FormattingEnabled = True
        Me.cboTemp.IntegralHeight = False
        Me.cboTemp.Location = New System.Drawing.Point(128, 89)
        Me.cboTemp.MaxDropDownItems = 99
        Me.cboTemp.Name = "cboTemp"
        Me.cboTemp.Size = New System.Drawing.Size(341, 27)
        Me.cboTemp.TabIndex = 110
        '
        'chkTemplate
        '
        Me.chkTemplate.AutoSize = True
        Me.chkTemplate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTemplate.ForeColor = System.Drawing.Color.Blue
        Me.chkTemplate.Location = New System.Drawing.Point(32, 97)
        Me.chkTemplate.Name = "chkTemplate"
        Me.chkTemplate.Size = New System.Drawing.Size(90, 20)
        Me.chkTemplate.TabIndex = 109
        Me.chkTemplate.Text = "Template:"
        Me.chkTemplate.UseVisualStyleBackColor = True
        '
        'chkPDSNo
        '
        Me.chkPDSNo.AutoSize = True
        Me.chkPDSNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPDSNo.ForeColor = System.Drawing.Color.Blue
        Me.chkPDSNo.Location = New System.Drawing.Point(32, 61)
        Me.chkPDSNo.Name = "chkPDSNo"
        Me.chkPDSNo.Size = New System.Drawing.Size(77, 20)
        Me.chkPDSNo.TabIndex = 108
        Me.chkPDSNo.Text = "PDSNO:"
        Me.chkPDSNo.UseVisualStyleBackColor = True
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate.ForeColor = System.Drawing.Color.Blue
        Me.chkDate.Location = New System.Drawing.Point(32, 27)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(64, 20)
        Me.chkDate.TabIndex = 107
        Me.chkDate.Text = "DATE:"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(4, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 19)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Search by:"
        '
        'PicSearch
        '
        Me.PicSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicSearch.Image = Global.SendM360_.NET_2008_.My.Resources.Resources.magnifying_glass
        Me.PicSearch.Location = New System.Drawing.Point(492, 19)
        Me.PicSearch.Name = "PicSearch"
        Me.PicSearch.Size = New System.Drawing.Size(53, 50)
        Me.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSearch.TabIndex = 105
        Me.PicSearch.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(214, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 32)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = " - "
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(260, 25)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(93, 26)
        Me.dtpTo.TabIndex = 101
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(115, 25)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(93, 26)
        Me.dtpFrom.TabIndex = 98
        '
        'lvMessageLog
        '
        Me.lvMessageLog.AllowDrop = True
        Me.lvMessageLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvMessageLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMessageLog.FullRowSelect = True
        Me.lvMessageLog.GridLines = True
        Me.lvMessageLog.Location = New System.Drawing.Point(8, 155)
        Me.lvMessageLog.Name = "lvMessageLog"
        Me.lvMessageLog.Size = New System.Drawing.Size(1126, 453)
        Me.lvMessageLog.TabIndex = 96
        Me.lvMessageLog.Tag = ""
        Me.lvMessageLog.UseCompatibleStateImageBehavior = False
        Me.lvMessageLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PDSNO"
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
        'txtPDSNo
        '
        Me.txtPDSNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDSNo.Location = New System.Drawing.Point(115, 57)
        Me.txtPDSNo.MaxLength = 15
        Me.txtPDSNo.Name = "txtPDSNo"
        Me.txtPDSNo.Size = New System.Drawing.Size(354, 26)
        Me.txtPDSNo.TabIndex = 97
        '
        'frmMessageLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 682)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMessageLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MESSAGE LOG"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboTemp As System.Windows.Forms.ComboBox
    Friend WithEvents chkTemplate As System.Windows.Forms.CheckBox
    Friend WithEvents chkPDSNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PicSearch As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvMessageLog As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPDSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
