<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmallIncomeSetRentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EntryTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me._101ABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewHouse101ADataSet = New WindowsApplication1.NewHouse101ADataSet()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me._101BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewHouse101BDataSet = New WindowsApplication1.NewHouse101BDataSet()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me._101CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewHouse101CDataSet = New WindowsApplication1.NewHouse101CDataSet()
        Me._101ATableAdapter = New WindowsApplication1.NewHouse101ADataSetTableAdapters._101ATableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBoxA = New System.Windows.Forms.TextBox()
        Me._101BTableAdapter = New WindowsApplication1.NewHouse101BDataSetTableAdapters._101BTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBoxB = New System.Windows.Forms.TextBox()
        Me._101CTableAdapter = New WindowsApplication1.NewHouse101CDataSetTableAdapters._101CTableAdapter()
        Me.TableAdapterManager2 = New WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBoxC = New System.Windows.Forms.TextBox()
        Me._101ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._101CBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._101CBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vacant101ADataSet = New WindowsApplication1.Vacant101ADataSet()
        Me.Vacancy101ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101ATableAdapter = New WindowsApplication1.Vacant101ADataSetTableAdapters.Vacancy101ATableAdapter()
        Me.TableAdapterManager3 = New WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101A = New System.Windows.Forms.TextBox()
        Me.Vacant101BDataSet = New WindowsApplication1.Vacant101BDataSet()
        Me.Vacancy101BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101BTableAdapter = New WindowsApplication1.Vacant101BDataSetTableAdapters.Vacancy101BTableAdapter()
        Me.TableAdapterManager4 = New WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101B = New System.Windows.Forms.TextBox()
        Me.Vacant101CDataSet = New WindowsApplication1.Vacant101CDataSet()
        Me.Vacancy101CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101CTableAdapter = New WindowsApplication1.Vacant101CDataSetTableAdapters.Vacancy101CTableAdapter()
        Me.TableAdapterManager5 = New WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101C = New System.Windows.Forms.TextBox()
        CType(Me._101ABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHouse101ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHouse101BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHouse101CDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101CBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101CBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant101ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant101BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant101CDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(759, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rent For Small Income Estate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Amount Below To Apply In The Upcoming Month"
        '
        'EntryTextBox
        '
        Me.EntryTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryTextBox.Location = New System.Drawing.Point(586, 331)
        Me.EntryTextBox.Multiline = True
        Me.EntryTextBox.Name = "EntryTextBox"
        Me.EntryTextBox.Size = New System.Drawing.Size(192, 46)
        Me.EntryTextBox.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SaveButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(838, 411)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(146, 42)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me._101ABindingSource1, "Rent", True))
        Me.ListBox1.DataSource = Me._101ABindingSource1
        Me.ListBox1.DisplayMember = "Rent"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 69)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.ValueMember = "Rent"
        '
        '_101ABindingSource1
        '
        Me._101ABindingSource1.DataMember = "101A"
        Me._101ABindingSource1.DataSource = Me.NewHouse101ADataSet
        '
        'NewHouse101ADataSet
        '
        Me.NewHouse101ADataSet.DataSetName = "NewHouse101ADataSet"
        Me.NewHouse101ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox2
        '
        Me.ListBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me._101BBindingSource, "Rent", True))
        Me.ListBox2.DataSource = Me._101BBindingSource
        Me.ListBox2.DisplayMember = "Rent"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 178)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 69)
        Me.ListBox2.TabIndex = 5
        Me.ListBox2.ValueMember = "Rent"
        '
        '_101BBindingSource
        '
        Me._101BBindingSource.DataMember = "101B"
        Me._101BBindingSource.DataSource = Me.NewHouse101BDataSet
        '
        'NewHouse101BDataSet
        '
        Me.NewHouse101BDataSet.DataSetName = "NewHouse101BDataSet"
        Me.NewHouse101BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox3
        '
        Me.ListBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me._101CBindingSource, "Rent", True))
        Me.ListBox3.DataSource = Me._101CBindingSource
        Me.ListBox3.DisplayMember = "Rent"
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(12, 308)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 69)
        Me.ListBox3.TabIndex = 6
        Me.ListBox3.ValueMember = "Rent"
        '
        '_101CBindingSource
        '
        Me._101CBindingSource.DataMember = "101C"
        Me._101CBindingSource.DataSource = Me.NewHouse101CDataSet
        '
        'NewHouse101CDataSet
        '
        Me.NewHouse101CDataSet.DataSetName = "NewHouse101CDataSet"
        Me.NewHouse101CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_101ATableAdapter
        '
        Me._101ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._101ATableAdapter = Me._101ATableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBoxA
        '
        Me.RentTextBoxA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101ABindingSource1, "Rent", True))
        Me.RentTextBoxA.Location = New System.Drawing.Point(12, 31)
        Me.RentTextBoxA.Name = "RentTextBoxA"
        Me.RentTextBoxA.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBoxA.TabIndex = 9
        '
        '_101BTableAdapter
        '
        Me._101BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1._101BTableAdapter = Me._101BTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBoxB
        '
        Me.RentTextBoxB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101BBindingSource, "Rent", True))
        Me.RentTextBoxB.Location = New System.Drawing.Point(12, 152)
        Me.RentTextBoxB.Name = "RentTextBoxB"
        Me.RentTextBoxB.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBoxB.TabIndex = 11
        '
        '_101CTableAdapter
        '
        Me._101CTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2._101CTableAdapter = Me._101CTableAdapter
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBoxC
        '
        Me.RentTextBoxC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101CBindingSource, "Rent", True))
        Me.RentTextBoxC.Location = New System.Drawing.Point(12, 284)
        Me.RentTextBoxC.Name = "RentTextBoxC"
        Me.RentTextBoxC.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBoxC.TabIndex = 13
        '
        '_101ABindingSource
        '
        Me._101ABindingSource.DataMember = "101A"
        Me._101ABindingSource.DataSource = Me.NewHouse101ADataSet
        '
        '_101CBindingSource1
        '
        Me._101CBindingSource1.DataMember = "101C"
        Me._101CBindingSource1.DataSource = Me.NewHouse101CDataSet
        '
        '_101CBindingSource2
        '
        Me._101CBindingSource2.DataMember = "101C"
        Me._101CBindingSource2.DataSource = Me.NewHouse101CDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(415, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 42)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Vacant101ADataSet
        '
        Me.Vacant101ADataSet.DataSetName = "Vacant101ADataSet"
        Me.Vacant101ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy101ABindingSource
        '
        Me.Vacancy101ABindingSource.DataMember = "Vacancy101A"
        Me.Vacancy101ABindingSource.DataSource = Me.Vacant101ADataSet
        '
        'Vacancy101ATableAdapter
        '
        Me.Vacancy101ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.UpdateOrder = WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.Vacancy101ATableAdapter = Me.Vacancy101ATableAdapter
        '
        'TenantTextBox101A
        '
        Me.TenantTextBox101A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101ABindingSource, "Tenant", True))
        Me.TenantTextBox101A.Location = New System.Drawing.Point(138, 57)
        Me.TenantTextBox101A.Name = "TenantTextBox101A"
        Me.TenantTextBox101A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101A.TabIndex = 19
        '
        'Vacant101BDataSet
        '
        Me.Vacant101BDataSet.DataSetName = "Vacant101BDataSet"
        Me.Vacant101BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy101BBindingSource
        '
        Me.Vacancy101BBindingSource.DataMember = "Vacancy101B"
        Me.Vacancy101BBindingSource.DataSource = Me.Vacant101BDataSet
        '
        'Vacancy101BTableAdapter
        '
        Me.Vacancy101BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.UpdateOrder = WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager4.Vacancy101BTableAdapter = Me.Vacancy101BTableAdapter
        '
        'TenantTextBox101B
        '
        Me.TenantTextBox101B.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101BBindingSource, "Tenant", True))
        Me.TenantTextBox101B.Location = New System.Drawing.Point(138, 178)
        Me.TenantTextBox101B.Name = "TenantTextBox101B"
        Me.TenantTextBox101B.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101B.TabIndex = 20
        '
        'Vacant101CDataSet
        '
        Me.Vacant101CDataSet.DataSetName = "Vacant101CDataSet"
        Me.Vacant101CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy101CBindingSource
        '
        Me.Vacancy101CBindingSource.DataMember = "Vacancy101C"
        Me.Vacancy101CBindingSource.DataSource = Me.Vacant101CDataSet
        '
        'Vacancy101CTableAdapter
        '
        Me.Vacancy101CTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.UpdateOrder = WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager5.Vacancy101CTableAdapter = Me.Vacancy101CTableAdapter
        '
        'TenantTextBox101C
        '
        Me.TenantTextBox101C.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101CBindingSource, "Tenant", True))
        Me.TenantTextBox101C.Location = New System.Drawing.Point(138, 308)
        Me.TenantTextBox101C.Name = "TenantTextBox101C"
        Me.TenantTextBox101C.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101C.TabIndex = 21
        '
        'SmallIncomeSetRentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.IMG_20200812_165939
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1103, 473)
        Me.Controls.Add(Me.TenantTextBox101C)
        Me.Controls.Add(Me.TenantTextBox101B)
        Me.Controls.Add(Me.TenantTextBox101A)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RentTextBoxC)
        Me.Controls.Add(Me.RentTextBoxB)
        Me.Controls.Add(Me.RentTextBoxA)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EntryTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SmallIncomeSetRentForm"
        Me.Text = "Small Income Estate"
        CType(Me._101ABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHouse101ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHouse101BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHouse101CDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101CBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101CBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant101ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant101BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant101CDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EntryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents NewHouse101ADataSet As WindowsApplication1.NewHouse101ADataSet
    Friend WithEvents _101ATableAdapter As WindowsApplication1.NewHouse101ADataSetTableAdapters._101ATableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents _101ABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RentTextBoxA As System.Windows.Forms.TextBox
    Friend WithEvents NewHouse101BDataSet As WindowsApplication1.NewHouse101BDataSet
    Friend WithEvents _101BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101BTableAdapter As WindowsApplication1.NewHouse101BDataSetTableAdapters._101BTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBoxB As System.Windows.Forms.TextBox
    Friend WithEvents NewHouse101CDataSet As WindowsApplication1.NewHouse101CDataSet
    Friend WithEvents _101CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101CTableAdapter As WindowsApplication1.NewHouse101CDataSetTableAdapters._101CTableAdapter
    Friend WithEvents TableAdapterManager2 As WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBoxC As System.Windows.Forms.TextBox
    Friend WithEvents _101ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101CBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents _101CBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Vacant101ADataSet As WindowsApplication1.Vacant101ADataSet
    Friend WithEvents Vacancy101ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101ATableAdapter As WindowsApplication1.Vacant101ADataSetTableAdapters.Vacancy101ATableAdapter
    Friend WithEvents TableAdapterManager3 As WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant101BDataSet As WindowsApplication1.Vacant101BDataSet
    Friend WithEvents Vacancy101BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101BTableAdapter As WindowsApplication1.Vacant101BDataSetTableAdapters.Vacancy101BTableAdapter
    Friend WithEvents TableAdapterManager4 As WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101B As System.Windows.Forms.TextBox
    Friend WithEvents Vacant101CDataSet As WindowsApplication1.Vacant101CDataSet
    Friend WithEvents Vacancy101CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101CTableAdapter As WindowsApplication1.Vacant101CDataSetTableAdapters.Vacancy101CTableAdapter
    Friend WithEvents TableAdapterManager5 As WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101C As System.Windows.Forms.TextBox
End Class
