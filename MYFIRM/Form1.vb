Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ManagerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerCheckBox.CheckedChanged
        Me.Hide()
        ManagerloginForm.Show()

    End Sub

    Private Sub OfficerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficerCheckBox.CheckedChanged
        Me.Hide()
        OfficerloginForm.Show()


    End Sub

    Private Sub ReceptionistCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceptionistCheckBox.CheckedChanged
        Me.Hide()
        ReceptionistloginForm.Show()

    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
