Imports System.Security.Cryptography

Public Class Users
    Private TripelDes As New TripleDESCryptoServiceProvider
    Private username As String
    Private password As String
    Private data_enkripsi As New ArrayList()

    Public Property GSusername As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSpasssword As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, TripleDES.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuthentication(username As String, ByVal plainPassword As String) As String
        Dim realPasswordas As String = EncryptData("1234")
        Dim realUsername As String = "fahmi"
        If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPasswordas) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function addData_user(username As String, password As String)
        data_enkripsi.Add({username, EncryptData(password)})
    End Function
End Class
