Public Class Form1


    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        sticker.Top = sticker.Top - 10

    End Sub

    Private Sub BtnR_Click(sender As Object, e As EventArgs) Handles BtnR.Click
        sticker.Left = sticker.Left + 10
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        sticker.Top = sticker.Top + 10
    End Sub

    Private Sub BtnCenter_Click(sender As Object, e As EventArgs) Handles BtnCenter.Click

        sticker.Top = Me.Height / 2
        sticker.Left = Me.Width / 2
    End Sub

    Private Sub BtnUpL_Click(sender As Object, e As EventArgs) Handles BtnUpL.Click
        sticker.Left = sticker.Left - 10
        sticker.Top = sticker.Top - 10
    End Sub

    Private Sub BtnUpR_Click(sender As Object, e As EventArgs) Handles BtnUpR.Click
        sticker.Left = sticker.Left + 10
        sticker.Top = sticker.Top - 10
    End Sub

    Private Sub BtnDownL_Click(sender As Object, e As EventArgs) Handles BtnDownL.Click
        sticker.Left = sticker.Left - 10
        sticker.Top = sticker.Top + 10
    End Sub

    Private Sub BtnDownR_Click(sender As Object, e As EventArgs) Handles BtnDownR.Click
        sticker.Left = sticker.Left + 10
        sticker.Top = sticker.Top + 10
    End Sub

    Private Sub BtnL_Click(sender As Object, e As EventArgs) Handles BtnL.Click
        sticker.Left = sticker.Left - 10

    End Sub

    Private Sub BtnZoomIn_Click(sender As Object, e As EventArgs) Handles BtnZoomIn.Click

        sticker.Width = sticker.Width * 1.1


    End Sub
End Class
