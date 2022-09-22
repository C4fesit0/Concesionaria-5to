<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciclado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciclado))
        Me.lblTit = New System.Windows.Forms.Label()
        Me.btnEmi = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lstM8 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVol = New System.Windows.Forms.Button()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(12, 18)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(275, 15)
        Me.lblTit.TabIndex = 0
        Me.lblTit.Text = "Lista de autos con mas de 8 años de antiguedad:"
        '
        'btnEmi
        '
        Me.btnEmi.Location = New System.Drawing.Point(282, 226)
        Me.btnEmi.Name = "btnEmi"
        Me.btnEmi.Size = New System.Drawing.Size(83, 38)
        Me.btnEmi.TabIndex = 1
        Me.btnEmi.Text = "Emitir nota de baja"
        Me.btnEmi.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lstM8
        '
        Me.lstM8.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstM8.Location = New System.Drawing.Point(12, 46)
        Me.lstM8.Name = "lstM8"
        Me.lstM8.Size = New System.Drawing.Size(353, 174)
        Me.lstM8.TabIndex = 2
        Me.lstM8.UseCompatibleStateImageBehavior = False
        Me.lstM8.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Matricula"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Km Uso"
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(15, 234)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 3
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Location = New System.Drawing.Point(183, 243)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(0, 13)
        Me.lblAux.TabIndex = 4
        Me.lblAux.Visible = False
        '
        'frmReciclado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 276)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.lstM8)
        Me.Controls.Add(Me.btnEmi)
        Me.Controls.Add(Me.lblTit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReciclado"
        Me.Text = "Reciclado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents btnEmi As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lstM8 As System.Windows.Forms.ListView
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAux As System.Windows.Forms.Label
End Class
