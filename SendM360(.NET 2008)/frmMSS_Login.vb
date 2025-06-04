
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports System
Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Text
Imports Microsoft.Win32
Imports System.Net.Security.AuthenticationLevel
'Imports Microsoft.Win32.TaskScheduler

Public Class frmMSS_Login
    Private objMutex As System.Threading.Mutex
    'Dim con1 As New clsConnection
    Dim computer As New Microsoft.VisualBasic.Devices.ComputerInfo
    'Dim con1 As New clsConnection1
    Dim lvHash As String
    Dim lvExpire As Boolean        'janing 03-23-2018
    'Public pvoForceChange As Boolean   ' Melnard @ 2019-02-26
    Dim form As New frmSendSMS
    Dim formHR As New frmSendSMS_HR
    Dim Con1 As New clsConnection
    Dim Con2 As New clsConnection
    

    Private Sub ClearAll()
        txtUserName.Text = "SLEC-"
        txtUserName.Focus()
        txtUserName.Select(Len(txtUserName.Text), Len(txtUserName.Text))
        txtPassword.Clear()
    End Sub

    Private Sub frmMSS_Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            End
        End If
    End Sub
    Private Function ReadPassword() As String
        Dim password As New System.Text.StringBuilder()
        Do
            Dim keyInfo As ConsoleKeyInfo = Console.ReadKey(True)
            If keyInfo.Key = ConsoleKey.Enter Then
                Exit Do
            End If
            password.Append(keyInfo.KeyChar)
        Loop
        Return password.ToString()
    End Function
    Private Function GetNetworkCredentials() As NetworkCredential
        ' Prompt the user for username and password
        Console.Write("Enter username (including domain, if applicable): STLUKES67\Administrator")
        Dim username As String = Console.ReadLine()

        Console.Write("Enter password: Sl3c123$")
        Dim password As String = ReadPassword()

        ' Create a NetworkCredential object
        Return New NetworkCredential(username, password)
    End Function
    Private Function GetSampleNetworkCredentials() As NetworkCredential
        ' Use sample username and password
        Dim sampleUsername As String = "administrator"
        Dim samplePassword As String = "Sl3c123$"

        ' Create a NetworkCredential object
        Return New NetworkCredential(sampleUsername, samplePassword)
    End Function
    Private Sub frmMSS_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo frmMSS_Login_Load_Err

        'Dim networkCredentials As NetworkCredential = GetSampleNetworkCredentials()
        '' Create a PowerShell process
        'Dim powerShellScript As String = String.Format("Start-Process cmd -Verb RunAs -Credential (New-Object System.Management.Automation.PSCredential ('{0}', (ConvertTo-SecureString '{1}' -AsPlainText -Force)))", networkCredentials.UserName, networkCredentials.Password)
        '' Create a ProcessStartInfo object for PowerShell
        'Dim psi As New ProcessStartInfo("powershell.exe")
        '' Specify the PowerShell script as the script block
        'psi.Arguments = String.Format("-NoProfile -ExecutionPolicy Bypass -Command ""{0}""", powerShellScript)

        'Using process As New Process()
        '    ' Set the ProcessStartInfo for the process
        '    process.StartInfo = psi

        '    ' Start the process
        '    process.Start()

        '    ' Wait for the process to exit
        '    process.WaitForExit()
        '    If process.ExitCode <> 0 Then
        '        MsgBox("PowerShell script failed. Exit code: " & process.ExitCode)
        '    Else
        '        MsgBox("PowerShell script completed successfully.")
        '    End If
        'End Using



        ' Prompt the user for credentials

        ' Example of using ICredentials (for network-related operations)
        'Dim credentials As ICredentials = GetNetworkCredentials()
        ' Extract username and password from ICredentials
        'Dim networkCredentials As NetworkCredential = TryCast(credentials, NetworkCredential)
        ' Create a ProcessStartInfo object

        ' Specify the PowerShell command to create a new folder
        'Dim powershellCommand As String = "New-Item -ItemType Directory -Path ""C:\geckodriver\cmd.exe"""

        'Dim psi As New ProcessStartInfo("cmd.exe")
        ' '' Enable redirection of standard input
        ''psi.RedirectStandardInput = True
        ' '' Set the working directory to C:\Windows\System32
        ''psi.WorkingDirectory = "C:\Windows\System32"
        ' '' Add arguments to execute PowerShell command with credentials
        ' ''psi.Arguments = "-NoProfile -ExecutionPolicy Bypass -Command ""& {{ " & powershellCommand & " }}"""
        ' ''psi.Arguments = "-NoProfile -ExecutionPolicy Bypass -Command Start-Process cmd.exe -Verb RunAs"
        'Dim websiteUrl As String = "https://www.emedical.immi.gov.au/eMedUI/eMedical"
        'Dim PathDriver As String = "C:\geckodriver\geckodriver.exe"

        ' ''asa.FileName = "cmd.exe"

        '' Create a new Process instance
        'Using process As New Process()
        '    ' Set the ProcessStartInfo for the process
        '    process.StartInfo = psi
        '    ' Start the process
        '    process.Start()

        '    ' Get the StreamWriter for the standard input
        '    Dim cmdInput As StreamWriter = process.StandardInput

        '    ' Execute commands in cmd
        '    cmdInput.WriteLine("setx webdriver.gecko.driver """ & PathDriver & """ /M")
        '    cmdInput.WriteLine("start firefox """ & websiteUrl & """")
        '    cmdInput.WriteLine("exit")

        '    ' Close the input stream to signal the end of input
        '    cmdInput.Close()

        '    ' Wait for the process to exit
        '    process.WaitForExit()
        'End Using

        objMutex = New System.Threading.Mutex(False, "SendSMS")
        If objMutex.WaitOne(0, False) = False Then
            objMutex.Close()
            objMutex = Nothing
            MessageBox.Show("Another instance is already running!")
            End
        End If
        'Dim pathdriverdeployment As String = "\\AD12SVR\Deployment\Password Manager\geckodriver\selenium.webdriver.geckodriver.0.29.1\driver\win32\geckodriver.exe"

        'Dim Folderdriver As String = "geckodriver"
        'Dim outputpath As String = "C:\" & Folderdriver
        'Dim filedrivername As String = "geckodriver.exe"
        'Dim pathCdriver As String = "C:\" & Folderdriver & "\" & filedrivername

        'If Not Directory.Exists(outputpath) Then
        '    ' Create the folder
        '    Directory.CreateDirectory(outputpath)
        '    'Console.WriteLine("Folder created successfully.")
        'Else
        '    'Console.WriteLine("Folder already exists.")
        'End If

        '' Check if the destination file exists
        'If Not File.Exists(pathCdriver) Then
        '    ' If the destination file doesn't exist, copy the file
        '    File.Copy(pathdriverdeployment, pathCdriver)
        'Else
        '    ' MessageBox.Show("Destination file already exists.")
        'End If

        'Get version of the program
        grpsysteminfo.Visible = False
        lblVersion.Text = "Version: " + Me.GetType.Assembly.GetName.Version.ToString()
        Dim lvgetuserdomain As String

        '*This Program is only for STLUKES67.clinic
        lvgetuserdomain = System.Environment.UserDomainName
        If lvgetuserdomain = "" Or lvgetuserdomain <> "STLUKES67" Then
            MsgBox("Your not permited to use the Program!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PM")
            End
        Else
        End If
        'Get IP Address Device
        'gvMyIP = myIPs.AddressList(1).ToString()
        ClearAll()

frmMSS_Login_Load_Err:
        If Err.Number = 0 Then
        Else
            'DisplayError("Error on frmMSS_Login_Load()", Err.Number, Err.Description)
            'TakeScreenShot()
        End If
    End Sub
    Private Sub Login()
        '*Initiating Connection using Username and Password
        Con1.ConOleOpen()
        Dim cmd As OleDbCommand = New OleDbCommand("select a.Username, " & _
                                                   "a.emphash, " & _
                                                   "b.designation, " & _
                                                   "b.OfficialName, " & _
                                                   "b.Department, " & _
                                                   "a.expirationdate, " & _
                                                   "b.EmpNo, " & _
                                                   "b.Firstname " & _
                                                   "from _tblSystemUsers a, _tblemployees b where " & _
                                                   "a.emphash=b.emphash and " & _
                                                   "b.active='T' and " & _
                                                   "UserID = '" & Trim(txtUserName.Text) & "' and Password = '" & Trim(Encrypt(txtPassword.Text)) & "' ", Con1.gvDBConn)

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            If CDate(sdr.GetValue(5)) >= Today Then    'expirationdate
                Con1.gvUserName = UCase(Trim(sdr.GetValue(0).ToString))                                'USERNAME
                Con1.gvValUserEmpHash = UCase(Trim(sdr.GetValue(1).ToString))                                 'EMPHASH
                Con1.gvValUserTitle = Trim(sdr.GetValue(2).ToString)                                            'DESIGNATION
                Con1.gvUserOfcName = Trim(sdr.GetValue(3).ToString)                                           'OfficialName
                form.mvEmp = Trim(sdr.GetValue(3).ToString)
                form.mvEmphash = UCase(Trim(sdr.GetValue(1).ToString))
                formHR.mvEmp = Trim(sdr.GetValue(3).ToString)
                mvEmphash = UCase(Trim(sdr.GetValue(1).ToString))
                mvFirstname = UCase(Trim(sdr.GetValue(7).ToString))
                'MsgBox(form.mvEmp)
                Con1.gvValUserID = Trim(sdr.GetValue(6).ToString)                                           'EmpNo
                mvUserID = Trim(sdr.GetValue(6).ToString)
                'If UCase(Trim(sdr.GetValue(7).ToString)) = True Then
                '    gvforce = 1
                '    GoTo SuccessLogin
                'ElseIf UCase(Trim(sdr.GetValue(7).ToString)) = False Then
                '    gvforce = 0
                '    GoTo SuccessLogin
                'End If
                If Trim(sdr.GetValue(4).ToString) = "Administration" _
                   And (Trim(sdr.GetValue(2).ToString) = "HR Staff" _
                   Or Trim(sdr.GetValue(2).ToString) = "Manager" Or Trim(sdr.GetValue(2).ToString) = "Asst. Manager") Then
                    GoTo SuccessLoginHR

                Else

                End If
            Else
                MsgBox("Expired Account!")

                GoTo FailedLogin
            End If
        Else 'Expired Account
            MsgBox("Username or Password invalid. Please Try Again.", MsgBoxStyle.Information, "PM")
            GoTo FailedLogin
        End If


SuccessLogin:
        Me.Hide()
        form.ShowDialog()
        Con1.ConOleClose()
        txtUserName.Text = "SLEC-"
        txtUserName.Focus()
        txtUserName.Select(Microsoft.VisualBasic.Len(txtUserName.Text), Microsoft.VisualBasic.Len(txtUserName.Text))
        txtPassword.Clear()
SuccessLoginHR:
        Me.Hide()
        formHR.ShowDialog()
        Con1.ConOleClose()
        txtUserName.Text = "SLEC-"
        txtUserName.Focus()
        txtUserName.Select(Microsoft.VisualBasic.Len(txtUserName.Text), Microsoft.VisualBasic.Len(txtUserName.Text))
        txtPassword.Clear()
FailedLogin:
        Con1.ConOleClose()
        'MsgBox("Username or Password invalid. Please Try Again.", MsgBoxStyle.Information, "Password Manager")
        ' DisplayError("Error on btnOk_Click()", Err.Number, Err.Description)
        'TakeScreenShot()
        ClearAll()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Login()
    End Sub

    Public Function Encrypt(ByVal Password As String) As String
        Dim lvRetVal As String
        Dim lvCtr As Integer

        lvRetVal = ""
        For lvCtr = 1 To Len(Password)
            lvRetVal = lvRetVal & Chr(Asc(Mid(Password, lvCtr, 1)) + (lvCtr * 2))
        Next
        Encrypt = lvRetVal

    End Function

    Public Function Login(ByVal cLoginName As String, ByVal cPassword As String) As Boolean
        Dim lvLogIn As String

        'lvLogIn = "select * from _tblSystemUsers where UserID = '" & Trim(cLoginName) & "' And Password = '" & Trim(Encrypt(cPassword)) & "'"
        Con1.ConDBConnopen()
        lvLogIn = "Select a.*, b.OfficialName, b.Designation, b.Department, b.Active, b.Initials " & _
                 "From _tblSystemUsers a, _tblEmployees b " & _
                 "Where a.EmpHash = b.EmpHash " & _
                       " And a.UserID = '" & Trim(cLoginName) & "' " & _
                       " And a.Password = '" & Trim(Encrypt(cPassword)) & "' " & _
                       " And b.Active = 'T' " & _
                       " And DateDiff(d, ExpirationDate, GetDate()) <= 0 "

        Dim cmdLogin As New OleDb.OleDbCommand(lvLogIn, Con1.gvDBConn)
        Dim rsLogin As OleDbDataReader = cmdLogin.ExecuteReader
        With rsLogin
            If .HasRows = True Then
                If .Read Then
                    Con1.gvUserID = Trim(.Item("EmpHash"))
                    Con1.gvUserName = Trim(.Item("UserName").ToString)
                    Con1.gvUserNo = Trim(.Item("UserID"))
                    Con1.gvUserTitle = Trim(.Item("Designation"))
                    Con1.gvUserOfcName = Trim(.Item("OfficialName"))
                    Con1.gvUserInitial = Trim(.Item("Initials"))        'Choy @2023-08-14
                    Return True
                End If
                Con1.ConDBConnClose()
            Else
                Con1.ConDBConnClose()
                Return False
            End If
            .Close()
            ' rsLogin = Nothing
        End With
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            Login()
        End If
    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus, txtPassword.GotFocus
        sender.backcolor = Color.LightYellow
    End Sub

    Private Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus, txtPassword.GotFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmMSS_Login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            End
        End If
    End Sub


    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress

        If InStr("!@#$%^&*()_+=/\|[]{}:;<>?,.", e.KeyChar) > 0 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = vbCr Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub btnOk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOk.MouseDown
        btnOk.BackColor = Color.LightCyan
    End Sub

    Private Sub btnOk_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.MouseHover
        btnOk.BackColor = Color.LightBlue
    End Sub

    Private Sub btnCancel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.BackColor = Color.LightCyan
    End Sub

    Private Sub btnCancel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseHover
        btnCancel.BackColor = Color.LightBlue
    End Sub

    Private Sub PicNotice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicNotice.Click
        'PanNotice.Visible = True
        PanDiagnostic.Visible = False
    End Sub

    Private Sub PicDiagnostic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicDiagnostic.Click
        PanDiagnostic.Visible = True
        'PanNotice.Visible = False
        lblConnectivity.Text = ""
        lblDomain.Text = ""
        lblHostname.Text = ""
        lblIPAddress.Text = ""
        lblPingResult.Text = ""
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim getuserdomain As String
        Dim rsTest As New ADODB.Recordset
        Dim Host_name As String = Dns.GetHostName()
        Dim ip_address As String = Dns.GetHostEntry(Host_name).AddressList(1).ToString()
        Dim lvStrSql As String
        On Error GoTo btnCheck_Err
        '*Diagnostics on Process
        getuserdomain = System.Environment.UserDomainName
        lblIPAddress.Text = ip_address
        lblHostname.Text = Host_name
        lblDomain.Text = getuserdomain

        lvStrSql = "Select * From _tblSystemUsers"
        With rsTest
            .Open(lvStrSql, con1.gvADODB)
            If Not rsTest.EOF Then
                lblConnectivity.Text = "Successful!"
            Else
                tmrVisible.Stop()
                lblConnectivity.Text = "UnSuccessful!...  Please contact administrator!"
            End If
            .Close()
        End With
        '* Check ping connection
        'If MyComputer.Network.Ping("192.168.10.250") Then
        '    Dim host As String = "192.168.10.250" ' use any other machine name
        '    Dim pingreq As Ping = New Ping()
        '    Dim rep As PingReply = pingreq.Send(host)
        '    'Console.WriteLine("Pinging {0} [{1}]", host, rep.Address.ToString())
        '    lblReply.Text = "Reply From: " & rep.Address.ToString() & " Time= " & rep.RoundtripTime & " TTL= " & rep.Options.Ttl
        '    lblPingResult.Text = "Successful!"
        'ElseIf Not MyComputer.Network.Ping("192.168.10.250") Then
        '    tmrVisible.Stop()
        '    lblPingResult.Text = "Ping: Request timed out. Call IT Administrator!"
        'End If

btnCheck_Err:
        If Err.Number = 0 Then
        Else
            'DisplayError("Error on btnCheck()", Err.Number, Err.Description)
            'TakeScreenShot()
        End If
    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        PanDiagnostic.Visible = False
    End Sub

    Dim DoubleBytes As Double
    '*Translating Bytes TB, GB, KB format
    Public Function FormatBytes(ByVal BytesCaller As ULong) As String
        Try
            Select Case BytesCaller
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = BytesCaller ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try

    End Function

    Private Sub picCloseSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCloseSystem.Click
        grpsysteminfo.Visible = False
    End Sub

    Private Sub btnSystemInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemInfo.Click
        On Error GoTo btnSystemInfo_Err
        '*Get System Info of the current Device
        grpsysteminfo.Visible = True
        lvlAvPhMemory.Text = FormatBytes(computer.AvailablePhysicalMemory)
        lvlAvVrMemory.Text = FormatBytes(computer.AvailableVirtualMemory)
        lblInstalledUI.Text = computer.InstalledUICulture.DisplayName
        lblOSname.Text = computer.OSFullName
        lblOSplatform.Text = computer.OSPlatform
        lblOSVersion.Text = computer.OSVersion
        lblTotalPhyMemory.Text = FormatBytes(computer.TotalPhysicalMemory)
        lblTotalVirMemory.Text = FormatBytes(computer.TotalVirtualMemory)
btnSystemInfo_Err:
        If Err.Number = 0 Then
        Else
            'DisplayError("Error on btnSystemInfo_click()", Err.Number, Err.Description)
            'TakeScreenShot()
        End If
    End Sub
End Class

'Private Sub tmrVisible_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVisible.Tick
'    'Try
'    '*******ELY*****************
'    'MONITOR BYTE SIZE SEND AND RECEIVED
'    'Bandwidth
'    '*******ELY*****************
'    '    Dim networkInterfaces As New System.Diagnostics.PerformanceCounterCategory("Network Interface")
'    '    Dim nics As String() = networkInterfaces.GetInstanceNames()
'    '    Dim bytesSent(nics.Length - 1) As System.Diagnostics.PerformanceCounter
'    '    Dim bytesReceived(nics.Length - 1) As System.Diagnostics.PerformanceCounter
'    '    Dim i As Integer
'    '    For i = 0 To nics.Length - 1
'    '        bytesSent(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes Sent/sec", nics(i), True)
'    '        bytesReceived(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes received/sec", nics(i), True)
'    '    Next
'    '    'Dim ni As System.Diagnostics.PerformanceCounter 
'    '    For i = 0 To nics.Length - 1
'    '        Label5.Text = String.Format("     interface {0}: {1} ", i, nics(i))
'    '    Next
'    '    ' Do
'    '    For z = 0 To 1000
'    '        For i = 0 To nics.Length - 1
'    '            Label4.Text = String.Format("     interface {0}: {1} bytes sent/sec, {2} bytes received/sec.  ", i, bytesSent(i).NextValue, bytesReceived(i).NextValue)
'    '        Next
'    '        z = z + 1
'    '    Next z
'    '    'System.Console.WriteLine("")
'    '    'System.Console.WriteLine("")
'    '    'System.Threading.Thread.Sleep(3000)
'    '    ' Loop
'    'Catch ex As Exception
'    '    tmrVisible.Stop()
'    '    MsgBox(ex.Message)
'    'End Try
'    '        On Error GoTo tmrVisible_Tick_Err
'    '        If Not MyComputer.Network.IsAvailable Then
'    '            tmrVisible.Stop()
'    '            MsgBox("Network has been Disconnected! Call IT. Your IP Address:", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PasswordManager Module")
'    '            If MsgBoxResult.Ok Then
'    '                ' tmrVisible.Start()
'    '            End If
'    '        Else
'    '        End If
'    '        If MyComputer.Network.Ping("192.168.10.250") Then
'    '        Else
'    '            tmrVisible.Stop()
'    '            MsgBox("192.168.10.250 - Ping request timed out. Call IT Administrator!")
'    '        End If
'    'tmrVisible_Tick_Err:
'    '        If Err.Number = 0 Then
'    '        Else
'    '            DisplayError("Error on tmrVisible_Tick()", Err.Number, Err.Description)
'    '            TakeScreenShot()
'    '        End If
'End Sub