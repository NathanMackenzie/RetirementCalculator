<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectForm
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
        Me.TabController = New System.Windows.Forms.TabControl()
        Me.RetirementTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IntrestRate = New System.Windows.Forms.NumericUpDown()
        Me.RetirementYear = New System.Windows.Forms.NumericUpDown()
        Me.YearlyContribution = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RetirementEnterButton = New System.Windows.Forms.Button()
        Me.InflationTab = New System.Windows.Forms.TabPage()
        Me.InflationEnterButton = New System.Windows.Forms.Button()
        Me.InflationYear = New System.Windows.Forms.NumericUpDown()
        Me.InflationRate = New System.Windows.Forms.NumericUpDown()
        Me.Price = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabController.SuspendLayout()
        Me.RetirementTab.SuspendLayout()
        CType(Me.IntrestRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetirementYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearlyContribution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InflationTab.SuspendLayout()
        CType(Me.InflationYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InflationRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Price, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabController
        '
        Me.TabController.Controls.Add(Me.RetirementTab)
        Me.TabController.Controls.Add(Me.InflationTab)
        Me.TabController.Location = New System.Drawing.Point(3, 0)
        Me.TabController.Name = "TabController"
        Me.TabController.SelectedIndex = 0
        Me.TabController.Size = New System.Drawing.Size(472, 554)
        Me.TabController.TabIndex = 0
        '
        'RetirementTab
        '
        Me.RetirementTab.Controls.Add(Me.Label3)
        Me.RetirementTab.Controls.Add(Me.IntrestRate)
        Me.RetirementTab.Controls.Add(Me.RetirementYear)
        Me.RetirementTab.Controls.Add(Me.YearlyContribution)
        Me.RetirementTab.Controls.Add(Me.Label2)
        Me.RetirementTab.Controls.Add(Me.Label1)
        Me.RetirementTab.Controls.Add(Me.RetirementEnterButton)
        Me.RetirementTab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RetirementTab.Location = New System.Drawing.Point(8, 39)
        Me.RetirementTab.Name = "RetirementTab"
        Me.RetirementTab.Padding = New System.Windows.Forms.Padding(3)
        Me.RetirementTab.Size = New System.Drawing.Size(456, 507)
        Me.RetirementTab.TabIndex = 0
        Me.RetirementTab.Text = "Retierment Calc"
        Me.RetirementTab.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Interest Rate (%)"
        '
        'IntrestRate
        '
        Me.IntrestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntrestRate.Location = New System.Drawing.Point(310, 160)
        Me.IntrestRate.Name = "IntrestRate"
        Me.IntrestRate.Size = New System.Drawing.Size(140, 38)
        Me.IntrestRate.TabIndex = 7
        '
        'RetirementYear
        '
        Me.RetirementYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetirementYear.Location = New System.Drawing.Point(310, 240)
        Me.RetirementYear.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.RetirementYear.Name = "RetirementYear"
        Me.RetirementYear.Size = New System.Drawing.Size(140, 38)
        Me.RetirementYear.TabIndex = 6
        '
        'YearlyContribution
        '
        Me.YearlyContribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearlyContribution.Location = New System.Drawing.Point(310, 80)
        Me.YearlyContribution.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.YearlyContribution.Name = "YearlyContribution"
        Me.YearlyContribution.Size = New System.Drawing.Size(140, 38)
        Me.YearlyContribution.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Yearly Contribution ($)"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Retirement Year"
        '
        'RetirementEnterButton
        '
        Me.RetirementEnterButton.Location = New System.Drawing.Point(104, 365)
        Me.RetirementEnterButton.Name = "RetirementEnterButton"
        Me.RetirementEnterButton.Size = New System.Drawing.Size(234, 92)
        Me.RetirementEnterButton.TabIndex = 1
        Me.RetirementEnterButton.Text = "Enter"
        Me.RetirementEnterButton.UseVisualStyleBackColor = True
        '
        'InflationTab
        '
        Me.InflationTab.BackColor = System.Drawing.Color.Transparent
        Me.InflationTab.Controls.Add(Me.InflationEnterButton)
        Me.InflationTab.Controls.Add(Me.InflationYear)
        Me.InflationTab.Controls.Add(Me.InflationRate)
        Me.InflationTab.Controls.Add(Me.Price)
        Me.InflationTab.Controls.Add(Me.Label6)
        Me.InflationTab.Controls.Add(Me.Label5)
        Me.InflationTab.Controls.Add(Me.Label4)
        Me.InflationTab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InflationTab.Location = New System.Drawing.Point(8, 39)
        Me.InflationTab.Name = "InflationTab"
        Me.InflationTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InflationTab.Size = New System.Drawing.Size(456, 507)
        Me.InflationTab.TabIndex = 1
        Me.InflationTab.Text = "Inflation Calc"
        '
        'InflationEnterButton
        '
        Me.InflationEnterButton.Location = New System.Drawing.Point(104, 365)
        Me.InflationEnterButton.Name = "InflationEnterButton"
        Me.InflationEnterButton.Size = New System.Drawing.Size(234, 92)
        Me.InflationEnterButton.TabIndex = 6
        Me.InflationEnterButton.Text = "Enter"
        Me.InflationEnterButton.UseVisualStyleBackColor = True
        '
        'InflationYear
        '
        Me.InflationYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InflationYear.Location = New System.Drawing.Point(310, 240)
        Me.InflationYear.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.InflationYear.Name = "InflationYear"
        Me.InflationYear.Size = New System.Drawing.Size(140, 38)
        Me.InflationYear.TabIndex = 5
        '
        'InflationRate
        '
        Me.InflationRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InflationRate.Location = New System.Drawing.Point(310, 160)
        Me.InflationRate.Name = "InflationRate"
        Me.InflationRate.Size = New System.Drawing.Size(140, 38)
        Me.InflationRate.TabIndex = 4
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(310, 80)
        Me.Price.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(140, 38)
        Me.Price.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 31)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Retirement Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Yearly Inflation (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price of Good ($)"
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(474, 554)
        Me.Controls.Add(Me.TabController)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectForm"
        Me.Text = "Retirement Calculator"
        Me.TabController.ResumeLayout(False)
        Me.RetirementTab.ResumeLayout(False)
        Me.RetirementTab.PerformLayout()
        CType(Me.IntrestRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetirementYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearlyContribution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InflationTab.ResumeLayout(False)
        Me.InflationTab.PerformLayout()
        CType(Me.InflationYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InflationRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Price, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabController As TabControl
    Friend WithEvents RetirementTab As TabPage
    Friend WithEvents InflationTab As TabPage
    Friend WithEvents RetirementEnterButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IntrestRate As NumericUpDown
    Friend WithEvents RetirementYear As NumericUpDown
    Friend WithEvents YearlyContribution As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InflationYear As NumericUpDown
    Friend WithEvents InflationRate As NumericUpDown
    Friend WithEvents Price As NumericUpDown
    Friend WithEvents InflationEnterButton As Button
End Class
