Imports System.Data.Odbc
Public Class frmVerificarPresu

    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click

        If Len(txtDNI.Text) = 8 And Len(txtpresu.Text) <> 0 Then
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
                          "And NPres =" & txtpresu.Text & " And tipo='compra';"


                    consulta(1)
                    If rs1.Read = True Then
                        If rs1(0) <> 0 Then
                            sql = "Select Fven>=curdate() " & _
                                  "From Presupuestos " & _
                                  "Where NPres=" & txtpresu.Text & ";"
                            consulta(1)
                            If rs1.Read = True Then
                                If rs1(0) = 1 Then
                                    btnGen.Enabled = True
                                    sql = "Select modelo, marca, color, kmu " & _
                                          "From aux " & _
                                          "Where presupuesto=" & txtpresu.Text & ";"
                                    consulta(1)
                                    If rs1.Read = True Then
                                        lstauto.Items.Add(rs1(0))
                                        lstauto.Items(i).SubItems.Add(rs1(1))
                                        lstauto.Items(i).SubItems.Add(rs1(3))
                                        lstauto.Items(i).SubItems.Add(rs1(2))
                                        i = i + 1
                                    End If

                                Else
                                    MsgBox("El presupuesto esta vencido")
                                End If
                            End If
                        Else
                            MsgBox("El presupuesto no pertenece a ese cliente o no es de compra")
                        End If

                    End If

                End If

            End If

        End If



    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Close()
        frmCompraAutosUsados.Show()
    End Sub

    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGen.Click
        Dim precioventa As Integer
        Me.Hide()
        frmChe.Show()
        sql = "Select Matricula, Marca, Modelo, Color, Nbast, Kmu, AñoModelo,precio " & _
              "From aux " & _
              "Where presupuesto=" & txtpresu.Text
        consulta(1)
        If rs1.Read = True Then
            precioventa = (rs1(7) * 0.3) + rs1(7)

            sql = "Insert into precios values(''," & precioventa & ")"
            consulta(2)
            sql = "Select max(npre) " & _
                  "From precios"
            consulta(2)

            If rs2.Read Then
                sql = "Insert into Almacen values('','" & rs1(0) & "','" & rs1(1) & "','" & rs1(2) & "','" & rs1(3) & "','" & rs1(4) & "'," & rs2(0) & "," & rs1(5) & "," & rs1(6) & ")"
                consulta(3)
            End If

        End If


    End Sub


End Class