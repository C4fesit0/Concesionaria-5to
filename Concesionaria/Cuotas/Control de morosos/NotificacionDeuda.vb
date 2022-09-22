Public Class frmNotiDeu
    Dim i As Integer
    Dim aux As Integer
    Private Sub frmNotiDeu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sig()
    End Sub

    Private Sub sig()
        sql = "Select max(IdND)+1 " & _
              "From Notif_Deuda"
        consulta(1)

        sql = "Select IdCuo " & _
              "From Cuotas " & _
              "Where Contrato=" & frmControlMorosos.lstMor.Items(i).SubItems(1).Text & " " & _
              "And Debe=2 " & _
              "Order by Idcuo desc " & _
              "Limit 1"
        consulta(1)


        If rs1.Read = True Then
            aux = rs1(0)
            lblCue1.Text = "Se le notifica a " & frmControlMorosos.lstMor.Items(i).SubItems(0).Text & " que se a pasado el plazo " + vbLf + "acordado de 1 mes para pagar la cuota numero " & rs1(0) & " " + vbLf + "para la paga de su automovil comprado en la " + vbLf + "concesionario KIX. Se le informa que a partir de ahora " + vbLf + "con la proxima paga de cuota se le va a sumar la que " + vbLf + "debe. Tambien se le recuerda que si esta cuota no se " + vbLf + "paga para dentro de los siguientes 2 meses o cualquier " + vbLf + "cuota tarda mas de 3 meses a ser pagada se le va a " + vbLf + "quitar el automovil de su propiedad como acordadado " + vbLf + "en el contrato de credito prendario y pasara a ser " + vbLf + "propiedad del prestamista hasta que se paguen todas " + vbLf + "las cuotas debidas"
        End If

        sql = "Select Monto " & _
              "From Cuotas " & _
              "Where Contrato=" & frmControlMorosos.lstMor.Items(i).SubItems(1).Text & " " & _
              "Limit 1"
        consulta(2)

        If rs2.Read Then
            lblCue2.Text = "Se le informa tambien que tiene otras " & Val(frmControlMorosos.lstMor.Items(i).SubItems(2).Text) - 1 & " cuotas sin " + vbLf + "pagar en su contrato de credito prendario N° " & frmControlMorosos.lstMor.Items(i).SubItems(1).Text & ", " + vbLf + "siendo un total de $" & rs2(0) & " que debe."
        End If

    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        sql = "Insert into Notif_Deuda values('', " & frmControlMorosos.lstMor.Items(i).SubItems(1).Text & ", " & aux & ")"
        consulta(1)

        btnImp.Visible = False
        PrintForm1.Print()
        btnImp.Visible = True

        If frmControlMorosos.lstMor.Items(i).SubItems(3).Text = "Si" Then
            sql = "Select Count(*) From Morosos Where Contrato=" & frmControlMorosos.lstMor.Items(i).SubItems(1).Text
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 0 Then
                    sql = "Insert into Morosos values('', " & frmControlMorosos.lstMor.Items(i).SubItems(1).Text & ", 0)"
                    consulta(1)
                End If
            End If

        End If

        i += 1

        If i < Val(frmControlMorosos.lblAux.Text) Then
            sig()
        Else
            frmCuotas.Show()
            frmControlMorosos.Close()
            Me.Close()
        End If


    End Sub
End Class