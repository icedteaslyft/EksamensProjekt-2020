﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tyngdekraft_Form_R
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
        Me.Beregn_Tyngdekraft_But = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tyngdekraft_Total_lbl = New System.Windows.Forms.Label()
        Me.Tyngdekraft_Tyngdeacceleration_TextBox = New System.Windows.Forms.TextBox()
        Me.Rumfang_lbl = New System.Windows.Forms.Label()
        Me.Masse_lbl = New System.Windows.Forms.Label()
        Me.Tyngdekraft_Masse_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Beregn_Tyngdekraft_But
        '
        Me.Beregn_Tyngdekraft_But.Location = New System.Drawing.Point(511, 177)
        Me.Beregn_Tyngdekraft_But.Margin = New System.Windows.Forms.Padding(2)
        Me.Beregn_Tyngdekraft_But.Name = "Beregn_Tyngdekraft_But"
        Me.Beregn_Tyngdekraft_But.Size = New System.Drawing.Size(50, 27)
        Me.Beregn_Tyngdekraft_But.TabIndex = 55
        Me.Beregn_Tyngdekraft_But.Text = "Beregn"
        Me.Beregn_Tyngdekraft_But.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(470, 143)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Tyngdekraft"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "="
        '
        'Tyngdekraft_Total_lbl
        '
        Me.Tyngdekraft_Total_lbl.AutoSize = True
        Me.Tyngdekraft_Total_lbl.Location = New System.Drawing.Point(653, 144)
        Me.Tyngdekraft_Total_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Tyngdekraft_Total_lbl.Name = "Tyngdekraft_Total_lbl"
        Me.Tyngdekraft_Total_lbl.Size = New System.Drawing.Size(31, 13)
        Me.Tyngdekraft_Total_lbl.TabIndex = 51
        Me.Tyngdekraft_Total_lbl.Text = "Total"
        '
        'Tyngdekraft_Tyngdeacceleration_TextBox
        '
        Me.Tyngdekraft_Tyngdeacceleration_TextBox.Location = New System.Drawing.Point(482, 141)
        Me.Tyngdekraft_Tyngdeacceleration_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Tyngdekraft_Tyngdeacceleration_TextBox.Name = "Tyngdekraft_Tyngdeacceleration_TextBox"
        Me.Tyngdekraft_Tyngdeacceleration_TextBox.Size = New System.Drawing.Size(149, 20)
        Me.Tyngdekraft_Tyngdeacceleration_TextBox.TabIndex = 50
        '
        'Rumfang_lbl
        '
        Me.Rumfang_lbl.AutoSize = True
        Me.Rumfang_lbl.Location = New System.Drawing.Point(490, 113)
        Me.Rumfang_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Rumfang_lbl.Name = "Rumfang_lbl"
        Me.Rumfang_lbl.Size = New System.Drawing.Size(132, 13)
        Me.Rumfang_lbl.TabIndex = 49
        Me.Rumfang_lbl.Text = "Tyngdeacceleration(N/kg)"
        '
        'Masse_lbl
        '
        Me.Masse_lbl.AutoSize = True
        Me.Masse_lbl.Location = New System.Drawing.Point(407, 113)
        Me.Masse_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Masse_lbl.Name = "Masse_lbl"
        Me.Masse_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Masse_lbl.TabIndex = 48
        Me.Masse_lbl.Text = "Masse(kg)"
        '
        'Tyngdekraft_Masse_TextBox
        '
        Me.Tyngdekraft_Masse_TextBox.Location = New System.Drawing.Point(399, 141)
        Me.Tyngdekraft_Masse_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Tyngdekraft_Masse_TextBox.Name = "Tyngdekraft_Masse_TextBox"
        Me.Tyngdekraft_Masse_TextBox.Size = New System.Drawing.Size(68, 20)
        Me.Tyngdekraft_Masse_TextBox.TabIndex = 47
        '
        'Tyngdekraft_Form_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Beregn_Tyngdekraft_But)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tyngdekraft_Total_lbl)
        Me.Controls.Add(Me.Tyngdekraft_Tyngdeacceleration_TextBox)
        Me.Controls.Add(Me.Rumfang_lbl)
        Me.Controls.Add(Me.Masse_lbl)
        Me.Controls.Add(Me.Tyngdekraft_Masse_TextBox)
        Me.Name = "Tyngdekraft_Form_R"
        Me.Text = "Tyngdekraft_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Beregn_Tyngdekraft_But As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tyngdekraft_Total_lbl As Label
    Friend WithEvents Tyngdekraft_Tyngdeacceleration_TextBox As TextBox
    Friend WithEvents Rumfang_lbl As Label
    Friend WithEvents Masse_lbl As Label
    Friend WithEvents Tyngdekraft_Masse_TextBox As TextBox
End Class
