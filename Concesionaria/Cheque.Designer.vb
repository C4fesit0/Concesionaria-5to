﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChe
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtMon = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblNR = New System.Windows.Forms.Label()
        Me.txtNR = New System.Windows.Forms.TextBox()
        Me.txtNC = New System.Windows.Forms.TextBox()
        Me.lblNC = New System.Windows.Forms.Label()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.btnEmi = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtBan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAuxnc = New System.Windows.Forms.Label()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(13, 36)
        Me.txtNom.MaxLength = 25
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 0
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(13, 12)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(107, 13)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nombre del emitente:"
        '
        'txtMon
        '
        Me.txtMon.Location = New System.Drawing.Point(267, 104)
        Me.txtMon.Name = "txtMon"
        Me.txtMon.Size = New System.Drawing.Size(100, 20)
        Me.txtMon.TabIndex = 2
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(267, 80)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 3
        Me.lblMonto.Text = "Monto:"
        '
        'lblNR
        '
        Me.lblNR.AutoSize = True
        Me.lblNR.Location = New System.Drawing.Point(13, 81)
        Me.lblNR.Name = "lblNR"
        Me.lblNR.Size = New System.Drawing.Size(48, 13)
        Me.lblNR.TabIndex = 4
        Me.lblNR.Text = "N° Ruta:"
        '
        'txtNR
        '
        Me.txtNR.Location = New System.Drawing.Point(13, 104)
        Me.txtNR.MaxLength = 9
        Me.txtNR.Name = "txtNR"
        Me.txtNR.Size = New System.Drawing.Size(100, 20)
        Me.txtNR.TabIndex = 5
        '
        'txtNC
        '
        Me.txtNC.Location = New System.Drawing.Point(137, 104)
        Me.txtNC.MaxLength = 9
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Size = New System.Drawing.Size(100, 20)
        Me.txtNC.TabIndex = 6
        '
        'lblNC
        '
        Me.lblNC.AutoSize = True
        Me.lblNC.Location = New System.Drawing.Point(138, 81)
        Me.lblNC.Name = "lblNC"
        Me.lblNC.Size = New System.Drawing.Size(59, 13)
        Me.lblNC.TabIndex = 7
        Me.lblNC.Text = "N° Cuenta:"
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(500, 52)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(83, 25)
        Me.btnVol.TabIndex = 8
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'btnEmi
        '
        Me.btnEmi.Location = New System.Drawing.Point(500, 6)
        Me.btnEmi.Name = "btnEmi"
        Me.btnEmi.Size = New System.Drawing.Size(83, 25)
        Me.btnEmi.TabIndex = 9
        Me.btnEmi.Text = "Emitir"
        Me.btnEmi.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(270, 33)
        Me.dtpFecha.MaxDate = New Date(2019, 11, 17, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 10
        Me.dtpFecha.Value = New Date(2019, 11, 17, 0, 0, 0, 0)
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(270, 8)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(93, 13)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "Fecha de emision:"
        '
        'txtBan
        '
        Me.txtBan.Location = New System.Drawing.Point(402, 104)
        Me.txtBan.Name = "txtBan"
        Me.txtBan.Size = New System.Drawing.Size(100, 20)
        Me.txtBan.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre del banco"
        '
        'lblAuxnc
        '
        Me.lblAuxnc.AutoSize = True
        Me.lblAuxnc.Location = New System.Drawing.Point(327, 137)
        Me.lblAuxnc.Name = "lblAuxnc"
        Me.lblAuxnc.Size = New System.Drawing.Size(0, 13)
        Me.lblAuxnc.TabIndex = 14
        Me.lblAuxnc.Visible = False
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.Location = New System.Drawing.Point(134, 12)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(107, 13)
        Me.lblApe.TabIndex = 15
        Me.lblApe.Text = "Apellido del emitente:"
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(137, 35)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 16
        '
        'frmChe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 140)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.lblApe)
        Me.Controls.Add(Me.lblAuxnc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBan)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnEmi)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.lblNC)
        Me.Controls.Add(Me.txtNC)
        Me.Controls.Add(Me.txtNR)
        Me.Controls.Add(Me.lblNR)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.txtMon)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmChe"
        Me.Text = "Cheque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtMon As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblNR As System.Windows.Forms.Label
    Friend WithEvents txtNR As System.Windows.Forms.TextBox
    Friend WithEvents txtNC As System.Windows.Forms.TextBox
    Friend WithEvents lblNC As System.Windows.Forms.Label
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents btnEmi As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtBan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAuxnc As System.Windows.Forms.Label
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
End Class
