﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim i As Integer
        Dim numsum As Integer
        numsum = 0
        For i = 1 To 20 Step 2
            numsum = numsum + i
        Next
        lblResults.Text = numsum
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ListBoxOddNumbers.Items.Clear()
        Dim a As Boolean
        For i = 1 To 20 Step 2
            If i Mod 2 = 0 Then
                a = False
            Else
                a = True
            End If
            If a = True Then
                ListBoxOddNumbers.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub btnSumDisp_Click(sender As Object, e As EventArgs) Handles btnSumDisp.Click
        ListBoxOddNumbers.Items.Clear()
        Dim i As Integer
        Dim numsum As Integer
        numsum = 0
        For i = 1 To 20 Step 2
            numsum = numsum + i
        Next
        lblResults.Text = numsum
        Dim a As Boolean
        For i = 1 To 20 Step 2
            If i Mod 2 = 0 Then
                a = False
            Else
                a = True
            End If
            If a = True Then
                ListBoxOddNumbers.Items.Add(i)
            End If
        Next
    End Sub
End Class
