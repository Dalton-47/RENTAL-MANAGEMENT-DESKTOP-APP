<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceptionistpinForm24
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
        Me.NewButton1 = New System.Windows.Forms.Button()
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
        Me.ReceptionistpinDataSet = New WindowsApplication1.ReceptionistpinDataSet()
        Me.ReceptionistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceptionistTableAdapter = New WindowsApplication1.ReceptionistpinDataSetTableAdapters.ReceptionistTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ReceptionistpinDataSetTableAdapters.TableAdapterManager()
        Me.ReceptionistnameTextBox = New System.Windows.Forms.TextBox()
        Me.Mypin1TextBox = New System.Windows.Forms.TextBox()
        CType(Me.ReceptionistpinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptionistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myHelpButton
        '
        Me.myHelpButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.myHelpButton.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myHelpButton.Location = New System.Drawing.Point(825, 403)
        Me.myHelpButton.Name = "myHelpButton"
        Me.myHelpButton.Size = New System.Drawing.Size(116, 47)
        Me.myHelpButton.TabIndex = 70
        Me.myHelpButton.Text = "HELP"
        Me.myHelpButton.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.SpringGreen
        Me.NewButton1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.Location = New System.Drawing.Point(374, 403)
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(152, 47)
        Me.NewButton1.TabIndex = 69
        Me.NewButton1.Text = "SAVE"
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'NewconfirmTextBox3
        '
        Me.NewconfirmTextBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewconfirmTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewconfirmTextBox3.Location = New System.Drawing.Point(655, 329)
        Me.NewconfirmTextBox3.Multiline = True
        Me.NewconfirmTextBox3.Name = "NewconfirmTextBox3"
        Me.NewconfirmTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewconfirmTextBox3.Size = New System.Drawing.Size(162, 43)
        Me.NewconfirmTextBox3.TabIndex = 68
        '
        'NewLabel3
        '
        Me.NewLabel3.AutoSize = True
        Me.NewLabel3.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel3.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel3.Location = New System.Drawing.Point(468, 341)
        Me.NewLabel3.Name = "NewLabel3"
        Me.NewLabel3.Size = New System.Drawing.Size(178, 31)
        Me.NewLabel3.TabIndex = 67
        Me.NewLabel3.Text = "Confirm Pin :"
        '
        'NewTextBox2
        '
        Me.NewTextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox2.Location = New System.Drawing.Point(655, 272)
        Me.NewTextBox2.Multiline = True
        Me.NewTextBox2.Name = "NewTextBox2"
        Me.NewTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewTextBox2.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox2.TabIndex = 66
        '
        'NewLabel2
        '
        Me.NewLabel2.AutoSize = True
        Me.NewLabel2.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel2.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel2.Location = New System.Drawing.Point(515, 272)
        Me.NewLabel2.Name = "NewLabel2"
        Me.NewLabel2.Size = New System.Drawing.Size(131, 31)
        Me.NewLabel2.TabIndex = 65
        Me.NewLabel2.Text = "New Pin :"
        '
        'NewTextBox1
        '
        Me.NewTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTextBox1.Location = New System.Drawing.Point(655, 196)
        Me.NewTextBox1.Multiline = True
        Me.NewTextBox1.Name = "NewTextBox1"
        Me.NewTextBox1.Size = New System.Drawing.Size(162, 40)
        Me.NewTextBox1.TabIndex = 64
        '
        'NewLabel1
        '
        Me.NewLabel1.AutoSize = True
        Me.NewLabel1.BackColor = System.Drawing.Color.DarkCyan
        Me.NewLabel1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabel1.Location = New System.Drawing.Point(436, 205)
        Me.NewLabel1.Name = "NewLabel1"
        Me.NewLabel1.Size = New System.Drawing.Size(210, 31)
        Me.NewLabel1.TabIndex = 63
        Me.NewLabel1.Text = "New Username :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(575, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 47)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OrangeRed
        Me.Label1.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 45)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Please Fill Out The Spaces Below Accordingly"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(655, 319)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(154, 36)
        Me.PasswordTextBox.TabIndex = 60
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(654, 263)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(154, 31)
        Me.UsernameTextBox.TabIndex = 59
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Cyan
        Me.PasswordLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(471, 324)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(175, 31)
        Me.PasswordLabel.TabIndex = 58
        Me.PasswordLabel.Text = "Current Pin :"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Cyan
        Me.UsernameLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(392, 263)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(254, 31)
        Me.UsernameLabel.TabIndex = 57
        Me.UsernameLabel.Text = "Current Username :"
        '
        'ReceptionistpinDataSet
        '
        Me.ReceptionistpinDataSet.DataSetName = "ReceptionistpinDataSet"
        Me.ReceptionistpinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceptionistBindingSource
        '
        Me.ReceptionistBindingSource.DataMember = "Receptionist"
        Me.ReceptionistBindingSource.DataSource = Me.ReceptionistpinDataSet
        '
        'ReceptionistTableAdapter
        '
        Me.ReceptionistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ReceptionistTableAdapter = Me.ReceptionistTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ReceptionistpinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceptionistnameTextBox
        '
        Me.ReceptionistnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptionistBindingSource, "Receptionistname", True))
        Me.ReceptionistnameTextBox.Location = New System.Drawing.Point(33, 63)
        Me.ReceptionistnameTextBox.Name = "ReceptionistnameTextBox"
        Me.ReceptionistnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReceptionistnameTextBox.TabIndex = 72
        '
        'Mypin1TextBox
        '
        Me.Mypin1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptionistBindingSource, "Mypin1", True))
        Me.Mypin1TextBox.Location = New System.Drawing.Point(33, 89)
        Me.Mypin1TextBox.Name = "Mypin1TextBox"
        Me.Mypin1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Mypin1TextBox.TabIndex = 74
        '
        'ReceptionistpinForm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._806120488_323110
        Me.ClientSize = New System.Drawing.Size(1206, 611)
        Me.Controls.Add(Me.ReceptionistnameTextBox)
        Me.Controls.Add(Me.Mypin1TextBox)
        Me.Controls.Add(Me.myHelpButton)
        Me.Controls.Add(Me.NewButton1)
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
        Me.Name = "ReceptionistpinForm24"
        Me.Text = "RECEPTIONIST PIN"
        CType(Me.ReceptionistpinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptionistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myHelpButton As System.Windows.Forms.Button
    Friend WithEvents NewButton1 As System.Windows.Forms.Button
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
    Friend WithEvents ReceptionistpinDataSet As WindowsApplication1.ReceptionistpinDataSet
    Friend WithEvents ReceptionistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceptionistTableAdapter As WindowsApplication1.ReceptionistpinDataSetTableAdapters.ReceptionistTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.ReceptionistpinDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceptionistnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mypin1TextBox As System.Windows.Forms.TextBox
End Class
