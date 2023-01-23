Public Class myRecordsForm19

    Private Sub MyTenantBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTenantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MyTenantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TenantInformationDataSet)

    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'TenantInformationDataSet.MyTenant' table. You can move, or remove it, as needed.
            Me.MyTenantTableAdapter.Fill(Me.TenantInformationDataSet.MyTenant)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Tenant_IDTextBox.ReadOnly = True
        Phone_NOTextBox.ReadOnly = True
        SurnameTextBox.ReadOnly = True
        Other_NameTextBox.ReadOnly = True
        GenderTextBox.ReadOnly = True
        House_NumberTextBox.ReadOnly = True


    End Sub

    Private Sub SurnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurnameTextBox.TextChanged

    End Sub

    Private Sub Other_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GenderLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class