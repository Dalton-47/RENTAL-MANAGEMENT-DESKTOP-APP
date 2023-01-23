Public Class SmallIncomeSetRentForm

    Private Sub _101ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me._101ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewHouse101ADataSet)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Vacant101CDataSet.Vacancy101C' table. You can move, or remove it, as needed.
            Me.Vacancy101CTableAdapter.Fill(Me.Vacant101CDataSet.Vacancy101C)
            'TODO: This line of code loads data into the 'Vacant101BDataSet.Vacancy101B' table. You can move, or remove it, as needed.
            Me.Vacancy101BTableAdapter.Fill(Me.Vacant101BDataSet.Vacancy101B)
            'TODO: This line of code loads data into the 'Vacant101ADataSet.Vacancy101A' table. You can move, or remove it, as needed.
            Me.Vacancy101ATableAdapter.Fill(Me.Vacant101ADataSet.Vacancy101A)
            'TODO: This line of code loads data into the 'NewHouse101CDataSet._101C' table. You can move, or remove it, as needed.
            Me._101CTableAdapter.Fill(Me.NewHouse101CDataSet._101C)
            'TODO: This line of code loads data into the 'NewHouse101BDataSet._101B' table. You can move, or remove it, as needed.
            Me._101BTableAdapter.Fill(Me.NewHouse101BDataSet._101B)
            'TODO: This line of code loads data into the 'NewHouse101ADataSet._101A' table. You can move, or remove it, as needed.
            Me._101ATableAdapter.Fill(Me.NewHouse101ADataSet._101A)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        RentTextBoxA.Visible = False
        RentTextBoxB.Visible = False
        RentTextBoxC.Visible = False
        TenantTextBox101A.Visible = False
        TenantTextBox101B.Visible = False
        TenantTextBox101C.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If EntryTextBox.Text = String.Empty Then
            MessageBox.Show("Please Input the amount in the space provided above", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EntryTextBox.Focus()

        ElseIf EntryTextBox.Text <> String.Empty Then

            Try

                Dim myresult As DialogResult
                myresult = MessageBox.Show("Are You Sure You Want To Save The Above Value?", "Microsoft Visual Basic 2010", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                If myresult = Windows.Forms.DialogResult.Yes Then



                    If TenantTextBox101A.Text = 2 Then

                        Dim myrent As Integer
                        Dim money As Integer
                        Dim totalsa As Integer

                        myrent = EntryTextBox.Text
                        money = ListBox1.Text
                        myrent = 0 - myrent
                        totalsa = myrent + money
                        RentTextBoxA.Text = String.Empty
                        RentTextBoxA.Text = totalsa
                        Me._101ABindingSource1.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.NewHouse101ADataSet)

                    End If
                   
                    If TenantTextBox101B.Text = 2 Then
                        Dim myrent2 As Integer
                        Dim money2 As Integer
                        Dim totalsb As Integer

                        myrent2 = EntryTextBox.Text
                        myrent2 = 0 - myrent2
                        money2 = ListBox2.Text
                        totalsb = myrent2 + money2
                        RentTextBoxB.Text = String.Empty
                        RentTextBoxB.Text = totalsb
                        Me._101BBindingSource.EndEdit()
                        Me.TableAdapterManager1.UpdateAll(Me.NewHouse101BDataSet)

                    End If
                   


                    If TenantTextBox101C.Text = 2 Then

                        Dim myrent3 As Integer
                        Dim money3 As Integer
                        Dim totalsc As Integer

                        myrent3 = EntryTextBox.Text
                        myrent3 = 0 - myrent3
                        money3 = ListBox3.Text
                        totalsc = myrent3 + money3
                        RentTextBoxC.Text = String.Empty
                        RentTextBoxC.Text = totalsc
                        Me._101CBindingSource.EndEdit()
                        Me.TableAdapterManager2.UpdateAll(Me.NewHouse101CDataSet)

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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ChooseEstateForm.Show()

    End Sub

    Private Sub EntryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryTextBox.TextChanged

    End Sub
End Class