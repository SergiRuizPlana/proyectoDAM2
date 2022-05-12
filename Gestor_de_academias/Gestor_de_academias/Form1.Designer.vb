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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Albaranes = New System.Windows.Forms.Button()
        Me.Contratos = New System.Windows.Forms.Button()
        Me.Empresas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HomeBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Albaranes)
        Me.Panel1.Controls.Add(Me.Contratos)
        Me.Panel1.Controls.Add(Me.Empresas)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 659)
        Me.Panel1.TabIndex = 0
        '
        'Albaranes
        '
        Me.Albaranes.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Albaranes.FlatAppearance.BorderSize = 0
        Me.Albaranes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Albaranes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Albaranes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Albaranes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Albaranes.ForeColor = System.Drawing.Color.Cornsilk
        Me.Albaranes.Image = Global.Gestor_de_academias.My.Resources.Resources.albaran11
        Me.Albaranes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Albaranes.Location = New System.Drawing.Point(0, 289)
        Me.Albaranes.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Albaranes.Name = "Albaranes"
        Me.Albaranes.Size = New System.Drawing.Size(197, 47)
        Me.Albaranes.TabIndex = 4
        Me.Albaranes.Text = "Albarans"
        Me.Albaranes.UseVisualStyleBackColor = False
        '
        'Contratos
        '
        Me.Contratos.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Contratos.FlatAppearance.BorderSize = 0
        Me.Contratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Contratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Contratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Contratos.ForeColor = System.Drawing.Color.Cornsilk
        Me.Contratos.Image = Global.Gestor_de_academias.My.Resources.Resources.contrato1
        Me.Contratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contratos.Location = New System.Drawing.Point(0, 219)
        Me.Contratos.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Contratos.Name = "Contratos"
        Me.Contratos.Size = New System.Drawing.Size(197, 47)
        Me.Contratos.TabIndex = 3
        Me.Contratos.Text = "Contratos"
        Me.Contratos.UseVisualStyleBackColor = False
        '
        'Empresas
        '
        Me.Empresas.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Empresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Empresas.FlatAppearance.BorderSize = 0
        Me.Empresas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Empresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Empresas.ForeColor = System.Drawing.Color.Cornsilk
        Me.Empresas.Image = Global.Gestor_de_academias.My.Resources.Resources.emrpresa1
        Me.Empresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Empresas.Location = New System.Drawing.Point(0, 149)
        Me.Empresas.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Empresas.Name = "Empresas"
        Me.Empresas.Size = New System.Drawing.Size(197, 47)
        Me.Empresas.TabIndex = 2
        Me.Empresas.Text = "Empresas"
        Me.Empresas.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.HomeBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 140)
        Me.Panel3.TabIndex = 1
        '
        'HomeBtn
        '
        Me.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.HomeBtn.IconColor = System.Drawing.Color.Black
        Me.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HomeBtn.IconSize = 40
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.Location = New System.Drawing.Point(0, 0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(197, 49)
        Me.HomeBtn.TabIndex = 7
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(197, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1173, 126)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Panel4.Location = New System.Drawing.Point(197, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1173, 545)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(289, -95)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(595, 735)
        Me.Panel5.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 218)
        Me.DataGridView1.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(6, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 253)
        Me.Panel6.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(6, 290)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(584, 13)
        Me.Panel7.TabIndex = 2
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Últims contractes:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 659)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Albaranes As Button
    Friend WithEvents Contratos As Button
    Friend WithEvents Empresas As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents HomeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label2 As Label
End Class
