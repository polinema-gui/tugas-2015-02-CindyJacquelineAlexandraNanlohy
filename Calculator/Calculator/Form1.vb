Public Class Form1

    Dim samadengan As String
    Dim inputSatu As Integer
    Dim n As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (n = "0") Then
            n = "0"
        Else
            n &= "0"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (n = "0") Then
            n = "1"
        Else
            n &= "1"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (n = "0") Then
            n = "2"
        Else
            n &= "2"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (n = "0") Then
            n = "3"
        Else
            n &= "3"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (n = "0") Then
            n = "4"
        Else
            n &= "4"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (n = "0") Then
            n = "5"
        Else
            n &= "5"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (n = "0") Then
            n = "6"
        Else
            n &= "6"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (n = "0") Then
            n = "7"
        Else
            n &= "7"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (n = "0") Then
            n = "8"
        Else
            n &= "8"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (n = "0") Then
            n = "9"
        Else
            n &= "9"
        End If
        TextBox1.Text = n
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = "0"
        n = Nothing
    End Sub

    Private Sub Buttonhasil_Click(sender As Object, e As EventArgs) Handles Buttonhasil.Click
        Select Case Me.samadengan
            Case "a"
                TextBox1.Text = Convert.ToString(inputSatu + TextBox1.Text)
            Case "b"
                TextBox1.Text = Convert.ToString(inputSatu - TextBox1.Text)
        End Select
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        Me.samadengan = "a"
        Me.inputSatu = TextBox1.Text
        n = Nothing
    End Sub

    Private Sub Buttonmin_Click(sender As Object, e As EventArgs) Handles Buttonmin.Click
        Me.samadengan = "b"
        Me.inputSatu = TextBox1.Text
        n = Nothing
    End Sub
End Class
