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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodecontracteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatainiciDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestsmensualsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContracteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestio_empresesDataSet = New Gestor_de_academias.gestio_empresesDataSet()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContracteTableAdapter = New Gestor_de_academias.gestio_empresesDataSetTableAdapters.contracteTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1423, 546)
        Me.Panel1.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Navy
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.IconButton1.IconColor = System.Drawing.Color.Navy
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(251, 285)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(206, 40)
        Me.IconButton1.TabIndex = 8
        Me.IconButton1.Text = "Crear nou contracte"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.Navy
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.List
        Me.IconButton3.IconColor = System.Drawing.Color.Navy
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 35
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(34, 285)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(206, 40)
        Me.IconButton3.TabIndex = 7
        Me.IconButton3.Text = "Llista de Contractes"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(88, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No hi ha cap contracte!"
        Me.Label2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodecontracteDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn, Me.DatainiciDataGridViewTextBoxColumn, Me.TestsmensualsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContracteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(474, 115)
        Me.DataGridView1.TabIndex = 3
        '
        'CodecontracteDataGridViewTextBoxColumn
        '
        Me.CodecontracteDataGridViewTextBoxColumn.DataPropertyName = "Code_contracte"
        Me.CodecontracteDataGridViewTextBoxColumn.HeaderText = "Code_contracte"
        Me.CodecontracteDataGridViewTextBoxColumn.Name = "CodecontracteDataGridViewTextBoxColumn"
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.Width = 130
        '
        'DatainiciDataGridViewTextBoxColumn
        '
        Me.DatainiciDataGridViewTextBoxColumn.DataPropertyName = "Data_inici"
        Me.DatainiciDataGridViewTextBoxColumn.HeaderText = "Data_inici"
        Me.DatainiciDataGridViewTextBoxColumn.Name = "DatainiciDataGridViewTextBoxColumn"
        '
        'TestsmensualsDataGridViewTextBoxColumn
        '
        Me.TestsmensualsDataGridViewTextBoxColumn.DataPropertyName = "Tests_mensuals"
        Me.TestsmensualsDataGridViewTextBoxColumn.HeaderText = "Tests_mensuals"
        Me.TestsmensualsDataGridViewTextBoxColumn.Name = "TestsmensualsDataGridViewTextBoxColumn"
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(34, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 181)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(34, 238)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1386, 13)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(34, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 13)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ultims Contractes modificats:"
        '
        'ContracteTableAdapter
        '
        Me.ContracteTableAdapter.ClearBeforeFill = True
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1626, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Contrato"
        Me.Text = "Contrato"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Gestio_empresesDataSet As gestio_empresesDataSet
    Friend WithEvents ContracteBindingSource As BindingSource
    Friend WithEvents ContracteTableAdapter As gestio_empresesDataSetTableAdapters.contracteTableAdapter
    Friend WithEvents CodecontracteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatainiciDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestsmensualsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
