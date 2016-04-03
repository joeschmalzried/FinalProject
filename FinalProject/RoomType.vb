﻿Public Class RoomType
    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        If radSingle.Checked Then
            MessageBox.Show("Single Rooms provide a space of 30-40 meters squared, offering a
comfortable stay for one guest.", "Single Room Information")
        ElseIf radDouble.Checked Then
            MessageBox.Show("Double Rooms provide a space of 35-42 meters squared, offering a 
comfortable stay for one or two guests.", "Double Room Information")
        ElseIf radJunior.Checked Then
            MessageBox.Show("Featuring an elegant space of 45-60 meters squared. our Junior Suites
invite you to enjoy your vacations with an air of discrete luxury", "Junior Suite Information")
        ElseIf radSuperior.Checked Then
            MessageBox.Show("For those that with to enjoy your vacations in style, the Superior Suite
is the ideal choice. Two levels and 75 meters squared give you the space you need for unique vacations.",
                            "Superior Sutie Information")
        ElseIf radExecutive.Checked Then
            MessageBox.Show("The Executive Suites are the preferred choice for families with children 
or companies of up to 4 guests.", "Executive Suite Information")
        ElseIf radFamily.checked Then
            MessageBox.Show("The Family Suite is the preferred choice for families with children or 
companies of up to 4 guests.", "Family Suite Information")
        ElseIf radGrande.Checked Then
            MessageBox.Show("The preferred choice for groups of up to 6 guests, the Grande Suite offers 
3 separate bedrooms and a spacious living room at a total of 175 meters squared,
providing you with a unique stay experience.", "Grande Suite Information")
        End If
    End Sub
    Public Num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If radSingle.Checked Then
            Form1.lstRooms.Items.Add("Single Room " & num)
        ElseIf radDouble.Checked Then
            Form1.lstRooms.Items.Add("Double Room " & num)
        ElseIf radJunior.Checked Then
            Form1.lstRooms.Items.Add("Junior Room " & num)
        ElseIf radSuperior.Checked Then
            Form1.lstRooms.Items.Add("Superior Room " & num)
        ElseIf radExecutive.Checked Then
            Form1.lstRooms.Items.Add("Executive Room " & num)
        ElseIf radFamily.Checked Then
            Form1.lstRooms.Items.Add("Family Room " & num)
        ElseIf radGrande.Checked Then
            Form1.lstRooms.Items.Add("Grande Room " & num)
        End If

        NumberOfNights.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Num = Form1.lstRooms.Items.Count() + 1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class