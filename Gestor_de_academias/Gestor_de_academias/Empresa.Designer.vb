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
        Me.SuspendLayout()
        '
        'Empresa
        '
        Me.ClientSize = New System.Drawing.Size(1444, 800)
        Me.Name = "Empresa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Gestio_empresesDataSet As gestio_empresesDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As gestio_empresesDataSetTableAdapters.empresaTableAdapter
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
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip1 As ToolTip
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents EditCat As FontAwesome.Sharp.IconButton
End Class
