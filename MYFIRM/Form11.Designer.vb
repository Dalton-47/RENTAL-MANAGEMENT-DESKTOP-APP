<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeManagerPinForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeManagerPinForm))
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ManagerpinDataSet = New WindowsApplication1.ManagerpinDataSet()
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerTableAdapter = New WindowsApplication1.ManagerpinDataSetTableAdapters.ManagerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ManagerpinDataSetTableAdapters.TableAdapterManager()
        Me.ManagerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ManagerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MyusernameTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MypasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.NewLabel1 = New System.Windows.Forms.Label()
        Me.NewTextBox1 = New System.Windows.Forms.TextBox()
        Me.NewTextBox2 = New System.Windows.Forms.TextBox()
        Me.NewLabel2 = New System.Windows.Forms.Label()
        Me.NewconfirmTextBox3 = New System.Windows.Forms.TextBox()
        Me.NewLabel3 = New System.Windows.Forms.Label()
        Me.NewButton1 = New System.Windows.Forms.Button()
        Me.firstHelpButton = New System.Windows.Forms.Button()
        CType(Me.ManagerpinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManagerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(671, 264)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(154, 36)
        Me.PasswordTextBox.TabIndex = 39
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(670, 208)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(154, 31)
        Me.UsernameTextBox.TabIndex = 38
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Cyan
        Me.PasswordLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(487, 269)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(175, 31)
        Me.PasswordLabel.TabIndex = 37
        Me.PasswordLabel.Text = "Current Pin :"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Cyan
        Me.UsernameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(408, 208)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(254, 31)
        Me.UsernameLabel.TabIndex = 36
        Me.UsernameLabel.Text = "Current Username :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OrangeRed
        Me.Label1.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 45)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Please Fill Out The Spaces Below Accordingly"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 47)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ManagerpinDataSet
        '
        Me.ManagerpinDataSet.DataSetName = "ManagerpinDataSet"
        Me.ManagerpinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagerBindingSource
        '
        Me.ManagerBindingSource.DataMember = "Manager"
        Me.ManagerBindingSource.DataSource = Me.ManagerpinDataSet
        '
        'ManagerTableAdapter
        '
        Me.ManagerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ManagerTableAdapter = Me.ManagerTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ManagerpinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ManagerBindingNavigator
        '
        Me.ManagerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ManagerBindingNavigator.BindingSource = Me.ManagerBindingSource
        Me.ManagerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ManagerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ManagerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ManagerBindingNavigatorSaveItem})
        Me.ManagerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ManagerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ManagerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ManagerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ManagerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ManagerBindingNavigator.Name = "ManagerBindingNavigator"
        Me.ManagerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ManagerBindingNavigator.Size = New System.Drawing.Size(1306, 25)
        Me.ManagerBindingNavigator.TabIndex = 42
        Me.ManagerBindingNavigator.Text = "BindingNavigator1"
        Me.ManagerBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ManagerBindingNavigatorSaveItem
        '
        Me.ManagerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ManagerBindingNavigatorSaveItem.Image = CType(resources.GetObject("ManagerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ManagerBindingNavigatorSaveItem.Name = "ManagerBindingNavigatorSaveItem"
        Me.ManagerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ManagerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MyusernameTextBox
        '
        Me.MyusernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "Myusername", True))
        Me.MyusernameTextBox.Location = New System.Drawing.Point(12, 89)
        Me.MyusernameTextBox.Name = "MyusernameTextBox"
        Me.MyusernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MyusernameTextBox.TabIndex = 43
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ManagerBindingSource, "Myusername", True))
        Me.ListBox1.DataSource = Me.ManagerBindingSource
        Me.ListBox1.DisplayMember = "Myusername"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 115)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 56)
        Me.ListBox1.TabIndex = 44
        Me.ListBox1.ValueMember = "Myusername"
        '
        'MypasswordTextBox
        '
        Me.MypasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "Mypassword", True))
        Me.MypasswordTextBox.Location = New System.Drawing.Point(12, 196)
        Me.MypasswordTextBox.Name = "MypasswordTextBox"
        Me.MypasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MypasswordTextBox.TabIndex = 45
        '
        'ListBox2
        '
        Me.ListBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ManagerBindingSource, "Mypassword", True))
        Me.ListBox2.DataSource = Me.ManagerBindingSource
        Me.ListBox2.DisplayMember = "Mypassword"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 222)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 56)
        Me.ListBox2.TabIndex = 46
        Me.ListBox2.ValueMember = "Mypassword"
        '
        'NewLabel1
        '
        Me.NewLabel1.AutoSize = True
        Me.NewLabel1.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel1.Location = New System.Drawing.Point(452, 150)
        Me.NewLabel1.Name = "NewLabel1"
        Me.NewLabel1.Size = New System.Drawing.Size(210, 31)
        Me.NewLabel1.TabIndex = 47
        Me.NewLabel1.Text = "New Username :"
        '
        'NewTextBox1
        '
        Me.NewTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox1.Location = New System.Drawing.Point(671, 141)
        Me.NewTextBox1.Multiline = True
        Me.NewTextBox1.Name = "NewTextBox1"
        Me.NewTextBox1.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox1.TabIndex = 48
        '
        'NewTextBox2
        '
        Me.NewTextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox2.Location = New System.Drawing.Point(670, 208)
        Me.NewTextBox2.Multiline = True
        Me.NewTextBox2.Name = "NewTextBox2"
        Me.NewTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewTextBox2.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox2.TabIndex = 50
        '
        'NewLabel2
        '
        Me.NewLabel2.AutoSize = True
        Me.NewLabel2.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel2.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel2.Location = New System.Drawing.Point(531, 217)
        Me.NewLabel2.Name = "NewLabel2"
        Me.NewLabel2.Size = New System.Drawing.Size(131, 31)
        Me.NewLabel2.TabIndex = 49
        Me.NewLabel2.Text = "New Pin :"
        '
        'NewconfirmTextBox3
        '
        Me.NewconfirmTextBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewconfirmTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewconfirmTextBox3.Location = New System.Drawing.Point(671, 274)
        Me.NewconfirmTextBox3.Multiline = True
        Me.NewconfirmTextBox3.Name = "NewconfirmTextBox3"
        Me.NewconfirmTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewconfirmTextBox3.Size = New System.Drawing.Size(162, 43)
        Me.NewconfirmTextBox3.TabIndex = 52
        '
        'NewLabel3
        '
        Me.NewLabel3.AutoSize = True
        Me.NewLabel3.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel3.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel3.Location = New System.Drawing.Point(484, 286)
        Me.NewLabel3.Name = "NewLabel3"
        Me.NewLabel3.Size = New System.Drawing.Size(178, 31)
        Me.NewLabel3.TabIndex = 51
        Me.NewLabel3.Text = "Confirm Pin :"
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.SpringGreen
        Me.NewButton1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.Location = New System.Drawing.Point(390, 348)
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(152, 47)
        Me.NewButton1.TabIndex = 53
        Me.NewButton1.Text = "SAVE"
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'firstHelpButton
        '
        Me.firstHelpButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.firstHelpButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstHelpButton.Location = New System.Drawing.Point(841, 348)
        Me.firstHelpButton.Name = "firstHelpButton"
        Me.firstHelpButton.Size = New System.Drawing.Size(116, 47)
        Me.firstHelpButton.TabIndex = 56
        Me.firstHelpButton.Text = "HELP"
        Me.firstHelpButton.UseVisualStyleBackColor = False
        '
        'ChangeManagerPinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._264339766_187881
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1306, 471)
        Me.Controls.Add(Me.firstHelpButton)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.NewconfirmTextBox3)
        Me.Controls.Add(Me.NewLabel3)
        Me.Controls.Add(Me.NewTextBox2)
        Me.Controls.Add(Me.NewLabel2)
        Me.Controls.Add(Me.NewTextBox1)
        Me.Controls.Add(Me.NewLabel1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.MypasswordTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MyusernameTextBox)
        Me.Controls.Add(Me.ManagerBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "ChangeManagerPinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Mypin"
        CType(Me.ManagerpinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManagerBindingNavigator.ResumeLayout(False)
        Me.ManagerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ManagerpinDataSet As WindowsApplication1.ManagerpinDataSet
    Friend WithEvents ManagerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ManagerTableAdapter As WindowsApplication1.ManagerpinDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.ManagerpinDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ManagerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ManagerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MyusernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MypasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents NewLabel1 As System.Windows.Forms.Label
    Friend WithEvents NewTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NewTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents NewLabel2 As System.Windows.Forms.Label
    Friend WithEvents NewconfirmTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents NewLabel3 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As System.Windows.Forms.Button
    Friend WithEvents firstHelpButton As System.Windows.Forms.Button
End Class
