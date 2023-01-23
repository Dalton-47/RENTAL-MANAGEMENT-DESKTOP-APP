Public Class ManagerloginForm


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ManagerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ManagerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ManagerpinDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()

        'TODO: This line of code loads data into the 'ManagerpinDataSet.Manager' table. You can move, or remove it, as needed.
        Try
            Me.ManagerTableAdapter.Fill(Me.ManagerpinDataSet.Manager)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft Visual Basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ListBox1.Visible = False
        ListBox2.Visible = False


        If ListBox1.Text <> String.Empty Then
            My.Settings.mystring = ListBox1.Text.ToString
            My.Settings.Save()

        End If




    End Sub

    Private Sub ManagerBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerBindingNavigator.RefreshItems

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = 0
        Dim b As Integer = 0


        If UsernameTextBox.Text.ToUpper = ListBox1.Text.ToUpper Then
            a = 1
        End If
        If PasswordTextBox.Text = ListBox2.Text Then
            b = 1

        End If
        If a + b = 2 Then
            MessageBox.Show("Login successful", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UsernameTextBox.Text = String.Empty
            PasswordTextBox.Text = String.Empty
            Me.Hide()
            ManagerHomeForm.Show()

        ElseIf UsernameTextBox.Text.ToUpper <> ListBox1.Text.ToUpper Or PasswordTextBox.Text <> ListBox2.Text Or UsernameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then

            MessageBox.Show("Please input correct credentials", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Text = String.Empty
            PasswordTextBox.Text = String.Empty

        End If
    End Sub
End Class