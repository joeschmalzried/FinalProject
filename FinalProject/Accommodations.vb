Imports System.IO
Imports System.IO.File


Public Class Accommodations
    Public total As Decimal

    Dim list As New List(Of Decimal)
    Dim aName As New List(Of String)
    Private ReadOnly FILEPATH As String = "accomCost.txt"
    Private ReadOnly READFILE As String = "accomName.txt"

    Private Sub Accommodations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list.Clear()
        Dim infile As StreamReader = Nothing

        Try
            infile = OpenText(FILEPATH)
            While Not infile.EndOfStream
                Dim entireLine As String = infile.ReadLine()
                Dim fields() As String = entireLine.Split(","c)
                For num As Integer = LBound(fields) To UBound(fields)
                    Dim temp As String = fields(num)
                    list.Add(CDec(temp))
                Next
            End While
            infile.Close()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        aName.Clear()
        Dim fileIn As StreamReader = Nothing

        Try
            fileIn = OpenText(READFILE)
            While Not fileIn.EndOfStream
                Dim entire As String = fileIn.ReadLine()
                Dim names() As String = entire.Split(","c)
                For num As Integer = LBound(names) To UBound(names)
                    Dim temp As String = names(num)
                    aName.Add(names(num))
                Next
            End While
            fileIn.Close()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim temp As String = ""

        If chkBalcony.Checked = True Then
            total += list(0)
            temp = temp.ToString & "," & aName(0)
        End If
        If chkBar.Checked = True Then
            total += list(1)
            temp = temp.ToString & "," & aName(1)
        End If
        If chkBathrooms.Checked = True Then
            total += list(2)
            temp = temp.ToString & "," & aName(2)
        End If
        If chkCoffee.Checked = True Then
            total += list(3)
            temp = temp.ToString & "," & aName(3)
        End If
        If chkDoubleBed.Checked = True Then
            total += list(4)
            temp = temp.ToString & "," & aName(4)
        End If
        If chkSafe.Checked = True Then
            total += list(5)
            temp = temp.ToString & "," & aName(5)
        End If
        If chkSeperateRoom.Checked = True Then
            total += list(6)
            temp = temp.ToString & "," & aName(6)
        End If
        If chkSofa.Checked = True Then
            total += list(7)
            temp = temp.ToString & "," & aName(7)
        End If
        If chkTV.Checked = True Then
            total += list(8)
            temp = temp.ToString & "," & aName(8)
        End If
        If temp.ToString = "" Then
            temp = "No accommodations"
        End If

        Dim price As Double = calcCost()
        Form1.bookList.Add(Form1.Num.ToString, New Room With
                                           {.RoomType = RoomType.roomType.ToString, .Nights = Form1.Nights.ToString,
                                           .Accom = temp.ToString, .Total = price.ToString})
        reset()
        Form1.save()
        Me.Close()
        Form1.Show()
    End Sub

    Function calcCost() As Double
        Dim cost As Double
        Dim math As Double = RoomType.roomCost * Form1.Nights
        cost = total + math
        Return cost
    End Function

    Public Sub reset()
        chkBalcony.Checked = False
        chkBar.Checked = False
        chkBathrooms.Checked = False
        chkCoffee.Checked = False
        chkDoubleBed.Checked = False
        chkSafe.Checked = False
        chkSeperateRoom.Checked = False
        chkSofa.Checked = False
        chkTV.Checked = False
        total = 0
    End Sub

End Class