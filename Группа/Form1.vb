Imports System.Data.OleDb
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ggggg\Database2;Persist Security Info=False;"
        conn.Open()

    End Sub
End Class
