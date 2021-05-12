Public Class frmLineaProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim lineaproducto1 As New CapaNegocio.LineaProducto

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        lineaproducto1.Cantidad = txtCantidad.Text.Trim
        lineaproducto1.Categoria = txtCategoria.Text.Trim
        lineaproducto1.Precio = txtPrecio.Text.Trim
        Response.Write("<script>alert('" + "Se  agregaron correctamente los datos" + "')</script>")
    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        Response.Write("Cantidad: " + lineaproducto1.Cantidad + "Categoria: " + lineaproducto1.Categoria _
                      + "Precio: " + lineaproducto1.Precio)
    End Sub

    Protected Sub btnActualizarStock_Click(sender As Object, e As EventArgs) Handles btnActualizarStock.Click
        Response.Write("<script>alert('" + lineaproducto1.ActualizarStock() + "')</script>")
    End Sub

    Protected Sub btnReseñas_Click(sender As Object, e As EventArgs) Handles btnReseñas.Click
        Response.Write("<script>alert('" + lineaproducto1.Reseñas() + "')</script>")
    End Sub

    Protected Sub btnComentarios_Click(sender As Object, e As EventArgs) Handles btnComentarios.Click
        Response.Write("<script>alert('" + lineaproducto1.Comentarios() + "')</script>")
    End Sub

    Protected Sub btnDestacar_Click(sender As Object, e As EventArgs) Handles btnDestacar.Click
        Response.Write("<script>alert('" + lineaproducto1.Destacar() + "')</script>")
    End Sub
    Protected Sub btnOfertas_Click(sender As Object, e As EventArgs) Handles btnOfertas.Click
        Response.Write("<script>alert('" + lineaproducto1.Ofertas() + "')</script>")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class