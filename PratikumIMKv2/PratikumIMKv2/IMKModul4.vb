Imports System.Math
Public Class IMKModul4
    Dim Sec2, mSec, Min, Sec, iCount As Integer
    Dim gSize, gX, gY, gX2, gY2, gD, gT, gT2, iClick As Integer
    Dim gRandom As New Random
    Sub IMKModul4Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gX2 = 350
        gY2 = 220
        gSize = 100
        meText.Text = Me.Text
    End Sub
#Region "Functions"
    Sub StartButton(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "S T A R T" Then
            TTimers.FlatAppearance.BorderColor = Color.Lime
            TTimers.ForeColor = Color.Lime
            GameObject.Enabled = True
            TCounts.Enabled = True
            TCounters.Enabled = True
            Chart1.Series("Distance").Points.Clear()
            Chart1.Series("Times").Points.Clear()
            Chart1.Series("Diameter").Points.Clear()

            iClick = 0
            TTimers.Text = "00 : 00"
            Sec = 0
            Min = 0
            Sec2 = 0
            mSec = 0

            Button3.Hide()
            Button0.Hide()
            Button4.Hide()

            GraphicC1.Text = "Distance" & vbNewLine
            GraphicC2.Text = "Time(s)" & vbNewLine
            GraphicC3.Text = "Diameter" & vbNewLine
            Button2.Text = "Pause"
        ElseIf Button2.Text = "Pause" Then
            TTimers.FlatAppearance.BorderColor = Color.Gray
            TTimers.ForeColor = Color.Gray

            GameObject.Enabled = False
            TCounts.Enabled = False
            TCounters.Enabled = False

            Button3.Show()
            Button0.Show()
            Button4.Show()

            Button2.Text = "Continue"
        ElseIf Button2.Text = "Continue" Then
            TTimers.FlatAppearance.BorderColor = Color.Lime
            TTimers.ForeColor = Color.Lime

            GameObject.Enabled = True
            TCounts.Enabled = True
            TCounters.Enabled = True

            Button3.Hide()
            Button0.Hide()
            Button4.Hide()

            Button2.Text = "Pause"
        End If
    End Sub
    Sub GameObjectRun(sender As Object, e As EventArgs) Handles GameObject.Click
        iClick = iClick + 1
        GraphicC1.Text = GraphicC1.Text & gD & vbNewLine
        Chart1.Series("Distance").Points.AddXY(iClick, gD)
        GraphicC2.Text = GraphicC2.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
        Chart1.Series("Times").Points.AddXY(iClick, iCount)
        GraphicC3.Text = GraphicC3.Text & gSize & vbNewLine
        Chart1.Series("Diameter").Points.AddXY(iClick, gSize)
        gSize = gRandom.Next(20, 100)
        gX = gRandom.Next(10, 690)
        gY = gRandom.Next(10, 430)
        GameObject.Size = New Size(gSize, gSize)
        GameObject.Location = New Point(gX, gY)
        If gX > gX2 And gY > gY2 Then
            gD = Sqrt((gX - gX2) ^ 2 + (gY - gY2) ^ 2)
        ElseIf gX2 > gX And gY > gY2 Then
            gD = Sqrt((gX2 - gX) ^ 2 + (gY - gY2) ^ 2)
        ElseIf gX > gX2 And gY2 > gY Then
            gD = Sqrt((gX - gX2) ^ 2 + (gY2 - gY) ^ 2)
        ElseIf gX2 > gX And gY2 > gY Then
            gD = Sqrt((gX2 - gX) ^ 2 + (gY2 - gY) ^ 2)
        End If
        iCount = 0
        Sec2 = 0
        mSec = 0
        gX2 = gX
        gY2 = gY
        If iClick = 22 Then
            TTimers.FlatAppearance.BorderColor = Color.Gray
            TTimers.ForeColor = Color.Gray

            GameObject.Enabled = False
            TCounts.Enabled = False
            TCounters.Enabled = False

            Button3.Show()
            Button0.Show()
            Button4.Show()

            Button2.Text = "S T A R T"
        End If
    End Sub

    Private Sub GraphicButton(sender As Object, e As EventArgs) Handles Button3.Click
        If GameObject.Visible = True Then
            GameObject.Hide()
            meGraphic.Show()
            Button2.Hide()
            Button3.Text = "Close"
        ElseIf GameObject.Visible = False Then
            GameObject.Show()
            meGraphic.Hide()
            Button2.Show()
            Button3.Text = "Graphic"
        End If
    End Sub

    Sub ExitButton(sender As Object, e As EventArgs) Handles Button0.Click
        IMK.Show()
        Me.Close()
    End Sub
#End Region
#Region "Timer Configuration"
    Private Sub Timers_Tick(sender As Object, e As EventArgs) Handles TCounts.Tick
        Sec = Sec + 1
        If Sec = 60 Then
            Min = Min + 1
            Sec = 0
        End If
        TTimers.Text = Format(Min, "00") & " : " & Format(Sec, "00")
    End Sub
    Private Sub TimesCount(sender As Object, e As EventArgs) Handles TCounters.Tick
        iCount = iCount + 1
        mSec = mSec + 1
        If mSec = 100 Then
            Sec2 = Sec2 + 1
            mSec = 0
        End If
    End Sub
#End Region
#Region "Buttons Style"
    Sub Button0Enter(sender As Object, e As EventArgs) Handles Button0.MouseEnter
        Button0.FlatAppearance.BorderColor = Color.White
        Button0.ForeColor = Color.White
    End Sub
    Sub Button0Leave(sender As Object, e As EventArgs) Handles Button0.MouseLeave
        Button0.FlatAppearance.BorderColor = Color.Gray
        Button0.ForeColor = Color.Gray
    End Sub

    Sub Button2Enter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.ForeColor = Color.White
    End Sub
    Sub Button2Leave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.FlatAppearance.BorderColor = Color.Gray
        Button2.ForeColor = Color.Gray
    End Sub

    Sub Button3Enter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.ForeColor = Color.White
    End Sub
    Sub Button3Leave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.FlatAppearance.BorderColor = Color.Gray
        Button3.ForeColor = Color.Gray
    End Sub

    Sub Button4Enter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.ForeColor = Color.White
    End Sub
    Sub Button4Leave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.FlatAppearance.BorderColor = Color.Gray
        Button4.ForeColor = Color.Gray
    End Sub
#End Region
End Class