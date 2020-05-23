Public Class frm_bisiesto
    Private Sub frm_bisiesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_bienvenida.Text = ("¡Bienvenido " & nombre & "!")
    End Sub
    Public Function es_bisiesto() As Boolean
        Dim Año As Integer
        Año = tbx_año.Text
        If (Año Mod 4) = 0 Then
            es_bisiesto = True
        Else
            es_bisiesto = False
        End If
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim Año As Integer
        Año = tbx_año.Text

        If (es_bisiesto() = True) Then
            lbl_Resultado.Text = ("¡El año " & Año & " es bisiesto!")
            lbl_agradecer.Show()
            lbl_nombre.Show()
            lbl_alumno.Show()
        Else
            lbl_Resultado.Text = ("¡El año " & Año & " no es bisiesto!")
            lbl_agradecer.Show()
            lbl_nombre.Show()
            lbl_alumno.Show()
        End If

    End Sub
End Class