Public Class Hoved_Form

#Region "Knapper"
    Private Sub Hovedside_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub Tryk_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Tryk_Form_T.Show()

    End Sub

    Private Sub Varme_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Varme_Form_T.Show()

    End Sub

    Private Sub Densitet_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Densitet_Form_T.Show()
    End Sub

    Private Sub Gnidning_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Gnidningskraft_Form_R.Show()

    End Sub

    Private Sub Tyngde_But_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Tyngdekraft_Form_R.Show()
    End Sub
#End Region


End Class
