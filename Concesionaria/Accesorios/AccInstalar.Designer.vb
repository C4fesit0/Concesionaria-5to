<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaIns
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
        Me.lstMuestra = New System.Windows.Forms.ListView()
        Me.lstNota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstAcc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnVeri = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnNota = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMuestra
        '
        Me.lstMuestra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstNota, Me.lstAcc})
        Me.lstMuestra.Location = New System.Drawing.Point(12, 84)
        Me.lstMuestra.Name = "lstMuestra"
        Me.lstMuestra.Size = New System.Drawing.Size(189, 150)
        Me.lstMuestra.TabIndex = 14
        Me.lstMuestra.UseCompatibleStateImageBehavior = False
        Me.lstMuestra.View = System.Windows.Forms.View.Details
        '
        'lstNota
        '
        Me.lstNota.Text = "Nota de instalacion"
        Me.lstNota.Width = 105
        '
        'lstAcc
        '
        Me.lstAcc.Text = "Accesorios"
        Me.lstAcc.Width = 90
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(256, 137)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 22)
        Me.btnCargar.TabIndex = 13
        Me.btnCargar.Text = "Cargar lista"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 31)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 12
        '
        'txtPre
        '
        Me.txtPre.Location = New System.Drawing.Point(128, 31)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(100, 20)
        Me.txtPre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nro presupuesto"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(12, 9)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(60, 13)
        Me.lblDNI.TabIndex = 9
        Me.lblDNI.Text = "DNI cliente"
        '
        'btnVeri
        '
        Me.btnVeri.Location = New System.Drawing.Point(256, 28)
        Me.btnVeri.Name = "btnVeri"
        Me.btnVeri.Size = New System.Drawing.Size(75, 23)
        Me.btnVeri.TabIndex = 8
        Me.btnVeri.Text = "Verificar"
        Me.btnVeri.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 250)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnNota
        '
        Me.btnNota.Enabled = False
        Me.btnNota.Location = New System.Drawing.Point(256, 187)
        Me.btnNota.Name = "btnNota"
        Me.btnNota.Size = New System.Drawing.Size(75, 47)
        Me.btnNota.TabIndex = 16
        Me.btnNota.Text = "Generar nota de instalacion"
        Me.btnNota.UseVisualStyleBackColor = True
        '
        'frmNotaIns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 285)
        Me.Controls.Add(Me.btnNota)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lstMuestra)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.btnVeri)
        Me.Name = "frmNotaIns"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMuestra As System.Windows.Forms.ListView
    Friend WithEvents lstNota As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstAcc As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtPre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents btnVeri As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnNota As System.Windows.Forms.Button
End Class
