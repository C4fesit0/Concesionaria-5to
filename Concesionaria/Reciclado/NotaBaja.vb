Public Class frmNotaBaja

    Private Sub frmNotaBaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "Select max(IdNota)+1 From Nota_baja"
        consulta(1)

        If rs1.Read Then
            lblN.Text = rs1(0)
        End If

        lblMat.Text = ""

        For i As Integer = 0 To Val(frmReciclado.lblAux.Text) Step 1
            lblMat.Text = lblMat.Text & ", " & frmReciclado.lstM8.Items(i).SubItems(0).Text
            If (i Mod 3) = 0 Then
                lblMat.Text = lblMat.Text + vbLf
            End If
            sql = "Insert into nota_baja values(" & rs1(0) & ", '" & frmReciclado.lstM8.Items(i).SubItems(0).Text & "', curdate())"
            consulta(1)

            sql = "Delete from Almacen Where Matricula='" & frmReciclado.lstM8.Items(i).SubItems(0).Text & "'"
            consulta(1)
        Next
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        btnImp.Visible = False
        PrintForm1.Print()

        frmMenu.Show()
        Me.Close()
    End Sub
End Class