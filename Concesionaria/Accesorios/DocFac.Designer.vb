<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocFac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocFac))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAux2 = New System.Windows.Forms.Label()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.lblAuxFac = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNyA = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.lblcant7 = New System.Windows.Forms.Label()
        Me.lblcant6 = New System.Windows.Forms.Label()
        Me.lblcant5 = New System.Windows.Forms.Label()
        Me.lblcant4 = New System.Windows.Forms.Label()
        Me.lblcant3 = New System.Windows.Forms.Label()
        Me.lblcant2 = New System.Windows.Forms.Label()
        Me.lblcant = New System.Windows.Forms.Label()
        Me.lblauxcant = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblMontotal = New System.Windows.Forms.Label()
        Me.lblPre7 = New System.Windows.Forms.Label()
        Me.lblPre3 = New System.Windows.Forms.Label()
        Me.lblPre4 = New System.Windows.Forms.Label()
        Me.lblPre5 = New System.Windows.Forms.Label()
        Me.lblPre6 = New System.Windows.Forms.Label()
        Me.lblPre2 = New System.Windows.Forms.Label()
        Me.lblacc7 = New System.Windows.Forms.Label()
        Me.lblacc6 = New System.Windows.Forms.Label()
        Me.lblacc5 = New System.Windows.Forms.Label()
        Me.lblacc4 = New System.Windows.Forms.Label()
        Me.lblacc3 = New System.Windows.Forms.Label()
        Me.lblacc2 = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.lblPreAux = New System.Windows.Forms.Label()
        Me.lblacc = New System.Windows.Forms.Label()
        Me.lblAux3 = New System.Windows.Forms.Label()
        Me.lblFe = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNFac = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "LOGO"
        '
        'lblAux2
        '
        Me.lblAux2.AutoSize = True
        Me.lblAux2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux2.Location = New System.Drawing.Point(178, 117)
        Me.lblAux2.Name = "lblAux2"
        Me.lblAux2.Size = New System.Drawing.Size(37, 18)
        Me.lblAux2.TabIndex = 26
        Me.lblAux2.Text = "DNI:"
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux.Location = New System.Drawing.Point(14, 117)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(57, 18)
        Me.lblAux.TabIndex = 25
        Me.lblAux.Text = "Cliente:"
        '
        'lblAuxFac
        '
        Me.lblAuxFac.AutoSize = True
        Me.lblAuxFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxFac.Location = New System.Drawing.Point(177, 62)
        Me.lblAuxFac.Name = "lblAuxFac"
        Me.lblAuxFac.Size = New System.Drawing.Size(34, 24)
        Me.lblAuxFac.TabIndex = 24
        Me.lblAuxFac.Text = "N: "
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(178, 141)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(63, 18)
        Me.lblDNI.TabIndex = 23
        Me.lblDNI.Text = "-----------"
        '
        'lblNyA
        '
        Me.lblNyA.AutoSize = True
        Me.lblNyA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNyA.Location = New System.Drawing.Point(14, 141)
        Me.lblNyA.Name = "lblNyA"
        Me.lblNyA.Size = New System.Drawing.Size(123, 18)
        Me.lblNyA.TabIndex = 22
        Me.lblNyA.Text = "-----------------------"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(141, 26)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(160, 25)
        Me.lblFactura.TabIndex = 21
        Me.lblFactura.Text = "Factura tipo A"
        '
        'lblcant7
        '
        Me.lblcant7.AutoSize = True
        Me.lblcant7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant7.Location = New System.Drawing.Point(12, 358)
        Me.lblcant7.Name = "lblcant7"
        Me.lblcant7.Size = New System.Drawing.Size(0, 18)
        Me.lblcant7.TabIndex = 147
        '
        'lblcant6
        '
        Me.lblcant6.AutoSize = True
        Me.lblcant6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant6.Location = New System.Drawing.Point(12, 334)
        Me.lblcant6.Name = "lblcant6"
        Me.lblcant6.Size = New System.Drawing.Size(0, 18)
        Me.lblcant6.TabIndex = 146
        '
        'lblcant5
        '
        Me.lblcant5.AutoSize = True
        Me.lblcant5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant5.Location = New System.Drawing.Point(12, 308)
        Me.lblcant5.Name = "lblcant5"
        Me.lblcant5.Size = New System.Drawing.Size(0, 18)
        Me.lblcant5.TabIndex = 145
        '
        'lblcant4
        '
        Me.lblcant4.AutoSize = True
        Me.lblcant4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant4.Location = New System.Drawing.Point(12, 284)
        Me.lblcant4.Name = "lblcant4"
        Me.lblcant4.Size = New System.Drawing.Size(0, 18)
        Me.lblcant4.TabIndex = 144
        '
        'lblcant3
        '
        Me.lblcant3.AutoSize = True
        Me.lblcant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant3.Location = New System.Drawing.Point(12, 259)
        Me.lblcant3.Name = "lblcant3"
        Me.lblcant3.Size = New System.Drawing.Size(0, 18)
        Me.lblcant3.TabIndex = 143
        '
        'lblcant2
        '
        Me.lblcant2.AutoSize = True
        Me.lblcant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant2.Location = New System.Drawing.Point(12, 233)
        Me.lblcant2.Name = "lblcant2"
        Me.lblcant2.Size = New System.Drawing.Size(0, 18)
        Me.lblcant2.TabIndex = 142
        '
        'lblcant
        '
        Me.lblcant.AutoSize = True
        Me.lblcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant.Location = New System.Drawing.Point(12, 208)
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(0, 18)
        Me.lblcant.TabIndex = 141
        '
        'lblauxcant
        '
        Me.lblauxcant.AutoSize = True
        Me.lblauxcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblauxcant.Location = New System.Drawing.Point(12, 181)
        Me.lblauxcant.Name = "lblauxcant"
        Me.lblauxcant.Size = New System.Drawing.Size(70, 18)
        Me.lblauxcant.TabIndex = 140
        Me.lblauxcant.Text = "Cantidad:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(539, 181)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(87, 18)
        Me.lbltotal.TabIndex = 139
        Me.lbltotal.Text = "Monto total:"
        '
        'lblMontotal
        '
        Me.lblMontotal.AutoSize = True
        Me.lblMontotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontotal.Location = New System.Drawing.Point(539, 208)
        Me.lblMontotal.Name = "lblMontotal"
        Me.lblMontotal.Size = New System.Drawing.Size(0, 18)
        Me.lblMontotal.TabIndex = 138
        '
        'lblPre7
        '
        Me.lblPre7.AutoSize = True
        Me.lblPre7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre7.Location = New System.Drawing.Point(400, 358)
        Me.lblPre7.Name = "lblPre7"
        Me.lblPre7.Size = New System.Drawing.Size(0, 18)
        Me.lblPre7.TabIndex = 137
        '
        'lblPre3
        '
        Me.lblPre3.AutoSize = True
        Me.lblPre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre3.Location = New System.Drawing.Point(400, 259)
        Me.lblPre3.Name = "lblPre3"
        Me.lblPre3.Size = New System.Drawing.Size(0, 18)
        Me.lblPre3.TabIndex = 136
        '
        'lblPre4
        '
        Me.lblPre4.AutoSize = True
        Me.lblPre4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre4.Location = New System.Drawing.Point(400, 284)
        Me.lblPre4.Name = "lblPre4"
        Me.lblPre4.Size = New System.Drawing.Size(0, 18)
        Me.lblPre4.TabIndex = 135
        '
        'lblPre5
        '
        Me.lblPre5.AutoSize = True
        Me.lblPre5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre5.Location = New System.Drawing.Point(400, 308)
        Me.lblPre5.Name = "lblPre5"
        Me.lblPre5.Size = New System.Drawing.Size(0, 18)
        Me.lblPre5.TabIndex = 134
        '
        'lblPre6
        '
        Me.lblPre6.AutoSize = True
        Me.lblPre6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre6.Location = New System.Drawing.Point(400, 334)
        Me.lblPre6.Name = "lblPre6"
        Me.lblPre6.Size = New System.Drawing.Size(0, 18)
        Me.lblPre6.TabIndex = 133
        '
        'lblPre2
        '
        Me.lblPre2.AutoSize = True
        Me.lblPre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre2.Location = New System.Drawing.Point(400, 233)
        Me.lblPre2.Name = "lblPre2"
        Me.lblPre2.Size = New System.Drawing.Size(0, 18)
        Me.lblPre2.TabIndex = 132
        '
        'lblacc7
        '
        Me.lblacc7.AutoSize = True
        Me.lblacc7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc7.Location = New System.Drawing.Point(113, 358)
        Me.lblacc7.Name = "lblacc7"
        Me.lblacc7.Size = New System.Drawing.Size(0, 18)
        Me.lblacc7.TabIndex = 131
        '
        'lblacc6
        '
        Me.lblacc6.AutoSize = True
        Me.lblacc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc6.Location = New System.Drawing.Point(113, 334)
        Me.lblacc6.Name = "lblacc6"
        Me.lblacc6.Size = New System.Drawing.Size(0, 18)
        Me.lblacc6.TabIndex = 130
        '
        'lblacc5
        '
        Me.lblacc5.AutoSize = True
        Me.lblacc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc5.Location = New System.Drawing.Point(113, 308)
        Me.lblacc5.Name = "lblacc5"
        Me.lblacc5.Size = New System.Drawing.Size(0, 18)
        Me.lblacc5.TabIndex = 129
        '
        'lblacc4
        '
        Me.lblacc4.AutoSize = True
        Me.lblacc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc4.Location = New System.Drawing.Point(113, 284)
        Me.lblacc4.Name = "lblacc4"
        Me.lblacc4.Size = New System.Drawing.Size(0, 18)
        Me.lblacc4.TabIndex = 128
        '
        'lblacc3
        '
        Me.lblacc3.AutoSize = True
        Me.lblacc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc3.Location = New System.Drawing.Point(113, 259)
        Me.lblacc3.Name = "lblacc3"
        Me.lblacc3.Size = New System.Drawing.Size(0, 18)
        Me.lblacc3.TabIndex = 127
        '
        'lblacc2
        '
        Me.lblacc2.AutoSize = True
        Me.lblacc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc2.Location = New System.Drawing.Point(113, 233)
        Me.lblacc2.Name = "lblacc2"
        Me.lblacc2.Size = New System.Drawing.Size(0, 18)
        Me.lblacc2.TabIndex = 126
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre.Location = New System.Drawing.Point(400, 208)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(0, 18)
        Me.lblPre.TabIndex = 125
        '
        'lblPreAux
        '
        Me.lblPreAux.AutoSize = True
        Me.lblPreAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreAux.Location = New System.Drawing.Point(411, 181)
        Me.lblPreAux.Name = "lblPreAux"
        Me.lblPreAux.Size = New System.Drawing.Size(107, 18)
        Me.lblPreAux.TabIndex = 124
        Me.lblPreAux.Text = "Precio unitario:"
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc.Location = New System.Drawing.Point(113, 208)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(0, 18)
        Me.lblacc.TabIndex = 123
        '
        'lblAux3
        '
        Me.lblAux3.AutoSize = True
        Me.lblAux3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux3.Location = New System.Drawing.Point(113, 181)
        Me.lblAux3.Name = "lblAux3"
        Me.lblAux3.Size = New System.Drawing.Size(87, 18)
        Me.lblAux3.TabIndex = 122
        Me.lblAux3.Text = "Accesorios:"
        '
        'lblFe
        '
        Me.lblFe.AutoSize = True
        Me.lblFe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFe.Location = New System.Drawing.Point(399, 27)
        Me.lblFe.Name = "lblFe"
        Me.lblFe.Size = New System.Drawing.Size(74, 24)
        Me.lblFe.TabIndex = 148
        Me.lblFe.Text = "Fecha: "
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(560, 390)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 150
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(467, 33)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(63, 18)
        Me.lblFecha.TabIndex = 151
        Me.lblFecha.Text = "-----------"
        '
        'lblNFac
        '
        Me.lblNFac.AutoSize = True
        Me.lblNFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNFac.Location = New System.Drawing.Point(217, 68)
        Me.lblNFac.Name = "lblNFac"
        Me.lblNFac.Size = New System.Drawing.Size(63, 18)
        Me.lblNFac.TabIndex = 152
        Me.lblNFac.Text = "-----------"
        '
        'frmDocFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 425)
        Me.Controls.Add(Me.lblNFac)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblFe)
        Me.Controls.Add(Me.lblcant7)
        Me.Controls.Add(Me.lblcant6)
        Me.Controls.Add(Me.lblcant5)
        Me.Controls.Add(Me.lblcant4)
        Me.Controls.Add(Me.lblcant3)
        Me.Controls.Add(Me.lblcant2)
        Me.Controls.Add(Me.lblcant)
        Me.Controls.Add(Me.lblauxcant)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblMontotal)
        Me.Controls.Add(Me.lblPre7)
        Me.Controls.Add(Me.lblPre3)
        Me.Controls.Add(Me.lblPre4)
        Me.Controls.Add(Me.lblPre5)
        Me.Controls.Add(Me.lblPre6)
        Me.Controls.Add(Me.lblPre2)
        Me.Controls.Add(Me.lblacc7)
        Me.Controls.Add(Me.lblacc6)
        Me.Controls.Add(Me.lblacc5)
        Me.Controls.Add(Me.lblacc4)
        Me.Controls.Add(Me.lblacc3)
        Me.Controls.Add(Me.lblacc2)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.lblPreAux)
        Me.Controls.Add(Me.lblacc)
        Me.Controls.Add(Me.lblAux3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAux2)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.lblAuxFac)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNyA)
        Me.Controls.Add(Me.lblFactura)
        Me.Name = "frmDocFac"
        Me.Text = "DocFac"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAux2 As System.Windows.Forms.Label
    Friend WithEvents lblAux As System.Windows.Forms.Label
    Friend WithEvents lblAuxFac As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblNyA As System.Windows.Forms.Label
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents lblcant7 As System.Windows.Forms.Label
    Friend WithEvents lblcant6 As System.Windows.Forms.Label
    Friend WithEvents lblcant5 As System.Windows.Forms.Label
    Friend WithEvents lblcant4 As System.Windows.Forms.Label
    Friend WithEvents lblcant3 As System.Windows.Forms.Label
    Friend WithEvents lblcant2 As System.Windows.Forms.Label
    Friend WithEvents lblcant As System.Windows.Forms.Label
    Friend WithEvents lblauxcant As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblMontotal As System.Windows.Forms.Label
    Friend WithEvents lblPre7 As System.Windows.Forms.Label
    Friend WithEvents lblPre3 As System.Windows.Forms.Label
    Friend WithEvents lblPre4 As System.Windows.Forms.Label
    Friend WithEvents lblPre5 As System.Windows.Forms.Label
    Friend WithEvents lblPre6 As System.Windows.Forms.Label
    Friend WithEvents lblPre2 As System.Windows.Forms.Label
    Friend WithEvents lblacc7 As System.Windows.Forms.Label
    Friend WithEvents lblacc6 As System.Windows.Forms.Label
    Friend WithEvents lblacc5 As System.Windows.Forms.Label
    Friend WithEvents lblacc4 As System.Windows.Forms.Label
    Friend WithEvents lblacc3 As System.Windows.Forms.Label
    Friend WithEvents lblacc2 As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents lblPreAux As System.Windows.Forms.Label
    Friend WithEvents lblacc As System.Windows.Forms.Label
    Friend WithEvents lblAux3 As System.Windows.Forms.Label
    Friend WithEvents lblFe As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblNFac As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
End Class
