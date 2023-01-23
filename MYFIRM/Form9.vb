Public Class LargeIncomeSetRentForm

    Private Sub _404ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _404ABindingNavigatorSaveItem.Click
        Me.Validate()
        Me._404ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.House404ADataSet)

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vacant505BDataSet.Vacancy505B' table. You can move, or remove it, as needed.
        Me.Vacancy505BTableAdapter.Fill(Me.Vacant505BDataSet.Vacancy505B)
        'TODO: This line of code loads data into the 'Vacant505ADataSet.Vacancy505A' table. You can move, or remove it, as needed.
        Me.Vacancy505ATableAdapter.Fill(Me.Vacant505ADataSet.Vacancy505A)
        'TODO: This line of code loads data into the 'Vacant404ADataSet.Vacancy404A' table. You can move, or remove it, as needed.
        Me.Vacancy404ATableAdapter.Fill(Me.Vacant404ADataSet.Vacancy404A)
        Try
            'TODO: This line of code loads data into the 'House505BDataSet._505B' table. You can move, or remove it, as needed.
            Me._505BTableAdapter.Fill(Me.House505BDataSet._505B)
            'TODO: This line of code loads data into the 'House505BDataSet._505B' table. You can move, or remove it, as needed.
            Me._505BTableAdapter.Fill(Me.House505BDataSet._505B)
            'TODO: This line of code loads data into the 'House505ADataSet._505A' table. You can move, or remove it, as needed.
            Me._505ATableAdapter.Fill(Me.House505ADataSet._505A)
            'TODO: This line of code loads data into the 'House404ADataSet._404A' table. You can move, or remove it, as needed.
            Me._404ATableAdapter.Fill(Me.House404ADataSet._404A)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        RentTextBoxA.Text = String.Empty
        RentTextBoxB.Text = String.Empty
        RentTextBoxC.Text = String.Empty
        RentTextBoxA.Visible = False
        RentTextBoxB.Visible = False
        RentTextBoxC.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        TenantTextBox404A.Visible = False
        TenantTextBox505A.Visible = False
        TenantTextBox505B.Visible = False





    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If EntryTextBox.Text = String.Empty Then
            MessageBox.Show("Please Input the amount in the space provided above", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EntryTextBox.Focus()

        ElseIf EntryTextBox.Text <> String.Empty Then

            Try

                Dim myresult As DialogResult
                myresult = MessageBox.Show("Are You Sure You Want To Save The Above Value?", "Microsoft Visual Basic 2010", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                If myresult = Windows.Forms.DialogResult.Yes Then

                    If TenantTextBox404A.Text = 2 Then

                        Dim balance As Integer
                        Dim cash As Integer
                        Dim totals As Integer
                        balance = ListBox1.Text
                        cash = EntryTextBox.Text
                        cash = 0 - cash
                        totals = balance + cash
                        RentTextBoxA.Text = String.Empty
                        RentTextBoxA.Text = totals
                        Me._404ABindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.House404ADataSet)

                    End If
                    
                    If TenantTextBox505A.Text = 2 Then

                        Dim balance1 As Integer
                        Dim cash1 As Integer
                        Dim totals1 As Integer
                        balance1 = ListBox2.Text
                        cash1 = EntryTextBox.Text
                        cash1 = 0 - cash1
                        totals1 = cash1 + balance1
                        RentTextBoxB.Text = String.Empty
                        RentTextBoxB.Text = totals1
                        Me._505ABindingSource.EndEdit()
                        Me.TableAdapterManager1.UpdateAll(Me.House505ADataSet)

                    End If
                   
                    If TenantTextBox505B.Text = 2 Then

                        Dim balance2 As Integer
                        Dim cash2 As Integer
                        Dim totals2 As Integer
                        balance2 = ListBox3.Text
                        cash2 = EntryTextBox.Text
                        cash2 = 0 - cash2
                        totals2 = cash2 + balance2
                        RentTextBoxC.Text = String.Empty
                        RentTextBoxC.Text = totals2
                        Me._505BBindingSource.EndEdit()
                        Me.TableAdapterManager2.UpdateAll(Me.House505BDataSet)

                    End If
                    


                    MessageBox.Show("Rent For Upcoming Month Successfully Updated", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    SaveButton.Enabled = False
                    EntryTextBox.ReadOnly = True
                Else
                    EntryTextBox.Text = String.Empty
                    EntryTextBox.Focus()

                End If


            Catch ex As Exception
                MessageBox.Show("AN Unknown error Occurred,  Ensure you input numbers only", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                EntryTextBox.Text = String.Empty
                EntryTextBox.Focus()

            End Try
        End If



    End Sub

    Private Sub RentTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentTextBoxA.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ChooseEstateForm.Show()
    End Sub
End Class