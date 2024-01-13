Public Class IMKModul6
    Sub IMKModul6Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = -244
    End Sub
    Dim x, iTD, States, Delay, iEnd As Integer
    Dim gRandom As New Random
    Dim cE, iE, React, cT, iT, cR, iR As Integer

#Region "Game Object Configuration"""
    Sub StartButton(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "S T A R T" Then
            iEnd = 0
            cE = 0
            iE = 0
            cT = 0
            iT = 0
            cR = 0
            iR = 0
            meBody.Enabled = True
            iTD = 3
            TDelay.Enabled = True
            gObject90.Enabled = True
            TReact.Enabled = True

            Button0.Visible = False
            Button3.Visible = False
            Button4.Visible = False

            Button2.Text = "Pause"
        ElseIf Button2.Text = "Pause" Then
            meBody.Enabled = False
            TRun.Enabled = False
            TDelay.Enabled = False
            gObject90.Enabled = False

            Button0.Visible = True
            Button3.Visible = True
            Button4.Visible = True

            Button2.Text = "Continue"
        ElseIf Button2.Text = "Continue" Then
            meBody.Enabled = True
            TRun.Enabled = True
            TDelay.Enabled = True
            gObject90.Enabled = True

            Button0.Visible = False
            Button3.Visible = False
            Button4.Visible = False

            Button2.Text = "Pause"
        End If
    End Sub
    Sub GoButtons(sender As Object, e As EventArgs) Handles gCMD.Click
        If TRun.Enabled = True Then
            TRun.Enabled = False
            gCMD.Text = "GO"
            gCMD.BackgroundImage = My.Resources.CirclesGreen
        ElseIf TRun.Enabled = False Then
            TRun.Enabled = True
            gCMD.Text = "STOP"
            gCMD.BackgroundImage = My.Resources.CirclesRed
        End If

        'Consistency
        If (States = 1 And TRun.Enabled = True) Or (States = 2 And TRun.Enabled = False) Then
            cT = cT + 1
            cR = cR + React
        ElseIf (States = 1 And TRun.Enabled = False) Or (States = 2 And TRun.Enabled = True) Then
            cT = cT + 1
            cE = cE + 1
            cR = cR + React
        End If

        'Inconsistency
        If (States = 3 And TRun.Enabled = True) Or (States = 4 And TRun.Enabled = False) Then
            iT = iT + 1
            iR = iR + React
        ElseIf (States = 3 And TRun.Enabled = False) Or (States = 4 And TRun.Enabled = True) Then
            iT = iT + 1
            iE = iE + 1
            iR = iR + React
        End If
    End Sub

    Sub ResultButton(sender As Object, e As EventArgs) Handles Button3.Click
        If meBody.Visible = True Then
            meBody.Visible = False
            Button2.Visible = False
        ElseIf meBody.Visible = False Then
            meBody.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Sub ExitButton(sender As Object, e As EventArgs) Handles Button0.Click
        IMK.Show()
        Me.Close()
    End Sub
#End Region

    Private Sub TRun_Tick(sender As Object, e As EventArgs) Handles TRun.Tick
        x = x - 7
        Panel1.Location = New Point(x, 110)
        If x = -643 Then
            x = -244
        End If
    End Sub

    Sub TDelayTick(sender As Object, e As EventArgs) Handles TDelay.Tick
        iTD = iTD - 1
        If iTD = 0 Then
            If iEnd = 12 Then
                TDelay.Enabled = False
                TRun.Enabled = False
                TReact.Enabled = False
                gObject90.Enabled = False
                meBody.Enabled = False
                TXTR1.Text = cT & vbNewLine & vbNewLine & cE & vbNewLine & vbNewLine & Format(cR / cT, ".00") & "ms"
                TXTR2.Text = iT & vbNewLine & vbNewLine & iE & vbNewLine & vbNewLine & Format(iR / iT, ".00") & "ms"
                Button2.Text = "S T A R T"

                Button0.Visible = True
                Button3.Visible = True
                Button4.Visible = True
            End If
            States = gRandom.Next(1, 4)
            Delay = gRandom.Next(1, 4)
            If Delay = 1 Then
                iTD = 3
            ElseIf Delay = 2 Then
                iTD = 5
            ElseIf Delay = 3 Then
                iTD = 3
            ElseIf Delay = 4 Then
                iTD = 5
            End If
            If States = 1 Then
                GameObject1.BackgroundImage = My.Resources.objGStart
            ElseIf States = 2 Then
                GameObject1.BackgroundImage = My.Resources.objRStop
            ElseIf States = 3 Then
                GameObject1.BackgroundImage = My.Resources.objRStart
            ElseIf States = 4 Then
                GameObject1.BackgroundImage = My.Resources.objGStop
            End If
            React = 0
            iEnd = iEnd + 1
            TiEnd.Text = iEnd
        End If
    End Sub
    Sub gObject90Tick(sender As Object, e As EventArgs) Handles gObject90.Tick
        If TRun.Enabled = True Then
            GameObject99.Location = New Point(GameObject99.Location.X + 1, 165)
            If GameObject99.Location.X >= 1000 Then
                GameObject99.Location = New Point(-400, 40)
            End If
        ElseIf TRun.Enabled = False Then
            GameObject99.Location = New Point(GameObject99.Location.X + 7, 165)
            If GameObject99.Location.X >= 1000 Then
                GameObject99.Location = New Point(-400, 40)
            End If
        End If
    End Sub
    Sub TReactTick(sender As Object, e As EventArgs) Handles TReact.Tick
        React = React + 1
    End Sub
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