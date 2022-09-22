Public Class frmDocFac

    Private Sub frmDocFac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = 0
        sql = "Select max(NFact) " & _
              "From facturas ;"
        consulta(1)
        If rs1.Read = True Then
            lblNFac.Text = rs1(0)
            sql = "Select cliente,monto,FEmicion " & _
                  "From facturas " & _
                  "Where nfact=" & rs1(0) & ";"
            consulta(1)
            If rs1.Read Then
                lblFecha.Text = rs1(2)
                lblMontotal.Text = rs1(1)
                sql = "Select nombre,apellido, dni " & _
                      "From clientes " & _
                      "Where idcliente=" & rs1(0) & ";"
                consulta(2)
                If rs2.Read = True Then
                    lblNyA.Text = rs2(0) & " " & rs2(1)
                    lblDNI.Text = rs2(2)
                    sql = "Select idnota " & _
                          "From nota_ins " & _
                          "Where cliente=" & rs1(0) & ";"
                    consulta(2)
                    If rs2.Read Then
                        sql = "Select producto,cantidad " & _
                            "From nota_acc " & _
                            "Where nota=" & rs2(0) & ";"
                        consulta(3)

                        While rs3.Read = True
                            sql = "Select nombre,precio " & _
                                 "From productos " & _
                                 "Where idproducto= " & rs3(0) & ";"
                            consulta(1)

                            If rs1.Read = True Then
                                sql = "Select precio " & _
                                    "From precios " & _
                                    "Where npre=" & rs1(1) & ";"
                                consulta(4)
                                If rs4.Read Then
                                    If i = 0 Then
                                        lblacc.Text = rs1(0)
                                        lblPre.Text = rs4(0)
                                        lblcant.Text = rs3(1)
                                    ElseIf i = 1 Then
                                        lblacc2.Text = rs1(0)
                                        lblPre2.Text = rs4(0)
                                        lblcant2.Text = rs3(1)
                                    ElseIf i = 2 Then
                                        lblacc3.Text = rs1(0)
                                        lblPre3.Text = rs4(0)
                                        lblcant3.Text = rs3(1)
                                    ElseIf i = 3 Then
                                        lblacc4.Text = rs1(0)
                                        lblPre4.Text = rs4(0)
                                        lblcant4.Text = rs3(1)
                                    ElseIf i = 4 Then
                                        lblacc5.Text = rs1(0)
                                        lblPre5.Text = rs4(0)
                                        lblcant5.Text = rs3(1)
                                    ElseIf i = 5 Then
                                        lblacc6.Text = rs1(0)
                                        lblPre6.Text = rs4(0)
                                        lblcant6.Text = rs3(1)
                                    ElseIf i = 6 Then
                                        lblacc7.Text = rs1(0)
                                        lblPre7.Text = rs4(0)
                                        lblcant7.Text = rs3(1)
                                    End If
                                    i = i + 1
                                End If
                            End If
                        End While
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        PrintForm1.Print()
        Me.Close()
        frmAccesorios.Show()
    End Sub
End Class