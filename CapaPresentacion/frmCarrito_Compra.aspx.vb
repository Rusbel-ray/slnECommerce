Public Class frmCarrito_Compra
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim carrito_compra1 As New CapaNegocio.Carrito_Compra

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        'Leer los atributos de la clase
        carrito_compra1.CantidadProductos = txtCantidadProductos.Text.Trim
        carrito_compra1.FechaCreacion = txtFechaCreacion.Text.Trim
        MsgBox("Se  agregaron correctamente los datos")

    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        Response.Write("Cantidad de Productos: " + carrito_compra1.CantidadProductos +
                       "fecha de creacion: " + carrito_compra1.FechaCreacion)

    End Sub

    Protected Sub btnAlmacenar_Click(sender As Object, e As EventArgs) Handles btnAlmacenar.Click
        Response.Write("<script>alert('" + carrito_compra1.Almacenar() + "')</script>")
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Response.Write("<script>alert('" + carrito_compra1.Registrar() + "')</script>")
    End Sub

    Protected Sub btnDetallar_Click(sender As Object, e As EventArgs) Handles btnDetallar.Click
        Response.Write("<script>alert('" + carrito_compra1.Detallar() + "')</script>")

    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class