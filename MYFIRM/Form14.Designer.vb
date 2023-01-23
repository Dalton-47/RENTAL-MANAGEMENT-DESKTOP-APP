<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentForm
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
        Dim HouseNameLabel As System.Windows.Forms.Label
        Dim RentLabel As System.Windows.Forms.Label
        Dim MyDateLabel As System.Windows.Forms.Label
        Dim MPESATransactionNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentForm))
        Me.MyRecordsDataSet = New WindowsApplication1.MyRecordsDataSet()
        Me.RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordsTableAdapter = New WindowsApplication1.MyRecordsDataSetTableAdapters.RecordsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MyRecordsDataSetTableAdapters.TableAdapterManager()
        Me.RecordsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RecordsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HouseNameTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.MyDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MPESATransactionNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewHouse101ADataSet = New WindowsApplication1.NewHouse101ADataSet()
        Me._101ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._101ATableAdapter = New WindowsApplication1.NewHouse101ADataSetTableAdapters._101ATableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox101a = New System.Windows.Forms.TextBox()
        Me.NewHouse101BDataSet = New WindowsApplication1.NewHouse101BDataSet()
        Me._101BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._101BTableAdapter = New WindowsApplication1.NewHouse101BDataSetTableAdapters._101BTableAdapter()
        Me.TableAdapterManager2 = New WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox101b = New System.Windows.Forms.TextBox()
        Me.NewHouse101CDataSet = New WindowsApplication1.NewHouse101CDataSet()
        Me._101CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._101CTableAdapter = New WindowsApplication1.NewHouse101CDataSetTableAdapters._101CTableAdapter()
        Me.TableAdapterManager3 = New WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox101c = New System.Windows.Forms.TextBox()
        Me.House202ADataSet = New WindowsApplication1.House202ADataSet()
        Me._202ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._202ATableAdapter = New WindowsApplication1.House202ADataSetTableAdapters._202ATableAdapter()
        Me.TableAdapterManager4 = New WindowsApplication1.House202ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox202a = New System.Windows.Forms.TextBox()
        Me.House202BDataSet = New WindowsApplication1.House202BDataSet()
        Me._202BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._202BTableAdapter = New WindowsApplication1.House202BDataSetTableAdapters._202BTableAdapter()
        Me.TableAdapterManager5 = New WindowsApplication1.House202BDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox202b = New System.Windows.Forms.TextBox()
        Me.House303ADataSet = New WindowsApplication1.House303ADataSet()
        Me._303ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._303ATableAdapter = New WindowsApplication1.House303ADataSetTableAdapters._303ATableAdapter()
        Me.TableAdapterManager6 = New WindowsApplication1.House303ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox303a = New System.Windows.Forms.TextBox()
        Me.House303BDataSet = New WindowsApplication1.House303BDataSet()
        Me._303BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._303BTableAdapter = New WindowsApplication1.House303BDataSetTableAdapters._303BTableAdapter()
        Me.TableAdapterManager7 = New WindowsApplication1.House303BDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox303b = New System.Windows.Forms.TextBox()
        Me.House404ADataSet = New WindowsApplication1.House404ADataSet()
        Me._404ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._404ATableAdapter = New WindowsApplication1.House404ADataSetTableAdapters._404ATableAdapter()
        Me.TableAdapterManager8 = New WindowsApplication1.House404ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox404a = New System.Windows.Forms.TextBox()
        Me.House505ADataSet = New WindowsApplication1.House505ADataSet()
        Me._505ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._505ATableAdapter = New WindowsApplication1.House505ADataSetTableAdapters._505ATableAdapter()
        Me.TableAdapterManager9 = New WindowsApplication1.House505ADataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox505a = New System.Windows.Forms.TextBox()
        Me.House505BDataSet = New WindowsApplication1.House505BDataSet()
        Me._505BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._505BTableAdapter = New WindowsApplication1.House505BDataSetTableAdapters._505BTableAdapter()
        Me.TableAdapterManager10 = New WindowsApplication1.House505BDataSetTableAdapters.TableAdapterManager()
        Me.RentTextBox505b = New System.Windows.Forms.TextBox()
        Me.CashboxdatabaseDataSet = New WindowsApplication1.CashboxdatabaseDataSet()
        Me.CashtableboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashtableboxTableAdapter = New WindowsApplication1.CashboxdatabaseDataSetTableAdapters.CashtableboxTableAdapter()
        Me.TableAdapterManager11 = New WindowsApplication1.CashboxdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CashTextBox = New System.Windows.Forms.TextBox()
        HouseNameLabel = New System.Windows.Forms.Label()
        RentLabel = New System.Windows.Forms.Label()
        MyDateLabel = New System.Windows.Forms.Label()
        MPESATransactionNumberLabel = New System.Windows.Forms.Label()
        CType(Me.MyRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordsBindingNavigator.SuspendLayout()
        CType(Me.NewHouse101ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHouse101BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHouse101CDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._101CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House202ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._202ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House202BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._202BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House303ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._303ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House303BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._303BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House404ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._404ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House505ADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._505ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.House505BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._505BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashboxdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashtableboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HouseNameLabel
        '
        HouseNameLabel.AutoSize = True
        HouseNameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HouseNameLabel.Location = New System.Drawing.Point(347, 190)
        HouseNameLabel.Name = "HouseNameLabel"
        HouseNameLabel.Size = New System.Drawing.Size(178, 31)
        HouseNameLabel.TabIndex = 1
        HouseNameLabel.Text = "House Name:"
        '
        'RentLabel
        '
        RentLabel.AutoSize = True
        RentLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RentLabel.Location = New System.Drawing.Point(355, 246)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(145, 31)
        RentLabel.TabIndex = 3
        RentLabel.Text = "Rent Paid:"
        '
        'MyDateLabel
        '
        MyDateLabel.AutoSize = True
        MyDateLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyDateLabel.Location = New System.Drawing.Point(355, 303)
        MyDateLabel.Name = "MyDateLabel"
        MyDateLabel.Size = New System.Drawing.Size(144, 31)
        MyDateLabel.TabIndex = 5
        MyDateLabel.Text = "Date Paid:"
        AddHandler MyDateLabel.Click, AddressOf Me.MyDateLabel_Click
        '
        'MPESATransactionNumberLabel
        '
        MPESATransactionNumberLabel.AutoSize = True
        MPESATransactionNumberLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MPESATransactionNumberLabel.Location = New System.Drawing.Point(355, 363)
        MPESATransactionNumberLabel.Name = "MPESATransactionNumberLabel"
        MPESATransactionNumberLabel.Size = New System.Drawing.Size(384, 31)
        MPESATransactionNumberLabel.TabIndex = 7
        MPESATransactionNumberLabel.Text = "MPESA Transaction Number:"
        '
        'MyRecordsDataSet
        '
        Me.MyRecordsDataSet.DataSetName = "MyRecordsDataSet"
        Me.MyRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordsBindingSource
        '
        Me.RecordsBindingSource.DataMember = "Records"
        Me.RecordsBindingSource.DataSource = Me.MyRecordsDataSet
        '
        'RecordsTableAdapter
        '
        Me.RecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RecordsTableAdapter = Me.RecordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MyRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecordsBindingNavigator
        '
        Me.RecordsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecordsBindingNavigator.BindingSource = Me.RecordsBindingSource
        Me.RecordsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecordsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecordsBindingNavigator.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecordsBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.RecordsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecordsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecordsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecordsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecordsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecordsBindingNavigator.Name = "RecordsBindingNavigator"
        Me.RecordsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecordsBindingNavigator.Size = New System.Drawing.Size(1250, 28)
        Me.RecordsBindingNavigator.TabIndex = 0
        Me.RecordsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(97, 25)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(41, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(80, 25)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'RecordsBindingNavigatorSaveItem
        '
        Me.RecordsBindingNavigatorSaveItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecordsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecordsBindingNavigatorSaveItem.Name = "RecordsBindingNavigatorSaveItem"
        Me.RecordsBindingNavigatorSaveItem.Size = New System.Drawing.Size(109, 25)
        Me.RecordsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(106, 25)
        Me.EditToolStripButton.Text = "Edit Row"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelToolStripButton.Image = CType(resources.GetObject("CancelToolStripButton.Image"), System.Drawing.Image)
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(155, 25)
        Me.CancelToolStripButton.Text = "Cancel Changes"
        '
        'HouseNameTextBox
        '
        Me.HouseNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "HouseName", True))
        Me.HouseNameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseNameTextBox.Location = New System.Drawing.Point(531, 182)
        Me.HouseNameTextBox.Multiline = True
        Me.HouseNameTextBox.Name = "HouseNameTextBox"
        Me.HouseNameTextBox.Size = New System.Drawing.Size(200, 39)
        Me.HouseNameTextBox.TabIndex = 2
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "Rent", True))
        Me.RentTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentTextBox.Location = New System.Drawing.Point(531, 238)
        Me.RentTextBox.Multiline = True
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(200, 39)
        Me.RentTextBox.TabIndex = 4
        '
        'MyDateDateTimePicker
        '
        Me.MyDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordsBindingSource, "MyDate", True))
        Me.MyDateDateTimePicker.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDateDateTimePicker.Location = New System.Drawing.Point(531, 302)
        Me.MyDateDateTimePicker.Name = "MyDateDateTimePicker"
        Me.MyDateDateTimePicker.Size = New System.Drawing.Size(354, 32)
        Me.MyDateDateTimePicker.TabIndex = 6
        '
        'MPESATransactionNumberTextBox
        '
        Me.MPESATransactionNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "MPESATransactionNumber", True))
        Me.MPESATransactionNumberTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPESATransactionNumberTextBox.Location = New System.Drawing.Point(756, 355)
        Me.MPESATransactionNumberTextBox.Multiline = True
        Me.MPESATransactionNumberTextBox.Name = "MPESATransactionNumberTextBox"
        Me.MPESATransactionNumberTextBox.Size = New System.Drawing.Size(200, 39)
        Me.MPESATransactionNumberTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Elephant", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1115, 49)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MATATA AGENCY RENT-PAYMENTS ENTRY FORM "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(531, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NewHouse101ADataSet
        '
        Me.NewHouse101ADataSet.DataSetName = "NewHouse101ADataSet"
        Me.NewHouse101ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_101ABindingSource
        '
        Me._101ABindingSource.DataMember = "101A"
        Me._101ABindingSource.DataSource = Me.NewHouse101ADataSet
        '
        '_101ATableAdapter
        '
        Me._101ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1._101ATableAdapter = Me._101ATableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox101a
        '
        Me.RentTextBox101a.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101ABindingSource, "Rent", True))
        Me.RentTextBox101a.Location = New System.Drawing.Point(12, 148)
        Me.RentTextBox101a.Name = "RentTextBox101a"
        Me.RentTextBox101a.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox101a.TabIndex = 12
        '
        'NewHouse101BDataSet
        '
        Me.NewHouse101BDataSet.DataSetName = "NewHouse101BDataSet"
        Me.NewHouse101BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_101BBindingSource
        '
        Me._101BBindingSource.DataMember = "101B"
        Me._101BBindingSource.DataSource = Me.NewHouse101BDataSet
        '
        '_101BTableAdapter
        '
        Me._101BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2._101BTableAdapter = Me._101BTableAdapter
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox101b
        '
        Me.RentTextBox101b.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101BBindingSource, "Rent", True))
        Me.RentTextBox101b.Location = New System.Drawing.Point(12, 174)
        Me.RentTextBox101b.Name = "RentTextBox101b"
        Me.RentTextBox101b.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox101b.TabIndex = 14
        '
        'NewHouse101CDataSet
        '
        Me.NewHouse101CDataSet.DataSetName = "NewHouse101CDataSet"
        Me.NewHouse101CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_101CBindingSource
        '
        Me._101CBindingSource.DataMember = "101C"
        Me._101CBindingSource.DataSource = Me.NewHouse101CDataSet
        '
        '_101CTableAdapter
        '
        Me._101CTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3._101CTableAdapter = Me._101CTableAdapter
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.UpdateOrder = WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox101c
        '
        Me.RentTextBox101c.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._101CBindingSource, "Rent", True))
        Me.RentTextBox101c.Location = New System.Drawing.Point(12, 203)
        Me.RentTextBox101c.Name = "RentTextBox101c"
        Me.RentTextBox101c.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox101c.TabIndex = 16
        '
        'House202ADataSet
        '
        Me.House202ADataSet.DataSetName = "House202ADataSet"
        Me.House202ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_202ABindingSource
        '
        Me._202ABindingSource.DataMember = "202A"
        Me._202ABindingSource.DataSource = Me.House202ADataSet
        '
        '_202ATableAdapter
        '
        Me._202ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4._202ATableAdapter = Me._202ATableAdapter
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.UpdateOrder = WindowsApplication1.House202ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox202a
        '
        Me.RentTextBox202a.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._202ABindingSource, "Rent", True))
        Me.RentTextBox202a.Location = New System.Drawing.Point(12, 229)
        Me.RentTextBox202a.Name = "RentTextBox202a"
        Me.RentTextBox202a.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox202a.TabIndex = 18
        '
        'House202BDataSet
        '
        Me.House202BDataSet.DataSetName = "House202BDataSet"
        Me.House202BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_202BBindingSource
        '
        Me._202BBindingSource.DataMember = "202B"
        Me._202BBindingSource.DataSource = Me.House202BDataSet
        '
        '_202BTableAdapter
        '
        Me._202BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5._202BTableAdapter = Me._202BTableAdapter
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.UpdateOrder = WindowsApplication1.House202BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox202b
        '
        Me.RentTextBox202b.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._202BBindingSource, "Rent", True))
        Me.RentTextBox202b.Location = New System.Drawing.Point(12, 259)
        Me.RentTextBox202b.Name = "RentTextBox202b"
        Me.RentTextBox202b.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox202b.TabIndex = 20
        '
        'House303ADataSet
        '
        Me.House303ADataSet.DataSetName = "House303ADataSet"
        Me.House303ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_303ABindingSource
        '
        Me._303ABindingSource.DataMember = "303A"
        Me._303ABindingSource.DataSource = Me.House303ADataSet
        '
        '_303ATableAdapter
        '
        Me._303ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6._303ATableAdapter = Me._303ATableAdapter
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.UpdateOrder = WindowsApplication1.House303ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox303a
        '
        Me.RentTextBox303a.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._303ABindingSource, "Rent", True))
        Me.RentTextBox303a.Location = New System.Drawing.Point(12, 285)
        Me.RentTextBox303a.Name = "RentTextBox303a"
        Me.RentTextBox303a.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox303a.TabIndex = 22
        '
        'House303BDataSet
        '
        Me.House303BDataSet.DataSetName = "House303BDataSet"
        Me.House303BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_303BBindingSource
        '
        Me._303BBindingSource.DataMember = "303B"
        Me._303BBindingSource.DataSource = Me.House303BDataSet
        '
        '_303BTableAdapter
        '
        Me._303BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7._303BTableAdapter = Me._303BTableAdapter
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.UpdateOrder = WindowsApplication1.House303BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox303b
        '
        Me.RentTextBox303b.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._303BBindingSource, "Rent", True))
        Me.RentTextBox303b.Location = New System.Drawing.Point(12, 311)
        Me.RentTextBox303b.Name = "RentTextBox303b"
        Me.RentTextBox303b.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox303b.TabIndex = 24
        '
        'House404ADataSet
        '
        Me.House404ADataSet.DataSetName = "House404ADataSet"
        Me.House404ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_404ABindingSource
        '
        Me._404ABindingSource.DataMember = "404A"
        Me._404ABindingSource.DataSource = Me.House404ADataSet
        '
        '_404ATableAdapter
        '
        Me._404ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8._404ATableAdapter = Me._404ATableAdapter
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.UpdateOrder = WindowsApplication1.House404ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox404a
        '
        Me.RentTextBox404a.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._404ABindingSource, "Rent", True))
        Me.RentTextBox404a.Location = New System.Drawing.Point(12, 337)
        Me.RentTextBox404a.Name = "RentTextBox404a"
        Me.RentTextBox404a.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox404a.TabIndex = 26
        '
        'House505ADataSet
        '
        Me.House505ADataSet.DataSetName = "House505ADataSet"
        Me.House505ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_505ABindingSource
        '
        Me._505ABindingSource.DataMember = "505A"
        Me._505ABindingSource.DataSource = Me.House505ADataSet
        '
        '_505ATableAdapter
        '
        Me._505ATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9._505ATableAdapter = Me._505ATableAdapter
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager9.UpdateOrder = WindowsApplication1.House505ADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox505a
        '
        Me.RentTextBox505a.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._505ABindingSource, "Rent", True))
        Me.RentTextBox505a.Location = New System.Drawing.Point(12, 363)
        Me.RentTextBox505a.Name = "RentTextBox505a"
        Me.RentTextBox505a.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox505a.TabIndex = 28
        '
        'House505BDataSet
        '
        Me.House505BDataSet.DataSetName = "House505BDataSet"
        Me.House505BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_505BBindingSource
        '
        Me._505BBindingSource.DataMember = "505B"
        Me._505BBindingSource.DataSource = Me.House505BDataSet
        '
        '_505BTableAdapter
        '
        Me._505BTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager10
        '
        Me.TableAdapterManager10._505BTableAdapter = Me._505BTableAdapter
        Me.TableAdapterManager10.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager10.UpdateOrder = WindowsApplication1.House505BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTextBox505b
        '
        Me.RentTextBox505b.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me._505BBindingSource, "Rent", True))
        Me.RentTextBox505b.Location = New System.Drawing.Point(12, 389)
        Me.RentTextBox505b.Name = "RentTextBox505b"
        Me.RentTextBox505b.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox505b.TabIndex = 30
        '
        'CashboxdatabaseDataSet
        '
        Me.CashboxdatabaseDataSet.DataSetName = "CashboxdatabaseDataSet"
        Me.CashboxdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CashtableboxBindingSource
        '
        Me.CashtableboxBindingSource.DataMember = "Cashtablebox"
        Me.CashtableboxBindingSource.DataSource = Me.CashboxdatabaseDataSet
        '
        'CashtableboxTableAdapter
        '
        Me.CashtableboxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager11
        '
        Me.TableAdapterManager11.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager11.CashtableboxTableAdapter = Me.CashtableboxTableAdapter
        Me.TableAdapterManager11.UpdateOrder = WindowsApplication1.CashboxdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CashTextBox
        '
        Me.CashTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashtableboxBindingSource, "RENT", True))
        Me.CashTextBox.Location = New System.Drawing.Point(12, 414)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CashTextBox.TabIndex = 31
        '
        'RentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1250, 537)
        Me.Controls.Add(Me.CashTextBox)
        Me.Controls.Add(Me.RentTextBox505b)
        Me.Controls.Add(Me.RentTextBox505a)
        Me.Controls.Add(Me.RentTextBox404a)
        Me.Controls.Add(Me.RentTextBox303b)
        Me.Controls.Add(Me.RentTextBox303a)
        Me.Controls.Add(Me.RentTextBox202b)
        Me.Controls.Add(Me.RentTextBox202a)
        Me.Controls.Add(Me.RentTextBox101c)
        Me.Controls.Add(Me.RentTextBox101b)
        Me.Controls.Add(Me.RentTextBox101a)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(HouseNameLabel)
        Me.Controls.Add(Me.HouseNameTextBox)
        Me.Controls.Add(RentLabel)
        Me.Controls.Add(Me.RentTextBox)
        Me.Controls.Add(MyDateLabel)
        Me.Controls.Add(Me.MyDateDateTimePicker)
        Me.Controls.Add(MPESATransactionNumberLabel)
        Me.Controls.Add(Me.MPESATransactionNumberTextBox)
        Me.Controls.Add(Me.RecordsBindingNavigator)
        Me.Name = "RentForm"
        Me.Text = "Form14"
        CType(Me.MyRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordsBindingNavigator.ResumeLayout(False)
        Me.RecordsBindingNavigator.PerformLayout()
        CType(Me.NewHouse101ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHouse101BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHouse101CDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._101CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House202ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._202ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House202BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._202BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House303ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._303ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House303BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._303BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House404ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._404ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House505ADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._505ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.House505BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._505BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashboxdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashtableboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyRecordsDataSet As WindowsApplication1.MyRecordsDataSet
    Friend WithEvents RecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecordsTableAdapter As WindowsApplication1.MyRecordsDataSetTableAdapters.RecordsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MyRecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RecordsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HouseNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MyDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MPESATransactionNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NewHouse101ADataSet As WindowsApplication1.NewHouse101ADataSet
    Friend WithEvents _101ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101ATableAdapter As WindowsApplication1.NewHouse101ADataSetTableAdapters._101ATableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.NewHouse101ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox101a As System.Windows.Forms.TextBox
    Friend WithEvents NewHouse101BDataSet As WindowsApplication1.NewHouse101BDataSet
    Friend WithEvents _101BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101BTableAdapter As WindowsApplication1.NewHouse101BDataSetTableAdapters._101BTableAdapter
    Friend WithEvents TableAdapterManager2 As WindowsApplication1.NewHouse101BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox101b As System.Windows.Forms.TextBox
    Friend WithEvents NewHouse101CDataSet As WindowsApplication1.NewHouse101CDataSet
    Friend WithEvents _101CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _101CTableAdapter As WindowsApplication1.NewHouse101CDataSetTableAdapters._101CTableAdapter
    Friend WithEvents TableAdapterManager3 As WindowsApplication1.NewHouse101CDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox101c As System.Windows.Forms.TextBox
    Friend WithEvents House202ADataSet As WindowsApplication1.House202ADataSet
    Friend WithEvents _202ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _202ATableAdapter As WindowsApplication1.House202ADataSetTableAdapters._202ATableAdapter
    Friend WithEvents TableAdapterManager4 As WindowsApplication1.House202ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox202a As System.Windows.Forms.TextBox
    Friend WithEvents House202BDataSet As WindowsApplication1.House202BDataSet
    Friend WithEvents _202BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _202BTableAdapter As WindowsApplication1.House202BDataSetTableAdapters._202BTableAdapter
    Friend WithEvents TableAdapterManager5 As WindowsApplication1.House202BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox202b As System.Windows.Forms.TextBox
    Friend WithEvents House303ADataSet As WindowsApplication1.House303ADataSet
    Friend WithEvents _303ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _303ATableAdapter As WindowsApplication1.House303ADataSetTableAdapters._303ATableAdapter
    Friend WithEvents TableAdapterManager6 As WindowsApplication1.House303ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox303a As System.Windows.Forms.TextBox
    Friend WithEvents House303BDataSet As WindowsApplication1.House303BDataSet
    Friend WithEvents _303BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _303BTableAdapter As WindowsApplication1.House303BDataSetTableAdapters._303BTableAdapter
    Friend WithEvents TableAdapterManager7 As WindowsApplication1.House303BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox303b As System.Windows.Forms.TextBox
    Friend WithEvents House404ADataSet As WindowsApplication1.House404ADataSet
    Friend WithEvents _404ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _404ATableAdapter As WindowsApplication1.House404ADataSetTableAdapters._404ATableAdapter
    Friend WithEvents TableAdapterManager8 As WindowsApplication1.House404ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox404a As System.Windows.Forms.TextBox
    Friend WithEvents House505ADataSet As WindowsApplication1.House505ADataSet
    Friend WithEvents _505ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _505ATableAdapter As WindowsApplication1.House505ADataSetTableAdapters._505ATableAdapter
    Friend WithEvents TableAdapterManager9 As WindowsApplication1.House505ADataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox505a As System.Windows.Forms.TextBox
    Friend WithEvents House505BDataSet As WindowsApplication1.House505BDataSet
    Friend WithEvents _505BBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _505BTableAdapter As WindowsApplication1.House505BDataSetTableAdapters._505BTableAdapter
    Friend WithEvents TableAdapterManager10 As WindowsApplication1.House505BDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentTextBox505b As System.Windows.Forms.TextBox
    Friend WithEvents CashboxdatabaseDataSet As WindowsApplication1.CashboxdatabaseDataSet
    Friend WithEvents CashtableboxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CashtableboxTableAdapter As WindowsApplication1.CashboxdatabaseDataSetTableAdapters.CashtableboxTableAdapter
    Friend WithEvents TableAdapterManager11 As WindowsApplication1.CashboxdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CashTextBox As System.Windows.Forms.TextBox
End Class
