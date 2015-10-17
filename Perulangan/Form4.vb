Public Class Form4

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        Environment.Exit(0)
    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click
        Me.Close()

    End Sub
End Class