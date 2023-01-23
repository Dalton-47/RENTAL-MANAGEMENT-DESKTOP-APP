Public Class VacantHousesForm

    Private Sub Vacancy101ABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vacancy101ABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vacancy101ABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vacant101ADataSet)

    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'TODO: This line of code loads data into the 'VacantB202DataSet.VacancyB202' table. You can move, or remove it, as needed.
        Me.VacancyB202TableAdapter.Fill(Me.VacantB202DataSet.VacancyB202)
        'TODO: This line of code loads data into the 'Vacant202ADataSet.Vacancy202A' table. You can move, or remove it, as needed.
        Me.Vacancy202ATableAdapter.Fill(Me.Vacant202ADataSet.Vacancy202A)
        'TODO: This line of code loads data into the 'Vacant101CDataSet.Vacancy101C' table. You can move, or remove it, as needed.
        Me.Vacancy101CTableAdapter.Fill(Me.Vacant101CDataSet.Vacancy101C)
        'TODO: This line of code loads data into the 'Vacant101BDataSet.Vacancy101B' table. You can move, or remove it, as needed.
        Me.Vacancy101BTableAdapter.Fill(Me.Vacant101BDataSet.Vacancy101B)
        'TODO: This line of code loads data into the 'Vacant101ADataSet.Vacancy101A' table. You can move, or remove it, as needed.
        Me.Vacancy101ATableAdapter.Fill(Me.Vacant101ADataSet.Vacancy101A)
        TenantTextBox101A.Visible = False
        TenantTextBox101B.Visible = False
        TenantTextBox101C.Visible = False
        TenantTextBox202A.Visible = False
        TenantTextBoxB202.Visible = False
        TenantTextBox303A.Visible = False
        TenantTextBox303B.Visible = False
        TenantTextBox404A.Visible = False
        TenantTextBox505A.Visible = False
        TenantTextBox505B.Visible = False
        MyLabel.Visible = True
        MyButton.Visible = True
        Button1.Visible = False
        ListBox1.Visible = False
        MynameLabel.Visible = True
    End Sub

    Private Sub MyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton.Click
        Dim house101a As Integer = TenantTextBox101A.Text
        Dim house101b As Integer = TenantTextBox101B.Text
        Dim house101c As Integer = TenantTextBox101C.Text
        Dim house202a As Integer = TenantTextBox202A.Text
        Dim house202b As Integer = TenantTextBoxB202.Text
        Dim house303a As Integer = TenantTextBox303A.Text
        Dim house303b As Integer = TenantTextBox303B.Text
        Dim house404a As Integer = TenantTextBox404A.Text
        Dim house505a As Integer = TenantTextBox505A.Text
        Dim house505b As Integer = TenantTextBox505B.Text
        Dim emptystring As String = ""


        If house101a = 1 Then
            ListBox1.Items.Add("House101A Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house101b = 1 Then
            ListBox1.Items.Add("House101B Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house101c = 1 Then
            ListBox1.Items.Add("House101C Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house202a = 1 Then
            ListBox1.Items.Add("House202A Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house202b = 1 Then
            ListBox1.Items.Add("House202B Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house303a = 1 Then
            ListBox1.Items.Add("House303A Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house303b = 1 Then
            ListBox1.Items.Add("House303B Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house404a = 1 Then
            ListBox1.Items.Add("House404A Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house505a = 1 Then
            ListBox1.Items.Add("House505A Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        If house505b = 1 Then
            ListBox1.Items.Add("House505B Is NOT Occupied")
            ListBox1.Items.Add(emptystring)
        End If
        MyLabel.Visible = False
        MyButton.Visible = False
        Button1.Visible = True
        ListBox1.Visible = True
        MynameLabel.Visible = False





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class