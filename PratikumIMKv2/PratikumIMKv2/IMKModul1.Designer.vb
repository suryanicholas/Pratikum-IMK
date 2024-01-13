<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMKModul1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.meSidebar = New System.Windows.Forms.Panel()
        Me.meFooter = New System.Windows.Forms.Panel()
        Me.meHeader = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.meBody = New System.Windows.Forms.Panel()
        Me.meSubInfo = New System.Windows.Forms.Label()
        Me.meInfo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.meSidebar.SuspendLayout()
        Me.meHeader.SuspendLayout()
        Me.meBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(10, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 40)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Graphic"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Gray
        Me.Button3.Location = New System.Drawing.Point(10, 70)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "How to play?"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Gray
        Me.Button8.Location = New System.Drawing.Point(10, 480)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(180, 40)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Exit"
        Me.Button8.UseCompatibleTextRendering = True
        Me.Button8.UseVisualStyleBackColor = False
        '
        'meSidebar
        '
        Me.meSidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meSidebar.Controls.Add(Me.Button8)
        Me.meSidebar.Controls.Add(Me.Button3)
        Me.meSidebar.Controls.Add(Me.Button2)
        Me.meSidebar.Location = New System.Drawing.Point(800, 30)
        Me.meSidebar.Name = "meSidebar"
        Me.meSidebar.Size = New System.Drawing.Size(200, 540)
        Me.meSidebar.TabIndex = 5
        '
        'meFooter
        '
        Me.meFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meFooter.Location = New System.Drawing.Point(0, 570)
        Me.meFooter.Name = "meFooter"
        Me.meFooter.Size = New System.Drawing.Size(800, 30)
        Me.meFooter.TabIndex = 3
        '
        'meHeader
        '
        Me.meHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meHeader.Controls.Add(Me.meText)
        Me.meHeader.Location = New System.Drawing.Point(0, 0)
        Me.meHeader.Name = "meHeader"
        Me.meHeader.Size = New System.Drawing.Size(800, 30)
        Me.meHeader.TabIndex = 2
        '
        'meText
        '
        Me.meText.Location = New System.Drawing.Point(0, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(500, 30)
        Me.meText.TabIndex = 1
        Me.meText.Text = "meText"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meBody
        '
        Me.meBody.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesWhite
        Me.meBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.meBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meBody.Controls.Add(Me.meSubInfo)
        Me.meBody.Controls.Add(Me.Button1)
        Me.meBody.Controls.Add(Me.meInfo)
        Me.meBody.Location = New System.Drawing.Point(0, 30)
        Me.meBody.Name = "meBody"
        Me.meBody.Size = New System.Drawing.Size(800, 540)
        Me.meBody.TabIndex = 4
        '
        'meSubInfo
        '
        Me.meSubInfo.BackColor = System.Drawing.Color.Transparent
        Me.meSubInfo.Font = New System.Drawing.Font("Chakra Petch", 18.0!, System.Drawing.FontStyle.Bold)
        Me.meSubInfo.ForeColor = System.Drawing.Color.Black
        Me.meSubInfo.Location = New System.Drawing.Point(194, 189)
        Me.meSubInfo.Name = "meSubInfo"
        Me.meSubInfo.Size = New System.Drawing.Size(408, 60)
        Me.meSubInfo.TabIndex = 16
        Me.meSubInfo.Text = "meSubInfo"
        Me.meSubInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'meInfo
        '
        Me.meInfo.BackColor = System.Drawing.Color.Transparent
        Me.meInfo.Font = New System.Drawing.Font("Chakra Petch", 28.0!, System.Drawing.FontStyle.Bold)
        Me.meInfo.ForeColor = System.Drawing.Color.Black
        Me.meInfo.Location = New System.Drawing.Point(146, 135)
        Me.meInfo.Name = "meInfo"
        Me.meInfo.Size = New System.Drawing.Size(503, 270)
        Me.meInfo.TabIndex = 9
        Me.meInfo.Text = "meInfo"
        Me.meInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.BMenu
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Transformers Movie", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(680, 220)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 100)
        Me.Button1.TabIndex = 11
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IMKModul1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.meBody)
        Me.Controls.Add(Me.meFooter)
        Me.Controls.Add(Me.meHeader)
        Me.Controls.Add(Me.meSidebar)
        Me.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "IMKModul1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modul1"
        Me.meSidebar.ResumeLayout(False)
        Me.meHeader.ResumeLayout(False)
        Me.meBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents meSidebar As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents meInfo As System.Windows.Forms.Label
    Friend WithEvents meSubInfo As System.Windows.Forms.Label
    Friend WithEvents meBody As System.Windows.Forms.Panel
    Friend WithEvents meFooter As System.Windows.Forms.Panel
    Friend WithEvents meHeader As System.Windows.Forms.Panel
    Friend WithEvents meText As System.Windows.Forms.Label
End Class
