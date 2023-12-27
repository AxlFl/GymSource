<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_exit = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelholder = New System.Windows.Forms.Panel()
        Me.btn_logout = New Guna.UI.WinForms.GunaButton()
        Me.btn_employees = New Guna.UI.WinForms.GunaButton()
        Me.btn_payment = New Guna.UI.WinForms.GunaButton()
        Me.btn_memberlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_newmember = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 30)
        Me.Panel1.TabIndex = 1
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1190, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 30)
        Me.GunaControlBox1.TabIndex = 2
        '
        'btn_exit
        '
        Me.btn_exit.AnimationHoverSpeed = 0.07!
        Me.btn_exit.AnimationSpeed = 0.03!
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_exit.IconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_exit.IconSize = 15.0!
        Me.btn_exit.Location = New System.Drawing.Point(1235, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_exit.OnHoverIconColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_exit.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exit.Size = New System.Drawing.Size(45, 30)
        Me.btn_exit.TabIndex = 1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btn_logout)
        Me.GunaPanel1.Controls.Add(Me.btn_employees)
        Me.GunaPanel1.Controls.Add(Me.btn_payment)
        Me.GunaPanel1.Controls.Add(Me.btn_memberlist)
        Me.GunaPanel1.Controls.Add(Me.btn_newmember)
        Me.GunaPanel1.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 30)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(280, 690)
        Me.GunaPanel1.TabIndex = 2
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 195)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(280, 35)
        Me.GunaPanel3.TabIndex = 3
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 133)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(280, 10)
        Me.GunaPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(280, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 690)
        Me.Panel3.TabIndex = 3
        '
        'panelholder
        '
        Me.panelholder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelholder.Location = New System.Drawing.Point(300, 30)
        Me.panelholder.Name = "panelholder"
        Me.panelholder.Size = New System.Drawing.Size(980, 690)
        Me.panelholder.TabIndex = 4
        '
        'btn_logout
        '
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logout.FocusedColor = System.Drawing.Color.Empty
        Me.btn_logout.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_logout.Location = New System.Drawing.Point(0, 398)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(280, 42)
        Me.btn_logout.TabIndex = 11
        Me.btn_logout.Text = "Cerrar Sesion"
        '
        'btn_employees
        '
        Me.btn_employees.AnimationHoverSpeed = 0.07!
        Me.btn_employees.AnimationSpeed = 0.03!
        Me.btn_employees.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_employees.BorderColor = System.Drawing.Color.Black
        Me.btn_employees.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_employees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_employees.FocusedColor = System.Drawing.Color.Empty
        Me.btn_employees.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_employees.Image = CType(resources.GetObject("btn_employees.Image"), System.Drawing.Image)
        Me.btn_employees.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_employees.Location = New System.Drawing.Point(0, 356)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_employees.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_employees.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_employees.OnHoverImage = Nothing
        Me.btn_employees.OnPressedColor = System.Drawing.Color.Black
        Me.btn_employees.Size = New System.Drawing.Size(280, 42)
        Me.btn_employees.TabIndex = 10
        Me.btn_employees.Text = "Control de Empleados"
        '
        'btn_payment
        '
        Me.btn_payment.AnimationHoverSpeed = 0.07!
        Me.btn_payment.AnimationSpeed = 0.03!
        Me.btn_payment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_payment.BorderColor = System.Drawing.Color.Black
        Me.btn_payment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_payment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_payment.FocusedColor = System.Drawing.Color.Empty
        Me.btn_payment.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_payment.Image = CType(resources.GetObject("btn_payment.Image"), System.Drawing.Image)
        Me.btn_payment.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_payment.Location = New System.Drawing.Point(0, 314)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_payment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_payment.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_payment.OnHoverImage = Nothing
        Me.btn_payment.OnPressedColor = System.Drawing.Color.Black
        Me.btn_payment.Size = New System.Drawing.Size(280, 42)
        Me.btn_payment.TabIndex = 9
        Me.btn_payment.Text = "Informacion de pagos"
        '
        'btn_memberlist
        '
        Me.btn_memberlist.AnimationHoverSpeed = 0.07!
        Me.btn_memberlist.AnimationSpeed = 0.03!
        Me.btn_memberlist.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_memberlist.BorderColor = System.Drawing.Color.Black
        Me.btn_memberlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_memberlist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_memberlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_memberlist.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_memberlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_memberlist.Image = CType(resources.GetObject("btn_memberlist.Image"), System.Drawing.Image)
        Me.btn_memberlist.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_memberlist.Location = New System.Drawing.Point(0, 272)
        Me.btn_memberlist.Name = "btn_memberlist"
        Me.btn_memberlist.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_memberlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_memberlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_memberlist.OnHoverImage = Nothing
        Me.btn_memberlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_memberlist.Size = New System.Drawing.Size(280, 42)
        Me.btn_memberlist.TabIndex = 8
        Me.btn_memberlist.Text = "Lista de Miembros"
        '
        'btn_newmember
        '
        Me.btn_newmember.AnimationHoverSpeed = 0.07!
        Me.btn_newmember.AnimationSpeed = 0.03!
        Me.btn_newmember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_newmember.BorderColor = System.Drawing.Color.Black
        Me.btn_newmember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_newmember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_newmember.FocusedColor = System.Drawing.Color.Empty
        Me.btn_newmember.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newmember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_newmember.Image = CType(resources.GetObject("btn_newmember.Image"), System.Drawing.Image)
        Me.btn_newmember.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_newmember.Location = New System.Drawing.Point(0, 230)
        Me.btn_newmember.Name = "btn_newmember"
        Me.btn_newmember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_newmember.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_newmember.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_newmember.OnHoverImage = Nothing
        Me.btn_newmember.OnPressedColor = System.Drawing.Color.Black
        Me.btn_newmember.Size = New System.Drawing.Size(280, 42)
        Me.btn_newmember.TabIndex = 6
        Me.btn_newmember.Text = "Nuevo Miembro"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 143)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(280, 52)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 2
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(280, 133)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.panelholder)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_exit As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_newmember As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_employees As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_payment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_memberlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents panelholder As Panel
End Class
