<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FristStart_Dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FristStart_Dialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Welcome_Lable = New System.Windows.Forms.Label()
        Me.Intro_Lable = New System.Windows.Forms.Label()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.Browse_Button = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(288, 116)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(199, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(94, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Welcome_Lable
        '
        Me.Welcome_Lable.AutoSize = True
        Me.Welcome_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_Lable.Location = New System.Drawing.Point(12, 9)
        Me.Welcome_Lable.Name = "Welcome_Lable"
        Me.Welcome_Lable.Size = New System.Drawing.Size(167, 25)
        Me.Welcome_Lable.TabIndex = 1
        Me.Welcome_Lable.Text = "MyPlay Settings"
        '
        'Intro_Lable
        '
        Me.Intro_Lable.AutoSize = True
        Me.Intro_Lable.Location = New System.Drawing.Point(14, 44)
        Me.Intro_Lable.Name = "Intro_Lable"
        Me.Intro_Lable.Size = New System.Drawing.Size(473, 26)
        Me.Intro_Lable.TabIndex = 2
        Me.Intro_Lable.Text = "Please sepcify the address of the floder  on your computer which contains all the" & _
            " music files below. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click OK to procede."
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Location = New System.Drawing.Point(12, 84)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(394, 20)
        Me.Address_TextBox.TabIndex = 3
        '
        'Browse_Button
        '
        Me.Browse_Button.Location = New System.Drawing.Point(412, 84)
        Me.Browse_Button.Name = "Browse_Button"
        Me.Browse_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse_Button.TabIndex = 4
        Me.Browse_Button.Text = "Browse.."
        Me.Browse_Button.UseVisualStyleBackColor = True
        '
        'FristStart_Dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(499, 157)
        Me.Controls.Add(Me.Browse_Button)
        Me.Controls.Add(Me.Address_TextBox)
        Me.Controls.Add(Me.Intro_Lable)
        Me.Controls.Add(Me.Welcome_Lable)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FristStart_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MyPlay Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Lable As System.Windows.Forms.Label
    Friend WithEvents Intro_Lable As System.Windows.Forms.Label
    Friend WithEvents Address_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Browse_Button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents AxSkinFramework1 As AxXtremeSkinFramework.AxSkinFramework

End Class
