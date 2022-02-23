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
        Me.components = New System.ComponentModel.Container()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReniecDataSet = New VBReniec.ReniecDataSet()
        Me.PersonaTableAdapter = New VBReniec.ReniecDataSetTableAdapters.personaTableAdapter()
        Me.ReniecDataSet1 = New VBReniec.ReniecDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReniecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReniecDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(32, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(166, 89)
        Me.btnbuscar.TabIndex = 0
        Me.btnbuscar.Text = "Buscar datos"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(283, 47)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(117, 20)
        Me.txtdni.TabIndex = 1
        '
        'DataSetBindingSource
        '
        Me.DataSetBindingSource.DataSource = GetType(System.Data.DataSet)
        Me.DataSetBindingSource.Position = 0
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "persona"
        Me.PersonaBindingSource.DataSource = Me.ReniecDataSet
        '
        'ReniecDataSet
        '
        Me.ReniecDataSet.DataSetName = "ReniecDataSet"
        Me.ReniecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'ReniecDataSet1
        '
        Me.ReniecDataSet1.DataSetName = "ReniecDataSet"
        Me.ReniecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(471, 127)
        Me.DataGridView1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 278)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.btnbuscar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReniecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReniecDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtdni As TextBox
    Friend WithEvents DataSetBindingSource As BindingSource
    Friend WithEvents ReniecDataSet As ReniecDataSet
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As ReniecDataSetTableAdapters.personaTableAdapter
    Friend WithEvents ReniecDataSet1 As ReniecDataSet
    Friend WithEvents DataGridView1 As DataGridView
End Class
