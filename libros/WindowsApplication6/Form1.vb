Imports System.Data.SqlClient
Public Class form
    Private Sub txtaño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        mostrardatos()
    End Sub
    Sub mostrardatos()
        Dim dat As New SqlDataAdapter(" select * from libro ", cn)
        Dim d As New DataSet
        dat.Fill(d)
        DataGridView1.DataSource = d.Tables(0)
        DataGridView1.Columns("codigo").HeaderText = "Código"
        DataGridView1.Columns("editoria").HeaderText = "Editoria"
        DataGridView1.Columns("autor").HeaderText = "Autor"
        DataGridView1.Columns("año").HeaderText = "Edad"
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        limpiar()
    End Sub
    Sub limpiar()
        txtanio.Clear()
        txtcodigo.Clear()
        txteditoria.Clear()
        txtautor.Clear()
    End Sub
    Private Sub cmdinsertar_Click(sender As Object, e As EventArgs) Handles cmdinsertar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandText = " insert into libro (Editoria, Autor, Año) values ('" & txteditoria.Text & "','" & txtautor.Text & "'," & txtanio.Text & " ) "
            cmd.Parameters.AddWithValue("@editoria", txteditoria.Text)
            cmd.Parameters.AddWithValue("@apellido", txtautor.Text)
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            cmd.ExecuteNonQuery()
            Dim fila As Integer
            If fila > 0 Then
                MessageBox.Show("Datos guardados")
            End If
            MessageBox.Show("Datos guardados")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = " update libro set Editoria='" & txteditoria.Text & "',Autor='" & txtautor.Text & "',Año=" & txtanio.Text & "where codigo='" & txtcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos guardados")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                txtcodigo.Text = DataGridView1.SelectedRows(0).Cells("codigo").Value
                txteditoria.Text = DataGridView1.SelectedRows(0).Cells("editoria").Value
                txtautor.Text = DataGridView1.SelectedRows(0).Cells("autor").Value
                txtanio.Text = DataGridView1.SelectedRows(0).Cells("año").Value
            End If
        End If
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        If MsgBox("Desea eliminar", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "delete from libro where codigo= '" & txtcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos eliminados")
            mostrardatos()
        End If
    End Sub
End Class
