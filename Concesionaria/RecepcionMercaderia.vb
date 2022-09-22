Imports System.Data.Odbc
Public Class RecepcionMercaderia

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim i As Integer
        txtOrdenDeCompra.Enabled = False
        sql = "Select count(*) from ordencompra where id_od='" & txtOrdenDeCompra.Text & "' and estado=0"
        consulta(1)
        i = 0
        While rs1.Read() = True
            If rs1(0) = 1 Then
                sql = "select producto,cantidad from detalle_ordencompra where ordencompra='" & txtOrdenDeCompra.Text & "'"
                consulta(2)
                btn1.Enabled = False
                btn3OrdenDeCompra.Enabled = True
                While rs2.Read() = True

                    sql = "select nombre from productos where idproducto='" & rs2(0) & "'"
                    consulta(3)
                    rs3.Read()
                    lst.Items.Add(rs3(0))
                    lst.Items(i).SubItems.Add(rs2(1))
                    i = i + 1


                End While
                sql = "update ordencompra set estado=1 where id_OD='" & txtOrdenDeCompra.Text & "'"
                consulta(2)
            Else
                MsgBox("La orden de compra no existe o ya fue entregada")
                txtOrdenDeCompra.Enabled = True
                txtOrdenDeCompra.Text = ""
            End If
        End While
        i = 0

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2OrdenDeComra.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3OrdenDeCompra.Click

        sql = "select producto,cantidad from detalle_ordencompra where ordencompra='" & txtOrdenDeCompra.Text & "'"
        consulta(1)

        While rs1.Read = True
            sql = "update Productos set stock=stock+" & rs1(1) & " where idproducto='" & rs1(0) & "'"
            consulta(2)
            rs2.Read()
        End While
        MsgBox("Se ha agregado los nuevos repuestos al stock")
        btn1.Enabled = True
        btn3OrdenDeCompra.Enabled = False
        lst.Items.Clear()
        txtOrdenDeCompra.Enabled = True
        txtOrdenDeCompra.Text = ""
    End Sub

    Private Sub txtOrdenDeCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenDeCompra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
