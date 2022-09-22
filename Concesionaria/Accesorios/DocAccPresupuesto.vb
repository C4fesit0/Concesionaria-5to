Imports System.Data.Odbc
Public Class frmDocAccPres

    Private Sub frmDocAccPres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim acum As Integer
        sql = "Select max(npres) " & _
             "From presupuestos ;"
        consulta(1)
        If rs1.Read = True Then

            lblnpre.Text = rs1(0)

            sql = "Select nombre, apellido, dni " & _
                  "From clientes " & _
                  "Where idcliente = (Select idcliente " & _
                                     "From presupuestos " & _
                                     "Where npres=" & rs1(0) & ");"
            consulta(2)
            If rs2.Read() = True Then

                lblNyA.Text = rs2(0) & " " & rs2(1)
                lblDNI.Text = rs2(2)

                sql = "Select nombre, precio,cantidad " & _
                      "From Acc_Presupuestos AP, Productos P " & _
                      "Where AP.presupuesto= " & rs1(0) & " " & _
                      "And P.Idproducto=AP.producto"
                consulta(3)
                While rs3.Read = True
                    sql = "Select precio " & _
                          "From precios " & _
                          "Where Npre=" & rs3(1) & ";"
                    consulta(1)

                    If rs1.Read = True Then

                        If i = 0 Then
                            lblacc.Text = rs3(0)
                            lblPre.Text = rs1(0)
                            lblcant.Text = rs3(2)
                        ElseIf i = 1 Then
                            lblacc2.Text = rs3(0)
                            lblPre2.Text = rs1(0)
                            lblcant2.Text = rs3(2)
                        ElseIf i = 2 Then
                            lblacc3.Text = rs3(0)
                            lblPre3.Text = rs1(0)
                            lblcant3.Text = rs3(2)
                        ElseIf i = 3 Then
                            lblacc4.Text = rs3(0)
                            lblPre4.Text = rs1(0)
                            lblcant4.Text = rs3(2)
                        ElseIf i = 4 Then
                            lblacc5.Text = rs3(0)
                            lblPre5.Text = rs1(0)
                            lblcant5.Text = rs3(2)
                        ElseIf i = 5 Then
                            lblacc6.Text = rs3(0)
                            lblPre6.Text = rs1(0)
                            lblcant6.Text = rs3(2)
                        ElseIf i = 6 Then
                            lblacc7.Text = rs3(0)
                            lblPre7.Text = rs1(0)
                            lblcant7.Text = rs3(2)
                        End If
                        acum = acum + rs1(0) * rs3(2)
                        i += 1

                    End If

                End While
            End If
            lbMontotal.Text = acum
            sql = "Select max(npres) " & _
                  "From presupuestos ;"
            consulta(4)
            If rs4.Read Then
                sql = "Update presupuestos " & _
                      "Set Monto=" & acum & " " & _
                      "Where Npres=" & rs4(0) & ";"
                consulta(4)
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