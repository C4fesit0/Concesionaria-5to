Imports System.Data.Odbc
Public Class frmEmiOC
    Private Sub frmEmiOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "Select nombre, tipo, stock, pp " & _
              "From productos " & _
              "Where stock<=pp " & _
              "or stock=0;"
        consulta(1)
        sql = "insert into ordenCompra values('',curdate(),false)"
        consulta(2)
        While rs1.Read = True
            lstProductos.Items.Add(rs1(0))
            lstProductos.Items(lstProductos.Items.Count - 1).SubItems.Add(rs1(1))
            lstProductos.Items(lstProductos.Items.Count - 1).SubItems.Add(rs1(2))
            lstProductos.Items(lstProductos.Items.Count - 1).SubItems.Add(rs1(3))

        End While

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim pre As Integer
        Dim cont As Integer
        sql = "Select max(id_OD) " & _
              "From ordencompra"
        consulta(1)
        If rs1.Read = True Then
            sql = "Select idproducto, nombre,precio " & _
                  "From productos " & _
                  "Where nombre= '" & lstProductos.FocusedItem.Text & "'"
            consulta(2)
            If rs2.Read Then
                sql = "Select precio " & _
                      "From precios " & _
                      "Where npre=" & rs2(2)
                consulta(3)
                If rs3.Read = True Then
                    pre = (rs3(0) * 30) / 100

                    sql = "Insert into detalle_ordencompra values(''," & rs1(0) & "," & rs2(0) & "," & txtCant.Text & "," & pre & ")"
                    consulta(3)
                    If cont <= 6 Then
                        lstOC.Items.Add(rs2(1))
                        lstOC.Items(lstOC.Items.Count - 1).SubItems.Add(txtCant.Text)
                        lstOC.Items(lstOC.Items.Count - 1).SubItems.Add(pre)
                        lstProductos.FocusedItem.Remove()
                    Else
                        MsgBox("No puede ordenar mas productos")
                        btnGenerar.Enabled = False
                    End If
                End If


            End If


        End If

    End Sub


    Private Sub btnOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOC.Click
        Me.Hide()
        frmDocOC.Show()
    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        If Len(txtCant.Text) = 0 Then
            btnGenerar.Enabled = False
        Else
            btnGenerar.Enabled = True
        End If
    End Sub
End Class