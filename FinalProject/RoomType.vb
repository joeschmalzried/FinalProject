Imports System.IO
Imports System.IO.File

Public Class RoomType
    Public roomType As String
    Public roomCost As Double
    Dim list As New List(Of String)
    Private ReadOnly FILEPATH As String = "roomInfo.txt"


    Private Sub RoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Num += 1
        Dim infile As StreamReader = Nothing
        Dim index As Integer = 0
        Try
            infile = OpenText(FILEPATH)
            While Not infile.EndOfStream
                Dim entireLine As String = infile.ReadLine()
                Dim fields() As String = entireLine.Split(","c)
                For num As Integer = LBound(fields) To UBound(fields)
                    list.Add(fields(num))
                    num += 1
                Next
            End While
            infile.Close()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        If radSingle.Checked Then
            MessageBox.Show(list(1).ToString(), list(0).ToString())
            roomCost = 75
        ElseIf radDouble.Checked Then
            MessageBox.Show(list(3).ToString(), list(2).ToString())
            roomCost = 85
        ElseIf radJunior.Checked Then
            MessageBox.Show(list(5).ToString(), list(4).ToString())
            roomCost = 95
        ElseIf radSuperior.Checked Then
            MessageBox.Show(list(7).ToString(), list(6).ToString())
            roomCost = 110
        ElseIf radExecutive.Checked Then
            MessageBox.Show(list(9).ToString(), list(8).ToString())
            roomCost = 130
        ElseIf radFamily.Checked Then
            MessageBox.Show(list(11).ToString(), list(10).ToString())
            roomCost = 140
        ElseIf radGrande.Checked Then
            MessageBox.Show(list(13).ToString(), list(12).ToString())
            roomCost = 175
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If radSingle.Checked Then
            roomType = list(0)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 75
        ElseIf radDouble.Checked Then
            roomType = list(2)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 85
        ElseIf radJunior.Checked Then
            roomType = list(4)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 95
        ElseIf radSuperior.Checked Then
            roomType = list(6)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 110
        ElseIf radExecutive.Checked Then
            roomType = list(8)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 130
        ElseIf radFamily.Checked Then
            roomType = list(10)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 140
        ElseIf radGrande.Checked Then
            roomType = list(12)
            Form1.lstRooms.Items.Add(Form1.Num & ") " & roomType.ToString)
            roomCost = 175
        End If
        Me.Hide()
        NumberOfNights.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class