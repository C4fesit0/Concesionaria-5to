Imports System.Data.Odbc
Public Class frmNotaIns
    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click
        If Len(txtDNI.Text) = 8 And Len(txtPre.Text) <> 0 Then
            sql = "Select count(*) " & _
                 "From clientes " & _
                 "Where DNI =" & txtDNI.Text & ";"
            consulta(1)
            If rs1.Read = True Then
                If rs1(0) <> 0 Then
                    sql = "Select count(*) " & _
                          "From Presupuestos " & _
                          "Where Idcliente=(Select idcliente " & _
                                            "From clientes " & _
                                            "Where DNI =" & txtDNI.Text & ") " & _
                          "And NPres =" & txtPre.Text & ";"
                    consulta(1)

                    If rs1.Read = True Then
                        If rs1(0) <> 0 Then

                            sql = "Select count(*) " & _
                                  "From Acc_Presupuestos " & _
                                  "Where Presupuesto=" & txtPre.Text & ";"
                            consulta(1)
                            If rs1.Read = True Then
                                If rs1(0) <> 0 Then
                                    sql = "Select Fven>=curdate() " & _
                                          "From Presupuestos " & _
                                          "Where NPres=" & txtPre.Text & ";"
                                    consulta(1)
                                    If rs1.Read = True Then
                                        If rs1(0) Then
                                            sql = "Select producto " & _
                                                  "From acc_presupuestos " & _
                                                  "Where presupuesto=" & txtPre.Text & ";"
                                            consulta(1)
                                            If rs1.Read = True Then
                                                sql = "Select stock " & _
                                                      "From productos " & _
                                                      "Where idproducto=" & rs1(0) & ";"
                                                consulta(2)

                                                btnCargar.Enabled = True
                                                txtDNI.Enabled = False
                                                txtPre.Enabled = False
                                                btnVeri.Enabled = False

                                            End If
                                        Else
                                            MsgBox("El presupuesto esta vencido")
                                        End If
                                    End If
                                Else
                                    MsgBox("El presupuesto no es de accesorios")
                                End If
                            End If
                        Else
                            MsgBox("El presupuesto no pertenece a ese cliente")
                        End If


                    End If
                Else
                    MsgBox("El cliente no existe")
                End If
            End If
        Else
            MsgBox("Ingrese un DNI (8 caracteres) y numero de presupuesto validos")
        End If
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Dim x As Integer

        If rs2.Read = True Then
            If rs2(0) > 1 Then

                sql = "Select count(*) " & _
                      "From Constancias_cp " & _
                      "Where Presupuesto in (Select presupuesto " & _
                                            "From Presupuestos " & _
                                            "Where Idcliente=(Select idcliente " & _
                                                             "From clientes " & _
                                                             "Where DNI=" & txtDNI.Text & "));"
                consulta(1)
                If rs1.Read = True Then
                    If rs1(0) <> 0 Then
                        sql = "Select idcons " & _
                              "From Constancias_cp " & _
                              "Where Presupuesto in (Select presupuesto " & _
                                                    "From Presupuestos " & _
                                                    "Where Idcliente=(Select idcliente " & _
                                                                     "From clientes " & _
                                                                     "Where DNI=" & txtDNI.Text & "));"
                        consulta(1)
                        If rs1.Read = True Then
                            sql = "Select idcliente " & _
                                  "From clientes " & _
                                  "Where DNI=" & txtDNI.Text & "; "
                            consulta(4)
                            If rs4.Read Then


                                sql = "Insert into Nota_ins values(''," & rs1(0) & ",'False'," & rs4(0) & ");"
                                consulta(1)
                                sql = "Select producto,cantidad " & _
                                     "From Acc_Presupuestos " & _
                                     "Where presupuesto=" & txtPre.Text & ";"
                                consulta(1)
                                While rs1.Read = True
                                    sql = "Select max(idNota) " & _
                                          "From nota_ins "
                                    consulta(2)
                                    If rs2.Read = True Then
                                        sql = "Insert into Nota_Acc values(" & rs2(0) & "," & rs1(0) & "," & rs1(1) & ");"
                                        consulta(3)

                                        sql = "Select nombre " & _
                                             "From productos " & _
                                             "Where idproducto=" & rs1(0) & ";"
                                        consulta(3)
                                        If rs3.Read = True Then
                                            lstMuestra.Items.Add(rs2(0))
                                            lstMuestra.Items(lstMuestra.Items.Count - 1).SubItems.Add(rs3(0))

                                            sql = "update productos " & _
                                                 "set stock=(stock-" & rs1(1) & ")" & _
                                                 "where idproducto=" & rs1(0) & ";"

                                            consulta(3)
                                            btnNota.Enabled = True
                                            btnCargar.Enabled = False
                                        End If

                                    End If
                                End While


                            End If
                        End If
                    End If
                End If



            Else
                x = MsgBox("No hay stock del producto, desea generar una orden de compra?", MsgBoxStyle.YesNo, "Orden de compra")

                If x = 6 Then
                    Me.Hide()
                    'frmReg.Show()
                Else
                    txtDNI.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmAccesorios.Show()
    End Sub

    Private Sub btnNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNota.Click
        Me.Hide()
        frmDocNota.Show()

    End Sub
End Class