<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InflationForm
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
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.RecalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResultsLabel2 = New System.Windows.Forms.Label()
        Me.ResultsLabel3 = New System.Windows.Forms.Label()
        Me.InitialPrice = New System.Windows.Forms.Label()
        Me.RetirementYear = New System.Windows.Forms.Label()
        Me.FuturePrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel.Location = New System.Drawing.Point(57, 68)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(261, 42)
        Me.ResultsLabel.TabIndex = 0
        Me.ResultsLabel.Text = "Current Price:"
        '
        'RecalculateButton
        '
        Me.RecalculateButton.Location = New System.Drawing.Point(378, 326)
        Me.RecalculateButton.Name = "RecalculateButton"
        Me.RecalculateButton.Size = New System.Drawing.Size(154, 56)
        Me.RecalculateButton.TabIndex = 1
        Me.RecalculateButton.Text = "Recalculate"
        Me.RecalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(538, 326)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(126, 56)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ResultsLabel2
        '
        Me.ResultsLabel2.AutoSize = True
        Me.ResultsLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel2.Location = New System.Drawing.Point(57, 130)
        Me.ResultsLabel2.Name = "ResultsLabel2"
        Me.ResultsLabel2.Size = New System.Drawing.Size(358, 42)
        Me.ResultsLabel2.TabIndex = 3
        Me.ResultsLabel2.Text = "Year of Retirement:"
        '
        'ResultsLabel3
        '
        Me.ResultsLabel3.AutoSize = True
        Me.ResultsLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel3.Location = New System.Drawing.Point(57, 194)
        Me.ResultsLabel3.Name = "ResultsLabel3"
        Me.ResultsLabel3.Size = New System.Drawing.Size(244, 42)
        Me.ResultsLabel3.TabIndex = 4
        Me.ResultsLabel3.Text = "Future Price:"
        '
        'InitialPrice
        '
        Me.InitialPrice.AutoSize = True
        Me.InitialPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialPrice.Location = New System.Drawing.Point(454, 68)
        Me.InitialPrice.Name = "InitialPrice"
        Me.InitialPrice.Size = New System.Drawing.Size(131, 42)
        Me.InitialPrice.TabIndex = 5
        Me.InitialPrice.Text = "Label1"
        '
        'RetirementYear
        '
        Me.RetirementYear.AutoSize = True
        Me.RetirementYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetirementYear.Location = New System.Drawing.Point(454, 130)
        Me.RetirementYear.Name = "RetirementYear"
        Me.RetirementYear.Size = New System.Drawing.Size(131, 42)
        Me.RetirementYear.TabIndex = 6
        Me.RetirementYear.Text = "Label2"
        '
        'FuturePrice
        '
        Me.FuturePrice.AutoSize = True
        Me.FuturePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuturePrice.Location = New System.Drawing.Point(454, 194)
        Me.FuturePrice.Name = "FuturePrice"
        Me.FuturePrice.Size = New System.Drawing.Size(131, 42)
        Me.FuturePrice.TabIndex = 7
        Me.FuturePrice.Text = "Label3"
        '
        'InflationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 394)
        Me.Controls.Add(Me.FuturePrice)
        Me.Controls.Add(Me.RetirementYear)
        Me.Controls.Add(Me.InitialPrice)
        Me.Controls.Add(Me.ResultsLabel3)
        Me.Controls.Add(Me.ResultsLabel2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RecalculateButton)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Name = "InflationForm"
        Me.Text = "Inflation Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultsLabel As Label
    Friend WithEvents RecalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResultsLabel2 As Label
    Friend WithEvents ResultsLabel3 As Label
    Friend WithEvents InitialPrice As Label
    Friend WithEvents RetirementYear As Label
    Friend WithEvents FuturePrice As Label
End Class
