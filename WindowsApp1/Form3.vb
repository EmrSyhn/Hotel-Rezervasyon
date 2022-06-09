Imports System.Data.OleDb
Public Class Form3
    Public Sub listele(ByVal SQL As String)
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='veriler.mdb'")
        Dim veriler As New DataTable("bilgiler")
        Dim adapter As New OleDbDataAdapter(SQL, baglanti)
        adapter.Fill(veriler)
        DataGridView1.DataSource = veriler
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele("SELECT * FROM  bilgiler")


    End Sub
End Class