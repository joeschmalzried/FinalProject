Imports System.IO
Imports System.IO.File
Imports System.Text

Public Class Form1
    Public bookList As New Dictionary(Of String, Room)

    Public Num As Integer
    Public Nights As Integer

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
        bookList.Clear()
        Num = 0
        RoomType.roomCost = 0
        Nights = 0
    End Sub

    Private Sub DeleteRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRoomToolStripMenuItem.Click
        lstRooms.Items.Remove(lstRooms.SelectedItem)
    End Sub

    Private Sub DeleteSpecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSpecToolStripMenuItem.Click
        lstSpecs.Items.Remove(lstSpecs.SelectedItem)
    End Sub

    Private Sub CheapestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheapestToolStripMenuItem.Click
        Num += 1
        RoomType.roomType = "Single room"
        RoomType.roomCost = 75
        lstRooms.Items.Add(Num & ")" & "Single Room")
        Me.Hide()
        NumberOfNights.ShowDialog()
    End Sub

    Private Sub MostExpensiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostExpensiveToolStripMenuItem.Click
        Num += 1
        RoomType.roomType = "Grande Room"
        RoomType.roomCost = 175
        lstRooms.Items.Add(Num & " )" & "Grande Room")
        Me.Hide()
        NumberOfNights.ShowDialog()
    End Sub

    Public Sub save()
        'Dim outfile As StreamWriter
        'outfile = CreateText("SavedRooms.txt")

        'Dim sb As New StringBuilder
        'For Each item As KeyValuePair(Of String, Room) In bookList
        '    outfile.WriteLine(sb.AppendLine(item.Key & ", " & item.Value.RoomType.ToString & ", " & item.Value.Nights & ", " &
        '                                    item.Value.Accom & ", " & item.Value.Total))
        'Next

        Dim FILE_NAME As String = "SavedRooms.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            For Each item As KeyValuePair(Of String, Room) In bookList
                objWriter.WriteLine((item.Key & ", " & item.Value.RoomType.ToString & ", " & item.Value.Nights & ", " &
                                            item.Value.Accom & ", " & item.Value.Total))
            Next
            objWriter.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If

    End Sub

    Private Sub lstRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRooms.SelectedIndexChanged
        lstSpecs.Items.Clear()
        Dim aRoom As Room
        Try
            aRoom = bookList(lstRooms.SelectedIndex + 1)
            If aRoom Is Nothing Then
                lstSpecs.Items.Add("error")
            Else

                lstSpecs.Items.Add("Room Type:  " & aRoom.RoomType)
                lstSpecs.Items.Add("Number of Nights " & aRoom.Nights)
                lstSpecs.Items.Add("Accommodations:" & aRoom.Accom)
                lstSpecs.Items.Add("Total Cost: $" & aRoom.Total)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class