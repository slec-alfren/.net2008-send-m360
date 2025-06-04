Public Class clsConnection

    Public gvUserName As String
    Public gvValUserEmpHash As String
    Public gvValUserTitle As String
    Public gvUserOfcName As String
    Public gvValUserID As String
    Public gvUserID As String
    Public gvUserNo As String
    Public gvUserTitle As String
    Public gvUserInitial As String
    'Public gvConnSTR As String = "Provider=SQLOLEDB.1;Data Source=SQLSYS;Integrated Security=SSPI;Initial Catalog=SLEC;"
    Public gvDBConn_Str As String = "Provider=SQLOLEDB.1;Data Source=SQLSYS;Integrated Security=SSPI;Initial Catalog=dbSLEC;Persist Security Info=True "
    'For SQL Login Use
    Public gvConnSTR As String = "Provider=SQLOLEDB.1;Data Source=10.30.6.2;User ID=IT_Admin;Password=Sl3c123!;Initial Catalog=slec;Persist Security Info=True "
    ''Test server
    ''Public gvConnSTR As String = "Provider=SQLOLEDB.1;Data Source=SVR2012HV;Integrated Security=SSPI;Initial Catalog=SLEC;"
    Public gvDBConn_DBSLEC As New ADODB.Connection
    Public gvDBConn As New OleDb.OleDbConnection(gvConnSTR)
    Public gvADODB As New ADODB.Connection



    Sub New()

        Dim command As String = "Net Use ""\\192.168.10.200\IPC$"" /User:slecnas\slecuser p@ssw0rd /Persistent:Yes"

        ' Set up the ProcessStartInfo to run the command
        Dim startInfo As New ProcessStartInfo("cmd.exe")
        startInfo.Arguments = "/C " & command
        startInfo.WindowStyle = ProcessWindowStyle.Hidden ' Hide the command window

        Try
            ' Start the process (run the command)
            Dim process As Process = process.Start(startInfo)
            process.WaitForExit() ' Optionally, wait for the command to finish
        Catch ex As Exception
            ' Handle any errors that occur while running the command
            MessageBox.Show("Error: " & ex.Message)
        End Try

        'ConOpen()
        'ConClose()
    End Sub

    Public Sub ConOleOpen()
        gvDBConn.Open()
    End Sub
    Public Sub ConOleClose()
        gvDBConn.Close()
    End Sub


    Public Sub ConDBConnClose()
        gvDBConn_DBSLEC.Close()
    End Sub

    Public Sub ConDBConnopen()
        Try
            With gvDBConn_DBSLEC
                .ConnectionString = gvDBConn_Str
                .CommandTimeout = 0
                .CursorLocation = ADODB.CursorLocationEnum.adUseClient
                .Open()
            End With
            '
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Public Sub ConOpen()
        Try
            With gvADODB
                .ConnectionString = gvConnSTR
                .CommandTimeout = 0
                .CursorLocation = ADODB.CursorLocationEnum.adUseClient
                .Open()
            End With
            '
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Public Sub ConClose()
        gvADODB.Close()
    End Sub
End Class

