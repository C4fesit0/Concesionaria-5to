Imports System.Data.Odbc
Public Class frmInstalacion
    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click
        Dim montotal As Integer

        If Len(txtDNI.Text) = 8 And Len(txtNota.Text) <> 0 Then
            sql = "Select count(*) " & _
                  "from clientes " & _
                  "where DNI=" & txtDNI.Text & ";"
            consulta(1)
            If rs1.Read = True Then
                If rs1(0) <> 0 Then
                    sql = "Select count(*) " & _
                         "From nota_ins " & _
                         "Where idNota=" & txtNota.Text & ";"
                    consulta(1)
                    If rs1.Read = True Then
                        If rs1(0) <> 0 Then
                            sql = "Select estado " & _
                                  "From nota_ins " & _
                                  "Where idnota=" & txtNota.Text & ";"
                            consulta(1)

                            If rs1.Read = True Then
                                If rs1(0) = 1 Then
                                    sql = "Select idcliente " & _
                                          "From Clientes " & _
                                          "Where DNI=" & txtDNI.Text & ";"
                                    consulta(1)

                                    If rs1.Read = True Then
                                        sql = "Select monto " & _
                                              "From presupuestos " & _
                                              "Where idcliente=" & rs1(0) & ";"
                                        consulta(2)
                                        If rs2.Read = True Then
                                            montotal = rs2(0) + 2000
                                            sql = "insert into facturas values(''," & montotal & "," & rs1(0) & ",'A',curdate());"
                                            consulta(1)
                                            btnFactura.Enabled = True
                                            btnupdate.Enabled = False
                                        End If

                                    End If

                                Else
                                    MsgBox("No se instalaron aun, vuelva prontos")
                                    btnupdate.Enabled = True
                                End If
                            End If

                        Else
                            MsgBox("No existe la nota")
                        End If
                    End If
                End If
            Else
                MsgBox("El cliente no existe")
            End If


        Else
            MsgBox("Ingrese DNI(8 caracteres) y nota de instalacion validos")
        End If
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update nota_ins " & _
              "Set estado=1 " & _
              "Where idnota=" & txtNota.Text & ";"
        consulta(1)
        btnupdate.Enabled = False
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmAccesorios.Show()

    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Me.Hide()
        frmDocFac.Show()

    End Sub
End Class

'else if frmVerificarPresu.txtpresu.Text <> "" Then
'sql = "Insert into Cheques values ('', '" & txtNom.Text & "', '" & txtApe.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", '" & txtBan.Text & "'," & txtMon.Text & ", '" & fecha & "', 'Salida', 'Compra de auto')"
'consulta(1)
'frmverificarPresu.btngen.enabled= false
'frmverificarpresu.btnRecibo.enabled= true


