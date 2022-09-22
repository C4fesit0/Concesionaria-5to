<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlMorosos
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
        Me.lstMor = New System.Windows.Forms.ListView()
        Me.lstNomApe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstNC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstCantC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lst3M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblLstM = New System.Windows.Forms.Label()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.btnEmi = New System.Windows.Forms.Button()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMor
        '
        Me.lstMor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstNomApe, Me.lstNC, Me.lstCantC, Me.lst3M})
        Me.lstMor.Location = New System.Drawing.Point(18, 34)
        Me.lstMor.Name = "lstMor"
        Me.lstMor.Size = New System.Drawing.Size(359, 244)
        Me.lstMor.TabIndex = 0
        Me.lstMor.UseCompatibleStateImageBehavior = False
        Me.lstMor.View = System.Windows.Forms.View.Details
        '
        'lstNomApe
        '
        Me.lstNomApe.Text = "Nombre y Apellido"
        Me.lstNomApe.Width = 106
        '
        'lstNC
        '
        Me.lstNC.Text = "N° Contrato"
        Me.lstNC.Width = 77
        '
        'lstCantC
        '
        Me.lstCantC.Text = "Cant cuotas debe"
        Me.lstCantC.Width = 102
        '
        'lst3M
        '
        Me.lst3M.Text = "> 3 meses"
        Me.lst3M.Width = 70
        '
        'lblLstM
        '
        Me.lblLstM.AutoSize = True
        Me.lblLstM.Location = New System.Drawing.Point(12, 9)
        Me.lblLstM.Name = "lblLstM"
        Me.lblLstM.Size = New System.Drawing.Size(89, 13)
        Me.lblLstM.TabIndex = 1
        Me.lblLstM.Text = "Lista de morosos:"
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Location = New System.Drawing.Point(390, 95)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(0, 13)
        Me.lblAux.TabIndex = 2
        Me.lblAux.Visible = False
        '
        'btnEmi
        '
        Me.btnEmi.Location = New System.Drawing.Point(267, 302)
        Me.btnEmi.Name = "btnEmi"
        Me.btnEmi.Size = New System.Drawing.Size(111, 47)
        Me.btnEmi.TabIndex = 3
        Me.btnEmi.Text = "Emitir notificaciones de deuda "
        Me.btnEmi.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(16, 314)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 4
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'frmControlMorosos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 361)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.btnEmi)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.lblLstM)
        Me.Controls.Add(Me.lstMor)
        Me.Name = "frmControlMorosos"
        Me.Text = "Control Morosos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMor As System.Windows.Forms.ListView
    Friend WithEvents lstNomApe As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstCantC As System.Windows.Forms.ColumnHeader
    Friend WithEvents lst3M As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblLstM As System.Windows.Forms.Label
    Friend WithEvents lstNC As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAux As System.Windows.Forms.Label
    Friend WithEvents btnEmi As System.Windows.Forms.Button
    Friend WithEvents btnVol As System.Windows.Forms.Button
End Class
