<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterTenantForm
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
        Dim Tenant_IDLabel As System.Windows.Forms.Label
        Dim Phone_NOLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Other_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim House_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterTenantForm))
        Me.TenantInformationDataSet = New WindowsApplication1.TenantInformationDataSet()
        Me.MyTenantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyTenantTableAdapter = New WindowsApplication1.TenantInformationDataSetTableAdapters.MyTenantTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.TenantInformationDataSetTableAdapters.TableAdapterManager()
        Me.MyTenantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MyTenantBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Tenant_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NOTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Other_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.House_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vacant101ADataSet = New WindowsApplication1.Vacant101ADataSet()
        Me.Vacancy101ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101ATableAdapter = New WindowsApplication1.Vacant101ADataSetTableAdapters.Vacancy101ATableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101A = New System.Windows.Forms.TextBox()
        Me.Vacant101BDataSet = New WindowsApplication1.Vacant101BDataSet()
        Me.Vacancy101BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101BTableAdapter = New WindowsApplication1.Vacant101BDataSetTableAdapters.Vacancy101BTableAdapter()
        Me.TableAdapterManager2 = New WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101B = New System.Windows.Forms.TextBox()
        Me.Vacant101CDataSet = New WindowsApplication1.Vacant101CDataSet()
        Me.Vacancy101CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy101CTableAdapter = New WindowsApplication1.Vacant101CDataSetTableAdapters.Vacancy101CTableAdapter()
        Me.TableAdapterManager3 = New WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox101C = New System.Windows.Forms.TextBox()
        Me.Vacant202ADataSet = New WindowsApplication1.Vacant202ADataSet()
        Me.Vacancy202ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy202ATableAdapter = New WindowsApplication1.Vacant202ADataSetTableAdapters.Vacancy202ATableAdapter()
        Me.TableAdapterManager4 = New WindowsApplication1.Vacant202ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox202A = New System.Windows.Forms.TextBox()
        Me.Vacant303ADataSet = New WindowsApplication1.Vacant303ADataSet()
        Me.Vacancy303ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy303ATableAdapter = New WindowsApplication1.Vacant303ADataSetTableAdapters.Vacancy303ATableAdapter()
        Me.TableAdapterManager5 = New WindowsApplication1.Vacant303ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox303A = New System.Windows.Forms.TextBox()
        Me.Vacant303BDataSet = New WindowsApplication1.Vacant303BDataSet()
        Me.Vacancy303BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy303BTableAdapter = New WindowsApplication1.Vacant303BDataSetTableAdapters.Vacancy303BTableAdapter()
        Me.TableAdapterManager6 = New WindowsApplication1.Vacant303BDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox303B = New System.Windows.Forms.TextBox()
        Me.Vacant404ADataSet = New WindowsApplication1.Vacant404ADataSet()
        Me.Vacancy404ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy404ATableAdapter = New WindowsApplication1.Vacant404ADataSetTableAdapters.Vacancy404ATableAdapter()
        Me.TableAdapterManager7 = New WindowsApplication1.Vacant404ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox404A = New System.Windows.Forms.TextBox()
        Me.Vacant505ADataSet = New WindowsApplication1.Vacant505ADataSet()
        Me.Vacancy505ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy505ATableAdapter = New WindowsApplication1.Vacant505ADataSetTableAdapters.Vacancy505ATableAdapter()
        Me.TableAdapterManager8 = New WindowsApplication1.Vacant505ADataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox505A = New System.Windows.Forms.TextBox()
        Me.Vacant505BDataSet = New WindowsApplication1.Vacant505BDataSet()
        Me.Vacancy505BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vacancy505BTableAdapter = New WindowsApplication1.Vacant505BDataSetTableAdapters.Vacancy505BTableAdapter()
        Me.TableAdapterManager9 = New WindowsApplication1.Vacant505BDataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox505B = New System.Windows.Forms.TextBox()
        Me.VacantB202DataSet = New WindowsApplication1.VacantB202DataSet()
        Me.VacancyB202BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacancyB202TableAdapter = New WindowsApplication1.VacantB202DataSetTableAdapters.VacancyB202TableAdapter()
        Me.TableAdapterManager10 = New WindowsApplication1.VacantB202DataSetTableAdapters.TableAdapterManager()
        Me.TenantTextBox202B = New System.Windows.Forms.TextBox()
        Tenant_IDLabel = New System.Windows.Forms.Label()
        Phone_NOLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Other_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        House_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.TenantInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyTenantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyTenantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyTenantBindingNavigator.SuspendLayout()
        CType(Me.Vacant101ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant101BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant101CDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy101CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant202ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy202ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant303ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy303ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant303BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy303BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant404ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy404ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant505ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy505ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacant505BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vacancy505BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacantB202DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacancyB202BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tenant_IDLabel
        '
        Tenant_IDLabel.AutoSize = True
        Tenant_IDLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_IDLabel.Location = New System.Drawing.Point(462, 211)
        Tenant_IDLabel.Name = "Tenant_IDLabel"
        Tenant_IDLabel.Size = New System.Drawing.Size(151, 31)
        Tenant_IDLabel.TabIndex = 1
        Tenant_IDLabel.Text = "Tenant ID:"
        AddHandler Tenant_IDLabel.Click, AddressOf Me.Tenant_IDLabel_Click
        '
        'Phone_NOLabel
        '
        Phone_NOLabel.AutoSize = True
        Phone_NOLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NOLabel.Location = New System.Drawing.Point(462, 259)
        Phone_NOLabel.Name = "Phone_NOLabel"
        Phone_NOLabel.Size = New System.Drawing.Size(150, 31)
        Phone_NOLabel.TabIndex = 3
        Phone_NOLabel.Text = "Phone NO:"
        AddHandler Phone_NOLabel.Click, AddressOf Me.Phone_NOLabel_Click
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(462, 305)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(132, 31)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        AddHandler SurnameLabel.Click, AddressOf Me.SurnameLabel_Click
        '
        'Other_NameLabel
        '
        Other_NameLabel.AutoSize = True
        Other_NameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Other_NameLabel.Location = New System.Drawing.Point(462, 412)
        Other_NameLabel.Name = "Other_NameLabel"
        Other_NameLabel.Size = New System.Drawing.Size(160, 31)
        Other_NameLabel.TabIndex = 7
        Other_NameLabel.Text = "First Name:"
        AddHandler Other_NameLabel.Click, AddressOf Me.Other_NameLabel_Click
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(462, 354)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(112, 31)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "Gender:"
        AddHandler GenderLabel.Click, AddressOf Me.GenderLabel_Click
        '
        'House_NumberLabel
        '
        House_NumberLabel.AutoSize = True
        House_NumberLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NumberLabel.Location = New System.Drawing.Point(462, 461)
        House_NumberLabel.Name = "House_NumberLabel"
        House_NumberLabel.Size = New System.Drawing.Size(150, 31)
        House_NumberLabel.TabIndex = 11
        House_NumberLabel.Text = "House NO:"
        AddHandler House_NumberLabel.Click, AddressOf Me.House_NumberLabel_Click
        '
        'TenantInformationDataSet
        '
        Me.TenantInformationDataSet.DataSetName = "TenantInformationDataSet"
        Me.TenantInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyTenantBindingSource
        '
        Me.MyTenantBindingSource.DataMember = "MyTenant"
        Me.MyTenantBindingSource.DataSource = Me.TenantInformationDataSet
        '
        'MyTenantTableAdapter
        '
        Me.MyTenantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MyTenantTableAdapter = Me.MyTenantTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.TenantInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MyTenantBindingNavigator
        '
        Me.MyTenantBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MyTenantBindingNavigator.BindingSource = Me.MyTenantBindingSource
        Me.MyTenantBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MyTenantBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MyTenantBindingNavigator.GripMargin = New System.Windows.Forms.Padding(4)
        Me.MyTenantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MyTenantBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.MyTenantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MyTenantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MyTenantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MyTenantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MyTenantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MyTenantBindingNavigator.Name = "MyTenantBindingNavigator"
        Me.MyTenantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MyTenantBindingNavigator.Size = New System.Drawing.Size(1306, 28)
        Me.MyTenantBindingNavigator.Stretch = True
        Me.MyTenantBindingNavigator.TabIndex = 0
        Me.MyTenantBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.BackColor = System.Drawing.Color.LimeGreen
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(207, 25)
        Me.BindingNavigatorAddNewItem.Text = "ADD NEW TENANT"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.BackColor = System.Drawing.Color.Aqua
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(113, 25)
        Me.BindingNavigatorDeleteItem.Text = "DELETE"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'MyTenantBindingNavigatorSaveItem
        '
        Me.MyTenantBindingNavigatorSaveItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MyTenantBindingNavigatorSaveItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTenantBindingNavigatorSaveItem.Image = CType(resources.GetObject("MyTenantBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MyTenantBindingNavigatorSaveItem.Name = "MyTenantBindingNavigatorSaveItem"
        Me.MyTenantBindingNavigatorSaveItem.Size = New System.Drawing.Size(135, 25)
        Me.MyTenantBindingNavigatorSaveItem.Text = "SAVE DATA"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStripButton1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(134, 25)
        Me.ToolStripButton1.Text = "EDIT ROW"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStripButton2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(208, 25)
        Me.ToolStripButton2.Text = "CANCEL CHANGES"
        '
        'Tenant_IDTextBox
        '
        Me.Tenant_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Tenant ID", True))
        Me.Tenant_IDTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenant_IDTextBox.Location = New System.Drawing.Point(653, 211)
        Me.Tenant_IDTextBox.Multiline = True
        Me.Tenant_IDTextBox.Name = "Tenant_IDTextBox"
        Me.Tenant_IDTextBox.Size = New System.Drawing.Size(235, 31)
        Me.Tenant_IDTextBox.TabIndex = 2
        '
        'Phone_NOTextBox
        '
        Me.Phone_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Phone NO", True))
        Me.Phone_NOTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NOTextBox.Location = New System.Drawing.Point(653, 256)
        Me.Phone_NOTextBox.Multiline = True
        Me.Phone_NOTextBox.Name = "Phone_NOTextBox"
        Me.Phone_NOTextBox.Size = New System.Drawing.Size(235, 34)
        Me.Phone_NOTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(653, 305)
        Me.SurnameTextBox.Multiline = True
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(235, 35)
        Me.SurnameTextBox.TabIndex = 6
        '
        'Other_NameTextBox
        '
        Me.Other_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Other Name", True))
        Me.Other_NameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_NameTextBox.Location = New System.Drawing.Point(653, 411)
        Me.Other_NameTextBox.Multiline = True
        Me.Other_NameTextBox.Name = "Other_NameTextBox"
        Me.Other_NameTextBox.Size = New System.Drawing.Size(235, 32)
        Me.Other_NameTextBox.TabIndex = 8
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(653, 354)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(235, 31)
        Me.GenderTextBox.TabIndex = 10
        '
        'House_NumberTextBox
        '
        Me.House_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "House Number", True))
        Me.House_NumberTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_NumberTextBox.Location = New System.Drawing.Point(653, 461)
        Me.House_NumberTextBox.Multiline = True
        Me.House_NumberTextBox.Name = "House_NumberTextBox"
        Me.House_NumberTextBox.Size = New System.Drawing.Size(235, 32)
        Me.House_NumberTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1144, 64)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MATATA AGENCY TENANT'S RECORDS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(590, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 52)
        Me.Button1.TabIndex = 14
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vacancy101ATableAdapter = Me.Vacancy101ATableAdapter
        '
        'TenantTextBox101A
        '
        Me.TenantTextBox101A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101ABindingSource, "Tenant", True))
        Me.TenantTextBox101A.Location = New System.Drawing.Point(12, 186)
        Me.TenantTextBox101A.Name = "TenantTextBox101A"
        Me.TenantTextBox101A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101A.TabIndex = 16
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.Vacancy101BTableAdapter = Me.Vacancy101BTableAdapter
        '
        'TenantTextBox101B
        '
        Me.TenantTextBox101B.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101BBindingSource, "Tenant", True))
        Me.TenantTextBox101B.Location = New System.Drawing.Point(12, 212)
        Me.TenantTextBox101B.Name = "TenantTextBox101B"
        Me.TenantTextBox101B.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101B.TabIndex = 18
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.UpdateOrder = WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.Vacancy101CTableAdapter = Me.Vacancy101CTableAdapter
        '
        'TenantTextBox101C
        '
        Me.TenantTextBox101C.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy101CBindingSource, "Tenant", True))
        Me.TenantTextBox101C.Location = New System.Drawing.Point(12, 238)
        Me.TenantTextBox101C.Name = "TenantTextBox101C"
        Me.TenantTextBox101C.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox101C.TabIndex = 20
        '
        'Vacant202ADataSet
        '
        Me.Vacant202ADataSet.DataSetName = "Vacant202ADataSet"
        Me.Vacant202ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy202ABindingSource
        '
        Me.Vacancy202ABindingSource.DataMember = "Vacancy202A"
        Me.Vacancy202ABindingSource.DataSource = Me.Vacant202ADataSet
        '
        'Vacancy202ATableAdapter
        '
        Me.Vacancy202ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.UpdateOrder = WindowsApplication1.Vacant202ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager4.Vacancy202ATableAdapter = Me.Vacancy202ATableAdapter
        '
        'TenantTextBox202A
        '
        Me.TenantTextBox202A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy202ABindingSource, "Tenant", True))
        Me.TenantTextBox202A.Location = New System.Drawing.Point(12, 266)
        Me.TenantTextBox202A.Name = "TenantTextBox202A"
        Me.TenantTextBox202A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox202A.TabIndex = 22
        '
        'Vacant303ADataSet
        '
        Me.Vacant303ADataSet.DataSetName = "Vacant303ADataSet"
        Me.Vacant303ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy303ABindingSource
        '
        Me.Vacancy303ABindingSource.DataMember = "Vacancy303A"
        Me.Vacancy303ABindingSource.DataSource = Me.Vacant303ADataSet
        '
        'Vacancy303ATableAdapter
        '
        Me.Vacancy303ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.UpdateOrder = WindowsApplication1.Vacant303ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager5.Vacancy303ATableAdapter = Me.Vacancy303ATableAdapter
        '
        'TenantTextBox303A
        '
        Me.TenantTextBox303A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy303ABindingSource, "Tenant", True))
        Me.TenantTextBox303A.Location = New System.Drawing.Point(12, 292)
        Me.TenantTextBox303A.Name = "TenantTextBox303A"
        Me.TenantTextBox303A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox303A.TabIndex = 24
        '
        'Vacant303BDataSet
        '
        Me.Vacant303BDataSet.DataSetName = "Vacant303BDataSet"
        Me.Vacant303BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy303BBindingSource
        '
        Me.Vacancy303BBindingSource.DataMember = "Vacancy303B"
        Me.Vacancy303BBindingSource.DataSource = Me.Vacant303BDataSet
        '
        'Vacancy303BTableAdapter
        '
        Me.Vacancy303BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.UpdateOrder = WindowsApplication1.Vacant303BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager6.Vacancy303BTableAdapter = Me.Vacancy303BTableAdapter
        '
        'TenantTextBox303B
        '
        Me.TenantTextBox303B.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy303BBindingSource, "Tenant", True))
        Me.TenantTextBox303B.Location = New System.Drawing.Point(12, 318)
        Me.TenantTextBox303B.Name = "TenantTextBox303B"
        Me.TenantTextBox303B.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox303B.TabIndex = 26
        '
        'Vacant404ADataSet
        '
        Me.Vacant404ADataSet.DataSetName = "Vacant404ADataSet"
        Me.Vacant404ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy404ABindingSource
        '
        Me.Vacancy404ABindingSource.DataMember = "Vacancy404A"
        Me.Vacancy404ABindingSource.DataSource = Me.Vacant404ADataSet
        '
        'Vacancy404ATableAdapter
        '
        Me.Vacancy404ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.UpdateOrder = WindowsApplication1.Vacant404ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager7.Vacancy404ATableAdapter = Me.Vacancy404ATableAdapter
        '
        'TenantTextBox404A
        '
        Me.TenantTextBox404A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy404ABindingSource, "Tenant", True))
        Me.TenantTextBox404A.Location = New System.Drawing.Point(12, 344)
        Me.TenantTextBox404A.Name = "TenantTextBox404A"
        Me.TenantTextBox404A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox404A.TabIndex = 28
        '
        'Vacant505ADataSet
        '
        Me.Vacant505ADataSet.DataSetName = "Vacant505ADataSet"
        Me.Vacant505ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy505ABindingSource
        '
        Me.Vacancy505ABindingSource.DataMember = "Vacancy505A"
        Me.Vacancy505ABindingSource.DataSource = Me.Vacant505ADataSet
        '
        'Vacancy505ATableAdapter
        '
        Me.Vacancy505ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.UpdateOrder = WindowsApplication1.Vacant505ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager8.Vacancy505ATableAdapter = Me.Vacancy505ATableAdapter
        '
        'TenantTextBox505A
        '
        Me.TenantTextBox505A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy505ABindingSource, "Tenant", True))
        Me.TenantTextBox505A.Location = New System.Drawing.Point(12, 370)
        Me.TenantTextBox505A.Name = "TenantTextBox505A"
        Me.TenantTextBox505A.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox505A.TabIndex = 30
        '
        'Vacant505BDataSet
        '
        Me.Vacant505BDataSet.DataSetName = "Vacant505BDataSet"
        Me.Vacant505BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vacancy505BBindingSource
        '
        Me.Vacancy505BBindingSource.DataMember = "Vacancy505B"
        Me.Vacancy505BBindingSource.DataSource = Me.Vacant505BDataSet
        '
        'Vacancy505BTableAdapter
        '
        Me.Vacancy505BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager9.UpdateOrder = WindowsApplication1.Vacant505BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager9.Vacancy505BTableAdapter = Me.Vacancy505BTableAdapter
        '
        'TenantTextBox505B
        '
        Me.TenantTextBox505B.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vacancy505BBindingSource, "Tenant", True))
        Me.TenantTextBox505B.Location = New System.Drawing.Point(12, 396)
        Me.TenantTextBox505B.Name = "TenantTextBox505B"
        Me.TenantTextBox505B.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox505B.TabIndex = 32
        '
        'VacantB202DataSet
        '
        Me.VacantB202DataSet.DataSetName = "VacantB202DataSet"
        Me.VacantB202DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacancyB202BindingSource
        '
        Me.VacancyB202BindingSource.DataMember = "VacancyB202"
        Me.VacancyB202BindingSource.DataSource = Me.VacantB202DataSet
        '
        'VacancyB202TableAdapter
        '
        Me.VacancyB202TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager10
        '
        Me.TableAdapterManager10.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager10.UpdateOrder = WindowsApplication1.VacantB202DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager10.VacancyB202TableAdapter = Me.VacancyB202TableAdapter
        '
        'TenantTextBox202B
        '
        Me.TenantTextBox202B.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacancyB202BindingSource, "Tenant", True))
        Me.TenantTextBox202B.Location = New System.Drawing.Point(12, 422)
        Me.TenantTextBox202B.Name = "TenantTextBox202B"
        Me.TenantTextBox202B.Size = New System.Drawing.Size(100, 20)
        Me.TenantTextBox202B.TabIndex = 34
        '
        'RegisterTenantForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(1306, 605)
        Me.Controls.Add(Me.TenantTextBox202B)
        Me.Controls.Add(Me.TenantTextBox505B)
        Me.Controls.Add(Me.TenantTextBox505A)
        Me.Controls.Add(Me.TenantTextBox404A)
        Me.Controls.Add(Me.TenantTextBox303B)
        Me.Controls.Add(Me.TenantTextBox303A)
        Me.Controls.Add(Me.TenantTextBox202A)
        Me.Controls.Add(Me.TenantTextBox101C)
        Me.Controls.Add(Me.TenantTextBox101B)
        Me.Controls.Add(Me.TenantTextBox101A)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Tenant_IDLabel)
        Me.Controls.Add(Me.Tenant_IDTextBox)
        Me.Controls.Add(Phone_NOLabel)
        Me.Controls.Add(Me.Phone_NOTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Other_NameLabel)
        Me.Controls.Add(Me.Other_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(House_NumberLabel)
        Me.Controls.Add(Me.House_NumberTextBox)
        Me.Controls.Add(Me.MyTenantBindingNavigator)
        Me.Name = "RegisterTenantForm"
        Me.Text = "REGISTER TENANT"
        CType(Me.TenantInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTenantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTenantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyTenantBindingNavigator.ResumeLayout(False)
        Me.MyTenantBindingNavigator.PerformLayout()
        CType(Me.Vacant101ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant101BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant101CDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy101CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant202ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy202ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant303ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy303ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant303BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy303BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant404ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy404ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant505ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy505ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacant505BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vacancy505BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacantB202DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacancyB202BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TenantInformationDataSet As WindowsApplication1.TenantInformationDataSet
    Friend WithEvents MyTenantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MyTenantTableAdapter As WindowsApplication1.TenantInformationDataSetTableAdapters.MyTenantTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.TenantInformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MyTenantBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MyTenantBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tenant_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents House_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Vacant101ADataSet As WindowsApplication1.Vacant101ADataSet
    Friend WithEvents Vacancy101ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101ATableAdapter As WindowsApplication1.Vacant101ADataSetTableAdapters.Vacancy101ATableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.Vacant101ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant101BDataSet As WindowsApplication1.Vacant101BDataSet
    Friend WithEvents Vacancy101BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101BTableAdapter As WindowsApplication1.Vacant101BDataSetTableAdapters.Vacancy101BTableAdapter
    Friend WithEvents TableAdapterManager2 As WindowsApplication1.Vacant101BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101B As System.Windows.Forms.TextBox
    Friend WithEvents Vacant101CDataSet As WindowsApplication1.Vacant101CDataSet
    Friend WithEvents Vacancy101CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy101CTableAdapter As WindowsApplication1.Vacant101CDataSetTableAdapters.Vacancy101CTableAdapter
    Friend WithEvents TableAdapterManager3 As WindowsApplication1.Vacant101CDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox101C As System.Windows.Forms.TextBox
    Friend WithEvents Vacant202ADataSet As WindowsApplication1.Vacant202ADataSet
    Friend WithEvents Vacancy202ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy202ATableAdapter As WindowsApplication1.Vacant202ADataSetTableAdapters.Vacancy202ATableAdapter
    Friend WithEvents TableAdapterManager4 As WindowsApplication1.Vacant202ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox202A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant303ADataSet As WindowsApplication1.Vacant303ADataSet
    Friend WithEvents Vacancy303ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy303ATableAdapter As WindowsApplication1.Vacant303ADataSetTableAdapters.Vacancy303ATableAdapter
    Friend WithEvents TableAdapterManager5 As WindowsApplication1.Vacant303ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox303A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant303BDataSet As WindowsApplication1.Vacant303BDataSet
    Friend WithEvents Vacancy303BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy303BTableAdapter As WindowsApplication1.Vacant303BDataSetTableAdapters.Vacancy303BTableAdapter
    Friend WithEvents TableAdapterManager6 As WindowsApplication1.Vacant303BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox303B As System.Windows.Forms.TextBox
    Friend WithEvents Vacant404ADataSet As WindowsApplication1.Vacant404ADataSet
    Friend WithEvents Vacancy404ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy404ATableAdapter As WindowsApplication1.Vacant404ADataSetTableAdapters.Vacancy404ATableAdapter
    Friend WithEvents TableAdapterManager7 As WindowsApplication1.Vacant404ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox404A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant505ADataSet As WindowsApplication1.Vacant505ADataSet
    Friend WithEvents Vacancy505ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy505ATableAdapter As WindowsApplication1.Vacant505ADataSetTableAdapters.Vacancy505ATableAdapter
    Friend WithEvents TableAdapterManager8 As WindowsApplication1.Vacant505ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox505A As System.Windows.Forms.TextBox
    Friend WithEvents Vacant505BDataSet As WindowsApplication1.Vacant505BDataSet
    Friend WithEvents Vacancy505BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vacancy505BTableAdapter As WindowsApplication1.Vacant505BDataSetTableAdapters.Vacancy505BTableAdapter
    Friend WithEvents TableAdapterManager9 As WindowsApplication1.Vacant505BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox505B As System.Windows.Forms.TextBox
    Friend WithEvents VacantB202DataSet As WindowsApplication1.VacantB202DataSet
    Friend WithEvents VacancyB202BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VacancyB202TableAdapter As WindowsApplication1.VacantB202DataSetTableAdapters.VacancyB202TableAdapter
    Friend WithEvents TableAdapterManager10 As WindowsApplication1.VacantB202DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TenantTextBox202B As System.Windows.Forms.TextBox
End Class
