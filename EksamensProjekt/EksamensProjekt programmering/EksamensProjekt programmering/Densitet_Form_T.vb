Public Class Densitet_Form_T



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
        p_Rho = m_Masse / V_Rumfang
    End Sub

    Private Sub Beregn_Densitet_Væsker_But_Click(sender As Object, e As EventArgs) Handles Beregn_Densitet_Væsker_But.Click
        BeregnDensitetVæsker()
        Densitet_Total_lbl.Text = p_Rho.ToString()
        'm_Masse = Nothing
        'V_Rumfang = Nothing
        'p_Rho = Nothing
    End Sub


#End Region


#Region "Densitet Gasser"
    Private Sub Densitet_Molmasse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Molmasse_TextBox.TextChanged
        m_MolMasse = Val(Densitet_Molmasse_TextBox.Text)
    End Sub

    Private Sub Densitet_Gaskonstanten_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Gaskonstanten_TextBox.TextChanged
        R_Gaskonstant = Val(Densitet_Gaskonstanten_TextBox.Text)
    End Sub

    Private Sub Densitet_Tryk_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Tryk_TextBox.TextChanged
        p_Tryk = Val(Densitet_Tryk_TextBox.Text)
    End Sub

    Private Sub Densitet_Temperatur_K_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Densitet_Temperatur_K_TextBox.TextChanged
        T_Kelvin = Val(Densitet_Temperatur_K_TextBox.Text)

    End Sub

    Public Sub BeregnDensitetGasser()
        p_Rho = (m_MolMasse / R_Gaskonstant) * (p_Tryk / T_Kelvin)
    End Sub

    Private Sub Beregn_Densitet_Gasser_But_Click(sender As Object, e As EventArgs) Handles Beregn_Densitet_Gasser_But.Click
        BeregnDensitetGasser()
        Densitet_Gas_Total_lbl.Text = p_Rho * 1000.ToString() & "Kg/m3"
    End Sub



#End Region


End Class