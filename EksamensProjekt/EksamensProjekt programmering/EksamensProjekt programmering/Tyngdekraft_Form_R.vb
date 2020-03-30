Public Class Tyngdekraft_Form_R
    Private Sub Beregn_Tyngdekraft_But_Click(sender As Object, e As EventArgs) Handles Beregn_Tyngdekraft_But.Click
        'Kalder sub routinen "BeregnTyngdekraft" 
        BeregnTyngdekraft()
        'Sætter 
        Tyngdekraft_Total_lbl.Text = F_Kraft.ToString("F4")
    End Sub

    Public Sub BeregnTyngdekraft()
        F_Kraft = m_Masse * g_TyngdeAcceleration
    End Sub

    Private Sub Tyngdekraft_Masse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tyngdekraft_Masse_TextBox.TextChanged
        m_Masse = Val(Tyngdekraft_Masse_TextBox.Text.ToString())
    End Sub

    Private Sub Tyngdekraft_Tyngdeacceleration_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tyngdekraft_Tyngdeacceleration_TextBox.TextChanged
        g_TyngdeAcceleration = Val(Tyngdekraft_Tyngdeacceleration_TextBox.Text.ToString())
    End Sub
End Class