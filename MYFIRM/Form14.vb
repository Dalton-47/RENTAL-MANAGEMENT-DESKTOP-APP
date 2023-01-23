Public Class RentForm

    Private Sub setcontrols(ByVal valueboolean As Boolean)
        HouseNameTextBox.ReadOnly = valueboolean
        RentTextBox.ReadOnly = valueboolean
        MyDateDateTimePicker.Enabled = Not valueboolean
        MPESATransactionNumberTextBox.ReadOnly = valueboolean
        BindingNavigatorMoveFirstItem.Visible = valueboolean
        BindingNavigatorMoveLastItem.Visible = valueboolean
        BindingNavigatorMoveNextItem.Visible = valueboolean
        BindingNavigatorMovePreviousItem.Visible = valueboolean
        BindingNavigatorPositionItem.Visible = valueboolean
        BindingNavigatorAddNewItem.Enabled = valueboolean
        BindingNavigatorCountItem.Visible = valueboolean
        BindingNavigatorDeleteItem.Enabled = valueboolean
        RecordsBindingNavigatorSaveItem.Enabled = Not valueboolean





    End Sub
    Private Sub RecordsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsBindingNavigatorSaveItem.Click

        Try
            Dim mydialog As DialogResult
            mydialog = MessageBox.Show("Are You sure you want to Save this record?", "Microsoft Visual Basic Express", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If mydialog = Windows.Forms.DialogResult.Yes Then
                Me.Validate()
                Me.RecordsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MyRecordsDataSet)
                setcontrols(True)
                HouseNameTextBox.Focus()
                Dim rent As Integer = RentTextBox.Text
                Dim mycash As Integer = CashTextBox.Text
                Dim cashbox As Integer

                If HouseNameTextBox.Text.ToString.ToLower = "101a" Then
                    Dim rent1 As Integer = RentTextBox101a.Text
                    Dim totals1 As Integer
                    totals1 = rent + rent1
                    RentTextBox101a.Text = String.Empty
                    RentTextBox101a.Text = totals1
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me._101ABindingSource.EndEdit()
                    Me.TableAdapterManager1.UpdateAll(Me.NewHouse101ADataSet)
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)

                ElseIf HouseNameTextBox.Text.ToString.ToLower = "101b" Then
                    Dim rent2 As Integer
                    Dim totals2 As Integer
                    rent2 = RentTextBox101b.Text
                    totals2 = rent + rent2
                    RentTextBox101b.Text = String.Empty
                    RentTextBox101b.Text = totals2
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._101BBindingSource.EndEdit()
                    Me.TableAdapterManager2.UpdateAll(Me.NewHouse101BDataSet)


                ElseIf HouseNameTextBox.Text.ToString.ToLower = "101c" Then
                    Dim rent3 As Integer
                    Dim totals3 As Integer
                    rent3 = RentTextBox101c.Text
                    totals3 = rent + rent3
                    RentTextBox101c.Text = String.Empty
                    RentTextBox101c.Text = totals3
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._101CBindingSource.EndEdit()
                    Me.TableAdapterManager3.UpdateAll(Me.NewHouse101CDataSet)


                ElseIf HouseNameTextBox.Text.ToString.ToLower = "202a" Then
                    Dim rent4 As Integer
                    Dim totals4 As Integer
                    rent4 = RentTextBox202a.Text
                    totals4 = rent4 + rent
                    RentTextBox202a.Text = String.Empty
                    RentTextBox202a.Text = totals4
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._202ABindingSource.EndEdit()
                    Me.TableAdapterManager4.UpdateAll(Me.House202ADataSet)


                ElseIf HouseNameTextBox.Text.ToString.ToLower = "202b" Then
                    Dim rent5 As Integer
                    Dim totals5 As Integer
                    rent5 = RentTextBox202b.Text
                    totals5 = rent + rent5
                    RentTextBox202b.Text = String.Empty
                    RentTextBox202b.Text = totals5
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._202BBindingSource.EndEdit()
                    Me.TableAdapterManager5.UpdateAll(Me.House202BDataSet)


                ElseIf HouseNameTextBox.Text.ToString.ToLower = "303a" Then
                    Dim rent6 As Integer
                    Dim totals6 As Integer
                    rent6 = RentTextBox303a.Text
                    totals6 = rent + rent6
                    RentTextBox303a.Text = String.Empty
                    RentTextBox303a.Text = totals6
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._303ABindingSource.EndEdit()
                    Me.TableAdapterManager6.UpdateAll(Me.House303ADataSet)


                ElseIf HouseNameTextBox.Text.ToString.ToLower = "303b" Then
                    Dim rent7 As Integer
                    Dim totals7 As Integer
                    rent7 = RentTextBox303b.Text
                    totals7 = rent + rent7
                    RentTextBox303b.Text = String.Empty
                    RentTextBox303b.Text = totals7
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._303BBindingSource.EndEdit()
                    Me.TableAdapterManager7.UpdateAll(Me.House303BDataSet)



                ElseIf HouseNameTextBox.Text.ToString.ToLower = "404a" Then
                    Dim rent8 As Integer
                    Dim totals8 As Integer
                    rent8 = RentTextBox404a.Text
                    totals8 = rent + rent8
                    RentTextBox404a.Text = String.Empty
                    RentTextBox404a.Text = totals8
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._404ABindingSource.EndEdit()
                    Me.TableAdapterManager8.UpdateAll(Me.House404ADataSet)



                ElseIf HouseNameTextBox.Text.ToString.ToLower = "505a" Then
                    Dim rent9 As Integer
                    Dim totals9 As Integer
                    rent9 = RentTextBox505a.Text
                    totals9 = rent + rent9
                    RentTextBox505a.Text = String.Empty
                    RentTextBox505a.Text = totals9
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._505ABindingSource.EndEdit()
                    Me.TableAdapterManager9.UpdateAll(Me.House505ADataSet)



                ElseIf HouseNameTextBox.Text.ToString.ToLower = "505b" Then
                    Dim rent10 As Integer
                    Dim totals10 As Integer
                    rent10 = RentTextBox505b.Text
                    totals10 = rent + rent10
                    RentTextBox505b.Text = String.Empty
                    RentTextBox505b.Text = totals10
                    cashbox = rent + mycash
                    CashTextBox.Text = String.Empty
                    CashTextBox.Text = cashbox
                    Me.CashtableboxBindingSource.EndEdit()
                    Me.TableAdapterManager11.UpdateAll(Me.CashboxdatabaseDataSet)
                    Me._505BBindingSource.EndEdit()
                    Me.TableAdapterManager10.UpdateAll(Me.House505BDataSet)



                End If


                MessageBox.Show("DATA SAVED SUCCESSFULLY", "VISUAL BASIC 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf mydialog = Windows.Forms.DialogResult.No Then
                MyDateDateTimePicker.Text = String.Empty
                HouseNameTextBox.Text = String.Empty
                RentTextBox.Text = ""
                MPESATransactionNumberTextBox.Text = String.Empty

                If HouseNameTextBox.Text = String.Empty Then
                    MyRecordsDataSet.RejectChanges()
                    RecordsBindingSource.EndEdit()

                End If
                MessageBox.Show("Data Not Saved", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Error During Save Operation"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




        setcontrols(True)

    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CashboxdatabaseDataSet.Cashtablebox' table. You can move, or remove it, as needed.
        Me.CashtableboxTableAdapter.Fill(Me.CashboxdatabaseDataSet.Cashtablebox)
        'TODO: This line of code loads data into the 'House505BDataSet._505B' table. You can move, or remove it, as needed.
        Me._505BTableAdapter.Fill(Me.House505BDataSet._505B)
        'TODO: This line of code loads data into the 'House505ADataSet._505A' table. You can move, or remove it, as needed.
        Me._505ATableAdapter.Fill(Me.House505ADataSet._505A)
        'TODO: This line of code loads data into the 'House404ADataSet._404A' table. You can move, or remove it, as needed.
        Me._404ATableAdapter.Fill(Me.House404ADataSet._404A)
        'TODO: This line of code loads data into the 'House303BDataSet._303B' table. You can move, or remove it, as needed.
        Me._303BTableAdapter.Fill(Me.House303BDataSet._303B)
        'TODO: This line of code loads data into the 'House303ADataSet._303A' table. You can move, or remove it, as needed.
        Me._303ATableAdapter.Fill(Me.House303ADataSet._303A)
        'TODO: This line of code loads data into the 'House202BDataSet._202B' table. You can move, or remove it, as needed.
        Me._202BTableAdapter.Fill(Me.House202BDataSet._202B)
        'TODO: This line of code loads data into the 'House202ADataSet._202A' table. You can move, or remove it, as needed.
        Me._202ATableAdapter.Fill(Me.House202ADataSet._202A)
        'TODO: This line of code loads data into the 'NewHouse101CDataSet._101C' table. You can move, or remove it, as needed.
        Me._101CTableAdapter.Fill(Me.NewHouse101CDataSet._101C)
        'TODO: This line of code loads data into the 'NewHouse101BDataSet._101B' table. You can move, or remove it, as needed.
        Me._101BTableAdapter.Fill(Me.NewHouse101BDataSet._101B)
        'TODO: This line of code loads data into the 'NewHouse101ADataSet._101A' table. You can move, or remove it, as needed.
        Me._101ATableAdapter.Fill(Me.NewHouse101ADataSet._101A)
        Try
            'TODO: This line of code loads data into the 'MyRecordsDataSet.Records' table. You can move, or remove it, as needed.
            Me.RecordsTableAdapter.Fill(Me.MyRecordsDataSet.Records)

        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        setcontrols(True)

    End Sub

    Private Sub MyDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        HouseNameTextBox.Focus()
        setcontrols(False)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            Dim mydialog As DialogResult
            mydialog = MessageBox.Show("Are You sure you want to delete this record?", "Microsoft Visual Basic Express", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If mydialog = Windows.Forms.DialogResult.Yes Then
                RecordsBindingSource.RemoveCurrent()
                RecordsBindingSource.EndEdit()
                RecordsTableAdapter.Update(MyRecordsDataSet.Records)
                Me.TableAdapterManager.UpdateAll(Me.MyRecordsDataSet)
                setcontrols(True)
                MessageBox.Show("Record Deleted Successfully", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MyRecordsDataSet.RejectChanges()
            RecordsBindingSource.Position = RecordsBindingSource.Position
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        setcontrols(False)
        HouseNameTextBox.Focus()

    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripButton.Click
        Me.RecordsBindingSource.CancelEdit()
        setcontrols(True)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        OfficerHomeForm.Show()

    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click

    End Sub

    Private Sub RentTextBox101a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentTextBox101a.TextChanged

    End Sub
End Class