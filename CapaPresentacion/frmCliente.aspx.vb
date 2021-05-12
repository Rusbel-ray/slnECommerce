Public Class frmCliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Dim cliente1 As New CapaNegocio.Cliente

    Protected Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        cliente1.Id = txtId.Text.Trim
        cliente1.Direccion = txtDireccion.Text.Trim
        cliente1.Email = txtEmail.Text.Trim
        cliente1.Telefono = txtTelefono.Text.Trim
        MsgBox("Se han leido correctamente los datos de Cliente")

    End Sub

    Protected Sub btnEscribir_Click(sender As Object, e As EventArgs) Handles btnEscribir.Click

        MsgBox(" Id: " + cliente1.Id + " Direccion: " + cliente1.Direccion +
               " Email: " + cliente1.Email + " Telefono: " + cliente1.Telefono)


    End Sub

    Protected Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox(cliente1.Comprar)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MsgBox(cliente1.Buscar)
    End Sub

    Protected Sub btnRecomendar_Click(sender As Object, e As EventArgs) Handles btnRecomendar.Click
        MsgBox(cliente1.Recomendar)
    End Sub

    Protected Sub btnReclamar_Click(sender As Object, e As EventArgs) Handles btnReclamar.Click
        MsgBox(cliente1.Reclamar)
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Llamar al formulario de Principal
        Response.Redirect("frmPrincipal.aspx")
    End Sub
End Class
