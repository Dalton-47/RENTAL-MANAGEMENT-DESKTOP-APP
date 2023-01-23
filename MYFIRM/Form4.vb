Public Class ReceptionistloginForm

    Private Sub ReceptionistBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceptionistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceptionistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReceptionistpinDataSet)

    End Sub

    Private Sub Receptionistlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceptionistpinDataSet.Receptionist' table. You can move, or remove it, as needed.


        Try
            UsernameTextBox.Focus()
            Me.ReceptionistTableAdapter.Fill(Me.ReceptionistpinDataSet.Receptionist)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        ListBox1.Visible = False
        ListBox2.Visible = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer



        If UsernameTextBox.Text <> String.Empty And PasswordTextBox.Text <> String.Empty Then
            If UsernameTextBox.Text.ToUpper.Trim = ListBox1.Text.ToUpper.Trim Then
                a = 1

            End If
            If PasswordTextBox.Text = ListBox2.Text Then
                b = 1

            End If
            If a + b = 2 Then
                MessageBox.Show("LOGIN WAS SUCCESSFUL", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty

            ElseIf UsernameTextBox.Text.ToUpper <> ListBox1.Text.ToUpper Or PasswordTextBox.Text <> ListBox2.Text Or UsernameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then


                MessageBox.Show("Please input correct credentials", "Microsoft Visual Basic 2010", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty
            End If
        End If
        Me.Hide()
        ReceptionistForm.Show()

    End Sub
End Class