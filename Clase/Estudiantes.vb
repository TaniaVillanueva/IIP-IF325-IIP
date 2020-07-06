Public Class Estudiantes
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable

    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        'mostrarDatos()
    End Sub

    Private Sub mostrarDatos()

    End Sub

End Class