Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim i As Integer = 1

        Do While (i <= 10)
            Dim x As Integer = i ^ 2
            lstResult.Items.Add(x)
            i += 1
        Loop


    End Sub
End Class
