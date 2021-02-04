'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'   Form       : RetirementForm
'
'   Description: This class loads the RetirementForm GUI and calculates the results for a retirement
'                account with the given parameters
'
'   Author     : Nathan Mackenzie
'
'   Date       : 3/6/19
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class RetirementForm

    Dim Contribution As Double 'Allocate space for Contribution varials
    Dim Intrest As Double 'Allocate space for Intrest variable
    Dim Year As Int16 'Alocate space for the retirement yeart

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Property   : SetContribution
    ' Description: A write only setter property for the Contribution variable.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public WriteOnly Property SetContribution As Double
        Set(Value As Double)
            Contribution = Value
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Property   : SetIntrest
    ' Description: A write only setter property for the Intrest variable.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public WriteOnly Property SetIntrest As Double
        Set(Value As Double)
            Intrest = Value / 100
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
    ' Function      : RetirementForm_Load
    ' Description   : This function is called when RetirementForm GUI loads. It manages initial 
    '                 formatting of the charct area and calls to function to populate the charts.
    ' Parameters    : sender: Object of the compnenet calling the function
    '                 e: Class containing data of the even
    '
    ' Called By     : RetirementForm
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub RetirementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set initial page dimentions
        Me.Width = 800
        Me.Height = 540

        'Format chart area
        BarChart.Series("Contributed").Points.Clear()
        BarChart.Series("Balance").Points.Clear()
        BarChart.ChartAreas("ChartArea1").AxisX.Title = "Year"
        BarChart.ChartAreas("ChartArea1").AxisY.Title = "US Dollars"

        'Call to populate the chart and list view
        PopulateList()

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


    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Function      : PopulateList
    ' Description   : This function calculates the interest earned in a given year, total interest earned,
    '                 total contributions, and account balance, for each consecutive year between now and
    '                 retirement. It then populates the listview and chart with these values
    ' Parameters    : NULL
    '
    ' Called By     : RetirementForm_Load
    ' Value Returned: Void
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub PopulateList()

        Dim Total As Double 'Allocate space for the total variable. Used to hold the value of the new 
        'account total
        Dim Principle As Double = 0 'Allocate space for Principle variable. Used to hold the account
        'previous balance
        Dim TotalContribution As Double = 0 'Allocate space for the TotalContributions variable. Used
        'to keep a running tally of all contributions made.

        'Iterate through every year from not until the year of retirement
        For Iterate As Int16 = Date.Today.Year To Year Step 1
            Total = Contribution + Principle * (Math.E) ^ (Intrest) 'Calculate the new balance on the account
            TotalContribution += Contribution ' Add this years contribution to the total contributions

            'Format and populate the list view
            Dim str(5) As String
            Dim itm As ListViewItem
            str(0) = Iterate.ToString 'Current year of row
            str(1) = FormatCurrency(TotalContribution).ToString 'Total contributions
            str(2) = FormatCurrency(((Principle * (Math.E) ^ (Intrest)) - Principle)).ToString 'Interest earned
            str(3) = FormatCurrency((Total - TotalContribution)).ToString 'Total interest earned
            str(4) = FormatCurrency(Total) 'Current account balance
            itm = New ListViewItem(str)
            YearlyListView.Items.Add(itm) 'Add row to list view

            'Add currenet balance and contribution bars to the chart
            BarChart.Series("Contributed").Points.AddXY(Iterate, TotalContribution)
            BarChart.Series("Balance").Points.AddXY(Iterate, (Total))

            Principle = Total 'Set principle to be the current total
        Next

    End Sub


End Class