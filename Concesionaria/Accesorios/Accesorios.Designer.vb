<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesorios
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
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnNotains = New System.Windows.Forms.Button()
        Me.btnInstalacion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Location = New System.Drawing.Point(12, 30)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(101, 51)
        Me.btnPresupuesto.TabIndex = 0
        Me.btnPresupuesto.Text = "Emitir presupuesto"
        Me.btnPresupuesto.UseVisualStyleBackColor = True
        '
        'btnNotains
        '
        Me.btnNotains.Location = New System.Drawing.Point(171, 30)
        Me.btnNotains.Name = "btnNotains"
        Me.btnNotains.Size = New System.Drawing.Size(101, 51)
        Me.btnNotains.TabIndex = 1
        Me.btnNotains.Text = "Generar nota de instalacion"
        Me.btnNotains.UseVisualStyleBackColor = True
        '
        'btnInstalacion
        '
        Me.btnInstalacion.Location = New System.Drawing.Point(171, 108)
        Me.btnInstalacion.Name = "btnInstalacion"
        Me.btnInstalacion.Size = New System.Drawing.Size(101, 51)
        Me.btnInstalacion.TabIndex = 2
        Me.btnInstalacion.Text = "Instalacion"
        Me.btnInstalacion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(21, 122)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmAccesorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 190)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnInstalacion)
        Me.Controls.Add(Me.btnNotains)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Name = "frmAccesorios"
        Me.Text = "Accesorios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnNotains As System.Windows.Forms.Button
    Friend WithEvents btnInstalacion As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
