Public Class NumberOfNights
    Private Sub NumberOfNights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNights.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        errProvider.Clear()
        stslbl1.Text = ""
        Dim nights As Integer = 0
        If (Not Integer.TryParse(txtNights.Text, nights)) Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        ElseIf nights < 1 Then
            errProvider.SetError(txtNights, "You must enter a positive number.")
            stslbl1.Text = "You must enter a positive number"
            txtNights.Clear()
            txtNights.Focus()
            Return
        End If
        If nights = 1 Then
            Form1.lstSpecs.Items.Add(RoomType.Num.ToString & ") " & nights.ToString() & " Night")
        Else
            Form1.lstSpecs.Items.Add(RoomType.Num.ToString & ") " & nights.ToString() & " Nights")
        End If
        Accommodations.ShowDialog()
            Me.Close()
    End Sub


End Class