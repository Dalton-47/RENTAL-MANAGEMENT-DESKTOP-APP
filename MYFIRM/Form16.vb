Public Class RegisterTenantForm

    Private Sub setcontrols(ByVal valueboolean As Boolean)
        Tenant_IDTextBox.ReadOnly = valueboolean
        Phone_NOTextBox.ReadOnly = valueboolean
        SurnameTextBox.ReadOnly = valueboolean
        GenderTextBox.ReadOnly = valueboolean
        Other_NameTextBox.ReadOnly = valueboolean
        House_NumberTextBox.ReadOnly = valueboolean
        BindingNavigatorMoveFirstItem.Visible = valueboolean
        BindingNavigatorMoveLastItem.Visible = valueboolean
        BindingNavigatorMoveNextItem.Visible = valueboolean
        BindingNavigatorMovePreviousItem.Visible = valueboolean
        BindingNavigatorPositionItem.Visible = valueboolean
        BindingNavigatorAddNewItem.Enabled = valueboolean
        BindingNavigatorCountItem.Visible = valueboolean
        BindingNavigatorDeleteItem.Enabled = valueboolean
        MyTenantBindingNavigatorSaveItem.Enabled = Not valueboolean




    End Sub

    Private Sub MyTenantBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTenantBindingNavigatorSaveItem.Click
        Try
            Dim mydialog As DialogResult
            mydialog = MessageBox.Show("Are You sure you want to Save this record?", "Microsoft Visual Basic Express", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If mydialog = Windows.Forms.DialogResult.Yes Then
               

                Dim myhouse As String = House_NumberTextBox.Text
                If myhouse.ToUpper = "101A" Then
                    TenantTextBox101A.Text = 2
                    Me.Vacancy101ABindingSource.EndEdit()
                    Me.TableAdapterManager1.UpdateAll(Me.Vacant101ADataSet)

                End If

                If myhouse.ToUpper = "101B" Then
                    TenantTextBox101B.Text = 2
                    Me.Vacancy101BBindingSource.EndEdit()
                    Me.TableAdapterManager2.UpdateAll(Me.Vacant101BDataSet)
                End If

                If myhouse.ToUpper = "101C" Then
                    TenantTextBox101C.Text = 2
                    Me.Vacancy101CBindingSource.EndEdit()
                    Me.TableAdapterManager3.UpdateAll(Me.Vacant101CDataSet)
                End If

                If myhouse.ToUpper = "202A" Then
                    TenantTextBox202A.Text = "2"
                    Me.Vacancy202ABindingSource.EndEdit()
                    Me.TableAdapterManager4.UpdateAll(Me.Vacant202ADataSet)
                End If

                If myhouse.ToUpper = "202B" Then
                    TenantTextBox202B.Text = 2
                    Me.VacancyB202BindingSource.EndEdit()
                    Me.TableAdapterManager10.UpdateAll(Me.VacantB202DataSet)
                End If

                If myhouse.ToUpper = "303A" Then
                    TenantTextBox303A.Text = 2
                    Me.Vacancy303ABindingSource.EndEdit()
                    Me.TableAdapterManager5.UpdateAll(Me.Vacant303ADataSet)
                End If

                If myhouse.ToUpper = "303B" Then
                    TenantTextBox303B.Text = 2
                    Me.Vacancy303BBindingSource.EndEdit()
                    Me.TableAdapterManager6.UpdateAll(Me.Vacant303BDataSet)
                End If

                If myhouse.ToUpper = "404A" Then
                    TenantTextBox404A.Text = 2
                    Me.Vacancy404ABindingSource.EndEdit()
                    Me.TableAdapterManager7.UpdateAll(Me.Vacant404ADataSet)
                End If

                If myhouse.ToUpper = "505A" Then
                    TenantTextBox505A.Text = 2
                    Me.Vacancy505ABindingSource.EndEdit()
                    Me.TableAdapterManager8.UpdateAll(Me.Vacant505ADataSet)
                End If

                If myhouse.ToUpper = "505B" Then
                    TenantTextBox505B.Text = 2
                    Me.Vacancy505BBindingSource.EndEdit()
                    Me.TableAdapterManager9.UpdateAll(Me.Vacant505BDataSet)
                End If
                Dim read As String = Other_NameTextBox.Text.ToLower + " is now considered a tenant at Matata Agency"
                Dim message As String = read
                Dim SAPI As Object
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak(message)
                Me.Validate()
                Me.MyTenantBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TenantInformationDataSet)
                MessageBox.Show("DATA SAVED SUCCESSFULLY", "VISUAL BASIC 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tenant_IDTextBox.Focus()
                setcontrols(True)
            ElseIf mydialog = Windows.Forms.DialogResult.No Then
                Tenant_IDTextBox.Text = ""
                Phone_NOTextBox.Text = ""
                SurnameTextBox.Text = ""
                GenderTextBox.Text = ""
                Other_NameTextBox.Text = ""
                House_NumberTextBox.Text = ""

                While Tenant_IDTextBox.Text = String.Empty
                    TenantInformationDataSet.RejectChanges()
                    MyTenantBindingSource.EndEdit()
                End While
                MessageBox.Show("Data Not Saved", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Error During Save Operation"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try


    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'TenantInformationDataSet.MyTenant' table. You can move, or remove it, as needed.
            Me.MyTenantTableAdapter.Fill(Me.TenantInformationDataSet.MyTenant)
            'TODO: This line of code loads data into the 'VacantB202DataSet.VacancyB202' table. You can move, or remove it, as needed.
            Me.VacancyB202TableAdapter.Fill(Me.VacantB202DataSet.VacancyB202)
            'TODO: This line of code loads data into the 'Vacant505BDataSet.Vacancy505B' table. You can move, or remove it, as needed.
            Me.Vacancy505BTableAdapter.Fill(Me.Vacant505BDataSet.Vacancy505B)
            'TODO: This line of code loads data into the 'Vacant505ADataSet.Vacancy505A' table. You can move, or remove it, as needed.
            Me.Vacancy505ATableAdapter.Fill(Me.Vacant505ADataSet.Vacancy505A)
            'TODO: This line of code loads data into the 'Vacant404ADataSet.Vacancy404A' table. You can move, or remove it, as needed.
            Me.Vacancy404ATableAdapter.Fill(Me.Vacant404ADataSet.Vacancy404A)
            'TODO: This line of code loads data into the 'Vacant303BDataSet.Vacancy303B' table. You can move, or remove it, as needed.
            Me.Vacancy303BTableAdapter.Fill(Me.Vacant303BDataSet.Vacancy303B)
            'TODO: This line of code loads data into the 'Vacant303ADataSet.Vacancy303A' table. You can move, or remove it, as needed.
            Me.Vacancy303ATableAdapter.Fill(Me.Vacant303ADataSet.Vacancy303A)
            'TODO: This line of code loads data into the 'Vacant202ADataSet.Vacancy202A' table. You can move, or remove it, as needed.
            Me.Vacancy202ATableAdapter.Fill(Me.Vacant202ADataSet.Vacancy202A)
            'TODO: This line of code loads data into the 'Vacant101CDataSet.Vacancy101C' table. You can move, or remove it, as needed.
            Me.Vacancy101CTableAdapter.Fill(Me.Vacant101CDataSet.Vacancy101C)
            'TODO: This line of code loads data into the 'Vacant101BDataSet.Vacancy101B' table. You can move, or remove it, as needed.
            Me.Vacancy101BTableAdapter.Fill(Me.Vacant101BDataSet.Vacancy101B)
            'TODO: This line of code loads data into the 'Vacant101ADataSet.Vacancy101A' table. You can move, or remove it, as needed.
            Me.Vacancy101ATableAdapter.Fill(Me.Vacant101ADataSet.Vacancy101A)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TenantTextBox101A.Visible = False
        TenantTextBox101B.Hide()
        TenantTextBox101C.Hide()
        TenantTextBox202A.Hide()
        TenantTextBox202B.Hide()
        TenantTextBox303A.Hide()
        TenantTextBox303B.Hide()
        TenantTextBox404A.Hide()
        TenantTextBox505A.Hide()
        TenantTextBox505B.Hide()

        setcontrols(True)


    End Sub

    Private Sub House_NumberLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Other_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SurnameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Phone_NOLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tenant_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Phone_NOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Phone_NOTextBox.TextChanged

    End Sub

    Private Sub GenderLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Other_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Other_NameTextBox.TextChanged

    End Sub

    Private Sub GenderTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tenant_IDTextBox.Focus()
        setcontrols(False)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            Dim mydialog As DialogResult
            mydialog = MessageBox.Show("Are You sure you want to delete this record?", "Microsoft Visual Basic Express", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If mydialog = Windows.Forms.DialogResult.Yes Then
                MyTenantBindingSource.RemoveCurrent()
                MyTenantBindingSource.EndEdit()
                MyTenantTableAdapter.Update(TenantInformationDataSet.MyTenant)
                Me.TableAdapterManager.UpdateAll(Me.TenantInformationDataSet)
                setcontrols(True)
                MessageBox.Show("Tenant Record Deleted Successfully", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tenant_IDTextBox.Focus()
            Else
                Me.TableAdapterManager.UpdateAll(Me.TenantInformationDataSet)
            End If
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        setcontrols(False)
        BindingNavigatorDeleteItem.Enabled = True

        Tenant_IDTextBox.Focus()


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.MyTenantBindingSource.CancelEdit()
        setcontrols(True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        OfficerHomeForm.Show()

    End Sub
End Class