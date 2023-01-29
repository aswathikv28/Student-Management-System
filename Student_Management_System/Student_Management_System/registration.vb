Imports System.Data.SqlClient


Public Class registration
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\WinFormsApp7\WinFormsApp7\regi.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from register where email='" & eid.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Email Id Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO register values('" & fname.Text & "','" & lname.Text & "','" & eid.Text & "','" & phone.Text & "','" & dob.Text & "','" & gender.Text & "','" & dname.Text & "','" & dphone.Text & "','" & address.Text & "','" & dept.Text & "','" & course.Text & "')", con)
                If (fname.Text = "" And lname.Text = "" And eid.Text = "" And phone.Text = "" And dob.Text = "" And gender.Text = "" And dname.Text = "" And dphone.Text = "" And address.Text = "" And dept.Text = "" And course.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()

                    fname.Clear()
                    lname.Clear()
                    eid.Clear()
                    phone.Clear()
                    dob.Clear()
                    gender.Text = " "
                    dname.Clear()
                    dphone.Clear()
                    address.Clear()
                    dept.Text = " "
                    course.Text = " "
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try


    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged

    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

