Public Class Arreglos
    'Variables Globales
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        'Arreglo unidimensional
        Dim Computadoras(3) As String
        Computadoras(0) = " Toshiba "
        Computadoras(1) = " Dell "
        Computadoras(2) = " Asus "
        Computadoras(3) = " MAC "

        For i = 0 To (Computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(Computadoras(i))
        Next
        btnGenerar.Enabled = False
    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        Dim Precio(3) As Integer
        Precio(0) = 22500
        Precio(1) = 21000
        Precio(2) = 29000
        Precio(3) = 42000
        For i = 0 To (Precio.Length - 1) Step 1
            cmbPrecio.Items.Add(Precio(i))
        Next
        btnPrecios.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmbComputadoras.Items.Clear()
        cmbPrecio.Items.Clear()
        btnPrecios.Enabled = True
        btnGenerar.Enabled = True
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim Cant As Integer
        Dim Compu() As String
        'Le asignamos el tamaño
        Cant = Val(txtCantidad.Text)
        'Redim: Para asignarle otro valor a la misma variable
        ReDim Compu(Cant - 1)
        'Llenar el combobox mediante un inputbox
        For i = 0 To (Compu.Length - 1) Step 1
            Compu(i) = InputBox("Ingrese la marca de la pc", " Ingresar ")
        Next
        'Mostrar los datos en el combobox
        For c = 0 To (Compu.Length - 1) Step 1
            cmbCompus.Items.Add(Compu(c))
        Next
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCanIngresar.Text)
        ReDim mComputadoras(cantComputadoras, 3)

        'Llenar los campos Marca, Modelo, Precio y cantidad
        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese la modelo N." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese la precio N." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
            index = i
        Next

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Marca As String
        Marca = txtMarca.Text

        For i = 0 To (cantComputadoras - 1) Step 1
            If (mComputadoras(i, 0) = Marca) Then
                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(i, 2)
                txtCntidad.Text = mComputadoras(i, 3)

                encuentra = True
                btnVender.Enabled = True

            End If
        Next
    End Sub

End Class