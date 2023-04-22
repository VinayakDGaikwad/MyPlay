Imports System.Windows.Forms

Public Class FristStart_Dialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If System.IO.Path.IsPathRooted(Address_TextBox.Text) = True Then
            If System.IO.File.Exists("MyPlayFile.txt") = False Then
                System.IO.File.WriteAllText("MyPlayFile.txt", Address_TextBox.Text)

                Form1.MyPLay_Lode()
                Me.Close()
                Exit Sub
            End If

            If System.IO.File.ReadAllText("MyPlayFile.txt") = "" Then
                System.IO.File.WriteAllText("MyPlayFile.txt", Address_TextBox.Text)

                Form1.MyPLay_Lode()
                Me.Close()
                Exit Sub
            Else
                System.IO.File.WriteAllText("MyPlayFile.txt", Address_TextBox.Text)
                MsgBox("The new settings were applyed, please restart the MyPlay.", MsgBoxStyle.Information, "Restart Requiered")

                Form1.MyPLay_Lode()
                Me.Close()
                Exit Sub
            End If

        Else
            MsgBox("This path is not rooted or unreachable, please check the path.", MsgBoxStyle.Critical, "Invalid Path")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Browse_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse_Button.Click
        FolderBrowserDialog1.ShowDialog()
        Address_TextBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class
