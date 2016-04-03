<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accommodations
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
        Me.chkDoubleBed = New System.Windows.Forms.CheckBox()
        Me.chkSofa = New System.Windows.Forms.CheckBox()
        Me.chkSafe = New System.Windows.Forms.CheckBox()
        Me.chkTV = New System.Windows.Forms.CheckBox()
        Me.chkBar = New System.Windows.Forms.CheckBox()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.chkBalcony = New System.Windows.Forms.CheckBox()
        Me.chkBathrooms = New System.Windows.Forms.CheckBox()
        Me.chkSeperateRoom = New System.Windows.Forms.CheckBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkDoubleBed
        '
        Me.chkDoubleBed.AutoSize = True
        Me.chkDoubleBed.Location = New System.Drawing.Point(8, 12)
        Me.chkDoubleBed.Name = "chkDoubleBed"
        Me.chkDoubleBed.Size = New System.Drawing.Size(82, 17)
        Me.chkDoubleBed.TabIndex = 0
        Me.chkDoubleBed.Text = "Double Bed"
        Me.chkDoubleBed.UseVisualStyleBackColor = True
        '
        'chkSofa
        '
        Me.chkSofa.AutoSize = True
        Me.chkSofa.Location = New System.Drawing.Point(142, 12)
        Me.chkSofa.Name = "chkSofa"
        Me.chkSofa.Size = New System.Drawing.Size(188, 17)
        Me.chkSofa.TabIndex = 1
        Me.chkSofa.Text = "Sitting corner with sofa or armchair"
        Me.chkSofa.UseVisualStyleBackColor = True
        '
        'chkSafe
        '
        Me.chkSafe.AutoSize = True
        Me.chkSafe.Location = New System.Drawing.Point(355, 12)
        Me.chkSafe.Name = "chkSafe"
        Me.chkSafe.Size = New System.Drawing.Size(108, 17)
        Me.chkSafe.TabIndex = 2
        Me.chkSafe.Text = "Safe Deposit Box"
        Me.chkSafe.UseVisualStyleBackColor = True
        '
        'chkTV
        '
        Me.chkTV.AutoSize = True
        Me.chkTV.Location = New System.Drawing.Point(8, 48)
        Me.chkTV.Name = "chkTV"
        Me.chkTV.Size = New System.Drawing.Size(64, 17)
        Me.chkTV.TabIndex = 3
        Me.chkTV.Text = "LCD TV"
        Me.chkTV.UseVisualStyleBackColor = True
        '
        'chkBar
        '
        Me.chkBar.AutoSize = True
        Me.chkBar.Location = New System.Drawing.Point(142, 48)
        Me.chkBar.Name = "chkBar"
        Me.chkBar.Size = New System.Drawing.Size(64, 17)
        Me.chkBar.TabIndex = 4
        Me.chkBar.Text = "Mini-Bar"
        Me.chkBar.UseVisualStyleBackColor = True
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.Location = New System.Drawing.Point(355, 48)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(151, 30)
        Me.chkCoffee.TabIndex = 5
        Me.chkCoffee.Text = "Steamer and amenities for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "making coffee and tea"
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'chkBalcony
        '
        Me.chkBalcony.AutoSize = True
        Me.chkBalcony.Location = New System.Drawing.Point(8, 92)
        Me.chkBalcony.Name = "chkBalcony"
        Me.chkBalcony.Size = New System.Drawing.Size(116, 17)
        Me.chkBalcony.TabIndex = 6
        Me.chkBalcony.Text = "Balcony or Terrace"
        Me.chkBalcony.UseVisualStyleBackColor = True
        '
        'chkBathrooms
        '
        Me.chkBathrooms.AutoSize = True
        Me.chkBathrooms.Location = New System.Drawing.Point(142, 92)
        Me.chkBathrooms.Name = "chkBathrooms"
        Me.chkBathrooms.Size = New System.Drawing.Size(106, 17)
        Me.chkBathrooms.TabIndex = 7
        Me.chkBathrooms.Text = "1 or 2 Bathrooms"
        Me.chkBathrooms.UseVisualStyleBackColor = True
        '
        'chkSeperateRoom
        '
        Me.chkSeperateRoom.AutoSize = True
        Me.chkSeperateRoom.Location = New System.Drawing.Point(355, 92)
        Me.chkSeperateRoom.Name = "chkSeperateRoom"
        Me.chkSeperateRoom.Size = New System.Drawing.Size(119, 17)
        Me.chkSeperateRoom.TabIndex = 8
        Me.chkSeperateRoom.Text = "Seperate Bedrooms"
        Me.chkSeperateRoom.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(424, 156)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 9
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(320, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Accommodations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 202)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.chkSeperateRoom)
        Me.Controls.Add(Me.chkBathrooms)
        Me.Controls.Add(Me.chkBalcony)
        Me.Controls.Add(Me.chkCoffee)
        Me.Controls.Add(Me.chkBar)
        Me.Controls.Add(Me.chkTV)
        Me.Controls.Add(Me.chkSafe)
        Me.Controls.Add(Me.chkSofa)
        Me.Controls.Add(Me.chkDoubleBed)
        Me.Name = "Accommodations"
        Me.Text = "Accommodations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDoubleBed As CheckBox
    Friend WithEvents chkSofa As CheckBox
    Friend WithEvents chkSafe As CheckBox
    Friend WithEvents chkTV As CheckBox
    Friend WithEvents chkBar As CheckBox
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents chkBalcony As CheckBox
    Friend WithEvents chkBathrooms As CheckBox
    Friend WithEvents chkSeperateRoom As CheckBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnClose As Button
End Class
