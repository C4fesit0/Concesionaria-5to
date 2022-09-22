Public Class frmReciclado

    

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnEmi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmi.Click
        Me.Hide()
        frmNotaBaja.Show()
    End Sub

    Private Sub frmReciclado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer

        sql = "Select Matricula, Marca, Modelo, Color, KMU " & _
              "From Almacen " & _
              "Where TIMESTAMPDIFF(YEAR, AnoModelo, curdate())>=8 " & _
              "And IdAutoU not in (Select AutoU from COnstancia_AutoU)"
        consulta(1)

        While rs1.Read
            lstM8.Items.Add(rs1(0))
            lstM8.Items(i).SubItems.Add(rs1(1))
            lstM8.Items(i).SubItems.Add(rs1(2))
            lstM8.Items(i).SubItems.Add(rs1(3))
            lstM8.Items(i).SubItems.Add(rs1(4))

            i = i + 1
        End While

        lblAux.Text = i - 1
    End Sub
End Class