<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetirementForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BarChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RecalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.YearlyListView = New System.Windows.Forms.ListView()
        Me.YearColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalContribution = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IntrestEarned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotIntrestEarnedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalSavedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BarChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 200)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BarChart)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.YearlyListView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1374, 1004)
        Me.SplitContainer1.SplitterDistance = 519
        Me.SplitContainer1.TabIndex = 0
        '
        'BarChart
        '
        Me.BarChart.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.Name = "ChartArea1"
        Me.BarChart.ChartAreas.Add(ChartArea1)
        Me.BarChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.BarChart.Legends.Add(Legend1)
        Me.BarChart.Location = New System.Drawing.Point(0, 0)
        Me.BarChart.Name = "BarChart"
        Me.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Balance"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "Contributed"
        Me.BarChart.Series.Add(Series1)
        Me.BarChart.Series.Add(Series2)
        Me.BarChart.Size = New System.Drawing.Size(1374, 519)
        Me.BarChart.TabIndex = 0
        Me.BarChart.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RecalculateButton)
        Me.Panel1.Controls.Add(Me.ExitButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 66)
        Me.Panel1.TabIndex = 3
        '
        'RecalculateButton
        '
        Me.RecalculateButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.RecalculateButton.Location = New System.Drawing.Point(1120, 0)
        Me.RecalculateButton.Name = "RecalculateButton"
        Me.RecalculateButton.Size = New System.Drawing.Size(163, 66)
        Me.RecalculateButton.TabIndex = 1
        Me.RecalculateButton.Text = "Recalculate"
        Me.RecalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.Location = New System.Drawing.Point(1283, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(91, 66)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'YearlyListView
        '
        Me.YearlyListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.YearColumn, Me.TotalContribution, Me.IntrestEarned, Me.TotIntrestEarnedColumn, Me.TotalSavedColumn})
        Me.YearlyListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YearlyListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearlyListView.GridLines = True
        Me.YearlyListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.YearlyListView.Location = New System.Drawing.Point(0, 0)
        Me.YearlyListView.Margin = New System.Windows.Forms.Padding(3, 3, 3, 100)
        Me.YearlyListView.Name = "YearlyListView"
        Me.YearlyListView.Size = New System.Drawing.Size(1374, 481)
        Me.YearlyListView.TabIndex = 0
        Me.YearlyListView.UseCompatibleStateImageBehavior = False
        Me.YearlyListView.View = System.Windows.Forms.View.Details
        '
        'YearColumn
        '
        Me.YearColumn.Text = "Year"
        Me.YearColumn.Width = 75
        '
        'TotalContribution
        '
        Me.TotalContribution.Text = "Total Contributed"
        Me.TotalContribution.Width = 200
        '
        'IntrestEarned
        '
        Me.IntrestEarned.Text = "Interest Earned"
        Me.IntrestEarned.Width = 212
        '
        'TotIntrestEarnedColumn
        '
        Me.TotIntrestEarnedColumn.Text = "Total Earned Interest"
        Me.TotIntrestEarnedColumn.Width = 272
        '
        'TotalSavedColumn
        '
        Me.TotalSavedColumn.Text = "Total Saved"
        Me.TotalSavedColumn.Width = 224
        '
        'RetirementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1374, 1004)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "RetirementForm"
        Me.Text = "Retirement Results"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BarChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BarChart As DataVisualization.Charting.Chart
    Friend WithEvents YearlyListView As ListView
    Friend WithEvents ExitButton As Button
    Friend WithEvents RecalculateButton As Button
    Friend WithEvents YearColumn As ColumnHeader
    Friend WithEvents TotIntrestEarnedColumn As ColumnHeader
    Friend WithEvents TotalSavedColumn As ColumnHeader
    Friend WithEvents TotalContribution As ColumnHeader
    Friend WithEvents IntrestEarned As ColumnHeader
    Friend WithEvents Panel1 As Panel
End Class
