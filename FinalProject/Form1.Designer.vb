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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSpecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostExpensiveRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheapestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostExpensiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstRooms = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewRoom = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstSpecs = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ResetToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRoomToolStripMenuItem, Me.ToolStripMenuItem3, Me.DeleteSpecToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Delete Options"
        '
        'DeleteRoomToolStripMenuItem
        '
        Me.DeleteRoomToolStripMenuItem.Name = "DeleteRoomToolStripMenuItem"
        Me.DeleteRoomToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeleteRoomToolStripMenuItem.Text = "Delete Room"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(139, 6)
        '
        'DeleteSpecToolStripMenuItem
        '
        Me.DeleteSpecToolStripMenuItem.Name = "DeleteSpecToolStripMenuItem"
        Me.DeleteSpecToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeleteSpecToolStripMenuItem.Text = "Delete Spec"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostExpensiveRoomToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'MostExpensiveRoomToolStripMenuItem
        '
        Me.MostExpensiveRoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheapestToolStripMenuItem, Me.MostExpensiveToolStripMenuItem})
        Me.MostExpensiveRoomToolStripMenuItem.Name = "MostExpensiveRoomToolStripMenuItem"
        Me.MostExpensiveRoomToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.MostExpensiveRoomToolStripMenuItem.Text = "Find"
        '
        'CheapestToolStripMenuItem
        '
        Me.CheapestToolStripMenuItem.Name = "CheapestToolStripMenuItem"
        Me.CheapestToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CheapestToolStripMenuItem.Text = "Cheapest"
        '
        'MostExpensiveToolStripMenuItem
        '
        Me.MostExpensiveToolStripMenuItem.Name = "MostExpensiveToolStripMenuItem"
        Me.MostExpensiveToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MostExpensiveToolStripMenuItem.Text = "Most expensive"
        '
        'lstRooms
        '
        Me.lstRooms.FormattingEnabled = True
        Me.lstRooms.Location = New System.Drawing.Point(12, 68)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.Size = New System.Drawing.Size(120, 95)
        Me.lstRooms.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Rooms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Room Specs:"
        '
        'btnNewRoom
        '
        Me.btnNewRoom.Location = New System.Drawing.Point(298, 221)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(90, 23)
        Me.btnNewRoom.TabIndex = 5
        Me.btnNewRoom.Text = "New Room"
        Me.btnNewRoom.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 221)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstSpecs
        '
        Me.lstSpecs.FormattingEnabled = True
        Me.lstSpecs.HorizontalScrollbar = True
        Me.lstSpecs.Location = New System.Drawing.Point(188, 68)
        Me.lstSpecs.Name = "lstSpecs"
        Me.lstSpecs.Size = New System.Drawing.Size(200, 95)
        Me.lstSpecs.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 254)
        Me.Controls.Add(Me.lstSpecs)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNewRoom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRooms)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Hotel Rooms"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DeleteRoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents DeleteSpecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstRooms As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewRoom As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostExpensiveRoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheapestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostExpensiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstSpecs As ListBox
End Class
