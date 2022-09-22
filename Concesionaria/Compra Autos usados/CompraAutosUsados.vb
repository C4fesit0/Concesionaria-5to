Public Class frmCompraAutosUsados

    Private Sub BtnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompra.Click
        Me.Hide()
        frmPreCompra.Show()
    End Sub

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        Me.Hide()
        frmVerificarPresu.Show()

    End Sub


    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class