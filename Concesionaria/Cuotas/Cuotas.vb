Public Class frmCuotas

    Private Sub btnCCuo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCCuo.Click
        frmCobroCuo.Show()
        Me.Close()
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnCMor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCMor.Click
        frmControlMorosos.Show()
        Me.Close()
    End Sub
End Class