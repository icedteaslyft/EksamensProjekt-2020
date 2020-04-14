Imports System.ComponentModel

Public Class Densitet_Form_T

    Private Sub Densitet_Form_T_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KanRegne = True
    End Sub

    'Sætter alle variabler til "Nothing" når man lukker formen
    Private Sub Densitet_Form_T_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
#Region "Knapper"

    Private Sub Hovedside_But_Click_1(sender As Object, e As EventArgs) Handles Hovedside_But.Click
        Me.Close()
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
        Elektrisk_Ladning_Form_R.Show()
    End Sub

    Private Sub Densitet_But_Click_1(sender As Object, e As EventArgs) Handles Densitet_But.Click
        Me.Hide()
        Me.Show()
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

#Region "Densitet Væsker"
    Private Sub Densitet_Masse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Masse_TextBox.TextChanged
        m_Masse = Val(Densitet_Masse_TextBox.Text)
    End Sub

    Private Sub Densitet_Rumfang_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Rumfang_TextBox.TextChanged
        V_Rumfang = Val(Densitet_Rumfang_TextBox.Text)
    End Sub

    Public Sub BeregnDensitetVæsker()

        If KanRegne = True Then
            p_Rho = m_Masse / V_Rumfang
        End If

    End Sub

    Private Sub Beregn_Densitet_Væsker_But_Click(sender As Object, e As EventArgs) Handles Beregn_Densitet_Væsker_But.Click
        CheckVariablerVæsker()
        BeregnDensitetVæsker()
        Densitet_Total_lbl.Text = p_Rho.ToString("F4")

        If KanRegne = False Then
            KanRegne = True
        End If

    End Sub



#End Region


#Region "Densitet Gasser"
    Private Sub Densitet_Molmasse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Molmasse_TextBox.TextChanged
        m_MolMasse = Val(Densitet_Molmasse_TextBox.Text)
    End Sub

    Private Sub Densitet_Tryk_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Tryk_TextBox.TextChanged
        p_Tryk = Val(Densitet_Tryk_TextBox.Text)
    End Sub

    Private Sub Densitet_Temperatur_K_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Temperatur_K_TextBox.TextChanged
        T_Kelvin = Val(Densitet_Temperatur_K_TextBox.Text)

    End Sub

    Public Sub BeregnDensitetGasser()

        If KanRegne = True Then
            p_Rho = (m_MolMasse / R_Gaskonstant) * (p_Tryk / T_Kelvin)
        End If


    End Sub

    Private Sub Beregn_Densitet_Gasser_But_Click(sender As Object, e As EventArgs) Handles Beregn_Densitet_Gasser_But.Click
        CheckVariablerGasser()
        BeregnDensitetGasser()
        Densitet_Gas_Total_lbl.Text = p_Rho.ToString("F4") & " Kg/m3"

        If KanRegne = False Then
            KanRegne = True
        End If


    End Sub



#End Region

    Private Sub CheckVariablerVæsker()
        If m_Masse = Nothing Or V_Rumfang = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            p_Rho = Nothing
        End If

    End Sub

    Private Sub CheckVariablerGasser()

        If m_MolMasse = Nothing Or p_Tryk = Nothing Or T_Kelvin = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            p_Rho = Nothing

        End If
    End Sub



End Class