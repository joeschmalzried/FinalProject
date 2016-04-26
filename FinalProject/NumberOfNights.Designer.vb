<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberOfNights
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stslbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of nights you plan to stay"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(38, 117)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(173, 117)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(91, 44)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 1
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stslbl1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 146)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stslbl1
        '
        Me.stslbl1.Name = "stslbl1"
        Me.stslbl1.Size = New System.Drawing.Size(0, 17)
        '
        'NumberOfNights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 168)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NumberOfNights"
        Me.Text = "Number Of Nights"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtNights As TextBox
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stslbl1 As ToolStripStatusLabel
End Class
