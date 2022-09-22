Public Class frmDocOC

    Private Sub frmDocOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim acum As Integer
        i = 0
        sql = "Select max(Id_OD) " & _
              "From ordenCompra ;"
        consulta(1)
        If rs1.Read Then
            lblNOC.Text = rs1(0)
            sql = "Select producto,cantidad, precio " & _
                  "From detalle_ordencompra " & _
                  "Where ordencompra=" & rs1(0) & ";"
            consulta(2)
            While rs2.Read = True
                sql = "Select nombre " & _
                     "From productos " & _
                     "Where idproducto=" & rs2(0) & ";"
                consulta(3)
                If rs3.Read = True Then

                    If i = 0 Then
                        lblacc.Text = rs3(0)
                        lblPre.Text = rs2(2)
                        lblcant.Text = rs2(1)
                    ElseIf i = 1 Then
                        lblacc2.Text = rs3(0)
                        lblPre2.Text = rs2(2)
                        lblcant2.Text = rs2(1)
                    ElseIf i = 2 Then
                        lblacc3.Text = rs3(0)
                        lblPre3.Text = rs2(2)
                        lblcant3.Text = rs2(1)
                    ElseIf i = 3 Then
                        lblacc4.Text = rs3(0)
                        lblPre4.Text = rs2(2)
                        lblcant4.Text = rs2(1)
                    ElseIf i = 4 Then
                        lblacc5.Text = rs3(0)
                        lblPre5.Text = rs2(2)
                        lblcant5.Text = rs2(1)
                    ElseIf i = 5 Then
                        lblacc6.Text = rs3(0)
                        lblPre6.Text = rs2(2)
                        lblcant6.Text = rs2(1)
                    ElseIf i = 6 Then
                        lblacc7.Text = rs3(0)
                        lblPre7.Text = rs2(2)
                        lblcant7.Text = rs2(1)
                    End If
                    acum = acum + rs2(1) * rs2(2)
                    i += 1
                End If
            End While
            lblMontotal.Text = acum
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        PrintForm1.Print()
        Me.Close()
        frmMenu.Show()
    End Sub
End Class