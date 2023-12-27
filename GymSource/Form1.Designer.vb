<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginScreen))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_exit = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_login = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_password = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_user = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 8
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 30)
        Me.Panel1.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.AnimationHoverSpeed = 0.07!
        Me.btn_exit.AnimationSpeed = 0.03!
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_exit.IconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_exit.IconSize = 15.0!
        Me.btn_exit.Location = New System.Drawing.Point(555, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_exit.OnHoverIconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_exit.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exit.Size = New System.Drawing.Size(45, 30)
        Me.btn_exit.TabIndex = 0
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 30)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(600, 58)
        Me.GunaPanel1.TabIndex = 2
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 88)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(600, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 208)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(600, 30)
        Me.GunaPanel2.TabIndex = 4
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 238)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(600, 42)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 5
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 280)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(600, 60)
        Me.GunaPanel3.TabIndex = 6
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.btn_login)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel4.Controls.Add(Me.txt_password)
        Me.GunaPanel4.Controls.Add(Me.txt_user)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 340)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(600, 224)
        Me.GunaPanel4.TabIndex = 7
        '
        'btn_login
        '
        Me.btn_login.AnimationHoverSpeed = 0.07!
        Me.btn_login.AnimationSpeed = 0.03!
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BaseColor = System.Drawing.Color.Empty
        Me.btn_login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_login.BorderSize = 1
        Me.btn_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_login.Font = New System.Drawing.Font("Muli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_login.Image = Nothing
        Me.btn_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_login.Location = New System.Drawing.Point(217, 155)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.btn_login.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_login.OnHoverImage = Nothing
        Me.btn_login.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_login.Radius = 10
        Me.btn_login.Size = New System.Drawing.Size(168, 45)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Entrar"
        Me.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Muli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(213, 71)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(81, 19)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Contraseña"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Muli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(213, 3)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(56, 19)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Usuario"
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BaseColor = System.Drawing.Color.White
        Me.txt_password.BorderColor = System.Drawing.Color.Silver
        Me.txt_password.BorderSize = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_password.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Muli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(217, 98)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.Radius = 8
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(168, 30)
        Me.txt_password.TabIndex = 0
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.Transparent
        Me.txt_user.BaseColor = System.Drawing.Color.White
        Me.txt_user.BorderColor = System.Drawing.Color.Silver
        Me.txt_user.BorderSize = 0
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_user.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_user.Font = New System.Drawing.Font("Muli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(217, 30)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.Radius = 8
        Me.txt_user.SelectedText = ""
        Me.txt_user.Size = New System.Drawing.Size(168, 30)
        Me.txt_user.TabIndex = 0
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 766)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "LoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GYM SOURCE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_exit As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txt_user As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_login As Guna.UI.WinForms.GunaButton
End Class
