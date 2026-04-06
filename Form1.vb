Option Strict On
Option Explicit On
Public Class Form1
    'Global Vars
    'static
    'Overriding
    Private nC, nR As Integer
    Private myArray(3, 4) As Integer
    Private RowTotal(3) As Integer
    Private RowAverage(3) As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nR = 3
        nC = 4
        Init()

        myArray(1, 1) = 9
        myArray(1, 2) = 12
        myArray(1, 3) = 13
        myArray(1, 4) = 67

        myArray(2, 1) = 32
        myArray(2, 2) = 23
        myArray(2, 3) = 43
        myArray(2, 4) = 32

        myArray(3, 1) = 3
        myArray(3, 2) = 9
        myArray(3, 3) = 9
        myArray(3, 4) = 9


    End Sub

    Private Sub PIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdTut.Row = r
        grdTut.Col = c
        grdTut.Text = t
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        For r As Integer = 1 To nR
            For c As Integer = 1 To nC
                PIG(r, c, CStr(myArray(r, c)))
            Next c
        Next r

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        For r As Integer = 1 To nR
            Dim Total As Integer = 0
            For c As Integer = 1 To nC
                Total += myArray(r, c)
            Next c
            RowTotal(r) = Total
            RowAverage(r) = Total / nC
            PIG(r, nC + 1, CStr(RowTotal(r)))
            PIG(r, nC + 2, CStr(RowAverage(r)))
        Next r
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myArray(4) As Integer
        myArray(1) = 2
        myArray(2) = 4
        myArray(3) = 5
        myArray(4) = 9
        Dim Sum As Integer = FindTotal(myArray, 4)
        MsgBox(Sum)
        Dim Total As Integer = 0
        findSum(myArray, 4, Total)


    End Sub

    Private Function FindTotal(ByRef arr() As Integer, ByVal size As Integer) As Integer
        Dim Total As Integer = 0
        For i As Integer = 1 To size
            Total += arr(i)
        Next i
        Return Total
    End Function

    Private Sub findSum(ByRef arr() As Integer, ByVal Size As Integer, ByRef Total As Integer)
        For i As Integer = 1 To Size
            Total += arr(i)
        Next i
    End Sub

    Private Sub Init()
        'Resizing the grid dimensions
        grdTut.Rows = nR + 1
        grdTut.Cols = nC + 3

        'Label The grid:
        For r As Integer = 1 To nR
            PIG(r, 0, "Row " & CStr(r)) 'Concatenation(&)
        Next r
        For c = 1 To nC
            PIG(0, c, "Column " & CStr(c))
        Next c

        PIG(0, nC + 1, "Total")
        PIG(0, nC + 2, "Average")
    End Sub


    ' 2 3 4 5 0
    ' 4 5 7 8 5
    ' 7 8 6 11 5


End Class
