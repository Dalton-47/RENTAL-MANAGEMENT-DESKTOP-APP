Public Class Form15

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CashboxdatabaseDataSet.Cashtablebox' table. You can move, or remove it, as needed.
        Me.CashtableboxTableAdapter.Fill(Me.CashboxdatabaseDataSet.Cashtablebox)
        'TODO: This line of code loads data into the 'CashboxdatabaseDataSet.Cashtablebox' table. You can move, or remove it, as needed.
        Me.CashtableboxTableAdapter.Fill(Me.CashboxdatabaseDataSet.Cashtablebox)
        Try
            'TODO: This line of code loads data into the 'NewHouse101CDataSet._101C' table. You can move, or remove it, as needed.
            Me._101CTableAdapter.Fill(Me.NewHouse101CDataSet._101C)
            'TODO: This line of code loads data into the 'NewHouse101BDataSet._101B' table. You can move, or remove it, as needed.
            Me._101BTableAdapter.Fill(Me.NewHouse101BDataSet._101B)
            'TODO: This line of code loads data into the 'NewHouse101ADataSet._101A' table. You can move, or remove it, as needed.
            Me._101ATableAdapter.Fill(Me.NewHouse101ADataSet._101A)
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
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic 2010"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
        CashTextBox.Visible = False

       
        TotalTextBox.Hide()
        BackButton.Hide()



    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub _202ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me._202ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.House202ADataSet)

    End Sub

    Private Sub RentTextBox202A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mystring As String
        Dim mycash As Integer = CashTextBox.Text




        Dim Total As Integer
        Total = mycash
        mystring = "Current Balance = Ksh." + Total.ToString
        TotalTextBox.Text = mystring

        Dim mydate As String
        mydate = Date.Now.ToString("dd")


        If mydate = "01" Then
            CashTextBox.Text = 1

        End If

        Me.CashtableboxBindingSource.EndEdit()
        Me.TableAdapterManager10.UpdateAll(Me.CashboxdatabaseDataSet)
       


        TotalTextBox.Show()
        BackButton.Show()


    End Sub

    Private Sub BalanceLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       






    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        BackButton.Hide()
        TotalTextBox.Hide()

        Me.Hide()
        ManagerHomeForm.Show()

    End Sub

    Private Sub TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalTextBox.TextChanged

    End Sub

    Private Sub RENTTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashTextBox.TextChanged

    End Sub
End Class