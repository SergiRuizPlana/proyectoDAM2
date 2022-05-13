<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Albaran
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.createAlbara = New FontAwesome.Sharp.IconButton()
        Me.DataGridAlbara = New System.Windows.Forms.DataGridView()
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.DataCreacioFilter = New System.Windows.Forms.DateTimePicker()
        Me.RestartFilterAlb = New FontAwesome.Sharp.IconButton()
        Me.cifEmpFilter = New System.Windows.Forms.TextBox()
        Me.searchAlb = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numAlbFilter = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.closeCreateAlbara = New FontAwesome.Sharp.IconButton()
        Me.ButtonCreateAlbara = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxBuscarEmpresa = New System.Windows.Forms.GroupBox()
        Me.ButtonOkEmpresa = New FontAwesome.Sharp.IconButton()
        Me.ButtonSearchEmpAlb = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxSearchEmpAlbara = New System.Windows.Forms.ComboBox()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestio_empresesDataSet1 = New Gestor_de_academias.Gestio_empresesDataSet()
        Me.TextSearchEmpAlbara = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxQtyTests = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoriaTest = New System.Windows.Forms.ComboBox()
        Me.CategoriatestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxTamanyTest = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxIVAAlb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDiscountAlb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxInsertQtyTest = New System.Windows.Forms.TextBox()
        Me.SearchQtyTestAlb = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CategoriaTableAdapter1 = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.categoriaTableAdapter()
        Me.Categoria_testTableAdapter1 = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter()
        Me.EmpresaTableAdapter1 = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.AlbaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlbaraTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.albaraTableAdapter()
        Me.FKalbaratenuma276EDEB3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Albara_testTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.albara_testTableAdapter()
        Me.NumalbaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbaraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridAlbara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel0.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxBuscarEmpresa.SuspendLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxQtyTests.SuspendLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKalbaratenuma276EDEB3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.createAlbara)
        Me.Panel1.Controls.Add(Me.DataGridAlbara)
        Me.Panel1.Location = New System.Drawing.Point(48, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 717)
        Me.Panel1.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.AliceBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(391, 54)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(116, 31)
        Me.IconButton1.TabIndex = 26
        Me.IconButton1.Text = "Esborrar"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'createAlbara
        '
        Me.createAlbara.BackColor = System.Drawing.Color.AliceBlue
        Me.createAlbara.FlatAppearance.BorderSize = 0
        Me.createAlbara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createAlbara.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createAlbara.ForeColor = System.Drawing.SystemColors.ControlText
        Me.createAlbara.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.createAlbara.IconColor = System.Drawing.Color.Black
        Me.createAlbara.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.createAlbara.IconSize = 20
        Me.createAlbara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.createAlbara.Location = New System.Drawing.Point(391, 17)
        Me.createAlbara.Name = "createAlbara"
        Me.createAlbara.Size = New System.Drawing.Size(116, 31)
        Me.createAlbara.TabIndex = 25
        Me.createAlbara.Text = "    Crear"
        Me.createAlbara.UseVisualStyleBackColor = False
        '
        'DataGridAlbara
        '
        Me.DataGridAlbara.AutoGenerateColumns = False
        Me.DataGridAlbara.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridAlbara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridAlbara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlbara.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumalbaraDataGridViewTextBoxColumn})
        Me.DataGridAlbara.DataSource = Me.AlbaraBindingSource1
        Me.DataGridAlbara.Location = New System.Drawing.Point(31, 18)
        Me.DataGridAlbara.Name = "DataGridAlbara"
        Me.DataGridAlbara.Size = New System.Drawing.Size(363, 560)
        Me.DataGridAlbara.TabIndex = 22
        '
        'Panel0
        '
        Me.Panel0.BackColor = System.Drawing.Color.Plum
        Me.Panel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel0.Controls.Add(Me.DataCreacioFilter)
        Me.Panel0.Controls.Add(Me.RestartFilterAlb)
        Me.Panel0.Controls.Add(Me.cifEmpFilter)
        Me.Panel0.Controls.Add(Me.searchAlb)
        Me.Panel0.Controls.Add(Me.Label1)
        Me.Panel0.Controls.Add(Me.Label2)
        Me.Panel0.Controls.Add(Me.Label3)
        Me.Panel0.Controls.Add(Me.numAlbFilter)
        Me.Panel0.Location = New System.Drawing.Point(48, 15)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(520, 67)
        Me.Panel0.TabIndex = 21
        '
        'DataCreacioFilter
        '
        Me.DataCreacioFilter.Location = New System.Drawing.Point(225, 35)
        Me.DataCreacioFilter.Name = "DataCreacioFilter"
        Me.DataCreacioFilter.Size = New System.Drawing.Size(150, 20)
        Me.DataCreacioFilter.TabIndex = 21
        '
        'RestartFilterAlb
        '
        Me.RestartFilterAlb.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RestartFilterAlb.FlatAppearance.BorderSize = 0
        Me.RestartFilterAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestartFilterAlb.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.RestartFilterAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.RestartFilterAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RestartFilterAlb.IconSize = 30
        Me.RestartFilterAlb.Location = New System.Drawing.Point(449, 20)
        Me.RestartFilterAlb.Name = "RestartFilterAlb"
        Me.RestartFilterAlb.Size = New System.Drawing.Size(42, 35)
        Me.RestartFilterAlb.TabIndex = 20
        Me.RestartFilterAlb.UseVisualStyleBackColor = False
        '
        'cifEmpFilter
        '
        Me.cifEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cifEmpFilter.Location = New System.Drawing.Point(13, 35)
        Me.cifEmpFilter.Name = "cifEmpFilter"
        Me.cifEmpFilter.Size = New System.Drawing.Size(100, 20)
        Me.cifEmpFilter.TabIndex = 2
        '
        'searchAlb
        '
        Me.searchAlb.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.searchAlb.FlatAppearance.BorderSize = 0
        Me.searchAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchAlb.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.searchAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.searchAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchAlb.IconSize = 30
        Me.searchAlb.Location = New System.Drawing.Point(401, 20)
        Me.searchAlb.Name = "searchAlb"
        Me.searchAlb.Size = New System.Drawing.Size(42, 35)
        Me.searchAlb.TabIndex = 19
        Me.searchAlb.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CIF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.Label2.Location = New System.Drawing.Point(116, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº albarà"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.Label3.Location = New System.Drawing.Point(222, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data creació"
        '
        'numAlbFilter
        '
        Me.numAlbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numAlbFilter.Location = New System.Drawing.Point(119, 35)
        Me.numAlbFilter.Name = "numAlbFilter"
        Me.numAlbFilter.Size = New System.Drawing.Size(100, 20)
        Me.numAlbFilter.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(911, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 799)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.closeCreateAlbara)
        Me.Panel3.Controls.Add(Me.ButtonCreateAlbara)
        Me.Panel3.Controls.Add(Me.GroupBoxBuscarEmpresa)
        Me.Panel3.Controls.Add(Me.GroupBoxQtyTests)
        Me.Panel3.Location = New System.Drawing.Point(581, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 409)
        Me.Panel3.TabIndex = 24
        Me.Panel3.Visible = False
        '
        'closeCreateAlbara
        '
        Me.closeCreateAlbara.BackColor = System.Drawing.Color.LightBlue
        Me.closeCreateAlbara.FlatAppearance.BorderSize = 0
        Me.closeCreateAlbara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCreateAlbara.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.closeCreateAlbara.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.closeCreateAlbara.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeCreateAlbara.IconSize = 40
        Me.closeCreateAlbara.Location = New System.Drawing.Point(286, 6)
        Me.closeCreateAlbara.Name = "closeCreateAlbara"
        Me.closeCreateAlbara.Size = New System.Drawing.Size(30, 35)
        Me.closeCreateAlbara.TabIndex = 37
        Me.closeCreateAlbara.UseVisualStyleBackColor = False
        '
        'ButtonCreateAlbara
        '
        Me.ButtonCreateAlbara.BackColor = System.Drawing.Color.Teal
        Me.ButtonCreateAlbara.FlatAppearance.BorderSize = 0
        Me.ButtonCreateAlbara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCreateAlbara.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateAlbara.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateAlbara.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonCreateAlbara.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCreateAlbara.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCreateAlbara.IconSize = 20
        Me.ButtonCreateAlbara.Location = New System.Drawing.Point(90, 367)
        Me.ButtonCreateAlbara.Name = "ButtonCreateAlbara"
        Me.ButtonCreateAlbara.Size = New System.Drawing.Size(137, 26)
        Me.ButtonCreateAlbara.TabIndex = 29
        Me.ButtonCreateAlbara.Text = "Generar albarà"
        Me.ButtonCreateAlbara.UseVisualStyleBackColor = False
        '
        'GroupBoxBuscarEmpresa
        '
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonOkEmpresa)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonSearchEmpAlb)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ComboBoxSearchEmpAlbara)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.TextSearchEmpAlbara)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label4)
        Me.GroupBoxBuscarEmpresa.Location = New System.Drawing.Point(12, 11)
        Me.GroupBoxBuscarEmpresa.Name = "GroupBoxBuscarEmpresa"
        Me.GroupBoxBuscarEmpresa.Size = New System.Drawing.Size(268, 116)
        Me.GroupBoxBuscarEmpresa.TabIndex = 34
        Me.GroupBoxBuscarEmpresa.TabStop = False
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
        'ButtonSearchEmpAlb
        '
        Me.ButtonSearchEmpAlb.BackColor = System.Drawing.Color.Teal
        Me.ButtonSearchEmpAlb.FlatAppearance.BorderSize = 0
        Me.ButtonSearchEmpAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchEmpAlb.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ButtonSearchEmpAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSearchEmpAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonSearchEmpAlb.IconSize = 20
        Me.ButtonSearchEmpAlb.Location = New System.Drawing.Point(232, 18)
        Me.ButtonSearchEmpAlb.Name = "ButtonSearchEmpAlb"
        Me.ButtonSearchEmpAlb.Size = New System.Drawing.Size(30, 26)
        Me.ButtonSearchEmpAlb.TabIndex = 33
        Me.ButtonSearchEmpAlb.UseVisualStyleBackColor = False
        '
        'ComboBoxSearchEmpAlbara
        '
        Me.ComboBoxSearchEmpAlbara.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxSearchEmpAlbara.DataSource = Me.EmpresaBindingSource
        Me.ComboBoxSearchEmpAlbara.DisplayMember = "nom"
        Me.ComboBoxSearchEmpAlbara.FormattingEnabled = True
        Me.ComboBoxSearchEmpAlbara.Location = New System.Drawing.Point(6, 50)
        Me.ComboBoxSearchEmpAlbara.Name = "ComboBoxSearchEmpAlbara"
        Me.ComboBoxSearchEmpAlbara.Size = New System.Drawing.Size(257, 21)
        Me.ComboBoxSearchEmpAlbara.TabIndex = 0
        Me.ComboBoxSearchEmpAlbara.ValueMember = "nom"
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.Gestio_empresesDataSet1
        '
        'Gestio_empresesDataSet1
        '
        Me.Gestio_empresesDataSet1.DataSetName = "Gestio_empresesDataSet"
        Me.Gestio_empresesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextSearchEmpAlbara
        '
        Me.TextSearchEmpAlbara.Location = New System.Drawing.Point(55, 22)
        Me.TextSearchEmpAlbara.Name = "TextSearchEmpAlbara"
        Me.TextSearchEmpAlbara.Size = New System.Drawing.Size(160, 20)
        Me.TextSearchEmpAlbara.TabIndex = 2
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
        'GroupBoxQtyTests
        '
        Me.GroupBoxQtyTests.Controls.Add(Me.Label6)
        Me.GroupBoxQtyTests.Controls.Add(Me.ComboBoxCategoriaTest)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label12)
        Me.GroupBoxQtyTests.Controls.Add(Me.ComboBoxTamanyTest)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label11)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label9)
        Me.GroupBoxQtyTests.Controls.Add(Me.TextBoxIVAAlb)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label10)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label8)
        Me.GroupBoxQtyTests.Controls.Add(Me.TextBoxDiscountAlb)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label7)
        Me.GroupBoxQtyTests.Controls.Add(Me.TextBoxInsertQtyTest)
        Me.GroupBoxQtyTests.Controls.Add(Me.SearchQtyTestAlb)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label5)
        Me.GroupBoxQtyTests.Location = New System.Drawing.Point(12, 133)
        Me.GroupBoxQtyTests.Name = "GroupBoxQtyTests"
        Me.GroupBoxQtyTests.Size = New System.Drawing.Size(282, 214)
        Me.GroupBoxQtyTests.TabIndex = 35
        Me.GroupBoxQtyTests.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Categoria"
        '
        'ComboBoxCategoriaTest
        '
        Me.ComboBoxCategoriaTest.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxCategoriaTest.DataSource = Me.CategoriatestBindingSource
        Me.ComboBoxCategoriaTest.DisplayMember = "descripcio"
        Me.ComboBoxCategoriaTest.FormattingEnabled = True
        Me.ComboBoxCategoriaTest.Location = New System.Drawing.Point(64, 19)
        Me.ComboBoxCategoriaTest.Name = "ComboBoxCategoriaTest"
        Me.ComboBoxCategoriaTest.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxCategoriaTest.TabIndex = 48
        Me.ComboBoxCategoriaTest.ValueMember = "cod_categoria"
        '
        'CategoriatestBindingSource
        '
        Me.CategoriatestBindingSource.DataMember = "categoria_test"
        Me.CategoriatestBindingSource.DataSource = Me.Gestio_empresesDataSet1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Tamany"
        '
        'ComboBoxTamanyTest
        '
        Me.ComboBoxTamanyTest.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxTamanyTest.FormattingEnabled = True
        Me.ComboBoxTamanyTest.Location = New System.Drawing.Point(64, 46)
        Me.ComboBoxTamanyTest.Name = "ComboBoxTamanyTest"
        Me.ComboBoxTamanyTest.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxTamanyTest.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(200, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "unitats"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(200, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "%"
        '
        'TextBoxIVAAlb
        '
        Me.TextBoxIVAAlb.Location = New System.Drawing.Point(119, 134)
        Me.TextBoxIVAAlb.Name = "TextBoxIVAAlb"
        Me.TextBoxIVAAlb.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxIVAAlb.TabIndex = 38
        Me.TextBoxIVAAlb.Text = "21"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "I.V.A."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(200, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "%"
        '
        'TextBoxDiscountAlb
        '
        Me.TextBoxDiscountAlb.Location = New System.Drawing.Point(119, 108)
        Me.TextBoxDiscountAlb.Name = "TextBoxDiscountAlb"
        Me.TextBoxDiscountAlb.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxDiscountAlb.TabIndex = 35
        Me.TextBoxDiscountAlb.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Descompte"
        '
        'TextBoxInsertQtyTest
        '
        Me.TextBoxInsertQtyTest.Location = New System.Drawing.Point(118, 82)
        Me.TextBoxInsertQtyTest.Name = "TextBoxInsertQtyTest"
        Me.TextBoxInsertQtyTest.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxInsertQtyTest.TabIndex = 30
        '
        'SearchQtyTestAlb
        '
        Me.SearchQtyTestAlb.BackColor = System.Drawing.Color.Teal
        Me.SearchQtyTestAlb.FlatAppearance.BorderSize = 0
        Me.SearchQtyTestAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchQtyTestAlb.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.SearchQtyTestAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchQtyTestAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SearchQtyTestAlb.IconSize = 20
        Me.SearchQtyTestAlb.Location = New System.Drawing.Point(118, 168)
        Me.SearchQtyTestAlb.Name = "SearchQtyTestAlb"
        Me.SearchQtyTestAlb.Size = New System.Drawing.Size(56, 26)
        Me.SearchQtyTestAlb.TabIndex = 32
        Me.SearchQtyTestAlb.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Quantitat "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CategoriaTableAdapter1
        '
        Me.CategoriaTableAdapter1.ClearBeforeFill = True
        '
        'Categoria_testTableAdapter1
        '
        Me.Categoria_testTableAdapter1.ClearBeforeFill = True
        '
        'EmpresaTableAdapter1
        '
        Me.EmpresaTableAdapter1.ClearBeforeFill = True
        '
        'AlbaraBindingSource
        '
        Me.AlbaraBindingSource.DataMember = "albara"
        Me.AlbaraBindingSource.DataSource = Me.Gestio_empresesDataSet1
        '
        'AlbaraTableAdapter
        '
        Me.AlbaraTableAdapter.ClearBeforeFill = True
        '
        'FKalbaratenuma276EDEB3BindingSource
        '
        Me.FKalbaratenuma276EDEB3BindingSource.DataMember = "FK__albara_te__num_a__276EDEB3"
        Me.FKalbaratenuma276EDEB3BindingSource.DataSource = Me.AlbaraBindingSource
        '
        'Albara_testTableAdapter
        '
        Me.Albara_testTableAdapter.ClearBeforeFill = True
        '
        'NumalbaraDataGridViewTextBoxColumn
        '
        Me.NumalbaraDataGridViewTextBoxColumn.DataPropertyName = "num_albara"
        Me.NumalbaraDataGridViewTextBoxColumn.HeaderText = "num_albara"
        Me.NumalbaraDataGridViewTextBoxColumn.Name = "NumalbaraDataGridViewTextBoxColumn"
        '
        'AlbaraBindingSource1
        '
        Me.AlbaraBindingSource1.DataMember = "albara"
        Me.AlbaraBindingSource1.DataSource = Me.Gestio_empresesDataSet1
        '
        'Albaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1531, 828)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel0)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Albaran"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridAlbara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel0.ResumeLayout(False)
        Me.Panel0.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBoxBuscarEmpresa.ResumeLayout(False)
        Me.GroupBoxBuscarEmpresa.PerformLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxQtyTests.ResumeLayout(False)
        Me.GroupBoxQtyTests.PerformLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKalbaratenuma276EDEB3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel0 As Panel
    Friend WithEvents RestartFilterAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents cifEmpFilter As TextBox
    Friend WithEvents searchAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numAlbFilter As TextBox
    Friend WithEvents DataGridAlbara As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents createAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents closeCreateAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonCreateAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBoxBuscarEmpresa As GroupBox
    Friend WithEvents ButtonSearchEmpAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxSearchEmpAlbara As ComboBox
    Friend WithEvents TextSearchEmpAlbara As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxQtyTests As GroupBox
    Friend WithEvents SearchQtyTestAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBoxInsertQtyTest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataCreacioFilter As DateTimePicker
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonOkEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDiscountAlb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxIVAAlb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxTamanyTest As ComboBox
    Friend WithEvents CategoriaTableAdapter1 As Gestio_empresesDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents Categoria_testTableAdapter1 As Gestio_empresesDataSetTableAdapters.categoria_testTableAdapter
    Friend WithEvents EmpresaTableAdapter1 As Gestio_empresesDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents Gestio_empresesDataSet1 As Gestio_empresesDataSet
    Friend WithEvents CategoriatestBindingSource As BindingSource
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxCategoriaTest As ComboBox
    Friend WithEvents AlbaraBindingSource As BindingSource
    Friend WithEvents AlbaraTableAdapter As Gestio_empresesDataSetTableAdapters.albaraTableAdapter
    Friend WithEvents FKalbaratenuma276EDEB3BindingSource As BindingSource
    Friend WithEvents Albara_testTableAdapter As Gestio_empresesDataSetTableAdapters.albara_testTableAdapter
    Friend WithEvents NumalbaraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlbaraBindingSource1 As BindingSource
End Class
