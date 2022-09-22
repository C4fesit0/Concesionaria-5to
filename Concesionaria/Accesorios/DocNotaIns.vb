Imports System.Data.Odbc
Public Class frmDocNota

    Private Sub frmDocNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = 0
        sql = "Select max(IdNota) " & _
              "From Nota_ins ;"
        consulta(1)
        If rs1.Read = True Then
            lblnpre.Text = rs1(0)
            sql = "Select nombre, apellido, dni " & _
                  "From clientes " & _
                  "Where idcliente = (Select idcliente " & _
                                     "From nota_ins " & _
                                     "Where idNota=" & rs1(0) & ");"
            consulta(2)
            If rs2.Read = True Then

                lblNyA.Text = rs2(0) & " " & rs2(1)
                lblDNI.Text = rs2(2)

                sql = "Select nombre " & _
                      "From nota_acc,productos " & _
                      "Where nota=" & rs1(0) & " " & _
                      "And producto=idproducto; "
                consulta(3)
                While rs3.Read = True
                    If i = 0 Then
                        lblacc.Text = rs3(0)
                    ElseIf i = 1 Then
                        lblacc2.Text = rs3(0)
                    ElseIf i = 2 Then
                        lblacc3.Text = rs3(0)
                    ElseIf i = 3 Then
                        lblacc4.Text = rs3(0)
                    ElseIf i = 4 Then
                        lblacc5.Text = rs3(0)
                    ElseIf i = 5 Then
                        lblacc6.Text = rs3(0)
                    ElseIf i = 6 Then
                        lblacc7.Text = rs3(0)
                    End If
                    i = i + 1
                End While
            End If
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        btnImp.Visible = False
        PrintForm1.Print()

        frmAccesorios.Show()
        Me.Close()
    End Sub
End Class