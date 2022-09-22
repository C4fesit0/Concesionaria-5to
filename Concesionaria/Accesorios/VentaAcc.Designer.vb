<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentaAcc
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
        Dim lstprec As System.Windows.Forms.ColumnHeader
        Me.nupCant = New System.Windows.Forms.NumericUpDown()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.lstCompras = New System.Windows.Forms.ListView()
        Me.lstdesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btncom = New System.Windows.Forms.Button()
        Me.lblpr = New System.Windows.Forms.Label()
        Me.cbxacc = New System.Windows.Forms.ComboBox()
        Me.lblacc = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnveri = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        lstprec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.nupCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstprec
        '
        lstprec.Text = "Precio"
        lstprec.Width = 95
        '
        'nupCant
        '
        Me.nupCant.Enabled = False
        Me.nupCant.Location = New System.Drawing.Point(158, 98)
        Me.nupCant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupCant.Name = "nupCant"
        Me.nupCant.Size = New System.Drawing.Size(44, 20)
        Me.nupCant.TabIndex = 33
        Me.nupCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(324, 214)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 32
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGen
        '
        Me.btnGen.Location = New System.Drawing.Point(324, 320)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(75, 48)
        Me.btnGen.TabIndex = 31
        Me.btnGen.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "presupuesto"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'lstCompras
        '
        Me.lstCompras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstdesc, lstprec, Me.ColumnHeader1})
        Me.lstCompras.Location = New System.Drawing.Point(9, 145)
        Me.lstCompras.Name = "lstCompras"
        Me.lstCompras.Size = New System.Drawing.Size(287, 223)
        Me.lstCompras.TabIndex = 30
        Me.lstCompras.UseCompatibleStateImageBehavior = False
        Me.lstCompras.View = System.Windows.Forms.View.Details
        '
        'lstdesc
        '
        Me.lstdesc.Text = "Accesorios"
        Me.lstdesc.Width = 134
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cantidad"
        Me.ColumnHeader1.Width = 55
        '
        'btncom
        '
        Me.btncom.Enabled = False
        Me.btncom.Location = New System.Drawing.Point(299, 98)
        Me.btncom.Name = "btncom"
        Me.btncom.Size = New System.Drawing.Size(100, 23)
        Me.btncom.TabIndex = 29
        Me.btncom.Text = "Comprar"
        Me.btncom.UseVisualStyleBackColor = True
        '
        'lblpr
        '
        Me.lblpr.AutoSize = True
        Me.lblpr.Location = New System.Drawing.Point(202, 163)
        Me.lblpr.Name = "lblpr"
        Me.lblpr.Size = New System.Drawing.Size(0, 13)
        Me.lblpr.TabIndex = 28
        '
        'cbxacc
        '
        Me.cbxacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxacc.Enabled = False
        Me.cbxacc.FormattingEnabled = True
        Me.cbxacc.Location = New System.Drawing.Point(12, 97)
        Me.cbxacc.Name = "cbxacc"
        Me.cbxacc.Size = New System.Drawing.Size(121, 21)
        Me.cbxacc.TabIndex = 27
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.Location = New System.Drawing.Point(12, 69)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(54, 13)
        Me.lblacc.TabIndex = 26
        Me.lblacc.Text = "Accesorio"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(9, 13)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(60, 13)
        Me.lbl1.TabIndex = 25
        Me.lbl1.Text = "DNI cliente"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 29)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(124, 20)
        Me.txtDNI.TabIndex = 24
        '
        'btnveri
        '
        Me.btnveri.Location = New System.Drawing.Point(158, 29)
        Me.btnveri.Name = "btnveri"
        Me.btnveri.Size = New System.Drawing.Size(100, 23)
        Me.btnveri.TabIndex = 23
        Me.btnveri.Text = "Verificar"
        Me.btnveri.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(9, 396)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmVentaAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 441)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.nupCant)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.lstCompras)
        Me.Controls.Add(Me.btncom)
        Me.Controls.Add(Me.lblpr)
        Me.Controls.Add(Me.cbxacc)
        Me.Controls.Add(Me.lblacc)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.btnveri)
        Me.Name = "frmVentaAcc"
        Me.Text = "Form3"
        CType(Me.nupCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nupCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents lstCompras As System.Windows.Forms.ListView
    Friend WithEvents lstdesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btncom As System.Windows.Forms.Button
    Friend WithEvents lblpr As System.Windows.Forms.Label
    Friend WithEvents cbxacc As System.Windows.Forms.ComboBox
    Friend WithEvents lblacc As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnveri As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
