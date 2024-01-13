<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMKModul4
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.meSidebar = New System.Windows.Forms.Panel()
        Me.TTimers = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.meFooter = New System.Windows.Forms.Panel()
        Me.meHeader = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.meBody = New System.Windows.Forms.Panel()
        Me.meGraphic = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GraphicC1 = New System.Windows.Forms.Button()
        Me.GraphicC3 = New System.Windows.Forms.Button()
        Me.GraphicC2 = New System.Windows.Forms.Button()
        Me.GameObject = New System.Windows.Forms.Button()
        Me.TCounts = New System.Windows.Forms.Timer(Me.components)
        Me.TCounters = New System.Windows.Forms.Timer(Me.components)
        Me.meSidebar.SuspendLayout()
        Me.meHeader.SuspendLayout()
        Me.meBody.SuspendLayout()
        Me.meGraphic.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'meSidebar
        '
        Me.meSidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meSidebar.Controls.Add(Me.TTimers)
        Me.meSidebar.Controls.Add(Me.Button0)
        Me.meSidebar.Controls.Add(Me.Button4)
        Me.meSidebar.Controls.Add(Me.Button2)
        Me.meSidebar.Controls.Add(Me.Button3)
        Me.meSidebar.Location = New System.Drawing.Point(800, 0)
        Me.meSidebar.Name = "meSidebar"
        Me.meSidebar.Size = New System.Drawing.Size(200, 600)
        Me.meSidebar.TabIndex = 9
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
        'meFooter
        '
        Me.meFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meFooter.Location = New System.Drawing.Point(0, 570)
        Me.meFooter.Name = "meFooter"
        Me.meFooter.Size = New System.Drawing.Size(800, 30)
        Me.meFooter.TabIndex = 7
        '
        'meHeader
        '
        Me.meHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meHeader.Controls.Add(Me.meText)
        Me.meHeader.Location = New System.Drawing.Point(0, 0)
        Me.meHeader.Name = "meHeader"
        Me.meHeader.Size = New System.Drawing.Size(800, 30)
        Me.meHeader.TabIndex = 6
        '
        'meText
        '
        Me.meText.Location = New System.Drawing.Point(0, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(500, 30)
        Me.meText.TabIndex = 1
        Me.meText.Text = "meText"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.meText.UseCompatibleTextRendering = True
        '
        'meBody
        '
        Me.meBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.meBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.meBody.Controls.Add(Me.meGraphic)
        Me.meBody.Controls.Add(Me.GameObject)
        Me.meBody.Location = New System.Drawing.Point(1, 30)
        Me.meBody.Name = "meBody"
        Me.meBody.Size = New System.Drawing.Size(800, 540)
        Me.meBody.TabIndex = 8
        '
        'meGraphic
        '
        Me.meGraphic.Controls.Add(Me.Chart1)
        Me.meGraphic.Controls.Add(Me.GraphicC1)
        Me.meGraphic.Controls.Add(Me.GraphicC3)
        Me.meGraphic.Controls.Add(Me.GraphicC2)
        Me.meGraphic.Location = New System.Drawing.Point(0, 0)
        Me.meGraphic.Name = "meGraphic"
        Me.meGraphic.Size = New System.Drawing.Size(796, 540)
        Me.meGraphic.TabIndex = 28
        Me.meGraphic.Visible = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.RosyBrown
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.RoyalBlue
        Me.Chart1.BorderlineColor = System.Drawing.Color.Empty
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Location = New System.Drawing.Point(363, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Lime, System.Drawing.Color.Red}
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Font = New System.Drawing.Font("Chakra Petch", 8.0!)
        Series4.Legend = "Legend1"
        Series4.Name = "Distance"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Times"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Diameter"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(433, 536)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title3.Font = New System.Drawing.Font("Chakra Petch", 14.0!)
        Title3.ForeColor = System.Drawing.Color.White
        Title3.Name = "Title1"
        Title3.Position.Auto = False
        Title3.Position.Height = 94.0!
        Title3.Position.Width = 6.157406!
        Title3.Position.X = 1.0!
        Title3.Position.Y = 3.0!
        Title3.Text = "R a n g e"
        Title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title4.Font = New System.Drawing.Font("Chakra Petch", 14.0!)
        Title4.ForeColor = System.Drawing.Color.White
        Title4.Name = "Title2"
        Title4.Position.Auto = False
        Title4.Position.Width = 84.84259!
        Title4.Position.X = 12.0!
        Title4.Position.Y = 97.0!
        Title4.Text = "C i r c l e"
        Me.Chart1.Titles.Add(Title3)
        Me.Chart1.Titles.Add(Title4)
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
        Me.GraphicC1.Text = "Distance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.GraphicC3.ForeColor = System.Drawing.Color.Red
        Me.GraphicC3.Location = New System.Drawing.Point(243, 1)
        Me.GraphicC3.Margin = New System.Windows.Forms.Padding(0)
        Me.GraphicC3.Name = "GraphicC3"
        Me.GraphicC3.Size = New System.Drawing.Size(120, 536)
        Me.GraphicC3.TabIndex = 27
        Me.GraphicC3.Text = "Diameter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.GraphicC2.ForeColor = System.Drawing.Color.Lime
        Me.GraphicC2.Location = New System.Drawing.Point(122, 1)
        Me.GraphicC2.Margin = New System.Windows.Forms.Padding(0)
        Me.GraphicC2.Name = "GraphicC2"
        Me.GraphicC2.Size = New System.Drawing.Size(120, 536)
        Me.GraphicC2.TabIndex = 26
        Me.GraphicC2.Text = "Time" & Global.Microsoft.VisualBasic.ChrW(13) & "(s)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GraphicC2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GraphicC2.UseCompatibleTextRendering = True
        Me.GraphicC2.UseVisualStyleBackColor = False
        '
        'GameObject
        '
        Me.GameObject.BackColor = System.Drawing.Color.Transparent
        Me.GameObject.BackgroundImage = Global.PratikumIMKv2.My.Resources.Resources.CirclesRed
        Me.GameObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameObject.Enabled = False
        Me.GameObject.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.GameObject.FlatAppearance.BorderSize = 0
        Me.GameObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.GameObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.GameObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameObject.Font = New System.Drawing.Font("Chakra Petch", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GameObject.ForeColor = System.Drawing.Color.Gray
        Me.GameObject.Location = New System.Drawing.Point(350, 220)
        Me.GameObject.Margin = New System.Windows.Forms.Padding(0)
        Me.GameObject.Name = "GameObject"
        Me.GameObject.Size = New System.Drawing.Size(100, 100)
        Me.GameObject.TabIndex = 0
        Me.GameObject.TabStop = False
        Me.GameObject.UseCompatibleTextRendering = True
        Me.GameObject.UseVisualStyleBackColor = False
        '
        'TCounts
        '
        Me.TCounts.Interval = 1000
        '
        'TCounters
        '
        Me.TCounters.Interval = 1
        '
        'IMKModul4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.meFooter)
        Me.Controls.Add(Me.meHeader)
        Me.Controls.Add(Me.meBody)
        Me.Controls.Add(Me.meSidebar)
        Me.Font = New System.Drawing.Font("Chakra Petch", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "IMKModul4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interaksi Manusia dan Komputer | Fitt's Law"
        Me.meSidebar.ResumeLayout(False)
        Me.meHeader.ResumeLayout(False)
        Me.meBody.ResumeLayout(False)
        Me.meGraphic.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents meSidebar As System.Windows.Forms.Panel
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents meFooter As System.Windows.Forms.Panel
    Friend WithEvents meHeader As System.Windows.Forms.Panel
    Friend WithEvents meText As System.Windows.Forms.Label
    Friend WithEvents meBody As System.Windows.Forms.Panel
    Friend WithEvents GameObject As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TCounts As System.Windows.Forms.Timer
    Friend WithEvents TTimers As System.Windows.Forms.Button
    Friend WithEvents GraphicC1 As System.Windows.Forms.Button
    Friend WithEvents GraphicC3 As System.Windows.Forms.Button
    Friend WithEvents GraphicC2 As System.Windows.Forms.Button
    Friend WithEvents meGraphic As System.Windows.Forms.Panel
    Friend WithEvents TCounters As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
