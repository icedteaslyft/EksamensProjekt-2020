Public Class Idealgasser__Form_D
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

#Region "Idealgas"
    'Værdi til det tekstboksen modtager

    Private Sub R_mol_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R_mol_TextBox.TextChanged
        R_mol = Val(R_mol_TextBox.Text)
    End Sub
    Private Sub n_Stofmængde_Textbox_Textchanged(sender As Object, e As EventArgs) Handles n_Stofmængde_TextBox.TextChanged
        n_Stofmængde = Val(n_Stofmængde_TextBox.Text)
    End Sub
    Private Sub T_Tempeartur_Textbox_Textchanged(sender As Object, e As EventArgs) Handles T_Temperatur_TextBox.TextChanged
        T_Temperatur = Val(T_Temperatur_TextBox.Text)
    End Sub
    Public Sub But_Udregn_Idealgas()
        If KanRegne = True Then
            P_V = n_Stofmængde * R_mol * T_Temperatur
        End If
    End Sub

    Private Sub But_Udregn_Click(sender As Object, e As EventArgs) Handles But_Udregn.Click
        But_Udregn_Idealgas()
        IdealGasTotal_lbl.Text = P_V.ToString("F4")

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub



#End Region

#Region "Subroutiner"

    Private Sub CheckVariablerIdealgasser()
        If R_mol = Nothing Or T_Temperatur = Nothing Or n_Stofmængde = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False

        End If

#End Region


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
        Me.Show()
    End Sub

    Private Sub Interferens_But_Click(sender As Object, e As EventArgs) Handles Interferens_But.Click
        Me.Hide()
        Interferens_Form_D.Show()
    End Sub











#End Region


#Region "Sammenhængen mellem trykket p, rumfanget V og kelvintemperaturen T af en afspærret mængde af en idealgas"

#End Region


#Region "Tilstandsligningen for en afspærret mængde af en idealgas"

#End Region


#Region "Tilstandsligningen for en afspærret mængde af en idealgas, der indeholder N molekyler"


#End Region


#Region "Ekin er middelværdien af et atoms kinetiske energi i en én-atomig idealgas"


#End Region


End Class