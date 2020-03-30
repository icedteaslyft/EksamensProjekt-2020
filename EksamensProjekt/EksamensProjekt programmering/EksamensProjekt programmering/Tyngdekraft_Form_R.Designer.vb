<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tyngdekraft_Form_R
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
        Me.Hovedside_But = New System.Windows.Forms.Button()
        Me.Tryk_But = New System.Windows.Forms.Button()
        Me.Varme_But = New System.Windows.Forms.Button()
        Me.Densitet_But = New System.Windows.Forms.Button()
        Me.Gnidning_But = New System.Windows.Forms.Button()
        Me.Tyngde_But = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Hovedside_But
        '
        Me.Hovedside_But.Location = New System.Drawing.Point(11, 11)
        Me.Hovedside_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Hovedside_But.Name = "Hovedside_But"
        Me.Hovedside_But.Size = New System.Drawing.Size(253, 22)
        Me.Hovedside_But.TabIndex = 12
        Me.Hovedside_But.Text = "Hovedsiden"
        Me.Hovedside_But.UseVisualStyleBackColor = True
        '
        'Tryk_But
        '
        Me.Tryk_But.Location = New System.Drawing.Point(11, 141)
        Me.Tryk_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Tryk_But.Name = "Tryk_But"
        Me.Tryk_But.Size = New System.Drawing.Size(253, 22)
        Me.Tryk_But.TabIndex = 11
        Me.Tryk_But.Text = "Udregn Tryk"
        Me.Tryk_But.UseVisualStyleBackColor = True
        '
        'Varme_But
        '
        Me.Varme_But.Location = New System.Drawing.Point(11, 115)
        Me.Varme_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Varme_But.Name = "Varme_But"
        Me.Varme_But.Size = New System.Drawing.Size(253, 22)
        Me.Varme_But.TabIndex = 10
        Me.Varme_But.Text = "Udregn Varme"
        Me.Varme_But.UseVisualStyleBackColor = True
        '
        'Densitet_But
        '
        Me.Densitet_But.Location = New System.Drawing.Point(11, 89)
        Me.Densitet_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Densitet_But.Name = "Densitet_But"
        Me.Densitet_But.Size = New System.Drawing.Size(253, 22)
        Me.Densitet_But.TabIndex = 9
        Me.Densitet_But.Text = "Udregn Densitet"
        Me.Densitet_But.UseVisualStyleBackColor = True
        '
        'Gnidning_But
        '
        Me.Gnidning_But.Location = New System.Drawing.Point(11, 63)
        Me.Gnidning_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Gnidning_But.Name = "Gnidning_But"
        Me.Gnidning_But.Size = New System.Drawing.Size(253, 22)
        Me.Gnidning_But.TabIndex = 8
        Me.Gnidning_But.Text = "Udregn Gnidningskraften"
        Me.Gnidning_But.UseVisualStyleBackColor = True
        '
        'Tyngde_But
        '
        Me.Tyngde_But.Location = New System.Drawing.Point(11, 37)
        Me.Tyngde_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Tyngde_But.Name = "Tyngde_But"
        Me.Tyngde_But.Size = New System.Drawing.Size(253, 22)
        Me.Tyngde_But.TabIndex = 7
        Me.Tyngde_But.Text = "Udregn Tyngdekraften"
        Me.Tyngde_But.UseVisualStyleBackColor = True
        '
        'Tyngdekraft_Form_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Hovedside_But)
        Me.Controls.Add(Me.Tryk_But)
        Me.Controls.Add(Me.Varme_But)
        Me.Controls.Add(Me.Densitet_But)
        Me.Controls.Add(Me.Gnidning_But)
        Me.Controls.Add(Me.Tyngde_But)
        Me.Name = "Tyngdekraft_Form_R"
        Me.Text = "Tyngdekraft_form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Hovedside_But As Button
    Friend WithEvents Tryk_But As Button
    Friend WithEvents Varme_But As Button
    Friend WithEvents Densitet_But As Button
    Friend WithEvents Gnidning_But As Button
    Friend WithEvents Tyngde_But As Button
End Class
