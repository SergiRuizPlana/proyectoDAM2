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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Albaran))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EditAlbara = New FontAwesome.Sharp.IconButton()
        Me.createAlbara = New FontAwesome.Sharp.IconButton()
        Me.DataGridAlbara = New System.Windows.Forms.DataGridView()
        Me.NumalbaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioempresesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestio_empresesDataSet = New Gestor_de_academias.gestio_empresesDataSet()
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
        Me.GroupBoxSearchTest = New System.Windows.Forms.GroupBox()
        Me.ButtonInsertTest = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxSearchTestAlb = New System.Windows.Forms.ComboBox()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextInsertTest = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonCreateAlbara = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxCrearAlbara = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCrearAuto = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCrearManual = New System.Windows.Forms.RadioButton()
        Me.GroupBoxBuscarEmpresa = New System.Windows.Forms.GroupBox()
        Me.ButtonSearchEmpAlb = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxSearchEmpAlbara = New System.Windows.Forms.ComboBox()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextSearchEmpAlbara = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxQtyTests = New System.Windows.Forms.GroupBox()
        Me.SearchQtyTestAlb = New FontAwesome.Sharp.IconButton()
        Me.TextBoxInsertQtyTest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AlbaraTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.albaraTableAdapter()
        Me.AlbaraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.TestTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.testTableAdapter()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtonEditAlbaraBack = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxInsertTestEditAlb = New System.Windows.Forms.GroupBox()
        Me.ButtonInserttestEditAlb = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxSearchTestEditAlb = New System.Windows.Forms.ComboBox()
        Me.TextBoxInsertTestEditAlb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSaveAlbaraEdit = New FontAwesome.Sharp.IconButton()
        Me.GroupBoxEditEmpresaAlb = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscarEmpresaEditAlb = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxEmpresaEditAlb = New System.Windows.Forms.ComboBox()
        Me.TextBoxBuscarEmpresaEditAlb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBoxQtyTestEditAlb = New System.Windows.Forms.GroupBox()
        Me.ButtonQtyTestEditAlb = New FontAwesome.Sharp.IconButton()
        Me.TextBoxQtyTestEditAlb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxDeleteTestEditAlb = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteTestEditAlb = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxDeleteTestEditAlb = New System.Windows.Forms.ComboBox()
        Me.TextBoxDeleteTestEditAlb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CategoriatestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Categoria_testTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.categoria_testTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridAlbara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioempresesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel0.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxSearchTest.SuspendLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCrearAlbara.SuspendLayout()
        Me.GroupBoxBuscarEmpresa.SuspendLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxQtyTests.SuspendLayout()
        CType(Me.AlbaraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBoxInsertTestEditAlb.SuspendLayout()
        Me.GroupBoxEditEmpresaAlb.SuspendLayout()
        Me.GroupBoxQtyTestEditAlb.SuspendLayout()
        Me.GroupBoxDeleteTestEditAlb.SuspendLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.EditAlbara)
        Me.Panel1.Controls.Add(Me.createAlbara)
        Me.Panel1.Controls.Add(Me.DataGridAlbara)
        Me.Panel1.Location = New System.Drawing.Point(48, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 717)
        Me.Panel1.TabIndex = 0
        '
        'EditAlbara
        '
        Me.EditAlbara.BackColor = System.Drawing.Color.AliceBlue
        Me.EditAlbara.FlatAppearance.BorderSize = 0
        Me.EditAlbara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditAlbara.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbara.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EditAlbara.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.EditAlbara.IconColor = System.Drawing.Color.Black
        Me.EditAlbara.IconFont = FontAwesome.Sharp.IconFont.Regular
        Me.EditAlbara.IconSize = 25
        Me.EditAlbara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditAlbara.Location = New System.Drawing.Point(415, 59)
        Me.EditAlbara.Name = "EditAlbara"
        Me.EditAlbara.Size = New System.Drawing.Size(85, 28)
        Me.EditAlbara.TabIndex = 26
        Me.EditAlbara.Text = "     Editar"
        Me.EditAlbara.UseVisualStyleBackColor = False
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
        Me.createAlbara.Location = New System.Drawing.Point(415, 18)
        Me.createAlbara.Name = "createAlbara"
        Me.createAlbara.Size = New System.Drawing.Size(85, 31)
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
        Me.DataGridAlbara.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumalbaraDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn})
        Me.DataGridAlbara.DataSource = Me.AlbaraBindingSource
        Me.DataGridAlbara.Location = New System.Drawing.Point(31, 18)
        Me.DataGridAlbara.Name = "DataGridAlbara"
        Me.DataGridAlbara.Size = New System.Drawing.Size(344, 560)
        Me.DataGridAlbara.TabIndex = 22
        '
        'NumalbaraDataGridViewTextBoxColumn
        '
        Me.NumalbaraDataGridViewTextBoxColumn.DataPropertyName = "num_albara"
        Me.NumalbaraDataGridViewTextBoxColumn.HeaderText = "num_albara"
        Me.NumalbaraDataGridViewTextBoxColumn.Name = "NumalbaraDataGridViewTextBoxColumn"
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "cif"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'AlbaraBindingSource
        '
        Me.AlbaraBindingSource.DataMember = "albara"
        Me.AlbaraBindingSource.DataSource = Me.GestioempresesDataSetBindingSource
        '
        'GestioempresesDataSetBindingSource
        '
        Me.GestioempresesDataSetBindingSource.DataSource = Me.Gestio_empresesDataSet
        Me.GestioempresesDataSetBindingSource.Position = 0
        '
        'Gestio_empresesDataSet
        '
        Me.Gestio_empresesDataSet.DataSetName = "gestio_empresesDataSet"
        Me.Gestio_empresesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Panel3.Controls.Add(Me.GroupBoxSearchTest)
        Me.Panel3.Controls.Add(Me.ButtonCreateAlbara)
        Me.Panel3.Controls.Add(Me.GroupBoxCrearAlbara)
        Me.Panel3.Controls.Add(Me.GroupBoxBuscarEmpresa)
        Me.Panel3.Controls.Add(Me.GroupBoxQtyTests)
        Me.Panel3.Location = New System.Drawing.Point(585, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 349)
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
        Me.closeCreateAlbara.Location = New System.Drawing.Point(278, 10)
        Me.closeCreateAlbara.Name = "closeCreateAlbara"
        Me.closeCreateAlbara.Size = New System.Drawing.Size(30, 35)
        Me.closeCreateAlbara.TabIndex = 37
        Me.closeCreateAlbara.UseVisualStyleBackColor = False
        '
        'GroupBoxSearchTest
        '
        Me.GroupBoxSearchTest.Controls.Add(Me.ButtonInsertTest)
        Me.GroupBoxSearchTest.Controls.Add(Me.ComboBoxSearchTestAlb)
        Me.GroupBoxSearchTest.Controls.Add(Me.TextInsertTest)
        Me.GroupBoxSearchTest.Controls.Add(Me.Label6)
        Me.GroupBoxSearchTest.Location = New System.Drawing.Point(9, 204)
        Me.GroupBoxSearchTest.Name = "GroupBoxSearchTest"
        Me.GroupBoxSearchTest.Size = New System.Drawing.Size(263, 87)
        Me.GroupBoxSearchTest.TabIndex = 36
        Me.GroupBoxSearchTest.TabStop = False
        '
        'ButtonInsertTest
        '
        Me.ButtonInsertTest.BackColor = System.Drawing.Color.Teal
        Me.ButtonInsertTest.FlatAppearance.BorderSize = 0
        Me.ButtonInsertTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsertTest.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.ButtonInsertTest.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonInsertTest.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonInsertTest.IconSize = 20
        Me.ButtonInsertTest.Location = New System.Drawing.Point(227, 47)
        Me.ButtonInsertTest.Name = "ButtonInsertTest"
        Me.ButtonInsertTest.Size = New System.Drawing.Size(30, 26)
        Me.ButtonInsertTest.TabIndex = 39
        Me.ButtonInsertTest.UseVisualStyleBackColor = False
        '
        'ComboBoxSearchTestAlb
        '
        Me.ComboBoxSearchTestAlb.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxSearchTestAlb.DataSource = Me.CategoriatestBindingSource
        Me.ComboBoxSearchTestAlb.DisplayMember = "descripcio"
        Me.ComboBoxSearchTestAlb.FormattingEnabled = True
        Me.ComboBoxSearchTestAlb.Location = New System.Drawing.Point(5, 19)
        Me.ComboBoxSearchTestAlb.Name = "ComboBoxSearchTestAlb"
        Me.ComboBoxSearchTestAlb.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxSearchTestAlb.TabIndex = 26
        Me.ComboBoxSearchTestAlb.ValueMember = "cod_categoria"
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.GestioempresesDataSetBindingSource
        '
        'TextInsertTest
        '
        Me.TextInsertTest.Location = New System.Drawing.Point(67, 51)
        Me.TextInsertTest.Name = "TextInsertTest"
        Me.TextInsertTest.Size = New System.Drawing.Size(148, 20)
        Me.TextInsertTest.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Inserir test"
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
        Me.ButtonCreateAlbara.Location = New System.Drawing.Point(87, 308)
        Me.ButtonCreateAlbara.Name = "ButtonCreateAlbara"
        Me.ButtonCreateAlbara.Size = New System.Drawing.Size(137, 26)
        Me.ButtonCreateAlbara.TabIndex = 29
        Me.ButtonCreateAlbara.Text = "Generar albarà"
        Me.ButtonCreateAlbara.UseVisualStyleBackColor = False
        '
        'GroupBoxCrearAlbara
        '
        Me.GroupBoxCrearAlbara.Controls.Add(Me.RadioButtonCrearAuto)
        Me.GroupBoxCrearAlbara.Controls.Add(Me.RadioButtonCrearManual)
        Me.GroupBoxCrearAlbara.Location = New System.Drawing.Point(9, 3)
        Me.GroupBoxCrearAlbara.Name = "GroupBoxCrearAlbara"
        Me.GroupBoxCrearAlbara.Size = New System.Drawing.Size(263, 42)
        Me.GroupBoxCrearAlbara.TabIndex = 1
        Me.GroupBoxCrearAlbara.TabStop = False
        '
        'RadioButtonCrearAuto
        '
        Me.RadioButtonCrearAuto.AutoSize = True
        Me.RadioButtonCrearAuto.Location = New System.Drawing.Point(130, 16)
        Me.RadioButtonCrearAuto.Name = "RadioButtonCrearAuto"
        Me.RadioButtonCrearAuto.Size = New System.Drawing.Size(128, 17)
        Me.RadioButtonCrearAuto.TabIndex = 1
        Me.RadioButtonCrearAuto.Text = "Crear automàticament"
        Me.RadioButtonCrearAuto.UseVisualStyleBackColor = True
        '
        'RadioButtonCrearManual
        '
        Me.RadioButtonCrearManual.AutoSize = True
        Me.RadioButtonCrearManual.Location = New System.Drawing.Point(6, 16)
        Me.RadioButtonCrearManual.Name = "RadioButtonCrearManual"
        Me.RadioButtonCrearManual.Size = New System.Drawing.Size(110, 17)
        Me.RadioButtonCrearManual.TabIndex = 0
        Me.RadioButtonCrearManual.Text = "Crear manualment"
        Me.RadioButtonCrearManual.UseVisualStyleBackColor = True
        '
        'GroupBoxBuscarEmpresa
        '
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ButtonSearchEmpAlb)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.ComboBoxSearchEmpAlbara)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.TextSearchEmpAlbara)
        Me.GroupBoxBuscarEmpresa.Controls.Add(Me.Label4)
        Me.GroupBoxBuscarEmpresa.Location = New System.Drawing.Point(9, 51)
        Me.GroupBoxBuscarEmpresa.Name = "GroupBoxBuscarEmpresa"
        Me.GroupBoxBuscarEmpresa.Size = New System.Drawing.Size(263, 90)
        Me.GroupBoxBuscarEmpresa.TabIndex = 34
        Me.GroupBoxBuscarEmpresa.TabStop = False
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
        Me.ButtonSearchEmpAlb.Location = New System.Drawing.Point(227, 18)
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
        Me.ComboBoxSearchEmpAlbara.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxSearchEmpAlbara.TabIndex = 0
        Me.ComboBoxSearchEmpAlbara.ValueMember = "cif"
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.GestioempresesDataSetBindingSource
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
        Me.GroupBoxQtyTests.Controls.Add(Me.SearchQtyTestAlb)
        Me.GroupBoxQtyTests.Controls.Add(Me.TextBoxInsertQtyTest)
        Me.GroupBoxQtyTests.Controls.Add(Me.Label5)
        Me.GroupBoxQtyTests.Location = New System.Drawing.Point(9, 147)
        Me.GroupBoxQtyTests.Name = "GroupBoxQtyTests"
        Me.GroupBoxQtyTests.Size = New System.Drawing.Size(263, 51)
        Me.GroupBoxQtyTests.TabIndex = 35
        Me.GroupBoxQtyTests.TabStop = False
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
        Me.SearchQtyTestAlb.Location = New System.Drawing.Point(227, 15)
        Me.SearchQtyTestAlb.Name = "SearchQtyTestAlb"
        Me.SearchQtyTestAlb.Size = New System.Drawing.Size(30, 26)
        Me.SearchQtyTestAlb.TabIndex = 32
        Me.SearchQtyTestAlb.UseVisualStyleBackColor = False
        '
        'TextBoxInsertQtyTest
        '
        Me.TextBoxInsertQtyTest.Location = New System.Drawing.Point(87, 19)
        Me.TextBoxInsertQtyTest.Name = "TextBoxInsertQtyTest"
        Me.TextBoxInsertQtyTest.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxInsertQtyTest.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Quantitat tests"
        '
        'AlbaraTableAdapter
        '
        Me.AlbaraTableAdapter.ClearBeforeFill = True
        '
        'AlbaraBindingSource1
        '
        Me.AlbaraBindingSource1.DataMember = "albara"
        Me.AlbaraBindingSource1.DataSource = Me.GestioempresesDataSetBindingSource
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Controls.Add(Me.ButtonEditAlbaraBack)
        Me.Panel4.Controls.Add(Me.GroupBoxInsertTestEditAlb)
        Me.Panel4.Controls.Add(Me.ButtonSaveAlbaraEdit)
        Me.Panel4.Controls.Add(Me.GroupBoxEditEmpresaAlb)
        Me.Panel4.Controls.Add(Me.GroupBoxQtyTestEditAlb)
        Me.Panel4.Controls.Add(Me.GroupBoxDeleteTestEditAlb)
        Me.Panel4.Location = New System.Drawing.Point(585, 370)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(311, 403)
        Me.Panel4.TabIndex = 25
        Me.Panel4.Visible = False
        '
        'ButtonEditAlbaraBack
        '
        Me.ButtonEditAlbaraBack.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonEditAlbaraBack.FlatAppearance.BorderSize = 0
        Me.ButtonEditAlbaraBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditAlbaraBack.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ButtonEditAlbaraBack.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEditAlbaraBack.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonEditAlbaraBack.IconSize = 40
        Me.ButtonEditAlbaraBack.Location = New System.Drawing.Point(277, 11)
        Me.ButtonEditAlbaraBack.Name = "ButtonEditAlbaraBack"
        Me.ButtonEditAlbaraBack.Size = New System.Drawing.Size(30, 35)
        Me.ButtonEditAlbaraBack.TabIndex = 37
        Me.ButtonEditAlbaraBack.UseVisualStyleBackColor = False
        '
        'GroupBoxInsertTestEditAlb
        '
        Me.GroupBoxInsertTestEditAlb.Controls.Add(Me.ButtonInserttestEditAlb)
        Me.GroupBoxInsertTestEditAlb.Controls.Add(Me.ComboBoxSearchTestEditAlb)
        Me.GroupBoxInsertTestEditAlb.Controls.Add(Me.TextBoxInsertTestEditAlb)
        Me.GroupBoxInsertTestEditAlb.Controls.Add(Me.Label7)
        Me.GroupBoxInsertTestEditAlb.Location = New System.Drawing.Point(9, 163)
        Me.GroupBoxInsertTestEditAlb.Name = "GroupBoxInsertTestEditAlb"
        Me.GroupBoxInsertTestEditAlb.Size = New System.Drawing.Size(263, 87)
        Me.GroupBoxInsertTestEditAlb.TabIndex = 36
        Me.GroupBoxInsertTestEditAlb.TabStop = False
        '
        'ButtonInserttestEditAlb
        '
        Me.ButtonInserttestEditAlb.BackColor = System.Drawing.Color.Teal
        Me.ButtonInserttestEditAlb.FlatAppearance.BorderSize = 0
        Me.ButtonInserttestEditAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInserttestEditAlb.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.ButtonInserttestEditAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonInserttestEditAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonInserttestEditAlb.IconSize = 20
        Me.ButtonInserttestEditAlb.Location = New System.Drawing.Point(227, 47)
        Me.ButtonInserttestEditAlb.Name = "ButtonInserttestEditAlb"
        Me.ButtonInserttestEditAlb.Size = New System.Drawing.Size(30, 26)
        Me.ButtonInserttestEditAlb.TabIndex = 39
        Me.ButtonInserttestEditAlb.UseVisualStyleBackColor = False
        '
        'ComboBoxSearchTestEditAlb
        '
        Me.ComboBoxSearchTestEditAlb.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxSearchTestEditAlb.DataSource = Me.TestBindingSource
        Me.ComboBoxSearchTestEditAlb.DisplayMember = "codi_test"
        Me.ComboBoxSearchTestEditAlb.FormattingEnabled = True
        Me.ComboBoxSearchTestEditAlb.Location = New System.Drawing.Point(5, 19)
        Me.ComboBoxSearchTestEditAlb.Name = "ComboBoxSearchTestEditAlb"
        Me.ComboBoxSearchTestEditAlb.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxSearchTestEditAlb.TabIndex = 26
        Me.ComboBoxSearchTestEditAlb.ValueMember = "codi_test"
        '
        'TextBoxInsertTestEditAlb
        '
        Me.TextBoxInsertTestEditAlb.Location = New System.Drawing.Point(67, 51)
        Me.TextBoxInsertTestEditAlb.Name = "TextBoxInsertTestEditAlb"
        Me.TextBoxInsertTestEditAlb.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxInsertTestEditAlb.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Inserir test"
        '
        'ButtonSaveAlbaraEdit
        '
        Me.ButtonSaveAlbaraEdit.BackColor = System.Drawing.Color.Teal
        Me.ButtonSaveAlbaraEdit.FlatAppearance.BorderSize = 0
        Me.ButtonSaveAlbaraEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveAlbaraEdit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveAlbaraEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSaveAlbaraEdit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonSaveAlbaraEdit.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSaveAlbaraEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonSaveAlbaraEdit.IconSize = 20
        Me.ButtonSaveAlbaraEdit.Location = New System.Drawing.Point(87, 361)
        Me.ButtonSaveAlbaraEdit.Name = "ButtonSaveAlbaraEdit"
        Me.ButtonSaveAlbaraEdit.Size = New System.Drawing.Size(137, 26)
        Me.ButtonSaveAlbaraEdit.TabIndex = 29
        Me.ButtonSaveAlbaraEdit.Text = "Guardar albarà"
        Me.ButtonSaveAlbaraEdit.UseVisualStyleBackColor = False
        '
        'GroupBoxEditEmpresaAlb
        '
        Me.GroupBoxEditEmpresaAlb.Controls.Add(Me.ButtonBuscarEmpresaEditAlb)
        Me.GroupBoxEditEmpresaAlb.Controls.Add(Me.ComboBoxEmpresaEditAlb)
        Me.GroupBoxEditEmpresaAlb.Controls.Add(Me.TextBoxBuscarEmpresaEditAlb)
        Me.GroupBoxEditEmpresaAlb.Controls.Add(Me.Label8)
        Me.GroupBoxEditEmpresaAlb.Location = New System.Drawing.Point(9, 10)
        Me.GroupBoxEditEmpresaAlb.Name = "GroupBoxEditEmpresaAlb"
        Me.GroupBoxEditEmpresaAlb.Size = New System.Drawing.Size(263, 90)
        Me.GroupBoxEditEmpresaAlb.TabIndex = 34
        Me.GroupBoxEditEmpresaAlb.TabStop = False
        '
        'ButtonBuscarEmpresaEditAlb
        '
        Me.ButtonBuscarEmpresaEditAlb.BackColor = System.Drawing.Color.Teal
        Me.ButtonBuscarEmpresaEditAlb.FlatAppearance.BorderSize = 0
        Me.ButtonBuscarEmpresaEditAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarEmpresaEditAlb.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ButtonBuscarEmpresaEditAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonBuscarEmpresaEditAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonBuscarEmpresaEditAlb.IconSize = 20
        Me.ButtonBuscarEmpresaEditAlb.Location = New System.Drawing.Point(227, 18)
        Me.ButtonBuscarEmpresaEditAlb.Name = "ButtonBuscarEmpresaEditAlb"
        Me.ButtonBuscarEmpresaEditAlb.Size = New System.Drawing.Size(30, 26)
        Me.ButtonBuscarEmpresaEditAlb.TabIndex = 33
        Me.ButtonBuscarEmpresaEditAlb.UseVisualStyleBackColor = False
        '
        'ComboBoxEmpresaEditAlb
        '
        Me.ComboBoxEmpresaEditAlb.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxEmpresaEditAlb.DataSource = Me.EmpresaBindingSource
        Me.ComboBoxEmpresaEditAlb.DisplayMember = "nom"
        Me.ComboBoxEmpresaEditAlb.FormattingEnabled = True
        Me.ComboBoxEmpresaEditAlb.Location = New System.Drawing.Point(6, 50)
        Me.ComboBoxEmpresaEditAlb.Name = "ComboBoxEmpresaEditAlb"
        Me.ComboBoxEmpresaEditAlb.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxEmpresaEditAlb.TabIndex = 0
        Me.ComboBoxEmpresaEditAlb.ValueMember = "cif"
        '
        'TextBoxBuscarEmpresaEditAlb
        '
        Me.TextBoxBuscarEmpresaEditAlb.Location = New System.Drawing.Point(55, 22)
        Me.TextBoxBuscarEmpresaEditAlb.Name = "TextBoxBuscarEmpresaEditAlb"
        Me.TextBoxBuscarEmpresaEditAlb.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxBuscarEmpresaEditAlb.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Empresa"
        '
        'GroupBoxQtyTestEditAlb
        '
        Me.GroupBoxQtyTestEditAlb.Controls.Add(Me.ButtonQtyTestEditAlb)
        Me.GroupBoxQtyTestEditAlb.Controls.Add(Me.TextBoxQtyTestEditAlb)
        Me.GroupBoxQtyTestEditAlb.Controls.Add(Me.Label9)
        Me.GroupBoxQtyTestEditAlb.Location = New System.Drawing.Point(9, 106)
        Me.GroupBoxQtyTestEditAlb.Name = "GroupBoxQtyTestEditAlb"
        Me.GroupBoxQtyTestEditAlb.Size = New System.Drawing.Size(263, 51)
        Me.GroupBoxQtyTestEditAlb.TabIndex = 35
        Me.GroupBoxQtyTestEditAlb.TabStop = False
        '
        'ButtonQtyTestEditAlb
        '
        Me.ButtonQtyTestEditAlb.BackColor = System.Drawing.Color.Teal
        Me.ButtonQtyTestEditAlb.FlatAppearance.BorderSize = 0
        Me.ButtonQtyTestEditAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonQtyTestEditAlb.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.ButtonQtyTestEditAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonQtyTestEditAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonQtyTestEditAlb.IconSize = 20
        Me.ButtonQtyTestEditAlb.Location = New System.Drawing.Point(227, 15)
        Me.ButtonQtyTestEditAlb.Name = "ButtonQtyTestEditAlb"
        Me.ButtonQtyTestEditAlb.Size = New System.Drawing.Size(30, 26)
        Me.ButtonQtyTestEditAlb.TabIndex = 32
        Me.ButtonQtyTestEditAlb.UseVisualStyleBackColor = False
        '
        'TextBoxQtyTestEditAlb
        '
        Me.TextBoxQtyTestEditAlb.Location = New System.Drawing.Point(87, 19)
        Me.TextBoxQtyTestEditAlb.Name = "TextBoxQtyTestEditAlb"
        Me.TextBoxQtyTestEditAlb.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxQtyTestEditAlb.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Quantitat tests"
        '
        'GroupBoxDeleteTestEditAlb
        '
        Me.GroupBoxDeleteTestEditAlb.Controls.Add(Me.ButtonDeleteTestEditAlb)
        Me.GroupBoxDeleteTestEditAlb.Controls.Add(Me.ComboBoxDeleteTestEditAlb)
        Me.GroupBoxDeleteTestEditAlb.Controls.Add(Me.TextBoxDeleteTestEditAlb)
        Me.GroupBoxDeleteTestEditAlb.Controls.Add(Me.Label10)
        Me.GroupBoxDeleteTestEditAlb.Location = New System.Drawing.Point(9, 256)
        Me.GroupBoxDeleteTestEditAlb.Name = "GroupBoxDeleteTestEditAlb"
        Me.GroupBoxDeleteTestEditAlb.Size = New System.Drawing.Size(263, 87)
        Me.GroupBoxDeleteTestEditAlb.TabIndex = 38
        Me.GroupBoxDeleteTestEditAlb.TabStop = False
        '
        'ButtonDeleteTestEditAlb
        '
        Me.ButtonDeleteTestEditAlb.BackColor = System.Drawing.Color.Teal
        Me.ButtonDeleteTestEditAlb.FlatAppearance.BorderSize = 0
        Me.ButtonDeleteTestEditAlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteTestEditAlb.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.ButtonDeleteTestEditAlb.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonDeleteTestEditAlb.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonDeleteTestEditAlb.IconSize = 20
        Me.ButtonDeleteTestEditAlb.Location = New System.Drawing.Point(227, 47)
        Me.ButtonDeleteTestEditAlb.Name = "ButtonDeleteTestEditAlb"
        Me.ButtonDeleteTestEditAlb.Size = New System.Drawing.Size(30, 26)
        Me.ButtonDeleteTestEditAlb.TabIndex = 39
        Me.ButtonDeleteTestEditAlb.UseVisualStyleBackColor = False
        '
        'ComboBoxDeleteTestEditAlb
        '
        Me.ComboBoxDeleteTestEditAlb.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxDeleteTestEditAlb.DataSource = Me.TestBindingSource
        Me.ComboBoxDeleteTestEditAlb.DisplayMember = "codi_test"
        Me.ComboBoxDeleteTestEditAlb.FormattingEnabled = True
        Me.ComboBoxDeleteTestEditAlb.Location = New System.Drawing.Point(5, 19)
        Me.ComboBoxDeleteTestEditAlb.Name = "ComboBoxDeleteTestEditAlb"
        Me.ComboBoxDeleteTestEditAlb.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxDeleteTestEditAlb.TabIndex = 26
        Me.ComboBoxDeleteTestEditAlb.ValueMember = "codi_test"
        '
        'TextBoxDeleteTestEditAlb
        '
        Me.TextBoxDeleteTestEditAlb.Location = New System.Drawing.Point(67, 51)
        Me.TextBoxDeleteTestEditAlb.Name = "TextBoxDeleteTestEditAlb"
        Me.TextBoxDeleteTestEditAlb.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxDeleteTestEditAlb.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Eliminar test"
        '
        'CategoriatestBindingSource
        '
        Me.CategoriatestBindingSource.DataMember = "categoria_test"
        Me.CategoriatestBindingSource.DataSource = Me.GestioempresesDataSetBindingSource
        '
        'Categoria_testTableAdapter
        '
        Me.Categoria_testTableAdapter.ClearBeforeFill = True
        '
        'Albaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel0)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Albaran"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridAlbara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioempresesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel0.ResumeLayout(False)
        Me.Panel0.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBoxSearchTest.ResumeLayout(False)
        Me.GroupBoxSearchTest.PerformLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCrearAlbara.ResumeLayout(False)
        Me.GroupBoxCrearAlbara.PerformLayout()
        Me.GroupBoxBuscarEmpresa.ResumeLayout(False)
        Me.GroupBoxBuscarEmpresa.PerformLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxQtyTests.ResumeLayout(False)
        Me.GroupBoxQtyTests.PerformLayout()
        CType(Me.AlbaraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBoxInsertTestEditAlb.ResumeLayout(False)
        Me.GroupBoxInsertTestEditAlb.PerformLayout()
        Me.GroupBoxEditEmpresaAlb.ResumeLayout(False)
        Me.GroupBoxEditEmpresaAlb.PerformLayout()
        Me.GroupBoxQtyTestEditAlb.ResumeLayout(False)
        Me.GroupBoxQtyTestEditAlb.PerformLayout()
        Me.GroupBoxDeleteTestEditAlb.ResumeLayout(False)
        Me.GroupBoxDeleteTestEditAlb.PerformLayout()
        CType(Me.CategoriatestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GestioempresesDataSetBindingSource As BindingSource
    Friend WithEvents Gestio_empresesDataSet As gestio_empresesDataSet
    Friend WithEvents AlbaraBindingSource As BindingSource
    Friend WithEvents AlbaraTableAdapter As gestio_empresesDataSetTableAdapters.albaraTableAdapter
    Friend WithEvents NumalbaraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EditAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents createAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents closeCreateAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBoxSearchTest As GroupBox
    Friend WithEvents ButtonInsertTest As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxSearchTestAlb As ComboBox
    Friend WithEvents TextInsertTest As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonCreateAlbara As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBoxCrearAlbara As GroupBox
    Friend WithEvents RadioButtonCrearAuto As RadioButton
    Friend WithEvents RadioButtonCrearManual As RadioButton
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
    Friend WithEvents AlbaraBindingSource1 As BindingSource
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As gestio_empresesDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents TestBindingSource As BindingSource
    Friend WithEvents TestTableAdapter As gestio_empresesDataSetTableAdapters.testTableAdapter
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ButtonEditAlbaraBack As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBoxInsertTestEditAlb As GroupBox
    Friend WithEvents ButtonInserttestEditAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxSearchTestEditAlb As ComboBox
    Friend WithEvents TextBoxInsertTestEditAlb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonSaveAlbaraEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBoxEditEmpresaAlb As GroupBox
    Friend WithEvents ButtonBuscarEmpresaEditAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxEmpresaEditAlb As ComboBox
    Friend WithEvents TextBoxBuscarEmpresaEditAlb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBoxQtyTestEditAlb As GroupBox
    Friend WithEvents ButtonQtyTestEditAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBoxQtyTestEditAlb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBoxDeleteTestEditAlb As GroupBox
    Friend WithEvents ButtonDeleteTestEditAlb As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxDeleteTestEditAlb As ComboBox
    Friend WithEvents TextBoxDeleteTestEditAlb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CategoriatestBindingSource As BindingSource
    Friend WithEvents Categoria_testTableAdapter As gestio_empresesDataSetTableAdapters.categoria_testTableAdapter
End Class
