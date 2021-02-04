'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'   Form       : InflationForm
'
'   Description: This class loads the InflationForm GUI and calculates the results of inflation for 
'                the provided inputs.
'
'   Author     : Nathan Mackenzie
'
'   Date       : 3/6/19
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class InflationForm
    Dim Price As Double 'Allocate space for price variable
    Dim Inflation As Double 'Allocate space for Inflation variable
    Dim Year As Int16 'Allocate space for year of retirement variable 

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Property   : SetPrice
    ' Description: A write only setter property for the Price variable.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public WriteOnly Property SetPrice As Double
        Set(Value As Double)
            Price = Value
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Property   : SetInflation
    ' Description: A write only setter property for the Inflation variable.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public WriteOnly Property SetInflation As Double
        Set(Value As Double)
            Inflation = Value / 100
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Property   : SetYear
    ' Description: A write only setter property for the Year variable.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public WriteOnly Property SetYear As Int16
        Set(Value As Int16)
            Year = Value
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : InflationForm_Load
    ' Description   : This function is called when InflationForm GUI loads. It formates and calculates
    '                 the inflated price of a good for the provided inputs.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : InflationForm
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub InflationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewPrice As Double = 0
        NewPrice = Price * Math.E ^ (Inflation * (Year - Date.Today.Year)) 'Calculate the inflated price
        'Change text on all labels to reflect the results
        InitialPrice.Text = FormatCurrency(Price).ToString
        FuturePrice.Text = FormatCurrency(NewPrice).ToString
        RetirementYear.Text = Year.ToString
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : ExitButton_Click
    ' Description   : This function exits the entire application.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : ExitButton
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : RecalculateButton_Click
    ' Description   : This function closes this form allowing the parent form to come back into focus.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : RecalculateButton
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub RecalculateButton_Click(sender As Object, e As EventArgs) Handles RecalculateButton.Click
        Me.Close()
    End Sub


End Class