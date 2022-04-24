<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EmpresaAlbara = New System.Windows.Forms.Button()
        Me.EmpresaContrato = New System.Windows.Forms.Button()
        Me.EditEmpresa = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdrecaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaltestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestsrealitzatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestsdisponiblesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreutotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestio_empresesDataSet = New Gestor_de_academias.gestio_empresesDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.empresaCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaEmail = New System.Windows.Forms.TextBox()
        Me.empresaPhone = New System.Windows.Forms.TextBox()
        Me.empresaAdresa = New System.Windows.Forms.TextBox()
        Me.empresaCif = New System.Windows.Forms.TextBox()
        Me.empresaNombre = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmpresaTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.TableAdapterManager = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.categoriaTableAdapter()
        Me.searchEmp = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel2.Controls.Add(Me.EmpresaAlbara)
        Me.Panel2.Controls.Add(Me.EmpresaContrato)
        Me.Panel2.Controls.Add(Me.EditEmpresa)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1158, 471)
        Me.Panel2.TabIndex = 18
        '
        'EmpresaAlbara
        '
        Me.EmpresaAlbara.Location = New System.Drawing.Point(1070, 95)
        Me.EmpresaAlbara.Name = "EmpresaAlbara"
        Me.EmpresaAlbara.Size = New System.Drawing.Size(85, 23)
        Me.EmpresaAlbara.TabIndex = 21
        Me.EmpresaAlbara.Text = "Albara"
        Me.EmpresaAlbara.UseVisualStyleBackColor = True
        '
        'EmpresaContrato
        '
        Me.EmpresaContrato.Location = New System.Drawing.Point(1070, 66)
        Me.EmpresaContrato.Name = "EmpresaContrato"
        Me.EmpresaContrato.Size = New System.Drawing.Size(85, 23)
        Me.EmpresaContrato.TabIndex = 20
        Me.EmpresaContrato.Text = "Contrato"
        Me.EmpresaContrato.UseVisualStyleBackColor = True
        '
        'EditEmpresa
        '
        Me.EditEmpresa.Location = New System.Drawing.Point(1070, 37)
        Me.EditEmpresa.Name = "EditEmpresa"
        Me.EditEmpresa.Size = New System.Drawing.Size(85, 23)
        Me.EditEmpresa.TabIndex = 19
        Me.EditEmpresa.Text = "Edit"
        Me.EditEmpresa.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CifDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.AdrecaDataGridViewTextBoxColumn, Me.TelfDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.TotaltestsDataGridViewTextBoxColumn, Me.TestsrealitzatsDataGridViewTextBoxColumn, Me.TestsdisponiblesDataGridViewTextBoxColumn, Me.PreutotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpresaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(20, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 408)
        Me.DataGridView1.TabIndex = 0
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "cif"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdrecaDataGridViewTextBoxColumn
        '
        Me.AdrecaDataGridViewTextBoxColumn.DataPropertyName = "adreca"
        Me.AdrecaDataGridViewTextBoxColumn.HeaderText = "adreca"
        Me.AdrecaDataGridViewTextBoxColumn.Name = "AdrecaDataGridViewTextBoxColumn"
        Me.AdrecaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelfDataGridViewTextBoxColumn
        '
        Me.TelfDataGridViewTextBoxColumn.DataPropertyName = "telf"
        Me.TelfDataGridViewTextBoxColumn.HeaderText = "telf"
        Me.TelfDataGridViewTextBoxColumn.Name = "TelfDataGridViewTextBoxColumn"
        Me.TelfDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotaltestsDataGridViewTextBoxColumn
        '
        Me.TotaltestsDataGridViewTextBoxColumn.DataPropertyName = "total_tests"
        Me.TotaltestsDataGridViewTextBoxColumn.HeaderText = "total_tests"
        Me.TotaltestsDataGridViewTextBoxColumn.Name = "TotaltestsDataGridViewTextBoxColumn"
        Me.TotaltestsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestsrealitzatsDataGridViewTextBoxColumn
        '
        Me.TestsrealitzatsDataGridViewTextBoxColumn.DataPropertyName = "tests_realitzats"
        Me.TestsrealitzatsDataGridViewTextBoxColumn.HeaderText = "tests_realitzats"
        Me.TestsrealitzatsDataGridViewTextBoxColumn.Name = "TestsrealitzatsDataGridViewTextBoxColumn"
        Me.TestsrealitzatsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestsdisponiblesDataGridViewTextBoxColumn
        '
        Me.TestsdisponiblesDataGridViewTextBoxColumn.DataPropertyName = "tests_disponibles"
        Me.TestsdisponiblesDataGridViewTextBoxColumn.HeaderText = "tests_disponibles"
        Me.TestsdisponiblesDataGridViewTextBoxColumn.Name = "TestsdisponiblesDataGridViewTextBoxColumn"
        Me.TestsdisponiblesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreutotalDataGridViewTextBoxColumn
        '
        Me.PreutotalDataGridViewTextBoxColumn.DataPropertyName = "preu_total"
        Me.PreutotalDataGridViewTextBoxColumn.HeaderText = "preu_total"
        Me.PreutotalDataGridViewTextBoxColumn.Name = "PreutotalDataGridViewTextBoxColumn"
        Me.PreutotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'Gestio_empresesDataSet
        '
        Me.Gestio_empresesDataSet.DataSetName = "gestio_empresesDataSet"
        Me.Gestio_empresesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(433, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Categoria"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.empresaCategoria)
        Me.Panel1.Controls.Add(Me.EmpresaEmail)
        Me.Panel1.Controls.Add(Me.empresaPhone)
        Me.Panel1.Controls.Add(Me.empresaAdresa)
        Me.Panel1.Controls.Add(Me.empresaCif)
        Me.Panel1.Controls.Add(Me.empresaNombre)
        Me.Panel1.Location = New System.Drawing.Point(1176, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 407)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "telf"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Adresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CIF"
        '
        'empresaCategoria
        '
        Me.empresaCategoria.DataSource = Me.CategoriaBindingSource
        Me.empresaCategoria.DisplayMember = "descripcio"
        Me.empresaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empresaCategoria.FormattingEnabled = True
        Me.empresaCategoria.Location = New System.Drawing.Point(51, 165)
        Me.empresaCategoria.Name = "empresaCategoria"
        Me.empresaCategoria.Size = New System.Drawing.Size(138, 21)
        Me.empresaCategoria.TabIndex = 11
        Me.empresaCategoria.ValueMember = "cod_categoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'EmpresaEmail
        '
        Me.EmpresaEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpresaEmail.Location = New System.Drawing.Point(51, 138)
        Me.EmpresaEmail.Name = "EmpresaEmail"
        Me.EmpresaEmail.Size = New System.Drawing.Size(138, 20)
        Me.EmpresaEmail.TabIndex = 10
        '
        'empresaPhone
        '
        Me.empresaPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaPhone.Location = New System.Drawing.Point(51, 112)
        Me.empresaPhone.Name = "empresaPhone"
        Me.empresaPhone.Size = New System.Drawing.Size(138, 20)
        Me.empresaPhone.TabIndex = 9
        '
        'empresaAdresa
        '
        Me.empresaAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaAdresa.Location = New System.Drawing.Point(51, 86)
        Me.empresaAdresa.Name = "empresaAdresa"
        Me.empresaAdresa.Size = New System.Drawing.Size(138, 20)
        Me.empresaAdresa.TabIndex = 8
        '
        'empresaCif
        '
        Me.empresaCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaCif.Location = New System.Drawing.Point(51, 60)
        Me.empresaCif.Name = "empresaCif"
        Me.empresaCif.Size = New System.Drawing.Size(138, 20)
        Me.empresaCif.TabIndex = 7
        '
        'empresaNombre
        '
        Me.empresaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaNombre.Location = New System.Drawing.Point(51, 34)
        Me.empresaNombre.Name = "empresaNombre"
        Me.empresaNombre.Size = New System.Drawing.Size(138, 20)
        Me.empresaNombre.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoriaBindingSource
        Me.ComboBox1.DisplayMember = "descripcio"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(436, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "descripcio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Adresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CIF"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(330, 44)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(224, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(118, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(12, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1156, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.albara_testTableAdapter = Nothing
        Me.TableAdapterManager.albaraTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoria_testTableAdapter = Nothing
        Me.TableAdapterManager.categoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.contracteTableAdapter = Nothing
        Me.TableAdapterManager.testTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestor_de_academias.gestio_empresesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'searchEmp
        '
        Me.searchEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.searchEmp.FlatAppearance.BorderSize = 0
        Me.searchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchEmp.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.searchEmp.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.searchEmp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchEmp.IconSize = 30
        Me.searchEmp.Location = New System.Drawing.Point(580, 36)
        Me.searchEmp.Name = "searchEmp"
        Me.searchEmp.Size = New System.Drawing.Size(42, 35)
        Me.searchEmp.TabIndex = 19
        Me.searchEmp.UseVisualStyleBackColor = False
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1551, 1227)
        Me.Controls.Add(Me.searchEmp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Empresa"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Gestio_empresesDataSet As gestio_empresesDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As gestio_empresesDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdrecaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotaltestsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestsrealitzatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestsdisponiblesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreutotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableAdapterManager As gestio_empresesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaTableAdapter As gestio_empresesDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents empresaCategoria As ComboBox
    Friend WithEvents EmpresaEmail As TextBox
    Friend WithEvents empresaPhone As TextBox
    Friend WithEvents empresaAdresa As TextBox
    Friend WithEvents empresaCif As TextBox
    Friend WithEvents empresaNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EmpresaAlbara As Button
    Friend WithEvents EmpresaContrato As Button
    Friend WithEvents EditEmpresa As Button
    Friend WithEvents searchEmp As FontAwesome.Sharp.IconButton
End Class
