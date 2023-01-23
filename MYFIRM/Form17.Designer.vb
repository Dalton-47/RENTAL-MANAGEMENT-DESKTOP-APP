<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
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
        Me.HouseNameTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.MyDateTextBox = New System.Windows.Forms.TextBox()
        Me.MPESATransactionNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        HouseNameLabel = New System.Windows.Forms.Label()
        RentLabel = New System.Windows.Forms.Label()
        MyDateLabel = New System.Windows.Forms.Label()
        MPESATransactionNumberLabel = New System.Windows.Forms.Label()
        CType(Me.MyRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'HouseNameLabel
        '
        HouseNameLabel.AutoSize = True
        HouseNameLabel.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HouseNameLabel.Location = New System.Drawing.Point(348, 217)
        HouseNameLabel.Name = "HouseNameLabel"
        HouseNameLabel.Size = New System.Drawing.Size(212, 38)
        HouseNameLabel.TabIndex = 1
        HouseNameLabel.Text = "House Name:"
        '
        'RentLabel
        '
        RentLabel.AutoSize = True
        RentLabel.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RentLabel.Location = New System.Drawing.Point(348, 270)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(369, 38)
        RentLabel.TabIndex = 3
        RentLabel.Text = "Last Amount Deposited:"
        AddHandler RentLabel.Click, AddressOf Me.RentLabel_Click
        '
        'MyDateLabel
        '
        MyDateLabel.AutoSize = True
        MyDateLabel.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyDateLabel.Location = New System.Drawing.Point(348, 323)
        MyDateLabel.Name = "MyDateLabel"
        MyDateLabel.Size = New System.Drawing.Size(312, 38)
        MyDateLabel.TabIndex = 5
        MyDateLabel.Text = "Rent Payment Date:"
        AddHandler MyDateLabel.Click, AddressOf Me.MyDateLabel_Click
        '
        'MPESATransactionNumberLabel
        '
        MPESATransactionNumberLabel.AutoSize = True
        MPESATransactionNumberLabel.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MPESATransactionNumberLabel.Location = New System.Drawing.Point(348, 388)
        MPESATransactionNumberLabel.Name = "MPESATransactionNumberLabel"
        MPESATransactionNumberLabel.Size = New System.Drawing.Size(454, 38)
        MPESATransactionNumberLabel.TabIndex = 7
        MPESATransactionNumberLabel.Text = "MPESATransaction Number:"
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
        Me.RecordsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecordsBindingNavigatorSaveItem})
        Me.RecordsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecordsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecordsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecordsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecordsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecordsBindingNavigator.Name = "RecordsBindingNavigator"
        Me.RecordsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecordsBindingNavigator.Size = New System.Drawing.Size(1083, 28)
        Me.RecordsBindingNavigator.TabIndex = 0
        Me.RecordsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 25)
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
        'RecordsBindingNavigatorSaveItem
        '
        Me.RecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecordsBindingNavigatorSaveItem.Enabled = False
        Me.RecordsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecordsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecordsBindingNavigatorSaveItem.Name = "RecordsBindingNavigatorSaveItem"
        Me.RecordsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 25)
        Me.RecordsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HouseNameTextBox
        '
        Me.HouseNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "HouseName", True))
        Me.HouseNameTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseNameTextBox.Location = New System.Drawing.Point(821, 217)
        Me.HouseNameTextBox.Multiline = True
        Me.HouseNameTextBox.Name = "HouseNameTextBox"
        Me.HouseNameTextBox.Size = New System.Drawing.Size(224, 38)
        Me.HouseNameTextBox.TabIndex = 2
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "Rent", True))
        Me.RentTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentTextBox.Location = New System.Drawing.Point(821, 270)
        Me.RentTextBox.Multiline = True
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(224, 38)
        Me.RentTextBox.TabIndex = 4
        '
        'MyDateTextBox
        '
        Me.MyDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "MyDate", True))
        Me.MyDateTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDateTextBox.Location = New System.Drawing.Point(821, 323)
        Me.MyDateTextBox.Multiline = True
        Me.MyDateTextBox.Name = "MyDateTextBox"
        Me.MyDateTextBox.Size = New System.Drawing.Size(353, 38)
        Me.MyDateTextBox.TabIndex = 6
        '
        'MPESATransactionNumberTextBox
        '
        Me.MPESATransactionNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "MPESATransactionNumber", True))
        Me.MPESATransactionNumberTextBox.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPESATransactionNumberTextBox.Location = New System.Drawing.Point(821, 388)
        Me.MPESATransactionNumberTextBox.Multiline = True
        Me.MPESATransactionNumberTextBox.Name = "MPESATransactionNumberTextBox"
        Me.MPESATransactionNumberTextBox.Size = New System.Drawing.Size(251, 38)
        Me.MPESATransactionNumberTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(50, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1273, 62)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MATATA AGENCY RENT-PAYMENT HISTORY"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(613, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1083, 524)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(HouseNameLabel)
        Me.Controls.Add(Me.HouseNameTextBox)
        Me.Controls.Add(RentLabel)
        Me.Controls.Add(Me.RentTextBox)
        Me.Controls.Add(MyDateLabel)
        Me.Controls.Add(Me.MyDateTextBox)
        Me.Controls.Add(MPESATransactionNumberLabel)
        Me.Controls.Add(Me.MPESATransactionNumberTextBox)
        Me.Controls.Add(Me.RecordsBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "HistoryForm"
        Me.Text = "Form17"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MyRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordsBindingNavigator.ResumeLayout(False)
        Me.RecordsBindingNavigator.PerformLayout()
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
    Friend WithEvents MyDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MPESATransactionNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
