<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contrato
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contrato))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodcontracteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatainiciDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestsmensualsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaultimamodificaioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContracteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestio_empresesDataSet = New Gestor_de_academias.Gestio_empresesDataSet()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.crearContracte = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContracteTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.contracteTableAdapter()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxInsertQtyTest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.ButtonCreateContract = New FontAwesome.Sharp.IconButton()
        Me.closeCreateContracte = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxBuscarEmpresa = New System.Windows.Forms.GroupBox()
        Me.ButtonOkEmpresa = New FontAwesome.Sharp.IconButton()
        Me.ButtonSearchEmp = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxSearchEmp = New System.Windows.Forms.ComboBox()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextSearchEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CategoriatestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Categoria_testTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter()
        Me.nomEmpFilter = New System.Windows.Forms.TextBox()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.closeShowContract = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxBuscarEmpresa.SuspendLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.crearContracte)
        Me.Panel1.Location = New System.Drawing.Point(63, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 735)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodcontracteDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.DatainiciDataGridViewTextBoxColumn, Me.TestsmensualsDataGridViewTextBoxColumn, Me.FechaultimamodificaioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContracteBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SlateBlue
        Me.DataGridView1.Location = New System.Drawing.Point(18, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(535, 646)
        Me.DataGridView1.TabIndex = 3
        '
        'CodcontracteDataGridViewTextBoxColumn
        '
        Me.CodcontracteDataGridViewTextBoxColumn.DataPropertyName = "cod_contracte"
        Me.CodcontracteDataGridViewTextBoxColumn.HeaderText = "Núm. Contracte"
        Me.CodcontracteDataGridViewTextBoxColumn.Name = "CodcontracteDataGridViewTextBoxColumn"
        Me.CodcontracteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "CIF"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatainiciDataGridViewTextBoxColumn
        '
        Me.DatainiciDataGridViewTextBoxColumn.DataPropertyName = "data_inici"
        Me.DatainiciDataGridViewTextBoxColumn.HeaderText = "Data Inicial"
        Me.DatainiciDataGridViewTextBoxColumn.Name = "DatainiciDataGridViewTextBoxColumn"
        Me.DatainiciDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestsmensualsDataGridViewTextBoxColumn
        '
        Me.TestsmensualsDataGridViewTextBoxColumn.DataPropertyName = "tests_mensuals"
        Me.TestsmensualsDataGridViewTextBoxColumn.HeaderText = "Tests mensuals"
        Me.TestsmensualsDataGridViewTextBoxColumn.Name = "TestsmensualsDataGridViewTextBoxColumn"
        Me.TestsmensualsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaultimamodificaioDataGridViewTextBoxColumn
        '
        Me.FechaultimamodificaioDataGridViewTextBoxColumn.DataPropertyName = "fecha_ultima_modificaio"
        Me.FechaultimamodificaioDataGridViewTextBoxColumn.HeaderText = "Última actualització"
        Me.FechaultimamodificaioDataGridViewTextBoxColumn.Name = "FechaultimamodificaioDataGridViewTextBoxColumn"
        Me.FechaultimamodificaioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContracteBindingSource
        '
        Me.ContracteBindingSource.DataMember = "contracte"
        Me.ContracteBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'Gestio_empresesDataSet
        '
        Me.Gestio_empresesDataSet.DataSetName = "gestio_empresesDataSet"
        Me.Gestio_empresesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(414, 18)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(112, 31)
        Me.IconButton1.TabIndex = 27
        Me.IconButton1.Text = "     Eliminar"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'crearContracte
        '
        Me.crearContracte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.crearContracte.FlatAppearance.BorderSize = 0
        Me.crearContracte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crearContracte.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crearContracte.ForeColor = System.Drawing.Color.White
        Me.crearContracte.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.crearContracte.IconColor = System.Drawing.Color.White
        Me.crearContracte.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.crearContracte.IconSize = 20
        Me.crearContracte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.crearContracte.Location = New System.Drawing.Point(296, 18)
        Me.crearContracte.Name = "crearContracte"
        Me.crearContracte.Size = New System.Drawing.Size(112, 31)
        Me.crearContracte.TabIndex = 26
        Me.crearContracte.Text = "    Crear"
        Me.crearContracte.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(975, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(590, 799)
        Me.Panel5.TabIndex = 24
        Me.Panel5.Visible = False
        '
        'ContracteTableAdapter
        '
        Me.ContracteTableAdapter.ClearBeforeFill = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Plum
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.ButtonCreateContract)
        Me.Panel6.Controls.Add(Me.closeCreateContracte)
        Me.Panel6.Controls.Add(Me.GroupBoxBuscarEmpresa)
        Me.Panel6.Location = New System.Drawing.Point(635, 75)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 298)
        Me.Panel6.TabIndex = 25
        Me.Panel6.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxInsertQtyTest)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.IconButton2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 88)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'TextBoxInsertQtyTest
        '
        Me.TextBoxInsertQtyTest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxInsertQtyTest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInsertQtyTest.ForeColor = System.Drawing.Color.Purple
        Me.TextBoxInsertQtyTest.Location = New System.Drawing.Point(78, 22)
        Me.TextBoxInsertQtyTest.Name = "TextBoxInsertQtyTest"
        Me.TextBoxInsertQtyTest.Size = New System.Drawing.Size(69, 15)
        Me.TextBoxInsertQtyTest.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Quantitat "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(158, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "unitats mensuals"
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(116, 54)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(56, 26)
        Me.IconButton2.TabIndex = 45
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'ButtonCreateContract
        '
        Me.ButtonCreateContract.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCreateContract.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonCreateContract.FlatAppearance.BorderSize = 2
        Me.ButtonCreateContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCreateContract.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateContract.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateContract.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonCreateContract.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateContract.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCreateContract.IconSize = 20
        Me.ButtonCreateContract.Location = New System.Drawing.Point(93, 250)
        Me.ButtonCreateContract.Name = "ButtonCreateContract"
        Me.ButtonCreateContract.Size = New System.Drawing.Size(137, 26)
        Me.ButtonCreateContract.TabIndex = 45
        Me.ButtonCreateContract.Text = "Generar contracte"
        Me.ButtonCreateContract.UseVisualStyleBackColor = False
        '
        'closeCreateContracte
        '
        Me.closeCreateContracte.BackColor = System.Drawing.Color.Transparent
        Me.closeCreateContracte.FlatAppearance.BorderSize = 0
        Me.closeCreateContracte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCreateContracte.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.closeCreateContracte.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.closeCreateContracte.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeCreateContracte.IconSize = 40
        Me.closeCreateContracte.Location = New System.Drawing.Point(289, 15)
        Me.closeCreateContracte.Name = "closeCreateContracte"
        Me.closeCreateContracte.Size = New System.Drawing.Size(30, 35)
        Me.closeCreateContracte.TabIndex = 38
        Me.closeCreateContracte.UseVisualStyleBackColor = False
        '
        'GroupBoxBuscarEmpresa
        '
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonOkEmpresa)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ComboBoxSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.TextSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label4)
        Me.GroupBoxBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxBuscarEmpresa.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarEmpresa.Location = New System.Drawing.Point(15, 28)
        Me.GroupBoxBuscarEmpresa.Name = "GroupBoxBuscarEmpresa"
        Me.GroupBoxBuscarEmpresa.Size = New System.Drawing.Size(268, 107)
        Me.GroupBoxBuscarEmpresa.TabIndex = 35
        Me.GroupBoxBuscarEmpresa.TabStop = False
        '
        'ButtonOkEmpresa
        '
        Me.ButtonOkEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOkEmpresa.FlatAppearance.BorderSize = 0
        Me.ButtonOkEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOkEmpresa.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.ButtonOkEmpresa.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonOkEmpresa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonOkEmpresa.IconSize = 20
        Me.ButtonOkEmpresa.Location = New System.Drawing.Point(118, 79)
        Me.ButtonOkEmpresa.Name = "ButtonOkEmpresa"
        Me.ButtonOkEmpresa.Size = New System.Drawing.Size(56, 26)
        Me.ButtonOkEmpresa.TabIndex = 34
        Me.ButtonOkEmpresa.UseVisualStyleBackColor = False
        '
        'ButtonSearchEmp
        '
        Me.ButtonSearchEmp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSearchEmp.FlatAppearance.BorderSize = 0
        Me.ButtonSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchEmp.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ButtonSearchEmp.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSearchEmp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonSearchEmp.IconSize = 20
        Me.ButtonSearchEmp.Location = New System.Drawing.Point(232, 18)
        Me.ButtonSearchEmp.Name = "ButtonSearchEmp"
        Me.ButtonSearchEmp.Size = New System.Drawing.Size(30, 26)
        Me.ButtonSearchEmp.TabIndex = 33
        Me.ButtonSearchEmp.UseVisualStyleBackColor = False
        '
        'ComboBoxSearchEmp
        '
        Me.ComboBoxSearchEmp.BackColor = System.Drawing.Color.Violet
        Me.ComboBoxSearchEmp.DataSource = Me.EmpresaBindingSource
        Me.ComboBoxSearchEmp.DisplayMember = "nom"
        Me.ComboBoxSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxSearchEmp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSearchEmp.ForeColor = System.Drawing.Color.White
        Me.ComboBoxSearchEmp.FormattingEnabled = True
        Me.ComboBoxSearchEmp.Location = New System.Drawing.Point(6, 48)
        Me.ComboBoxSearchEmp.Name = "ComboBoxSearchEmp"
        Me.ComboBoxSearchEmp.Size = New System.Drawing.Size(256, 23)
        Me.ComboBoxSearchEmp.TabIndex = 0
        Me.ComboBoxSearchEmp.ValueMember = "cif"
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'TextSearchEmp
        '
        Me.TextSearchEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextSearchEmp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearchEmp.ForeColor = System.Drawing.Color.Purple
        Me.TextSearchEmp.Location = New System.Drawing.Point(64, 24)
        Me.TextSearchEmp.Name = "TextSearchEmp"
        Me.TextSearchEmp.Size = New System.Drawing.Size(151, 14)
        Me.TextSearchEmp.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Empresa"
        '
        'CategoriatestBindingSource
        '
        Me.CategoriatestBindingSource.DataMember = "categoria_test"
        Me.CategoriatestBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Categoria_testTableAdapter
        '
        Me.Categoria_testTableAdapter.ClearBeforeFill = True
        '
        'nomEmpFilter
        '
        Me.nomEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nomEmpFilter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomEmpFilter.Location = New System.Drawing.Point(141, 19)
        Me.nomEmpFilter.Name = "nomEmpFilter"
        Me.nomEmpFilter.Size = New System.Drawing.Size(342, 14)
        Me.nomEmpFilter.TabIndex = 27
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 26
        Me.IconButton3.Location = New System.Drawing.Point(499, 12)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(42, 32)
        Me.IconButton3.TabIndex = 28
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cerca"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ComboBox1.DataSource = Me.EmpresaBindingSource
        Me.ComboBox1.DisplayMember = "nom"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(141, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(342, 23)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.ValueMember = "cif"
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.Transparent
        Me.IconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 26
        Me.IconButton5.Location = New System.Drawing.Point(539, 12)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(42, 32)
        Me.IconButton5.TabIndex = 31
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'closeShowContract
        '
        Me.closeShowContract.BackColor = System.Drawing.Color.Transparent
        Me.closeShowContract.FlatAppearance.BorderSize = 0
        Me.closeShowContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeShowContract.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.closeShowContract.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.closeShowContract.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeShowContract.IconSize = 40
        Me.closeShowContract.Location = New System.Drawing.Point(1569, 9)
        Me.closeShowContract.Name = "closeShowContract"
        Me.closeShowContract.Size = New System.Drawing.Size(30, 35)
        Me.closeShowContract.TabIndex = 38
        Me.closeShowContract.UseVisualStyleBackColor = False
        Me.closeShowContract.Visible = False
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1597, 823)
        Me.Controls.Add(Me.closeShowContract)
        Me.Controls.Add(Me.IconButton5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.nomEmpFilter)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Contrato"
        Me.Text = "Contrato"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxBuscarEmpresa.ResumeLayout(False)
        Me.GroupBoxBuscarEmpresa.PerformLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Gestio_empresesDataSet As Gestio_empresesDataSet
    Friend WithEvents ContracteBindingSource As BindingSource
    Friend WithEvents ContracteTableAdapter As Gestio_empresesDataSetTableAdapters.contracteTableAdapter
    Friend WithEvents CodecontracteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBoxBuscarEmpresa As GroupBox
    Friend WithEvents ButtonOkEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonSearchEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxSearchEmp As ComboBox
    Friend WithEvents TextSearchEmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents closeCreateContracte As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxInsertQtyTest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCreateContract As FontAwesome.Sharp.IconButton
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As Gestio_empresesDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents CategoriatestBindingSource As BindingSource
    Friend WithEvents Categoria_testTableAdapter As Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter
    Friend WithEvents CodcontracteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatainiciDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestsmensualsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaultimamodificaioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents crearContracte As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents nomEmpFilter As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents closeShowContract As FontAwesome.Sharp.IconButton
End Class
