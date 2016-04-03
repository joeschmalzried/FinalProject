<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomType
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
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.radJunior = New System.Windows.Forms.RadioButton()
        Me.radSuperior = New System.Windows.Forms.RadioButton()
        Me.radExecutive = New System.Windows.Forms.RadioButton()
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radGrande = New System.Windows.Forms.RadioButton()
        Me.btnInformation = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the room type you would like"
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(12, 43)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(85, 17)
        Me.radSingle.TabIndex = 1
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single Room"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radDouble
        '
        Me.radDouble.AutoSize = True
        Me.radDouble.Location = New System.Drawing.Point(161, 43)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(90, 17)
        Me.radDouble.TabIndex = 2
        Me.radDouble.TabStop = True
        Me.radDouble.Text = "Double Room"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'radJunior
        '
        Me.radJunior.AutoSize = True
        Me.radJunior.Location = New System.Drawing.Point(12, 78)
        Me.radJunior.Name = "radJunior"
        Me.radJunior.Size = New System.Drawing.Size(83, 17)
        Me.radJunior.TabIndex = 3
        Me.radJunior.TabStop = True
        Me.radJunior.Text = "Junion Suite"
        Me.radJunior.UseVisualStyleBackColor = True
        '
        'radSuperior
        '
        Me.radSuperior.AutoSize = True
        Me.radSuperior.Location = New System.Drawing.Point(161, 78)
        Me.radSuperior.Name = "radSuperior"
        Me.radSuperior.Size = New System.Drawing.Size(91, 17)
        Me.radSuperior.TabIndex = 4
        Me.radSuperior.TabStop = True
        Me.radSuperior.Text = "Superior Suite"
        Me.radSuperior.UseVisualStyleBackColor = True
        '
        'radExecutive
        '
        Me.radExecutive.AutoSize = True
        Me.radExecutive.Location = New System.Drawing.Point(12, 117)
        Me.radExecutive.Name = "radExecutive"
        Me.radExecutive.Size = New System.Drawing.Size(99, 17)
        Me.radExecutive.TabIndex = 5
        Me.radExecutive.TabStop = True
        Me.radExecutive.Text = "Executive Suite"
        Me.radExecutive.UseVisualStyleBackColor = True
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(161, 117)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(81, 17)
        Me.radFamily.TabIndex = 6
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "Family Suite"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radGrande
        '
        Me.radGrande.AutoSize = True
        Me.radGrande.Location = New System.Drawing.Point(12, 157)
        Me.radGrande.Name = "radGrande"
        Me.radGrande.Size = New System.Drawing.Size(87, 17)
        Me.radGrande.TabIndex = 7
        Me.radGrande.TabStop = True
        Me.radGrande.Text = "Grande Suite"
        Me.radGrande.UseVisualStyleBackColor = True
        '
        'btnInformation
        '
        Me.btnInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformation.Location = New System.Drawing.Point(78, 192)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(102, 39)
        Me.btnInformation.TabIndex = 8
        Me.btnInformation.Text = "Information"
        Me.btnInformation.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 262)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'RoomType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 297)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInformation)
        Me.Controls.Add(Me.radGrande)
        Me.Controls.Add(Me.radFamily)
        Me.Controls.Add(Me.radExecutive)
        Me.Controls.Add(Me.radSuperior)
        Me.Controls.Add(Me.radJunior)
        Me.Controls.Add(Me.radDouble)
        Me.Controls.Add(Me.radSingle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RoomType"
        Me.Text = "Room Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents radDouble As RadioButton
    Friend WithEvents radJunior As RadioButton
    Friend WithEvents radSuperior As RadioButton
    Friend WithEvents radExecutive As RadioButton
    Friend WithEvents radFamily As RadioButton
    Friend WithEvents radGrande As RadioButton
    Friend WithEvents btnInformation As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClose As Button
End Class
