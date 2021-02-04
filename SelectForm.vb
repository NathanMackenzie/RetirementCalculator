
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'   Form       : SelectForm
'
'   Description: This class handles all of the load and event functionality for the SelectForm GUI.
'
'
'   Author     : Nathan Mackenzie
'
'   Date       : 3/6/19
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class SelectForm

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : TabController_SelectedIndexChanged
    ' Description   : This function is called whenever a new tab is selected. Changes the form text
    '                 to match the currently selected tab.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : TabController
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub TabController_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabController.SelectedIndexChanged
        Me.Text = TabController.SelectedTab.Text 'Change form text to match the name of the selected tab
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : SelectForm_Load
    ' Description   : First called upon loading the SelectForm GUI. Manages initial formatting task.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : SelectForm
    ' Value Returned: Void
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub SelectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Format all input fields on the retirement calculator tab
        YearlyContribution.DecimalPlaces = 2
        IntrestRate.DecimalPlaces = 2
        RetirementYear.Value = Date.Today.Year
        RetirementYear.Minimum = Date.Today.Year

        'Format all input fields on the inflation calculator tab
        Price.DecimalPlaces = 2
        InflationRate.DecimalPlaces = 2
        InflationYear.Value = Date.Today.Year
        InflationYear.Minimum = Date.Today.Year
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : RetirementEnterButton_Click
    ' Description   : Called on click of RetirementEnterButton, sends data to RetirementForm and
    '                 calls to open the form.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : RetirementEnterButton
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub RetirementEnterButton_Click(sender As Object, e As EventArgs) Handles RetirementEnterButton.Click
        'Pass all input field information to the RetirementForm
        RetirementForm.SetContribution = YearlyContribution.Value
        RetirementForm.SetIntrest = IntrestRate.Value
        RetirementForm.SetYear = RetirementYear.Value
        'Call to show RetirementForm as a modal 
        RetirementForm.ShowDialog()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : InflationEnterButton_Click
    ' Description   : Called on click of InflationEnterButton, sends data to InflationForm and
    '                 calls to open the form.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : RetirementEnterButton
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub InflationEnterButton_Click(sender As Object, e As EventArgs) Handles InflationEnterButton.Click
        'Pass all input field information to the InflationForm
        InflationForm.SetPrice = Price.Value
        InflationForm.SetInflation = InflationRate.Value
        InflationForm.SetYear = InflationYear.Value
        'Call to show InflationForm as a modal
        InflationForm.ShowDialog()
    End Sub
End Class
