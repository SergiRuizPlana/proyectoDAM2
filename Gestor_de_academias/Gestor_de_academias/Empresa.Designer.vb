﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.EditEmpresa = New FontAwesome.Sharp.IconButton()
        Me.createEmpresa = New FontAwesome.Sharp.IconButton()
        Me.EmpresaAlbara = New System.Windows.Forms.Button()
        Me.EmpresaContrato = New System.Windows.Forms.Button()
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
        Me.CancelEmpresa = New FontAwesome.Sharp.IconButton()
        Me.SaveEmpresa = New FontAwesome.Sharp.IconButton()
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
        Me.emailEmpFilter = New System.Windows.Forms.TextBox()
        Me.adresaEmpFilter = New System.Windows.Forms.TextBox()
        Me.nomEmpFilter = New System.Windows.Forms.TextBox()
        Me.cifEmpFilter = New System.Windows.Forms.TextBox()
        Me.EmpresaTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.empresaTableAdapter()
        Me.TableAdapterManager = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.categoriaTableAdapter()
        Me.searchEmp = New FontAwesome.Sharp.IconButton()
        Me.categEmpFilter = New System.Windows.Forms.Panel()
        Me.createLabel = New System.Windows.Forms.Label()
        Me.RestartFilterEmp = New FontAwesome.Sharp.IconButton()
        Me.CategoriaCreate = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.catdescripcio = New System.Windows.Forms.TextBox()
        Me.saveCat = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.categEmpFilter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel2.Controls.Add(Me.EditEmpresa)
        Me.Panel2.Controls.Add(Me.createEmpresa)
        Me.Panel2.Controls.Add(Me.EmpresaAlbara)
        Me.Panel2.Controls.Add(Me.EmpresaContrato)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 471)
        Me.Panel2.TabIndex = 18
        '
        'EditEmpresa
        '
        Me.EditEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.EditEmpresa.FlatAppearance.BorderSize = 0
        Me.EditEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EditEmpresa.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.EditEmpresa.IconColor = System.Drawing.Color.Black
        Me.EditEmpresa.IconFont = FontAwesome.Sharp.IconFont.Regular
        Me.EditEmpresa.IconSize = 25
        Me.EditEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditEmpresa.Location = New System.Drawing.Point(1103, 78)
        Me.EditEmpresa.Name = "EditEmpresa"
        Me.EditEmpresa.Size = New System.Drawing.Size(85, 28)
        Me.EditEmpresa.TabIndex = 24
        Me.EditEmpresa.Text = "     Editar"
        Me.EditEmpresa.UseVisualStyleBackColor = False
        '
        'createEmpresa
        '
        Me.createEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.createEmpresa.FlatAppearance.BorderSize = 0
        Me.createEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.createEmpresa.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.createEmpresa.IconColor = System.Drawing.Color.Black
        Me.createEmpresa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.createEmpresa.IconSize = 20
        Me.createEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.createEmpresa.Location = New System.Drawing.Point(1103, 37)
        Me.createEmpresa.Name = "createEmpresa"
        Me.createEmpresa.Size = New System.Drawing.Size(85, 31)
        Me.createEmpresa.TabIndex = 23
        Me.createEmpresa.Text = "    Crear"
        Me.createEmpresa.UseVisualStyleBackColor = False
        '
        'EmpresaAlbara
        '
        Me.EmpresaAlbara.Location = New System.Drawing.Point(1103, 181)
        Me.EmpresaAlbara.Name = "EmpresaAlbara"
        Me.EmpresaAlbara.Size = New System.Drawing.Size(85, 23)
        Me.EmpresaAlbara.TabIndex = 21
        Me.EmpresaAlbara.Text = "Albara"
        Me.EmpresaAlbara.UseVisualStyleBackColor = True
        '
        'EmpresaContrato
        '
        Me.EmpresaContrato.Location = New System.Drawing.Point(1103, 210)
        Me.EmpresaContrato.Name = "EmpresaContrato"
        Me.EmpresaContrato.Size = New System.Drawing.Size(85, 23)
        Me.EmpresaContrato.TabIndex = 20
        Me.EmpresaContrato.Text = "Contrato"
        Me.EmpresaContrato.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CifDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.AdrecaDataGridViewTextBoxColumn, Me.TelfDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.TotaltestsDataGridViewTextBoxColumn, Me.TestsrealitzatsDataGridViewTextBoxColumn, Me.TestsdisponiblesDataGridViewTextBoxColumn, Me.PreutotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpresaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(20, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1090, 408)
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
        Me.Label11.Location = New System.Drawing.Point(434, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Categoria"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CategoriaCreate)
        Me.Panel1.Controls.Add(Me.createLabel)
        Me.Panel1.Controls.Add(Me.CancelEmpresa)
        Me.Panel1.Controls.Add(Me.SaveEmpresa)
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
        Me.Panel1.Location = New System.Drawing.Point(1222, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 407)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'CancelEmpresa
        '
        Me.CancelEmpresa.FlatAppearance.BorderSize = 0
        Me.CancelEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEmpresa.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.CancelEmpresa.IconColor = System.Drawing.Color.Red
        Me.CancelEmpresa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CancelEmpresa.IconSize = 37
        Me.CancelEmpresa.Location = New System.Drawing.Point(51, 331)
        Me.CancelEmpresa.Name = "CancelEmpresa"
        Me.CancelEmpresa.Size = New System.Drawing.Size(51, 40)
        Me.CancelEmpresa.TabIndex = 26
        Me.CancelEmpresa.UseVisualStyleBackColor = True
        '
        'SaveEmpresa
        '
        Me.SaveEmpresa.FlatAppearance.BorderSize = 0
        Me.SaveEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveEmpresa.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.SaveEmpresa.IconColor = System.Drawing.Color.Lime
        Me.SaveEmpresa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveEmpresa.IconSize = 35
        Me.SaveEmpresa.Location = New System.Drawing.Point(230, 331)
        Me.SaveEmpresa.Name = "SaveEmpresa"
        Me.SaveEmpresa.Size = New System.Drawing.Size(51, 40)
        Me.SaveEmpresa.TabIndex = 25
        Me.SaveEmpresa.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Categoria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "telf"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Adresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CIF"
        '
        'empresaCategoria
        '
        Me.empresaCategoria.DataSource = Me.CategoriaBindingSource
        Me.empresaCategoria.DisplayMember = "descripcio"
        Me.empresaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empresaCategoria.FormattingEnabled = True
        Me.empresaCategoria.Location = New System.Drawing.Point(99, 217)
        Me.empresaCategoria.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
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
        Me.EmpresaEmail.Location = New System.Drawing.Point(99, 184)
        Me.EmpresaEmail.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.EmpresaEmail.Name = "EmpresaEmail"
        Me.EmpresaEmail.Size = New System.Drawing.Size(138, 20)
        Me.EmpresaEmail.TabIndex = 10
        '
        'empresaPhone
        '
        Me.empresaPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaPhone.Location = New System.Drawing.Point(99, 151)
        Me.empresaPhone.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.empresaPhone.Name = "empresaPhone"
        Me.empresaPhone.Size = New System.Drawing.Size(138, 20)
        Me.empresaPhone.TabIndex = 9
        '
        'empresaAdresa
        '
        Me.empresaAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaAdresa.Location = New System.Drawing.Point(99, 118)
        Me.empresaAdresa.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.empresaAdresa.Name = "empresaAdresa"
        Me.empresaAdresa.Size = New System.Drawing.Size(138, 20)
        Me.empresaAdresa.TabIndex = 8
        '
        'empresaCif
        '
        Me.empresaCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaCif.Location = New System.Drawing.Point(99, 85)
        Me.empresaCif.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.empresaCif.Name = "empresaCif"
        Me.empresaCif.Size = New System.Drawing.Size(138, 20)
        Me.empresaCif.TabIndex = 7
        '
        'empresaNombre
        '
        Me.empresaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empresaNombre.Location = New System.Drawing.Point(99, 52)
        Me.empresaNombre.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
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
        Me.ComboBox1.Location = New System.Drawing.Point(437, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "descripcio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Adresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CIF"
        '
        'emailEmpFilter
        '
        Me.emailEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailEmpFilter.Location = New System.Drawing.Point(331, 25)
        Me.emailEmpFilter.Name = "emailEmpFilter"
        Me.emailEmpFilter.Size = New System.Drawing.Size(100, 20)
        Me.emailEmpFilter.TabIndex = 5
        '
        'adresaEmpFilter
        '
        Me.adresaEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adresaEmpFilter.Location = New System.Drawing.Point(225, 25)
        Me.adresaEmpFilter.Name = "adresaEmpFilter"
        Me.adresaEmpFilter.Size = New System.Drawing.Size(100, 20)
        Me.adresaEmpFilter.TabIndex = 4
        '
        'nomEmpFilter
        '
        Me.nomEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nomEmpFilter.Location = New System.Drawing.Point(119, 25)
        Me.nomEmpFilter.Name = "nomEmpFilter"
        Me.nomEmpFilter.Size = New System.Drawing.Size(100, 20)
        Me.nomEmpFilter.TabIndex = 3
        '
        'cifEmpFilter
        '
        Me.cifEmpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cifEmpFilter.Location = New System.Drawing.Point(13, 25)
        Me.cifEmpFilter.Name = "cifEmpFilter"
        Me.cifEmpFilter.Size = New System.Drawing.Size(100, 20)
        Me.cifEmpFilter.TabIndex = 2
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
        Me.searchEmp.Location = New System.Drawing.Point(600, 16)
        Me.searchEmp.Name = "searchEmp"
        Me.searchEmp.Size = New System.Drawing.Size(42, 35)
        Me.searchEmp.TabIndex = 19
        Me.searchEmp.UseVisualStyleBackColor = False
        '
        'categEmpFilter
        '
        Me.categEmpFilter.Controls.Add(Me.RestartFilterEmp)
        Me.categEmpFilter.Controls.Add(Me.cifEmpFilter)
        Me.categEmpFilter.Controls.Add(Me.searchEmp)
        Me.categEmpFilter.Controls.Add(Me.Label1)
        Me.categEmpFilter.Controls.Add(Me.emailEmpFilter)
        Me.categEmpFilter.Controls.Add(Me.Label11)
        Me.categEmpFilter.Controls.Add(Me.Label2)
        Me.categEmpFilter.Controls.Add(Me.adresaEmpFilter)
        Me.categEmpFilter.Controls.Add(Me.ComboBox1)
        Me.categEmpFilter.Controls.Add(Me.Label3)
        Me.categEmpFilter.Controls.Add(Me.nomEmpFilter)
        Me.categEmpFilter.Controls.Add(Me.Label4)
        Me.categEmpFilter.Location = New System.Drawing.Point(32, 13)
        Me.categEmpFilter.Name = "categEmpFilter"
        Me.categEmpFilter.Size = New System.Drawing.Size(707, 57)
        Me.categEmpFilter.TabIndex = 20
        '
        'createLabel
        '
        Me.createLabel.AutoSize = True
        Me.createLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createLabel.Location = New System.Drawing.Point(22, 9)
        Me.createLabel.Name = "createLabel"
        Me.createLabel.Size = New System.Drawing.Size(59, 25)
        Me.createLabel.TabIndex = 27
        Me.createLabel.Text = "Nom"
        '
        'RestartFilterEmp
        '
        Me.RestartFilterEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RestartFilterEmp.FlatAppearance.BorderSize = 0
        Me.RestartFilterEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestartFilterEmp.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.RestartFilterEmp.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.RestartFilterEmp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RestartFilterEmp.IconSize = 30
        Me.RestartFilterEmp.Location = New System.Drawing.Point(648, 16)
        Me.RestartFilterEmp.Name = "RestartFilterEmp"
        Me.RestartFilterEmp.Size = New System.Drawing.Size(42, 35)
        Me.RestartFilterEmp.TabIndex = 20
        Me.RestartFilterEmp.UseVisualStyleBackColor = False
        '
        'CategoriaCreate
        '
        Me.CategoriaCreate.FlatAppearance.BorderSize = 0
        Me.CategoriaCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoriaCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.CategoriaCreate.IconColor = System.Drawing.Color.SeaShell
        Me.CategoriaCreate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CategoriaCreate.IconSize = 30
        Me.CategoriaCreate.Location = New System.Drawing.Point(243, 215)
        Me.CategoriaCreate.Name = "CategoriaCreate"
        Me.CategoriaCreate.Size = New System.Drawing.Size(38, 28)
        Me.CategoriaCreate.TabIndex = 28
        Me.CategoriaCreate.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Nom/desrcipcio"
        '
        'catdescripcio
        '
        Me.catdescripcio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.catdescripcio.Location = New System.Drawing.Point(7, 33)
        Me.catdescripcio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.catdescripcio.Name = "catdescripcio"
        Me.catdescripcio.Size = New System.Drawing.Size(138, 20)
        Me.catdescripcio.TabIndex = 29
        '
        'saveCat
        '
        Me.saveCat.FlatAppearance.BorderSize = 0
        Me.saveCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveCat.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.saveCat.IconColor = System.Drawing.Color.Lime
        Me.saveCat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.saveCat.IconSize = 25
        Me.saveCat.Location = New System.Drawing.Point(151, 33)
        Me.saveCat.Name = "saveCat"
        Me.saveCat.Size = New System.Drawing.Size(38, 26)
        Me.saveCat.TabIndex = 31
        Me.saveCat.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.saveCat)
        Me.Panel3.Controls.Add(Me.catdescripcio)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(92, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 76)
        Me.Panel3.TabIndex = 25
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1551, 1227)
        Me.Controls.Add(Me.categEmpFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Empresa"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.categEmpFilter.ResumeLayout(False)
        Me.categEmpFilter.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents emailEmpFilter As TextBox
    Friend WithEvents adresaEmpFilter As TextBox
    Friend WithEvents nomEmpFilter As TextBox
    Friend WithEvents cifEmpFilter As TextBox
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EmpresaAlbara As Button
    Friend WithEvents EmpresaContrato As Button
    Friend WithEvents searchEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents EditEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents createEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents CancelEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveEmpresa As FontAwesome.Sharp.IconButton
    Friend WithEvents createLabel As Label
    Friend WithEvents categEmpFilter As Panel
    Friend WithEvents RestartFilterEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents saveCat As FontAwesome.Sharp.IconButton
    Friend WithEvents catdescripcio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CategoriaCreate As FontAwesome.Sharp.IconButton
End Class
