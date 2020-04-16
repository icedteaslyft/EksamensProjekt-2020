Public Class Varme_Form_T
    'Starter ud med at sætte KanRegne bool til sandt
    Private Sub Varme_Form_T_Load(sender As Object, e As EventArgs) Handles Me.Load
        KanRegne = True
    End Sub

    'Sætter alle variabler i programmet til deres standard værdier (i dette tilfælde til ingenting)
    Private Sub Varme_Form_T_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
        Me.Show()
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

#Region "Tilført Varme"
    'Sætter værdien til det tekstboksens input modtager
    Private Sub TilførtVarme_Temperaturstining_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TilførtVarme_Temperaturstining_TextBox.TextChanged
        DT_Temperaturstigning = Val(TilførtVarme_Temperaturstining_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub TilførtVarme_Varmekapicitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TilførtVarme_Varmekapicitet_TextBox.TextChanged
        c_Varmekapacitet2 = Val(TilførtVarme_Varmekapicitet_TextBox.Text)
    End Sub

    'En Subrutine der laver udregningen for Tilført Varme
    'Den tjekker om KanRegne er sandt. I det tilfælde laver den udregningen.
    Public Sub BeregnTilførtVarme()
        If KanRegne = True Then
            Q_Tilførtvarme = DT_Temperaturstigning * c_Varmekapacitet2
        End If

    End Sub

    'Denne knap aktivere Subrutinerne "Checkvariabler" og "Beregn" 
    'Den sætter også teksten i "Total" labelen til hvad end værdien Q_Tilførtvarme er
    'Den tjekker tilsidst om Kanregne er Falsk, og hvis den er det, så sætter den KanRegne til sandt igen
    Private Sub Beregn_TilførtVarme_But_Click(sender As Object, e As EventArgs) Handles Beregn_TilførtVarme_But.Click
        CheckVariablerTilførtVarme()
        BeregnTilførtVarme()
        Tilført_Varme_Total_lbl.Text = Q_Tilførtvarme.ToString & "J"

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub

#End Region

#Region "Varmekapacitet"
    'Sætter værdien til det tekstboksens input modtager
    Private Sub Varme_Temperaturstining_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Varme_Temperaturstining_TextBox.TextChanged
        DT_Temperaturstigning2 = Val(Varme_Temperaturstining_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub Tilført_Varme_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tilført_Varme_TextBox.TextChanged
        Q_Tilførtvarme2 = Val(Tilført_Varme_TextBox.Text)
    End Sub

    'En Subrutine der laver udregningen for Varme Kapacitet
    'Den tjekker om KanRegne er sandt. I det tilfælde laver den udregningen.
    Public Sub BeregnVarmeKapacitet()
        If KanRegne = True Then
            c_Varmekapacitet = Q_Tilførtvarme2 / DT_Temperaturstigning2
        End If

    End Sub

    'Denne knap aktivere Subrutinerne "Checkvariabler" og "Beregn" 
    'Den sætter også teksten i "Total" labelen til hvad end værdien c_Varmekapacitet er
    'Den tjekker tilsidst om Kanregne er Falsk, og hvis den er det, så sætter den KanRegne til sandt igen
    Private Sub Beregn_Varmekapacitet_But_Click(sender As Object, e As EventArgs) Handles Beregn_Varmekapacitet_But.Click
        CheckVariablerVarmekapacitet()
        BeregnVarmeKapacitet()
        Varmekapacitet_Total_lbl.Text = c_Varmekapacitet.ToString & "kJ/Celsius"

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub

#End Region

#Region "Specifik Varmekapacitet"

    'Sætter værdien til det tekstboksens input modtager
    Private Sub Masse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Masse_TextBox.TextChanged
        m_Masse = Val(Masse_TextBox.Text)
    End Sub

    'Sætter værdien til det tekstboksens input modtager
    Private Sub SpecifikVarme_Varmekapacitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles SpecifikVarme_Varmekapacitet_TextBox.TextChanged
        c_Varmekapacitet3 = Val(SpecifikVarme_Varmekapacitet_TextBox.Text)
    End Sub

    'En Subrutine der laver udregningen for Specifik Varmekapacitet
    'Den tjekker om KanRegne er sandt. I det tilfælde laver den udregningen.
    Public Sub BeregnSpecifikVarmeKapacitet()
        If KanRegne = True Then
            c_Specifik_Varmekapacitet = c_Varmekapacitet3 / m_Masse
        End If

    End Sub

    'Denne knap aktivere Subrutinerne "Checkvariabler" og "Beregn" 
    'Den sætter også teksten i "Total" labelen til hvad end værdien c_Specifik_Varmekapacitet er
    'Den tjekker tilsidst om Kanregne er Falsk, og hvis den er det, så sætter den KanRegne til sandt igen
    Private Sub Beregn_SpecifikVarme_But_Click(sender As Object, e As EventArgs) Handles Beregn_SpecifikVarme_But.Click
        CheckVariablerSpecifikVarme()
        BeregnSpecifikVarmeKapacitet()
        Specifik_Varmekapacitet_Total_lbl.Text = c_Specifik_Varmekapacitet.ToString & "kJ/(kg*Celsius)"

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
#Region "Subrutiner"
    Private Sub CheckVariablerTilførtVarme()
        If DT_Temperaturstigning = Nothing Or c_Varmekapacitet2 = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            Q_Tilførtvarme = Nothing
        End If

    End Sub

    Private Sub CheckVariablerVarmekapacitet()
        If Q_Tilførtvarme2 = Nothing Or DT_Temperaturstigning2 = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            c_Varmekapacitet = Nothing
        End If

    End Sub
    Private Sub CheckVariablerSpecifikVarme()
        If c_Varmekapacitet3 = Nothing Or m_Masse = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
            c_Specifik_Varmekapacitet = Nothing
        End If

    End Sub

#End Region

End Class