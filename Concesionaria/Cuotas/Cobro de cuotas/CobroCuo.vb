Public Class frmCobroCuo


    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtCont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCont.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim cantP As Integer
        Dim cantD As Integer
        Dim i As Integer
        Dim aux As Integer

        If Len(txtDNI.Text) = 8 And txtCont.Text <> "" And txtCP.Text <> "" Then
            sql = "Select count(*) " & _
                  "From Clientes " & _
                  "Where DNI=" & txtDNI.Text
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    sql = "Select count(*) " & _
                          "From Constancias_cp " & _
                          "Where Presupuesto IN (Select NPres " & _
                                               "From Presupuestos " & _
                                               "Where IdCliente=(Select IdCliente " & _
                                                                "From Clientes " & _
                                                                "Where DNI=" & txtDNI.Text & ")) " & _
                          "And IdCons=" & txtCP.Text
                    consulta(1)

                    If rs1.Read = True Then
                        If rs1(0) = 1 Then
                            sql = "Select count(*) " & _
                                  "From Contratos_cre " & _
                                  "Where IdCont=" & txtCont.Text & " " & _
                                  "And Cliente = (Select IdCliente " & _
                                                 "From Clientes " & _
                                                 "Where DNI=" & txtDNI.Text & ") " & _
                                  "And IdCont=" & txtCont.Text
                            consulta(1)

                            If rs1.Read = True Then
                                If rs1(0) = 1 Then
                                    lstCuo.Enabled = True
                                    lblCantD.Enabled = True
                                    lblCantP.Enabled = True
                                    Label2.Enabled = True
                                    Label3.Enabled = True
                                    Label4.Enabled = True
                                    nudCobro.Enabled = True
                                    btnRec.Enabled = True
                                    lblM.Enabled = True
                                    btnVer.Enabled = False

                                    'Cargar la list view de referencia



                                    sql = "Select IdCuo, FechaM, Debe, Monto " & _
                                          "From Cuotas " & _
                                          "Where Contrato=" & txtCont.Text
                                    consulta(1)

                                    While rs1.Read = True
                                        If i = 1 Then
                                            aux = rs1(3)
                                        End If

                                        lstCuo.Items.Add(i + 1)
                                        lstCuo.Items(i).SubItems.Add(rs1(1))
                                        Select Case rs1(2)
                                            Case 0
                                                lstCuo.Items(i).SubItems.Add("No pago")
                                                cantP = cantP + 1
                                            Case 1
                                                lstCuo.Items(i).SubItems.Add("Pago")
                                            Case 2
                                                lstCuo.Items(i).SubItems.Add("Debe")
                                                cantP = cantP + 1
                                                cantD = cantD + 1
                                        End Select

                                        i = i + 1
                                    End While


                                    'El mecanismo de cobro de cuotas

                                    sql = "Select count(*) " & _
                                          "From Cuotas " & _
                                          "Where Contrato=" & txtCont.Text & " " & _
                                          "And Debe=2"
                                    consulta(2)

                                    If rs2.Read = True Then
                                        If rs2(0) <> 0 Then
                                            nudCobro.Value = rs2(0)
                                            nudCobro.Minimum = rs2(0)
                                        End If
                                    End If

                                    sql = "Select count(*) " & _
                                          "From Cuotas " & _
                                          "Where Contrato=" & txtCont.Text & " " & _
                                          "And Debe=1"
                                    consulta(2)

                                    If rs2.Read = True Then
                                        nudCobro.Maximum = 35 - rs2(0)
                                    End If

                                    lblMon.Text = aux
                                    lblCantD.Text = cantD
                                    lblCantP.Text = cantP

                                Else
                                    MsgBox("El contrato de credito es invalido o no pertenece al conjunto de cliente y constancia de compraventa que ingreso")
                                End If
                            End If
                        Else
                            MsgBox("La constancia de compraventa es invalida o no pertenece a ese cliente")
                        End If
                    End If
                Else
                    MsgBox("Cliente invalido")
                End If
            End If

        Else
            MsgBox("Llene las cajas de texto")
        End If
    End Sub

    Private Sub btnRec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRec.Click
        Me.Hide()
        frmChe.Show()
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmCuotas.Show()
        Me.Close()
    End Sub

    Private Sub frmCobroCuo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "Call Deuda()"
        consulta(1)
    End Sub
End Class