<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tests = New System.Windows.Forms.Button()
        Me.Albaranes = New System.Windows.Forms.Button()
        Me.Contratos = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Empresas = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Tests)
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
        'Tests
        '
        Me.Tests.Location = New System.Drawing.Point(0, 359)
        Me.Tests.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Tests.Name = "Tests"
        Me.Tests.Size = New System.Drawing.Size(197, 40)
        Me.Tests.TabIndex = 5
        Me.Tests.Text = "Tests"
        Me.Tests.UseVisualStyleBackColor = True
        '
        'Albaranes
        '
        Me.Albaranes.Image = Global.Gestor_de_academias.My.Resources.Resources.albaran11
        Me.Albaranes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Albaranes.Location = New System.Drawing.Point(0, 289)
        Me.Albaranes.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Albaranes.Name = "Albaranes"
        Me.Albaranes.Size = New System.Drawing.Size(197, 40)
        Me.Albaranes.TabIndex = 4
        Me.Albaranes.Text = "Albarans"
        Me.Albaranes.UseVisualStyleBackColor = True
        '
        'Contratos
        '
        Me.Contratos.Image = Global.Gestor_de_academias.My.Resources.Resources.contrato1
        Me.Contratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contratos.Location = New System.Drawing.Point(0, 219)
        Me.Contratos.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Contratos.Name = "Contratos"
        Me.Contratos.Size = New System.Drawing.Size(197, 40)
        Me.Contratos.TabIndex = 3
        Me.Contratos.Text = "Contratos"
        Me.Contratos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 140)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(197, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 100)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(564, 30)
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
        Me.Panel4.Location = New System.Drawing.Point(197, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1224, 559)
        Me.Panel4.TabIndex = 2
        '
        'Empresas
        '
        Me.Empresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Empresas.Image = Global.Gestor_de_academias.My.Resources.Resources.emrpresa1
        Me.Empresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Empresas.Location = New System.Drawing.Point(0, 149)
        Me.Empresas.Margin = New System.Windows.Forms.Padding(3, 10, 3, 20)
        Me.Empresas.Name = "Empresas"
        Me.Empresas.Size = New System.Drawing.Size(197, 40)
        Me.Empresas.TabIndex = 2
        Me.Empresas.Text = "Empresas"
        Me.Empresas.UseVisualStyleBackColor = True
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tests As Button
    Friend WithEvents Albaranes As Button
    Friend WithEvents Contratos As Button
    Friend WithEvents Empresas As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
End Class
