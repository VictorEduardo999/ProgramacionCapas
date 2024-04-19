Imports CapaEntidad

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    'Declaramos el objeto persona
    Dim persona1 As New Persona()
    Protected Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        persona1.Apellidos = txtNombre2.Text
        persona1.Nombres = txtNombre2.Text
        persona1.Edad = txtEdad2.Text
        lblResul.Text = "Persona registrada correctamente"
    End Sub

    Protected Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        lblResul.Text = persona1.DevolverDatos()

    End Sub
End Class