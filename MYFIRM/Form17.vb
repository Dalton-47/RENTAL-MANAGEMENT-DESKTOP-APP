Public Class HistoryForm

    Private Sub RecordsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyRecordsDataSet)

    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'MyRecordsDataSet.Records' table. You can move, or remove it, as needed.
            Me.RecordsTableAdapter.Fill(Me.MyRecordsDataSet.Records)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        HouseNameTextBox.ReadOnly = True
        RentTextBox.ReadOnly = True
        MyDateTextBox.ReadOnly = True
        MPESATransactionNumberTextBox.ReadOnly = True


    End Sub

    Private Sub RentLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MyDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class