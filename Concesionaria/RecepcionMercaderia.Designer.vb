<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionMercaderia
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
        Me.txtOrdenDeCompra = New System.Windows.Forms.TextBox()
        Me.lblOrdenDeCompra = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn2OrdenDeComra = New System.Windows.Forms.Button()
        Me.btn3OrdenDeCompra = New System.Windows.Forms.Button()
        Me.lst = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(132, 43)
        Me.txtOrdenDeCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrdenDeCompra.MaxLength = 10
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(68, 20)
        Me.txtOrdenDeCompra.TabIndex = 0
        '
        'lblOrdenDeCompra
        '
        Me.lblOrdenDeCompra.AutoSize = True
        Me.lblOrdenDeCompra.Location = New System.Drawing.Point(24, 43)
        Me.lblOrdenDeCompra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrdenDeCompra.Name = "lblOrdenDeCompra"
        Me.lblOrdenDeCompra.Size = New System.Drawing.Size(105, 13)
        Me.lblOrdenDeCompra.TabIndex = 1
        Me.lblOrdenDeCompra.Text = "Orden de Compra Nº"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(215, 38)
        Me.btn1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(67, 27)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Buscar"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(129, 78)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 3
        '
        'btn2OrdenDeComra
        '
        Me.btn2OrdenDeComra.Location = New System.Drawing.Point(12, 296)
        Me.btn2OrdenDeComra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2OrdenDeComra.Name = "btn2OrdenDeComra"
        Me.btn2OrdenDeComra.Size = New System.Drawing.Size(112, 20)
        Me.btn2OrdenDeComra.TabIndex = 6
        Me.btn2OrdenDeComra.Text = "Volver"
        Me.btn2OrdenDeComra.UseVisualStyleBackColor = True
        '
        'btn3OrdenDeCompra
        '
        Me.btn3OrdenDeCompra.Enabled = False
        Me.btn3OrdenDeCompra.Location = New System.Drawing.Point(217, 296)
        Me.btn3OrdenDeCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3OrdenDeCompra.Name = "btn3OrdenDeCompra"
        Me.btn3OrdenDeCompra.Size = New System.Drawing.Size(111, 20)
        Me.btn3OrdenDeCompra.TabIndex = 7
        Me.btn3OrdenDeCompra.Text = "Añadir al inventario"
        Me.btn3OrdenDeCompra.UseVisualStyleBackColor = True
        '
        'lst
        '
        Me.lst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lst.Location = New System.Drawing.Point(12, 70)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(316, 209)
        Me.lst.TabIndex = 8
        Me.lst.UseCompatibleStateImageBehavior = False
        Me.lst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Productos"
        Me.ColumnHeader1.Width = 253
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cantidad"
        Me.ColumnHeader2.Width = 59
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.btn3OrdenDeCompra)
        Me.Controls.Add(Me.btn2OrdenDeComra)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblOrdenDeCompra)
        Me.Controls.Add(Me.txtOrdenDeCompra)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOrdenDeCompra As System.Windows.Forms.TextBox
    Friend WithEvents lblOrdenDeCompra As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btn2OrdenDeComra As System.Windows.Forms.Button
    Friend WithEvents btn3OrdenDeCompra As System.Windows.Forms.Button
    Friend WithEvents lst As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader

End Class
