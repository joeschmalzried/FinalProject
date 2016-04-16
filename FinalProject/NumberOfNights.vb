Public Class NumberOfNights
    Public Nights As Integer = 0
    Private Sub NumberOfNights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNights.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        errProvider.Clear()
        stslbl1.Text = ""

        If (Not Integer.TryParse(txtNights.Text, Nights)) Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        ElseIf Nights < 1 Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        End If
        If Nights = 1 Then
            Form1.lstSpecs.Items.Add(RoomType.Num.ToString & ") " & Nights.ToString() & " Night")
        Else
            Form1.lstSpecs.Items.Add(RoomType.Num.ToString & ") " & Nights.ToString() & " Nights")
        End If
        Me.Hide()
        Accommodations.ShowDialog()
        Me.Close()
    End Sub


End Class