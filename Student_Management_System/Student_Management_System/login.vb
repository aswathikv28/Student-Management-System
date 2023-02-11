Imports System.Data.SqlClient

Public Class login
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\WinFormsApp7\WinFormsApp7\regi.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
    Dim objcmd As SqlCommand = Nothing

    Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\WinFormsApp7\WinFormsApp7\regi.mdf;Integrated Security=True")
            objcon.Open()
Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim stmt As String = "select * from register where email ='" & email.Text & "' AND password ='" & password.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
    If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()

    Else
                MessageBox.Show("Ivalid input")
                form1.Show()
                email.Clear()
                password.Clear()

            End If
    Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
End Class