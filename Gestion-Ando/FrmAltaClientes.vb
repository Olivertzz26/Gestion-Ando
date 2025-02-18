Public Class FrmAltaClientes
    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each ctrl As Control In Me.Controls
            ' Verifica si el control es una caja de texto
            If TypeOf ctrl Is TextBox Then
                ' Borra el texto en la caja de texto
                DirectCast(ctrl, TextBox).Clear()
            End If

            ' Verifica si el control es un ComboBox
            If TypeOf ctrl Is ComboBox Then
                ' Borra la selección del ComboBox nooooooooooooooooooooooo
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            End If
            TXTCODIGO.Focus()
        Next
    End Sub


    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub FrmAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTCODIGO.Focus()
    End Sub
End Class