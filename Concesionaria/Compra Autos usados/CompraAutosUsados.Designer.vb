<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraAutosUsados
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
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCompra
        '
        Me.BtnCompra.Location = New System.Drawing.Point(12, 12)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(108, 56)
        Me.BtnCompra.TabIndex = 0
        Me.BtnCompra.Text = "Emitir presupuesto"
        Me.BtnCompra.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Location = New System.Drawing.Point(164, 12)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(108, 56)
        Me.btnCheque.TabIndex = 1
        Me.btnCheque.Text = "Emitir cheque"
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(13, 108)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 2
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'frmCompraAutosUsados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 144)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.BtnCompra)
        Me.Name = "frmCompraAutosUsados"
        Me.Text = "CompraAutosUsados"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCompra As System.Windows.Forms.Button
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents btnVol As System.Windows.Forms.Button
End Class
