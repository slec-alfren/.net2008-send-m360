<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSS_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSS_Login))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpsysteminfo = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblTotalVirMemory = New System.Windows.Forms.Label
        Me.lblTotalPhyMemory = New System.Windows.Forms.Label
        Me.lblOSVersion = New System.Windows.Forms.Label
        Me.lblOSplatform = New System.Windows.Forms.Label
        Me.lblOSname = New System.Windows.Forms.Label
        Me.lblInstalledUI = New System.Windows.Forms.Label
        Me.lvlAvVrMemory = New System.Windows.Forms.Label
        Me.lvlAvPhMemory = New System.Windows.Forms.Label
        Me.picCloseSystem = New System.Windows.Forms.PictureBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.PanDiagnostic = New System.Windows.Forms.Panel
        Me.lblReply = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnSystemInfo = New System.Windows.Forms.Button
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.lblConnectivity = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblDomain = New System.Windows.Forms.Label
        Me.lblIPAddress = New System.Windows.Forms.Label
        Me.lblHostname = New System.Windows.Forms.Label
        Me.btnCheck = New System.Windows.Forms.Button
        Me.lblPingResult = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTestPing = New System.Windows.Forms.Label
        Me.PicDiagnostic = New System.Windows.Forms.PictureBox
        Me.PicNotice = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.tmrVisible = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.grpsysteminfo.SuspendLayout()
        CType(Me.picCloseSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanDiagnostic.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDiagnostic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.grpsysteminfo)
        Me.Panel1.Controls.Add(Me.PanDiagnostic)
        Me.Panel1.Controls.Add(Me.PicDiagnostic)
        Me.Panel1.Controls.Add(Me.PicNotice)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 513)
        Me.Panel1.TabIndex = 0
        '
        'grpsysteminfo
        '
        Me.grpsysteminfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpsysteminfo.Controls.Add(Me.Label19)
        Me.grpsysteminfo.Controls.Add(Me.lblTotalVirMemory)
        Me.grpsysteminfo.Controls.Add(Me.lblTotalPhyMemory)
        Me.grpsysteminfo.Controls.Add(Me.lblOSVersion)
        Me.grpsysteminfo.Controls.Add(Me.lblOSplatform)
        Me.grpsysteminfo.Controls.Add(Me.lblOSname)
        Me.grpsysteminfo.Controls.Add(Me.lblInstalledUI)
        Me.grpsysteminfo.Controls.Add(Me.lvlAvVrMemory)
        Me.grpsysteminfo.Controls.Add(Me.lvlAvPhMemory)
        Me.grpsysteminfo.Controls.Add(Me.picCloseSystem)
        Me.grpsysteminfo.Controls.Add(Me.Label18)
        Me.grpsysteminfo.Controls.Add(Me.Label17)
        Me.grpsysteminfo.Controls.Add(Me.Label16)
        Me.grpsysteminfo.Controls.Add(Me.Label15)
        Me.grpsysteminfo.Controls.Add(Me.Label14)
        Me.grpsysteminfo.Controls.Add(Me.Label13)
        Me.grpsysteminfo.Controls.Add(Me.Label12)
        Me.grpsysteminfo.Controls.Add(Me.Label11)
        Me.grpsysteminfo.Location = New System.Drawing.Point(14, 165)
        Me.grpsysteminfo.Name = "grpsysteminfo"
        Me.grpsysteminfo.Size = New System.Drawing.Size(502, 283)
        Me.grpsysteminfo.TabIndex = 14
        Me.grpsysteminfo.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(351, 31)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "SYSTEM INFORMATION:"
        '
        'lblTotalVirMemory
        '
        Me.lblTotalVirMemory.AutoSize = True
        Me.lblTotalVirMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVirMemory.Location = New System.Drawing.Point(235, 251)
        Me.lblTotalVirMemory.Name = "lblTotalVirMemory"
        Me.lblTotalVirMemory.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalVirMemory.TabIndex = 21
        '
        'lblTotalPhyMemory
        '
        Me.lblTotalPhyMemory.AutoSize = True
        Me.lblTotalPhyMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPhyMemory.Location = New System.Drawing.Point(251, 223)
        Me.lblTotalPhyMemory.Name = "lblTotalPhyMemory"
        Me.lblTotalPhyMemory.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalPhyMemory.TabIndex = 20
        '
        'lblOSVersion
        '
        Me.lblOSVersion.AutoSize = True
        Me.lblOSVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSVersion.Location = New System.Drawing.Point(147, 197)
        Me.lblOSVersion.Name = "lblOSVersion"
        Me.lblOSVersion.Size = New System.Drawing.Size(0, 25)
        Me.lblOSVersion.TabIndex = 19
        '
        'lblOSplatform
        '
        Me.lblOSplatform.AutoSize = True
        Me.lblOSplatform.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSplatform.Location = New System.Drawing.Point(147, 172)
        Me.lblOSplatform.Name = "lblOSplatform"
        Me.lblOSplatform.Size = New System.Drawing.Size(0, 25)
        Me.lblOSplatform.TabIndex = 18
        '
        'lblOSname
        '
        Me.lblOSname.AutoSize = True
        Me.lblOSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSname.Location = New System.Drawing.Point(165, 149)
        Me.lblOSname.Name = "lblOSname"
        Me.lblOSname.Size = New System.Drawing.Size(0, 25)
        Me.lblOSname.TabIndex = 17
        '
        'lblInstalledUI
        '
        Me.lblInstalledUI.AutoSize = True
        Me.lblInstalledUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstalledUI.Location = New System.Drawing.Point(213, 123)
        Me.lblInstalledUI.Name = "lblInstalledUI"
        Me.lblInstalledUI.Size = New System.Drawing.Size(0, 25)
        Me.lblInstalledUI.TabIndex = 16
        '
        'lvlAvVrMemory
        '
        Me.lvlAvVrMemory.AutoSize = True
        Me.lvlAvVrMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlAvVrMemory.Location = New System.Drawing.Point(271, 98)
        Me.lvlAvVrMemory.Name = "lvlAvVrMemory"
        Me.lvlAvVrMemory.Size = New System.Drawing.Size(0, 25)
        Me.lvlAvVrMemory.TabIndex = 15
        '
        'lvlAvPhMemory
        '
        Me.lvlAvPhMemory.AutoSize = True
        Me.lvlAvPhMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlAvPhMemory.Location = New System.Drawing.Point(290, 71)
        Me.lvlAvPhMemory.Name = "lvlAvPhMemory"
        Me.lvlAvPhMemory.Size = New System.Drawing.Size(0, 25)
        Me.lvlAvPhMemory.TabIndex = 14
        '
        'picCloseSystem
        '
        Me.picCloseSystem.Location = New System.Drawing.Point(445, 12)
        Me.picCloseSystem.Name = "picCloseSystem"
        Me.picCloseSystem.Size = New System.Drawing.Size(48, 48)
        Me.picCloseSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCloseSystem.TabIndex = 13
        Me.picCloseSystem.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 251)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(216, 25)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Total Virtual Memory:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(236, 25)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Total Physical Memory:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 25)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "OS Version:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "OS Platform:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "OS Full Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 25)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Installed UI Culture:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(256, 25)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Available Virtual Memory:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(276, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Available Physical Memory:"
        '
        'PanDiagnostic
        '
        Me.PanDiagnostic.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanDiagnostic.Controls.Add(Me.lblReply)
        Me.PanDiagnostic.Controls.Add(Me.Label20)
        Me.PanDiagnostic.Controls.Add(Me.btnSystemInfo)
        Me.PanDiagnostic.Controls.Add(Me.picClose)
        Me.PanDiagnostic.Controls.Add(Me.lblConnectivity)
        Me.PanDiagnostic.Controls.Add(Me.Label6)
        Me.PanDiagnostic.Controls.Add(Me.lblDomain)
        Me.PanDiagnostic.Controls.Add(Me.lblIPAddress)
        Me.PanDiagnostic.Controls.Add(Me.lblHostname)
        Me.PanDiagnostic.Controls.Add(Me.btnCheck)
        Me.PanDiagnostic.Controls.Add(Me.lblPingResult)
        Me.PanDiagnostic.Controls.Add(Me.Label10)
        Me.PanDiagnostic.Controls.Add(Me.Label9)
        Me.PanDiagnostic.Controls.Add(Me.Label8)
        Me.PanDiagnostic.Controls.Add(Me.Label7)
        Me.PanDiagnostic.Controls.Add(Me.lblTestPing)
        Me.PanDiagnostic.Location = New System.Drawing.Point(14, 165)
        Me.PanDiagnostic.Name = "PanDiagnostic"
        Me.PanDiagnostic.Size = New System.Drawing.Size(501, 334)
        Me.PanDiagnostic.TabIndex = 15
        Me.PanDiagnostic.Visible = False
        '
        'lblReply
        '
        Me.lblReply.AutoSize = True
        Me.lblReply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReply.Location = New System.Drawing.Point(120, 50)
        Me.lblReply.Name = "lblReply"
        Me.lblReply.Size = New System.Drawing.Size(0, 20)
        Me.lblReply.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 20)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Ping Result:"
        '
        'btnSystemInfo
        '
        Me.btnSystemInfo.BackColor = System.Drawing.Color.White
        Me.btnSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSystemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemInfo.Location = New System.Drawing.Point(184, 288)
        Me.btnSystemInfo.Name = "btnSystemInfo"
        Me.btnSystemInfo.Size = New System.Drawing.Size(158, 32)
        Me.btnSystemInfo.TabIndex = 13
        Me.btnSystemInfo.Text = "System Info"
        Me.btnSystemInfo.UseVisualStyleBackColor = False
        '
        'picClose
        '
        Me.picClose.Location = New System.Drawing.Point(449, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(48, 48)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'lblConnectivity
        '
        Me.lblConnectivity.AutoSize = True
        Me.lblConnectivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblConnectivity.Location = New System.Drawing.Point(172, 220)
        Me.lblConnectivity.Name = "lblConnectivity"
        Me.lblConnectivity.Size = New System.Drawing.Size(0, 20)
        Me.lblConnectivity.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DB Connectivity:"
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDomain.Location = New System.Drawing.Point(128, 183)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(0, 20)
        Me.lblDomain.TabIndex = 9
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblIPAddress.Location = New System.Drawing.Point(132, 145)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(0, 20)
        Me.lblIPAddress.TabIndex = 8
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = True
        Me.lblHostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHostname.Location = New System.Drawing.Point(128, 111)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Size = New System.Drawing.Size(0, 20)
        Me.lblHostname.TabIndex = 7
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.White
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(184, 250)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(158, 32)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Diagnose"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblPingResult
        '
        Me.lblPingResult.AutoSize = True
        Me.lblPingResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPingResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPingResult.Location = New System.Drawing.Point(128, 79)
        Me.lblPingResult.Name = "lblPingResult"
        Me.lblPingResult.Size = New System.Drawing.Size(0, 20)
        Me.lblPingResult.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Diagnostic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Domain:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "IP Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "HostName:"
        '
        'lblTestPing
        '
        Me.lblTestPing.AutoSize = True
        Me.lblTestPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestPing.Location = New System.Drawing.Point(25, 50)
        Me.lblTestPing.Name = "lblTestPing"
        Me.lblTestPing.Size = New System.Drawing.Size(89, 20)
        Me.lblTestPing.TabIndex = 0
        Me.lblTestPing.Text = "Test Ping:"
        '
        'PicDiagnostic
        '
        Me.PicDiagnostic.Location = New System.Drawing.Point(476, 11)
        Me.PicDiagnostic.Name = "PicDiagnostic"
        Me.PicDiagnostic.Size = New System.Drawing.Size(48, 48)
        Me.PicDiagnostic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicDiagnostic.TabIndex = 11
        Me.PicDiagnostic.TabStop = False
        '
        'PicNotice
        '
        Me.PicNotice.Location = New System.Drawing.Point(6, 6)
        Me.PicNotice.Name = "PicNotice"
        Me.PicNotice.Size = New System.Drawing.Size(48, 48)
        Me.PicNotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicNotice.TabIndex = 10
        Me.PicNotice.TabStop = False
        Me.PicNotice.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(16, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 5)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SEND M360"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblVersion)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnOk)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.txtUserName)
        Me.Panel3.Location = New System.Drawing.Point(16, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 334)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(4, 307)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(57, 20)
        Me.lblVersion.TabIndex = 9
        Me.lblVersion.Text = "Label4"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(107, 203)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 5)
        Me.Panel4.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(232, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(181, 80)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(90, 219)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(136, 80)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(107, 152)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10026)
        Me.txtPassword.Size = New System.Drawing.Size(289, 47)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(107, 51)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(289, 47)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrVisible
        '
        Me.tmrVisible.Interval = 30000
        '
        'frmMSS_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(558, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMSS_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOG-IN"
        Me.Panel1.ResumeLayout(False)
        Me.grpsysteminfo.ResumeLayout(False)
        Me.grpsysteminfo.PerformLayout()
        CType(Me.picCloseSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanDiagnostic.ResumeLayout(False)
        Me.PanDiagnostic.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDiagnostic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNotice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tmrVisible As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PicDiagnostic As System.Windows.Forms.PictureBox
    Friend WithEvents PicNotice As System.Windows.Forms.PictureBox
    Friend WithEvents PanDiagnostic As System.Windows.Forms.Panel
    Friend WithEvents lblConnectivity As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents lblHostname As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblPingResult As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTestPing As System.Windows.Forms.Label
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnSystemInfo As System.Windows.Forms.Button
    Friend WithEvents grpsysteminfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents picCloseSystem As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalVirMemory As System.Windows.Forms.Label
    Friend WithEvents lblTotalPhyMemory As System.Windows.Forms.Label
    Friend WithEvents lblOSVersion As System.Windows.Forms.Label
    Friend WithEvents lblOSplatform As System.Windows.Forms.Label
    Friend WithEvents lblOSname As System.Windows.Forms.Label
    Friend WithEvents lblInstalledUI As System.Windows.Forms.Label
    Friend WithEvents lvlAvVrMemory As System.Windows.Forms.Label
    Friend WithEvents lvlAvPhMemory As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblReply As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
