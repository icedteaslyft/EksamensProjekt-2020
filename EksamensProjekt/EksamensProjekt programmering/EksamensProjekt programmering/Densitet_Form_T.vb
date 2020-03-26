Public Class Densitet_Form_T



#Region "Knapper"
    Private Sub Hovedside_But_Click(sender As Object, e As EventArgs) Handles Hovedside_But.Click
        Me.Hide()
        Hoved_Form.Show()

    End Sub

    Private Sub Tryk_But_Click(sender As Object, e As EventArgs) Handles Tryk_But.Click
        Me.Hide()
        Tryk_Form_T.Show()

    End Sub

    Private Sub Varme_But_Click(sender As Object, e As EventArgs) Handles Varme_But.Click
        Me.Hide()
        Varme_Form_T.Show()

    End Sub

    Private Sub Densitet_But_Click(sender As Object, e As EventArgs) Handles Densitet_But.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Gnidning_But_Click(sender As Object, e As EventArgs) Handles Gnidning_But.Click
        Me.Hide()
        Gnidningskraft_Form_R.Show()

    End Sub

    Private Sub Tyngde_But_Click(sender As Object, e As EventArgs) Handles Tyngde_But.Click
        Me.Hide()
        Tyngdekraft_Form_R.Show()
    End Sub
#End Region


End Class