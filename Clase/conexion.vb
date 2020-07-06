Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source = DESKTOP-4AAROTR; initial catalog = Ejempo; integrated security = True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Function consulta() As DataTable
        Try
            conexion.Open()

            Dim cmd As New SqlCommand("consultaEstudiante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim EliminarE As String = "Delete from" + "Tabla" + "where" + condicion
        comando = New SqlCommand(EliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update" + tabla + "Set" + campos + "where" + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function buscarEstudiante(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "Select * from persona.estudiante" + "where" + "Condicion"
            Dim cmd As New SqlCommand(buscar, conexion)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function estudianteValidar(ByVal codigo As String) As Boolean
        Dim resultado As Boolean = False

        Try
            conexion.Open()
            comando = New SqlCommand("Selsect * from persona.estudiante where codigo = '" + codigo + "'", conexion)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = True
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado

    End Function

    Function insertarE(ByVal codigo As String, ByVal nombre As String, ByVal Apellido1 As String, ByVal Apellido2 As String, ByVal edad As Integer, ByVal sexo As String, ByVal codicoClase As String) As String
        Dim mensaje As String = "Estudiante almacenado"
        Try
            comando = New SqlCommand("Insert into persona.estudiante(codigo,nombre,primerApellido,segundoApellido,edad,sexo,codigoClase) values '" & codigo & "', '" & nombre & "','" & Apellido1 & "','" & Apellido2 & "','" & edad & "','" & sexo & "','" & codicoClase & "')", conexion)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            mensaje = "No se incerto por : " + ex.ToString
        End Try
        Return mensaje
    End Function


End Class
