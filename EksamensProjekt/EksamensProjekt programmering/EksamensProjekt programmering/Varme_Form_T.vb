﻿Public Class Varme_Form_T



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

    Private Sub TilførtVarme_Temperaturstining_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TilførtVarme_Temperaturstining_TextBox.TextChanged
        DT_Temperaturstigning = Val(TilførtVarme_Temperaturstining_TextBox.Text)
    End Sub

    Private Sub TilførtVarme_Varmekapicitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TilførtVarme_Varmekapicitet_TextBox.TextChanged
        c_Varmekapacitet = Val(TilførtVarme_Varmekapicitet_TextBox.Text)
    End Sub

    Public Sub BeregnTilførtVarme()
        Q_Tilførtvarme = DT_Temperaturstigning * c_Varmekapacitet
    End Sub

    Private Sub Beregn_TilførtVarme_But_Click(sender As Object, e As EventArgs) Handles Beregn_TilførtVarme_But.Click
        BeregnTilførtVarme()
        Tilført_Varme_Total_lbl.Text = Q_Tilførtvarme.ToString & "J"
    End Sub



#End Region

#Region "Varmekapacitet"

    Private Sub Varme_Temperaturstining_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Varme_Temperaturstining_TextBox.TextChanged
        DT_Temperaturstigning = Val(Varme_Temperaturstining_TextBox.Text)
    End Sub

    Private Sub Tilført_Varme_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tilført_Varme_TextBox.TextChanged
        Q_Tilførtvarme = Val(Tilført_Varme_TextBox.Text)
    End Sub
    Public Sub BeregnVarmeKapacitet()
        c_Varmekapacitet = Q_Tilførtvarme / DT_Temperaturstigning
    End Sub

    Private Sub Beregn_Varmekapacitet_But_Click(sender As Object, e As EventArgs) Handles Beregn_Varmekapacitet_But.Click
        BeregnVarmeKapacitet()
        Varmekapacitet_Total_lbl.Text = c_Varmekapacitet.ToString & "kJ/Celsius"
    End Sub

#End Region

#Region "Specifik Varmekapacitet"


    Private Sub Masse_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Masse_TextBox.TextChanged
        m_Masse = Val(Masse_TextBox.Text)
    End Sub

    Private Sub SpecifikVarme_Varmekapacitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles SpecifikVarme_Varmekapacitet_TextBox.TextChanged
        c_Varmekapacitet = Val(SpecifikVarme_Varmekapacitet_TextBox.Text)
    End Sub

    Public Sub BeregnSpecifikVarmeKapacitet()
        c_Specifik_Varmekapacitet = c_Varmekapacitet / m_Masse
    End Sub
    Private Sub Beregn_SpecifikVarme_But_Click(sender As Object, e As EventArgs) Handles Beregn_SpecifikVarme_But.Click
        BeregnSpecifikVarmeKapacitet()
        Specifik_Varmekapacitet_Total_lbl.Text = c_Specifik_Varmekapacitet.ToString & "kJ/(kg*Celsius)"
    End Sub


#End Region


End Class