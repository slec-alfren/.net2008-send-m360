Public Class frmMainMenu
    Private Sub LoadFormIntoPanel(ByVal childForm As Form)
        'panSMS.Controls.Clear()              ' Remove previous form
        childForm.TopLevel = False           ' Make it a child control
        childForm.FormBorderStyle = FormBorderStyle.None
        'childForm.Dock = DockStyle.Fill      ' Fill the panel
        'childForm.Dock = DockStyle.Top
        'panSMS.Controls.Add(childForm)       ' Add to panel
        'childForm.Width = 883 'Ely @ 05292025
        'childForm.Height = 560 'Ely @ 05292025
        'childForm.Left = (Panel1.Width - childForm.Width) \ 2
        childForm.Top = 0
        childForm.Show()                     ' Display it

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadFormIntoPanel(frmSendSMS)
    End Sub

End Class