Public Class frmProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim producto1 As New CapaNegocio.Producto

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        producto1.Id = txtId.Text.Trim
        producto1.Calidad = txtCalidad.Text.Trim
        producto1.Denominacion = txtDenominacion.Text.Trim
        producto1.Proveedor = txtProveedor.Text.Trim
        Response.Write("<script>alert('" + "Se  agregaron correctamente los datos" + "')</script>")
    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        Response.Write("ID: " + producto1.Id + "Calidad: " + producto1.Calidad _
                      + "Denominacion: " + producto1.Denominacion + "Proveedor: " + producto1.Proveedor)
    End Sub

    Protected Sub btnDeteriorar_Click(sender As Object, e As EventArgs) Handles btnDeteriorar.Click
        Response.Write("<script>alert('" + producto1.Deteriorar() + "')</script>")
    End Sub

    Protected Sub btnDestacar_Click(sender As Object, e As EventArgs) Handles btnDestacar.Click
        Response.Write("<script>alert('" + producto1.Destacar() + "')</script>")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class