Public Class IMKModul5
    Dim Min, Sec, mSec, iCount, Sec2, iNo As Integer
    Dim gObjects, gRandoms, gClick As Integer
    Dim iBall, iAct As Integer
    Dim gText As String
    Dim gRandom As New Random
    Dim gColor1, gColor2, gColor3 As Image

    Sub Modul5Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Functions"
    Sub StartButton(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "S T A R T" Then
            meBody.Enabled = True
            TTimers.FlatAppearance.BorderColor = Color.Lime
            TTimers.ForeColor = Color.Lime
            TCounts.Enabled = True
            TCounters.Enabled = True
            gObjects = 0
            GameObjects()

            TTimers.Text = "00 : 00"
            Sec = 0
            Min = 0
            iCount = 0
            iAct = 0
            iBall = 0
            Sec2 = 0
            mSec = 0

            Button3.Hide()
            Button0.Hide()
            Button4.Hide()


            Chart1.Series("Actions").Points.Clear()
            Chart1.Series("Times").Points.Clear()
            GraphicC1.Text = "Actions" & vbNewLine
            GraphicC2.Text = "Ball" & vbNewLine
            GraphicC3.Text = "Times" & vbNewLine
            Button2.Text = "Pause"
        ElseIf Button2.Text = "Pause" Then
            TTimers.FlatAppearance.BorderColor = Color.Gray
            TTimers.ForeColor = Color.Gray

            TCounts.Enabled = False
            TCounters.Enabled = False

            Button3.Show()
            Button0.Show()
            Button4.Show()

            Button2.Text = "Continue"
        ElseIf Button2.Text = "Continue" Then
            TTimers.FlatAppearance.BorderColor = Color.Lime
            TTimers.ForeColor = Color.Lime

            TCounts.Enabled = True
            TCounters.Enabled = True

            Button3.Hide()
            Button0.Hide()
            Button4.Hide()

            Button2.Text = "Pause"
        End If
    End Sub
    Sub GameObjects()
        gObjects = gObjects + 1
        gRandoms = gRandom.Next(1, 18)
        If gRandoms = 1 Then
            gColor1 = My.Resources.CirclesRed
            gColor2 = My.Resources.CirclesOrange
            gColor3 = My.Resources.CirclesYellow
            gText = " Smallest Red "
        ElseIf gRandoms = 2 Then
            gColor1 = My.Resources.CirclesRed
            gColor2 = My.Resources.CirclesOrange
            gColor3 = My.Resources.CirclesYellow
            gText = " Biggest Red "
        ElseIf gRandoms = 3 Then
            gColor1 = My.Resources.CirclesBlue
            gColor2 = My.Resources.CirclesCyan
            gColor3 = My.Resources.CirclesGreen
            gText = " Smallest Blue "
        ElseIf gRandoms = 4 Then
            gColor1 = My.Resources.CirclesBlue
            gColor2 = My.Resources.CirclesCyan
            gColor3 = My.Resources.CirclesGreen
            gText = " Biggest Blue "
        ElseIf gRandoms = 5 Then
            gColor1 = My.Resources.CirclesBlack
            gColor2 = My.Resources.CirclesPurple
            gColor3 = My.Resources.CirclesRed
            gText = " Smallest Black "
        ElseIf gRandoms = 6 Then
            gColor1 = My.Resources.CirclesBlack
            gColor2 = My.Resources.CirclesPurple
            gColor3 = My.Resources.CirclesRed
            gText = " Biggest Black "
        ElseIf gRandoms = 7 Then
            gColor1 = My.Resources.CirclesYellow
            gColor2 = My.Resources.CirclesOrange
            gColor3 = My.Resources.CirclesWhite
            gText = " Smallest Yellow "
        ElseIf gRandoms = 8 Then
            gColor1 = My.Resources.CirclesYellow
            gColor2 = My.Resources.CirclesOrange
            gColor3 = My.Resources.CirclesWhite
            gText = " Biggest Yellow "
        ElseIf gRandoms = 9 Then
            gColor1 = My.Resources.CirclesPurple
            gColor2 = My.Resources.CirclesRed
            gColor3 = My.Resources.CirclesBlue
            gText = " Smallest Purple "
        ElseIf gRandoms = 10 Then
            gColor1 = My.Resources.CirclesPurple
            gColor2 = My.Resources.CirclesRed
            gColor3 = My.Resources.CirclesBlue
            gText = " Biggest Purple "
        ElseIf gRandoms = 11 Then
            gColor1 = My.Resources.CirclesWhite
            gColor2 = My.Resources.CirclesCyan
            gColor3 = My.Resources.CirclesGreen
            gText = " Smallest White "
        ElseIf gRandoms = 12 Then
            gColor1 = My.Resources.CirclesWhite
            gColor2 = My.Resources.CirclesCyan
            gColor3 = My.Resources.CirclesGreen
            gText = " Biggest White "
        ElseIf gRandoms = 13 Then
            gColor1 = My.Resources.CirclesOrange
            gColor2 = My.Resources.CirclesYellow
            gColor3 = My.Resources.CirclesGreen
            gText = " Smallest Orange "
        ElseIf gRandoms = 14 Then
            gColor1 = My.Resources.CirclesOrange
            gColor2 = My.Resources.CirclesYellow
            gColor3 = My.Resources.CirclesGreen
            gText = " Biggest Orange "
        ElseIf gRandoms = 15 Then
            gColor1 = My.Resources.CirclesGreen
            gColor2 = My.Resources.CirclesWhite
            gColor3 = My.Resources.CirclesYellow
            gText = " Smallest Green "
        ElseIf gRandoms = 16 Then
            gColor1 = My.Resources.CirclesGreen
            gColor2 = My.Resources.CirclesWhite
            gColor3 = My.Resources.CirclesYellow
            gText = " Biggest Green "
        ElseIf gRandoms = 17 Then
            gColor1 = My.Resources.CirclesCyan
            gColor2 = My.Resources.CirclesBlue
            gColor3 = My.Resources.CirclesWhite
            gText = " Smallest Cyan "
        ElseIf gRandoms = 18 Then
            gColor1 = My.Resources.CirclesCyan
            gColor2 = My.Resources.CirclesBlue
            gColor3 = My.Resources.CirclesWhite
            gText = " Biggest Cyan "
        End If
        If gText.Contains("Biggest") Then
            If gObjects = 1 Or gObjects = 10 Then
                gClick = 12
            ElseIf gObjects = 2 Or gObjects = 8 Then
                gClick = 0
            ElseIf gObjects = 3 Or gObjects = 7 Then
                gClick = 5
            ElseIf gObjects = 4 Or gObjects = 9 Then
                gClick = 17
            ElseIf gObjects = 5 Then
                gClick = 4
            ElseIf gObjects = 6 Then
                gClick = 18
            End If
        ElseIf gText.Contains("Smallest") Then
            If gObjects = 1 Or gObjects = 7 Then
                gClick = 22
            ElseIf gObjects = 2 Or gObjects = 9 Then
                gClick = 10
            ElseIf gObjects = 3 Or gObjects = 5 Then
                gClick = 8
            ElseIf gObjects = 4 Or gObjects = 8 Then
                gClick = 15
            ElseIf gObjects = 6 Then
                gClick = 16
            ElseIf gObjects = 10 Then
                gClick = 3
            End If
        End If
        If gObjects = 1 Then
            iBall = 4
            meText.Text = "Click the" & gText & "Ball"

            GameObject12.BackgroundImage = gColor1
            GameObject1.BackgroundImage = gColor1
            GameObject7.BackgroundImage = gColor1
            GameObject22.BackgroundImage = gColor1

            GameObject12.Show()
            GameObject1.Show()
            GameObject7.Show()
            GameObject22.Show()
        ElseIf gObjects = 2 Then
            iBall = 8
            meText.Text = "Click the" & gText & "Ball"

            GameObject12.Hide()
            GameObject1.Hide()
            GameObject7.Hide()
            GameObject22.Hide()

            GameObject0.BackgroundImage = gColor1
            GameObject13.BackgroundImage = gColor1
            GameObject11.BackgroundImage = gColor1
            GameObject10.BackgroundImage = gColor1

            GameObject17.BackgroundImage = gColor2
            GameObject6.BackgroundImage = gColor2
            GameObject20.BackgroundImage = gColor2
            GameObject15.BackgroundImage = gColor2

            GameObject0.Show()
            GameObject13.Show()
            GameObject11.Show()
            GameObject10.Show()
            GameObject17.Show()
            GameObject6.Show()
            GameObject20.Show()
            GameObject15.Show()

        ElseIf gObjects = 3 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject0.Hide()
            GameObject13.Hide()
            GameObject11.Hide()
            GameObject10.Hide()
            GameObject17.Hide()
            GameObject6.Hide()
            GameObject20.Hide()
            GameObject15.Hide()

            GameObject5.BackgroundImage = gColor1
            GameObject9.BackgroundImage = gColor1
            GameObject2.BackgroundImage = gColor1
            GameObject8.BackgroundImage = gColor1

            GameObject4.BackgroundImage = gColor2
            GameObject23.BackgroundImage = gColor2
            GameObject14.BackgroundImage = gColor2
            GameObject22.BackgroundImage = gColor2

            GameObject18.BackgroundImage = gColor3
            GameObject6.BackgroundImage = gColor3
            GameObject19.BackgroundImage = gColor3
            GameObject16.BackgroundImage = gColor3

            GameObject5.Show()
            GameObject9.Show()
            GameObject2.Show()
            GameObject8.Show()
            GameObject4.Show()
            GameObject23.Show()
            GameObject14.Show()
            GameObject22.Show()
            GameObject18.Show()
            GameObject6.Show()
            GameObject19.Show()
            GameObject16.Show()
        ElseIf gObjects = 4 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject5.Hide()
            GameObject9.Hide()
            GameObject2.Hide()
            GameObject8.Hide()
            GameObject4.Hide()
            GameObject23.Hide()
            GameObject14.Hide()
            GameObject22.Hide()
            GameObject18.Hide()
            GameObject6.Hide()
            GameObject19.Hide()
            GameObject16.Hide()

            GameObject17.BackgroundImage = gColor1
            GameObject1.BackgroundImage = gColor1
            GameObject11.BackgroundImage = gColor1
            GameObject15.BackgroundImage = gColor1

            GameObject12.BackgroundImage = gColor2
            GameObject13.BackgroundImage = gColor2
            GameObject7.BackgroundImage = gColor2
            GameObject3.BackgroundImage = gColor2

            GameObject0.BackgroundImage = gColor3
            GameObject21.BackgroundImage = gColor3
            GameObject20.BackgroundImage = gColor3
            GameObject10.BackgroundImage = gColor3

            GameObject17.Show()
            GameObject1.Show()
            GameObject11.Show()
            GameObject15.Show()
            GameObject12.Show()
            GameObject13.Show()
            GameObject7.Show()
            GameObject3.Show()
            GameObject0.Show()
            GameObject21.Show()
            GameObject20.Show()
            GameObject10.Show()
        ElseIf gObjects = 5 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject17.Hide()
            GameObject1.Hide()
            GameObject11.Hide()
            GameObject15.Hide()
            GameObject12.Hide()
            GameObject13.Hide()
            GameObject7.Hide()
            GameObject3.Hide()
            GameObject0.Hide()
            GameObject21.Hide()
            GameObject20.Hide()
            GameObject10.Hide()

            GameObject4.BackgroundImage = gColor1
            GameObject23.BackgroundImage = gColor1
            GameObject14.BackgroundImage = gColor1
            GameObject8.BackgroundImage = gColor1

            GameObject5.BackgroundImage = gColor2
            GameObject21.BackgroundImage = gColor2
            GameObject2.BackgroundImage = gColor2
            GameObject10.BackgroundImage = gColor2

            GameObject18.BackgroundImage = gColor3
            GameObject9.BackgroundImage = gColor3
            GameObject11.BackgroundImage = gColor3
            GameObject16.BackgroundImage = gColor3

            GameObject4.Show()
            GameObject23.Show()
            GameObject14.Show()
            GameObject8.Show()
            GameObject5.Show()
            GameObject21.Show()
            GameObject2.Show()
            GameObject10.Show()
            GameObject18.Show()
            GameObject9.Show()
            GameObject11.Show()
            GameObject16.Show()
        ElseIf gObjects = 6 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject4.Hide()
            GameObject23.Hide()
            GameObject14.Hide()
            GameObject8.Hide()
            GameObject5.Hide()
            GameObject21.Hide()
            GameObject2.Hide()
            GameObject10.Hide()
            GameObject18.Hide()
            GameObject9.Hide()
            GameObject11.Hide()
            GameObject16.Hide()

            GameObject18.BackgroundImage = gColor1
            GameObject6.BackgroundImage = gColor1
            GameObject19.BackgroundImage = gColor1
            GameObject16.BackgroundImage = gColor1

            GameObject17.BackgroundImage = gColor2
            GameObject9.BackgroundImage = gColor2
            GameObject11.BackgroundImage = gColor2
            GameObject8.BackgroundImage = gColor2

            GameObject12.BackgroundImage = gColor3
            GameObject1.BackgroundImage = gColor3
            GameObject2.BackgroundImage = gColor3
            GameObject15.BackgroundImage = gColor3

            GameObject18.Show()
            GameObject6.Show()
            GameObject19.Show()
            GameObject16.Show()
            GameObject17.Show()
            GameObject9.Show()
            GameObject11.Show()
            GameObject8.Show()
            GameObject12.Show()
            GameObject1.Show()
            GameObject2.Show()
            GameObject15.Show()
        ElseIf gObjects = 7 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject18.Hide()
            GameObject6.Hide()
            GameObject19.Hide()
            GameObject16.Hide()
            GameObject17.Hide()
            GameObject9.Hide()
            GameObject11.Hide()
            GameObject8.Hide()
            GameObject12.Hide()
            GameObject1.Hide()
            GameObject2.Hide()
            GameObject15.Hide()

            GameObject5.BackgroundImage = gColor1
            GameObject21.BackgroundImage = gColor1
            GameObject7.BackgroundImage = gColor1
            GameObject22.BackgroundImage = gColor1

            GameObject18.BackgroundImage = gColor2
            GameObject6.BackgroundImage = gColor2
            GameObject19.BackgroundImage = gColor2
            GameObject3.BackgroundImage = gColor2

            GameObject17.BackgroundImage = gColor3
            GameObject23.BackgroundImage = gColor3
            GameObject14.BackgroundImage = gColor3
            GameObject8.BackgroundImage = gColor3

            GameObject5.Show()
            GameObject21.Show()
            GameObject7.Show()
            GameObject22.Show()
            GameObject18.Show()
            GameObject6.Show()
            GameObject19.Show()
            GameObject3.Show()
            GameObject17.Show()
            GameObject23.Show()
            GameObject14.Show()
            GameObject8.Show()
        ElseIf gObjects = 8 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject5.Hide()
            GameObject21.Hide()
            GameObject7.Hide()
            GameObject22.Hide()
            GameObject18.Hide()
            GameObject6.Hide()
            GameObject19.Hide()
            GameObject3.Hide()
            GameObject17.Hide()
            GameObject23.Hide()
            GameObject14.Hide()
            GameObject8.Hide()

            GameObject0.BackgroundImage = gColor1
            GameObject9.BackgroundImage = gColor1
            GameObject20.BackgroundImage = gColor1
            GameObject15.BackgroundImage = gColor1

            GameObject12.BackgroundImage = gColor2
            GameObject1.BackgroundImage = gColor2
            GameObject11.BackgroundImage = gColor2
            GameObject10.BackgroundImage = gColor2

            GameObject4.BackgroundImage = gColor3
            GameObject13.BackgroundImage = gColor3
            GameObject7.BackgroundImage = gColor3
            GameObject22.BackgroundImage = gColor3

            GameObject0.Show()
            GameObject9.Show()
            GameObject20.Show()
            GameObject15.Show()
            GameObject12.Show()
            GameObject1.Show()
            GameObject11.Show()
            GameObject10.Show()
            GameObject4.Show()
            GameObject13.Show()
            GameObject7.Show()
            GameObject22.Show()
        ElseIf gObjects = 9 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject0.Hide()
            GameObject9.Hide()
            GameObject20.Hide()
            GameObject15.Hide()
            GameObject12.Hide()
            GameObject1.Hide()
            GameObject11.Hide()
            GameObject10.Hide()
            GameObject4.Hide()
            GameObject13.Hide()
            GameObject7.Hide()
            GameObject22.Hide()

            GameObject17.BackgroundImage = gColor1
            GameObject13.BackgroundImage = gColor1
            GameObject2.BackgroundImage = gColor1
            GameObject10.BackgroundImage = gColor1

            GameObject4.BackgroundImage = gColor2
            GameObject23.BackgroundImage = gColor2
            GameObject14.BackgroundImage = gColor2
            GameObject16.BackgroundImage = gColor2

            GameObject5.BackgroundImage = gColor3
            GameObject1.BackgroundImage = gColor3
            GameObject19.BackgroundImage = gColor3
            GameObject3.BackgroundImage = gColor3

            GameObject17.Show()
            GameObject13.Show()
            GameObject2.Show()
            GameObject10.Show()
            GameObject4.Show()
            GameObject23.Show()
            GameObject14.Show()
            GameObject16.Show()
            GameObject5.Show()
            GameObject1.Show()
            GameObject19.Show()
            GameObject3.Show()
        ElseIf gObjects = 10 Then
            iBall = 12
            meText.Text = "Click the" & gText & "Ball"

            GameObject17.Hide()
            GameObject13.Hide()
            GameObject2.Hide()
            GameObject10.Hide()
            GameObject4.Hide()
            GameObject23.Hide()
            GameObject14.Hide()
            GameObject16.Hide()
            GameObject5.Hide()
            GameObject1.Hide()
            GameObject19.Hide()
            GameObject3.Hide()

            GameObject12.BackgroundImage = gColor1
            GameObject6.BackgroundImage = gColor1
            GameObject14.BackgroundImage = gColor1
            GameObject3.BackgroundImage = gColor1

            GameObject0.BackgroundImage = gColor2
            GameObject1.BackgroundImage = gColor2
            GameObject7.BackgroundImage = gColor2
            GameObject22.BackgroundImage = gColor2

            GameObject17.BackgroundImage = gColor3
            GameObject21.BackgroundImage = gColor3
            GameObject2.BackgroundImage = gColor3
            GameObject10.BackgroundImage = gColor3

            GameObject12.Show()
            GameObject6.Show()
            GameObject14.Show()
            GameObject3.Show()
            GameObject0.Show()
            GameObject1.Show()
            GameObject7.Show()
            GameObject22.Show()
            GameObject17.Show()
            GameObject21.Show()
            GameObject2.Show()
            GameObject10.Show()
        ElseIf gObjects = 11 Then
            GameObject12.Hide()
            GameObject6.Hide()
            GameObject14.Hide()
            GameObject3.Hide()
            GameObject0.Hide()
            GameObject1.Hide()
            GameObject7.Hide()
            GameObject22.Hide()
            GameObject17.Hide()
            GameObject21.Hide()
            GameObject2.Hide()
            GameObject10.Hide()
            meBody.Enabled = False
            TTimers.FlatAppearance.BorderColor = Color.Gray
            TTimers.ForeColor = Color.Gray

            TCounts.Enabled = False
            TCounters.Enabled = False

            Button3.Show()
            Button0.Show()
            Button4.Show()

            meText.Text = "VICTORY"
            Button2.Text = "S T A R T"
        End If
    End Sub
    Sub GameObjectsVisible()
        GameObject0.Hide()
        GameObject1.Hide()
        GameObject2.Hide()
        GameObject3.Hide()
        GameObject4.Hide()
        GameObject5.Hide()
        GameObject6.Hide()
        GameObject7.Hide()
        GameObject8.Hide()
        GameObject9.Hide()
        GameObject10.Hide()
        GameObject11.Hide()
        GameObject12.Hide()
        GameObject13.Hide()
        GameObject14.Hide()
        GameObject15.Hide()
        GameObject16.Hide()
        GameObject17.Hide()
        GameObject18.Hide()
        GameObject19.Hide()
        GameObject20.Hide()
        GameObject21.Hide()
        GameObject22.Hide()
        GameObject23.Hide()
    End Sub
    Sub IfWrongs()
        GameObjectsVisible()
        TNotif.Enabled = True
        gObjects = 0
        iObjects.Text = gObjects & "/10"
        GameObjects()
        Chart1.Series("Actions").Points.Clear()
        Chart1.Series("Times").Points.Clear()
        GraphicC1.Text = "Actions" & vbNewLine
        GraphicC2.Text = "Ball" & vbNewLine
        GraphicC3.Text = "Times" & vbNewLine
    End Sub
    Sub GameObject0Click(sender As Object, e As EventArgs) Handles GameObject0.Click
        iAct = iAct + 1
        If gClick = 0 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject1Click(sender As Object, e As EventArgs) Handles GameObject1.Click
        iAct = iAct + 1
        If gClick = 1 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject2Click(sender As Object, e As EventArgs) Handles GameObject2.Click
        iAct = iAct + 1
        If gClick = 2 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject3Click(sender As Object, e As EventArgs) Handles GameObject3.Click
        iAct = iAct + 1
        If gClick = 3 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject4Click(sender As Object, e As EventArgs) Handles GameObject4.Click
        iAct = iAct + 1
        If gClick = 4 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject5Click(sender As Object, e As EventArgs) Handles GameObject5.Click
        iAct = iAct + 1
        If gClick = 5 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject6Click(sender As Object, e As EventArgs) Handles GameObject6.Click
        iAct = iAct + 1
        If gClick = 6 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject7Click(sender As Object, e As EventArgs) Handles GameObject7.Click
        iAct = iAct + 1
        If gClick = 7 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject8Click(sender As Object, e As EventArgs) Handles GameObject8.Click
        iAct = iAct + 1
        If gClick = 8 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject9Click(sender As Object, e As EventArgs) Handles GameObject9.Click
        iAct = iAct + 1
        If gClick = 9 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject10Click(sender As Object, e As EventArgs) Handles GameObject10.Click
        iAct = iAct + 1
        If gClick = 10 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject11Click(sender As Object, e As EventArgs) Handles GameObject11.Click
        iAct = iAct + 1
        If gClick = 11 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject12Click(sender As Object, e As EventArgs) Handles GameObject12.Click
        iAct = iAct + 1
        If gClick = 12 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject13Click(sender As Object, e As EventArgs) Handles GameObject13.Click
        iAct = iAct + 1
        If gClick = 13 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject14Click(sender As Object, e As EventArgs) Handles GameObject14.Click
        iAct = iAct + 1
        If gClick = 14 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject15Click(sender As Object, e As EventArgs) Handles GameObject15.Click
        iAct = iAct + 1
        If gClick = 15 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject16Click(sender As Object, e As EventArgs) Handles GameObject16.Click
        iAct = iAct + 1
        If gClick = 16 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject17Click(sender As Object, e As EventArgs) Handles GameObject17.Click
        iAct = iAct + 1
        If gClick = 17 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject18Click(sender As Object, e As EventArgs) Handles GameObject18.Click
        iAct = iAct + 1
        If gClick = 18 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject19Click(sender As Object, e As EventArgs) Handles GameObject19.Click
        iAct = iAct + 1
        If gClick = 19 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject20Click(sender As Object, e As EventArgs) Handles GameObject20.Click
        iAct = iAct + 1
        If gClick = 20 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject21Click(sender As Object, e As EventArgs) Handles GameObject21.Click
        iAct = iAct + 1
        If gClick = 21 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject22Click(sender As Object, e As EventArgs) Handles GameObject22.Click
        iAct = iAct + 1
        If gClick = 22 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub
    Sub GameObject23Click(sender As Object, e As EventArgs) Handles GameObject23.Click
        iAct = iAct + 1
        If gClick = 23 Then
            GameObjects()
            iObjects.Text = gObjects - 1 & "/10"
            GraphicC1.Text = GraphicC1.Text & iAct & vbNewLine
            GraphicC2.Text = GraphicC2.Text & iBall & vbNewLine
            GraphicC3.Text = GraphicC3.Text & Format(Sec2, "00") & "." & Format(mSec, "00") & vbNewLine
            Chart1.Series("Actions").Points.AddXY(gObjects, iAct)
            Chart1.Series("Times").Points.AddXY(gObjects, iCount)
        Else
            IfWrongs()
        End If
        iCount = 0
        mSec = 0
        Sec2 = 0
    End Sub


    Private Sub GraphicButton(sender As Object, e As EventArgs) Handles Button3.Click
        If meBody.Visible = True Then
            meBody.Hide()
            meGraphic.Show()
            Button2.Hide()
            Button3.Text = "Close"
        ElseIf meBody.Visible = False Then
            meBody.Show()
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
    Private Sub TCountersTick(sender As Object, e As EventArgs) Handles TCounters.Tick
        iCount = iCount + 1
        mSec = mSec + 1
        If mSec = 100 Then
            Sec2 = Sec2 + 1
            mSec = 0
        End If
    End Sub
    Private Sub TNotif_Tick(sender As Object, e As EventArgs) Handles TNotif.Tick
        iNo = iNo + 1
        If iNo = 1 Then
            iNotif.Show()
        ElseIf iNo = 2 Then
            iNotif.Hide()
        ElseIf iNo = 3 Then
            iNotif.Show()
        ElseIf iNo = 4 Then
            iNotif.Hide()
        ElseIf iNo = 5 Then
            iNotif.Show()
        ElseIf iNo = 35 Then
            iNotif.Hide()
            TNotif.Enabled = False
            iNo = 0
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