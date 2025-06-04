Public Class frmMaintenance
    Dim con1 As New clsConnection
    Dim con2 As New clsConnection
    Dim mvUpdate As Boolean
    Dim mvRecID As Integer
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim lvStatus As String
        Try

            If chkStatus.Checked = True Then
                lvStatus = 1
            Else
                lvStatus = 0
            End If

            If ValidateEntry() = True Then
                If Me.Text = "HR - Setup Template" Then
                    If mvUpdate = True Then
                        CheckField(mvRecID, "UPDATE", txtTempCode.Text, txtDescription.Text, txtMessage.Text, txtRemarks.Text, lvStatus)
                        UpdateDataHR(txtTempCode.Text)
                        FillDataTempChoose("MsgContent like '%HR Department%'")
                        frmSendSMS_HR.FillComboCateg()
                        MsgBox("Update Successful!")
                        mvUpdate = False
                        mvRecID = 0
                    Else
                        SaveDataHR(mvEmphash)
                        SaveEditLog("ADD", txtTempCode.Text, txtTempCode.Text, "", txtTempCode.Text)
                        FillDataTempChoose("MsgContent like '%HR Department%'")
                        frmSendSMS_HR.FillComboCateg()
                        MsgBox("Saved Successful!")
                    End If
                ElseIf Me.Text = "Setup Template" Then
                    If mvUpdate = True Then
                        CheckField(mvRecID, "UPDATE", txtTempCode.Text, txtDescription.Text, txtMessage.Text, txtRemarks.Text, lvStatus)
                        UpdateData(txtTempCode.Text)
                        FillDataTempChoose("MsgContent not like '%HR Department%'")
                        frmSendSMS.FillComboCateg()
                        MsgBox("Update Successful!")
                        mvUpdate = False
                        mvRecID = 0
                    Else
                        SaveData(mvEmphash)
                        SaveEditLog("ADD", txtTempCode.Text, txtTempCode.Text, "", txtTempCode.Text)
                        FillDataTempChoose("MsgContent not like '%HR Department%'")
                        frmSendSMS.FillComboCateg()
                        MsgBox("Saved Successful!")
                    End If

                End If

            End If
            Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Function CheckField(ByVal cRecID As String, ByVal cAction As String, ByVal cTempCode As String, ByVal cDescription As String, ByVal cMsgContent As String, ByVal cRemarks As String, ByVal cStatus As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        Dim lvTempCode As String = ""
        Dim lvDescription As String = ""
        Dim lvMsgContent As String = ""
        Dim lvRemarks As String = ""
        Dim lvStatus As String = ""

        lvSqlstr = "Select * from tblM360Template where RecID = '" & cRecID & "'"
        con1.ConOpen()
        With rsSaveData
            .Open(lvSqlstr, con1.gvADODB)
            If Not .EOF Then
                lvTempCode = Trim(.Fields("TempCode").Value.ToString)
                lvDescription = Trim(.Fields("Description").Value.ToString)
                lvMsgContent = Trim(.Fields("MsgContent").Value.ToString)
                lvRemarks = Trim(.Fields("Remarks").Value.ToString)
                lvStatus = Trim(.Fields("Status").Value.ToString)
            End If
        End With
        con1.ConClose()

        If cTempCode <> lvTempCode Then
            SaveEditLog(cAction, lvTempCode, "TempCode", lvTempCode, cTempCode)
        End If

        If cDescription <> lvDescription Then
            SaveEditLog(cAction, lvTempCode, "Description", lvDescription, cDescription)
        End If

        If cMsgContent <> lvMsgContent Then
            SaveEditLog(cAction, lvTempCode, "MsgContent", lvMsgContent, cMsgContent)
        End If

        If cRemarks <> lvRemarks Then
            SaveEditLog(cAction, lvTempCode, "Remarks", lvRemarks, cRemarks)
        End If

        If cStatus <> lvStatus Then
            SaveEditLog(cAction, lvTempCode, "Status", lvStatus, cStatus)
        End If
        CheckField = ""
    End Function

    Private Sub UpdateDataHR(ByVal cTempCode As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        Dim lvStatus As Integer

        If chkStatus.Checked = True Then
            lvStatus = 1
        Else
            lvStatus = 0
        End If

        con1.ConDBConnopen()

        lvSqlstr = "Update tblM360Template " & _
                        "set Description = '" & Trim(Repl_All(txtDescription.Text)) & "', " & _
                        "MsgContent = '" & Trim(Repl_All(txtMessage.Text)) & "', " & _
                        "Remarks = '" & Trim(Repl_All(txtRemarks.Text)) & "', " & _
                        "EncDate = Getdate(), " & _
                        "Encby = '" & mvEmphash & "', " & _
                        "Status = '" & lvStatus & "', " & _
                        "TempCode = '" & txtTempCode.Text & "' " & _
                   "Where RecID = '" & mvRecID & "'"

        'MsgBox(lvSqlstr)
        Dim cmdUpdate As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdUpdate.ExecuteNonQuery()

        con1.ConDBConnClose()
    End Sub

    Private Function ValidateEntry() As Boolean
        If txtTempCode.Text <> "" Then
            ValidateEntry = True
            txtTempCode.BackColor = Color.White
        ElseIf txtTempCode.Text = "" Then
            txtTempCode.Focus()
            txtTempCode.BackColor = Color.Yellow
            ValidateEntry = False
        ElseIf txtDescription.Text <> "" Then
            txtDescription.BackColor = Color.White
            ValidateEntry = True
        ElseIf txtDescription.Text = "" Then
            txtDescription.Focus()
            txtDescription.BackColor = Color.Yellow
            ValidateEntry = False
        ElseIf txtMessage.Text <> "" Then
            txtMessage.Focus()
            txtMessage.BackColor = Color.White
            ValidateEntry = True
        ElseIf txtMessage.Text = "" Then
            txtMessage.Focus()
            txtMessage.BackColor = Color.Yellow
            ValidateEntry = False
        ElseIf txtRemarks.Text <> "" Then
            txtRemarks.Focus()
            txtRemarks.BackColor = Color.White
            ValidateEntry = True
        ElseIf txtRemarks.Text = "" Then
            txtRemarks.Focus()
            txtRemarks.BackColor = Color.Yellow
            ValidateEntry = False
        End If
    End Function

    Function GetID(ByVal cTempCode As String) As Integer
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        lvSqlstr = "Select * from tblM360Template where TempCode = '" & cTempCode & "'"

        With rsSaveData
            .Open(lvSqlstr, con1.gvADODB)
            If Not .EOF Then
                GetID = Trim(.Fields("RecID").Value.ToString)
            Else
                GetID = 0
            End If
        End With

    End Function

    Private Sub SaveEditLog(ByVal cAction As String, ByVal cTempCode As String, ByVal cFieldName As String, ByVal cOldField As String, ByVal cNewField As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String

        lvSqlstr = "Insert into tblSMSTemp_editlog (FieldName, OldValue, NewValue, Editby, EditDate) " & _
                               " Values('" & cAction & " - " & cTempCode & " - " & cFieldName & "','" & cOldField & "','" & cNewField & "','" & mvEmphash & "' ,Getdate())"
        con1.ConOleOpen()

        Dim cmdInsert As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()
    End Sub

    Private Sub SaveDataHR(ByVal cEmphash As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        Dim lvStatus As Integer

        If chkStatus.Checked = True Then
            lvStatus = 1
        Else
            lvStatus = 0
        End If

        con1.ConDBConnopen()

        lvSqlstr = "Insert into tblM360Template (TempCode, Description, MsgContent, Remarks, EncDate, Encby, Status) " & _
                                " Values('" & Trim(Repl_All(txtTempCode.Text)) & "','" & Trim(Repl_All(txtDescription.Text)) & "','" & Trim(Repl_All(txtMessage.Text)) & "','" & Trim(Repl_All(txtRemarks.Text)) & "' ,Getdate(),'" & cEmphash & "', '" & lvStatus & "')"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConDBConnClose()
    End Sub

    Private Sub UpdateData(ByVal cTempCode As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        Dim lvStatus As Integer

        If chkStatus.Checked = True Then
            lvStatus = 1
        Else
            lvStatus = 0
        End If

        con1.ConOleOpen()

        lvSqlstr = "Update tblM360Template " & _
                        "set Description = '" & Trim(Repl_All(txtDescription.Text)) & "', " & _
                        "MsgContent = '" & Trim(Repl_All(txtMessage.Text)) & "', " & _
                        "Remarks = '" & Trim(Repl_All(txtRemarks.Text)) & "', " & _
                        "EncDate = Getdate(), " & _
                        "Encby = '" & mvEmphash & "', " & _
                        "Status = '" & lvStatus & "', " & _
                        "TempCode = '" & txtTempCode.Text & "' " & _
                   "Where RecID = '" & mvRecID & "'"

        'MsgBox(lvSqlstr)
        Dim cmdUpdate As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdUpdate.ExecuteNonQuery()

        con1.ConOleClose()
    End Sub

    Private Sub SaveData(ByVal cEmphash As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String
        Dim lvStatus As Integer

        If chkStatus.Checked = True Then
            lvStatus = 1
        Else
            lvStatus = 0
        End If

        con1.ConOleOpen()

        lvSqlstr = "Insert into tblM360Template (TempCode, Description, MsgContent, Remarks, EncDate, Encby, Status) " & _
                                " Values('" & Trim(Repl_All(txtTempCode.Text)) & "','" & Trim(Repl_All(txtDescription.Text)) & "','" & Trim(Repl_All(txtMessage.Text)) & "','" & Trim(Repl_All(txtRemarks.Text)) & "' ,Getdate(),'" & cEmphash & "', '" & lvStatus & "')"

        Dim cmdInsert As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdInsert.ExecuteNonQuery()

        con1.ConOleClose()
    End Sub

    Private Sub Clear()
        txtTempCode.Text = ""
        txtTempCode.Enabled = True
        txtDescription.Text = ""
        txtMessage.Text = ""
        txtRemarks.Text = ""
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        mvUpdate = False
        lblStatus.Text = "<>"
        chkStatus.Checked = False
        mvUpdate = False
        mvRecID = 0
    End Sub

    Private Sub txtTempCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTempCode.LostFocus
        If txtTempCode.Text <> "" Then
            txtTempCode.BackColor = Color.White
        ElseIf txtTempCode.Text = "" Then
            txtTempCode.Focus()
            txtTempCode.BackColor = Color.Yellow
        End If
    End Sub


    Private Sub txtDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.LostFocus
        If txtDescription.Text <> "" Then
            txtDescription.BackColor = Color.White
        ElseIf txtDescription.Text = "" Then
            txtDescription.Focus()
            txtDescription.BackColor = Color.Yellow
        End If
    End Sub


    Private Sub txtMsgContent_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.LostFocus
        If txtMessage.Text <> "" Then
            txtMessage.BackColor = Color.White
        ElseIf txtMessage.Text = "" Then
            txtMessage.Focus()
            txtMessage.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub txtRemarks_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRemarks.LostFocus
        If txtRemarks.Text <> "" Then
            txtRemarks.BackColor = Color.White
        ElseIf txtRemarks.Text = "" Then
            txtRemarks.Focus()
            txtRemarks.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Clear()
        Me.Hide()
    End Sub

    Private Sub frmMaintenance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Clear()
        If Me.Text = "Setup Template" Then
            FillDataTempChoose("MsgContent not like '%HR Department%'")
        Else
            FillDataTempChoose("MsgContent like '%HR Department%'")
        End If

        txtTempCode.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub FillDataTempChoose(ByVal cQuery As String)
        Dim rsTempChoose As New ADODB.Recordset
        Dim lvStr As String
        Dim itemx As ListViewItem
        Dim lvStat As String
        con1.ConOpen()
        lvChoose.Items.Clear()
        lvStr = "Select RecID, TempCode, Description, MsgContent, Remarks, Status from tblM360Template where " & cQuery & " order by Status asc "
        With rsTempChoose
            .Open(lvStr, con1.gvADODB)
            If Not .EOF Then
                .MoveFirst()
                Do While Not .EOF
                    itemx = lvChoose.Items.Add(Trim(.Fields("RecID").Value.ToString))
                    itemx.SubItems.Add(Trim(.Fields("TempCode").Value.ToString))
                    itemx.SubItems.Add(Trim(.Fields("Description").Value.ToString))
                    itemx.SubItems.Add(Trim(.Fields("MsgContent").Value.ToString))
                    itemx.SubItems.Add(Trim(.Fields("Remarks").Value.ToString))
                    If Trim(.Fields("Status").Value.ToString) = 1 Then
                        lvStat = "Active"
                        itemx.SubItems.Add("Active")
                    Else
                        lvStat = "Inactive"
                        itemx.SubItems.Add("Inactive")
                    End If
                    .MoveNext()
                Loop
            End If
        End With
        con1.ConClose()
        frmSendSMS.FillComboCateg()
        ListViewAlternateColor(lvChoose, Color.LightBlue)
    End Sub


    Private Sub lvChoose_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvChoose.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = lvChoose.Columns(e.Column)
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
        lvChoose.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort and Alternate Color
        ListViewAlternateColor(lvChoose, Color.LightBlue)
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

    Private Sub lvChoose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvChoose.Click

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        MsgBox("Under Maintenance.")
        ' Dim result As DialogResult
        Try
            'result = MessageBox.Show("Do you want to Delete this Template?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If result = DialogResult.Yes Then
            '    txtTempCode.Enabled = False
            '    cmdSave.Enabled = True
            '    ' User clicked Yes
            '    If lvChoose.SelectedItems.Count > 0 Then
            '        Dim selectedItem As ListViewItem = lvChoose.SelectedItems(0)
            '        mvRecID = selectedItem.Text  ' Column 0
            '        DeleteData(mvRecID)
            '        If Me.Text = "Setup Template" Then
            '            FillDataTempChoose("MsgContent not like '%HR Department%'")
            '            frmSendSMS_HR.FillComboCateg()

            '        Else
            '            FillDataTempChoose("MsgContent like '%HR Department%'")
            '            frmSendSMS_HR.FillComboCateg()
            '        End If

            '        MsgBox("Template has been deleted!")
            '        Clear()
            '    End If
            'Else
            '    txtTempCode.Enabled = True
            '    cmdSave.Enabled = True
            '    ' User clicked No
            '    'Do nothing
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteData(ByVal cRecID As String)
        Dim rsSaveData As New ADODB.Recordset
        Dim lvSqlstr As String


        con1.ConOleOpen()

        lvSqlstr = "Delete from tblM360Template where RecID = '" & mvRecID & "'"

        Dim cmdDel As New OleDb.OleDbCommand(lvSqlstr, con1.gvDBConn)

        cmdDel.ExecuteNonQuery()

        con1.ConOleClose()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clear()
    End Sub

    Private Sub chkStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkStatus.Click
        If chkStatus.Checked = True Then
            lblStatus.Text = "ACTIVE"
        Else
            lblStatus.Text = "INACTIVE"
        End If
    End Sub

    Private Sub chkStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStatus.CheckedChanged

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If lvChoose.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = lvChoose.SelectedItems(0)
                ' Assuming first column is the main item, and others are subitems
                mvRecID = selectedItem.Text  ' Column 0
                txtTempCode.Text = selectedItem.SubItems(1).Text  ' Column 1
                txtDescription.Text = selectedItem.SubItems(2).Text  ' Column 2
                txtMessage.Text = selectedItem.SubItems(3).Text  ' Column 3
                txtRemarks.Text = selectedItem.SubItems(4).Text  ' Column 3
                If selectedItem.SubItems(4).Text = "ACTIVE" Then  ' Column 4
                    chkStatus.Checked = True
                    lblStatus.Text = "ACTIVE"
                Else
                    chkStatus.Checked = False
                    lblStatus.Text = "INACTIVE"
                End If
                'txtTempCode.Enabled = False
                'cmdSave.Enabled = True
                mvUpdate = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        lbltextCount.Text = Len(txtMessage.Text) 'Ely @ 05292025
    End Sub




End Class