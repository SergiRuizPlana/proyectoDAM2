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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContracteTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.contracteTableAdapter()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ButtonCreateContract = New FontAwesome.Sharp.IconButton()
        Me.closeCreateAlbara = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxBuscarEmpresa = New System.Windows.Forms.GroupBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoriaTest = New System.Windows.Forms.ComboBox()
        Me.CategoriatestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonOkEmpresa = New FontAwesome.Sharp.IconButton()
        Me.TextBoxInsertQtyTest = New System.Windows.Forms.TextBox()
        Me.ButtonSearchEmp = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxSearchEmp = New System.Windows.Forms.ComboBox()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextSearchEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpresaTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Categoria_testTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter()
        Me.crearContracte = New FontAwesome.Sharp.IconButton()
        Me.nomEmpFilter = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBoxBuscarEmpresa.SuspendLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.crearContracte)
        Me.Panel1.Location = New System.Drawing.Point(63, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 735)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGridView1.Location = New System.Drawing.Point(28, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(502, 646)
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
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.ButtonCreateContract)
        Me.Panel6.Controls.Add(Me.closeCreateAlbara)
        Me.Panel6.Controls.Add(Me.GroupBoxBuscarEmpresa)
        Me.Panel6.Location = New System.Drawing.Point(635, 75)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 330)
        Me.Panel6.TabIndex = 25
        Me.Panel6.Visible = False
        '
        'ButtonCreateContract
        '
        Me.ButtonCreateContract.BackColor = System.Drawing.Color.Teal
        Me.ButtonCreateContract.FlatAppearance.BorderSize = 0
        Me.ButtonCreateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCreateContract.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateContract.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateContract.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonCreateContract.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateContract.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCreateContract.IconSize = 20
        Me.ButtonCreateContract.Location = New System.Drawing.Point(95, 290)
        Me.ButtonCreateContract.Name = "ButtonCreateContract"
        Me.ButtonCreateContract.Size = New System.Drawing.Size(137, 26)
        Me.ButtonCreateContract.TabIndex = 45
        Me.ButtonCreateContract.Text = "Generar contracte"
        Me.ButtonCreateContract.UseVisualStyleBackColor = False
        '
        'closeCreateAlbara
        '
        Me.closeCreateAlbara.BackColor = System.Drawing.Color.Transparent
        Me.closeCreateAlbara.FlatAppearance.BorderSize = 0
        Me.closeCreateAlbara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCreateAlbara.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.closeCreateAlbara.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.closeCreateAlbara.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeCreateAlbara.IconSize = 40
        Me.closeCreateAlbara.Location = New System.Drawing.Point(291, 5)
        Me.closeCreateAlbara.Name = "closeCreateAlbara"
        Me.closeCreateAlbara.Size = New System.Drawing.Size(30, 35)
        Me.closeCreateAlbara.TabIndex = 38
        Me.closeCreateAlbara.UseVisualStyleBackColor = False
        '
        'GroupBoxBuscarEmpresa
        '
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.IconButton4)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label6)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ComboBoxCategoriaTest)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.IconButton2)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label11)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonOkEmpresa)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.TextBoxInsertQtyTest)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label5)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ComboBoxSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.TextSearchEmp)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label4)
        Me.GroupBoxBuscarEmpresa.Location = New System.Drawing.Point(17, 18)
        Me.GroupBoxBuscarEmpresa.Name = "GroupBoxBuscarEmpresa"
        Me.GroupBoxBuscarEmpresa.Size = New System.Drawing.Size(268, 254)
        Me.GroupBoxBuscarEmpresa.TabIndex = 35
        Me.GroupBoxBuscarEmpresa.TabStop = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.Teal
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 20
        Me.IconButton4.Location = New System.Drawing.Point(118, 218)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(56, 26)
        Me.IconButton4.TabIndex = 48
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Categoria"
        '
        'ComboBoxCategoriaTest
        '
        Me.ComboBoxCategoriaTest.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxCategoriaTest.DataSource = Me.CategoriatestBindingSource
        Me.ComboBoxCategoriaTest.DisplayMember = "descripcio"
        Me.ComboBoxCategoriaTest.FormattingEnabled = True
        Me.ComboBoxCategoriaTest.Location = New System.Drawing.Point(64, 187)
        Me.ComboBoxCategoriaTest.Name = "ComboBoxCategoriaTest"
        Me.ComboBoxCategoriaTest.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxCategoriaTest.TabIndex = 46
        Me.ComboBoxCategoriaTest.ValueMember = "cod_categoria"
        '
        'CategoriatestBindingSource
        '
        Me.CategoriatestBindingSource.DataMember = "categoria_test"
        Me.CategoriatestBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Teal
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(118, 150)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(56, 26)
        Me.IconButton2.TabIndex = 45
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(164, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "unitats mensuals"
        '
        'ButtonOkEmpresa
        '
        Me.ButtonOkEmpresa.BackColor = System.Drawing.Color.Teal
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
        'TextBoxInsertQtyTest
        '
        Me.TextBoxInsertQtyTest.Location = New System.Drawing.Point(66, 118)
        Me.TextBoxInsertQtyTest.Name = "TextBoxInsertQtyTest"
        Me.TextBoxInsertQtyTest.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxInsertQtyTest.TabIndex = 42
        '
        'ButtonSearchEmp
        '
        Me.ButtonSearchEmp.BackColor = System.Drawing.Color.Teal
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Quantitat "
        '
        'ComboBoxSearchEmp
        '
        Me.ComboBoxSearchEmp.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxSearchEmp.DataSource = Me.EmpresaBindingSource
        Me.ComboBoxSearchEmp.DisplayMember = "nom"
        Me.ComboBoxSearchEmp.FormattingEnabled = True
        Me.ComboBoxSearchEmp.Location = New System.Drawing.Point(6, 50)
        Me.ComboBoxSearchEmp.Name = "ComboBoxSearchEmp"
        Me.ComboBoxSearchEmp.Size = New System.Drawing.Size(257, 21)
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
        Me.TextSearchEmp.Location = New System.Drawing.Point(55, 22)
        Me.TextSearchEmp.Name = "TextSearchEmp"
        Me.TextSearchEmp.Size = New System.Drawing.Size(160, 20)
        Me.TextSearchEmp.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Empresa"
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
        'nomEmpFilter
        '
        Me.nomEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nomEmpFilter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomEmpFilter.Location = New System.Drawing.Point(166, 46)
        Me.nomEmpFilter.Name = "nomEmpFilter"
        Me.nomEmpFilter.Size = New System.Drawing.Size(342, 14)
        Me.nomEmpFilter.TabIndex = 27
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
        Me.IconButton3.Location = New System.Drawing.Point(524, 39)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(42, 32)
        Me.IconButton3.TabIndex = 28
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Buscar"
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1577, 823)
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
        Me.GroupBoxBuscarEmpresa.ResumeLayout(False)
        Me.GroupBoxBuscarEmpresa.PerformLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents closeCreateAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxInsertQtyTest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCreateContract As FontAwesome.Sharp.IconButton
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As Gestio_empresesDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxCategoriaTest As ComboBox
    Friend WithEvents CategoriatestBindingSource As BindingSource
    Friend WithEvents Categoria_testTableAdapter As Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
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
End Class
