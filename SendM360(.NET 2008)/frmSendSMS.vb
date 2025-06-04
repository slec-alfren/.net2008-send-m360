
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmSendSMS
    Dim con1 As New clsConnection
    Dim con2 As New clsConnection
    Dim mvContactNo As String
    Dim Sent As Boolean
    Dim lvSentMessage As String
    Dim lvPDSNo As String
    Dim lvFullName As String
    Dim lvContactno As String
    Dim lvAddContactno As String
    Private isOn As Boolean = False
    Private isOnMessageLog As Boolean = False 'Ely @ 05292025
    Public mvEmp As String
    Public mvEmphash As String
    Dim mvFirstName As String
    Dim mvitem As New ListView 'Ely @ 05292025
    Dim lvperson As New clsPersonMessage() 'Ely @ 05292025

    'api_url: https://api.m360.com.ph/v3/api/broadcast

    'Private ReadOnly apiUrl As String = "https://api.m360.com.ph/v3/api/broadcast" ' Replace with the actual M360 API URL
    'Private ReadOnly apiKey As String = "HkVFa0VxZRIP3Lfs"
    'Private ReadOnly apiSecret As String = "fBwj6mAqIcR3SXaw2zUGyzq8TMJRZxc6"
    '"app_key": "M2T63BDj8A3S8f1U",
    '"app_secret": "O5gtQNhQxo89T4tZViAKqX2HM36uyxDP",

    Private Sub SendSMS(ByVal cCPNumber As String, ByVal cMessage As String)
        lblEnterp.Text = "Sending...."
        'MsgBox(mvEmp)
        'Dim appkey As String = "M2T63BDj8A3S8f1U"
        'Dim appsecret As String = "O5gtQNhQxo89T4tZViAKqX2HM36uyxDP"
        'Dim msisdn As String = cCPNumber
        'Dim content As String = ConvertToSingleLine(cMessage)
        'Dim Shortcode_mask As String = "SLEC"
        'Dim rcvd_transid As String = "sms-2"
        'Dim is_intnl As Boolean = False

        'Ely @ 2025-05-15
        Dim appkey As String = gvAppKey
        Dim appsecret As String = gvAppSecret
        Dim msisdn As String = cCPNumber
        Dim content As String = ConvertToSingleLine(cMessage)
        Dim Shortcode_mask As String = "SLEC"
        Dim rcvd_transid As String = "sms-2"
        Dim is_intnl As Boolean = False
        '' API URL
        'Dim apiUrl As String = "https://api.m360.com.ph/v3/api/broadcast" ' Replace with the correct endpoint
        ''api_url: https://api.m360.com.ph/v3/api/broadcast
        '{
        '    "app_key": "HkVFa0VxZRIP3Lfs",
        '    "app_secret": "fBwj6mAqIcR3SXaw2zUGyzq8TMJRZxc6",
        '    "msisdn": "+639694179693",
        '    "content": "Sample Message pf m360",
        '    "shortcode_mask": "SLEC",
        '    "rcvd_transid": "sms-2",
        '    "is_intnl": false
        '}

        '' JSON Data
        'Dim jsonData As String = "{" & _
        '"""app_key"": """ & appkey & "," & _
        '"""app_secret"": """ & appsecret & "," & _
        '"""msisdn"": """ & msisdn & "," & _
        '"""content"":""" & content & "," & _
        '"""shortcode_mask"": """ & Shortcode_mask & "," & _
        '"""rcvd_transid"": """ & rcvd_transid & "," & _
        '"""is_intnl"": false" & _
        '"}"



        ''Try
        'System.Net.ServicePointManager.SecurityProtocol = CType(3072, System.Net.SecurityProtocolType)
        '' Create the HTTP request
        'Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
        'request.Method = "POST"
        'request.ContentType = "application/json"
        'request.Accept = "application/json"

        '' Add the JSON data to the request
        'Dim byteData As Byte() = Encoding.UTF8.GetBytes(jsonData)
        'request.ContentLength = byteData.Length

        'Using dataStream As Stream = request.GetRequestStream()
        '    dataStream.Write(byteData, 0, byteData.Length)
        'End Using

        '' Get the response
        'Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

        'Using reader As New StreamReader(response.GetResponseStream())
        '    Dim responseText As String = reader.ReadToEnd()
        '    MsgBox("Response: " & responseText)
        'End Using
        Try
            Dim url As String = "https://api.m360.com.ph/v3/api/broadcast"
            'Dim url As String = "https://api.m360.com.ph/v3/api/send"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Accept = "application/json"

            ' JSON Payload
            Dim jsonData As String = "{" & _
            """app_key"": """ & appkey & """," & _
            """app_secret"": """ & appsecret & """," & _
            """msisdn"": """ & msisdn & """," & _
            """content"":""" & content & """," & _
            """shortcode_mask"": """ & Shortcode_mask & """," & _
            """rcvd_transid"": """ & rcvd_transid & """," & _
            """is_intnl"": false" & _
            "}"
            System.Net.ServicePointManager.SecurityProtocol = CType(3072, System.Net.SecurityProtocolType)
            ' Write Payload
            Using writer As New StreamWriter(request.GetRequestStream())
                writer.Write(jsonData)
            End Using

            ' Get Response
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Console.WriteLine("Response: " & reader.ReadToEnd())
            End Using
            Sent = True
            lblEnterp.Text = "Successful!..."


        Catch ex As WebException
            ' Handle errors
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    Console.WriteLine("Error Response: " & reader.ReadToEnd())
                    MsgBox(ex.Message + "Please Report this to IT" & reader.ReadToEnd())
                    Sent = False
                    lblEnterp.Text = "Sending Failed!..."
                End Using
                Exit Sub
            Else
                Console.WriteLine("Error: " & ex.Message)
                MsgBox(ex.Message + "Please Report this to IT")
                Sent = False
                lblEnterp.Text = "Sending Failed!..."
                Exit Sub
            End If
        End Try
    End Sub

    Private Function CheckAccess(ByVal cEmphash As String) As Boolean
        Dim rsCheckAccess As New ADODB.Recordset
        Dim lvStr As String

        lvStr = "Select * from _tblEmployees where Active = 'T' and Designation in('Manager', 'Asst. Manager') and emphash = '" & cEmphash & "' order by emphash asc"

        con1.ConOpen()

        With rsCheckAccess
            .Open(lvStr, con1.gvADODB)
            If Not .EOF Then
                CheckAccess = True
            Else
                CheckAccess = False
            End If
        End With

        con1.ConClose()

    End Function

    

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' SendSMS(txtPDSNO.Text)
        txtPDSNO.Text = ""
        'Console.WriteLine(result)

    End Sub

    Private Sub Clear()

        txtSurname.Text = ""
        'lblGivenname.Text = ""
        'lblMiddleName.Text = ""
        txtContactno.Text = "###########"
        txtMessage.Text = ""
        picSend.Enabled = False
        txtSurname.Text = ""
        txtContactno.Text = ""
        lblEnterp.Text = "Click Here to Send-->"
        'picAppPhoto.Image = SLEC_SendmySMS.My.Resources.Resources.Unknown
        'picSend.Image = SLEC_SendmySMS.My.Resources.Resources.senddisabled
        'cboFloor.Items.Clear()
        'cboFloor.Items.Add("Ground Floor")
        'cboFloor.Items.Add("2nd Floor")
        'cboFloor.Items.Add("3rd Floor")
        'cboFloor.Items.Add("4th Floor")
        'cboFloor.Items.Add("5th Floor")
        'cboFloor.Items.Add("6th Floor")
        'cboFloor.Items.Add("Annex Ground Floor")
        'cboFloor.Items.Add("BGC")

        'cboLocation.Items.Clear()
        'cboLocation.Items.Add("Medical Records (US Related)")
        'cboLocation.Items.Add("Medical Records (Other Countries)")
    End Sub

    Private Sub txtPDSNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPDSNO.KeyPress
        'Dim rsRecSet As ADODB.Recordset
        'Dim lvSelStr As String
        If Asc(e.KeyChar) = Keys.Enter Then
            Clear()
            If Microsoft.VisualBasic.Left(Trim(txtPDSNO.Text), 2) = "OP" Then ' ELY 05-07-2025
                FillDataDBSLECEmployee(txtPDSNO.Text) ' ELY 05-07-2025
            ElseIf Trim(txtPDSNO.Text) <> "" Then
                FillData()
                'txtMessage.Text = "Good day, " & lblSurname.Text & " Good day, This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will call you shortly using the number 09178118465 or 09178312571 This is in relation to your IGRA test result. For the purpose of ensuring confidentiality, We will call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
                'picSend.Image = SLEC_SendmySMS.My.Resources.Resources.send1
            Else
            End If

        End If

        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso _
            Char.IsWhiteSpace(e.KeyChar) AndAlso _
            Not Char.IsControl(e.KeyChar) Then

            e.Handled = True ' Block symbols and punctuation
        End If
    End Sub

    Public Sub FillDataDBSLECEmployee(ByVal cPDSNO As String)
        Dim lvSelStr As String
        Dim lvSelStrDB As String
        Dim rsFilldata As New ADODB.Recordset
        Dim rsFilldataDBSLEC As New ADODB.Recordset
        Dim lvoriginal As String
        Dim lvDTRno As Integer
        '1st Connection
        lvSelStr = "Select Empno from tbltrans a, tblpatmast b, _tblemployees c " & _
                        "where a.patrefno = b.patrefno " & _
                        "and b.patLname = c.Lastname " & _
                        "and a.pdsno = '" & cPDSNO & "'"
        con1.ConOpen()
        With rsFilldata
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                lvoriginal = Trim(.Fields("Empno").Value.ToString)
                lvDTRno = lvoriginal.Substring(5)
            Else
            End If
        End With
        con1.ConClose()
        'Second Connection
        lvSelStrDB = "Select a.Gender, Trim(b.GivenName) as Firstname, Trim(a.Surname) + ', ' + Trim(a.GivenName) + ' ' +  Left(a.MiddleName, 1) as FullName, a.Mobileno " & _
                        "From tbl201_Employee a, tbl201_Employee b " & _
                        "Where a.DTRNo = b.DTRNo and a.DTRNo = '" & "00" & lvDTRno & "' " & _
                        "and a.Employstat not in('Retired', 'Terminated', 'End-of-Contract','Resigned', 'Project-based', 'Trainee', 'On-Duty')"

        con2.ConDBConnopen()
        With rsFilldata
            .Open(lvSelStrDB, con2.gvDBConn_DBSLEC)
            If Not .EOF Then
                Dim contact As String = CheckMobileNo(Trim(.Fields("Mobileno").Value.ToString))
                mvContactNo = contact
                'Dim formattedContact As String = FormatContactNumber(contact)
                txtContactno.Text = MaskNumber(contact) 'Ely @ 05292025
                lvAddContactno = mvContactNo
                'Dim result As String = input.Substring(input.IndexOf("/") + 1)
                'lblContactno.Text = result
                txtSurname.Text = Trim(.Fields("FullName").Value.ToString)
                mvFirstName = Trim(.Fields("Firstname").Value.ToString)
            Else
            End If
        End With
        con2.ConDBConnClose()
        picSend.Enabled = True
    End Sub

    Private Sub FillData()
        Dim lvSelStr As String
        Dim rsFilldata As New ADODB.Recordset
        Dim lvPre As String
        lvPre = ""
        lvSelStr = "Select b.patsex, a.VisitDate, Left(a.PDSCode,3) as Country, b.PatLName, b.PatFName, b.PatMName, c.Telno " & _
               "From tblTrans a, tblPatMast b, tblotherinfo c " & _
               "Where a.PatRefNo = b.PatRefNo And a.pdsno = c.pdsno " & _
                     "And a.PDSNo = '" & Trim(txtPDSNO.Text) & "'"

        rsFilldata = New ADODB.Recordset
        con1.ConOpen()
        With rsFilldata
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                If Trim(.Fields("patsex").Value.ToString) = "M" Then
                    lvPre = "Mr. "
                ElseIf Trim(.Fields("patsex").Value.ToString) = "F" Then
                    lvPre = "Ms. "
                End If
                txtSurname.Text = lvPre + Trim(.Fields("PatLName").Value.ToString) + ", " + Trim(.Fields("PatFName").Value.ToString)
                mvFirstName = Trim(.Fields("PatLName").Value.ToString)
                'lblGivenname.Text = Trim(.Fields("PatFName").Value.ToString)
                'lblMiddleName.Text = Trim(.Fields("PatMName").Vaslue.ToString)
                'CheckMobileNo(Trim(.Fields("Telno").Value.ToString))

                lvAddContactno = CheckMobileNo(Trim(.Fields("Telno").Value.ToString))
                txtContactno.Text = CheckMobileNo(Trim(.Fields("Telno").Value.ToString))
                Dim contact As String = CheckMobileNo(Trim(.Fields("Telno").Value.ToString))
                mvContactNo = contact
                'Dim formattedContact As String = FormatContactNumber(contact)
                txtContactno.Text = MaskNumber(contact) 'Ely 05292025 as MaskNumber
                Console.WriteLine(MaskNumber(contact)) ' Output: 09*******10 'Ely 05292025 as MaskNumber

                'ShowPicture(picAppPhoto, txtPDSNO.Text, Trim(.Fields("VisitDate").Value.ToString), Trim(.Fields("Country").Value.ToString))
                picSend.Enabled = True
            Else
                MsgBox("Invalid PDSNO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SendmyMessage")
                'picAppPhoto.Image = SLEC_SendmySMS.My.Resources.Resources.Unknown
            End If
            .Close()
        End With
        con1.ConClose()

    End Sub

    Private Function FormatContactNumber(ByVal contactNo As String) As String
        ' Check if the contact number is at least 10 characters long
        If contactNo.Length < 11 Then
            Return contactNo ' Return as is if it's too short to format
        End If

        ' Format the contact number to hide the last 2 digits of the last 3 numbers
        Dim visibleFirst As String = contactNo.Substring(0, 9) ' First 7 digits visible
        Dim hiddenPart As String = "***" ' Replace the next 2 digits with asterisks
        Dim lastDigit As String = contactNo.Substring(contactNo.Length - 1) ' Keep the last digit visible

        ' Combine the parts
        Dim formatted As String = visibleFirst & hiddenPart & lastDigit
        Return formatted
    End Function

    Private Sub InsertPaperTrail(ByVal cPDSNo As String)
        Dim rsSMS As New ADODB.Recordset
        Dim lvSelstr As String
        con1.ConOleOpen()

        lvSelstr = "Insert Into tblPDSAccessLog (PDSNo, Module, Action, UserID, AccessDate) " & _
            "Values ('" & Trim(cPDSNo) & "', " & _
                    "'" & "SLEC-M360" & "', " & _
                    "'" & "Sent" & "', " & _
                    "'" & mvEmphash & "', " & _
                    " " & "GetDate()" & ")"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSelstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()
    End Sub

    Private Sub InsertMsgBoard(ByVal cPDSNo As String, ByVal cMessage As String)
        Dim rsSMS As New ADODB.Recordset
        Dim lvSelstr As String
        con1.ConOleOpen()

        lvSelstr = "Insert into tblMessages (PDSNo, Subject, Remarks, Encoder, MsgDate) " & _
                                         "Values ('" & cPDSNo & "', 'SendM360', " & _
                                          "'" & Repl(Trim(cMessage)) & " ', '" & mvEmphash & "', GetDate())"
        Dim cmdInsert As New OleDb.OleDbCommand(lvSelstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()
    End Sub

    Public Function Repl(ByVal Str As String) As String
        Repl = Replace(Str, "'", "''")
    End Function

    Private Sub InsertSMS(ByVal cPDSNo As String, ByVal cContact As String, ByVal cMessage As String, ByVal cSubject As String)
        Dim rsSMS As New ADODB.Recordset
        Dim lvSelstr As String

        con1.ConOleOpen()

        lvSelstr = "Insert into tblSMSPayload (PDSNO,MobileNo,MsgContent,MsgSent,UserID,UserDate, SmsSubject) " & _
                                " Values('" & Trim(cPDSNo) & "','" & cContact & "','" & Trim(Repl(cMessage)) & "','1','" & mvEmphash & "',Getdate(), '" & cSubject & "')"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSelstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()

    End Sub

    Private Function CheckMobileNo(ByVal cContactNo As String) As String

        Dim lvContactNos(10) As String
        Dim lvMobileNos(10) As String
        Dim lvTestStr As String
        Dim lvNumber As String
        Dim lvChar As Char
        Dim lvIdx1 As Integer
        Dim lvIdx2 As Integer
        Dim lvIdx3 As Integer

        lvContactNos = Split(cContactNo, "/")
        lvIdx3 = 0
        Dim strLength As String
        'Try
        For lvIdx1 = LBound(lvContactNos) To UBound(lvContactNos)

            lvTestStr = Trim(lvContactNos(lvIdx1))
            lvNumber = ""
            strLength = lvTestStr.Length
            For lvIdx2 = 0 To strLength - 1
                lvChar = lvTestStr.Substring(lvIdx2, 1)
                If lvIdx2 = 0 And lvChar = "+" Then
                    lvNumber = lvNumber + lvChar
                ElseIf Char.IsDigit(lvChar) Then
                    lvNumber = lvNumber + lvChar
                End If
            Next

            ' Melnard @ 2024-11-22: At the moment, PH mobile numbers only use the following formats:
            '   a. +638XXXXXXXXX or +639XXXXXXXXX (i.e., +638/+639 followed by 9 digits)
            '   b. 638XXXXXXXXX or 639XXXXXXXXX (i.e., 638/639 followed by 9 digits)
            '   c. 08XXXXXXXXX or 09XXXXXXXXX (i.e., 08/09 followed by 9 digits)
            '   d. 8XXXXXXXXX or 9XXXXXXXXX (i.e., 8/9 followed by 9 digits)

            If (lvNumber.StartsWith("+638") Or lvNumber.StartsWith("+639")) And lvNumber.Length = 13 Then
                lvMobileNos(lvIdx3) = lvNumber
                lvIdx3 = lvIdx3 + 1
            ElseIf (lvNumber.StartsWith("638") Or lvNumber.StartsWith("639")) And lvNumber.Length = 12 Then
                lvMobileNos(lvIdx3) = lvNumber
                lvIdx3 = lvIdx3 + 1
            ElseIf (lvNumber.StartsWith("08") Or lvNumber.StartsWith("09")) And lvNumber.Length = 11 Then
                lvMobileNos(lvIdx3) = lvNumber
                lvIdx3 = lvIdx3 + 1
            ElseIf (lvNumber.StartsWith("8") Or lvNumber.StartsWith("9")) And lvNumber.Length = 10 Then
                lvMobileNos(lvIdx3) = lvNumber
                lvIdx3 = lvIdx3 + 1
            End If

        Next

        If lvIdx3 > 0 Then
            CheckMobileNo = lvMobileNos(0)
        Else
            CheckMobileNo = ""
        End If
        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try


    End Function

    Private Sub txtPDSNO_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPDSNO.GotFocus
        txtPDSNO.BackColor = Color.Yellow
    End Sub

    Private Sub txtPDSNO_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPDSNO.LostFocus
        txtPDSNO.BackColor = Color.White
    End Sub

    Private Sub picClear_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
        'picClear.BackColor = Color.Green
    End Sub

    Private Function ConvertToSingleLine(ByVal input As String) As String
        ' Replace all new line characters with a space
        Dim singleLine As String = input.Replace(Environment.NewLine, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        ' Optionally, trim extra spaces
        singleLine = System.Text.RegularExpressions.Regex.Replace(singleLine, "\s+", " ").Trim()
        Return singleLine
    End Function

    Private Sub picSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSend.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Send all items?", _
                                                    "Confirm", _
                                                    MessageBoxButtons.YesNo, _
                                                    MessageBoxIcon.Question)

            If result = DialogResult.Yes Then


                Dim itemCount As Integer = lvReceiver.Items.Count
                ToolStripProgressBar1.Maximum = lvReceiver.Items.Count
                ToolStripProgressBar1.Visible = True
                txtConsole.Text = ""
                tstSuccess.Text = 0
                tstFail.Text = 0
                Dim i As Integer = 1
                'For Each item As ListViewItem In lvReceiver.Items
                For Each lvitem As ListViewItem In mvitem.Items
                    lvperson = CType(mvitem.Tag, clsPersonMessage)
                    ToolStripProgressBar1.Value = i
                    'Application.DoEvents()
                    'For index As Integer = 0 To item.SubItems.Count - 1

                    Console.WriteLine(lvitem.SubItems(0).Text & " - " & lvitem.SubItems(1).Text & " - " & lvitem.SubItems(2).Text & " - " & lvitem.SubItems(3).Text)
                    SendSMS(lvitem.SubItems(2).Text, lvitem.SubItems(3).Text)
                    txtConsole.Multiline = True
                    If Sent = True Then
                        txtConsole.SelectionColor = Color.Green
                        tstSuccess.Text = Val(tstSuccess.Text) + 1
                        txtConsole.AppendText("PDSNO: " & lvitem.SubItems(0).Text & Environment.NewLine & _
                                              "Fullname: " & lvitem.SubItems(1).Text & Environment.NewLine & _
                                              "Date And Time: " & Now & Environment.NewLine & _
                                              "Contact No: " & lvitem.SubItems(2).Text & Environment.NewLine & _
                                              "-------SUCCESSFUL---------" & Environment.NewLine)

                        InsertSMS(lvitem.SubItems(0).Text, lvitem.SubItems(2).Text, lvitem.SubItems(3).Text, lvitem.SubItems(4).Text)
                        If lvitem.SubItems(0).Text <> "" Then
                            InsertMsgBoard(lvitem.SubItems(0).Text, lvitem.SubItems(3).Text)
                            InsertPaperTrail(lvitem.SubItems(0).Text)
                        Else
                            'PDSNO = "" then Do nothing
                        End If
                        i = i + 1
                    Else
                        txtConsole.SelectionColor = Color.Red
                        tstFail.Text = Val(tstFail.Text) + 1
                        txtConsole.AppendText("PDSNO: " & lvitem.SubItems(0).Text & Environment.NewLine & _
                                              "Fullname: " & lvitem.SubItems(1).Text & Environment.NewLine & _
                                              "Date And Time: " & Now & Environment.NewLine & _
                                              "Contact No: " & lvitem.SubItems(2).Text & Environment.NewLine & _
                                              "-------FAILED---------" & Environment.NewLine)
                    End If
                Next
                txtPDSNO.Text = ""
                picSend.Enabled = False
                txtPDSNO.Focus()
                ToolStripProgressBar1.Visible = False

                If Sent = True Then
                    MsgBox("Message sent!", MsgBoxStyle.Information)
                Else
                    MsgBox("Message unsent! Please Verify the Contact No. Kindly verify contactno in Medscreen.", MsgBoxStyle.Information)
                End If

                mvContactNo = ""
                mvFirstName = ""

                Clear()
                lvReceiver.Items.Clear()
                mvitem.Items.Clear()
                lblcountReceiver.Text = 0
            Else
                'Nothing Happen
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSendSMS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmSendSMS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmSendSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtPDSNO.CharacterCasing = CharacterCasing.Upper
            txtSurname.CharacterCasing = CharacterCasing.Upper
            chkLocked.Checked = True
            txtSurname.Enabled = False
            txtContactno.Enabled = False
            grpSpecial.Visible = True
            grpSpecial.Enabled = True
            Me.Width = 818 'Ely @ 05292025
            Me.Height = 721 'Ely @ 05292025
            tstUser.Text = mvUserID
            'MsgBox(mvEmp)
            GetM360Pass()
            FillComboCateg()
            ToolStripProgressBar1.Visible = False
            Clear()
            lvReceiver.Items.Clear()
            tstSuccess.Text = 0
            tstFail.Text = 0
            lblcountReceiver.Text = 0
            ToolTip1.SetToolTip(picSend, "Send Message Here.")
            'ToolTip1.SetToolTip(picClear, "Clear Message.")
            ToolTip1.SetToolTip(txtPDSNO, "Enter PDSNO here.")
            ToolTip1.SetToolTip(cboFloor, "Select Category here.")
            ToolTip1.SetToolTip(cboLocation, "Select Location here.")
            ToolTip1.SetToolTip(btnAdd, "Press here to add Receiver.")
            ToolTip1.SetToolTip(lvReceiver, "List of all Receiver.")
            ToolTip1.SetToolTip(txtSurname, "Full Name of the Applicant.")
            ToolTip1.SetToolTip(txtContactno, "Contact Number of the Applicant.")
            ToolTip1.SetToolTip(lblcountReceiver, "Number of All Applicant to Receive SMS.")

            If GetEmphash(mvEmphash) = True Then
                grpSpecial.Visible = True
                grpSpecial.Enabled = True
                txtSurname.Enabled = True
                txtContactno.Enabled = True
            Else
                grpSpecial.Visible = False
                grpSpecial.Enabled = False
                txtSurname.Enabled = False
                txtContactno.Enabled = False
            End If

            'Me.ShowInTaskbar = True
            If CheckAccess(mvEmphash) = False Then
                lblPDSNO.Visible = True
                chkLocked.Checked = False
                chkLocked.Visible = False
                ToolStripLabel2.Visible = False
                ToolStripLabel2.Enabled = False
                chkLocked.Checked = True
                Exit Sub
            Else
                lblPDSNO.Visible = False
                chkLocked.Checked = True
                chkLocked.Visible = True
                ToolStripLabel2.Visible = True
                ToolStripLabel2.Enabled = True
                chkLocked.Checked = False
            End If
            mvitem.Items.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function GetEmphash(ByVal cEmphash As String) As Boolean
        Dim rsSpecial As New ADODB.Recordset
        Dim lvStr As String

        lvStr = "Select * from _tblEmployees where emphash = '" & cEmphash & "' "
        con1.ConOpen()
        With rsSpecial
            .Open(lvStr, con1.gvADODB)
            If Not .EOF Then
                '00348 - Mar Jorie D. Mamaril, R.N.
                '00178 - Josephine G. Galliguez, R.N.
                '00075 - Melnard D. Roque, Mr.
                '00278 - Nielmhar R. Calixton, MR.
                '00790 - ALFREN JAMES CABUQUIT                                                                               
                '00700 - Ely 
                If Trim(.Fields("emphash").Value.ToString) = "00348" Or _
                   Trim(.Fields("emphash").Value.ToString) = "00178" Or _
                   Trim(.Fields("emphash").Value.ToString) = "00075" Or _
                   Trim(.Fields("emphash").Value.ToString) = "00278" Or _
                   Trim(.Fields("emphash").Value.ToString) = "00790" Or _
                   Trim(.Fields("emphash").Value.ToString) = "00700" Then
                    GetEmphash = True
                Else
                    GetEmphash = False
                End If
            Else
                GetEmphash = False
            End If
        End With
        con1.ConClose()

    End Function

    Public Sub FillComboCateg()
        Dim rsFillData As New ADODB.Recordset
        Dim lvSelStr As String
        lvSelStr = "Select * from tblM360Template where MsgContent not like '%HR Department%' and Status = '1' order by TempCode Asc"
        cboFloor.Items.Clear()
        con1.ConOpen()
        With rsFillData
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                .MoveFirst()
                While Not .EOF
                    cboFloor.Items.Add(Trim(.Fields("TempCode").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
        con1.ConClose()

    End Sub

    'Ely @ 2025-05-15
    Private Sub GetM360Pass()
        Dim rsM360Pass As New ADODB.Recordset
        Dim lvStr As String

        lvStr = "Select * from tblsysteminfo where SystemName = 'M360' "

        con1.ConOpen()
        With rsM360Pass
            .Open(lvStr, con1.gvADODB)
            If Not .EOF Then
                gvAppKey = Trim(.Fields("AppKey").Value.ToString)
                gvAppSecret = Trim(.Fields("AppSecret").Value.ToString)
            End If
        End With
        con1.ConClose()

    End Sub

    'Private Sub picClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClear.Click
    '    Clear()
    '    txtPDSNO.Text = ""
    '    txtPDSNO.Focus()
    '    'optImmu.Checked = False
    '    'optDOT.Checked = False
    '    'optLaboratory.Checked = False
    'End Sub

    Private Sub cboFloor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboFloor.KeyPress
        e.Handled = True ' Suppress the key
    End Sub

    Private Sub cboFloor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFloor.LostFocus
        'cboLocation.Items.Clear()
        'If cboFloor.Text = "Ground Floor" Then
        '    'cboLocation.Items.Add("Reception")
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("Medical Records (US Related)")
        '    cboLocation.Items.Add("Medical Records (Other Countries)")
        '    If cboLocation.Text = "Medical Records (US Related)" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that we will be contact you shortly thru the number 09178144359 for verification regarding your medical examinations. Thank you."""
        '    End If

        '    If cboLocation.Text = "Medical Records (Other Countries)" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 85210020 local 605 from Mondays to Fridays, 8:00 AM - 3:00 PM thru 85210020 local 513 and look for _____. Thank you."
        '    End If

        'ElseIf cboFloor.Text = "2nd Floor" Then
        '    'cboLocation.Items.Add("Immunization")
        '    cboLocation.Text = "Immunization"
        '    txtMessage.Text = "Good day, " & lvFirstName & " Please proceed to the 2nd floor,Immunization Reception area."
        'ElseIf cboFloor.Text = "3rd Floor" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("X-ray Department")
        '    'cboLocation.Items.Add("Radiology")
        '    cboLocation.Text = "X-ray Department"
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - X-ray Dept. Please be advised that we will be contact you shortly thru the number 09178066740 for instructions regarding your medical examinations. Thank you."
        'ElseIf cboFloor.Text = "4th Floor" Then
        '    'cboLocation.Items.Add("Laboratory")
        '    cboLocation.Text = "Laboratory"
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - Lab Dept. Please be advised that we will be contact you shortly thru the number 09178265328 for instructions regarding your medical examinations. Thank you."
        'ElseIf cboFloor.Text = "5th Floor" Then
        '    'cboLocation.Items.Add("Checkout")
        '    cboLocation.Text = "Checkout"
        '    txtMessage.Text = "Good day, " & lvFirstName & " Please proceed to the 5th floor, Checkout waiting area."
        'ElseIf cboFloor.Text = "6th Floor" Then
        '    'cboLocation.Items.Add("Accounting")
        '    cboLocation.Text = "Accounting"
        'ElseIf cboFloor.Text = "Annex Ground Floor" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("DOT1")
        '    cboLocation.Items.Add("DOT2")
        '    cboLocation.Items.Add("SORTING")
        '    'cboLocation.Text = "DOT"
        '    If cboLocation.Text = "DOT1" Then
        '        txtMessage.Text = "Good day, " & lvFirstName & "This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will cal you shortly using the number 09178118465 or 09178312571 This is relation to your IGRA test result. For the purpose of ensuring confidentiality, We will be call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    ElseIf cboLocation.Text = "DOT2" Then
        '        txtMessage.Text = "Good day, Mr./Ms. This is to inform you that " & mvFirstname & " , one our clinical staff will be calling you today using the mobile number 09178118465 or 09178312571. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    ElseIf cboLocation.Text = "SORTING" Then
        '        txtMessage.Text = "Good day, Mr./Ms. " & lvFirstName & "This is to inform you that " & mvFirstname & " , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '        'Good day, Mr./Ms. _____. This is to inform you that _____ , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you.
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    End If
        'ElseIf cboFloor.Text = "BGC" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("BGC")
        '    If cboLocation.Text = "BGC" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 87897700 loc. 7002/7003 from Mondays to Fridays, 8:00 AM - 3:00 PM and look for _____. Thank you."
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    End If
        'End If
    End Sub

    Private Sub cboLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLocation.KeyPress
        e.Handled = True ' Suppress the key
    End Sub

    Private Sub cboLocation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocation.LostFocus
        'If cboLocation.Text = "Medical Records (US Related)" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that we will be contact you shortly thru the number 09178144359 for verification regarding your medical examinations. Thank you."""
        'End If

        'If cboLocation.Text = "Medical Records (Other Countries)" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 85210020 local 605 from Mondays to Fridays, 8:00 AM - 3:00 PM thru 85210020 local 513 and look for _____. Thank you."
        'End If

        'If cboLocation.Text = "X-ray Department" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - X-ray Dept. Please be advised that we will be contact you shortly thru the number 09178066740 for instructions regarding your medical examinations. Thank you."
        'End If
        'If cboLocation.Text = "Laboratory" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - Lab Dept. Please be advised that we will be contact you shortly thru the number 09178265328 for instructions regarding your medical examinations. Thank you."
        'End If

        'If cboLocation.Text = "DOT1" Then
        '    txtMessage.Text = "Good day, " & lvFirstName & "This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will cal you shortly using the number 09178118465 or 09178312571 This is relation to your IGRA test result. For the purpose of ensuring confidentiality, We will be call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
        '    lblCountText.Text = (Len(txtMessage.Text))
        'ElseIf cboLocation.Text = "DOT2" Then
        '    txtMessage.Text = "Good day, " & lvFirstName & "This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will cal you shortly using the number 09178118465 or 09178312571 This is relation to your IGRA test result. For the purpose of ensuring confidentiality, We will be call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
        '    lblCountText.Text = (Len(txtMessage.Text))
        'ElseIf cboLocation.Text = "SORTING" Then
        '    txtMessage.Text = "Good day, Mr./Ms. " & lvFirstName & "This is to inform you that " & mvEmp & " , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '    'Good day, Mr./Ms. _____. This is to inform you that _____ , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you.
        '    lblCountText.Text = (Len(txtMessage.Text))
        'End If

        'If cboLocation.Text = "BGC" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 87897700 loc. 7002/7003 from Mondays to Fridays, 8:00 AM - 3:00 PM and look for _____. Thank you."
        '    lblCountText.Text = (Len(txtMessage.Text))
        'End If


    End Sub

    'Ely @ 05292025
    Private Function MaskNumber(ByVal number As String) As String
        If number.Length >= 9 Then
            Return number.Substring(0, 4) & "*****" & number.Substring(number.Length - 2)
        Else
            Return number ' fallback if too short
        End If
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If chkLocked.Checked = False Then
            If txtSurname.Text = "" Then
                MsgBox("Invalid Input!, Please encode the Name of the Applicant.")
                txtSurname.Focus()
                Exit Sub
            ElseIf txtContactno.Text = "" Then
                MsgBox("Invalid Input!, Please encode the contact number.")
                txtContactno.Focus()
                Exit Sub
            Else
                AddReceiver(txtPDSNO.Text, txtSurname.Text, txtContactno.Text, txtMessage.Text, cboFloor.Text)
                picSend.Enabled = True
            End If

        Else
            If txtPDSNO.Text <> "" Then
                AddReceiver(txtPDSNO.Text, mvFirstName, lvAddContactno, txtMessage.Text, cboFloor.Text)
                txtPDSNO.Text = ""
                txtContactno.Text = ""
                txtSurname.Text = ""
                'txtMessage.Text = ""
                'txtPDSNO.Focus()
                lblcountReceiver.Text = Val(lblcountReceiver.Text) + 1
                picSend.Enabled = True
            Else
                MsgBox("Invalid Input.", MsgBoxStyle.Exclamation, "SendM360")
                txtPDSNO.Focus()
            End If

        End If



    End Sub

    Private Sub AddReceiver(ByVal cPDSNo As String, ByVal cFullname As String, ByVal cContact As String, ByVal cMessage As String, ByVal cSubject As String)
        Dim itmx As New ListViewItem
        Dim itmxy As New ListViewItem
        Dim lvMessage As String
        For Each item As ListViewItem In lvReceiver.Items
            If chkLocked.Checked = False Then
                If txtSurname.Text = "" Then
                    MsgBox("Invalid Input!, Please encode the Name of the Applicant.")
                    txtSurname.Focus()
                    Exit Sub
                ElseIf txtContactno.Text = "" Then
                    MsgBox("Invalid Input!, Please encode the contact number.")
                    txtContactno.Focus()
                    Exit Sub
                Else

                End If
            Else
                If item.Text = txtPDSNO.Text Then
                    MessageBox.Show("An item with the same PDSNO already exists!", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next

        'Console.WriteLine(cPDSNo & " - " & cFullname & " - " & cContact)

        itmx = mvitem.Items.Add(Trim(cPDSNo))
        itmx.SubItems.Add(Trim(cFullname))
        itmx.SubItems.Add(Trim(cContact))

        If chkLocked.Checked = True Then
            lvMessage = cMessage.Replace("[NAME]", GetFirstname(mvEmphash))
            itmx.SubItems.Add(Trim(lvMessage))
        Else
            lvMessage = cMessage.Replace("[NAME]", cFullname)
            itmx.SubItems.Add(Trim(lvMessage))
        End If
        itmx.SubItems.Add(Trim(cboFloor.Text))

        'Console.WriteLine(lvperson.gvPDSNO & " - " & lvperson.gvName & " - " & lvperson.gvContact & " - " & lvperson.gvMessage)
        itmxy = lvReceiver.Items.Add(Trim(cPDSNo))
        itmxy.SubItems.Add(Trim(cFullname))

        If CheckMobileNo(Trim(cContact)) <> "" Then
            itmxy.SubItems.Add(MaskNumber(Trim(cContact)))
        Else
            MsgBox("Please Check mobile Number." + vbInformation)
            txtContactno.Focus()
            Exit Sub
        End If


        If chkLocked.Checked = True Then
            lvMessage = cMessage.Replace("[NAME]", GetFirstname(mvEmphash))
            itmxy.SubItems.Add(Trim(lvMessage))
        Else
            lvMessage = cMessage.Replace("[NAME]", cFullname)
            itmxy.SubItems.Add(Trim(lvMessage))
        End If
        itmxy.SubItems.Add(Trim(cboFloor.Text))

        ListViewAlternateColor(lvReceiver, Color.LightBlue)
    End Sub

    Private Function GetFirstname(ByVal cEmphash As String) As String
        Dim rsGetFirstname As New ADODB.Recordset
        Dim lvSelStr As String
        GetFirstname = ""

        lvSelStr = "Select Trim(PatFname) + Trim(PatLname) as FULLNAME from tbltrans a, tblpatmast b " & _
                        "where a.patrefno = b.patrefno " & _
                             " and a.pdsno = '" & Trim(txtPDSNO.Text) & "' "
        cboLocation.Items.Clear()
        con1.ConOpen()
        With rsGetFirstname
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                GetFirstname = Trim(.Fields("FULLNAME").Value.ToString)
            End If
        End With
        con1.ConClose()

    End Function


    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click

        ' Display a MessageBox asking the user for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all items?", _
                                                     "Confirm Removal", _
                                                     MessageBoxButtons.YesNo, _
                                                     MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' Clear all items from the ListView
            lvReceiver.Items.Clear()
            lblcountReceiver.Text = 0
            MessageBox.Show("All items have been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPDSNO.Focus()
            Clear()

        Else
            'MessageBox.Show("No items were removed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If lvReceiver.SelectedItems.Count > 0 Then
            lvReceiver.Items.Remove(lvReceiver.SelectedItems(0))
            lblcountReceiver.Text = Val(lblcountReceiver.Text) - 1
        End If
    End Sub


   


    'Ely @ 05292025
    Private Sub ToggleOnOff_MessageLog()
        If isOnMessageLog Then
            ' Turn OFF
            isOnMessageLog = False
            Me.Width = 818
        Else
            ' Turn ON
            isOnMessageLog = True
            Me.Width = 1400
        End If
    End Sub



    Private Sub txtConsole_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        frmMaintenance.Text = "Setup Template"
        frmMaintenance.ShowDialog()
        'MsgBox("Maintenance ongoing!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub lvReceiver_ColumnWidthChanging(ByVal sender As System.Object, ByVal e As ColumnWidthChangingEventArgs) Handles lvReceiver.ColumnWidthChanging
        e.NewWidth = lvReceiver.Columns(e.ColumnIndex).Width
        e.Cancel = True
    End Sub

    Private Sub ListViewAlternateColor(ByVal oCtrl As ListView, ByVal oColor As Color)
        oCtrl.BackColor = oColor
        If TypeOf oCtrl Is ListView Then
            oCtrl.Sort()
            For i As Integer = 0 To oCtrl.Items.Count - 1
                If i Mod 2 = 0 Then
                    oCtrl.Items(i).BackColor = oColor
                Else
                    oCtrl.Items(i).BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub lvReceiver_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvReceiver.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = lvReceiver.Columns(e.Column)
        ' Figure out the new sorting order. 
        Dim sort_order As System.Windows.Forms.SortOrder
        If gvSortingColumn Is Nothing Then
            ' New column. Sort ascending. 
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column. 
            If new_sorting_column.Equals(gvSortingColumn) Then
                ' Same column. Switch the sort order. 
                If gvSortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending. 
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator. 
            gvSortingColumn.Text = gvSortingColumn.Text.Substring(2)
        End If
        ' Display the new sort order. 
        gvSortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            gvSortingColumn.Text = "> " & gvSortingColumn.Text
        Else
            gvSortingColumn.Text = "< " & gvSortingColumn.Text
        End If
        ' Create a comparer. 
        lvReceiver.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort and Alternate Color
        ListViewAlternateColor(lvReceiver, Color.LightBlue)
    End Sub

   

   

    Private Sub FillDescription(ByVal cTempCode As String)
        Dim rsFillDescription As New ADODB.Recordset
        Dim lvSelStr As String
        Dim lvDescription As String
        Dim lvSetDescription As String

        lvSelStr = "Select * from tblM360Template where  MsgContent not like '%HR Department%' and TempCode = '" & cTempCode & "' and Status = '1' order by TempCode Asc"
        cboLocation.Items.Clear()
        con1.ConOpen()
        With rsFillDescription
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                lvDescription = Trim(.Fields("Description").Value.ToString)
                lvSetDescription = lvDescription.Replace([Name], mvFirstName)
                cboLocation.Text = Trim(.Fields("Description").Value.ToString)
                txtMessage.Text = Trim(.Fields("MsgContent").Value.ToString)
                'tstTxtCount.Text = Len(txtMessage.Text)
            End If
        End With
        con1.ConClose()

    End Sub

    Private Sub cboFloor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cboFloor.MouseClick
        FillDescription(cboFloor.Text)
    End Sub

    Private Sub cboFloor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFloor.SelectedIndexChanged
        FillDescription(cboFloor.Text)
        'cboLocation.Items.Clear()
        'If cboFloor.Text = "Ground Floor" Then
        '    'cboLocation.Items.Add("Reception")
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("Medical Records (US Related)")
        '    cboLocation.Items.Add("Medical Records (Other Countries)")
        '    If cboLocation.Text = "Medical Records (US Related)" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that we will be contact you shortly thru the number 09178144359 for verification regarding your medical examinations. Thank you."""
        '    End If

        '    If cboLocation.Text = "Medical Records (Other Countries)" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 85210020 local 605 from Mondays to Fridays, 8:00 AM - 3:00 PM thru 85210020 local 513 and look for _____. Thank you."
        '    End If

        'ElseIf cboFloor.Text = "2nd Floor" Then
        '    'cboLocation.Items.Add("Immunization")
        '    cboLocation.Text = "Immunization"
        '    txtMessage.Text = "Good day, " & lvFirstName & " Please proceed to the 2nd floor,Immunization Reception area."
        'ElseIf cboFloor.Text = "3rd Floor" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("X-ray Department")
        '    'cboLocation.Items.Add("Radiology")
        '    cboLocation.Text = "X-ray Department"
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - X-ray Dept. Please be advised that we will be contact you shortly thru the number 09178066740 for instructions regarding your medical examinations. Thank you."
        'ElseIf cboFloor.Text = "4th Floor" Then
        '    'cboLocation.Items.Add("Laboratory")
        '    cboLocation.Text = "Laboratory"
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - Lab Dept. Please be advised that we will be contact you shortly thru the number 09178265328 for instructions regarding your medical examinations. Thank you."
        'ElseIf cboFloor.Text = "5th Floor" Then
        '    'cboLocation.Items.Add("Checkout")
        '    cboLocation.Text = "Checkout"
        '    txtMessage.Text = "Good day, " & lvFirstName & " Please proceed to the 5th floor, Checkout waiting area."
        'ElseIf cboFloor.Text = "6th Floor" Then
        '    'cboLocation.Items.Add("Accounting")
        '    cboLocation.Text = "Accounting"
        'ElseIf cboFloor.Text = "Annex Ground Floor" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("DOT1")
        '    cboLocation.Items.Add("DOT2")
        '    cboLocation.Items.Add("SORTING")
        '    'cboLocation.Text = "DOT"
        '    If cboLocation.Text = "DOT1" Then
        '        txtMessage.Text = "Good day, " & lvFirstName & "This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will cal you shortly using the number 09178118465 or 09178312571 This is relation to your IGRA test result. For the purpose of ensuring confidentiality, We will be call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    ElseIf cboLocation.Text = "DOT2" Then
        '        txtMessage.Text = "Good day, Mr./Ms. This is to inform you that " & mvFirstname & " , one our clinical staff will be calling you today using the mobile number 09178118465 or 09178312571. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    ElseIf cboLocation.Text = "SORTING" Then
        '        txtMessage.Text = "Good day, Mr./Ms. " & lvFirstName & "This is to inform you that " & mvFirstname & " , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '        'Good day, Mr./Ms. _____. This is to inform you that _____ , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you.
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    End If
        'ElseIf cboFloor.Text = "BGC" Then
        '    cboLocation.Items.Clear()
        '    cboLocation.Items.Add("BGC")
        '    If cboLocation.Text = "BGC" Then
        '        txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 87897700 loc. 7002/7003 from Mondays to Fridays, 8:00 AM - 3:00 PM and look for _____. Thank you."
        '        lblCountText.Text = (Len(txtMessage.Text))
        '    End If
        'End If
    End Sub

    Private Sub cboLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocation.SelectedIndexChanged
        'If cboLocation.Text = "Medical Records (US Related)" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that we will be contact you shortly thru the number 09178144359 for verification regarding your medical examinations. Thank you."""
        'End If

        'If cboLocation.Text = "Medical Records (Other Countries)" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 85210020 local 605 from Mondays to Fridays, 8:00 AM - 3:00 PM thru 85210020 local 513 and look for _____. Thank you."
        'End If

        'If cboLocation.Text = "X-ray Department" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - X-ray Dept. Please be advised that we will be contact you shortly thru the number 09178066740 for instructions regarding your medical examinations. Thank you."
        'End If
        'If cboLocation.Text = "Laboratory" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic - Lab Dept. Please be advised that we will be contact you shortly thru the number 09178265328 for instructions regarding your medical examinations. Thank you."
        'End If

        'If cboLocation.Text = "DOT1" Then
        '    txtMessage.Text = "Good day, " & lvFirstName & "This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will cal you shortly using the number 09178118465 or 09178312571 This is relation to your IGRA test result. For the purpose of ensuring confidentiality, We will be call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
        '    lblCountText.Text = (Len(txtMessage.Text))
        'ElseIf cboLocation.Text = "DOT2" Then
        '    txtMessage.Text = "Good day, Mr./Ms. This is to inform you that " & mvFirstname & " , one our clinical staff will be calling you today using the mobile number 09178118465 or 09178312571. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '    lblCountText.Text = (Len(txtMessage.Text))
        'ElseIf cboLocation.Text = "SORTING" Then
        '    txtMessage.Text = "Good day, Mr./Ms. " & lvFirstName & "This is to inform you that " & mvEmp & " , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you."
        '    'Good day, Mr./Ms. _____. This is to inform you that _____ , one our clinical staff will be calling you today using the mobile number 09178118465. He/she will be providing you with instructions regarding your medical examination process/results. Please be assured that this is a legitimate call from St. Luke’s Medical Center Extension Clinic. Thank you.
        '    lblCountText.Text = (Len(txtMessage.Text))
        'End If

        'If cboLocation.Text = "BGC" Then
        '    txtMessage.Text = "Magandang araw! This is from St. Luke’s Medical Center Extension Clinic. Please be advised that clinic staff have made attempts to contact you via your mobile and email address but have been unable to reach you. In line with this, may we request that you call us thru 87897700 loc. 7002/7003 from Mondays to Fridays, 8:00 AM - 3:00 PM and look for _____. Thank you."
        '    lblCountText.Text = (Len(txtMessage.Text))
        'End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmMessageLog.ShowDialog()
    End Sub

    Private Sub txtMessage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMessage.KeyPress
        e.Handled = True
    End Sub


    Private Sub chkLocked_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLocked.Click
        If chkLocked.Checked = True Then
            txtSurname.Text = ""
            txtSurname.Enabled = False
            txtContactno.Text = ""
            txtContactno.Enabled = False
            txtPDSNO.Enabled = True
            txtPDSNO.Focus()
            txtPDSNO.BackColor = Color.Yellow
            'txtSurname.BackColor = Color.Gray
        Else
            txtSurname.Text = ""
            txtSurname.Enabled = True
            txtContactno.Text = ""
            txtContactno.Enabled = True
            txtPDSNO.Enabled = False
            txtPDSNO.Text = ""
            txtSurname.Focus()
            txtSurname.BackColor = Color.Yellow
            'txtPDSNO.BackColor = Color.Gray
        End If

    End Sub

    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress
        If chkLocked.Checked = True Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso _
             e.KeyChar <> "'" AndAlso _
            Not Char.IsWhiteSpace(e.KeyChar) AndAlso _
            Not Char.IsControl(e.KeyChar) Then

            e.Handled = True ' Block everything except letters, apostrophe, and control keys
        End If

     
    End Sub

    Private Sub txtSurname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSurname.LostFocus
        txtSurname.BackColor = Color.White
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        ToggleOnOff_MessageLog()
    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        tstTxtCount.Text = Len(txtMessage.Text)
    End Sub


    Private Sub txtContactno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactno.KeyPress
        If chkLocked.Checked = True Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block non-numeric keys
        End If

    End Sub


    Private Sub txtSurname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSurname.TextChanged

    End Sub

    Private Sub txtContactno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContactno.TextChanged

    End Sub

    Private Sub lblPDSNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPDSNO.Click

    End Sub

    Private Sub chkLocked_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocked.CheckedChanged

    End Sub
End Class
