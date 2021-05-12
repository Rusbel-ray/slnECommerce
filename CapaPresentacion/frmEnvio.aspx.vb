Public Class frmEnvio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim envio1 As New CapaNegocio.Envio

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        'Leer los atributos de la clase
        envio1.Id = txtId.Text.Trim
        envio1.Direccionfacturacion = txtDireccionFacturacion.Text.Trim
        envio1.Finalizado = txtFinalizado.Text.Trim
        envio1.Fechaenvio = txtFechaEnvio.Text.Trim
        envio1.Compania = txtCompañia.Text.Trim
        Response.Write("<script>alert('" + "Se  agregaron correctamente los datos" + "')</script>")
    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        'Escribir los atributos del objeto
        Response.Write("ID: " + envio1.Id + "Dirección de Facturacion: " + envio1.Direccionfacturacion _
                       + "Finalizado: " + envio1.Finalizado + "Fecha Envio: " + envio1.Fechaenvio +
                       "Compania: " + envio1.Compania)
    End Sub

    Protected Sub btnEntregarProducto_Click(sender As Object, e As EventArgs) Handles btnEntregarProducto.Click
        Response.Write("<script>alert('" + envio1.EntregarProducto() + "')</script>")
    End Sub

    Protected Sub btnConfirmarEntrega_Click(sender As Object, e As EventArgs) Handles btnConfirmarEntrega.Click
        Response.Write("<script>alert('" + envio1.ConfirmarEntrega() + "')</script>")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class