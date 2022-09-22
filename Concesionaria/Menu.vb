Imports System.Data.Odbc

Public Class frmMenu
    Private Sub frmMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cnn = New OdbcConnection("DSN=BDCons")
            cnn.Open()
        Catch ex As Exception
            MsgBox("Falla en la conexion")
        End Try
    End Sub

    Private Sub btnVentaA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVentaA.Click
        Me.Hide()
        frmVenta.Show()
    End Sub

    Private Sub btnCuo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCuo.Click
        Me.Hide()
        frmCuotas.Show()
    End Sub

    Private Sub btnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRec.Click
        Me.Hide()
        frmReciclado.Show()
    End Sub

    Private Sub btnRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRep.Click
        ServicioReclamos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RecepcionMercaderia.Show()
        Me.Hide()
    End Sub

    Private Sub btnAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcc.Click
        frmAccesorios.Show()
        Me.Hide()
    End Sub

    Private Sub btnCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCom.Click
        frmCompraAutosUsados.Show()
        Me.Hide()
    End Sub

    Private Sub btnPedidos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPedidos.Click
        frmEmiOC.Show()
        Me.Hide()
    End Sub
End Class