<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemberList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberList))
        Me.blankpanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.comb_filter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.comb_membresia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_amount_members = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_update = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_search = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_searchmember = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdMiembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMiembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosMiembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turnoMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.blankpanel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blankpanel1
        '
        Me.blankpanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.blankpanel1.Controls.Add(Me.comb_filter)
        Me.blankpanel1.Controls.Add(Me.GunaLabel3)
        Me.blankpanel1.Controls.Add(Me.comb_membresia)
        Me.blankpanel1.Controls.Add(Me.GunaLabel2)
        Me.blankpanel1.Controls.Add(Me.GunaLabel1)
        Me.blankpanel1.Controls.Add(Me.lbl_amount_members)
        Me.blankpanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.blankpanel1.Location = New System.Drawing.Point(0, 0)
        Me.blankpanel1.Name = "blankpanel1"
        Me.blankpanel1.Size = New System.Drawing.Size(964, 71)
        Me.blankpanel1.TabIndex = 1
        '
        'comb_filter
        '
        Me.comb_filter.BackColor = System.Drawing.Color.Transparent
        Me.comb_filter.BorderRadius = 15
        Me.comb_filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comb_filter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comb_filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comb_filter.Font = New System.Drawing.Font("Muli", 9.75!)
        Me.comb_filter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comb_filter.ItemHeight = 24
        Me.comb_filter.Items.AddRange(New Object() {"Activos", "Inactivos", "Mensual", "Quincenal", "Semenal"})
        Me.comb_filter.Location = New System.Drawing.Point(706, 25)
        Me.comb_filter.Name = "comb_filter"
        Me.comb_filter.Size = New System.Drawing.Size(199, 30)
        Me.comb_filter.TabIndex = 18
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel3.Location = New System.Drawing.Point(631, 30)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(54, 20)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "Filtrar:"
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
        Me.comb_membresia.Items.AddRange(New Object() {"ID", "Alfabetico", "Membresia", "Turno", "Estado"})
        Me.comb_membresia.Location = New System.Drawing.Point(391, 25)
        Me.comb_membresia.Name = "comb_membresia"
        Me.comb_membresia.Size = New System.Drawing.Size(199, 30)
        Me.comb_membresia.TabIndex = 18
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel2.Location = New System.Drawing.Point(287, 30)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(98, 20)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Ordenar por:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel1.Location = New System.Drawing.Point(87, 29)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(82, 20)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "miembros"
        '
        'lbl_amount_members
        '
        Me.lbl_amount_members.AutoSize = True
        Me.lbl_amount_members.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount_members.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lbl_amount_members.Location = New System.Drawing.Point(30, 11)
        Me.lbl_amount_members.Name = "lbl_amount_members"
        Me.lbl_amount_members.Size = New System.Drawing.Size(59, 44)
        Me.lbl_amount_members.TabIndex = 0
        Me.lbl_amount_members.Text = "02"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.Guna2TextBox1)
        Me.GunaPanel1.Controls.Add(Me.lbl_search)
        Me.GunaPanel1.Controls.Add(Me.btn_searchmember)
        Me.GunaPanel1.Controls.Add(Me.btn_update)
        Me.GunaPanel1.Controls.Add(Me.btn_delete)
        Me.GunaPanel1.Controls.Add(Me.btn_exit)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 574)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(964, 77)
        Me.GunaPanel1.TabIndex = 3
        '
        'btn_update
        '
        Me.btn_update.AutoRoundedCorners = True
        Me.btn_update.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.BorderRadius = 15
        Me.btn_update.BorderThickness = 1
        Me.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_update.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(598, 20)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.PressedColor = System.Drawing.Color.Transparent
        Me.btn_update.Size = New System.Drawing.Size(152, 33)
        Me.btn_update.TabIndex = 20
        Me.btn_update.Text = "Actualizar"
        '
        'btn_delete
        '
        Me.btn_delete.AutoRoundedCorners = True
        Me.btn_delete.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.BorderRadius = 15
        Me.btn_delete.BorderThickness = 1
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(768, 20)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(173, 33)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "Borrar"
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_search.Location = New System.Drawing.Point(151, 26)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(91, 20)
        Me.lbl_search.TabIndex = 21
        Me.lbl_search.Text = "Member ID:"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(257, 20)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(128, 33)
        Me.Guna2TextBox1.TabIndex = 22
        '
        'btn_searchmember
        '
        Me.btn_searchmember.AutoRoundedCorners = True
        Me.btn_searchmember.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_searchmember.BorderRadius = 15
        Me.btn_searchmember.BorderThickness = 1
        Me.btn_searchmember.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_searchmember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_searchmember.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_searchmember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_searchmember.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_searchmember.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btn_searchmember.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_searchmember.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_searchmember.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_searchmember.Location = New System.Drawing.Point(391, 20)
        Me.btn_searchmember.Name = "btn_searchmember"
        Me.btn_searchmember.PressedColor = System.Drawing.Color.Transparent
        Me.btn_searchmember.Size = New System.Drawing.Size(125, 33)
        Me.btn_searchmember.TabIndex = 20
        Me.btn_searchmember.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 503)
        Me.Panel1.TabIndex = 4
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 38
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMiembro, Me.NombreMiembro, Me.ApellidosMiembro, Me.TypeMember, Me.turnoMember, Me.StateMember, Me.MemberStart, Me.EndMember})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(12, 20)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(940, 464)
        Me.Guna2DataGridView1.TabIndex = 3
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 38
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IdMiembro
        '
        Me.IdMiembro.HeaderText = "ID Miembro"
        Me.IdMiembro.Name = "IdMiembro"
        '
        'NombreMiembro
        '
        Me.NombreMiembro.HeaderText = "Nombres"
        Me.NombreMiembro.Name = "NombreMiembro"
        '
        'ApellidosMiembro
        '
        Me.ApellidosMiembro.HeaderText = "Apellidos"
        Me.ApellidosMiembro.Name = "ApellidosMiembro"
        '
        'TypeMember
        '
        Me.TypeMember.HeaderText = "Tipo Membresia"
        Me.TypeMember.Name = "TypeMember"
        '
        'turnoMember
        '
        Me.turnoMember.HeaderText = "Turno"
        Me.turnoMember.Name = "turnoMember"
        '
        'StateMember
        '
        Me.StateMember.HeaderText = "Estado Membresia"
        Me.StateMember.Name = "StateMember"
        '
        'MemberStart
        '
        Me.MemberStart.HeaderText = "Inicio Membresia"
        Me.MemberStart.Name = "MemberStart"
        '
        'EndMember
        '
        Me.EndMember.HeaderText = "Fin Membresia"
        Me.EndMember.Name = "EndMember"
        '
        'btn_exit
        '
        Me.btn_exit.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_exit.HoverState.ImageSize = New System.Drawing.Size(32, 32)
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_exit.ImageRotate = 0!
        Me.btn_exit.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_exit.Location = New System.Drawing.Point(12, 11)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_exit.Size = New System.Drawing.Size(64, 54)
        Me.btn_exit.TabIndex = 19
        '
        'MemberList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.blankpanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberList"
        Me.Text = "MemberList"
        Me.blankpanel1.ResumeLayout(False)
        Me.blankpanel1.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents blankpanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_amount_members As Guna.UI.WinForms.GunaLabel
    Friend WithEvents comb_membresia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents comb_filter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_search As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_searchmember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IdMiembro As DataGridViewTextBoxColumn
    Friend WithEvents NombreMiembro As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosMiembro As DataGridViewTextBoxColumn
    Friend WithEvents TypeMember As DataGridViewTextBoxColumn
    Friend WithEvents turnoMember As DataGridViewTextBoxColumn
    Friend WithEvents StateMember As DataGridViewTextBoxColumn
    Friend WithEvents MemberStart As DataGridViewTextBoxColumn
    Friend WithEvents EndMember As DataGridViewTextBoxColumn
End Class
