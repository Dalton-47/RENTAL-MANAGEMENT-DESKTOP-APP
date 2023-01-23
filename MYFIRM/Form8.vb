Public Class MediumIncomeSetRentForm

    Private Sub _202ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _202ABindingNavigatorSaveItem.Click
        Me.Validate()
        Me._202ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.House202ADataSet)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vacant303BDataSet.Vacancy303B' table. You can move, or remove it, as needed.
        Me.Vacancy303BTableAdapter.Fill(Me.Vacant303BDataSet.Vacancy303B)
        'TODO: This line of code loads data into the 'VacantB202DataSet.VacancyB202' table. You can move, or remove it, as needed.
        Me.VacancyB202TableAdapter.Fill(Me.VacantB202DataSet.VacancyB202)
        'TODO: This line of code loads data into the 'Vacant303ADataSet.Vacancy303A' table. You can move, or remove it, as needed.
        Me.Vacancy303ATableAdapter.Fill(Me.Vacant303ADataSet.Vacancy303A)
        'TODO: This line of code loads data into the 'Vacant202ADataSet.Vacancy202A' table. You can move, or remove it, as needed.
        Me.Vacancy202ATableAdapter.Fill(Me.Vacant202ADataSet.Vacancy202A)
        Try
            'TODO: This line of code loads data into the 'House303BDataSet._303B' table. You can move, or remove it, as needed.
            Me._303BTableAdapter.Fill(Me.House303BDataSet._303B)
            'TODO: This line of code loads data into the 'House303ADataSet._303A' table. You can move, or remove it, as needed.
            Me._303ATableAdapter.Fill(Me.House303ADataSet._303A)
            'TODO: This line of code loads data into the 'House202BDataSet._202B' table. You can move, or remove it, as needed.
            Me._202BTableAdapter.Fill(Me.House202BDataSet._202B)
            'TODO: This line of code loads data into the 'House202ADataSet._202A' table. You can move, or remove it, as needed.
            Me._202ATableAdapter.Fill(Me.House202ADataSet._202A)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        RentTextBoxA.Text = String.Empty
        RentTextBoxB.Text = String.Empty
        RentTextBoxC.Text = String.Empty
        RentTextBoxD.Text = String.Empty
        RentTextBoxA.Visible = False
        RentTextBoxB.Visible = False
        RentTextBoxC.Visible = False
        RentTextBoxD.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False
        TenantTextBox202A.Visible = False
        TenantTextBox202B.Visible = False
        TenantTextBox303A.Visible = False
        TenantTextBox303B.Visible = False






    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If EntryTextBox.Text = String.Empty Then
            MessageBox.Show("Please Input the amount in the space provided above", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EntryTextBox.Focus()

        ElseIf EntryTextBox.Text <> String.Empty Then

            Try

                Dim myresult As DialogResult
                myresult = MessageBox.Show("Are You Sure You Want To Save The Above Value?", "Microsoft Visual Basic Express", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                If myresult = Windows.Forms.DialogResult.Yes Then

                    If TenantTextBox202A.Text = 2 Then

                        Dim cash As Integer
                        Dim balance As Integer
                        Dim totals As Integer
                        cash = EntryTextBox.Text
                        cash = 0 - cash
                        balance = ListBox1.Text
                        totals = cash + balance
                        RentTextBoxA.Text = String.Empty
                        RentTextBoxA.Text = totals
                        Me._202ABindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.House202ADataSet)

                    End If
                   

                    If TenantTextBox202B.Text = 2 Then

                        Dim cash1 As Integer
                        Dim balance1 As Integer
                        Dim totals1 As Integer
                        cash1 = EntryTextBox.Text
                        cash1 = 0 - cash1
                        balance1 = ListBox2.Text
                        totals1 = cash1 + balance1
                        RentTextBoxB.Text = String.Empty
                        RentTextBoxB.Text = totals1
                        Me._202BBindingSource.EndEdit()
                        Me.TableAdapterManager1.UpdateAll(Me.House202BDataSet)

                    End If
                   
                    If TenantTextBox303A.Text = 2 Then

                        Dim cash2 As Integer
                        Dim balance2 As Integer
                        Dim totals2 As Integer
                        cash2 = EntryTextBox.Text
                        cash2 = 0 - cash2
                        balance2 = ListBox3.Text
                        totals2 = cash2 + balance2
                        RentTextBoxC.Text = String.Empty
                        RentTextBoxC.Text = totals2
                        Me._303ABindingSource.EndEdit()
                        Me.TableAdapterManager2.UpdateAll(Me.House303ADataSet)

                    End If
                   
                    If TenantTextBox303B.Text = 2 Then

                        Dim cash3 As Integer
                        Dim balance3 As Integer
                        Dim totals3 As Integer
                        cash3 = EntryTextBox.Text
                        cash3 = 0 - cash3
                        balance3 = ListBox4.Text
                        totals3 = cash3 + balance3
                        RentTextBoxD.Text = String.Empty
                        RentTextBoxD.Text = totals3
                        Me._303BBindingSource.EndEdit()
                        Me.TableAdapterManager3.UpdateAll(Me.House303BDataSet)

                    End If
                    

                    MessageBox.Show("Rent For Upcoming Month Successfully Updated", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    SaveButton.Enabled = False
                    EntryTextBox.ReadOnly = True
                Else
                    EntryTextBox.Text = String.Empty
                    EntryTextBox.Focus()

                End If


            Catch ex As Exception
                MessageBox.Show("AN Unknown error Occurred,  Ensure you input numbers only", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                EntryTextBox.Text = String.Empty
                EntryTextBox.Focus()

            End Try
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ChooseEstateForm.Show()

    End Sub
End Class