﻿Public Class Form1
    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Try
            Dim a, b As Integer
            a = txtfirstnum.Text
            b = txtsecondnum.Text
            lblresult.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class
