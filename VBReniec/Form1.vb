


Public Class Form1

    Dim servicio As New ServiceReference1.WSReniecSoapClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        DataGridView1.DataSource = servicio.Buscar(txtdni.Text).Tables(0)


    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        txtdni.Text = DataGridView1.CurrentRow.Cells("dni").Value


    End Sub
End Class



