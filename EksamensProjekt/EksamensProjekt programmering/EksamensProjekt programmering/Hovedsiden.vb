Public Class Hoved_Form
#Region "Troels knapper"
    Private Sub Densitet_But_Click(sender As Object, e As EventArgs) Handles Densitet_But.Click
        Densitet_Form_T.Show()
    End Sub

    Private Sub Specifik_Varmekapacitet_But_Click(sender As Object, e As EventArgs) Handles Varme_But.Click
        Varme_T.Show()
    End Sub

    Private Sub Tryk_But_Click(sender As Object, e As EventArgs) Handles Tryk_But.Click
        Tryk_Form_T.Show()
    End Sub



#End Region

End Class
