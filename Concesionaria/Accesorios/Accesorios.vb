Public Class frmAccesorios

    Private Sub btnPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Me.Hide()
        frmVentaAcc.Show()
    End Sub

    Private Sub btnNotains_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotains.Click
        Me.Hide()
        frmNotaIns.Show()
    End Sub

    Private Sub btnInstalacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstalacion.Click
        Me.Hide()
        frmInstalacion.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()

    End Sub
End Class