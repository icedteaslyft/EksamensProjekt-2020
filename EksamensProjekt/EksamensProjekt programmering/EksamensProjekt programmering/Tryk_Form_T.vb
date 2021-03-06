﻿Public Class Tryk_Form_T

    'Starter ud med at sætte KanRegne bool til sandt
    Private Sub Tryk_Form_T_Load(sender As Object, e As EventArgs) Handles Me.Load
        KanRegne = True
    End Sub

    'Sætter alle variabler i programmet til deres standard værdier (i dette tilfælde til ingenting)
    Private Sub Tryk_Form_T_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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

    'Styre alle knapperne imellem formene
#Region "Knapper"
    'Alle knapper følge samme kode, som loader den der bliver trykket på, og lukker sig selv.
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
        Me.Show()
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

#Region "Tryk"
    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tryk_Areal_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Areal_TextBox.TextChanged
        A_Areal = Val(Tryk_Areal_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tryk_Kraft_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Kraft_TextBox.TextChanged
        F_Kraft = Val(Tryk_Kraft_TextBox.Text)
    End Sub

    'En Subrutine der laver udregningen for Tryk
    'Den tjekker om KanRegne er sandt. I det tilfælde laver den udregningen.
    Public Sub BeregnTryk()
        If KanRegne = True Then
            p_Tryk = F_Kraft / A_Areal
        End If

    End Sub

    'Denne knap aktivere Subrutinerne "Checkvariabler" og "Beregn" 
    'Den sætter også teksten i "Total" labelen til hvad end værdien p_Tryk er
    'Den tjekker tilsidst om Kanregne er Falsk, og hvis den er det, så sætter den KanRegne til sandt igen
    Private Sub Tryk_Beregn_But_Click(sender As Object, e As EventArgs) Handles Tryk_Beregn_But.Click
        CheckVariablerTryk()
        BeregnTryk()
        Tryk_Total_lbl.Text = p_Tryk.ToString("F4") & "kPa"

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub

#End Region

#Region "Væske Tryk"
    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tryk_Densitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Densitet_TextBox.TextChanged
        p_Rho = Val(Tryk_Densitet_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tryk_Højde_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Højde_TextBox.TextChanged
        h_Højde = Val(Tryk_Højde_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tryk_Tyngde_Accelerationen_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Tyngde_Accelerationen_TextBox.TextChanged
        g_TyngdeAcceleration = Val(Tryk_Tyngde_Accelerationen_TextBox.Text)
    End Sub

    'En Subrutine der laver udregningen for Væske Tryk
    'Den tjekker om KanRegne er sandt. I det tilfælde laver den udregningen.
    Public Sub BeregnVæskeTryk()
        If KanRegne = True Then
            p_VæskeTryk = p_Rho * h_Højde * g_TyngdeAcceleration
        End If

    End Sub

    'Denne knap aktivere Subrutinerne "Checkvariabler" og "Beregn" 
    'Den sætter også teksten i "Total" labelen til hvad end værdien p_VæskeTryk er
    'Den tjekker tilsidst om Kanregne er Falsk, og hvis den er det, så sætter den KanRegne til sandt igen
    Private Sub Tryk_Væske_Beregn_But_Click(sender As Object, e As EventArgs) Handles Tryk_Væske_Beregn_But.Click
        CheckVariablerVæskeTryk()
        BeregnVæskeTryk()
        Væske_Tryk_Total_lbl.Text = p_VæskeTryk.ToString("F4") & "kPa"

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub
#End Region

    ''Disse subrutiner kræves pr. funktion formen har.
    ''Subrutinen tjekker om dens korresponderende værdier ikke står til ingenting.
    ''Hvis bare en af værdierne står til ingenting, så vil der poppe en beskedboks op 
    'der siger brugeren mangler værdier
    ''Sætter KanRegne til falsk, for at stoppe programmet at lave en udregning den ikke kan.
    'Hvis den gør, bliver totalen til uendeligt)
    ''Og tilsidst sætter totalværdien i den brugte udregning til ingenting.
#Region "Sub Rutiner"

    Private Sub CheckVariablerVæskeTryk()
        If p_Rho = Nothing Or h_Højde = Nothing Or g_TyngdeAcceleration = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            p_VæskeTryk = Nothing
        End If

    End Sub

    Private Sub CheckVariablerTryk()
        If F_Kraft = Nothing Or A_Areal = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            p_Tryk = Nothing
        End If

    End Sub
#End Region
End Class