Public Class frmPago
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim pago1 As New CapaNegocio.Pago

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        pago1.Id = txtId.Text.Trim
        pago1.FechaPago = txtFechaPago.Text.Trim
        pago1.Pagos = txtPago.Text.Trim
        Response.Write("<script>alert('" + "Se  agregaron correctamente los datos" + "')</script>")
    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click
        Response.Write("ID: " + pago1.Id + "Fecha de Pago: " + pago1.FechaPago _
                      + "Pago: " + pago1.Pagos)
    End Sub
    Protected Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        Response.Write("<script>alert('" + pago1.CancelarPago() + "')</script>")
    End Sub
    Protected Sub btnMetodoPago_Click(sender As Object, e As EventArgs) Handles btnMetodoPago.Click
        Response.Write("<script>alert('" + pago1.MetodoPago() + "')</script>")
    End Sub
    Protected Sub btnReembolso_Click(sender As Object, e As EventArgs) Handles btnReembolso.Click
        Response.Write("<script>alert('" + pago1.Reembolso() + "')</script>")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class