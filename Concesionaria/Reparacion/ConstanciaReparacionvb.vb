Public Class frmConstanciaReparacion
    Dim hoy As String
    Dim vencimiento As String
    Dim patente As String
    Dim docCliente As String
    Dim idclient As Integer
    Dim constanciaCliente As Integer
    Dim garantiaTipo As String

    Private Sub ConstanciaReparacionvb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        patente = ServicioReclamos.txt2MatriculaSR.Text
        docCliente = ServicioReclamos.txt1DocumentoSR.Text
        sql = "Select constancia from ventas_autos where matricula='" & ServicioReclamos.txt2MatriculaSR.Text & "'"
        consulta(2)
        rs2.Read()
        constanciaCliente = rs2(0)
        sql = "select fechaf from garantia where constancia='" & rs2(0) & "'"
        consulta(1)
        rs1.Read()
        vencimiento = rs1(0)
        hoy = Format(Now(), "yyyyMMdd")

        If vencimiento < hoy Then
            lblGarantia.Text = "La Garantia cubre los daños"
            garantiaTipo = "con garantia"
        ElseIf vencimiento > hoy Then
            lblGarantia.Text = "La Garantia no cubre los daños"
            garantiaTipo = "sin garantia"
        End If

        sql = "Select count(*) from reparaciones"
        consulta(2)

        If rs2.Read() = True Then
            If rs2(0) = 0 Then
                lblNumeroReparacion.Text = "N°: 400"
            ElseIf rs2(0) > 0 Then
                sql = "Select max(Nreparacion)+1 from reparaciones"
                consulta(1)
                rs1.Read()
                lblNumeroReparacion.Text = "N°: " & rs1(0)
            End If

        End If
        lblFecha.Text = hoy
        lblMatricula.Text = patente
        lblCliente.Text = docCliente

        sql = "select idcliente from clientes where DNI='" & docCliente & "'"
        consulta(1)
        rs1.Read()
        idclient = rs1(0)

        sql = "insert into reparaciones values('','" & constanciaCliente & "','" & patente & "','" & idclient & "',curdate(),null,'" & garantiaTipo & "','Pendiente')"
        consulta(1)
        rs1.Read()
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        btnImp.Visible = False
        PrintForm1.Print()
        frmMenu.Show()
        ServicioReclamos.Close()
        Me.Close()
    End Sub
End Class