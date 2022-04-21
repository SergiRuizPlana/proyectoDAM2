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
        Me.empresaNombre = New System.Windows.Forms.TextBox()
        Me.empresaCif = New System.Windows.Forms.TextBox()
        Me.empresaAdresa = New System.Windows.Forms.TextBox()
        Me.empresaPhone = New System.Windows.Forms.TextBox()
        Me.EmpresaEmail = New System.Windows.Forms.TextBox()
        Me.empresaCategoria = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'empresaNombre
        '
        Me.empresaNombre.Location = New System.Drawing.Point(101, 63)
        Me.empresaNombre.Name = "empresaNombre"
        Me.empresaNombre.Size = New System.Drawing.Size(138, 20)
        Me.empresaNombre.TabIndex = 0
        '
        'empresaCif
        '
        Me.empresaCif.Location = New System.Drawing.Point(101, 89)
        Me.empresaCif.Name = "empresaCif"
        Me.empresaCif.Size = New System.Drawing.Size(138, 20)
        Me.empresaCif.TabIndex = 1
        '
        'empresaAdresa
        '
        Me.empresaAdresa.Location = New System.Drawing.Point(101, 115)
        Me.empresaAdresa.Name = "empresaAdresa"
        Me.empresaAdresa.Size = New System.Drawing.Size(138, 20)
        Me.empresaAdresa.TabIndex = 2
        '
        'empresaPhone
        '
        Me.empresaPhone.Location = New System.Drawing.Point(101, 141)
        Me.empresaPhone.Name = "empresaPhone"
        Me.empresaPhone.Size = New System.Drawing.Size(138, 20)
        Me.empresaPhone.TabIndex = 3
        '
        'EmpresaEmail
        '
        Me.EmpresaEmail.Location = New System.Drawing.Point(101, 167)
        Me.EmpresaEmail.Name = "EmpresaEmail"
        Me.EmpresaEmail.Size = New System.Drawing.Size(138, 20)
        Me.EmpresaEmail.TabIndex = 4
        '
        'empresaCategoria
        '
        Me.empresaCategoria.FormattingEnabled = True
        Me.empresaCategoria.Location = New System.Drawing.Point(101, 194)
        Me.empresaCategoria.Name = "empresaCategoria"
        Me.empresaCategoria.Size = New System.Drawing.Size(138, 21)
        Me.empresaCategoria.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.empresaCategoria)
        Me.Controls.Add(Me.EmpresaEmail)
        Me.Controls.Add(Me.empresaPhone)
        Me.Controls.Add(Me.empresaAdresa)
        Me.Controls.Add(Me.empresaCif)
        Me.Controls.Add(Me.empresaNombre)
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents empresaNombre As TextBox
    Friend WithEvents empresaCif As TextBox
    Friend WithEvents empresaAdresa As TextBox
    Friend WithEvents empresaPhone As TextBox
    Friend WithEvents EmpresaEmail As TextBox
    Friend WithEvents empresaCategoria As ComboBox
    Friend WithEvents Button1 As Button
End Class
