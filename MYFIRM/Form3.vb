Public Class OfficerloginForm


    Private Sub OfficerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OfficerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OfficerpinDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficerpinDataSet.Officer' table. You can move, or remove it, as needed.
        Try
            Me.OfficerTableAdapter.Fill(Me.OfficerpinDataSet.Officer)

        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        ListBox1.Visible = False
        ListBox2.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer

        If UsernameTextBox.Text <> String.Empty And PasswordTextBox.Text <> String.Empty Then
            If UsernameTextBox.Text.Trim.ToUpper = ListBox1.Text.Trim.ToUpper Then
                a = 1

            End If
            If PasswordTextBox.Text = ListBox2.Text Then
                b = 1

            End If
            If a + b = 2 Then
                MessageBox.Show("LOGIN WAS SUCCESSFUL", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)

                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty
                Me.Hide()
                OfficerHomeForm.Show()

            ElseIf UsernameTextBox.Text.ToUpper <> ListBox1.Text.ToUpper Or PasswordTextBox.Text <> ListBox2.Text Or UsernameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then

                MessageBox.Show("Please input correct credentials", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty
            End If
        End If
    End Sub
End Class