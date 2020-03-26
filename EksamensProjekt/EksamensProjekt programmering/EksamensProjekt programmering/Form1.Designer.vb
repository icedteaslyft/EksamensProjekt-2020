<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1489, 886)
        Me.Controls.Add(Me.Gnidning_But)
        Me.Controls.Add(Me.Tyngde_But)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tyngde_But As Button
    Friend WithEvents Gnidning_But As Button
End Class
