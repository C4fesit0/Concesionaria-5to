Imports System.Data.Odbc
Public Class frmVentaAcc
    Dim cont As Integer
    Private Sub btnveri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveri.Click

        If Len(txtDNI.Text) = 8 Then
            sql = "select count(*),idcliente from clientes where DNI=" & txtDNI.Text & ";"
            consulta(1)
            If rs1.Read = True Then
                If rs1(0) <> 0 Then
                    sql = "Select count(*) " & _
                          "From Constancias_cp " & _
                          "Where Presupuesto in (Select presupuesto " & _
                                                "From Presupuestos " & _
                                                "Where Idcliente=(Select idcliente " & _
                                                                 "From clientes " & _
                                                                 "Where DNI=" & txtDNI.Text & "));"
                    consulta(3)
                    If rs3.Read() = True Then
                        If rs3(0) <> 0 Then

                            txtDNI.Enabled = False
                            btnveri.Enabled = False
                            cbxacc.Enabled = True
                            btncom.Enabled = True
                            nupCant.Enabled = True

                            sql = "Insert into presupuestos values (''," & rs1(1) & ", 'Venta', curdate(),date_add(curdate(), interval 2 month),null);"
                            consulta(1)
                            sql = "Select nombre from productos where tipo='accesorio';"
                            consulta(2)
                            While rs2.Read() = True

                                cbxacc.Items.Add(rs2(0))
                            End While
                        Else
                            MsgBox("El cliente no compro un auto")
                        End If
                    End If
                Else


                End If

            End If

        Else
            MsgBox("Ingrese un DNI (8 caracteres) valido")

        End If

    End Sub

    Private Sub btncom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncom.Click


        sql = "Select Idproducto, precio, nombre from productos where nombre = '" & cbxacc.Text & "' and tipo='accesorio';"
        consulta(1)

        If rs1.Read = True Then
            sql = "select precio from precios where npre =" & rs1(1) & ";"
            consulta(2)

            If rs2.Read = True Then


                sql = "Select max(Npres) from presupuestos;"
                consulta(3)

                If rs3.Read = True Then

                    sql = "Insert into Acc_presupuestos values(" & rs3(0) & ", " & rs1(0) & "," & nupCant.Value & ");"
                    consulta(3)
                    If cont <= 6 Then
                        lstCompras.Items.Add(rs1(2))
                        lstCompras.Items(lstCompras.Items.Count - 1).SubItems.Add(rs2(0))
                        lstCompras.Items(lstCompras.Items.Count - 1).SubItems.Add(nupCant.Value)
                        cbxacc.Items.Remove(cbxacc.SelectedItem)
                        cont = cont + 1
                        btncom.Enabled = True
                    Else
                        MsgBox("No puede comprar mas articulos")
                        btncom.Enabled = False
                    End If
                End If

            End If



        End If



    End Sub
    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGen.Click
        Me.Hide()
        frmDocAccPres.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        sql = "Select idproducto,nombre " & _
              "From productos " & _
             "Where nombre='" & lstCompras.FocusedItem.Text & "';"
        consulta(1)

        If rs1.Read = True Then
            sql = "Select max(npres) " & _
                "From presupuestos ;"
            cbxacc.Items.Add(rs1(1))
            consulta(2)
            If rs2.Read = True Then
                sql = "Delete from Acc_Presupuestos " & _
                      "where presupuesto= " & rs2(0) & " and producto=" & rs1(0) & ";"
                consulta(1)
                lstCompras.FocusedItem.Remove()
                cont = cont - 1
                btncom.Enabled = True
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception

                End Try


            End If
        End If

    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        frmAccesorios.Show()
        Me.Close()
    End Sub
End Class