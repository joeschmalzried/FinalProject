Public Class Accommodations
    Public total As Decimal
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim num As Integer = RoomType.Num
        If chkBalcony.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Balcony Or Terrace")
            total += 50
        End If
        If chkBar.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Mini-Bar")
            total += 25
        End If
        If chkCoffee.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Steamer & amenities for making coffee & tea")
            total += 10
        End If
        If chkDoubleBed.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Double Bed")
            total += 50
        End If
        If chkSafe.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Safe Deposit Box")
            total += 15
        End If
        If chkSeperateRoom.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Separate Bedrooms")
            total += 75
        End If
        If chkSofa.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "Sitting corner with sofa Or armchair")
            total += 30
        End If
        If chkTV.Checked = True Then
            Form1.lstSpecs.Items.Add(num & ") " & "LCD TV")
            total += 20
        End If

        Me.Close()
        Form1.ShowCost()
        Form1.Show()
    End Sub
End Class