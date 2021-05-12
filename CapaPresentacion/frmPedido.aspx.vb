Public Class frmPedido
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim pedido1 As New CapaNegocio.Pedido

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        pedido1.Id = txtId.Text.Trim
        pedido1.Estado = txtEstado.Text.Trim
        pedido1.FechaRealizacion = txtFechaRealizacion.Text.Trim
        pedido1.Total = txtTotal.Text.Trim
        Response.Write("<script>alert('" + "Se  agregaron correctamente los datos" + "')</script>")
    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        Response.Write("ID: " + pedido1.Id + "Estado: " + pedido1.Estado _
                      + "Fecha Realización: " + pedido1.FechaRealizacion + "Total: " + pedido1.Total)
    End Sub

    Protected Sub btnDescripcion_Click(sender As Object, e As EventArgs) Handles btnDescripcion.Click
        Response.Write("<script>alert('" + pedido1.Descripcion() + "')</script>")
    End Sub

    Protected Sub btnCancelacion_Click(sender As Object, e As EventArgs) Handles btnCancelacion.Click
        Response.Write("<script>alert('" + pedido1.Cancelacion() + "')</script>")
    End Sub

    Protected Sub btnCotizar_Click(sender As Object, e As EventArgs) Handles btnCotizar.Click
        Response.Write("<script>alert('" + pedido1.Cotizar() + "')</script>")
    End Sub

    Protected Sub btnActualizacionStock_Click(sender As Object, e As EventArgs) Handles btnActualizacionStock.Click
        Response.Write("<script>alert('" + pedido1.ActualizacionStock() + "')</script>")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class