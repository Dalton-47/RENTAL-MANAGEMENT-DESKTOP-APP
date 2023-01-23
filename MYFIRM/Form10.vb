Public Class Defaultersform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton.Click
        Dim rent101a As String = RentTextBox101A.Text
        Dim rent101b As String = RentTextBox101B.Text
        Dim rent101c As String = RentTextBox101C.Text
        Dim rent202a As String = RentTextBox202A.Text
        Dim rent202b As String = RentTextBox202B.Text
        Dim rent303a As String = RentTextBox303A.Text
        Dim rent303b As String = RentTextBox303B.Text
        Dim rent404a As String = RentTextBox404A.Text
        Dim rent505a As String = RentTextBox505A.Text
        Dim rent505b As String = RentTextBox505B.Text

        Dim balance101a As String = " House101A  Rent  To  Pay = " & rent101a
        Dim balance101b As String = " House101B  Rent  To  Pay = " & rent101b
        Dim balance101c As String = " House101C  Rent  To  Pay = " & rent101c
        Dim balance202a As String = " House202A  Rent  To  Pay = " & rent202a
        Dim balance202b As String = " House202B  Rent  To  Pay = " & rent202b
        Dim balance303a As String = " House303A  Rent  To  Pay = " & rent303a
        Dim balance303b As String = " House303B  Rent  To  Pay = " & rent303b
        Dim balance404a As String = " House404A  Rent  To  Pay = " & rent404a
        Dim balance505a As String = " House505A  Rent  To  Pay = " & rent505a
        Dim balance505b As String = " House505B  Rent  To  Pay = " & rent505b



        Dim house101a As Integer = RentTextBox101A.Text
        Dim house101b As Integer = RentTextBox101B.Text
        Dim house101c As Integer = RentTextBox101C.Text
        Dim house202a As Integer = RentTextBox202A.Text
        Dim house202b As Integer = RentTextBox202B.Text
        Dim house303a As Integer = RentTextBox303A.Text
        Dim house303b As Integer = RentTextBox303B.Text
        Dim house404a As Integer = RentTextBox404A.Text
        Dim house505a As Integer = RentTextBox505A.Text
        Dim house505b As Integer = RentTextBox505B.Text
        Dim nullstring As String = ""


        If house101a < -200 Then

            ListBox1.Items.Add(balance101a)
            ListBox1.Items.Add(nullstring)
        End If
        If house101b < -200 Then
            ListBox1.Items.Add(balance101b)
            ListBox1.Items.Add(nullstring)
        End If
        If house101c < -200 Then
            ListBox1.Items.Add(balance101c)
            ListBox1.Items.Add(nullstring)
        End If
        If house202a < -200 Then
            ListBox1.Items.Add(balance202a)
            ListBox1.Items.Add(nullstring)
        End If
        If house202b < -200 Then
            ListBox1.Items.Add(balance202b)
            ListBox1.Items.Add(nullstring)
        End If
        If house303a < -200 Then
            ListBox1.Items.Add(balance303a)
            ListBox1.Items.Add(nullstring)
        End If
        If house303b < -200 Then
            ListBox1.Items.Add(balance303b)
            ListBox1.Items.Add(nullstring)
        End If
        If house404a < -200 Then
            ListBox1.Items.Add(balance404a)
            ListBox1.Items.Add(nullstring)
        End If
        If house505a < -200 Then
            ListBox1.Items.Add(balance505a)
            ListBox1.Items.Add(nullstring)
        End If
        If house505b < -200 Then
            ListBox1.Items.Add(balance505b)
            ListBox1.Items.Add(nullstring)
        End If
        If house101a > 0 And house101b > 0 And house101c > 0 And house202a > 0 And house202b > 0 And house303a > 0 And house303b > 0 And house404a > 0 And house505a > 0 And house505b > 0 Then
            Dim mystring As String = "NO DEFAULTERS IN THE SYSTEM"
            ListBox1.Items.Add(mystring)
        End If
        MyLabel.Visible = False
        MyButton.Visible = False
        Button1.Visible = True
        ListBox1.Visible = True
        MynameLabel.Visible = False





    End Sub

    Private Sub _101ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _101ABindingNavigatorSaveItem.Click
        Me.Validate()
        Me._101ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewHouse101ADataSet)

    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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
        Catch ex As Exception

            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Microsoft visual basic Express"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        RentTextBox101A.Visible = False
        RentTextBox101B.Visible = False
        RentTextBox101C.Visible = False
        RentTextBox202A.Visible = False
        RentTextBox202B.Visible = False
        RentTextBox303A.Visible = False
        RentTextBox303B.Visible = False
        RentTextBox404A.Visible = False
        RentTextBox505A.Visible = False
        RentTextBox505B.Visible = False
        MyLabel.Visible = True
        MyButton.Visible = True
        Button1.Visible = False
        ListBox1.Visible = False
        MynameLabel.Visible = True





    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

        Form1.Show()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class