Imports System.Data.Odbc
Public Class frmDocPreCompra

    Private Sub frmDocPreCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "Select max(npres) " & _
      "From presupuestos ;"
        consulta(1)
        If rs1.Read = True Then
            sql = "Select Nombre, Apellido,DNI " & _
                  "From Clientes " & _
                  "Where Idcliente=(Select idcliente " & _
                                   "From presupuestos " & _
                                   "Where npres=" & rs1(0) & ");"
            consulta(2)
            lblNpresu.Text = rs1(0)
            If rs2.Read = True Then
                lblNyA.Text = rs2(0) & " " & rs2(1)
                lblDNI.Text = rs2(2)
                sql = "Select modelo,color, kmu " & _
                      "From aux " & _
                      "Where presupuesto=" & rs1(0) & ";"
                consulta(2)
                If rs2.Read = True Then
                    lblColor.Text = rs2(1)
                    lblKm.Text = rs2(2)
                    lblModelo.Text = rs2(0)
                    sql = "Select Monto " & _
                          "From presupuestos " & _
                          "Where npres=" & rs1(0) & ";"
                    consulta(2)
                    If rs2.Read = True Then
                        lblPrecio.Text = rs2(0)
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        PrintForm1.Print()
        Me.Close()
        frmCompraAutosUsados.Show()
    End Sub
End Class