Public Class frmChe
    Dim band1 As Boolean = False
    Dim band2 As Boolean = False
    Dim band3 As Boolean = False
    Dim band4 As Boolean = False
    Dim band5 As Boolean = False
    Dim band6 As Boolean = False
    Dim fecha As String

    Private Sub txtBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBan.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMon.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEmi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmi.Click
        If Len(txtNC.Text) = 9 Then
            band1 = True
        Else
            MsgBox("Ingrese una Nª de cuenta valido (9 caracteres total)")
            band1 = False
        End If

        If Len(txtNom.Text) >= 3 Or frmCobroCuo.txtCont.Text <> "" Then
            band2 = True
        Else
            MsgBox("Ingrese un nombre valido")
            band2 = False
        End If

        If Len(txtNR.Text) = 9 Then
            band3 = True
        Else
            MsgBox("Ingrese una Nª de ruta valido (9 caracteres total)")
            band3 = False
        End If

        If Len(txtMon.Text) >= 4 Then
            band4 = True
        Else
            MsgBox("Ingrese un monto valido (mayor a 1000)")
            band4 = False
        End If

        If Len(txtBan.Text) >= 3 Then
            band5 = True
        Else
            MsgBox("Ingrese un banco valido")
            band5 = False
        End If

        If Len(txtApe.Text) >= 2 Then
            band6 = True
        Else
            MsgBox("Ingrese un apellido valido (mayor a dos letras)")
            band6 = False
        End If

        fecha = Str(Format(dtpFecha.Value, "yyyyMMdd"))

        If band1 And band2 And band3 And band4 And band5 And band6 Then


            If frmConsRes.txtPres.Text <> "" Then
                sql = "Insert into Cheques values ('', '" & txtNom.Text & "', '" & txtApe.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", '" & txtBan.Text & "'," & txtMon.Text & ", '" & fecha & "', 'Entrada', 'Compra auto seña')"
                consulta(1)

                frmConsRes.gbxMet.Enabled = False
                frmConsRes.btnSig.Enabled = True
                frmConsRes.btnVol.Enabled = False
                frmConsRes.btnSen.Enabled = False
                frmConsRes.lblAux.Text = txtMon.Text
                Me.Close()
                frmConsRes.Show()

            ElseIf frmCobroCuo.txtCont.Text <> "" Then
                sql = "Insert into Cheques values ('', '" & txtNom.Text & "', '" & txtApe.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", '" & txtBan.Text & "'," & txtMon.Text & ", '" & fecha & "', 'Entrada', 'Pago de cuota')"
                consulta(1)

                sql = "Select max(NCheque) From Cheques"
                consulta(1)

                rs1.Read()
                lblAuxnc.Text = rs1(0)

                frmRecibo.Show()
                Me.Hide()

            ElseIf frmConsCP.txtCR.Text <> "" Then
                sql = "Insert into Cheques values ('', '" & txtNom.Text & "', '" & txtApe.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", '" & txtBan.Text & "'," & txtMon.Text & ", '" & fecha & "', 'Entrada', 'Compra de auto')"
                consulta(1)

                frmConsCP.btnChe.Enabled = False
                frmConsCP.btnGen.Enabled = True

                frmConsCP.Show()
                Me.Close()
            ElseIf frmVerificarPresu.txtpresu.Text <> "" Then
                sql = "Insert into Cheques values ('', '" & txtNom.Text & "', '" & txtApe.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", '" & txtBan.Text & "'," & txtMon.Text & ", '" & fecha & "', 'Salida', 'Compra de auto')"
                consulta(1)
                frmVerificarPresu.btnGen.Enabled = False

                frmVerificarPresu.Close()
                frmMenu.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        If frmConsCP.txtPres.Text <> "" Then
            Me.Close()
            frmConsCP.Show()
        ElseIf frmConsRes.txtPres.Text <> "" Then
            Me.Close()
            frmConsRes.Show()
        End If
    End Sub

    Private Sub frmChe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If frmCobroCuo.txtCont.Text <> "" Then
            txtMon.Text = Val(frmCobroCuo.lblMon.Text) * frmCobroCuo.nudCobro.Value
            txtMon.Enabled = False

        ElseIf frmConsCP.txtCR.Text <> "" Then
            sql = "Select sena " & _
                  "From Constancias_res " & _
                  "Where IdRes=" & frmConsCP.txtCR.Text
            consulta(1)

            sql = "Select Monto " & _
                  "From Presupuestos " & _
                  "Where NPres=" & frmConsCP.txtPres.Text
            consulta(2)

            If rs1.Read And rs2.Read Then
                txtMon.Text = Val(rs2(0)) - Val(rs1(0))
                txtMon.Enabled = False
            End If
        End If
    End Sub

    
End Class