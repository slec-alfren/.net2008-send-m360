Imports System.IO
Imports System.Net
Imports System.Text
Public Class Form1
    'api_url: https://api.m360.com.ph/v3/api/broadcast
   
    'Private ReadOnly apiUrl As String = "https://api.m360.com.ph/v3/api/broadcast" ' Replace with the actual M360 API URL
    'Private ReadOnly apiKey As String = "HkVFa0VxZRIP3Lfs"
    'Private ReadOnly apiSecret As String = "fBwj6mAqIcR3SXaw2zUGyzq8TMJRZxc6"
    '"app_key": "M2T63BDj8A3S8f1U",
    '"app_secret": "O5gtQNhQxo89T4tZViAKqX2HM36uyxDP",

    Public Sub SendSMS(ByVal cCPNumber As String)
        Dim appkey As String = "M2T63BDj8A3S8f1U"
        Dim appsecret As String = "O5gtQNhQxo89T4tZViAKqX2HM36uyxDP"
        Dim msisdn As String = txtCPNumber.Text
        Dim content As String = "Sample Message pf m360 using VB.Net"
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
        Catch ex As WebException
            ' Handle errors
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    Console.WriteLine("Error Response: " & reader.ReadToEnd())
                End Using
            Else
                Console.WriteLine("Error: " & ex.Message)
            End If
        End Try
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        
        SendSMS(txtCPNumber.Text)

        txtCPNumber.Text = ""
        'Console.WriteLine(result)
        
    End Sub
End Class
