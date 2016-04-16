Public Class Form1

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewRoom_Click(sender As Object, e As EventArgs) Handles btnNewRoom.Click
        Me.Hide()
        RoomType.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        RoomType.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        NumberOfNights.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Accommodations.ShowDialog()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        lstRooms.Items.Clear()
        lstSpecs.Items.Clear()
    End Sub

    Private Sub DeleteRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRoomToolStripMenuItem.Click
        lstRooms.Items.Remove(lstRooms.SelectedItem)
    End Sub

    Private Sub DeleteSpecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSpecToolStripMenuItem.Click
        lstSpecs.Items.Remove(lstSpecs.SelectedItem)
    End Sub

    Private Sub CheapestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheapestToolStripMenuItem.Click
        RoomType.Num = lstRooms.Items.Count() + 1
        lstRooms.Items.Add("Single Room " & RoomType.Num)
        RoomType.Num = lstRooms.Items.Count() + 1
        Me.Hide()
        NumberOfNights.ShowDialog()
    End Sub

    Private Sub MostExpensiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostExpensiveToolStripMenuItem.Click
        RoomType.Num = lstRooms.Items.Count() + 1
        lstRooms.Items.Add("Grande Room " & RoomType.Num)
        RoomType.Num = lstRooms.Items.Count() + 1
        Me.Hide()
        NumberOfNights.ShowDialog()
    End Sub

    Sub ShowCost()
        Dim cost As Decimal
        cost += Accommodations.total + NumberOfNights.Nights * RoomType.roomCost
    End Sub

End Class
