Imports System.Data.Odbc
Public Class frmPreCompra
    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click
        Dim x As Integer

        sql = "Select count(*) " & _
              "From clientes " & _
              "Where DNI=" & txtDNI.Text & ";"
        consulta(1)
        If rs1.Read = True Then
            If rs1(0) = 1 Then
                txtaño.Enabled = True
                txtcolor.Enabled = True
                txtkmu.Enabled = True
                txtmarca.Enabled = True
                txtmodelo.Enabled = True
                txtprecio.Enabled = True
                txtnbasti.Enabled = True
                txtmatricula.Enabled = True
                txtDNI.Enabled = False
                btnVeri.Enabled = False
                btnpresu.Enabled = True
            Else
                x = MsgBox("Cliente no encontrado, desea ingresarlo?", MsgBoxStyle.YesNo, "Registrar")

                If x = 6 Then
                    Me.Hide()
                    frmReg.Show()
                Else
                    txtDNI.Text = ""
                End If
            End If


        End If

    End Sub


    Private Sub btnpresu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpresu.Click

        sql = "Select idcliente " & _
              "From clientes " & _
              "Where DNI=" & txtDNI.Text & ";"
        consulta(1)
        If rs1.Read = True Then
            sql = "insert into presupuestos values(''," & rs1(0) & ",'compra',curdate(),date_add(curdate(), interval 2 month)," & txtprecio.Text & ");"
            consulta(1)
            sql = "Select max(npres) " & _
                  "From presupuestos; "
            consulta(1)
            If rs1.Read Then
                sql = "Insert into aux values ('','" & txtmatricula.Text & "','" & txtmarca.Text & "','" & txtmodelo.Text & "','" & txtcolor.Text & "','" & txtnbasti.Text & "'," & txtkmu.Text & "," & txtaño.Text & "," & txtprecio.Text & "," & rs1(0) & ");"
                consulta(1)
                Me.Hide()
                frmDocPreCompra.Show()
            End If
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmCompraAutosUsados.Show()
    End Sub
End Class