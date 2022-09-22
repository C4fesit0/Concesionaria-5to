<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicioReclamos
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt1DocumentoSR = New System.Windows.Forms.TextBox()
        Me.txt2MatriculaSR = New System.Windows.Forms.TextBox()
        Me.btn1Verificar = New System.Windows.Forms.Button()
        Me.btn2VolverSR = New System.Windows.Forms.Button()
        Me.btn3VerificarAuto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(29, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(114, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Documento del Cliente"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Enabled = False
        Me.lbl2.Location = New System.Drawing.Point(26, 89)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(91, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Matricula del auto"
        '
        'txt1DocumentoSR
        '
        Me.txt1DocumentoSR.Location = New System.Drawing.Point(29, 44)
        Me.txt1DocumentoSR.MaxLength = 8
        Me.txt1DocumentoSR.Name = "txt1DocumentoSR"
        Me.txt1DocumentoSR.Size = New System.Drawing.Size(117, 20)
        Me.txt1DocumentoSR.TabIndex = 2
        '
        'txt2MatriculaSR
        '
        Me.txt2MatriculaSR.Location = New System.Drawing.Point(27, 105)
        Me.txt2MatriculaSR.MaxLength = 7
        Me.txt2MatriculaSR.Name = "txt2MatriculaSR"
        Me.txt2MatriculaSR.Size = New System.Drawing.Size(116, 20)
        Me.txt2MatriculaSR.TabIndex = 4
        '
        'btn1Verificar
        '
        Me.btn1Verificar.Location = New System.Drawing.Point(168, 34)
        Me.btn1Verificar.Name = "btn1Verificar"
        Me.btn1Verificar.Size = New System.Drawing.Size(81, 30)
        Me.btn1Verificar.TabIndex = 5
        Me.btn1Verificar.Text = "Verificar"
        Me.btn1Verificar.UseVisualStyleBackColor = True
        '
        'btn2VolverSR
        '
        Me.btn2VolverSR.Location = New System.Drawing.Point(29, 182)
        Me.btn2VolverSR.Name = "btn2VolverSR"
        Me.btn2VolverSR.Size = New System.Drawing.Size(82, 41)
        Me.btn2VolverSR.TabIndex = 7
        Me.btn2VolverSR.Text = "Volver"
        Me.btn2VolverSR.UseVisualStyleBackColor = True
        '
        'btn3VerificarAuto
        '
        Me.btn3VerificarAuto.Enabled = False
        Me.btn3VerificarAuto.Location = New System.Drawing.Point(168, 96)
        Me.btn3VerificarAuto.Name = "btn3VerificarAuto"
        Me.btn3VerificarAuto.Size = New System.Drawing.Size(81, 36)
        Me.btn3VerificarAuto.TabIndex = 8
        Me.btn3VerificarAuto.Text = "Verificar Auto"
        Me.btn3VerificarAuto.UseVisualStyleBackColor = True
        '
        'ServicioReclamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 249)
        Me.Controls.Add(Me.btn3VerificarAuto)
        Me.Controls.Add(Me.btn2VolverSR)
        Me.Controls.Add(Me.btn1Verificar)
        Me.Controls.Add(Me.txt2MatriculaSR)
        Me.Controls.Add(Me.txt1DocumentoSR)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "ServicioReclamos"
        Me.Text = "Servicio De reclamos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txt1DocumentoSR As System.Windows.Forms.TextBox
    Friend WithEvents txt2MatriculaSR As System.Windows.Forms.TextBox
    Friend WithEvents btn1Verificar As System.Windows.Forms.Button
    Friend WithEvents btn2VolverSR As System.Windows.Forms.Button
    Friend WithEvents btn3VerificarAuto As System.Windows.Forms.Button
End Class
