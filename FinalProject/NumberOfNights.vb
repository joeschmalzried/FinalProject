Public Class NumberOfNights

    Private Sub NumberOfNights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNights.Clear()
        txtNights.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        errProvider.Clear()
        stslbl1.Text = ""

        If (Not Integer.TryParse(txtNights.Text, Form1.Nights)) Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        ElseIf Form1.Nights < 1 Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        End If

        Me.Hide()
        Accommodations.ShowDialog()
        Me.Close()
    End Sub


End Class