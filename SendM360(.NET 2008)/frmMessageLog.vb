Public Class frmMessageLog
    Dim con1 As New clsConnection
    Dim con2 As New clsConnection

    

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

    'Ely @ 05292025
    Private Function MaskNumber(ByVal number As String) As String
        If number.Length >= 9 Then
            Return number.Substring(0, 4) & "*****" & number.Substring(number.Length - 2)
        Else
            Return number ' fallback if too short
        End If
    End Function

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

    Private Sub PicSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSearch.Click
        Dim lvQuerry As String = ""
        If CheckAccess(mvEmphash) = True Then
            lvQuerry = ""
        Else
            lvQuerry = " And UserID = '" & mvEmphash & "'"
        End If

        If chkDate.Checked = True Then
            FillDataMessageLog("UserDate Between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & " 00:00:00' And '" & Format(dtpTo.Value, "yyyy-MM-dd") & " 23:59:59'" & lvQuerry)
        ElseIf chkPDSNo.Checked = True Then
            FillDataMessageLog("PDSNo = '" & Trim(txtPDSNo.Text) & "'")
        ElseIf chkTemplate.Checked = True Then
            FillDataMessageLog("SmsSubject = '" & cboTemp.Text & "'" & lvQuerry)
        End If

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
            lvSelStr = "Select Top 1000 PDSNo, MobileNo, MsgContent, UserDate From tblSMSPayload where " & cQuery & " and MsgContent not like '%HR Department%' order by UserDate desc"
            con1.ConOpen()
            With rsFilldata
                .Open(lvSelStr, con1.gvADODB)
                If Not .EOF Then
                    Do While Not .EOF
                        itmx = lvMessageLog.Items.Add(Trim(.Fields("PDSNo").Value.ToString))
                        itmx.SubItems.Add(MaskNumber(Trim(.Fields("MobileNo").Value.ToString))) 'Ely @ 05292025
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

    Private Sub frmMessageLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lvQuerry As String = ""
        If CheckAccess(mvEmphash) = True Then
            lvQuerry = ""
        Else
            lvQuerry = " And UserID = '" & mvEmphash & "'"
        End If
        FillDataMessageLog("MsgSent = '1' " & lvQuerry)
        FillDataTemp(cboTemp)
    End Sub

    Private Sub FillDataTemp(ByVal Combo As ComboBox)
        Dim rsFillData As New ADODB.Recordset
        Dim lvStr As String = ""

        lvStr = "Select * from tblM360Template where Description not like ('%HR Department%')"

        con1.ConOpen()
        With rsFillData
            .Open(lvStr, con1.gvADODB)
            If Not .EOF Then
                .MoveFirst()
                Do While Not .EOF
                    cboTemp.Items.Add(Trim(.Fields("TempCode").Value.ToString))
                    .MoveNext()
                Loop
            End If
        End With
        con1.ConClose()

    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged

    End Sub

    Private Sub chkDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDate.Click
        If chkDate.Checked = True Then
            chkPDSNo.Checked = False
            chkTemplate.Checked = False
            txtPDSNo.Text = ""
            txtPDSNo.Enabled = False
            cboTemp.Enabled = False
            dtpFrom.Enabled = True
            dtpTo.Enabled = True
        End If
    End Sub

    Private Sub chkPDSNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPDSNo.CheckedChanged
        If chkPDSNo.Checked = True Then
            chkDate.Checked = False
            chkTemplate.Checked = False
            txtPDSNo.Enabled = True
            txtPDSNo.Text = ""
            cboTemp.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
        End If
    End Sub


    Private Sub chkTemplate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTemplate.Click
        If chkTemplate.Checked = True Then
            chkDate.Checked = False
            chkPDSNo.Checked = False
            txtPDSNo.Enabled = False
            txtPDSNo.Text = ""
            cboTemp.Enabled = True
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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

    Private Sub lvMessageLog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessageLog.SelectedIndexChanged

    End Sub

    Private Sub txtPDSNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPDSNo.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso _
            Not Char.IsWhiteSpace(e.KeyChar) AndAlso _
            Char.IsControl(e.KeyChar) Then

            e.Handled = True ' Block symbols and punctuation
        End If
    End Sub

    Private Sub cboTemp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTemp.KeyPress
        e.Handled = True
    End Sub

    Private Sub dtpFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFrom.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) AndAlso _
            Char.IsWhiteSpace(e.KeyChar) AndAlso _
            Char.IsControl(e.KeyChar) Then

            e.Handled = True ' Block symbols and punctuation
        End If
    End Sub

  
    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub cboTemp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTemp.SelectedIndexChanged

    End Sub

    Private Sub txtPDSNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPDSNo.TextChanged

    End Sub
End Class