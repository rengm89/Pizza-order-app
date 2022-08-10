Imports System.Data.OleDb
Module DatosGlobales
    Public Comando As New OleDbCommand
    Public Conexion As New OleDbConnection
    Public Adaptador As New OleDbDataAdapter

    Public DR As OleDbDataReader
    Public DS As DataSet

    Public CadenaDeConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Pedidos.accdb"
End Module
