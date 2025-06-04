'Programmers Notes:
'===========================
'Date Deployment 05-07-2025
'by: Ely 
'Additional Message Template
'Request by: Mam Mari
'New Version: 1.0.0.18
'===========================

Module modMain
    Public mvEmphash As String
    Public mvUserID As String
    Public mvFirstname As String
    Public gvSortingColumn As ColumnHeader
    Public gvAppKey As String
    Public gvAppSecret As String
    Dim con1 As New clsConnection

    Public Function Repl_All(ByVal Str As String) As String 'Ely 2025-05-06
        Dim lvStr As String

        lvStr = Replace(Str, "'", "''")
        lvStr = Replace(lvStr, "Ã±", "Ñ")
        lvStr = Replace(lvStr, "Ã‘", "Ñ")
        lvStr = Replace(lvStr, "N/A", "")
        lvStr = Replace(lvStr, "n/a", "")

        Repl_All = lvStr

    End Function
End Module
