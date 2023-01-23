<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HomeGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReceptionistCheckBox = New System.Windows.Forms.CheckBox()
        Me.OfficerCheckBox = New System.Windows.Forms.CheckBox()
        Me.ManagerCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeGroupBox
        '
        Me.HomeGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.HomeGroupBox.Controls.Add(Me.PictureBox1)
        Me.HomeGroupBox.Controls.Add(Me.GroupBox1)
        Me.HomeGroupBox.Controls.Add(Me.Label1)
        Me.HomeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HomeGroupBox.Location = New System.Drawing.Point(388, 130)
        Me.HomeGroupBox.Name = "HomeGroupBox"
        Me.HomeGroupBox.Size = New System.Drawing.Size(601, 401)
        Me.HomeGroupBox.TabIndex = 0
        Me.HomeGroupBox.TabStop = False
        Me.HomeGroupBox.Text = "WELCOME "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.ReceptionistCheckBox)
        Me.GroupBox1.Controls.Add(Me.OfficerCheckBox)
        Me.GroupBox1.Controls.Add(Me.ManagerCheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(122, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 185)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'ReceptionistCheckBox
        '
        Me.ReceptionistCheckBox.AutoSize = True
        Me.ReceptionistCheckBox.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceptionistCheckBox.Location = New System.Drawing.Point(18, 121)
        Me.ReceptionistCheckBox.Name = "ReceptionistCheckBox"
        Me.ReceptionistCheckBox.Size = New System.Drawing.Size(161, 26)
        Me.ReceptionistCheckBox.TabIndex = 2
        Me.ReceptionistCheckBox.Text = "RECEPTIONIST"
        Me.ReceptionistCheckBox.UseVisualStyleBackColor = True
        '
        'OfficerCheckBox
        '
        Me.OfficerCheckBox.AutoSize = True
        Me.OfficerCheckBox.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficerCheckBox.Location = New System.Drawing.Point(18, 70)
        Me.OfficerCheckBox.Name = "OfficerCheckBox"
        Me.OfficerCheckBox.Size = New System.Drawing.Size(106, 26)
        Me.OfficerCheckBox.TabIndex = 1
        Me.OfficerCheckBox.Text = "OFFICER"
        Me.OfficerCheckBox.UseVisualStyleBackColor = True
        '
        'ManagerCheckBox
        '
        Me.ManagerCheckBox.AutoSize = True
        Me.ManagerCheckBox.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManagerCheckBox.Location = New System.Drawing.Point(18, 23)
        Me.ManagerCheckBox.Name = "ManagerCheckBox"
        Me.ManagerCheckBox.Size = New System.Drawing.Size(117, 26)
        Me.ManagerCheckBox.TabIndex = 0
        Me.ManagerCheckBox.Text = "Manager"
        Me.ManagerCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PLEASE CHOOSE YOUR WORK OCCUPATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(813, 62)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MATATA AGENCY COMPANY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._435808343_332216
        Me.PictureBox1.Location = New System.Drawing.Point(165, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1289, 465)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HomeGroupBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HomeGroupBox.ResumeLayout(False)
        Me.HomeGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HomeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReceptionistCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OfficerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ManagerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
