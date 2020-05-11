Public Class Gravitation_Form_D

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
        Me.Show()
    End Sub

    Private Sub Idealgasser_But_Click(sender As Object, e As EventArgs) Handles Idealgasser_But.Click
        Me.Hide()
        Idealgasser__Form_D.Show()
    End Sub

    Private Sub Interferens_But_Click(sender As Object, e As EventArgs) Handles Interferens_But.Click
        Me.Hide()
        Interferens_Form_D.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles G_Gravitation_Textbox.TextChanged

    End Sub



#End Region

#Region "Gravitation"
    Private Sub G_Gravitation_Textbox_Textchanged(sender As Object, e As EventArgs) Handles G_Gravitation_Textbox.TextChanged
        G_Gravitation = Val(G_Gravitation_Textbox.Text)
    End Sub

    Private Sub M_Masse1_Textbox_Textchanged(Sender As Object, e As EventArgs) Handles M_Masse1_Textbox.TextChanged
        M_Masse1 = Val(M_Masse1_Textbox.Text)
    End Sub

    Private Sub M_Masse2_Textbox_Textchanged(Sender As Object, e As EventArgs) Handles M_Masse2_Textbox.TextChanged
        M_Masse2 = Val(M_Masse2_Textbox.Text)
    End Sub

    Private Sub R_Afstand_Textbox_Textchanged(Sender As Object, e As EventArgs) Handles R_Afstand_Textbox.TextChanged
        R_Afstand = Val(R_Afstand_Textbox.Text)
    End Sub

    Private Sub But_Udregn_Gravitation()
        If KanRegne = True Then
            F_Resultat = G_Gravitation * M_Masse1 * M_Masse2 / R_Afstand
        End If
    End Sub


    Private Sub But_Udregn_Gravitation_Click(Sender As Object, e As EventArgs) Handles But_Udregn_Gravitation_But.Click, But_Udregn_Gravitation_But.Click
        But_Udregn_Gravitation()
        GravitationTotal_lbl.Text = F_Resultat.ToString("F4")

        If KanRegne = False Then
            KanRegne = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

#End Region

#Region "Subroutiner"
    Private Sub CheckVariablerGravitation()
        If G_Gravitation = Nothing Or M_Masse1 = Nothing Or M_Masse2 = Nothing Or R_Afstand = Nothing Then
            MsgBox("Ikke alle værdier er angivet!")
            KanRegne = False
        End If
    End Sub
#End Region

#Region "F er størrelsen af gravitationskraften.."


#End Region


#Region "Epot er den potentielle energi af to partikler..."


#End Region



End Class