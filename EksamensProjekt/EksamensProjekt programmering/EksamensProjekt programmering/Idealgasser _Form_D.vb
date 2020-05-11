Public Class Idealgasser__Form_D
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

#Region "Idealgas"
    'Værdi til det tekstboksen modtager

    Private Sub p_Trykket_textbox_Textchanged(sender As Object, e As EventArgs)
        p_Trykket = Val(p_Trykket.Text)
    End Sub
    Private Sub V_Volumen_textbox_Textchanged(sender As Object, e As EventArgs)
        V_Volumen = Val(V_Volumen.Text)
    End Sub
    Private Sub n_Stofmængde_Textbox_Textchanged(sender As Object, e As EventArgs) Handles n_Stofmængde.TextChanged
        n_Stofmængde = Val(n_Stofmængde.Text)
    End Sub
    Private Sub T_Tempeartur_Textbox_Textchanged(sender As Object, e As EventArgs) Handles T_Temperatur.TextChanged
        T_Temperatur = Val(T_Temperatur)
    End Sub
    Public Sub But_Udregn()
        If KanRegne = True Then
            n_Stofmængde * R_mol * T_Temperatur
        End If
    End Sub

    Private Sub 


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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles p_Trykket.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles n_Stofmængde.TextChanged

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