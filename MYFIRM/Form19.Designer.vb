<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myRecordsForm19
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myRecordsForm19))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Tenant_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NOTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Other_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.House_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'Tenant_IDLabel
        '
        Tenant_IDLabel.AutoSize = True
        Tenant_IDLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_IDLabel.Location = New System.Drawing.Point(457, 173)
        Tenant_IDLabel.Name = "Tenant_IDLabel"
        Tenant_IDLabel.Size = New System.Drawing.Size(161, 31)
        Tenant_IDLabel.TabIndex = 2
        Tenant_IDLabel.Text = "Tenant ID:"
        '
        'Phone_NOLabel
        '
        Phone_NOLabel.AutoSize = True
        Phone_NOLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NOLabel.Location = New System.Drawing.Point(457, 218)
        Phone_NOLabel.Name = "Phone_NOLabel"
        Phone_NOLabel.Size = New System.Drawing.Size(159, 31)
        Phone_NOLabel.TabIndex = 4
        Phone_NOLabel.Text = "Phone NO:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(457, 260)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(140, 31)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'Other_NameLabel
        '
        Other_NameLabel.AutoSize = True
        Other_NameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Other_NameLabel.Location = New System.Drawing.Point(457, 305)
        Other_NameLabel.Name = "Other_NameLabel"
        Other_NameLabel.Size = New System.Drawing.Size(183, 31)
        Other_NameLabel.TabIndex = 8
        Other_NameLabel.Text = "Other Name:"
        AddHandler Other_NameLabel.Click, AddressOf Me.Other_NameLabel_Click
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(457, 346)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(119, 31)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender:"
        AddHandler GenderLabel.Click, AddressOf Me.GenderLabel_Click
        '
        'House_NumberLabel
        '
        House_NumberLabel.AutoSize = True
        House_NumberLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NumberLabel.Location = New System.Drawing.Point(457, 396)
        House_NumberLabel.Name = "House_NumberLabel"
        House_NumberLabel.Size = New System.Drawing.Size(220, 31)
        House_NumberLabel.TabIndex = 12
        House_NumberLabel.Text = "House Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(837, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MATATA AGENCY RECORDS"
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
        Me.MyTenantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MyTenantBindingNavigatorSaveItem})
        Me.MyTenantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MyTenantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MyTenantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MyTenantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MyTenantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MyTenantBindingNavigator.Name = "MyTenantBindingNavigator"
        Me.MyTenantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MyTenantBindingNavigator.Size = New System.Drawing.Size(1131, 28)
        Me.MyTenantBindingNavigator.TabIndex = 1
        Me.MyTenantBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BindingNavigatorMoveFirstItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(109, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BindingNavigatorMovePreviousItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(142, 25)
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
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BindingNavigatorMoveNextItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(109, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BindingNavigatorMoveLastItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(104, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'MyTenantBindingNavigatorSaveItem
        '
        Me.MyTenantBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MyTenantBindingNavigatorSaveItem.Enabled = False
        Me.MyTenantBindingNavigatorSaveItem.Image = CType(resources.GetObject("MyTenantBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MyTenantBindingNavigatorSaveItem.Name = "MyTenantBindingNavigatorSaveItem"
        Me.MyTenantBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 25)
        Me.MyTenantBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tenant_IDTextBox
        '
        Me.Tenant_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Tenant ID", True))
        Me.Tenant_IDTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenant_IDTextBox.Location = New System.Drawing.Point(651, 173)
        Me.Tenant_IDTextBox.Multiline = True
        Me.Tenant_IDTextBox.Name = "Tenant_IDTextBox"
        Me.Tenant_IDTextBox.Size = New System.Drawing.Size(197, 31)
        Me.Tenant_IDTextBox.TabIndex = 3
        '
        'Phone_NOTextBox
        '
        Me.Phone_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Phone NO", True))
        Me.Phone_NOTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NOTextBox.Location = New System.Drawing.Point(651, 218)
        Me.Phone_NOTextBox.Multiline = True
        Me.Phone_NOTextBox.Name = "Phone_NOTextBox"
        Me.Phone_NOTextBox.Size = New System.Drawing.Size(197, 31)
        Me.Phone_NOTextBox.TabIndex = 5
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(651, 260)
        Me.SurnameTextBox.Multiline = True
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(197, 31)
        Me.SurnameTextBox.TabIndex = 7
        '
        'Other_NameTextBox
        '
        Me.Other_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Other Name", True))
        Me.Other_NameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_NameTextBox.Location = New System.Drawing.Point(651, 305)
        Me.Other_NameTextBox.Multiline = True
        Me.Other_NameTextBox.Name = "Other_NameTextBox"
        Me.Other_NameTextBox.Size = New System.Drawing.Size(197, 31)
        Me.Other_NameTextBox.TabIndex = 9
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(651, 346)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(197, 31)
        Me.GenderTextBox.TabIndex = 11
        '
        'House_NumberTextBox
        '
        Me.House_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyTenantBindingSource, "House Number", True))
        Me.House_NumberTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_NumberTextBox.Location = New System.Drawing.Point(683, 396)
        Me.House_NumberTextBox.Multiline = True
        Me.House_NumberTextBox.Name = "House_NumberTextBox"
        Me.House_NumberTextBox.Size = New System.Drawing.Size(165, 31)
        Me.House_NumberTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(585, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'myRecordsForm19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 546)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "myRecordsForm19"
        Me.Text = "TENANT INFORMATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TenantInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTenantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTenantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyTenantBindingNavigator.ResumeLayout(False)
        Me.MyTenantBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
