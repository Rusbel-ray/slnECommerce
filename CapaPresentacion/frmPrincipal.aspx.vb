Public Class frmPrincipal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCarritoCompras_Click(sender As Object, e As EventArgs) Handles btnCarritoCompras.Click
        'Llamar al formulario de pedido
        Response.Redirect("frmCarrito_Compra.aspx")
    End Sub

    Protected Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        'Llamar al formulario de Cliente
        Response.Redirect("frmCliente.aspx")
    End Sub

    Protected Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        'Llamar al formulario de Producto
        Response.Redirect("frmProducto.aspx")
    End Sub

    Protected Sub btnLineaProducto_Click(sender As Object, e As EventArgs) Handles btnLineaProducto.Click
        'Llamar al formulario de LineaProducto
        Response.Redirect("frmLineaProducto.aspx")
    End Sub

    Protected Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        'Llamar al formulario de Pago
        Response.Redirect("frmPago.aspx")
    End Sub

    Protected Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        'Llamar al formulario de pedido
        Response.Redirect("frmPedido.aspx")
    End Sub

    Protected Sub btnEnvio_Click(sender As Object, e As EventArgs) Handles btnEnvio.Click
        'Llamar al formulario de Envio
        Response.Redirect("frmEnvio.aspx")
    End Sub
End Class