Imports System.Data.OleDb
Public Class frmPedidos

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "PedidosClientes"

            Adaptador = New OleDb.OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim Tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = Tabla.NewRow()
            Fila("IdNombre") = txtCliente.Text
            Fila("IdVariedad") = cmbVariedad.SelectedItem
            Fila("IdTamaño") = cmbTamano.SelectedItem
            Tabla.Rows.Add(Fila)



            Dim ComandoParaGrabar As New OleDbCommandBuilder(Adaptador)
            Adaptador.Update(DS)

            Conexion.Close()
            MessageBox.Show("Pedido Cargado")
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

        txtCliente.Text = ""
        cmbVariedad.SelectedIndex = 0
        cmbTamano.SelectedIndex = 0
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "PedidosClientes"

            Adaptador = New OleDb.OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            dgvPedidos.DataSource = DS.Tables(0)


            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class
