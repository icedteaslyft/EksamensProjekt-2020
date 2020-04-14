Public Class Tryk_Form_T

    Private Sub Tryk_Form_T_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub Tryk_Areal_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Areal_TextBox.TextChanged
        A_Areal = Val(Tryk_Areal_TextBox.Text)
    End Sub

    Private Sub Tryk_Kraft_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Kraft_TextBox.TextChanged
        F_Kraft = Val(Tryk_Kraft_TextBox.Text)
    End Sub

    Public Sub BeregnTryk()
        p_Tryk = F_Kraft / A_Areal
    End Sub

    Private Sub Tryk_Beregn_But_Click(sender As Object, e As EventArgs) Handles Tryk_Beregn_But.Click
        BeregnTryk()
        Tryk_Total_lbl.Text = p_Tryk.ToString() & "kPa"
    End Sub

#End Region


#Region "Væske Tryk"

    Private Sub Tryk_Densitet_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Densitet_TextBox.TextChanged
        p_Rho = Val(Tryk_Densitet_TextBox.Text)
    End Sub

    Private Sub Tryk_Højde_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Højde_TextBox.TextChanged
        h_Højde = Val(Tryk_Højde_TextBox.Text)
    End Sub

    Private Sub Tryk_Tyngde_Accelerationen_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Tryk_Tyngde_Accelerationen_TextBox.TextChanged
        g_TyngdeAcceleration = Val(Tryk_Tyngde_Accelerationen_TextBox.Text)
    End Sub

    Public Sub BeregnVæskeTryk()
        p_VæskeTryk = p_Rho * h_Højde * g_TyngdeAcceleration
    End Sub

    Private Sub Tryk_Væske_Beregn_But_Click(sender As Object, e As EventArgs) Handles Tryk_Væske_Beregn_But.Click
        BeregnVæskeTryk()
        Væske_Tryk_Total_lbl.Text = p_VæskeTryk.ToString & "kPa"
    End Sub






#End Region

End Class