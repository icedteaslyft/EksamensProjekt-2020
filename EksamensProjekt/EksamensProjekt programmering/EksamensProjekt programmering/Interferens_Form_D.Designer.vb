<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interferens_Form_D
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
        Me.lbl_konstruktiv_int = New System.Windows.Forms.Label()
        Me.lbl_destruktiv_int = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_konstruktiv_int
        '
        Me.lbl_konstruktiv_int.AutoSize = True
        Me.lbl_konstruktiv_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_konstruktiv_int.Location = New System.Drawing.Point(366, 82)
        Me.lbl_konstruktiv_int.Name = "lbl_konstruktiv_int"
        Me.lbl_konstruktiv_int.Size = New System.Drawing.Size(206, 25)
        Me.lbl_konstruktiv_int.TabIndex = 0
        Me.lbl_konstruktiv_int.Text = "Konstruktiv Interferens"
        '
        'lbl_destruktiv_int
        '
        Me.lbl_destruktiv_int.AutoSize = True
        Me.lbl_destruktiv_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destruktiv_int.Location = New System.Drawing.Point(377, 193)
        Me.lbl_destruktiv_int.Name = "lbl_destruktiv_int"
        Me.lbl_destruktiv_int.Size = New System.Drawing.Size(195, 25)
        Me.lbl_destruktiv_int.TabIndex = 1
        Me.lbl_destruktiv_int.Text = "Destruktiv Interferens"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(347, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(474, 138)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "∆S = |PB| - |PA| = m* λ "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "∆S = |PB| - |PA| = 1/2 * λ + m * λ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(605, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Beregn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(347, 246)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(474, 246)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Interferens_But
        '
        Me.Interferens_But.Location = New System.Drawing.Point(8, 248)
        Me.Interferens_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Interferens_But.Name = "Interferens_But"
        Me.Interferens_But.Size = New System.Drawing.Size(217, 23)
        Me.Interferens_But.TabIndex = 69
        Me.Interferens_But.Text = "Beregn Interferens"
        Me.Interferens_But.UseVisualStyleBackColor = True
        '
        'Idealgasser_But
        '
        Me.Idealgasser_But.Location = New System.Drawing.Point(8, 221)
        Me.Idealgasser_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Idealgasser_But.Name = "Idealgasser_But"
        Me.Idealgasser_But.Size = New System.Drawing.Size(217, 23)
        Me.Idealgasser_But.TabIndex = 68
        Me.Idealgasser_But.Text = "Beregn Idealgasser"
        Me.Idealgasser_But.UseVisualStyleBackColor = True
        '
        'Gravitation_But
        '
        Me.Gravitation_But.Location = New System.Drawing.Point(8, 194)
        Me.Gravitation_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gravitation_But.Name = "Gravitation_But"
        Me.Gravitation_But.Size = New System.Drawing.Size(217, 23)
        Me.Gravitation_But.TabIndex = 67
        Me.Gravitation_But.Text = "Beregn Gravitation"
        Me.Gravitation_But.UseVisualStyleBackColor = True
        '
        'Tryk_But
        '
        Me.Tryk_But.Location = New System.Drawing.Point(8, 168)
        Me.Tryk_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tryk_But.Name = "Tryk_But"
        Me.Tryk_But.Size = New System.Drawing.Size(217, 23)
        Me.Tryk_But.TabIndex = 66
        Me.Tryk_But.Text = "Beregn Tryk"
        Me.Tryk_But.UseVisualStyleBackColor = True
        '
        'Varme_But
        '
        Me.Varme_But.Location = New System.Drawing.Point(8, 141)
        Me.Varme_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Varme_But.Name = "Varme_But"
        Me.Varme_But.Size = New System.Drawing.Size(217, 23)
        Me.Varme_But.TabIndex = 65
        Me.Varme_But.Text = "Beregn Varme"
        Me.Varme_But.UseVisualStyleBackColor = True
        '
        'Densitet_But
        '
        Me.Densitet_But.Location = New System.Drawing.Point(8, 114)
        Me.Densitet_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Densitet_But.Name = "Densitet_But"
        Me.Densitet_But.Size = New System.Drawing.Size(217, 23)
        Me.Densitet_But.TabIndex = 64
        Me.Densitet_But.Text = "Beregn Densitet"
        Me.Densitet_But.UseVisualStyleBackColor = True
        '
        'Elektrisk_Ladning_But
        '
        Me.Elektrisk_Ladning_But.Location = New System.Drawing.Point(8, 88)
        Me.Elektrisk_Ladning_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Elektrisk_Ladning_But.Name = "Elektrisk_Ladning_But"
        Me.Elektrisk_Ladning_But.Size = New System.Drawing.Size(217, 23)
        Me.Elektrisk_Ladning_But.TabIndex = 63
        Me.Elektrisk_Ladning_But.Text = "Bereng Elektrisk ladning"
        Me.Elektrisk_Ladning_But.UseVisualStyleBackColor = True
        '
        'Gnidningskraft_But
        '
        Me.Gnidningskraft_But.Location = New System.Drawing.Point(8, 61)
        Me.Gnidningskraft_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gnidningskraft_But.Name = "Gnidningskraft_But"
        Me.Gnidningskraft_But.Size = New System.Drawing.Size(217, 23)
        Me.Gnidningskraft_But.TabIndex = 62
        Me.Gnidningskraft_But.Text = "Beregn Gnidningskraft"
        Me.Gnidningskraft_But.UseVisualStyleBackColor = True
        '
        'Tyngde_But
        '
        Me.Tyngde_But.Location = New System.Drawing.Point(8, 34)
        Me.Tyngde_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tyngde_But.Name = "Tyngde_But"
        Me.Tyngde_But.Size = New System.Drawing.Size(217, 23)
        Me.Tyngde_But.TabIndex = 61
        Me.Tyngde_But.Text = "Beregn Tyngdekraft"
        Me.Tyngde_But.UseVisualStyleBackColor = True
        '
        'Hovedside_But
        '
        Me.Hovedside_But.Location = New System.Drawing.Point(8, 8)
        Me.Hovedside_But.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Hovedside_But.Name = "Hovedside_But"
        Me.Hovedside_But.Size = New System.Drawing.Size(217, 23)
        Me.Hovedside_But.TabIndex = 60
        Me.Hovedside_But.Text = "Hovedside"
        Me.Hovedside_But.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(580, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 20)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "="
        '
        'Interferens_Form_D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lbl_destruktiv_int)
        Me.Controls.Add(Me.lbl_konstruktiv_int)
        Me.Name = "Interferens_Form_D"
        Me.Text = "Interferens_Form_D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_konstruktiv_int As Label
    Friend WithEvents lbl_destruktiv_int As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
