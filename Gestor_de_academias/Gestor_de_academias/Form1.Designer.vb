<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Empresas = New FontAwesome.Sharp.IconButton()
        Me.Albaranes = New FontAwesome.Sharp.IconButton()
        Me.Contratos = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Gestio_empresesDataSet = New Gestor_de_academias.Gestio_empresesDataSet()
        Me.ContracteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContracteTableAdapter = New Gestor_de_academias.Gestio_empresesDataSetTableAdapters.contracteTableAdapter()
        Me.HomeBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Empresas)
        Me.Panel1.Controls.Add(Me.Albaranes)
        Me.Panel1.Controls.Add(Me.Contratos)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 828)
        Me.Panel1.TabIndex = 0
        '
        'Empresas
        '
        Me.Empresas.BackColor = System.Drawing.Color.Transparent
        Me.Empresas.FlatAppearance.BorderSize = 0
        Me.Empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Empresas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresas.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.Empresas.IconColor = System.Drawing.Color.White
        Me.Empresas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Empresas.Location = New System.Drawing.Point(3, 155)
        Me.Empresas.Name = "Empresas"
        Me.Empresas.Size = New System.Drawing.Size(191, 75)
        Me.Empresas.TabIndex = 7
        Me.Empresas.Text = "    Empreses"
        Me.Empresas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Empresas.UseVisualStyleBackColor = False
        '
        'Albaranes
        '
        Me.Albaranes.BackColor = System.Drawing.Color.Transparent
        Me.Albaranes.FlatAppearance.BorderSize = 0
        Me.Albaranes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Albaranes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albaranes.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.Albaranes.IconColor = System.Drawing.Color.White
        Me.Albaranes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Albaranes.Location = New System.Drawing.Point(3, 387)
        Me.Albaranes.Name = "Albaranes"
        Me.Albaranes.Size = New System.Drawing.Size(191, 75)
        Me.Albaranes.TabIndex = 6
        Me.Albaranes.Text = "    Albarans"
        Me.Albaranes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Albaranes.UseVisualStyleBackColor = False
        '
        'Contratos
        '
        Me.Contratos.BackColor = System.Drawing.Color.Transparent
        Me.Contratos.FlatAppearance.BorderSize = 0
        Me.Contratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contratos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contratos.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.Contratos.IconColor = System.Drawing.Color.White
        Me.Contratos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Contratos.Location = New System.Drawing.Point(3, 270)
        Me.Contratos.Name = "Contratos"
        Me.Contratos.Size = New System.Drawing.Size(191, 75)
        Me.Contratos.TabIndex = 5
        Me.Contratos.Text = "Contractes"
        Me.Contratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Contratos.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(30, 738)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(141, 62)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "About"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.HomeBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 123)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(197, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 123)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(35, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Panel4.Location = New System.Drawing.Point(197, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1334, 707)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(19, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(614, 318)
        Me.Panel5.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(6, 247)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(584, 13)
        Me.Panel7.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(6, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 203)
        Me.Panel6.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(6, 47)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(257, 13)
        Me.Panel8.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Últims contractes"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Location = New System.Drawing.Point(670, 28)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(614, 318)
        Me.Panel9.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(6, 247)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(584, 13)
        Me.Panel11.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(6, 47)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 203)
        Me.Panel10.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(6, 47)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(257, 13)
        Me.Panel12.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Contractes a punt d'expirar"
        '
        'Gestio_empresesDataSet
        '
        Me.Gestio_empresesDataSet.DataSetName = "Gestio_empresesDataSet"
        Me.Gestio_empresesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContracteBindingSource
        '
        Me.ContracteBindingSource.DataMember = "contracte"
        Me.ContracteBindingSource.DataSource = Me.Gestio_empresesDataSet
        '
        'ContracteTableAdapter
        '
        Me.ContracteTableAdapter.ClearBeforeFill = True
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Transparent
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.HomeBtn.IconColor = System.Drawing.Color.White
        Me.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HomeBtn.Location = New System.Drawing.Point(3, 24)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(191, 75)
        Me.HomeBtn.TabIndex = 8
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1531, 828)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.Gestio_empresesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContracteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Gestio_empresesDataSet As Gestio_empresesDataSet
    Friend WithEvents ContracteBindingSource As BindingSource
    Friend WithEvents ContracteTableAdapter As Gestio_empresesDataSetTableAdapters.contracteTableAdapter
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Empresas As FontAwesome.Sharp.IconButton
    Friend WithEvents Albaranes As FontAwesome.Sharp.IconButton
    Friend WithEvents Contratos As FontAwesome.Sharp.IconButton
    Friend WithEvents HomeBtn As FontAwesome.Sharp.IconButton
End Class
