Imports System.Data.OleDb
Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "admin" And TextBox2.Text = "parola") Then
            Form3.Show()
            Me.Close()
        Else
            MsgBox("Hatalı kullanıcı adı ve şifreli giriş yaptınız.", MsgBoxStyle.Exclamation, "HATA!")
        End If
    End Sub
End Class