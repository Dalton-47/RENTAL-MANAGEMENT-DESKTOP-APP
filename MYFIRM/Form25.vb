﻿Public Class OfficerPinForm25



    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficerpinDataSet.Officer' table. You can move, or remove it, as needed.
        Me.OfficerTableAdapter.Fill(Me.OfficerpinDataSet.Officer)
        Try
            'TODO: This line of code loads data into the 'ManagerpinDataSet.Manager' table. You can move, or remove it, as needed.
            Me.OfficerTableAdapter.Fill(Me.OfficerpinDataSet.Officer)
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UsernameLabel.Visible = True
        PasswordLabel.Visible = True
        UsernameTextBox.Visible = True
        PasswordTextBox.Visible = True
        Button1.Visible = True


        NewLabel1.Visible = False
        NewLabel2.Visible = False
        NewLabel3.Visible = False
        NewTextBox1.Visible = False
        NewTextBox2.Visible = False
        NewconfirmTextBox3.Visible = False
        myNewButton1.Visible = False


        OfficernameTextBox.Visible = False
        MypinTextBox.Visible = False
        myHelpButton.Visible = False

    End Sub

    Private Sub myNewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myNewButton1.Click
        Try
            Dim password As Integer = NewTextBox2.Text
            Dim confirm As Integer = NewconfirmTextBox3.Text
            Dim username As String = NewTextBox1.Text
            If NewTextBox1.Text <> String.Empty And NewTextBox2.Text <> String.Empty And NewTextBox2.Text = NewconfirmTextBox3.Text And NewTextBox2.Text = password And NewconfirmTextBox3.Text = confirm Then
                Try
                    OfficernameTextBox.Text = username
                    MypinTextBox.Text = confirm

                    Me.OfficerBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.OfficerpinDataSet)
                    Dim message As String = "Database Records are updated successfully"
                    Dim SAPI As Object
                    SAPI = CreateObject("SAPI.spvoice")
                    SAPI.speak(message)
                    NewTextBox1.ReadOnly = True
                    NewTextBox2.ReadOnly = True
                    NewconfirmTextBox3.ReadOnly = True

                    MessageBox.Show("Username and Pin Set Successfully", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    OfficerHomeForm.Show()

                Catch ex As Exception
                    MessageBox.Show("AN Unknown Error has occurred.Please Contact System Administrator", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                MessageBox.Show("Ensure The Pins are Matched", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Catch ex As Exception
            MessageBox.Show("Please Ensure You Follow The Rules stated To set New Login Credentials", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UsernameTextBox.Text.Trim.ToUpper = OfficernameTextBox.Text.Trim.ToUpper And PasswordTextBox.Text = MypinTextBox.Text Then
            Dim myresult As DialogResult

            myresult = MessageBox.Show("Press OK To Proceed", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If myresult = Windows.Forms.DialogResult.OK Then
                UsernameLabel.Visible = False
                PasswordLabel.Visible = False
                UsernameTextBox.Visible = False
                PasswordTextBox.Visible = False
                Button1.Visible = False


                NewLabel1.Visible = True
                NewLabel2.Visible = True
                NewLabel3.Visible = True
                NewTextBox1.Visible = True
                NewTextBox2.Visible = True
                NewconfirmTextBox3.Visible = True
                myNewButton1.Visible = True
                myHelpButton.Visible = True
                NewTextBox1.Focus()
            Else
                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty

                MessageBox.Show("Either The Password Or Username is incorrect", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Either The Password Or Username is incorrect", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

   

    Private Sub myHelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myHelpButton.Click
        Dim message As String = "Avoid Spaces Between characters in Username and Pin ,     The Pin should be 4-digit with Numbers Only"
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(message)

        MessageBox.Show("Avoid Spaces Between characters in Username and Pin , The Pin should be 4-digit with Numbers Only,", "Microsoft Visual Basic Express", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub OfficerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.OfficerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OfficerpinDataSet)

    End Sub
End Class