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
        Me.FormSkin = New Tic_Tac_Toe.FormSkin()
        Me.OLabel = New System.Windows.Forms.Label()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatMini1 = New Tic_Tac_Toe.FlatMini()
        Me.FlatClose1 = New Tic_Tac_Toe.FlatClose()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.Panel()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.FormSkin.SuspendLayout()
        Me.Grid.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin
        '
        Me.FormSkin.BackColor = System.Drawing.Color.White
        Me.FormSkin.BaseColor = System.Drawing.Color.White
        Me.FormSkin.BorderColor = System.Drawing.Color.Black
        Me.FormSkin.Controls.Add(Me.OLabel)
        Me.FormSkin.Controls.Add(Me.XLabel)
        Me.FormSkin.Controls.Add(Me.Label2)
        Me.FormSkin.Controls.Add(Me.Label1)
        Me.FormSkin.Controls.Add(Me.FlatMini1)
        Me.FormSkin.Controls.Add(Me.FlatClose1)
        Me.FormSkin.Controls.Add(Me.ResetButton)
        Me.FormSkin.Controls.Add(Me.Grid)
        Me.FormSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormSkin.HeaderColor = System.Drawing.Color.White
        Me.FormSkin.HeaderMaximize = False
        Me.FormSkin.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin.Name = "FormSkin"
        Me.FormSkin.Size = New System.Drawing.Size(270, 320)
        Me.FormSkin.TabIndex = 0
        Me.FormSkin.TabStop = False
        Me.FormSkin.Text = "Tic Tac Toe"
        '
        'OLabel
        '
        Me.OLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OLabel.AutoSize = True
        Me.OLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OLabel.ForeColor = System.Drawing.Color.Indigo
        Me.OLabel.Location = New System.Drawing.Point(218, 34)
        Me.OLabel.Name = "OLabel"
        Me.OLabel.Size = New System.Drawing.Size(18, 20)
        Me.OLabel.TabIndex = 0
        Me.OLabel.Text = "0"
        '
        'XLabel
        '
        Me.XLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.XLabel.AutoSize = True
        Me.XLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XLabel.ForeColor = System.Drawing.Color.Indigo
        Me.XLabel.Location = New System.Drawing.Point(65, 34)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(18, 20)
        Me.XLabel.TabIndex = 0
        Me.XLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(185, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "O:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X:"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.White
        Me.FlatMini1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(180, 1)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(45, 29)
        Me.FlatMini1.TabIndex = 0
        Me.FlatMini1.TabStop = False
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.Black
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.White
        Me.FlatClose1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(224, 1)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(45, 29)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.TabStop = False
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.Black
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResetButton.FlatAppearance.BorderSize = 0
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ResetButton.ForeColor = System.Drawing.Color.Indigo
        Me.ResetButton.Location = New System.Drawing.Point(31, 274)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(208, 34)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Grid.Controls.Add(Me.B1)
        Me.Grid.Controls.Add(Me.B2)
        Me.Grid.Controls.Add(Me.B3)
        Me.Grid.Controls.Add(Me.B4)
        Me.Grid.Controls.Add(Me.B5)
        Me.Grid.Controls.Add(Me.B6)
        Me.Grid.Controls.Add(Me.B7)
        Me.Grid.Controls.Add(Me.B8)
        Me.Grid.Controls.Add(Me.B9)
        Me.Grid.Location = New System.Drawing.Point(31, 60)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(208, 208)
        Me.Grid.TabIndex = 0
        '
        'B1
        '
        Me.B1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(0, 0)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(70, 70)
        Me.B1.TabIndex = 0
        Me.B1.TabStop = False
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(69, 0)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(70, 70)
        Me.B2.TabIndex = 1
        Me.B2.TabStop = False
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B3.ForeColor = System.Drawing.Color.Black
        Me.B3.Location = New System.Drawing.Point(138, 0)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(70, 70)
        Me.B3.TabIndex = 2
        Me.B3.TabStop = False
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B4.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B4.ForeColor = System.Drawing.Color.Black
        Me.B4.Location = New System.Drawing.Point(0, 69)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(70, 70)
        Me.B4.TabIndex = 3
        Me.B4.TabStop = False
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B5.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B5.ForeColor = System.Drawing.Color.Black
        Me.B5.Location = New System.Drawing.Point(69, 69)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(70, 70)
        Me.B5.TabIndex = 4
        Me.B5.TabStop = False
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B6.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B6.ForeColor = System.Drawing.Color.Black
        Me.B6.Location = New System.Drawing.Point(138, 69)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(70, 70)
        Me.B6.TabIndex = 5
        Me.B6.TabStop = False
        Me.B6.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B7.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B7.ForeColor = System.Drawing.Color.Black
        Me.B7.Location = New System.Drawing.Point(0, 138)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(70, 70)
        Me.B7.TabIndex = 6
        Me.B7.TabStop = False
        Me.B7.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B8.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B8.ForeColor = System.Drawing.Color.Black
        Me.B8.Location = New System.Drawing.Point(69, 138)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(70, 70)
        Me.B8.TabIndex = 7
        Me.B8.TabStop = False
        Me.B8.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.B9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B9.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.B9.ForeColor = System.Drawing.Color.Black
        Me.B9.Location = New System.Drawing.Point(138, 138)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(70, 70)
        Me.B9.TabIndex = 8
        Me.B9.TabStop = False
        Me.B9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(270, 320)
        Me.Controls.Add(Me.FormSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Tic_Tac_Toe.My.Resources.Resources.Tic_Tac_Toe
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(270, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.FormSkin.ResumeLayout(False)
        Me.FormSkin.PerformLayout()
        Me.Grid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents B9 As System.Windows.Forms.Button
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B8 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B7 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents FormSkin As Tic_Tac_Toe.FormSkin
    Friend WithEvents FlatMini1 As Tic_Tac_Toe.FlatMini
    Friend WithEvents FlatClose1 As Tic_Tac_Toe.FlatClose
    Friend WithEvents Grid As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OLabel As Label
    Friend WithEvents XLabel As Label
End Class