Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cikis As DateTime
        Dim giris As DateTime
        Dim durum As Double
        Dim fiyat1 As Double
        giris = DateTimePicker1.Value
        cikis = DateTimePicker2.Value
    
        Dim durum4 As String
        durum = DateDiff(DateInterval.Day, giris, cikis)
        fiyat1 = durum * 150
        TextBox6.Text = fiyat1
        durum4 = MsgBox("Sayın = " & TextBox1.Text & vbNewLine & " Bilgileriniz " & TextBox2.Text & vbNewLine & TextBox3.Text & " " & TextBox4.Text & " " & TextBox5.Text & vbNewLine & durum & " Gün " & vbNewLine & fiyat1 & " Ücretiniz " & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
        If durum4 = vbYes Then
            Dim sql As New String("INSERT INTO bilgiler (adsoyad,fiyat,adres,telefon,il,ilçe,oda,giris,cikis,kisisayi,misafirsayi) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')")
            sql = String.Format(sql, TextBox1.Text, TextBox6.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBox3.Text, DateTime.Parse(DateTimePicker1.Value), DateTime.Parse(DateTimePicker2.Value), ComboBox1.Text, ComboBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='veriler.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
            End If
            baglanti.Close()
        Else MsgBox("Kayıt iptal edildi")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox5.Clear()
        TextBox13.Clear()


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = Text.Substring(1) + Text.Substring(0, 1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class