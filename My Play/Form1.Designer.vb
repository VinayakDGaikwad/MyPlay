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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Refresh_Button = New System.Windows.Forms.Button()
        Me.Song_ListBox = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lisener_TextBox = New System.Windows.Forms.TextBox()
        Me.AxSkinFramework1 = New AxXtremeSkinFramework.AxSkinFramework()
        Me.MyPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.VerticalProgressBar1 = New My_Play.VerticalProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlayAllTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxSkinFramework1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Refresh_Button
        '
        Me.Refresh_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Refresh_Button.Location = New System.Drawing.Point(1008, 67)
        Me.Refresh_Button.Name = "Refresh_Button"
        Me.Refresh_Button.Size = New System.Drawing.Size(75, 23)
        Me.Refresh_Button.TabIndex = 1
        Me.Refresh_Button.Text = "Refresh"
        Me.Refresh_Button.UseVisualStyleBackColor = True
        '
        'Song_ListBox
        '
        Me.Song_ListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Song_ListBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.Song_ListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Song_ListBox.ForeColor = System.Drawing.Color.White
        Me.Song_ListBox.FormattingEnabled = True
        Me.Song_ListBox.ItemHeight = 108
        Me.Song_ListBox.Location = New System.Drawing.Point(12, 12)
        Me.Song_ListBox.Name = "Song_ListBox"
        Me.Song_ListBox.Size = New System.Drawing.Size(990, 328)
        Me.Song_ListBox.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1008, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lisener_TextBox
        '
        Me.Lisener_TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lisener_TextBox.Location = New System.Drawing.Point(1008, 41)
        Me.Lisener_TextBox.Name = "Lisener_TextBox"
        Me.Lisener_TextBox.Size = New System.Drawing.Size(75, 20)
        Me.Lisener_TextBox.TabIndex = 0
        '
        'AxSkinFramework1
        '
        Me.AxSkinFramework1.Enabled = True
        Me.AxSkinFramework1.Location = New System.Drawing.Point(0, 0)
        Me.AxSkinFramework1.Name = "AxSkinFramework1"
        Me.AxSkinFramework1.TabIndex = 0
        '
        'MyPlayer
        '
        Me.MyPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyPlayer.Enabled = True
        Me.MyPlayer.Location = New System.Drawing.Point(12, 340)
        Me.MyPlayer.Name = "MyPlayer"
        Me.MyPlayer.OcxState = CType(resources.GetObject("MyPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MyPlayer.Size = New System.Drawing.Size(990, 62)
        Me.MyPlayer.TabIndex = 5
        '
        'Exit_Button
        '
        Me.Exit_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exit_Button.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(1045, 12)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(38, 23)
        Me.Exit_Button.TabIndex = 6
        Me.Exit_Button.Text = "X"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'VerticalProgressBar1
        '
        Me.VerticalProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerticalProgressBar1.Location = New System.Drawing.Point(1008, 125)
        Me.VerticalProgressBar1.Name = "VerticalProgressBar1"
        Me.VerticalProgressBar1.Size = New System.Drawing.Size(75, 215)
        Me.VerticalProgressBar1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.My_Play.My.Resources.Resources.Volume
        Me.PictureBox1.Location = New System.Drawing.Point(1008, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1008, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "_"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlayAllTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1095, 414)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VerticalProgressBar1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.MyPlayer)
        Me.Controls.Add(Me.Lisener_TextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Song_ListBox)
        Me.Controls.Add(Me.Refresh_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "My Play"
        CType(Me.AxSkinFramework1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Refresh_Button As System.Windows.Forms.Button
    Friend WithEvents Song_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lisener_TextBox As System.Windows.Forms.TextBox
    Private WithEvents AxSkinFramework1 As AxXtremeSkinFramework.AxSkinFramework
    Friend WithEvents MyPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents VerticalProgressBar1 As My_Play.VerticalProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PlayAllTimer As System.Windows.Forms.Timer

End Class
