Public Class Accommodations
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim num As Integer = RoomType.Num
        If chkBalcony.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Balcony Or Terrace")
        End If
        If chkBar.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Mini-Bar")
        End If
        If chkCoffee.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Steamer & amenities for making coffee & tea")
        End If
        If chkDoubleBed.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Double Bed")
        End If
        If chkSafe.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Safe Deposit Box")
        End If
        If chkSeperateRoom.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Separate Bedrooms")
        End If
        If chkSofa.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Sitting corner with sofa Or armchair")
        End If
        If chkTV.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "LCD TV")
        End If

        Me.Close()
    End Sub
End Class