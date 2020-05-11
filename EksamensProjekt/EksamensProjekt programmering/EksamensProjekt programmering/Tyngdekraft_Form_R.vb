Public Class Tyngdekraft_Form_R

    'Den globale bool "KanRegne" bliver sat til at være true når formen startes.
    Private Sub Tyngdekraft_Form_R_Load(sender As Object, e As EventArgs) Handles Me.Load
        KanRegne = True
    End Sub

    'Alle de globale variabler som er i programmet bliver sat til at være ingenting.
    Private Sub Tyngdekraft_Form_R_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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

    'Denne region gør at man kan skifte mellem formene. Dette gør den ved at skjule sig selv og derefter vise den ønskede form.
#Region "Knapper"
    Private Sub Hovedside_But_Click_1(sender As Object, e As EventArgs) Handles Hovedside_But.Click
        Me.Hide()
        Hoved_Form.Show()
    End Sub

    Private Sub Tyngde_But_Click_1(sender As Object, e As EventArgs) Handles Tyngde_But.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Gnidningskraft_But_Click(sender As Object, e As EventArgs) Handles Gnidningskraft_But.Click
        Me.Hide()
        Gnidningskraft_Form_R.Show()
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

    Private Sub Beregn_Tyngdekraft_But_Click(sender As Object, e As EventArgs) Handles Beregn_Tyngdekraft_But.Click
        'Kalder sub rutinen "Checkvariabler"
        CheckVariabler()
        'Kalder sub routinen "BeregnTyngdekraft" 
        BeregnTyngdekraft()
        'Sætter total labellet til at være lig med den globale variabel F_Kraft som 
        'bliver konverteret til en string og sat til kun at have 4 decimaler. Og derefter sætter N bagved som står for newton.
        Tyngdekraft_Total_lbl.Text = F_Kraft.ToString("F4") & " N"

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub

    Public Sub BeregnTyngdekraft()
        'Sætter den globale variabel F_Kraft til at være lig med m_Masse ganget med g_TyngdeAcceleration som begge er globale variabler.
        If KanRegne = True Then
            F_Kraft = m_Masse * g_TyngdeAcceleration
        End If
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

#Region "Subrutine"
    Private Sub CheckVariabler()
        'Først tjekker sub rutinen om de globale variabler "m_Masse" og "g_TyngdeAcceleration" er lig med ingenting.
        'Hvis de er lig med ingenting, så kommer der en besked boks som fortæller brugeren at der mangler værdier.
        'Derefter bliver vores globale bool "KanRegne" sat til at være false, og vores globale variabel "F_Kraft" bliver sat til at være ingenting.
        If m_Masse = Nothing Or g_TyngdeAcceleration = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            F_Kraft = Nothing
        End If
    End Sub
#End Region
End Class