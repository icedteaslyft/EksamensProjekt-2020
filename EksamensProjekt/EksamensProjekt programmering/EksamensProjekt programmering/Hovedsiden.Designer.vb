<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hoved_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tyngde_But = New System.Windows.Forms.Button()
        Me.Gnidning_But = New System.Windows.Forms.Button()
        Me.Densitet_But = New System.Windows.Forms.Button()
        Me.Specifik_Varmekapacitet_But = New System.Windows.Forms.Button()
        Me.Tryk_But = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tyngde_But
        '
        Me.Tyngde_But.Location = New System.Drawing.Point(0, 0)
        Me.Tyngde_But.Name = "Tyngde_But"
        Me.Tyngde_But.Size = New System.Drawing.Size(380, 34)
        Me.Tyngde_But.TabIndex = 0
        Me.Tyngde_But.Text = "Udregn Tyngdekraften"
        Me.Tyngde_But.UseVisualStyleBackColor = True
        '
        'Gnidning_But
        '
        Me.Gnidning_But.Location = New System.Drawing.Point(0, 40)
        Me.Gnidning_But.Name = "Gnidning_But"
        Me.Gnidning_But.Size = New System.Drawing.Size(380, 34)
        Me.Gnidning_But.TabIndex = 1
        Me.Gnidning_But.Text = "Udregn Gnidningskraften"
        Me.Gnidning_But.UseVisualStyleBackColor = True
        '
        'Densitet_But
        '
        Me.Densitet_But.Location = New System.Drawing.Point(0, 80)
        Me.Densitet_But.Name = "Densitet_But"
        Me.Densitet_But.Size = New System.Drawing.Size(380, 34)
        Me.Densitet_But.TabIndex = 2
        Me.Densitet_But.Text = "Udregn Densitet"
        Me.Densitet_But.UseVisualStyleBackColor = True
        '
        'Specifik_Varmekapacitet_But
        '
        Me.Specifik_Varmekapacitet_But.Location = New System.Drawing.Point(0, 120)
        Me.Specifik_Varmekapacitet_But.Name = "Specifik_Varmekapacitet_But"
        Me.Specifik_Varmekapacitet_But.Size = New System.Drawing.Size(380, 34)
        Me.Specifik_Varmekapacitet_But.TabIndex = 3
        Me.Specifik_Varmekapacitet_But.Text = "Udregn Specifik varmekapacitet"
        Me.Specifik_Varmekapacitet_But.UseVisualStyleBackColor = True
        '
        'Tryk_But
        '
        Me.Tryk_But.Location = New System.Drawing.Point(0, 160)
        Me.Tryk_But.Name = "Tryk_But"
        Me.Tryk_But.Size = New System.Drawing.Size(380, 34)
        Me.Tryk_But.TabIndex = 4
        Me.Tryk_But.Text = "Udregn Tryk"
        Me.Tryk_But.UseVisualStyleBackColor = True
        '
        'Hoved_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1489, 886)
        Me.Controls.Add(Me.Tryk_But)
        Me.Controls.Add(Me.Specifik_Varmekapacitet_But)
        Me.Controls.Add(Me.Densitet_But)
        Me.Controls.Add(Me.Gnidning_But)
        Me.Controls.Add(Me.Tyngde_But)
        Me.Name = "Hoved_Form"
        Me.Text = "Hovedsiden"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tyngde_But As Button
    Friend WithEvents Gnidning_But As Button
    Friend WithEvents Densitet_But As Button
    Friend WithEvents Specifik_Varmekapacitet_But As Button
    Friend WithEvents Tryk_But As Button
End Class
