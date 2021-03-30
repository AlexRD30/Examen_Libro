Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection
    Public Sub conectar()


        Try
            cn.ConnectionString = "Data Source=DESKTOP-89EEBFB;Initial Catalog=libros;Integrated Security=True"
            cn.Open()
            MessageBox.Show(cn.State.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Module
