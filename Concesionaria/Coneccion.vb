Imports System.Data.Odbc

Module Coneccion
    'Se usa la funcion consulta() para hacer las consultas a la base de datos. Esta tiene como unico
    'parametro de entrada un numero, que representa el data reader el cual va a ser utilizado para la consulta.
    Public i As Integer
    Public cmd As OdbcCommand
    Public cnn As OdbcConnection
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public rs4 As OdbcDataReader
    Public sql As String

    Public Sub consulta(ByVal x As Integer)
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        If x = 1 Then
            rs1 = cmd.ExecuteReader
        ElseIf x = 2 Then
            rs2 = cmd.ExecuteReader
        ElseIf x = 3 Then
            rs3 = cmd.ExecuteReader
        ElseIf x = 4 Then
            rs4 = cmd.ExecuteReader
        End If

        cmd.Dispose()
    End Sub
End Module
