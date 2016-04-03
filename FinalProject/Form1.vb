Public Class Form1
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewRoom_Click(sender As Object, e As EventArgs) Handles btnNewRoom.Click
        RoomType.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RoomType.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        NumberOfNights.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs)
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

End Class
