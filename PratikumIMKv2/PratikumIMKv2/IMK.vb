Public Class IMK
    Dim X1, X2, States, iTExit, iInfo, Access, DMenu As Integer
    Sub IMKLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        meInfo.Text = ""
        meSubInfo.Text = ""
        meText.Text = Me.Text
        meSidebar.Location = New Point(600, 30)
        X2 = 600
        X1 = 800
    End Sub

#Region "Button Configuration"
    'Menu Buttons
    Sub MenuMouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.White
        Button1.BackgroundImage = My.Resources.CirclesRed
        If TInfo.Enabled = False And TMenu.Enabled = False Then

            meInfo.Text = "ALL PROGRAMS"
            If States = 0 Then
                meSubInfo.Text = "CLICK TO SHOW"
            ElseIf States = 1 Then
                meSubInfo.Text = "CLICK TO HIDE"
            End If
        End If
    End Sub
    Sub MenuMouseClick(sender As Object, e As EventArgs) Handles Button1.Click
        TSidebar.Enabled = True
        meSidebar.Show()
        meInfo.Font = New Font("Chakra Petch", 28.0!, FontStyle.Bold)
        TInfo.Enabled = False
        iInfo = 0
        If States = 1 Then
            meSubInfo.Text = "CLICK TO SHOW"
            meInfo.Text = "ALL PROGRAMS"
        ElseIf States = 0 Then
            meSubInfo.Text = "CLICK TO HIDE"
            meInfo.Text = "ALL PROGRAMS"
        End If
    End Sub
    Sub TSidebarRun(sender As Object, e As EventArgs) Handles TSidebar.Tick
        If States = 0 Then
            X1 = X1 + 8
            X2 = X2 + 8
        ElseIf States = 1 Then
            X1 = X1 - 8
            X2 = X2 - 8
        End If
        Me.Size = New Size(X1, 600)
        meHeader.Size = New Size(X1, 30)
        meSidebar.Location = New Point(X2, 30)
        meFooter.Size = New Size(X1, 30)
        If X1 = 1000 Then
            States = 1
            TSidebar.Enabled = False
        ElseIf X1 = 800 Then
            States = 0
            TSidebar.Enabled = False
            meSidebar.Hide()
        End If
    End Sub
    Sub MenuMouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Gray
        Button1.BackgroundImage = My.Resources.CirclesBlack
        If TInfo.Enabled = False And TMenu.Enabled = False Then

            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    'Info Buttons
    Sub InfoMouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.White
        Button2.BackgroundImage = My.Resources.CirclesRed
        If TInfo.Enabled = False And TMenu.Enabled = False Then

            meSubInfo.Text = "CLICK TO SHOW"
            meInfo.Text = "ABOUT THIS PROGRAM"
        End If
    End Sub
    Sub InfoMouseClick(sender As Object, e As EventArgs) Handles Button2.Click
        If TInfo.Enabled = False And TMenu.Enabled = False Then
            meSubInfo.Text = ""
            meInfo.Text = ""
            TInfo.Enabled = True
        End If
    End Sub
    Sub TInfoRun(sender As Object, e As EventArgs) Handles TInfo.Tick
        iInfo = iInfo + 1
        If iInfo = 1 Then
            meSubInfo.Text = "T|"
        ElseIf iInfo = 2 Then
            meSubInfo.Text = "T U|"
        ElseIf iInfo = 3 Then
            meSubInfo.Text = "T U G|"
        ElseIf iInfo = 4 Then
            meSubInfo.Text = "T U G A|"
        ElseIf iInfo = 5 Then
            meSubInfo.Text = "T U G A S|"
        ElseIf iInfo = 6 Then
            meSubInfo.Text = "T U G A S   P|"
        ElseIf iInfo = 7 Then
            meSubInfo.Text = "T U G A S   P R|"
        ElseIf iInfo = 8 Then
            meSubInfo.Text = "T U G A S   P R A|"
        ElseIf iInfo = 9 Then
            meSubInfo.Text = "T U G A S   P R A T|"
        ElseIf iInfo = 10 Then
            meSubInfo.Text = "T U G A S   P R A T I|"
        ElseIf iInfo = 11 Then
            meSubInfo.Text = "T U G A S   P R A T I K|"
        ElseIf iInfo = 12 Then
            meSubInfo.Text = "T U G A S   P R A T I K U|"
        ElseIf iInfo = 13 Then
            meSubInfo.Text = "T U G A S   P R A T I K U M|"
        ElseIf iInfo = 14 Then
            meSubInfo.Text = "T U G A S   P R A T I K U M"
            meInfo.Font = New Font("Chakra Petch", 14.0!, FontStyle.Bold)
            meInfo.Text = "I|"
        ElseIf iInfo = 15 Then
            meInfo.Text = "I N|"
        ElseIf iInfo = 16 Then
            meInfo.Text = "I N T|"
        ElseIf iInfo = 17 Then
            meInfo.Text = "I N T E|"
        ElseIf iInfo = 18 Then
            meInfo.Text = "I N T E R|"
        ElseIf iInfo = 19 Then
            meInfo.Text = "I N T E R A|"
        ElseIf iInfo = 20 Then
            meInfo.Text = "I N T E R A K|"
        ElseIf iInfo = 21 Then
            meInfo.Text = "I N T E R A K S|"
        ElseIf iInfo = 22 Then
            meInfo.Text = "I N T E R A K S I|"
        ElseIf iInfo = 23 Then
            meInfo.Text = "I N T E R A K S I   M|"
        ElseIf iInfo = 24 Then
            meInfo.Text = "I N T E R A K S I   M A|"
        ElseIf iInfo = 25 Then
            meInfo.Text = "I N T E R A K S I   M A N|"
        ElseIf iInfo = 26 Then
            meInfo.Text = "I N T E R A K S I   M A N U|"
        ElseIf iInfo = 27 Then
            meInfo.Text = "I N T E R A K S I   M A N U S|"
        ElseIf iInfo = 28 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I|"
        ElseIf iInfo = 29 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A|"
        ElseIf iInfo = 30 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D|"
        ElseIf iInfo = 31 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A|"
        ElseIf iInfo = 32 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N|"
        ElseIf iInfo = 33 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K|"
        ElseIf iInfo = 34 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O|"
        ElseIf iInfo = 35 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M|"
        ElseIf iInfo = 36 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P|"
        ElseIf iInfo = 37 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U|"
        ElseIf iInfo = 38 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T|"
        ElseIf iInfo = 39 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E|"
        ElseIf iInfo = 40 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R|"
        ElseIf iInfo = 50 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R"
        ElseIf iInfo = 60 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R|"
        ElseIf iInfo = 70 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R"
        ElseIf iInfo = 80 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R|"
        ElseIf iInfo = 90 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R"
        ElseIf iInfo = 100 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R|"
        ElseIf iInfo = 110 Then
            meInfo.Text = "I N T E R A K S I   M A N U S I A   D A N   K O M P U T E R"
        ElseIf iInfo = 120 Then
            meSubInfo.Text = "P|"
            meInfo.Text = ""
        ElseIf iInfo = 121 Then
            meSubInfo.Text = "P R|"
        ElseIf iInfo = 122 Then
            meSubInfo.Text = "P R O|"
        ElseIf iInfo = 123 Then
            meSubInfo.Text = "P R O G|"
        ElseIf iInfo = 124 Then
            meSubInfo.Text = "P R O G R|"
        ElseIf iInfo = 125 Then
            meSubInfo.Text = "P R O G R A|"
        ElseIf iInfo = 126 Then
            meSubInfo.Text = "P R O G R A M|"
        ElseIf iInfo = 127 Then
            meSubInfo.Text = "P R O G R A M   S|"
        ElseIf iInfo = 128 Then
            meSubInfo.Text = "P R O G R A M   S T|"
        ElseIf iInfo = 129 Then
            meSubInfo.Text = "P R O G R A M   S T U|"
        ElseIf iInfo = 130 Then
            meSubInfo.Text = "P R O G R A M   S T U D|"
        ElseIf iInfo = 131 Then
            meSubInfo.Text = "P R O G R A M   S T U D I|"
        ElseIf iInfo = 132 Then
            meSubInfo.Text = "P R O G R A M   S T U D I"
            meInfo.Font = New Font("Chakra Petch", 22.0!, FontStyle.Bold)
            meInfo.Text = "T|"
        ElseIf iInfo = 133 Then
            meInfo.Text = "T E|"
        ElseIf iInfo = 134 Then
            meInfo.Text = "T E K|"
        ElseIf iInfo = 135 Then
            meInfo.Text = "T E K N|"
        ElseIf iInfo = 136 Then
            meInfo.Text = "T E K N I|"
        ElseIf iInfo = 137 Then
            meInfo.Text = "T E K N I K|"
        ElseIf iInfo = 138 Then
            meInfo.Text = "T E K N I K   I|"
        ElseIf iInfo = 139 Then
            meInfo.Text = "T E K N I K   I N|"
        ElseIf iInfo = 140 Then
            meInfo.Text = "T E K N I K   I N F|"
        ElseIf iInfo = 141 Then
            meInfo.Text = "T E K N I K   I N F O|"
        ElseIf iInfo = 142 Then
            meInfo.Text = "T E K N I K   I N F O R|"
        ElseIf iInfo = 143 Then
            meInfo.Text = "T E K N I K   I N F O R M|"
        ElseIf iInfo = 144 Then
            meInfo.Text = "T E K N I K   I N F O R M A|"
        ElseIf iInfo = 145 Then
            meInfo.Text = "T E K N I K   I N F O R M A T|"
        ElseIf iInfo = 146 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I|"
        ElseIf iInfo = 147 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K|"
        ElseIf iInfo = 148 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A|"
        ElseIf iInfo = 158 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A"
        ElseIf iInfo = 168 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A|"
        ElseIf iInfo = 178 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A"
        ElseIf iInfo = 188 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A|"
        ElseIf iInfo = 198 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A"
        ElseIf iInfo = 208 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A|"
        ElseIf iInfo = 218 Then
            meInfo.Text = "T E K N I K   I N F O R M A T I K A"
        ElseIf iInfo = 228 Then
            meSubInfo.Text = "F|"
            meInfo.Text = ""
        ElseIf iInfo = 229 Then
            meSubInfo.Text = "F A|"
        ElseIf iInfo = 230 Then
            meSubInfo.Text = "F A K|"
        ElseIf iInfo = 231 Then
            meSubInfo.Text = "F A K U|"
        ElseIf iInfo = 232 Then
            meSubInfo.Text = "F A K U L|"
        ElseIf iInfo = 233 Then
            meSubInfo.Text = "F A K U L T|"
        ElseIf iInfo = 234 Then
            meSubInfo.Text = "F A K U L T A|"
        ElseIf iInfo = 235 Then
            meSubInfo.Text = "F A K U L T A S|"
        ElseIf iInfo = 236 Then
            meSubInfo.Text = "F A K U L T A S"
            meInfo.Font = New Font("Chakra Petch", 30.0!, FontStyle.Bold)
            meInfo.Text = "I|"
        ElseIf iInfo = 237 Then
            meInfo.Text = "I L|"
        ElseIf iInfo = 238 Then
            meInfo.Text = "I L M|"
        ElseIf iInfo = 239 Then
            meInfo.Text = "I L M U|"
        ElseIf iInfo = 240 Then
            meInfo.Text = "I L M U   K|"
        ElseIf iInfo = 241 Then
            meInfo.Text = "I L M U   K O|"
        ElseIf iInfo = 242 Then
            meInfo.Text = "I L M U   K O M|"
        ElseIf iInfo = 243 Then
            meInfo.Text = "I L M U   K O M P|"
        ElseIf iInfo = 244 Then
            meInfo.Text = "I L M U   K O M P U|"
        ElseIf iInfo = 245 Then
            meInfo.Text = "I L M U   K O M P U T|"
        ElseIf iInfo = 246 Then
            meInfo.Text = "I L M U   K O M P U T E|"
        ElseIf iInfo = 247 Then
            meInfo.Text = "I L M U   K O M P U T E R|"
        ElseIf iInfo = 257 Then
            meInfo.Text = "I L M U   K O M P U T E R"
        ElseIf iInfo = 267 Then
            meInfo.Text = "I L M U   K O M P U T E R|"
        ElseIf iInfo = 277 Then
            meInfo.Text = "I L M U   K O M P U T E R"
        ElseIf iInfo = 287 Then
            meInfo.Text = "I L M U   K O M P U T E R|"
        ElseIf iInfo = 297 Then
            meInfo.Text = "I L M U   K O M P U T E R"
        ElseIf iInfo = 307 Then
            meInfo.Text = "I L M U   K O M P U T E R|"
        ElseIf iInfo = 317 Then
            meInfo.Text = "I L M U   K O M P U T E R"
        ElseIf iInfo = 327 Then
            meSubInfo.Text = "P|"
            meInfo.Text = ""
        ElseIf iInfo = 328 Then
            meSubInfo.Text = "P E|"
        ElseIf iInfo = 329 Then
            meSubInfo.Text = "P E M|"
        ElseIf iInfo = 330 Then
            meSubInfo.Text = "P E M B|"
        ElseIf iInfo = 331 Then
            meSubInfo.Text = "P E M B U|"
        ElseIf iInfo = 332 Then
            meSubInfo.Text = "P E M B U A|"
        ElseIf iInfo = 333 Then
            meSubInfo.Text = "P E M B U A T|"
        ElseIf iInfo = 334 Then
            meSubInfo.Text = "P E M B U A T   P|"
        ElseIf iInfo = 335 Then
            meSubInfo.Text = "P E M B U A T   P R|"
        ElseIf iInfo = 336 Then
            meSubInfo.Text = "P E M B U A T   P R O|"
        ElseIf iInfo = 337 Then
            meSubInfo.Text = "P E M B U A T   P R O G|"
        ElseIf iInfo = 338 Then
            meSubInfo.Text = "P E M B U A T   P R O G R|"
        ElseIf iInfo = 339 Then
            meSubInfo.Text = "P E M B U A T   P R O G R A|"
        ElseIf iInfo = 340 Then
            meSubInfo.Text = "P E M B U A T   P R O G R A M|"
        ElseIf iInfo = 341 Then
            meSubInfo.Text = "P E M B U A T   P R O G R A M"
            meInfo.Font = New Font("Chakra Petch", 28.0!, FontStyle.Bold)
            meInfo.Text = "S|"
        ElseIf iInfo = 342 Then
            meInfo.Text = "S U|"
        ElseIf iInfo = 343 Then
            meInfo.Text = "S U R|"
        ElseIf iInfo = 344 Then
            meInfo.Text = "S U R Y|"
        ElseIf iInfo = 345 Then
            meInfo.Text = "S U R Y A|"
        ElseIf iInfo = 346 Then
            meInfo.Text = "S U R Y A   N|"
        ElseIf iInfo = 347 Then
            meInfo.Text = "S U R Y A   N I|"
        ElseIf iInfo = 348 Then
            meInfo.Text = "S U R Y A   N I C|"
        ElseIf iInfo = 349 Then
            meInfo.Text = "S U R Y A   N I C H|"
        ElseIf iInfo = 350 Then
            meInfo.Text = "S U R Y A   N I C H O|"
        ElseIf iInfo = 351 Then
            meInfo.Text = "S U R Y A   N I C H O L|"
        ElseIf iInfo = 352 Then
            meInfo.Text = "S U R Y A   N I C H O L A|"
        ElseIf iInfo = 353 Then
            meInfo.Text = "S U R Y A   N I C H O L A S|"
        ElseIf iInfo = 363 Then
            meInfo.Text = "S U R Y A   N I C H O L A S"
        ElseIf iInfo = 373 Then
            meInfo.Text = "S U R Y A   N I C H O L A S|"
        ElseIf iInfo = 383 Then
            meInfo.Text = "S U R Y A   N I C H O L A S"
        ElseIf iInfo = 393 Then
            meInfo.Text = "S U R Y A   N I C H O L A S|"
        ElseIf iInfo = 403 Then
            meInfo.Text = "S U R Y A   N I C H O L A S"
        ElseIf iInfo = 413 Then
            meInfo.Text = "S U R Y A   N I C H O L A S|"
        ElseIf iInfo = 423 Then
            meInfo.Text = "S U R Y A   N I C H O L A S"
        ElseIf iInfo = 433 Then
            meSubInfo.Text = ""
            meInfo.Text = ""
            meInfo.Font = New Font("Chakra Petch", 28.0!, FontStyle.Bold)
            TInfo.Enabled = False
            iInfo = 0
        End If
    End Sub
    Sub InfoMouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Gray
        Button2.BackgroundImage = My.Resources.CirclesBlack
        If TInfo.Enabled = False And TMenu.Enabled = False Then

            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    'Exit Buttons
    Sub ExitMouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.White
        Button3.BackgroundImage = My.Resources.CirclesRed
        If TInfo.Enabled = False And TMenu.Enabled = False Then
            meSubInfo.Text = "ALREADY WANT TO GO? CLICK TO"
            meInfo.Text = "CLOSE THIS PROGRAM"
        End If
    End Sub
    Sub ExitMouseClick(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        If States = 1 Then
            TSidebar.Enabled = True
        End If
        meInfo.Font = New Font("Chakra Petch", 30.0!, FontStyle.Bold)
        meSubInfo.Hide()
        TInfo.Enabled = False
        TExit.Enabled = True
    End Sub
    Sub TExitRun(sender As Object, e As EventArgs) Handles TExit.Tick
        iTExit = iTExit + 1
        If iTExit = 1 Then
            meInfo.Text = "C"
        ElseIf iTExit = 2 Then
            meInfo.Text = "C L O"
        ElseIf iTExit = 3 Then
            meInfo.Text = "C L O S"
        ElseIf iTExit = 4 Then
            meInfo.Text = "C L O S I"
        ElseIf iTExit = 5 Then
            meInfo.Text = "C L O S I N"
        ElseIf iTExit = 6 Then
            meInfo.Text = "C L O S I N G"
        ElseIf iTExit = 7 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P"
        ElseIf iTExit = 8 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R"
        ElseIf iTExit = 9 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R O"
        ElseIf iTExit = 10 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R O G"
        ElseIf iTExit = 11 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R O G R"
        ElseIf iTExit = 12 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R O G R A"
        ElseIf iTExit = 13 Then
            meInfo.Text = "C L O S I N G" & vbNewLine & "P R O G R A M"
        ElseIf iTExit = 33 Then
            Me.Close()
        End If
    End Sub
    Sub ExitMouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Gray
        Button3.BackgroundImage = My.Resources.CirclesBlack
        If TInfo.Enabled = False And TMenu.Enabled = False Then
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub
#End Region
#Region "Sidebar Buttons Configuration"
    Sub Modul1Enter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        If TMenu.Enabled = False Then
            Button4.ForeColor = Color.White
            Button4.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   1"
            meInfo.Text = "S E R I A L   P O S I T I O N"
        End If
    End Sub
    Sub Modul1Leave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        If TMenu.Enabled = False Then
            Button4.ForeColor = Color.FromArgb(120, 120, 120)
            Button4.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul2Enter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        If TMenu.Enabled = False Then
            Button5.ForeColor = Color.White
            Button5.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   2"
            meInfo.Text = "W E B E R ' S   L A W"
        End If
    End Sub
    Sub Modul2Leave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        If TMenu.Enabled = False Then
            Button5.ForeColor = Color.FromArgb(120, 120, 120)
            Button5.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul3Enter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        If TMenu.Enabled = False Then
            Button6.ForeColor = Color.White
            Button6.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   3"
            meInfo.Text = "M A Z E"
        End If
    End Sub
    Sub Modul3Leave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        If TMenu.Enabled = False Then
            Button6.ForeColor = Color.FromArgb(120, 120, 120)
            Button6.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul4Enter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        If TMenu.Enabled = False Then
            Button7.ForeColor = Color.White
            Button7.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   4"
            meInfo.Text = "F I T T ' S   L A W"
        End If
    End Sub
    Sub Modul4Leave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        If TMenu.Enabled = False Then
            Button7.ForeColor = Color.FromArgb(120, 120, 120)
            Button7.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul5Enter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        If TMenu.Enabled = False Then
            Button8.ForeColor = Color.White
            Button8.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   5"
            meInfo.Text = "H I C K ' S   L A W"
        End If
    End Sub
    Sub Modul5Leave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        If TMenu.Enabled = False Then
            Button8.ForeColor = Color.FromArgb(120, 120, 120)
            Button8.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul6Enter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Button9.ForeColor = Color.White
        Button9.FlatAppearance.BorderColor = Color.White
        meSubInfo.Text = "M O D U L   6"
        meInfo.Text = "C O N S I S T E N C Y"
    End Sub
    Sub Modul6Leave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        If TMenu.Enabled = False Then
            Button9.ForeColor = Color.FromArgb(120, 120, 120)
            Button9.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub

    Sub Modul7Enter(sender As Object, e As EventArgs) Handles Button10.MouseEnter
        If TMenu.Enabled = False Then
            Button10.ForeColor = Color.White
            Button10.FlatAppearance.BorderColor = Color.White
            meSubInfo.Text = "M O D U L   7"
            meInfo.Text = "P R O T O T Y P I N G"
        End If
    End Sub
    Sub Modul7Leave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        If TMenu.Enabled = False Then
            Button10.ForeColor = Color.FromArgb(120, 120, 120)
            Button10.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120)
            meSubInfo.Text = ""
            meInfo.Text = ""
        End If
    End Sub
#End Region
#Region "Sidebar Buttons Function"
    Sub Modul1Click(sender As Object, e As EventArgs) Handles Button4.Click
        Access = 1
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul2Click(sender As Object, e As EventArgs) Handles Button5.Click
        Access = 2
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul3Click(sender As Object, e As EventArgs) Handles Button6.Click
        Access = 3
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul4Click(sender As Object, e As EventArgs) Handles Button7.Click
        Access = 4
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul5Click(sender As Object, e As EventArgs) Handles Button8.Click
        Access = 5
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul6Click(sender As Object, e As EventArgs) Handles Button9.Click
        Access = 6
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub Modul7Click(sender As Object, e As EventArgs) Handles Button10.Click
        Access = 7
        TMenu.Enabled = True
        TSidebar.Enabled = True
    End Sub

    Sub TMenuRun(sender As Object, e As EventArgs) Handles TMenu.Tick
        DMenu = DMenu + 1
        If Access = 1 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   1|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                IMKModul1.Show()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 2 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   2|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 3 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   3|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 4 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   4|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                IMKModul4.Show()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 5 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   5|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                IMKModul5.Show()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 6 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   6|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                IMKModul6.Show()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        ElseIf Access = 7 Then
            If DMenu = 1 Then
                meSubInfo.Text = "O|"
                meInfo.Text = ""
            ElseIf DMenu = 2 Then
                meSubInfo.Text = "O P|"
            ElseIf DMenu = 3 Then
                meSubInfo.Text = "O P E|"
            ElseIf DMenu = 4 Then
                meSubInfo.Text = "O P E N|"
            ElseIf DMenu = 5 Then
                meSubInfo.Text = "O P E N I|"
            ElseIf DMenu = 6 Then
                meSubInfo.Text = "O P E N I N|"
            ElseIf DMenu = 7 Then
                meSubInfo.Text = "O P E N I N G|"
            ElseIf DMenu = 8 Then
                meSubInfo.Text = "O P E N I N G   P|"
            ElseIf DMenu = 9 Then
                meSubInfo.Text = "O P E N I N G   P R|"
            ElseIf DMenu = 10 Then
                meSubInfo.Text = "O P E N I N G   P R O|"
            ElseIf DMenu = 11 Then
                meSubInfo.Text = "O P E N I N G   P R O G|"
            ElseIf DMenu = 12 Then
                meSubInfo.Text = "O P E N I N G   P R O G R|"
            ElseIf DMenu = 13 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A|"
            ElseIf DMenu = 14 Then
                meSubInfo.Text = "O P E N I N G   P R O G R A M"
                meInfo.Text = "M|"
            ElseIf DMenu = 15 Then
                meInfo.Text = "M O|"
            ElseIf DMenu = 16 Then
                meInfo.Text = "M O D|"
            ElseIf DMenu = 17 Then
                meInfo.Text = "M O D U|"
            ElseIf DMenu = 18 Then
                meInfo.Text = "M O D U L|"
            ElseIf DMenu = 19 Then
                meInfo.Text = "M O D U L   7|"
            ElseIf DMenu = 29 Then
                Me.Hide()
                meSubInfo.Text = ""
                meInfo.Text = ""
                DMenu = 0
                TMenu.Enabled = False
            End If
        End If
    End Sub
#End Region
End Class
