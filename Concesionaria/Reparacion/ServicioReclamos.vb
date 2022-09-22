Imports System.Data.Odbc
Public Class ServicioReclamos


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        

        txt1DocumentoSR.Enabled = True
        txt2MatriculaSR.Enabled = False
        btn1Verificar.Enabled = False
        txt1DocumentoSR.Text = ""
        txt2MatriculaSR.Text = ""
    End Sub

    Private Sub txt1DocumentoSR_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt1DocumentoSR.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt1DocumentoSR_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt1DocumentoSR.TextChanged
        If String.IsNullOrEmpty(txt1DocumentoSR.Text) Then
            btn1Verificar.Enabled = False
        Else
            btn1Verificar.Enabled = True
        End If
    End Sub

    Private Sub btn1Verificar_Click(sender As System.Object, e As System.EventArgs) Handles btn1Verificar.Click

        sql = "select count(*) from clientes where DNI='" & txt1DocumentoSR.Text & "'"
        consulta(1)
        rs1.Read()

        If rs1(0) = 1 Then
            txt1DocumentoSR.Enabled = False
            btn1Verificar.Enabled = False
            txt2MatriculaSR.Enabled = True
            lbl2.Enabled = True
            btn3VerificarAuto.Enabled = True
        ElseIf rs1(0) = 0 Then
            MsgBox("El cliente no existe")
            txt1DocumentoSR.Text = ""
            btn1Verificar.Enabled = False
        End If

    End Sub

    Private Sub btn3VerificarAuto_Click(sender As System.Object, e As System.EventArgs) Handles btn3VerificarAuto.Click

        sql = "select count(*) from constancias_cp cp ,clientes c ,presupuestos p,ventas_autos va where matricula='" & txt2MatriculaSR.Text & "' and va.constancia=cp.idcons and cp.presupuesto=p.npres and p.idcliente=c.idcliente and c.DNI='" & txt1DocumentoSR.Text & "'"
        consulta(1)
        rs1.Read()
        If rs1(0) = 1 Then
            txt1DocumentoSR.Enabled = False
            txt2MatriculaSR.Enabled = False
            MsgBox("El cliente se cargo a reparaciones")


            frmConstanciaReparacion.Show()

        ElseIf rs1(0) = 0 Then
            MsgBox("El auto no pertenece a este cliente")
            txt1DocumentoSR.Text = ""
            btn1Verificar.Enabled = False
        End If
    End Sub

    Private Sub btn2VolverSR_Click(sender As System.Object, e As System.EventArgs) Handles btn2VolverSR.Click
        Me.Close()
        frmMenu.Show()
    End Sub



End Class