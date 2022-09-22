Public Class frmRecibo
    Private Sub frmRecibo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If frmCobroCuo.txtCont.Text <> "" Then
            lblRec.Text = "Recibi de " & frmChe.txtNom.Text
            lblSum.Text = "La suma de " & frmChe.txtMon.Text
            lblCon.Text = "Por concepto de pago de cuotas de " + vbLf + "credito prendario"

            lblEmi.Text = "Nombre emitente cheque: " & frmChe.txtNom.Text
            lblRut.Text = "N° Ruta: " & frmChe.txtNR.Text
            lblCue.Text = "N° Cuenta: " & frmChe.txtNC.Text
            lblBan.Text = "Nombre banco: " & frmChe.txtBan.Text

            sql = "Select date_format(curdate(), '%d/%m/%Y')"
            consulta(1)
            rs1.Read()
            lblFec.Text = rs1(0)

            sql = "Select max(NRecibo)+1 From Recibos"
            consulta(1)
            If rs1.Read = True Then
                lblNum.Text = "N°: " & rs1(0)
            End If
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        'Almacenar el recibo
        sql = "Insert into Recibos values('', '" & frmChe.txtNom.Text & "', curdate(), " & frmChe.lblAuxnc.Text & ")"
        consulta(1)

        sql = "Select max(NRecibo) From Recibos"
        consulta(3)
        rs3.Read()

        'Actualizar las cuotas como pagadas
        sql = "Select IdCuo " & _
              "From Cuotas " & _
              "Where debe!=1 " & _
              "And contrato=" & frmCobroCuo.txtCont.Text & _
             " Limit " & frmCobroCuo.nudCobro.Value
        consulta(1)

        While rs1.Read
            sql = "Update cuotas " & _
                  "Set Debe=1 " & _
                  "Where IdCuo=" & rs1(0)
            consulta(2)

            sql = "Insert into Recibos_Cuotas values(" & rs3(0) & "," & rs1(0) & ")"
            consulta(2)
        End While

        btnImp.Visible = False
        PrintForm1.Print()



        frmMenu.Show()
        frmChe.Close()
        frmCobroCuo.Close()
        Me.Close()

    End Sub
End Class