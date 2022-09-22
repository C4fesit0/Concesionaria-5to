<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGarantia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGarantia))
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblCue1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCue2 = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(100, 9)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(94, 25)
        Me.lblTit.TabIndex = 0
        Me.lblTit.Text = "Garantia"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(204, 14)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(28, 18)
        Me.lblN.TabIndex = 1
        Me.lblN.Text = "Nº:"
        '
        'lblCue1
        '
        Me.lblCue1.AutoSize = True
        Me.lblCue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCue1.Location = New System.Drawing.Point(12, 90)
        Me.lblCue1.Name = "lblCue1"
        Me.lblCue1.Size = New System.Drawing.Size(408, 54)
        Me.lblCue1.TabIndex = 2
        Me.lblCue1.Text = "Marca:..............     Modelo:...................  Matricula:.................." & _
            "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DNI receptor: ...............  Fecha emision: ..../..../..........." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fecha ve" & _
            "ncimiento: ..../..../..........."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Concesionaria.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblCue2
        '
        Me.lblCue2.AutoSize = True
        Me.lblCue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCue2.Location = New System.Drawing.Point(15, 173)
        Me.lblCue2.Name = "lblCue2"
        Me.lblCue2.Size = New System.Drawing.Size(422, 306)
        Me.lblCue2.TabIndex = 4
        Me.lblCue2.Text = resources.GetString("lblCue2.Text")
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(350, 493)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 5
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmGarantia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(444, 528)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.lblCue2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCue1)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblTit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGarantia"
        Me.Text = "Garantia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblN As System.Windows.Forms.Label
    Friend WithEvents lblCue1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCue2 As System.Windows.Forms.Label
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
