Public Class frm_menu

    Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
        nombre = tbx_nombre.Text

        If (tbx_nombre.Text = "") Then
            MsgBox("¡Por favor ingrese su nombre antes de continuar!")
        Else
            frm_bisiesto.Show()
            Me.Close()
        End If
    End Sub
End Class