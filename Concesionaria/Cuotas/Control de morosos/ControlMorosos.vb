Public Class frmControlMorosos

    Private Sub frmControlMorosos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer

        sql = "Call Deuda()"
        consulta(1)

        sql = "Select Nombre, Apellido, CU.Contrato, count(CU.Contrato), CU.contrato in (Select contrato " & _
                                                                                        "From (Select contrato, TIMESTAMPDIFF(MONTH, FechaM, curdate())>3 aux " & _
                                                                                              "From cuotas) B " & _
                                                                                        "Where aux=1 " & _
                                                                                        "Group by contrato) MesesT " & _
              "From Cuotas CU, Contratos_cre CC, Clientes CL " & _
              "Where CU.debe=2 " & _
              "And CU.Contrato=CC.IdCont " & _
              "And CC.Cliente=CL.IdCliente " & _
              "And CU.IdCuo not in (Select Cuota from notif_deuda)" & _
              "Group by Contrato"
        consulta(1)

        While rs1.Read = True

            lstMor.Items.Add(rs1(0) & " " & rs1(1))
            lstMor.Items(i).SubItems.Add(rs1(2))
            lstMor.Items(i).SubItems.Add(rs1(3))
            If rs1(4) > 0 Then
                lstMor.Items(i).SubItems.Add("Si")
            Else
                lstMor.Items(i).SubItems.Add("No")
            End If

            i += 1
        End While


        If i = 0 Then
            btnEmi.Enabled = False
        End If

        lblAux.Text = i
    End Sub

    Private Sub btnEmi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmi.Click
        Me.Hide()
        frmNotiDeu.Show()
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmCuotas.Show()
        Me.Close()
    End Sub
End Class