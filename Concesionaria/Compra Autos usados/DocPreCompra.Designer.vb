<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocPreCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocPreCompra))
        Me.lblNpresu = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblPreAux = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblColorAux = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKm = New System.Windows.Forms.Label()
        Me.lblKmAux = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblAux3 = New System.Windows.Forms.Label()
        Me.lblAux2 = New System.Windows.Forms.Label()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.lblNPres = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNyA = New System.Windows.Forms.Label()
        Me.lblPyT = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNpresu
        '
        Me.lblNpresu.AutoSize = True
        Me.lblNpresu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpresu.Location = New System.Drawing.Point(440, 60)
        Me.lblNpresu.Name = "lblNpresu"
        Me.lblNpresu.Size = New System.Drawing.Size(52, 24)
        Me.lblNpresu.TabIndex = 60
        Me.lblNpresu.Text = "-------"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(327, 206)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(78, 18)
        Me.lblPrecio.TabIndex = 58
        Me.lblPrecio.Text = "--------------"
        '
        'lblPreAux
        '
        Me.lblPreAux.AutoSize = True
        Me.lblPreAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreAux.Location = New System.Drawing.Point(327, 179)
        Me.lblPreAux.Name = "lblPreAux"
        Me.lblPreAux.Size = New System.Drawing.Size(55, 18)
        Me.lblPreAux.TabIndex = 57
        Me.lblPreAux.Text = "Precio:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(178, 206)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(68, 18)
        Me.lblColor.TabIndex = 56
        Me.lblColor.Text = "------------"
        '
        'lblColorAux
        '
        Me.lblColorAux.AutoSize = True
        Me.lblColorAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorAux.Location = New System.Drawing.Point(178, 179)
        Me.lblColorAux.Name = "lblColorAux"
        Me.lblColorAux.Size = New System.Drawing.Size(49, 18)
        Me.lblColorAux.TabIndex = 55
        Me.lblColorAux.Text = "Color:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "LOGO"
        '
        'lblKm
        '
        Me.lblKm.AutoSize = True
        Me.lblKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKm.Location = New System.Drawing.Point(14, 276)
        Me.lblKm.Name = "lblKm"
        Me.lblKm.Size = New System.Drawing.Size(58, 18)
        Me.lblKm.TabIndex = 53
        Me.lblKm.Text = "----------"
        '
        'lblKmAux
        '
        Me.lblKmAux.AutoSize = True
        Me.lblKmAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmAux.Location = New System.Drawing.Point(14, 244)
        Me.lblKmAux.Name = "lblKmAux"
        Me.lblKmAux.Size = New System.Drawing.Size(115, 18)
        Me.lblKmAux.TabIndex = 52
        Me.lblKmAux.Text = "Cantidad de km:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(14, 206)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(158, 18)
        Me.lblModelo.TabIndex = 51
        Me.lblModelo.Text = "------------------------------"
        '
        'lblAux3
        '
        Me.lblAux3.AutoSize = True
        Me.lblAux3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux3.Location = New System.Drawing.Point(14, 179)
        Me.lblAux3.Name = "lblAux3"
        Me.lblAux3.Size = New System.Drawing.Size(42, 18)
        Me.lblAux3.TabIndex = 50
        Me.lblAux3.Text = "Auto:"
        '
        'lblAux2
        '
        Me.lblAux2.AutoSize = True
        Me.lblAux2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux2.Location = New System.Drawing.Point(178, 117)
        Me.lblAux2.Name = "lblAux2"
        Me.lblAux2.Size = New System.Drawing.Size(37, 18)
        Me.lblAux2.TabIndex = 49
        Me.lblAux2.Text = "DNI:"
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux.Location = New System.Drawing.Point(14, 117)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(57, 18)
        Me.lblAux.TabIndex = 48
        Me.lblAux.Text = "Cliente:"
        '
        'lblNPres
        '
        Me.lblNPres.AutoSize = True
        Me.lblNPres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPres.Location = New System.Drawing.Point(405, 60)
        Me.lblNPres.Name = "lblNPres"
        Me.lblNPres.Size = New System.Drawing.Size(29, 24)
        Me.lblNPres.TabIndex = 47
        Me.lblNPres.Text = "N:"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(178, 141)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(98, 18)
        Me.lblDNI.TabIndex = 46
        Me.lblDNI.Text = "------------------"
        '
        'lblNyA
        '
        Me.lblNyA.AutoSize = True
        Me.lblNyA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNyA.Location = New System.Drawing.Point(14, 141)
        Me.lblNyA.Name = "lblNyA"
        Me.lblNyA.Size = New System.Drawing.Size(123, 18)
        Me.lblNyA.TabIndex = 45
        Me.lblNyA.Text = "-----------------------"
        '
        'lblPyT
        '
        Me.lblPyT.AutoSize = True
        Me.lblPyT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPyT.Location = New System.Drawing.Point(141, 26)
        Me.lblPyT.Name = "lblPyT"
        Me.lblPyT.Size = New System.Drawing.Size(418, 25)
        Me.lblPyT.TabIndex = 44
        Me.lblPyT.Text = "Presupuesto de compra de auto usado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(476, 279)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 61
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmDocPreCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 314)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblNpresu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblPreAux)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblColorAux)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKm)
        Me.Controls.Add(Me.lblKmAux)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblAux3)
        Me.Controls.Add(Me.lblAux2)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.lblNPres)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNyA)
        Me.Controls.Add(Me.lblPyT)
        Me.Name = "frmDocPreCompra"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNpresu As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblPreAux As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblColorAux As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKm As System.Windows.Forms.Label
    Friend WithEvents lblKmAux As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblAux3 As System.Windows.Forms.Label
    Friend WithEvents lblAux2 As System.Windows.Forms.Label
    Friend WithEvents lblAux As System.Windows.Forms.Label
    Friend WithEvents lblNPres As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblNyA As System.Windows.Forms.Label
    Friend WithEvents lblPyT As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
