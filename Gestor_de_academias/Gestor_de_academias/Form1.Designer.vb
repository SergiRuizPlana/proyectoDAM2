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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Albaranes.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
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
        Me.Contratos.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
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
        Me.Empresas.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
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
        Me.HomeBtn.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
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
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(197, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 126)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Reem Kufi", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Panel4.Location = New System.Drawing.Point(197, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1224, 545)
        Me.Panel4.TabIndex = 2
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PhoenixSquadron
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 70
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(305, 25)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 23.0R
        Me.IconButton1.Size = New System.Drawing.Size(161, 64)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1421, 659)
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
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
