Public Class Tyngdekraft_Form_R
    Private Sub Beregn_Tyngdekraft_But_Click(sender As Object, e As EventArgs) Handles Beregn_Tyngdekraft_But.Click
        'Kalder sub routinen "BeregnTyngdekraft" 
        BeregnTyngdekraft()
        'Sætter total labellet til at være lig med den globale variabel F_Kraft som 
        'bliver konverteret til en string og sat til kun at have 4 decimaler. Og derefter sætter N bagved som står for newton.
        Tyngdekraft_Total_lbl.Text = F_Kraft.ToString("F4") & " N"
    End Sub

    Public Sub BeregnTyngdekraft()
        'Sætter den globale variabel F_Kraft til at være lig med m_Masse ganget med g_TyngdeAcceleration som begge er globale variabler.
        F_Kraft = m_Masse * g_TyngdeAcceleration
    End Sub

    Private Sub Tyngdekraft_Masse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tyngdekraft_Masse_TextBox.TextChanged
        'Sætter den globale variabel m_Masse til at være lig med de tal som er tekstboksen til massen som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        m_Masse = Val(Tyngdekraft_Masse_TextBox.Text.ToString())
    End Sub

    Private Sub Tyngdekraft_Tyngdeacceleration_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tyngdekraft_Tyngdeacceleration_TextBox.TextChanged
        'Sætter den globale variabel g_TyngdeAcceleration til at være lig med de tal som er tekstboksen til tyngdeaccelerationen, som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        g_TyngdeAcceleration = Val(Tyngdekraft_Tyngdeacceleration_TextBox.Text.ToString())
    End Sub
End Class