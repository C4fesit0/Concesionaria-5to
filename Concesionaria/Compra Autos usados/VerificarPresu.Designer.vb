<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerificarPresu
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
        Me.lstauto = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnVeri = New System.Windows.Forms.Button()
        Me.txtpresu = New System.Windows.Forms.TextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstauto
        '
        Me.lstauto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstauto.Location = New System.Drawing.Point(15, 96)
        Me.lstauto.Name = "lstauto"
        Me.lstauto.Size = New System.Drawing.Size(265, 117)
        Me.lstauto.TabIndex = 13
        Me.lstauto.UseCompatibleStateImageBehavior = False
        Me.lstauto.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Modelo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kilometraje"
        Me.ColumnHeader3.Width = 79
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        '
        'btnGen
        '
        Me.btnGen.Enabled = False
        Me.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGen.Location = New System.Drawing.Point(298, 106)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(75, 36)
        Me.btnGen.TabIndex = 12
        Me.btnGen.Text = "Generar cheque"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DNI cliente"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(15, 31)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 10
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(162, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(118, 13)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "numero de presupuesto"
        '
        'btnVeri
        '
        Me.btnVeri.Location = New System.Drawing.Point(298, 28)
        Me.btnVeri.Name = "btnVeri"
        Me.btnVeri.Size = New System.Drawing.Size(75, 23)
        Me.btnVeri.TabIndex = 8
        Me.btnVeri.Text = "Verificar"
        Me.btnVeri.UseVisualStyleBackColor = True
        '
        'txtpresu
        '
        Me.txtpresu.Location = New System.Drawing.Point(165, 31)
        Me.txtpresu.Name = "txtpresu"
        Me.txtpresu.Size = New System.Drawing.Size(100, 20)
        Me.txtpresu.TabIndex = 7
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(15, 232)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 14
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'frmVerificarPresu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 276)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.lstauto)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnVeri)
        Me.Controls.Add(Me.txtpresu)
        Me.Name = "frmVerificarPresu"
        Me.Text = "VerificarPresu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstauto As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnVeri As System.Windows.Forms.Button
    Friend WithEvents txtpresu As System.Windows.Forms.TextBox
    Friend WithEvents btnvolver As System.Windows.Forms.Button
End Class
