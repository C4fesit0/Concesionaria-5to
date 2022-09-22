<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreCompra
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
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVeri = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.btnpresu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnbasti = New System.Windows.Forms.TextBox()
        Me.txtkmu = New System.Windows.Forms.TextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 23)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "DNI cliente"
        '
        'btnVeri
        '
        Me.btnVeri.Location = New System.Drawing.Point(143, 23)
        Me.btnVeri.Name = "btnVeri"
        Me.btnVeri.Size = New System.Drawing.Size(75, 23)
        Me.btnVeri.TabIndex = 37
        Me.btnVeri.Text = "Verificar"
        Me.btnVeri.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Precio "
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(12, 269)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 35
        '
        'btnpresu
        '
        Me.btnpresu.Enabled = False
        Me.btnpresu.Location = New System.Drawing.Point(166, 237)
        Me.btnpresu.Name = "btnpresu"
        Me.btnpresu.Size = New System.Drawing.Size(75, 52)
        Me.btnpresu.TabIndex = 34
        Me.btnpresu.Text = "Generar presupuesto"
        Me.btnpresu.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Kilometraje recorrido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Color"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(138, 64)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(80, 13)
        Me.lbl2.TabIndex = 31
        Me.lbl2.Text = "Año del modelo"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(9, 111)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(37, 13)
        Me.lbl3.TabIndex = 30
        Me.lbl3.Text = "Marca"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(9, 64)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(42, 13)
        Me.lbl1.TabIndex = 29
        Me.lbl1.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Matricula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Numero de bastidor"
        '
        'txtnbasti
        '
        Me.txtnbasti.Enabled = False
        Me.txtnbasti.Location = New System.Drawing.Point(12, 170)
        Me.txtnbasti.MaxLength = 10
        Me.txtnbasti.Name = "txtnbasti"
        Me.txtnbasti.Size = New System.Drawing.Size(100, 20)
        Me.txtnbasti.TabIndex = 26
        '
        'txtkmu
        '
        Me.txtkmu.Enabled = False
        Me.txtkmu.Location = New System.Drawing.Point(12, 221)
        Me.txtkmu.Name = "txtkmu"
        Me.txtkmu.Size = New System.Drawing.Size(100, 20)
        Me.txtkmu.TabIndex = 25
        '
        'txtcolor
        '
        Me.txtcolor.Enabled = False
        Me.txtcolor.Location = New System.Drawing.Point(141, 170)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(100, 20)
        Me.txtcolor.TabIndex = 24
        '
        'txtaño
        '
        Me.txtaño.Enabled = False
        Me.txtaño.Location = New System.Drawing.Point(141, 82)
        Me.txtaño.MaxLength = 4
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(100, 20)
        Me.txtaño.TabIndex = 23
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Location = New System.Drawing.Point(12, 127)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.txtmarca.TabIndex = 22
        '
        'txtmatricula
        '
        Me.txtmatricula.Enabled = False
        Me.txtmatricula.Location = New System.Drawing.Point(141, 127)
        Me.txtmatricula.MaxLength = 7
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtmatricula.TabIndex = 21
        '
        'txtmodelo
        '
        Me.txtmodelo.Enabled = False
        Me.txtmodelo.Location = New System.Drawing.Point(12, 82)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(100, 20)
        Me.txtmodelo.TabIndex = 20
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 304)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 40
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmPreCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 339)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVeri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.btnpresu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnbasti)
        Me.Controls.Add(Me.txtkmu)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtmatricula)
        Me.Controls.Add(Me.txtmodelo)
        Me.Name = "frmPreCompra"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnVeri As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents btnpresu As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnbasti As System.Windows.Forms.TextBox
    Friend WithEvents txtkmu As System.Windows.Forms.TextBox
    Friend WithEvents txtcolor As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents txtmatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
