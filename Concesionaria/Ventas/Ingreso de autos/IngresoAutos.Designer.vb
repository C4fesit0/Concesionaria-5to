<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoAutos
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
        Me.lblCons = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblMat = New System.Windows.Forms.Label()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChasis = New System.Windows.Forms.TextBox()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCV = New System.Windows.Forms.TextBox()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.lstCP = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblCons
        '
        Me.lblCons.AutoSize = True
        Me.lblCons.Location = New System.Drawing.Point(9, 13)
        Me.lblCons.Name = "lblCons"
        Me.lblCons.Size = New System.Drawing.Size(128, 13)
        Me.lblCons.TabIndex = 0
        Me.lblCons.Text = "Constancia compraventa:"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(12, 41)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 20)
        Me.txtCP.TabIndex = 1
        '
        'lblMat
        '
        Me.lblMat.AutoSize = True
        Me.lblMat.Location = New System.Drawing.Point(163, 13)
        Me.lblMat.Name = "lblMat"
        Me.lblMat.Size = New System.Drawing.Size(53, 13)
        Me.lblMat.TabIndex = 2
        Me.lblMat.Text = "Matricula:"
        '
        'txtMat
        '
        Me.txtMat.Location = New System.Drawing.Point(166, 41)
        Me.txtMat.MaxLength = 7
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(100, 20)
        Me.txtMat.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "N° Chasis:"
        '
        'txtChasis
        '
        Me.txtChasis.Location = New System.Drawing.Point(12, 106)
        Me.txtChasis.MaxLength = 10
        Me.txtChasis.Name = "txtChasis"
        Me.txtChasis.Size = New System.Drawing.Size(100, 20)
        Me.txtChasis.TabIndex = 5
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(177, 152)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(89, 37)
        Me.btnImp.TabIndex = 6
        Me.btnImp.Text = "Imprimir garantia"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cedula verde:"
        '
        'txtCV
        '
        Me.txtCV.Location = New System.Drawing.Point(166, 106)
        Me.txtCV.MaxLength = 8
        Me.txtCV.Name = "txtCV"
        Me.txtCV.Size = New System.Drawing.Size(100, 20)
        Me.txtCV.TabIndex = 8
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(12, 165)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 9
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'lstCP
        '
        Me.lstCP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstCP.Location = New System.Drawing.Point(303, 13)
        Me.lstCP.Name = "lstCP"
        Me.lstCP.Size = New System.Drawing.Size(257, 172)
        Me.lstCP.TabIndex = 10
        Me.lstCP.UseCompatibleStateImageBehavior = False
        Me.lstCP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Constancia CP"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 87
        '
        'frmIngresoAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 197)
        Me.Controls.Add(Me.lstCP)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.txtCV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.txtChasis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMat)
        Me.Controls.Add(Me.lblMat)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lblCons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmIngresoAutos"
        Me.Text = "Ingreso de autos 0km"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCons As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents lblMat As System.Windows.Forms.Label
    Friend WithEvents txtMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChasis As System.Windows.Forms.TextBox
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCV As System.Windows.Forms.TextBox
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents lstCP As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
