Public Class IMKModul1
    Sub IMKLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        meText.Text = Me.Text
        meSidebar.Location = New Point(600, 0)
    End Sub

End Class