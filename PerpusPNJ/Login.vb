Public Class Login
    Public Shared Users As Users
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plainUsername As String = TextBox1.Text
        Dim plainPassword As String = TextBox2.Text

        Dim AuthStatus As Boolean = Users.CheckAuthentication(plainUsername, plainPassword)

        If AuthStatus Then
            Perpustakaan.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim daftar = New DaftarLogin
        daftar.Show()
    End Sub
End Class