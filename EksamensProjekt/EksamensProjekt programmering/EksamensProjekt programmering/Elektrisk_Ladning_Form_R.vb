Public Class Elektrisk_Ladning_Form_R

    Private Sub Elektrisk_Ladning_Form_R_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        p_Rho = Nothing
        m_MolMasse = Nothing
        p_Tryk = Nothing
        T_Kelvin = Nothing
        m_Masse = Nothing
        V_Rumfang = Nothing
        Q_Tilførtvarme = Nothing
        DT_Temperaturstigning = Nothing
        c_Specifik_Varmekapacitet = Nothing
        c_Varmekapacitet = Nothing
        F_Kraft = Nothing
        A_Areal = Nothing
        h_Højde = Nothing
        p_VæskeTryk = Nothing
        g_TyngdeAcceleration = Nothing
    End Sub

    Private Sub Elektrisk_Ladning_Form_R_Load(sender As Object, e As EventArgs) Handles Me.Load
        KanRegne = True
    End Sub


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
        Gnidningskraft_Form_R.Show()
    End Sub

    Private Sub Elektrisk_Ladning_But_Click(sender As Object, e As EventArgs) Handles Elektrisk_Ladning_But.Click
        Me.Hide()
        Me.Show()
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


    Private Sub Beregn_Elektrisk_Ladning_But_Click(sender As Object, e As EventArgs) Handles Beregn_Elektrisk_Ladning_But.Click
        'Kalder sub rutinen "CheckVariabler"
        CheckVariabler()
        'Kalder sub routinen "BeregnElektriskLadning" 
        BeregnElektriskLadning()
        'Sætter total labellet til at være lig med den globale variabel Q_ElektriskLadning som 
        'bliver konverteret til en string og sat til kun at have 4 decimaler. Og derefter sætter C bagved som står for Coulomb.
        Elektrisk_Ladning_Total_lbl.Text = Q_ElektriskLadning.ToString("F4") & " C"

        If KanRegne = False Then
            KanRegne = True
        End If

    End Sub

    Public Sub BeregnElektriskLadning()
        'Sætter den globale variabel Q_ElektriskLadning til at være lig med t_DeltaTid ganget med I_Strømstyrke som begge er globale variabler.

        If KanRegne = True Then
            Q_ElektriskLadning = t_DeltaTid * I_Strømstyrke
        End If
    End Sub

    Private Sub Elektrisk_Ladning_Tid_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Elektrisk_Ladning_Tid_TextBox.TextChanged
        'Sætter den globale variabel t_DeltaTid til at være lig med de tal som er tekstboksen til Delta Tid, som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        t_DeltaTid = Val(Elektrisk_Ladning_Tid_TextBox.Text.ToString())
    End Sub

    Private Sub Elektrisk_Ladning_Strømstyrke_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Elektrisk_Ladning_Strømstyrke_TextBox.TextChanged
        'Sætter den globale variabel I_Strømstyrke til at være lig med de tal som er tekstboksen til massen som er brugerens input. 
        'Og den bliver opdateret hver gang værdien bliver ændret.
        I_Strømstyrke = Val(Elektrisk_Ladning_Strømstyrke_TextBox.Text.ToString())
    End Sub

#Region "Sub Rutine"

    Private Sub CheckVariabler()
        If I_Strømstyrke = Nothing Or t_DeltaTid = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            Q_ElektriskLadning = Nothing
        End If

    End Sub
#End Region

End Class