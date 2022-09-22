<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstalacion
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
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnVeri = New System.Windows.Forms.Button()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Enabled = False
        Me.btnupdate.Location = New System.Drawing.Point(12, 134)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "modificar"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnVeri
        '
        Me.btnVeri.Location = New System.Drawing.Point(86, 75)
        Me.btnVeri.Name = "btnVeri"
        Me.btnVeri.Size = New System.Drawing.Size(75, 23)
        Me.btnVeri.TabIndex = 10
        Me.btnVeri.Text = "Verificar"
        Me.btnVeri.UseVisualStyleBackColor = True
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(130, 14)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(98, 13)
        Me.lblNota.TabIndex = 9
        Me.lblNota.Text = "Nota de instalacion"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(9, 14)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(60, 13)
        Me.lblDNI.TabIndex = 8
        Me.lblDNI.Text = "DNI cliente"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(133, 33)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNota.TabIndex = 7
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 33)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 6
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 226)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.Enabled = False
        Me.btnFactura.Location = New System.Drawing.Point(179, 128)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(75, 35)
        Me.btnFactura.TabIndex = 13
        Me.btnFactura.Text = "Emitir factura"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'frmInstalacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnVeri)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtDNI)
        Me.Name = "frmInstalacion"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnVeri As System.Windows.Forms.Button
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
End Class
