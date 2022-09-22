Public Class frmGarantia
    Private Sub frmGarantia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "Select max(Ngar) From Garantia"
        consulta(1)

        If rs1.Read Then
            lblN.Text = "N°: " & rs1(0)
        End If

        sql = "Select Marca, Modelo " & _
              "From Autos A, Constancia_Auto CA " & _
              "Where CA.Auto=A.IdAuto " & _
              "And CA.Constancia= " & frmIngresoAutos.txtCP.Text
        consulta(1)

        sql = "Select DNI " & _
              "From Clientes " & _
              "Where IdCliente=(Select IdCliente " & _
                               "From Presupuestos " & _
                               "Where NPres=(Select Presupuesto " & _
                                            "From Constancias_cp " & _
                                            "Where IdCons=" & frmIngresoAutos.txtCP.Text & "))"
        consulta(2)

        sql = "Select curdate(), DATE_ADD(curdate(), INTERVAL 2 YEAR)"
        consulta(3)

        If rs1.Read And rs2.Read And rs3.Read Then
            lblCue1.Text = "Marca:" & rs1(0) & "     Modelo:" & rs1(1) & "    Matricula:" & frmIngresoAutos.txtMat.Text & "" + vbLf + "DNI receptor: " & rs2(0) & "    Fecha emision: " & rs3(0) & "" + vbLf + "Fecha vencimiento: " & rs3(1)
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        sql = "Insert into Garantia values('', " & frmIngresoAutos.txtCP.Text & ", curdate(), DATE_ADD(curdate(), INTERVAL 2 YEAR))"
        consulta(1)

        btnImp.Visible = False
        PrintForm1.Print()

        frmIngresoAutos.Close()
        frmMenu.Show()
        Me.Close()
    End Sub
End Class