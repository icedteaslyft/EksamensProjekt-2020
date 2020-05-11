<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idealgasser__Form_D
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdealGasTotal_lbl = New System.Windows.Forms.Label()
        Me.n_Stofmængde_TextBox = New System.Windows.Forms.TextBox()
        Me.T_Temperatur_TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.But_Udregn = New System.Windows.Forms.Button()
        Me.Interferens_But = New System.Windows.Forms.Button()
        Me.Idealgasser_But = New System.Windows.Forms.Button()
        Me.Gravitation_But = New System.Windows.Forms.Button()
        Me.Tryk_But = New System.Windows.Forms.Button()
        Me.Varme_But = New System.Windows.Forms.Button()
        Me.Densitet_But = New System.Windows.Forms.Button()
        Me.Elektrisk_Ladning_But = New System.Windows.Forms.Button()
        Me.Gnidningskraft_But = New System.Windows.Forms.Button()
        Me.Tyngde_But = New System.Windows.Forms.Button()
        Me.Hovedside_But = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_UdregnD = New System.Windows.Forms.Label()
        Me.R_mol_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Idealgasligningen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(658, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "p*V = n * R * T"
        '
        'IdealGasTotal_lbl
        '
        Me.IdealGasTotal_lbl.AutoSize = True
        Me.IdealGasTotal_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdealGasTotal_lbl.Location = New System.Drawing.Point(1010, 202)
        Me.IdealGasTotal_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdealGasTotal_lbl.Name = "IdealGasTotal_lbl"
        Me.IdealGasTotal_lbl.Size = New System.Drawing.Size(46, 20)
        Me.IdealGasTotal_lbl.TabIndex = 2
        Me.IdealGasTotal_lbl.Text = "Total"
        '
        'n_Stofmængde_TextBox
        '
        Me.n_Stofmængde_TextBox.Location = New System.Drawing.Point(518, 197)
        Me.n_Stofmængde_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.n_Stofmængde_TextBox.Name = "n_Stofmængde_TextBox"
        Me.n_Stofmængde_TextBox.Size = New System.Drawing.Size(103, 26)
        Me.n_Stofmængde_TextBox.TabIndex = 5
        '
        'T_Temperatur_TextBox
        '
        Me.T_Temperatur_TextBox.Location = New System.Drawing.Point(766, 197)
        Me.T_Temperatur_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Temperatur_TextBox.Name = "T_Temperatur_TextBox"
        Me.T_Temperatur_TextBox.Size = New System.Drawing.Size(103, 26)
        Me.T_Temperatur_TextBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(810, 172)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "T"
        '
        'But_Udregn
        '
        Me.But_Udregn.Location = New System.Drawing.Point(678, 312)
        Me.But_Udregn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_Udregn.Name = "But_Udregn"
        Me.But_Udregn.Size = New System.Drawing.Size(112, 35)
        Me.But_Udregn.TabIndex = 13
        Me.But_Udregn.Text = "Beregn"
        Me.But_Udregn.UseVisualStyleBackColor = True
        '
        'Interferens_But
        '
        Me.Interferens_But.Location = New System.Drawing.Point(16, 403)
        Me.Interferens_But.Name = "Interferens_But"
        Me.Interferens_But.Size = New System.Drawing.Size(326, 35)
        Me.Interferens_But.TabIndex = 79
        Me.Interferens_But.Text = "Beregn Interferens"
        Me.Interferens_But.UseVisualStyleBackColor = True
        '
        'Idealgasser_But
        '
        Me.Idealgasser_But.Location = New System.Drawing.Point(16, 362)
        Me.Idealgasser_But.Name = "Idealgasser_But"
        Me.Idealgasser_But.Size = New System.Drawing.Size(326, 35)
        Me.Idealgasser_But.TabIndex = 78
        Me.Idealgasser_But.Text = "Beregn Idealgasser"
        Me.Idealgasser_But.UseVisualStyleBackColor = True
        '
        'Gravitation_But
        '
        Me.Gravitation_But.Location = New System.Drawing.Point(16, 320)
        Me.Gravitation_But.Name = "Gravitation_But"
        Me.Gravitation_But.Size = New System.Drawing.Size(326, 35)
        Me.Gravitation_But.TabIndex = 77
        Me.Gravitation_But.Text = "Beregn Gravitation"
        Me.Gravitation_But.UseVisualStyleBackColor = True
        '
        'Tryk_But
        '
        Me.Tryk_But.Location = New System.Drawing.Point(16, 280)
        Me.Tryk_But.Name = "Tryk_But"
        Me.Tryk_But.Size = New System.Drawing.Size(326, 35)
        Me.Tryk_But.TabIndex = 76
        Me.Tryk_But.Text = "Beregn Tryk"
        Me.Tryk_But.UseVisualStyleBackColor = True
        '
        'Varme_But
        '
        Me.Varme_But.Location = New System.Drawing.Point(16, 238)
        Me.Varme_But.Name = "Varme_But"
        Me.Varme_But.Size = New System.Drawing.Size(326, 35)
        Me.Varme_But.TabIndex = 75
        Me.Varme_But.Text = "Beregn Varme"
        Me.Varme_But.UseVisualStyleBackColor = True
        '
        'Densitet_But
        '
        Me.Densitet_But.Location = New System.Drawing.Point(16, 197)
        Me.Densitet_But.Name = "Densitet_But"
        Me.Densitet_But.Size = New System.Drawing.Size(326, 35)
        Me.Densitet_But.TabIndex = 74
        Me.Densitet_But.Text = "Beregn Densitet"
        Me.Densitet_But.UseVisualStyleBackColor = True
        '
        'Elektrisk_Ladning_But
        '
        Me.Elektrisk_Ladning_But.Location = New System.Drawing.Point(16, 157)
        Me.Elektrisk_Ladning_But.Name = "Elektrisk_Ladning_But"
        Me.Elektrisk_Ladning_But.Size = New System.Drawing.Size(326, 35)
        Me.Elektrisk_Ladning_But.TabIndex = 73
        Me.Elektrisk_Ladning_But.Text = "Bereng Elektrisk ladning"
        Me.Elektrisk_Ladning_But.UseVisualStyleBackColor = True
        '
        'Gnidningskraft_But
        '
        Me.Gnidningskraft_But.Location = New System.Drawing.Point(16, 115)
        Me.Gnidningskraft_But.Name = "Gnidningskraft_But"
        Me.Gnidningskraft_But.Size = New System.Drawing.Size(326, 35)
        Me.Gnidningskraft_But.TabIndex = 72
        Me.Gnidningskraft_But.Text = "Beregn Gnidningskraft"
        Me.Gnidningskraft_But.UseVisualStyleBackColor = True
        '
        'Tyngde_But
        '
        Me.Tyngde_But.Location = New System.Drawing.Point(16, 74)
        Me.Tyngde_But.Name = "Tyngde_But"
        Me.Tyngde_But.Size = New System.Drawing.Size(326, 35)
        Me.Tyngde_But.TabIndex = 71
        Me.Tyngde_But.Text = "Beregn Tyngdekraft"
        Me.Tyngde_But.UseVisualStyleBackColor = True
        '
        'Hovedside_But
        '
        Me.Hovedside_But.Location = New System.Drawing.Point(16, 34)
        Me.Hovedside_But.Name = "Hovedside_But"
        Me.Hovedside_But.Size = New System.Drawing.Size(326, 35)
        Me.Hovedside_But.TabIndex = 70
        Me.Hovedside_But.Text = "Hovedside"
        Me.Hovedside_But.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(556, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "n"
        '
        'Lbl_UdregnD
        '
        Me.Lbl_UdregnD.AutoSize = True
        Me.Lbl_UdregnD.Location = New System.Drawing.Point(880, 202)
        Me.Lbl_UdregnD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_UdregnD.Name = "Lbl_UdregnD"
        Me.Lbl_UdregnD.Size = New System.Drawing.Size(18, 20)
        Me.Lbl_UdregnD.TabIndex = 81
        Me.Lbl_UdregnD.Text = "="
        '
        'R_mol_TextBox
        '
        Me.R_mol_TextBox.Location = New System.Drawing.Point(642, 197)
        Me.R_mol_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_mol_TextBox.Name = "R_mol_TextBox"
        Me.R_mol_TextBox.Size = New System.Drawing.Size(103, 26)
        Me.R_mol_TextBox.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(687, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "R"
        '
        'Idealgasser__Form_D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.R_mol_TextBox)
        Me.Controls.Add(Me.Lbl_UdregnD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Interferens_But)
        Me.Controls.Add(Me.Idealgasser_But)
        Me.Controls.Add(Me.Gravitation_But)
        Me.Controls.Add(Me.Tryk_But)
        Me.Controls.Add(Me.Varme_But)
        Me.Controls.Add(Me.Densitet_But)
        Me.Controls.Add(Me.Elektrisk_Ladning_But)
        Me.Controls.Add(Me.Gnidningskraft_But)
        Me.Controls.Add(Me.Tyngde_But)
        Me.Controls.Add(Me.Hovedside_But)
        Me.Controls.Add(Me.But_Udregn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.T_Temperatur_TextBox)
        Me.Controls.Add(Me.n_Stofmængde_TextBox)
        Me.Controls.Add(Me.IdealGasTotal_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Idealgasser__Form_D"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IdealGasTotal_lbl As Label
    Friend WithEvents n_Stofmængde_TextBox As TextBox
    Friend WithEvents T_Temperatur_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents But_Udregn As Button
    Friend WithEvents Interferens_But As Button
    Friend WithEvents Idealgasser_But As Button
    Friend WithEvents Gravitation_But As Button
    Friend WithEvents Tryk_But As Button
    Friend WithEvents Varme_But As Button
    Friend WithEvents Densitet_But As Button
    Friend WithEvents Elektrisk_Ladning_But As Button
    Friend WithEvents Gnidningskraft_But As Button
    Friend WithEvents Tyngde_But As Button
    Friend WithEvents Hovedside_But As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_UdregnD As Label
    Friend WithEvents R_mol_TextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
