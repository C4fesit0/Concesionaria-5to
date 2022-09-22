<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblRec = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.lblFec = New System.Windows.Forms.Label()
        Me.lblEmi = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblCue = New System.Windows.Forms.Label()
        Me.lblBan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(119, 12)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(35, 24)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "N°:"
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(117, 59)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(99, 31)
        Me.lblTit.TabIndex = 1
        Me.lblTit.Text = "Recibo"
        '
        'lblRec
        '
        Me.lblRec.AutoSize = True
        Me.lblRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec.Location = New System.Drawing.Point(15, 105)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(249, 18)
        Me.lblRec.TabIndex = 2
        Me.lblRec.Text = "Recibi de ............................................"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Concesionaria.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(15, 137)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(217, 18)
        Me.lblSum.TabIndex = 4
        Me.lblSum.Text = "La suma de ................................"
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.Location = New System.Drawing.Point(15, 171)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(334, 18)
        Me.lblCon.TabIndex = 5
        Me.lblCon.Text = "Por concepto de ....................................................."
        '
        'lblFec
        '
        Me.lblFec.AutoSize = True
        Me.lblFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblFec.Location = New System.Drawing.Point(253, 9)
        Me.lblFec.Name = "lblFec"
        Me.lblFec.Size = New System.Drawing.Size(60, 24)
        Me.lblFec.TabIndex = 6
        Me.lblFec.Text = "../../...."
        '
        'lblEmi
        '
        Me.lblEmi.AutoSize = True
        Me.lblEmi.Location = New System.Drawing.Point(12, 220)
        Me.lblEmi.Name = "lblEmi"
        Me.lblEmi.Size = New System.Drawing.Size(243, 13)
        Me.lblEmi.TabIndex = 7
        Me.lblEmi.Text = "Nombre emitente cheque: ....................................."
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(12, 244)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(138, 13)
        Me.lblRut.TabIndex = 8
        Me.lblRut.Text = "N° Ruta: ............................."
        '
        'lblCue
        '
        Me.lblCue.AutoSize = True
        Me.lblCue.Location = New System.Drawing.Point(177, 244)
        Me.lblCue.Name = "lblCue"
        Me.lblCue.Size = New System.Drawing.Size(172, 13)
        Me.lblCue.TabIndex = 9
        Me.lblCue.Text = "N° cuenta: ....................................."
        '
        'lblBan
        '
        Me.lblBan.AutoSize = True
        Me.lblBan.Location = New System.Drawing.Point(12, 269)
        Me.lblBan.Name = "lblBan"
        Me.lblBan.Size = New System.Drawing.Size(161, 13)
        Me.lblBan.TabIndex = 10
        Me.lblBan.Text = "Nombre banco: .........................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(18, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Firma y dni emitente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(197, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Firma y dni receptor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "-------------------------------------------------"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(195, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "-------------------------------------------------"
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(274, 374)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 15
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
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 403)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBan)
        Me.Controls.Add(Me.lblCue)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.lblEmi)
        Me.Controls.Add(Me.lblFec)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRec)
        Me.Controls.Add(Me.lblTit)
        Me.Controls.Add(Me.lblNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRecibo"
        Me.Text = "Recibo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblRec As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblCon As System.Windows.Forms.Label
    Friend WithEvents lblFec As System.Windows.Forms.Label
    Friend WithEvents lblEmi As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents lblCue As System.Windows.Forms.Label
    Friend WithEvents lblBan As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
