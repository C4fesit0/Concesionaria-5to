Public Class frmIngresoAutos
    Private Sub btnVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmVenta.Show()
        Me.Close()
    End Sub

    Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        If txtCP.Text <> "" And Len(txtChasis.Text) = 10 And Len(txtCV.Text) = 8 And Len(txtMat.Text) = 7 Then
            sql = "Select count(*) " & _
                  "From ventas_autos " & _
                  "Where Constancia=" & txtCP.Text & " " & _
                  "Or Matricula='" & txtMat.Text & "'"
            consulta(1)

            If rs1.Read Then
                If rs1(0) = 0 Then
                    sql = "Select count(*) " & _
                          "From Constancia_Auto " & _
                          "Where Constancia=" & txtCP.Text
                    consulta(1)

                    rs1.Read()

                    If rs1(0) = 1 Then
                        sql = "Insert into ventas_autos values('', '" & txtMat.Text & "', '" & txtCV.Text & "', '" & txtChasis.Text & "', " & txtCP.Text & ")"
                        consulta(1)

                        frmGarantia.Show()
                        Me.Hide()
                    Else
                        MsgBox("La constancia de compraventa no existe o es de un auto usado, no uno 0km")
                    End If
                Else
                    MsgBox("Ya se ingreso un auto con estas especificaciones")
                End If
            End If

            
        Else
            MsgBox("Llene todas las cajas de texto")
        End If

        
    End Sub

    Private Sub frmIngresoAutos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        sql = "Select Marca, Modelo, Constancia " & _
              "From Constancia_Auto CA, Autos A " & _
              "Where CA.Auto=A.IdAuto"
        consulta(1)

        While rs1.Read
            lstCP.Items.Add(rs1(2))
            lstCP.Items(i).SubItems.Add(rs1(0))
            lstCP.Items(i).SubItems.Add(rs1(1))

            i = i + 1
        End While
    End Sub
End Class