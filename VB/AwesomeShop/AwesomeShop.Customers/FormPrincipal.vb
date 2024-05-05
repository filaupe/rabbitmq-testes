Public Class FormPrincipal
    Private _publisher As Publisher

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        Dim msg As String = TextBoxMsgs.Text
        Dim sucess As Boolean = _publisher.PublishMsg(msg)
        If sucess Then
            DataGridViewMsgs.Rows.Add(msg)
        Else
            MsgBox("Falha ao enviar mensagem!")
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _publisher = New Publisher()
    End Sub
End Class
