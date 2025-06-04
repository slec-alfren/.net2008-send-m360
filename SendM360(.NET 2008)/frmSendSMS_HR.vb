
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmSendSMS_HR
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
    Public mvEmp As String

    Public gvSortingColumn As ColumnHeader

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtContactno.Text <> "" Then
            AddReceiver(txtPDSNO.Text, txtSurname.Text, CheckMobileNo(txtContactno.Text), txtMessage.Text)
            txtPDSNO.Text = ""
            lblContactno.Text = ""
            lblSurname.Text = ""
            txtMessage.Text = ""
            txtSurname.Text = ""
            txtContactno.Text = ""
            txtPDSNO.Focus()
            lblcountReceiver.Text = Val(lblcountReceiver.Text) + 1
        ElseIf lblContactno.Text <> "<>" Then
            AddReceiver(txtPDSNO.Text, lblSurname.Text, CheckMobileNo(lvAddContactno), txtMessage.Text)
            txtPDSNO.Text = ""
            lblContactno.Text = ""
            lblSurname.Text = ""
            txtMessage.Text = ""
            txtPDSNO.Focus()
            lblcountReceiver.Text = Val(lblcountReceiver.Text) + 1
        Else
            MsgBox("Invalid Input!.")
        End If
    End Sub

    Private Sub txtContactno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactno.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddReceiver(ByVal cPDSNo As String, ByVal cFullname As String, ByVal cContact As String, ByVal cMessage As String)
        Dim itmx As New ListViewItem
        For Each item As ListViewItem In lvReceiver.Items
            'If cboCategory.Text = "SLEC Employee" Then
            If txtPDSNO.Text <> "" Then
                If item.Text = txtPDSNO.Text Then
                    MessageBox.Show("An item with the same DTRNo already exists!", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        itmx = lvReceiver.Items.Add(Trim(cPDSNo))
        itmx.SubItems.Add(Trim(cFullname))
        itmx.SubItems.Add(Trim(cContact))
        itmx.SubItems.Add(Trim(cMessage))
        ListViewAlternateColor(lvReceiver, Color.LightBlue)
    End Sub

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
        Else
            'MessageBox.Show("No items were removed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Clear()
        lblSurname.Text = "<>"
        'lblGivenname.Text = ""
        'lblMiddleName.Text = ""
        lblContactno.Text = "<>"
        'txtMessage.Text = ""
        picSend.Enabled = False
        txtContactno.Text = ""
        txtMessage.Text = ""

        'picAppPhoto.Image = SLEC_SendmySMS.My.Resources.Resources.Unknown
        'picSend.Image = SLEC_SendmySMS.My.Resources.Resources.senddisabled
        cboCategory.Items.Clear()
        'cboCategory.Items.Add("SLEC Employee")
        'cboCategory.Items.Add("Job Interview")
        'mvEmp = ""
        'mvEmphash = ""
        'mvContactNo = ""
    End Sub

    Private Sub txtPDSNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPDSNO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Clear()
            If Trim(txtPDSNO.Text) <> "" Then
                FillData(txtPDSNO.Text)
                'txtMessage.Text = "Good day, " & lblSurname.Text & " Good day, This Is St.Luke 's Medical Center Extension Clinic. Please be advised that we will have one of our clinical staffs will call you shortly using the number 09178118465 or 09178312571 This is in relation to your IGRA test result. For the purpose of ensuring confidentiality, We will call you via a viber account for a video call. If you do not have a viber account yet, we request that you download the application. Thank you. SLEC"
                'picSend.Image = SLEC_SendmySMS.My.Resources.Resources.send1
            Else
            End If

        End If
    End Sub

    Private Sub FillData(ByVal cDTRNo As String)
        Try


            Dim lvSelStr As String
            Dim rsFilldata As New ADODB.Recordset
            Dim lvPre As String
            lvPre = ""
            lvSelStr = "Select Gender, Surname, GivenName, MiddleName, Mobileno " & _
                                "From tbl201_Employee " & _
                                    "Where DTRNo = '" & cDTRNo & "' " & _
                                        "and Employstat not in('Retired', 'Terminated', 'End-of-Contract','Resigned', 'Project-based', 'Trainee', 'On-Duty')"

            rsFilldata = New ADODB.Recordset
            con2.ConDBConnopen()
            With rsFilldata
                .Open(lvSelStr, con2.gvDBConn)
                If Not .EOF Then
                    If Trim(.Fields("Gender").Value.ToString) = "Male" Then
                        lvPre = "Mr. "
                    ElseIf Trim(.Fields("Gender").Value.ToString) = "Female" Then
                        lvPre = "Ms. "
                    End If
                    lblSurname.Text = lvPre + Trim(.Fields("Surname").Value.ToString) + ", " + Trim(.Fields("GivenName").Value.ToString)
                    'lblGivenname.Text = Trim(.Fields("PatFName").Value.ToString)
                    'lblMiddleName.Text = Trim(.Fields("PatMName").Vaslue.ToString)
                    'CheckMobileNo(Trim(.Fields("Telno").Value.ToString))

                    lvAddContactno = CheckMobileNo(Trim(.Fields("Mobileno").Value.ToString))
                    lblContactno.Text = CheckMobileNo(Trim(.Fields("Mobileno").Value.ToString))
                    Dim contact As String = CheckMobileNo(Trim(.Fields("Mobileno").Value.ToString))
                    mvContactNo = contact
                    Dim formattedContact As String = FormatContactNumber(contact)
                    lblContactno.Text = formattedContact
                    Console.WriteLine(formattedContact) ' Output: 9876543**0

                    'ShowPicture(picAppPhoto, txtPDSNO.Text, Trim(.Fields("VisitDate").Value.ToString), Trim(.Fields("Country").Value.ToString))
                    picSend.Enabled = True
                Else
                    MsgBox("Invalid DTRNO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SendmyMessage")
                    'picAppPhoto.Image = SLEC_SendmySMS.My.Resources.Resources.Unknown
                End If
                .Close()
            End With
            con2.ConDBConnClose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillDataMessageLog(ByVal cQuery As String)
        Try


            Dim itmx As New ListViewItem
            ' tblSMSPayload (PDSNO,MobileNo,MsgContent,MsgSent,UserID,UserDate)
            Dim lvSelStr As String
            Dim rsFilldata As New ADODB.Recordset
            Dim lvPre As String
            lvMessageLog.Items.Clear()
            lvPre = ""
            lvSelStr = "Select Top 500 PDSNo, MobileNo, MsgContent, UserDate From tblSMSPayload where " & cQuery & " and MsgContent like '%HR Department%' order by UserDate desc"
            con1.ConOpen()
            With rsFilldata
                .Open(lvSelStr, con1.gvADODB)
                If Not .EOF Then
                    Do While Not .EOF
                        itmx = lvMessageLog.Items.Add(Trim(.Fields("PDSNo").Value.ToString))
                        itmx.SubItems.Add(Trim(.Fields("MobileNo").Value.ToString))
                        itmx.SubItems.Add(Trim(.Fields("MsgContent").Value.ToString))
                        itmx.SubItems.Add(Trim(.Fields("UserDate").Value.ToString))
                        .MoveNext()
                    Loop
                Else
                    MsgBox("No Record Found!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SendmyMessage")
                End If
                .Close()
            End With
            con1.ConClose()
            ListViewAlternateColor(lvMessageLog, Color.LightBlue)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                    "'" & "Send" & "', " & _
                    "'" & con1.gvValUserEmpHash & "', " & _
                    " " & "GetDate()" & ")"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSelstr, con1.gvDBConn)
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

    Private Function Repl(ByVal Str As String) As String
        Repl = Replace(Str, "'", "''")
    End Function

    Private Sub InsertSMS(ByVal cPDSNo As String, ByVal cContact As String, ByVal cMessage As String)
        Dim rsSMS As New ADODB.Recordset
        Dim lvSelstr As String

        con1.ConOleOpen()

        lvSelstr = "Insert into tblSMSPayload (PDSNO,MobileNo,MsgContent,MsgSent,UserID,UserDate) " & _
                                " Values('" & Trim(cPDSNo) & "','" & cContact & "','" & Trim(Repl(cMessage)) & "','1','" & mvEmphash & "',Getdate())"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSelstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()

    End Sub


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ToggleOnOff()
    End Sub

    Private Sub ToggleOnOff()
        If isOn Then
            ' Turn OFF
            isOn = False
            Me.Height = 569
        Else
            ' Turn ON
            isOn = True
            Me.Height = 800
        End If
    End Sub

    Private Sub picClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClear.Click
        Clear()
        txtPDSNO.Text = ""
        txtPDSNO.Focus()
        'optImmu.Checked = False
        'optDOT.Checked = False
        'optLaboratory.Checked = False
    End Sub

    Private Sub picSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSend.Click
        Try
            Dim itemCount As Integer = lvReceiver.Items.Count
            ToolStripProgressBar1.Maximum = lvReceiver.Items.Count
            ToolStripProgressBar1.Visible = True
            txtConsole.Text = ""
            lblSuccessCount.Text = 0
            lblFailed.Text = 0
            Dim i As Integer = 1
            For Each item As ListViewItem In lvReceiver.Items
                'For index As Integer = 0 To item.SubItems.Count - 1
                SendSMS(item.SubItems(2).Text, item.SubItems(3).Text)
                txtConsole.Multiline = True
                If Sent = True Then
                    ToolStripProgressBar1.Value = i
                    txtConsole.SelectionColor = Color.Green
                    lblSuccessCount.Text = Val(lblSuccessCount.Text) + 1
                    txtConsole.AppendText("Fullname: " & item.SubItems(1).Text & Environment.NewLine & _
                                          "Date And Time: " & Now & Environment.NewLine & _
                                          "Contact No: " & item.SubItems(2).Text & Environment.NewLine & _
                                          "-------SUCCESSFUL---------" & Environment.NewLine)
                    InsertSMS(item.SubItems(0).Text, item.SubItems(2).Text, item.SubItems(3).Text)
                    FillDataMessageLog("MsgSent = 1")
                Else
                    txtConsole.SelectionColor = Color.Red
                    lblFailed.Text = Val(lblFailed.Text) + 1
                    txtConsole.AppendText("DTRNo: " & item.SubItems(0).Text & Environment.NewLine & _
                                          "Fullname: " & item.SubItems(1).Text & Environment.NewLine & _
                                          "Date And Time: " & Now & Environment.NewLine & _
                                          "Contact No: " & item.SubItems(2).Text & Environment.NewLine & _
                                          "-------FAILED---------" & Environment.NewLine)
                End If
            Next
            txtPDSNO.Text = ""
            picSend.Enabled = False
            txtPDSNO.Focus()

            If Sent = True Then
                MsgBox("Message sent!", MsgBoxStyle.Information)
            Else
                MsgBox("Message unsent! Please Verify the Contact No. Kindly verify contactno in Medscreen.", MsgBoxStyle.Information)
            End If
            mvContactNo = ""
            Clear()
            lvReceiver.Items.Clear()
            lblcountReceiver.Text = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Function ConvertToSingleLine(ByVal input As String) As String
    '    ' Replace all new line characters with a space
    '    Dim singleLine As String = input.Replace(Environment.NewLine, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
    '    ' Optionally, trim extra spaces
    '    singleLine = System.Text.RegularExpressions.Regex.Replace(singleLine, "\s+", " ").Trim()
    '    Return singleLine
    'End Function

    Private Function ConvertToSingleLine(ByVal input As String) As String
        ' Normalize line endings to vbLf to simplify processing
        Dim normalized As String = input.Replace(vbCrLf, vbLf).Replace(vbCr, vbLf)

        ' Preserve paragraph breaks: temporarily mark them with a unique placeholder
        normalized = System.Text.RegularExpressions.Regex.Replace(normalized, vbLf & "{2,}", "[[PARA]]")

        ' Replace remaining single line breaks with a space
        normalized = normalized.Replace(vbLf, " ")

        ' Restore paragraph breaks
        normalized = normalized.Replace("[[PARA]]", Environment.NewLine & Environment.NewLine)

        ' Clean up multiple spaces
        normalized = System.Text.RegularExpressions.Regex.Replace(normalized, "\s+", " ").Trim()

        Return normalized
    End Function

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


    Private Sub lvMessageLog_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvMessageLog.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = lvMessageLog.Columns(e.Column)
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
        lvMessageLog.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort and Alternate Color
        ListViewAlternateColor(lvMessageLog, Color.LightBlue)
    End Sub

    Private Sub SendSMS(ByVal cCPNumber As String, ByVal cMessage As String)
        'MsgBox(mvEmp)
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

            'InsertPaperTrail(txtPDSNO.Text)

        Catch ex As WebException
            ' Handle errors
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    Console.WriteLine("Error Response: " & reader.ReadToEnd())
                    MsgBox(ex.Message + "Please Report this to IT" & reader.ReadToEnd())
                    Sent = False
                End Using
                Exit Sub
            Else
                Console.WriteLine("Error: " & ex.Message)
                MsgBox(ex.Message + "Please Report this to IT")
                Sent = False
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub frmSendSMS_HR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
        'frmMSS_Login.ShowDialog()
    End Sub

    Private Sub frmSendSMS_HR_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
        'frmMSS_Login.ShowDialog()
    End Sub

    Private Sub frmSendSMS_HR_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmSendSMS_HR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetM360Pass()
        FillDataMessageLog("MsgSent = 1")
        FillComboCateg()
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

    Private Sub PicSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSearch.Click
        FillDataMessageLog("UserDate Between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & " 00:00:00' And '" & Format(dtpTo.Value, "yyyy-MM-dd") & " 23:59:59' ")
    End Sub

    Private Sub cboCategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True ' Suppress the key
    End Sub

    Private Sub cboCategory_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.LostFocus
        FillDescription(cboCategory.Text)
        'If cboCategory.Text = "SLEC Employee" Then
        '    txtPDSNO.Enabled = True
        '    txtSurname.Text = ""
        '    txtSurname.Enabled = False
        '    txtContactno.Text = ""
        '    txtContactno.Enabled = False
        '    txtMessage.Text = "Magandang Araw! This is St. Luke's Extension Clinic - HR Department. Please check your email or visit the HR office at your earliest convenience. If you have any questions, feel free to email us at hrd@slec.ph or call us at local 514."
        'ElseIf cboCategory.Text = "Job Applicants" Then
        '    txtPDSNO.Text = ""
        '    txtPDSNO.Enabled = False
        '    txtSurname.Text = ""
        '    txtSurname.Enabled = True
        '    txtContactno.Text = ""
        '    txtContactno.Enabled = True
        '    txtMessage.Text = "Magandang Araw! This is St. Luke's Extension Clinic - HR department. This is in regards your job application with us. Kindly check your email for the details. If you have any questions, you may contact us at 8521-0020 local 514 or email us at hrd@slec.ph."
        'End If

    End Sub


    Private Sub cmdCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCount.Click
        lblCountText.Text = Len(txtMessage.Text)
    End Sub

    Private Sub tslMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tslMaintenance.Click
        frmMaintenance.Text = "HR - Setup Template"
        frmMaintenance.ShowDialog()
    End Sub

    Public Sub FillComboCateg()
        Dim rsFillData As New ADODB.Recordset
        Dim lvSelStr As String
        lvSelStr = "Select * from tblM360Template where MsgContent like '%HR Department%' and Status = '1' order by TempCode Asc"
        cboCategory.Items.Clear()
        con1.ConOpen()
        With rsFillData
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                .MoveFirst()
                While Not .EOF
                    cboCategory.Items.Add(Trim(.Fields("TempCode").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
        con1.ConClose()

    End Sub

    Private Sub FillDescription(ByVal cTempCode As String)
        Dim rsFillDescription As New ADODB.Recordset
        Dim lvSelStr As String
        lvSelStr = "Select * from tblM360Template where MsgContent like '%HR Department%' and TempCode = '" & cTempCode & "'"
        txtDescription.Text = ""
        con1.ConOpen()
        With rsFillDescription
            .Open(lvSelStr, con1.gvADODB)
            If Not .EOF Then
                txtDescription.Text = Trim(.Fields("Description").Value.ToString)
                txtMessage.Text = Trim(.Fields("MsgContent").Value.ToString)
            End If
        End With
        con1.ConClose()

    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        FillDescription(cboCategory.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If lvReceiver.SelectedItems.Count > 0 Then
            lvReceiver.Items.Remove(lvReceiver.SelectedItems(0))
            lblcountReceiver.Text = Val(lblcountReceiver.Text) - 1
        End If
    End Sub

    Private Sub txtDescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress
        e.Handled = True ' Suppress the key
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged

    End Sub
End Class