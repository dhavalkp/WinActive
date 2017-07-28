<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.activateWindows = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.checkActivation = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.disableSmartscreen = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.enableSmartscreen = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LogBox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.madeBy = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 26)
        Me.Panel1.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitButton.BorderRadius = 0
        Me.exitButton.ButtonText = "X"
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.DisabledColor = System.Drawing.Color.Gray
        Me.exitButton.Iconcolor = System.Drawing.Color.Transparent
        Me.exitButton.Iconimage = Nothing
        Me.exitButton.Iconimage_right = Nothing
        Me.exitButton.Iconimage_right_Selected = Nothing
        Me.exitButton.Iconimage_Selected = Nothing
        Me.exitButton.IconMarginLeft = 0
        Me.exitButton.IconMarginRight = 0
        Me.exitButton.IconRightVisible = True
        Me.exitButton.IconRightZoom = 0R
        Me.exitButton.IconVisible = True
        Me.exitButton.IconZoom = 90.0R
        Me.exitButton.IsTab = False
        Me.exitButton.Location = New System.Drawing.Point(767, 5)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.exitButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.exitButton.OnHoverTextColor = System.Drawing.Color.White
        Me.exitButton.selected = False
        Me.exitButton.Size = New System.Drawing.Size(27, 18)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "X"
        Me.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.exitButton.Textcolor = System.Drawing.Color.White
        Me.exitButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 2)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "WinActive"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'activateWindows
        '
        Me.activateWindows.Activecolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.activateWindows.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.activateWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.activateWindows.BorderRadius = 0
        Me.activateWindows.ButtonText = "Activate Windows"
        Me.activateWindows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.activateWindows.DisabledColor = System.Drawing.Color.Gray
        Me.activateWindows.Iconcolor = System.Drawing.Color.Transparent
        Me.activateWindows.Iconimage = Nothing
        Me.activateWindows.Iconimage_right = Nothing
        Me.activateWindows.Iconimage_right_Selected = Nothing
        Me.activateWindows.Iconimage_Selected = Nothing
        Me.activateWindows.IconMarginLeft = 0
        Me.activateWindows.IconMarginRight = 0
        Me.activateWindows.IconRightVisible = True
        Me.activateWindows.IconRightZoom = 0R
        Me.activateWindows.IconVisible = True
        Me.activateWindows.IconZoom = 90.0R
        Me.activateWindows.IsTab = False
        Me.activateWindows.Location = New System.Drawing.Point(13, 362)
        Me.activateWindows.Name = "activateWindows"
        Me.activateWindows.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.activateWindows.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.activateWindows.OnHoverTextColor = System.Drawing.Color.DarkGray
        Me.activateWindows.selected = False
        Me.activateWindows.Size = New System.Drawing.Size(186, 48)
        Me.activateWindows.TabIndex = 2
        Me.activateWindows.Text = "Activate Windows"
        Me.activateWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.activateWindows.Textcolor = System.Drawing.Color.DarkGray
        Me.activateWindows.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'checkActivation
        '
        Me.checkActivation.Activecolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.checkActivation.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.checkActivation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.checkActivation.BorderRadius = 0
        Me.checkActivation.ButtonText = "Check Activation"
        Me.checkActivation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkActivation.DisabledColor = System.Drawing.Color.Gray
        Me.checkActivation.Iconcolor = System.Drawing.Color.Transparent
        Me.checkActivation.Iconimage = Nothing
        Me.checkActivation.Iconimage_right = Nothing
        Me.checkActivation.Iconimage_right_Selected = Nothing
        Me.checkActivation.Iconimage_Selected = Nothing
        Me.checkActivation.IconMarginLeft = 0
        Me.checkActivation.IconMarginRight = 0
        Me.checkActivation.IconRightVisible = True
        Me.checkActivation.IconRightZoom = 0R
        Me.checkActivation.IconVisible = True
        Me.checkActivation.IconZoom = 90.0R
        Me.checkActivation.IsTab = False
        Me.checkActivation.Location = New System.Drawing.Point(13, 308)
        Me.checkActivation.Name = "checkActivation"
        Me.checkActivation.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.checkActivation.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.checkActivation.OnHoverTextColor = System.Drawing.Color.DarkGray
        Me.checkActivation.selected = False
        Me.checkActivation.Size = New System.Drawing.Size(186, 48)
        Me.checkActivation.TabIndex = 3
        Me.checkActivation.Text = "Check Activation"
        Me.checkActivation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkActivation.Textcolor = System.Drawing.Color.DarkGray
        Me.checkActivation.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'disableSmartscreen
        '
        Me.disableSmartscreen.Activecolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.disableSmartscreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.disableSmartscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.disableSmartscreen.BorderRadius = 0
        Me.disableSmartscreen.ButtonText = "Disable Smartscreen"
        Me.disableSmartscreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.disableSmartscreen.DisabledColor = System.Drawing.Color.Gray
        Me.disableSmartscreen.Iconcolor = System.Drawing.Color.Transparent
        Me.disableSmartscreen.Iconimage = Nothing
        Me.disableSmartscreen.Iconimage_right = Nothing
        Me.disableSmartscreen.Iconimage_right_Selected = Nothing
        Me.disableSmartscreen.Iconimage_Selected = Nothing
        Me.disableSmartscreen.IconMarginLeft = 0
        Me.disableSmartscreen.IconMarginRight = 0
        Me.disableSmartscreen.IconRightVisible = True
        Me.disableSmartscreen.IconRightZoom = 0R
        Me.disableSmartscreen.IconVisible = True
        Me.disableSmartscreen.IconZoom = 90.0R
        Me.disableSmartscreen.IsTab = False
        Me.disableSmartscreen.Location = New System.Drawing.Point(599, 362)
        Me.disableSmartscreen.Name = "disableSmartscreen"
        Me.disableSmartscreen.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.disableSmartscreen.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.disableSmartscreen.OnHoverTextColor = System.Drawing.Color.DarkGray
        Me.disableSmartscreen.selected = False
        Me.disableSmartscreen.Size = New System.Drawing.Size(186, 48)
        Me.disableSmartscreen.TabIndex = 4
        Me.disableSmartscreen.Text = "Disable Smartscreen"
        Me.disableSmartscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.disableSmartscreen.Textcolor = System.Drawing.Color.DarkGray
        Me.disableSmartscreen.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'enableSmartscreen
        '
        Me.enableSmartscreen.Activecolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.enableSmartscreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.enableSmartscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enableSmartscreen.BorderRadius = 0
        Me.enableSmartscreen.ButtonText = "Enable Smartscreen"
        Me.enableSmartscreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enableSmartscreen.DisabledColor = System.Drawing.Color.Gray
        Me.enableSmartscreen.Iconcolor = System.Drawing.Color.Transparent
        Me.enableSmartscreen.Iconimage = Nothing
        Me.enableSmartscreen.Iconimage_right = Nothing
        Me.enableSmartscreen.Iconimage_right_Selected = Nothing
        Me.enableSmartscreen.Iconimage_Selected = Nothing
        Me.enableSmartscreen.IconMarginLeft = 0
        Me.enableSmartscreen.IconMarginRight = 0
        Me.enableSmartscreen.IconRightVisible = True
        Me.enableSmartscreen.IconRightZoom = 0R
        Me.enableSmartscreen.IconVisible = True
        Me.enableSmartscreen.IconZoom = 90.0R
        Me.enableSmartscreen.IsTab = False
        Me.enableSmartscreen.Location = New System.Drawing.Point(599, 308)
        Me.enableSmartscreen.Name = "enableSmartscreen"
        Me.enableSmartscreen.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.enableSmartscreen.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.enableSmartscreen.OnHoverTextColor = System.Drawing.Color.DarkGray
        Me.enableSmartscreen.selected = False
        Me.enableSmartscreen.Size = New System.Drawing.Size(186, 48)
        Me.enableSmartscreen.TabIndex = 5
        Me.enableSmartscreen.Text = "Enable Smartscreen"
        Me.enableSmartscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.enableSmartscreen.Textcolor = System.Drawing.Color.DarkGray
        Me.enableSmartscreen.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LogBox2
        '
        Me.LogBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LogBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LogBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.LogBox2.Location = New System.Drawing.Point(12, 32)
        Me.LogBox2.Multiline = True
        Me.LogBox2.Name = "LogBox2"
        Me.LogBox2.ReadOnly = True
        Me.LogBox2.Size = New System.Drawing.Size(773, 241)
        Me.LogBox2.TabIndex = 6
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 279)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(797, 23)
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'madeBy
        '
        Me.madeBy.AutoSize = True
        Me.madeBy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.madeBy.ForeColor = System.Drawing.SystemColors.GrayText
        Me.madeBy.Location = New System.Drawing.Point(371, 400)
        Me.madeBy.Name = "madeBy"
        Me.madeBy.Size = New System.Drawing.Size(56, 13)
        Me.madeBy.TabIndex = 1
        Me.madeBy.Text = "By: Raven"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(797, 422)
        Me.Controls.Add(Me.madeBy)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.LogBox2)
        Me.Controls.Add(Me.enableSmartscreen)
        Me.Controls.Add(Me.disableSmartscreen)
        Me.Controls.Add(Me.checkActivation)
        Me.Controls.Add(Me.activateWindows)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents checkActivation As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents activateWindows As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents enableSmartscreen As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents disableSmartscreen As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LogBox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents madeBy As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents exitButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
