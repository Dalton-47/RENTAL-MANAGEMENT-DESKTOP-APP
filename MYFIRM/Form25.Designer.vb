<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficerPinForm25
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
        Me.myHelpButton = New System.Windows.Forms.Button()
        Me.myNewButton1 = New System.Windows.Forms.Button()
        Me.NewconfirmTextBox3 = New System.Windows.Forms.TextBox()
        Me.NewLabel3 = New System.Windows.Forms.Label()
        Me.NewTextBox2 = New System.Windows.Forms.TextBox()
        Me.NewLabel2 = New System.Windows.Forms.Label()
        Me.NewTextBox1 = New System.Windows.Forms.TextBox()
        Me.NewLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.OfficerpinDataSet = New WindowsApplication1.OfficerpinDataSet()
        Me.OfficerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficerTableAdapter = New WindowsApplication1.OfficerpinDataSetTableAdapters.OfficerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.OfficerpinDataSetTableAdapters.TableAdapterManager()
        Me.OfficernameTextBox = New System.Windows.Forms.TextBox()
        Me.MypinTextBox = New System.Windows.Forms.TextBox()
        CType(Me.OfficerpinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myHelpButton
        '
        Me.myHelpButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.myHelpButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myHelpButton.Location = New System.Drawing.Point(849, 404)
        Me.myHelpButton.Name = "myHelpButton"
        Me.myHelpButton.Size = New System.Drawing.Size(116, 47)
        Me.myHelpButton.TabIndex = 84
        Me.myHelpButton.Text = "HELP"
        Me.myHelpButton.UseVisualStyleBackColor = False
        '
        'myNewButton1
        '
        Me.myNewButton1.BackColor = System.Drawing.Color.SpringGreen
        Me.myNewButton1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myNewButton1.Location = New System.Drawing.Point(398, 404)
        Me.myNewButton1.Name = "myNewButton1"
        Me.myNewButton1.Size = New System.Drawing.Size(152, 47)
        Me.myNewButton1.TabIndex = 83
        Me.myNewButton1.Text = "SAVE"
        Me.myNewButton1.UseVisualStyleBackColor = False
        '
        'NewconfirmTextBox3
        '
        Me.NewconfirmTextBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewconfirmTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewconfirmTextBox3.Location = New System.Drawing.Point(679, 330)
        Me.NewconfirmTextBox3.Multiline = True
        Me.NewconfirmTextBox3.Name = "NewconfirmTextBox3"
        Me.NewconfirmTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewconfirmTextBox3.Size = New System.Drawing.Size(162, 43)
        Me.NewconfirmTextBox3.TabIndex = 82
        '
        'NewLabel3
        '
        Me.NewLabel3.AutoSize = True
        Me.NewLabel3.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel3.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel3.Location = New System.Drawing.Point(492, 342)
        Me.NewLabel3.Name = "NewLabel3"
        Me.NewLabel3.Size = New System.Drawing.Size(178, 31)
        Me.NewLabel3.TabIndex = 81
        Me.NewLabel3.Text = "Confirm Pin :"
        '
        'NewTextBox2
        '
        Me.NewTextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox2.Location = New System.Drawing.Point(679, 273)
        Me.NewTextBox2.Multiline = True
        Me.NewTextBox2.Name = "NewTextBox2"
        Me.NewTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewTextBox2.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox2.TabIndex = 80
        '
        'NewLabel2
        '
        Me.NewLabel2.AutoSize = True
        Me.NewLabel2.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel2.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel2.Location = New System.Drawing.Point(539, 273)
        Me.NewLabel2.Name = "NewLabel2"
        Me.NewLabel2.Size = New System.Drawing.Size(131, 31)
        Me.NewLabel2.TabIndex = 79
        Me.NewLabel2.Text = "New Pin :"
        '
        'NewTextBox1
        '
        Me.NewTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox1.Location = New System.Drawing.Point(679, 197)
        Me.NewTextBox1.Multiline = True
        Me.NewTextBox1.Name = "NewTextBox1"
        Me.NewTextBox1.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox1.TabIndex = 78
        '
        'NewLabel1
        '
        Me.NewLabel1.AutoSize = True
        Me.NewLabel1.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel1.Location = New System.Drawing.Point(460, 206)
        Me.NewLabel1.Name = "NewLabel1"
        Me.NewLabel1.Size = New System.Drawing.Size(210, 31)
        Me.NewLabel1.TabIndex = 77
        Me.NewLabel1.Text = "New Username :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(599, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 47)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OrangeRed
        Me.Label1.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 45)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Please Fill Out The Spaces Below Accordingly"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(679, 320)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(154, 36)
        Me.PasswordTextBox.TabIndex = 74
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(678, 264)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(154, 31)
        Me.UsernameTextBox.TabIndex = 73
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Cyan
        Me.PasswordLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(495, 325)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(175, 31)
        Me.PasswordLabel.TabIndex = 72
        Me.PasswordLabel.Text = "Current Pin :"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Cyan
        Me.UsernameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(416, 264)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(254, 31)
        Me.UsernameLabel.TabIndex = 71
        Me.UsernameLabel.Text = "Current Username :"
        '
        'OfficerpinDataSet
        '
        Me.OfficerpinDataSet.DataSetName = "OfficerpinDataSet"
        Me.OfficerpinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfficerBindingSource
        '
        Me.OfficerBindingSource.DataMember = "Officer"
        Me.OfficerBindingSource.DataSource = Me.OfficerpinDataSet
        '
        'OfficerTableAdapter
        '
        Me.OfficerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OfficerTableAdapter = Me.OfficerTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.OfficerpinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OfficernameTextBox
        '
        Me.OfficernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfficerBindingSource, "Officername", True))
        Me.OfficernameTextBox.Location = New System.Drawing.Point(39, 94)
        Me.OfficernameTextBox.Name = "OfficernameTextBox"
        Me.OfficernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OfficernameTextBox.TabIndex = 86
        '
        'MypinTextBox
        '
        Me.MypinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfficerBindingSource, "mypin", True))
        Me.MypinTextBox.Location = New System.Drawing.Point(39, 120)
        Me.MypinTextBox.Name = "MypinTextBox"
        Me.MypinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MypinTextBox.TabIndex = 88
        '
        'OfficerPinForm25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._806120312_3266011
        Me.ClientSize = New System.Drawing.Size(1174, 535)
        Me.Controls.Add(Me.OfficernameTextBox)
        Me.Controls.Add(Me.MypinTextBox)
        Me.Controls.Add(Me.myHelpButton)
        Me.Controls.Add(Me.myNewButton1)
        Me.Controls.Add(Me.NewconfirmTextBox3)
        Me.Controls.Add(Me.NewLabel3)
        Me.Controls.Add(Me.NewTextBox2)
        Me.Controls.Add(Me.NewLabel2)
        Me.Controls.Add(Me.NewTextBox1)
        Me.Controls.Add(Me.NewLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "OfficerPinForm25"
        Me.Text = "OFFICER PIN"
        CType(Me.OfficerpinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myHelpButton As System.Windows.Forms.Button
    Friend WithEvents myNewButton1 As System.Windows.Forms.Button
    Friend WithEvents NewconfirmTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents NewLabel3 As System.Windows.Forms.Label
    Friend WithEvents NewTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents NewLabel2 As System.Windows.Forms.Label
    Friend WithEvents NewTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NewLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents OfficerpinDataSet As WindowsApplication1.OfficerpinDataSet
    Friend WithEvents OfficerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OfficerTableAdapter As WindowsApplication1.OfficerpinDataSetTableAdapters.OfficerTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.OfficerpinDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OfficernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MypinTextBox As System.Windows.Forms.TextBox
End Class
