<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMKModul5
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.GameObject0 = New System.Windows.Forms.Button()
        Me.TCounts = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GraphicC1 = New System.Windows.Forms.Button()
        Me.GraphicC3 = New System.Windows.Forms.Button()
        Me.GraphicC2 = New System.Windows.Forms.Button()
        Me.meGraphic = New System.Windows.Forms.Panel()
        Me.meFooter = New System.Windows.Forms.Panel()
        Me.meHeader = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.meBody = New System.Windows.Forms.Panel()
        Me.GameObject23 = New System.Windows.Forms.Button()
        Me.GameObject16 = New System.Windows.Forms.Button()
        Me.GameObject19 = New System.Windows.Forms.Button()
        Me.GameObject22 = New System.Windows.Forms.Button()
        Me.GameObject20 = New System.Windows.Forms.Button()
        Me.GameObject17 = New System.Windows.Forms.Button()
        Me.GameObject18 = New System.Windows.Forms.Button()
        Me.GameObject21 = New System.Windows.Forms.Button()
        Me.GameObject15 = New System.Windows.Forms.Button()
        Me.GameObject14 = New System.Windows.Forms.Button()
        Me.GameObject13 = New System.Windows.Forms.Button()
        Me.GameObject12 = New System.Windows.Forms.Button()
        Me.GameObject9 = New System.Windows.Forms.Button()
        Me.GameObject10 = New System.Windows.Forms.Button()
        Me.GameObject11 = New System.Windows.Forms.Button()
        Me.GameObject8 = New System.Windows.Forms.Button()
        Me.GameObject7 = New System.Windows.Forms.Button()
        Me.GameObject4 = New System.Windows.Forms.Button()
        Me.GameObject5 = New System.Windows.Forms.Button()
        Me.GameObject6 = New System.Windows.Forms.Button()
        Me.GameObject3 = New System.Windows.Forms.Button()
        Me.GameObject2 = New System.Windows.Forms.Button()
        Me.GameObject1 = New System.Windows.Forms.Button()
        Me.TTimers = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.meSidebar = New System.Windows.Forms.Panel()
        Me.iObjects = New System.Windows.Forms.Button()
        Me.iNotif = New System.Windows.Forms.Label()
        Me.TCounters = New System.Windows.Forms.Timer(Me.components)
        Me.TNotif = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.meGraphic.SuspendLayout()
        Me.meHeader.SuspendLayout()
        Me.meBody.SuspendLayout()
        Me.meSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameObject0
        '
        Me.GameObject0.BackColor = System.Drawing.Color.Transparent
        Me.GameObject0.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject0.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject0.FlatAppearance.BorderSize = 0
        Me.GameObject0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject0.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject0.ForeColor = System.Drawing.Color.Gray
        Me.GameObject0.Location = New System.Drawing.Point(0, 0)
        Me.GameObject0.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject0.Name = "GameObject0"
        Me.GameObject0.Size = New System.Drawing.Size(100, 100)
        Me.GameObject0.TabIndex = 0
        Me.GameObject0.TabStop = False
        Me.GameObject0.UseCompatibleTextRendering = True
        Me.GameObject0.UseVisualStyleBackColor = False
        Me.GameObject0.Visible = False
        '
        'TCounts
        '
        Me.TCounts.Interval = 1000
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.RosyBrown
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.RoyalBlue
        Me.Chart1.BorderlineColor = System.Drawing.Color.Empty
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(363, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Lime}
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Font = New System.Drawing.Font("Chakra Petch", 8.0!)
        Series1.Legend = "Legend1"
        Series1.Name = "Actions"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Name = "Times"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(433, 536)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title1.Font = New System.Drawing.Font("Chakra Petch", 14.0!)
        Title1.ForeColor = System.Drawing.Color.White
        Title1.Name = "Title1"
        Title1.Position.Auto = False
        Title1.Position.Height = 94.0!
        Title1.Position.Width = 6.157406!
        Title1.Position.X = 1.0!
        Title1.Position.Y = 3.0!
        Title1.Text = "R a n g e"
        Title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        Title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title2.Font = New System.Drawing.Font("Chakra Petch", 14.0!)
        Title2.ForeColor = System.Drawing.Color.White
        Title2.Name = "Title2"
        Title2.Position.Auto = False
        Title2.Position.Width = 84.84259!
        Title2.Position.X = 12.0!
        Title2.Position.Y = 97.0!
        Title2.Text = "I n s t r u c t i o n s"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.Titles.Add(Title2)
        '
        'GraphicC1
        '
        Me.GraphicC1.BackColor = System.Drawing.Color.Transparent
        Me.GraphicC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GraphicC1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GraphicC1.FlatAppearance.BorderSize = 2
        Me.GraphicC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GraphicC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GraphicC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GraphicC1.Font = New System.Drawing.Font("Chakra Petch", 13.2!, System.Drawing.FontStyle.Bold)
        Me.GraphicC1.ForeColor = System.Drawing.Color.White
        Me.GraphicC1.Location = New System.Drawing.Point(1, 1)
        Me.GraphicC1.Margin = New System.Windows.Forms.Padding(0)
        Me.GraphicC1.Name = "GraphicC1"
        Me.GraphicC1.Size = New System.Drawing.Size(120, 536)
        Me.GraphicC1.TabIndex = 25
        Me.GraphicC1.Text = "Actions"
        Me.GraphicC1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GraphicC1.UseCompatibleTextRendering = True
        Me.GraphicC1.UseVisualStyleBackColor = False
        '
        'GraphicC3
        '
        Me.GraphicC3.BackColor = System.Drawing.Color.Transparent
        Me.GraphicC3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GraphicC3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GraphicC3.FlatAppearance.BorderSize = 2
        Me.GraphicC3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GraphicC3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GraphicC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GraphicC3.Font = New System.Drawing.Font("Chakra Petch", 13.2!, System.Drawing.FontStyle.Bold)
        Me.GraphicC3.ForeColor = System.Drawing.Color.Lime
        Me.GraphicC3.Location = New System.Drawing.Point(243, 1)
        Me.GraphicC3.Margin = New System.Windows.Forms.Padding(0)
        Me.GraphicC3.Name = "GraphicC3"
        Me.GraphicC3.Size = New System.Drawing.Size(120, 536)
        Me.GraphicC3.TabIndex = 27
        Me.GraphicC3.Text = "Time(s)"
        Me.GraphicC3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GraphicC3.UseCompatibleTextRendering = True
        Me.GraphicC3.UseVisualStyleBackColor = False
        '
        'GraphicC2
        '
        Me.GraphicC2.BackColor = System.Drawing.Color.Transparent
        Me.GraphicC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GraphicC2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GraphicC2.FlatAppearance.BorderSize = 2
        Me.GraphicC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GraphicC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GraphicC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GraphicC2.Font = New System.Drawing.Font("Chakra Petch", 13.2!, System.Drawing.FontStyle.Bold)
        Me.GraphicC2.ForeColor = System.Drawing.Color.Red
        Me.GraphicC2.Location = New System.Drawing.Point(122, 1)
        Me.GraphicC2.Margin = New System.Windows.Forms.Padding(0)
        Me.GraphicC2.Name = "GraphicC2"
        Me.GraphicC2.Size = New System.Drawing.Size(120, 536)
        Me.GraphicC2.TabIndex = 26
        Me.GraphicC2.Text = "Wrong" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GraphicC2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GraphicC2.UseCompatibleTextRendering = True
        Me.GraphicC2.UseVisualStyleBackColor = False
        '
        'meGraphic
        '
        Me.meGraphic.Controls.Add(Me.Chart1)
        Me.meGraphic.Controls.Add(Me.GraphicC1)
        Me.meGraphic.Controls.Add(Me.GraphicC3)
        Me.meGraphic.Controls.Add(Me.GraphicC2)
        Me.meGraphic.Location = New System.Drawing.Point(0, 30)
        Me.meGraphic.Name = "meGraphic"
        Me.meGraphic.Size = New System.Drawing.Size(800, 540)
        Me.meGraphic.TabIndex = 28
        Me.meGraphic.Visible = False
        '
        'meFooter
        '
        Me.meFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meFooter.Location = New System.Drawing.Point(0, 570)
        Me.meFooter.Name = "meFooter"
        Me.meFooter.Size = New System.Drawing.Size(800, 30)
        Me.meFooter.TabIndex = 11
        '
        'meHeader
        '
        Me.meHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meHeader.Controls.Add(Me.meText)
        Me.meHeader.Location = New System.Drawing.Point(0, 0)
        Me.meHeader.Name = "meHeader"
        Me.meHeader.Size = New System.Drawing.Size(800, 30)
        Me.meHeader.TabIndex = 10
        '
        'meText
        '
        Me.meText.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.meText.Location = New System.Drawing.Point(2, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(796, 26)
        Me.meText.TabIndex = 1
        Me.meText.Text = "meText"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.meText.UseCompatibleTextRendering = True
        '
        'meBody
        '
        Me.meBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.meBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meBody.Controls.Add(Me.GameObject23)
        Me.meBody.Controls.Add(Me.GameObject16)
        Me.meBody.Controls.Add(Me.GameObject19)
        Me.meBody.Controls.Add(Me.GameObject22)
        Me.meBody.Controls.Add(Me.GameObject20)
        Me.meBody.Controls.Add(Me.GameObject17)
        Me.meBody.Controls.Add(Me.GameObject18)
        Me.meBody.Controls.Add(Me.GameObject21)
        Me.meBody.Controls.Add(Me.GameObject15)
        Me.meBody.Controls.Add(Me.GameObject14)
        Me.meBody.Controls.Add(Me.GameObject13)
        Me.meBody.Controls.Add(Me.GameObject12)
        Me.meBody.Controls.Add(Me.GameObject9)
        Me.meBody.Controls.Add(Me.GameObject10)
        Me.meBody.Controls.Add(Me.GameObject11)
        Me.meBody.Controls.Add(Me.GameObject8)
        Me.meBody.Controls.Add(Me.GameObject7)
        Me.meBody.Controls.Add(Me.GameObject4)
        Me.meBody.Controls.Add(Me.GameObject5)
        Me.meBody.Controls.Add(Me.GameObject6)
        Me.meBody.Controls.Add(Me.GameObject3)
        Me.meBody.Controls.Add(Me.GameObject2)
        Me.meBody.Controls.Add(Me.GameObject1)
        Me.meBody.Controls.Add(Me.GameObject0)
        Me.meBody.Enabled = False
        Me.meBody.Location = New System.Drawing.Point(0, 30)
        Me.meBody.Name = "meBody"
        Me.meBody.Size = New System.Drawing.Size(800, 540)
        Me.meBody.TabIndex = 12
        '
        'GameObject23
        '
        Me.GameObject23.BackColor = System.Drawing.Color.Transparent
        Me.GameObject23.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject23.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject23.FlatAppearance.BorderSize = 0
        Me.GameObject23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject23.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject23.ForeColor = System.Drawing.Color.Gray
        Me.GameObject23.Location = New System.Drawing.Point(659, 390)
        Me.GameObject23.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject23.Name = "GameObject23"
        Me.GameObject23.Size = New System.Drawing.Size(80, 80)
        Me.GameObject23.TabIndex = 51
        Me.GameObject23.TabStop = False
        Me.GameObject23.UseCompatibleTextRendering = True
        Me.GameObject23.UseVisualStyleBackColor = False
        Me.GameObject23.Visible = False
        '
        'GameObject16
        '
        Me.GameObject16.BackColor = System.Drawing.Color.Transparent
        Me.GameObject16.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject16.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject16.FlatAppearance.BorderSize = 0
        Me.GameObject16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject16.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject16.ForeColor = System.Drawing.Color.Gray
        Me.GameObject16.Location = New System.Drawing.Point(738, 245)
        Me.GameObject16.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject16.Name = "GameObject16"
        Me.GameObject16.Size = New System.Drawing.Size(40, 40)
        Me.GameObject16.TabIndex = 50
        Me.GameObject16.TabStop = False
        Me.GameObject16.UseCompatibleTextRendering = True
        Me.GameObject16.UseVisualStyleBackColor = False
        Me.GameObject16.Visible = False
        '
        'GameObject19
        '
        Me.GameObject19.BackColor = System.Drawing.Color.Transparent
        Me.GameObject19.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject19.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject19.FlatAppearance.BorderSize = 0
        Me.GameObject19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject19.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject19.ForeColor = System.Drawing.Color.Gray
        Me.GameObject19.Location = New System.Drawing.Point(310, 475)
        Me.GameObject19.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject19.Name = "GameObject19"
        Me.GameObject19.Size = New System.Drawing.Size(60, 60)
        Me.GameObject19.TabIndex = 49
        Me.GameObject19.TabStop = False
        Me.GameObject19.UseCompatibleTextRendering = True
        Me.GameObject19.UseVisualStyleBackColor = False
        Me.GameObject19.Visible = False
        '
        'GameObject22
        '
        Me.GameObject22.BackColor = System.Drawing.Color.Transparent
        Me.GameObject22.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject22.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject22.FlatAppearance.BorderSize = 0
        Me.GameObject22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject22.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject22.ForeColor = System.Drawing.Color.Gray
        Me.GameObject22.Location = New System.Drawing.Point(620, 457)
        Me.GameObject22.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject22.Name = "GameObject22"
        Me.GameObject22.Size = New System.Drawing.Size(40, 40)
        Me.GameObject22.TabIndex = 48
        Me.GameObject22.TabStop = False
        Me.GameObject22.UseCompatibleTextRendering = True
        Me.GameObject22.UseVisualStyleBackColor = False
        Me.GameObject22.Visible = False
        '
        'GameObject20
        '
        Me.GameObject20.BackColor = System.Drawing.Color.Transparent
        Me.GameObject20.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject20.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject20.FlatAppearance.BorderSize = 0
        Me.GameObject20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject20.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject20.ForeColor = System.Drawing.Color.Gray
        Me.GameObject20.Location = New System.Drawing.Point(467, 457)
        Me.GameObject20.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject20.Name = "GameObject20"
        Me.GameObject20.Size = New System.Drawing.Size(60, 60)
        Me.GameObject20.TabIndex = 47
        Me.GameObject20.TabStop = False
        Me.GameObject20.UseCompatibleTextRendering = True
        Me.GameObject20.UseVisualStyleBackColor = False
        Me.GameObject20.Visible = False
        '
        'GameObject17
        '
        Me.GameObject17.BackColor = System.Drawing.Color.Transparent
        Me.GameObject17.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject17.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject17.FlatAppearance.BorderSize = 0
        Me.GameObject17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject17.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject17.ForeColor = System.Drawing.Color.Gray
        Me.GameObject17.Location = New System.Drawing.Point(510, 255)
        Me.GameObject17.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject17.Name = "GameObject17"
        Me.GameObject17.Size = New System.Drawing.Size(100, 100)
        Me.GameObject17.TabIndex = 46
        Me.GameObject17.TabStop = False
        Me.GameObject17.UseCompatibleTextRendering = True
        Me.GameObject17.UseVisualStyleBackColor = False
        Me.GameObject17.Visible = False
        '
        'GameObject18
        '
        Me.GameObject18.BackColor = System.Drawing.Color.Transparent
        Me.GameObject18.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject18.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject18.FlatAppearance.BorderSize = 0
        Me.GameObject18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject18.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject18.ForeColor = System.Drawing.Color.Gray
        Me.GameObject18.Location = New System.Drawing.Point(370, 350)
        Me.GameObject18.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject18.Name = "GameObject18"
        Me.GameObject18.Size = New System.Drawing.Size(100, 100)
        Me.GameObject18.TabIndex = 45
        Me.GameObject18.TabStop = False
        Me.GameObject18.UseCompatibleTextRendering = True
        Me.GameObject18.UseVisualStyleBackColor = False
        Me.GameObject18.Visible = False
        '
        'GameObject21
        '
        Me.GameObject21.BackColor = System.Drawing.Color.Transparent
        Me.GameObject21.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject21.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject21.FlatAppearance.BorderSize = 0
        Me.GameObject21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject21.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject21.ForeColor = System.Drawing.Color.Gray
        Me.GameObject21.Location = New System.Drawing.Point(530, 370)
        Me.GameObject21.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject21.Name = "GameObject21"
        Me.GameObject21.Size = New System.Drawing.Size(80, 80)
        Me.GameObject21.TabIndex = 44
        Me.GameObject21.TabStop = False
        Me.GameObject21.UseCompatibleTextRendering = True
        Me.GameObject21.UseVisualStyleBackColor = False
        Me.GameObject21.Visible = False
        '
        'GameObject15
        '
        Me.GameObject15.BackColor = System.Drawing.Color.Transparent
        Me.GameObject15.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject15.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject15.FlatAppearance.BorderSize = 0
        Me.GameObject15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject15.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject15.ForeColor = System.Drawing.Color.Gray
        Me.GameObject15.Location = New System.Drawing.Point(510, 185)
        Me.GameObject15.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject15.Name = "GameObject15"
        Me.GameObject15.Size = New System.Drawing.Size(40, 40)
        Me.GameObject15.TabIndex = 43
        Me.GameObject15.TabStop = False
        Me.GameObject15.UseCompatibleTextRendering = True
        Me.GameObject15.UseVisualStyleBackColor = False
        Me.GameObject15.Visible = False
        '
        'GameObject14
        '
        Me.GameObject14.BackColor = System.Drawing.Color.Transparent
        Me.GameObject14.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject14.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject14.FlatAppearance.BorderSize = 0
        Me.GameObject14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject14.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject14.ForeColor = System.Drawing.Color.Gray
        Me.GameObject14.Location = New System.Drawing.Point(410, 255)
        Me.GameObject14.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject14.Name = "GameObject14"
        Me.GameObject14.Size = New System.Drawing.Size(60, 60)
        Me.GameObject14.TabIndex = 42
        Me.GameObject14.TabStop = False
        Me.GameObject14.UseCompatibleTextRendering = True
        Me.GameObject14.UseVisualStyleBackColor = False
        Me.GameObject14.Visible = False
        '
        'GameObject13
        '
        Me.GameObject13.BackColor = System.Drawing.Color.Transparent
        Me.GameObject13.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject13.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject13.FlatAppearance.BorderSize = 0
        Me.GameObject13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject13.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject13.ForeColor = System.Drawing.Color.Gray
        Me.GameObject13.Location = New System.Drawing.Point(420, 175)
        Me.GameObject13.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject13.Name = "GameObject13"
        Me.GameObject13.Size = New System.Drawing.Size(80, 80)
        Me.GameObject13.TabIndex = 41
        Me.GameObject13.TabStop = False
        Me.GameObject13.UseCompatibleTextRendering = True
        Me.GameObject13.UseVisualStyleBackColor = False
        Me.GameObject13.Visible = False
        '
        'GameObject12
        '
        Me.GameObject12.BackColor = System.Drawing.Color.Transparent
        Me.GameObject12.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject12.FlatAppearance.BorderSize = 0
        Me.GameObject12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject12.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject12.ForeColor = System.Drawing.Color.Gray
        Me.GameObject12.Location = New System.Drawing.Point(310, 175)
        Me.GameObject12.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject12.Name = "GameObject12"
        Me.GameObject12.Size = New System.Drawing.Size(100, 100)
        Me.GameObject12.TabIndex = 40
        Me.GameObject12.TabStop = False
        Me.GameObject12.UseCompatibleTextRendering = True
        Me.GameObject12.UseVisualStyleBackColor = False
        Me.GameObject12.Visible = False
        '
        'GameObject9
        '
        Me.GameObject9.BackColor = System.Drawing.Color.Transparent
        Me.GameObject9.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject9.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject9.FlatAppearance.BorderSize = 0
        Me.GameObject9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject9.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject9.ForeColor = System.Drawing.Color.Gray
        Me.GameObject9.Location = New System.Drawing.Point(420, 90)
        Me.GameObject9.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject9.Name = "GameObject9"
        Me.GameObject9.Size = New System.Drawing.Size(80, 80)
        Me.GameObject9.TabIndex = 39
        Me.GameObject9.TabStop = False
        Me.GameObject9.UseCompatibleTextRendering = True
        Me.GameObject9.UseVisualStyleBackColor = False
        Me.GameObject9.Visible = False
        '
        'GameObject10
        '
        Me.GameObject10.BackColor = System.Drawing.Color.Transparent
        Me.GameObject10.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject10.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject10.FlatAppearance.BorderSize = 0
        Me.GameObject10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject10.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject10.ForeColor = System.Drawing.Color.Gray
        Me.GameObject10.Location = New System.Drawing.Point(578, 130)
        Me.GameObject10.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject10.Name = "GameObject10"
        Me.GameObject10.Size = New System.Drawing.Size(40, 40)
        Me.GameObject10.TabIndex = 38
        Me.GameObject10.TabStop = False
        Me.GameObject10.UseCompatibleTextRendering = True
        Me.GameObject10.UseVisualStyleBackColor = False
        Me.GameObject10.Visible = False
        '
        'GameObject11
        '
        Me.GameObject11.BackColor = System.Drawing.Color.Transparent
        Me.GameObject11.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject11.FlatAppearance.BorderSize = 0
        Me.GameObject11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject11.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject11.ForeColor = System.Drawing.Color.Gray
        Me.GameObject11.Location = New System.Drawing.Point(60, 360)
        Me.GameObject11.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject11.Name = "GameObject11"
        Me.GameObject11.Size = New System.Drawing.Size(60, 60)
        Me.GameObject11.TabIndex = 37
        Me.GameObject11.TabStop = False
        Me.GameObject11.UseCompatibleTextRendering = True
        Me.GameObject11.UseVisualStyleBackColor = False
        Me.GameObject11.Visible = False
        '
        'GameObject8
        '
        Me.GameObject8.BackColor = System.Drawing.Color.Transparent
        Me.GameObject8.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject8.FlatAppearance.BorderSize = 0
        Me.GameObject8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject8.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject8.ForeColor = System.Drawing.Color.Gray
        Me.GameObject8.Location = New System.Drawing.Point(310, 282)
        Me.GameObject8.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject8.Name = "GameObject8"
        Me.GameObject8.Size = New System.Drawing.Size(40, 40)
        Me.GameObject8.TabIndex = 36
        Me.GameObject8.TabStop = False
        Me.GameObject8.UseCompatibleTextRendering = True
        Me.GameObject8.UseVisualStyleBackColor = False
        Me.GameObject8.Visible = False
        '
        'GameObject7
        '
        Me.GameObject7.BackColor = System.Drawing.Color.Transparent
        Me.GameObject7.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject7.FlatAppearance.BorderSize = 0
        Me.GameObject7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject7.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject7.ForeColor = System.Drawing.Color.Gray
        Me.GameObject7.Location = New System.Drawing.Point(157, 282)
        Me.GameObject7.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject7.Name = "GameObject7"
        Me.GameObject7.Size = New System.Drawing.Size(60, 60)
        Me.GameObject7.TabIndex = 35
        Me.GameObject7.TabStop = False
        Me.GameObject7.UseCompatibleTextRendering = True
        Me.GameObject7.UseVisualStyleBackColor = False
        Me.GameObject7.Visible = False
        '
        'GameObject4
        '
        Me.GameObject4.BackColor = System.Drawing.Color.Transparent
        Me.GameObject4.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject4.FlatAppearance.BorderSize = 0
        Me.GameObject4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject4.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject4.ForeColor = System.Drawing.Color.Gray
        Me.GameObject4.Location = New System.Drawing.Point(200, 80)
        Me.GameObject4.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject4.Name = "GameObject4"
        Me.GameObject4.Size = New System.Drawing.Size(100, 100)
        Me.GameObject4.TabIndex = 34
        Me.GameObject4.TabStop = False
        Me.GameObject4.UseCompatibleTextRendering = True
        Me.GameObject4.UseVisualStyleBackColor = False
        Me.GameObject4.Visible = False
        '
        'GameObject5
        '
        Me.GameObject5.BackColor = System.Drawing.Color.Transparent
        Me.GameObject5.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject5.FlatAppearance.BorderSize = 0
        Me.GameObject5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject5.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject5.ForeColor = System.Drawing.Color.Gray
        Me.GameObject5.Location = New System.Drawing.Point(60, 175)
        Me.GameObject5.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject5.Name = "GameObject5"
        Me.GameObject5.Size = New System.Drawing.Size(100, 100)
        Me.GameObject5.TabIndex = 33
        Me.GameObject5.TabStop = False
        Me.GameObject5.UseCompatibleTextRendering = True
        Me.GameObject5.UseVisualStyleBackColor = False
        Me.GameObject5.Visible = False
        '
        'GameObject6
        '
        Me.GameObject6.BackColor = System.Drawing.Color.Transparent
        Me.GameObject6.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject6.FlatAppearance.BorderSize = 0
        Me.GameObject6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject6.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject6.ForeColor = System.Drawing.Color.Gray
        Me.GameObject6.Location = New System.Drawing.Point(220, 195)
        Me.GameObject6.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject6.Name = "GameObject6"
        Me.GameObject6.Size = New System.Drawing.Size(80, 80)
        Me.GameObject6.TabIndex = 32
        Me.GameObject6.TabStop = False
        Me.GameObject6.UseCompatibleTextRendering = True
        Me.GameObject6.UseVisualStyleBackColor = False
        Me.GameObject6.Visible = False
        '
        'GameObject3
        '
        Me.GameObject3.BackColor = System.Drawing.Color.Transparent
        Me.GameObject3.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject3.FlatAppearance.BorderSize = 0
        Me.GameObject3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject3.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject3.ForeColor = System.Drawing.Color.Gray
        Me.GameObject3.Location = New System.Drawing.Point(200, 10)
        Me.GameObject3.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject3.Name = "GameObject3"
        Me.GameObject3.Size = New System.Drawing.Size(40, 40)
        Me.GameObject3.TabIndex = 31
        Me.GameObject3.TabStop = False
        Me.GameObject3.UseCompatibleTextRendering = True
        Me.GameObject3.UseVisualStyleBackColor = False
        Me.GameObject3.Visible = False
        '
        'GameObject2
        '
        Me.GameObject2.BackColor = System.Drawing.Color.Transparent
        Me.GameObject2.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject2.FlatAppearance.BorderSize = 0
        Me.GameObject2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject2.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject2.ForeColor = System.Drawing.Color.Gray
        Me.GameObject2.Location = New System.Drawing.Point(100, 80)
        Me.GameObject2.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject2.Name = "GameObject2"
        Me.GameObject2.Size = New System.Drawing.Size(60, 60)
        Me.GameObject2.TabIndex = 30
        Me.GameObject2.TabStop = False
        Me.GameObject2.UseCompatibleTextRendering = True
        Me.GameObject2.UseVisualStyleBackColor = False
        Me.GameObject2.Visible = False
        '
        'GameObject1
        '
        Me.GameObject1.BackColor = System.Drawing.Color.Transparent
        Me.GameObject1.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject1.FlatAppearance.BorderSize = 0
        Me.GameObject1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject1.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject1.ForeColor = System.Drawing.Color.Gray
        Me.GameObject1.Location = New System.Drawing.Point(110, 0)
        Me.GameObject1.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject1.Name = "GameObject1"
        Me.GameObject1.Size = New System.Drawing.Size(80, 80)
        Me.GameObject1.TabIndex = 29
        Me.GameObject1.TabStop = False
        Me.GameObject1.UseCompatibleTextRendering = True
        Me.GameObject1.UseVisualStyleBackColor = False
        Me.GameObject1.Visible = False
        '
        'TTimers
        '
        Me.TTimers.BackColor = System.Drawing.Color.Transparent
        Me.TTimers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TTimers.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.TTimers.FlatAppearance.BorderSize = 2
        Me.TTimers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.TTimers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.TTimers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TTimers.Font = New System.Drawing.Font("Chakra Petch", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TTimers.ForeColor = System.Drawing.Color.Gray
        Me.TTimers.Location = New System.Drawing.Point(10, 30)
        Me.TTimers.Margin = New System.Windows.Forms.Padding(0)
        Me.TTimers.Name = "TTimers"
        Me.TTimers.Size = New System.Drawing.Size(180, 40)
        Me.TTimers.TabIndex = 0
        Me.TTimers.TabStop = False
        Me.TTimers.Text = "00 : 00"
        Me.TTimers.UseCompatibleTextRendering = True
        Me.TTimers.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.Transparent
        Me.Button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button0.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button0.FlatAppearance.BorderSize = 2
        Me.Button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button0.ForeColor = System.Drawing.Color.Gray
        Me.Button0.Location = New System.Drawing.Point(10, 530)
        Me.Button0.Margin = New System.Windows.Forms.Padding(0)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(180, 40)
        Me.Button0.TabIndex = 24
        Me.Button0.Text = "Exit"
        Me.Button0.UseCompatibleTextRendering = True
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Gray
        Me.Button4.Location = New System.Drawing.Point(10, 480)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 40)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "How to play?"
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(10, 80)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "S T A R T"
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
        Me.Button3.Location = New System.Drawing.Point(10, 130)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Graphic"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'meSidebar
        '
        Me.meSidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meSidebar.Controls.Add(Me.iObjects)
        Me.meSidebar.Controls.Add(Me.iNotif)
        Me.meSidebar.Controls.Add(Me.TTimers)
        Me.meSidebar.Controls.Add(Me.Button0)
        Me.meSidebar.Controls.Add(Me.Button4)
        Me.meSidebar.Controls.Add(Me.Button2)
        Me.meSidebar.Controls.Add(Me.Button3)
        Me.meSidebar.Location = New System.Drawing.Point(800, 0)
        Me.meSidebar.Name = "meSidebar"
        Me.meSidebar.Size = New System.Drawing.Size(200, 600)
        Me.meSidebar.TabIndex = 13
        '
        'iObjects
        '
        Me.iObjects.BackColor = System.Drawing.Color.Transparent
        Me.iObjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.iObjects.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.iObjects.FlatAppearance.BorderSize = 2
        Me.iObjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.iObjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.iObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iObjects.Font = New System.Drawing.Font("Chakra Petch", 18.0!, System.Drawing.FontStyle.Bold)
        Me.iObjects.ForeColor = System.Drawing.Color.Gray
        Me.iObjects.Location = New System.Drawing.Point(9, 321)
        Me.iObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.iObjects.Name = "iObjects"
        Me.iObjects.Size = New System.Drawing.Size(180, 40)
        Me.iObjects.TabIndex = 25
        Me.iObjects.TabStop = False
        Me.iObjects.Text = "0/10"
        Me.iObjects.UseCompatibleTextRendering = True
        Me.iObjects.UseVisualStyleBackColor = False
        '
        'iNotif
        '
        Me.iNotif.Font = New System.Drawing.Font("Chakra Petch", 20.0!, System.Drawing.FontStyle.Bold)
        Me.iNotif.ForeColor = System.Drawing.Color.Orange
        Me.iNotif.Location = New System.Drawing.Point(10, 250)
        Me.iNotif.Name = "iNotif"
        Me.iNotif.Size = New System.Drawing.Size(180, 70)
        Me.iNotif.TabIndex = 2
        Me.iNotif.Text = "W R O N G !!!"
        Me.iNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.iNotif.UseCompatibleTextRendering = True
        Me.iNotif.Visible = False
        '
        'TCounters
        '
        Me.TCounters.Interval = 1
        '
        'TNotif
        '
        Me.TNotif.Interval = 20
        '
        'IMKModul5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.meFooter)
        Me.Controls.Add(Me.meHeader)
        Me.Controls.Add(Me.meSidebar)
        Me.Controls.Add(Me.meBody)
        Me.Controls.Add(Me.meGraphic)
        Me.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "IMKModul5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMKModul5"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.meGraphic.ResumeLayout(False)
        Me.meHeader.ResumeLayout(False)
        Me.meBody.ResumeLayout(False)
        Me.meSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameObject0 As System.Windows.Forms.Button
    Friend WithEvents TCounts As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GraphicC1 As System.Windows.Forms.Button
    Friend WithEvents GraphicC3 As System.Windows.Forms.Button
    Friend WithEvents GraphicC2 As System.Windows.Forms.Button
    Friend WithEvents meGraphic As System.Windows.Forms.Panel
    Friend WithEvents meFooter As System.Windows.Forms.Panel
    Friend WithEvents meHeader As System.Windows.Forms.Panel
    Friend WithEvents meText As System.Windows.Forms.Label
    Friend WithEvents meBody As System.Windows.Forms.Panel
    Friend WithEvents TTimers As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents meSidebar As System.Windows.Forms.Panel
    Friend WithEvents TCounters As System.Windows.Forms.Timer
    Friend WithEvents GameObject1 As System.Windows.Forms.Button
    Friend WithEvents GameObject7 As System.Windows.Forms.Button
    Friend WithEvents GameObject4 As System.Windows.Forms.Button
    Friend WithEvents GameObject5 As System.Windows.Forms.Button
    Friend WithEvents GameObject6 As System.Windows.Forms.Button
    Friend WithEvents GameObject3 As System.Windows.Forms.Button
    Friend WithEvents GameObject2 As System.Windows.Forms.Button
    Friend WithEvents GameObject9 As System.Windows.Forms.Button
    Friend WithEvents GameObject10 As System.Windows.Forms.Button
    Friend WithEvents GameObject11 As System.Windows.Forms.Button
    Friend WithEvents GameObject8 As System.Windows.Forms.Button
    Friend WithEvents GameObject23 As System.Windows.Forms.Button
    Friend WithEvents GameObject16 As System.Windows.Forms.Button
    Friend WithEvents GameObject19 As System.Windows.Forms.Button
    Friend WithEvents GameObject22 As System.Windows.Forms.Button
    Friend WithEvents GameObject20 As System.Windows.Forms.Button
    Friend WithEvents GameObject17 As System.Windows.Forms.Button
    Friend WithEvents GameObject18 As System.Windows.Forms.Button
    Friend WithEvents GameObject21 As System.Windows.Forms.Button
    Friend WithEvents GameObject15 As System.Windows.Forms.Button
    Friend WithEvents GameObject14 As System.Windows.Forms.Button
    Friend WithEvents GameObject13 As System.Windows.Forms.Button
    Friend WithEvents GameObject12 As System.Windows.Forms.Button
    Friend WithEvents iNotif As System.Windows.Forms.Label
    Friend WithEvents TNotif As System.Windows.Forms.Timer
    Friend WithEvents iObjects As System.Windows.Forms.Button
End Class
