Public Class Gnidningskraft_Form_R

#Region "Knapper"

    Private Sub Hovedside_But_Click_1(sender As Object, e As EventArgs) Handles Hovedside_But.Click
        Me.Hide()
        Hoved_Form.Show()
    End Sub

    Private Sub Tyngde_But_Click_1(sender As Object, e As EventArgs) Handles Tyngde_But.Click
        Me.Hide()
        Tyngdekraft_Form_R.Show()
    End Sub

    Private Sub Gnidningskraft_But_Click(sender As Object, e As EventArgs) Handles Gnidningskraft_But.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Elektrisk_Ladning_But_Click(sender As Object, e As EventArgs) Handles Elektrisk_Ladning_But.Click
        Me.Hide()
        Elektrisk_Ladning_Form_R.Show()
    End Sub

    Private Sub Densitet_But_Click_1(sender As Object, e As EventArgs) Handles Densitet_But.Click
        Me.Hide()
        Densitet_Form_T.Show()
    End Sub

    Private Sub Varme_But_Click_1(sender As Object, e As EventArgs) Handles Varme_But.Click
        Me.Hide()
        Varme_Form_T.Show()
    End Sub

    Private Sub Tryk_But_Click_1(sender As Object, e As EventArgs) Handles Tryk_But.Click
        Me.Hide()
        Tryk_Form_T.Show()
    End Sub

    Private Sub Gravitation_But_Click(sender As Object, e As EventArgs) Handles Gravitation_But.Click
        Me.Hide()
        Gravitation_Form_D.Show()
    End Sub

    Private Sub Idealgasser_But_Click(sender As Object, e As EventArgs) Handles Idealgasser_But.Click
        Me.Hide()
        Idealgasser__Form_D.Show()
    End Sub

    Private Sub Interferens_But_Click(sender As Object, e As EventArgs) Handles Interferens_But.Click
        Me.Hide()
        Interferens_Form_D.Show()
    End Sub




#End Region

    Private Sub Beregn_Gnidningskraft_But_Click(sender As Object, e As EventArgs) Handles Beregn_Gnidningskraft_But.Click
        'Kalder sub routinen "BeregnGnidningskraft" 
        BeregnGnidningskraft()
        'Sætter total labellet til at være lig med den globale variabel F_Gnidningskraft som 
        'bliver konverteret til en string og sat til kun at have 4 decimaler. Og derefter sætter N bagved som står for Newton.
        Gnidningskraft_Total_lbl.Text = F_Gnidningskraft.ToString("F4") & " N"
    End Sub

    Public Sub BeregnGnidningskraft()
        'Sætter den globale variabel F_Gnidningskraft til at være lig med My_Gnidningskoefficient ganget med Fn_Normalkraft som begge er globale variabler.
        F_Gnidningskraft = My_Gnidningskoefficient * Fn_Normalkraft
    End Sub

    Private Sub Gnidningskraft_My_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Gnidningskraft_My_TextBox.TextChanged
        'Sætter den globale variabel My_Gnidningskoefficient til at være lig med de tal som er tekstboksen til gnidningskoefficienten, som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        My_Gnidningskoefficient = Val(Gnidningskraft_My_TextBox.Text.ToString())
    End Sub

    Private Sub Gnidningskraft_Normalkraften_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Gnidningskraft_Normalkraften_TextBox.TextChanged
        'Sætter den globale variabel Fn_Normalkraft til at være lig med de tal som er tekstboksen til Normalkraften, som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        Fn_Normalkraft = Val(Gnidningskraft_Normalkraften_TextBox.Text.ToString())
    End Sub

End Class