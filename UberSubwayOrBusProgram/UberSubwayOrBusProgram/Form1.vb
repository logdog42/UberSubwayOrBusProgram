'Program:               Uber, Subway, or Bus 
'Developer:             Logan Taylor
'Date:                  12/16/20
'Purpose:               To calculate yearly commute cost based on user inputs for how they commute.

Option Strict On

Public Class frmUberSubwayOrBus

    'Class Variables
    Dim decMonthlyCost As Decimal
    Dim decYearlyCost As Decimal
    Dim intTransportType As Integer
    Dim intDaysInMonth As Integer
    Dim decCostPerDay As Decimal
    Dim strCostPerDay As String
    Dim strDailyCost As String
    Dim strDaysInMonth As String
    Dim blnValidateDaysInMonth As Boolean = False
    Dim blnValidateCostPerDay As Boolean = False
    Dim blnValidateTransportation As Boolean = False

    Private Sub frmUberSubwayOrBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Executes when application loads

        Threading.Thread.Sleep(5000)
        lblCommuteCostDisplay.Visible = False

    End Sub

    Private Sub cboTransportationMethod_SelectedIndexChanged(ByVal Sender As System.Object, ByVal e As EventArgs) Handles cboTransportationMethod.SelectedIndexChanged
        'Allows the user to pick transportation type, then calls sub procedure to display a series of input boxes asking for additional information.

        intTransportType = cboTransportationMethod.SelectedIndex
        Select Case intTransportType

            Case 0

                UberGroup()

            Case 1

                SubwayGroup()

            Case 2

                BusGroup()


        End Select

    End Sub

    Private Sub UberGroup()

        ValidateTransportType()
    End Sub

    Private Sub BusGroup()

        ValidateTransportType()
    End Sub

    Private Sub SubwayGroup()

        ValidateTransportType()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' asks for more information, Determines, and displays yearly commuting cost based on user inputs

        'strings used in this sub
        Dim strDailyCostAsk As String = "How much does it cost for one day of travel?"
        Dim strCostTitle As String = "Daily Cost"
        Dim strDaysInMonthAsk As String = "How many days do you travel to work, per month?"
        Dim strDaysTitle As String = "Days Per Month"

        'executed based on selected transportation type
        Try


            Select Case (cboTransportationMethod.SelectedIndex)

                Case 0

                    If blnValidateTransportation = True Then

                        strDailyCost = InputBox(strDailyCostAsk, strCostTitle)
                        ValidateCostPerDay()

                        If blnValidateCostPerDay = True Then

                            strDaysInMonth = InputBox(strDaysInMonthAsk, strDaysTitle)
                            ValidateDaysInMonth()

                            If blnValidateDaysInMonth = True Then

                                decMonthlyCost = Convert.ToDecimal(Convert.ToDecimal(strDailyCost) * 1.2) * intDaysInMonth
                                decYearlyCost = decMonthlyCost * 12
                                lblCommuteCostDisplay.Text = "Your yearly commute cost is " & decYearlyCost.ToString("C")
                                lblCommuteCostDisplay.Visible = True
                                btnCalculate.Enabled = False
                            Else

                                MsgBox("Enter a reasonable number of days, please.", , "Wow, did you really?")

                            End If

                        Else

                            MsgBox("Your price has to be between $1 and $59.99", , "Wow, did you really?")

                        End If

                    Else

                        MsgBox("You have to pick a type of transportaion.", , "Wow, did you really?")

                    End If

                Case 1

                    If blnValidateTransportation = True Then

                        strDailyCost = InputBox(strDailyCostAsk, strCostTitle)
                        ValidateCostPerDay()

                        If blnValidateCostPerDay = True Then

                            strDaysInMonth = InputBox(strDaysInMonthAsk, strDaysTitle)
                            ValidateDaysInMonth()

                            If blnValidateDaysInMonth = True Then

                                decMonthlyCost = Convert.ToDecimal(Convert.ToDecimal(strDailyCost) * 1) * intDaysInMonth
                                decYearlyCost = decMonthlyCost * 12
                                lblCommuteCostDisplay.Text = "Your yearly commute cost is " & decYearlyCost.ToString("C")
                                lblCommuteCostDisplay.Visible = True
                                btnCalculate.Enabled = False
                            Else

                                MsgBox("Enter a reasonable number of days, please.", , "Wow, did you really?")

                            End If

                        Else

                            MsgBox("Your price has to be between $1 and $59.99", , "Wow, did you really?")

                        End If

                    Else

                        MsgBox("You have to pick a type of transportaion.", , "Wow, did you really?")

                    End If

                Case 2

                    If blnValidateTransportation = True Then

                        strDailyCost = InputBox(strDailyCostAsk, strCostTitle)
                        ValidateCostPerDay()

                        If blnValidateCostPerDay = True Then

                            strDaysInMonth = InputBox(strDaysInMonthAsk, strDaysTitle)
                            ValidateDaysInMonth()

                            If blnValidateDaysInMonth = True Then

                                decMonthlyCost = Convert.ToDecimal(Convert.ToDecimal(strDailyCost) * 1) * intDaysInMonth
                                decYearlyCost = decMonthlyCost * 12
                                lblCommuteCostDisplay.Text = "Your yearly commute cost is " & decYearlyCost.ToString("C")
                                lblCommuteCostDisplay.Visible = True
                                btnCalculate.Enabled = False

                            Else

                                MsgBox("Enter a reasonable number of days, please.", , "Wow, did you really?")

                            End If

                        Else

                            MsgBox("Your price has to be between $1 and $59.99", , "Wow, did you really?")

                        End If

                    Else

                        MsgBox("You have to pick a type of transportaion.", , "Wow, did you really?")

                    End If

            End Select

        Catch ex As Exception

            MsgBox("You broke it, Way to go.", , "Wow, did you really?")


        End Try



    End Sub







    Private Function ValidateDaysInMonth() As Boolean
        'This procedure validates the input for workdays in a month

        intDaysInMonth = Convert.ToInt32(strDaysInMonth)

            If intDaysInMonth < 31 And intDaysInMonth > 0 Then

                blnValidateDaysInMonth = True

            Else

                blnValidateDaysInMonth = False
                intDaysInMonth = Convert.ToInt32(InputBox("Please enter your average number of workdays in a month; between 1 and 28 days. ", "Error"))
                ValidateDaysInMonth()

            End If


            Return blnValidateDaysInMonth

    End Function
    Private Function ValidateCostPerDay() As Boolean
        ' This function validates the Cost Per Day Input

        Dim strDailyCostError As String = "Please enter a valid cost between $1 and $59.99"
        Dim strMessageBoxTitle As String = "Error"

        decCostPerDay = Convert.ToDecimal(strDailyCost)

            If decCostPerDay > 0.99 And decCostPerDay < 60 Then

                blnValidateCostPerDay = True

            Else

                blnValidateCostPerDay = False
                decCostPerDay = Convert.ToDecimal(InputBox(strDailyCostError, strMessageBoxTitle))
                ValidateCostPerDay()

            End If

            Return blnValidateCostPerDay

    End Function

    Private Function ValidateTransportType() As Boolean
        'Ensures that The type of transportation is selected.

        Dim intTransportType As Integer

        'call a funtion to ensure the type of transport is selected.
        intTransportType = Convert.ToInt32(cboTransportationMethod.SelectedIndex)

            If cboTransportationMethod.SelectedIndex <= 2 And cboTransportationMethod.SelectedIndex >= 0 Then

                blnValidateTransportation = True

            Else
                'Detects If a Transport type is Selected

                blnValidateTransportation = False
                MsgBox("Please select a transport type", , "First Step")

            End If

            Return blnValidateTransportation

    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Executed when menu item Clear is clicked

        lblCommuteCostDisplay.Visible = False
        cboTransportationMethod.Text = "Type of Transport"
        btnCalculate.Enabled = True

    End Sub
End Class
