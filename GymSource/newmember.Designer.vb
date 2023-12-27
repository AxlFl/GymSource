<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newmember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newmember))
        Me.blankpanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.panel_info = New Guna.UI.WinForms.GunaPanel()
        Me.check_night = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.check_morning = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_new_member_reg = New Guna.UI2.WinForms.Guna2Button()
        Me.comb_membresia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.check_female = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.check_male = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_inf_princ = New Guna.UI.WinForms.GunaLabel()
        Me.txt_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_phn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_names = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.panel_info.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blankpanel1
        '
        Me.blankpanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.blankpanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.blankpanel1.Location = New System.Drawing.Point(0, 0)
        Me.blankpanel1.Name = "blankpanel1"
        Me.blankpanel1.Size = New System.Drawing.Size(980, 37)
        Me.blankpanel1.TabIndex = 0
        '
        'panel_info
        '
        Me.panel_info.Controls.Add(Me.check_night)
        Me.panel_info.Controls.Add(Me.check_morning)
        Me.panel_info.Controls.Add(Me.btn_exit)
        Me.panel_info.Controls.Add(Me.btn_new_member_reg)
        Me.panel_info.Controls.Add(Me.comb_membresia)
        Me.panel_info.Controls.Add(Me.Guna2VSeparator1)
        Me.panel_info.Controls.Add(Me.GunaPictureBox1)
        Me.panel_info.Controls.Add(Me.check_female)
        Me.panel_info.Controls.Add(Me.check_male)
        Me.panel_info.Controls.Add(Me.GunaLabel2)
        Me.panel_info.Controls.Add(Me.GunaLabel4)
        Me.panel_info.Controls.Add(Me.GunaLabel3)
        Me.panel_info.Controls.Add(Me.GunaLabel1)
        Me.panel_info.Controls.Add(Me.lbl_inf_princ)
        Me.panel_info.Controls.Add(Me.txt_lastname)
        Me.panel_info.Controls.Add(Me.txt_email)
        Me.panel_info.Controls.Add(Me.txt_phn)
        Me.panel_info.Controls.Add(Me.txt_names)
        Me.panel_info.Location = New System.Drawing.Point(28, 130)
        Me.panel_info.Name = "panel_info"
        Me.panel_info.Size = New System.Drawing.Size(925, 473)
        Me.panel_info.TabIndex = 2
        '
        'check_night
        '
        Me.check_night.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.check_night.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_night.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.check_night.Image = CType(resources.GetObject("check_night.Image"), System.Drawing.Image)
        Me.check_night.ImageOffset = New System.Drawing.Point(0, 0)
        Me.check_night.ImageRotate = 0!
        Me.check_night.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_night.Location = New System.Drawing.Point(435, 241)
        Me.check_night.Name = "check_night"
        Me.check_night.Size = New System.Drawing.Size(69, 59)
        Me.check_night.TabIndex = 19
        '
        'check_morning
        '
        Me.check_morning.CheckedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.check_morning.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_morning.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.check_morning.Image = CType(resources.GetObject("check_morning.Image"), System.Drawing.Image)
        Me.check_morning.ImageOffset = New System.Drawing.Point(0, 0)
        Me.check_morning.ImageRotate = 0!
        Me.check_morning.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_morning.Location = New System.Drawing.Point(341, 241)
        Me.check_morning.Name = "check_morning"
        Me.check_morning.Size = New System.Drawing.Size(69, 59)
        Me.check_morning.TabIndex = 19
        '
        'btn_exit
        '
        Me.btn_exit.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_exit.HoverState.ImageSize = New System.Drawing.Size(32, 32)
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_exit.ImageRotate = 0!
        Me.btn_exit.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_exit.Location = New System.Drawing.Point(17, 26)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_exit.Size = New System.Drawing.Size(64, 54)
        Me.btn_exit.TabIndex = 18
        '
        'btn_new_member_reg
        '
        Me.btn_new_member_reg.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_new_member_reg.BorderRadius = 18
        Me.btn_new_member_reg.BorderThickness = 1
        Me.btn_new_member_reg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_new_member_reg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_new_member_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_new_member_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_new_member_reg.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_new_member_reg.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_member_reg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_new_member_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_new_member_reg.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_new_member_reg.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_new_member_reg.Location = New System.Drawing.Point(698, 417)
        Me.btn_new_member_reg.Name = "btn_new_member_reg"
        Me.btn_new_member_reg.PressedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_new_member_reg.Size = New System.Drawing.Size(180, 37)
        Me.btn_new_member_reg.TabIndex = 17
        Me.btn_new_member_reg.Text = "Registrar"
        '
        'comb_membresia
        '
        Me.comb_membresia.BackColor = System.Drawing.Color.Transparent
        Me.comb_membresia.BorderRadius = 15
        Me.comb_membresia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comb_membresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comb_membresia.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comb_membresia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comb_membresia.Font = New System.Drawing.Font("Muli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_membresia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comb_membresia.ItemHeight = 24
        Me.comb_membresia.Items.AddRange(New Object() {"Mes", "Quincena", "Semana"})
        Me.comb_membresia.Location = New System.Drawing.Point(341, 339)
        Me.comb_membresia.Name = "comb_membresia"
        Me.comb_membresia.Size = New System.Drawing.Size(261, 30)
        Me.comb_membresia.TabIndex = 16
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillThickness = 2
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(644, 64)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 314)
        Me.Guna2VSeparator1.TabIndex = 15
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 109)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(247, 252)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 14
        Me.GunaPictureBox1.TabStop = False
        '
        'check_female
        '
        Me.check_female.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.check_female.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_female.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.check_female.Image = CType(resources.GetObject("check_female.Image"), System.Drawing.Image)
        Me.check_female.ImageOffset = New System.Drawing.Point(0, 0)
        Me.check_female.ImageRotate = 0!
        Me.check_female.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_female.Location = New System.Drawing.Point(435, 152)
        Me.check_female.Name = "check_female"
        Me.check_female.PressedState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.check_female.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_female.Size = New System.Drawing.Size(69, 59)
        Me.check_female.TabIndex = 11
        '
        'check_male
        '
        Me.check_male.CheckedState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.check_male.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_male.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.check_male.Image = CType(resources.GetObject("check_male.Image"), System.Drawing.Image)
        Me.check_male.ImageOffset = New System.Drawing.Point(0, 0)
        Me.check_male.ImageRotate = 0!
        Me.check_male.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_male.Location = New System.Drawing.Point(341, 152)
        Me.check_male.Name = "check_male"
        Me.check_male.PressedState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.check_male.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.check_male.Size = New System.Drawing.Size(69, 59)
        Me.check_male.TabIndex = 10
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(295, 309)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 16)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Membresia"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(295, 212)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(44, 16)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "Turno"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel3.Location = New System.Drawing.Point(672, 50)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(140, 16)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "Informacion Opcional"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(295, 133)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(36, 16)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Sexo"
        '
        'lbl_inf_princ
        '
        Me.lbl_inf_princ.AutoSize = True
        Me.lbl_inf_princ.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inf_princ.Location = New System.Drawing.Point(293, 0)
        Me.lbl_inf_princ.Name = "lbl_inf_princ"
        Me.lbl_inf_princ.Size = New System.Drawing.Size(218, 26)
        Me.lbl_inf_princ.TabIndex = 4
        Me.lbl_inf_princ.Text = "Informacion Principal"
        '
        'txt_lastname
        '
        Me.txt_lastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_lastname.BorderRadius = 15
        Me.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastname.DefaultText = ""
        Me.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.Font = New System.Drawing.Font("Muli", 9.0!)
        Me.txt_lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.IconLeft = CType(resources.GetObject("txt_lastname.IconLeft"), System.Drawing.Image)
        Me.txt_lastname.IconLeftOffset = New System.Drawing.Point(1, 0)
        Me.txt_lastname.Location = New System.Drawing.Point(298, 88)
        Me.txt_lastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastname.PlaceholderText = "apellidos"
        Me.txt_lastname.SelectedText = ""
        Me.txt_lastname.Size = New System.Drawing.Size(304, 30)
        Me.txt_lastname.TabIndex = 3
        '
        'txt_email
        '
        Me.txt_email.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_email.BorderRadius = 15
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Muli", 9.0!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.IconLeft = CType(resources.GetObject("txt_email.IconLeft"), System.Drawing.Image)
        Me.txt_email.IconLeftOffset = New System.Drawing.Point(1, 0)
        Me.txt_email.IconLeftSize = New System.Drawing.Size(17, 17)
        Me.txt_email.Location = New System.Drawing.Point(660, 133)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = "Correo"
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(246, 30)
        Me.txt_email.TabIndex = 3
        '
        'txt_phn
        '
        Me.txt_phn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_phn.BorderRadius = 15
        Me.txt_phn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phn.DefaultText = ""
        Me.txt_phn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_phn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_phn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phn.Font = New System.Drawing.Font("Muli", 9.0!)
        Me.txt_phn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_phn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phn.IconLeft = CType(resources.GetObject("txt_phn.IconLeft"), System.Drawing.Image)
        Me.txt_phn.Location = New System.Drawing.Point(660, 92)
        Me.txt_phn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_phn.Name = "txt_phn"
        Me.txt_phn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phn.PlaceholderText = "Celular"
        Me.txt_phn.SelectedText = ""
        Me.txt_phn.Size = New System.Drawing.Size(246, 30)
        Me.txt_phn.TabIndex = 3
        '
        'txt_names
        '
        Me.txt_names.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txt_names.BorderRadius = 15
        Me.txt_names.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_names.DefaultText = ""
        Me.txt_names.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_names.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_names.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_names.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_names.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_names.Font = New System.Drawing.Font("Muli", 9.0!)
        Me.txt_names.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_names.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_names.IconLeft = CType(resources.GetObject("txt_names.IconLeft"), System.Drawing.Image)
        Me.txt_names.Location = New System.Drawing.Point(298, 50)
        Me.txt_names.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_names.Name = "txt_names"
        Me.txt_names.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_names.PlaceholderText = "nombres"
        Me.txt_names.SelectedText = ""
        Me.txt_names.Size = New System.Drawing.Size(304, 30)
        Me.txt_names.TabIndex = 3
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'newmember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 690)
        Me.Controls.Add(Me.panel_info)
        Me.Controls.Add(Me.blankpanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newmember"
        Me.Text = "newmember"
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents blankpanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents panel_info As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_inf_princ As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_names As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents check_female As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents check_male As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents comb_membresia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_new_member_reg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_phn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents check_morning As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents check_night As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
