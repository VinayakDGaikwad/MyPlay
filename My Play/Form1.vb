Public Class Form1


    'I have added a lot of comments in this code. They are for beginners. Sory, If it is a mess for experts.

    'You will find a "MyplayFile.txt" file working here. This file is used to save the location of the folder which contains the music files.
    'This is where MyPlay searchs for .MP3 files.


    Public Sub DeletSelectedSong()


        'Create the original file address or O_F_A
        Dim TextFileStream As System.IO.TextReader
        TextFileStream = System.IO.File.OpenText(System.AppDomain.CurrentDomain.BaseDirectory + "MyplayFile.txt")
        Dim O_F_A As String = TextFileStream.ReadToEnd
        TextFileStream.Close()

        Dim CurrentIndex = Song_ListBox.SelectedIndex
        System.IO.File.Delete(O_F_A + "/" + Song_ListBox.SelectedItem + ".MP3")

        'Remove it from the Song_ListBox
        Song_ListBox.Items.Remove(Song_ListBox.SelectedItem)
        LodeSongList()

        'Select the next ListItem in Song_ListBox 
        Song_ListBox.SelectedIndex = CurrentIndex + 1

        'Now, play the selected song
        PlaySong(Song_ListBox.SelectedItem)

    End Sub

    Function HasDuplicates()
        Dim p = Process.GetProcessesByName("MyPlay.exe")
        If p.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function LodeSongList()
        'This sub will get the list of .mp3 files in the directotry, specifed in the "MyplayFile.txt" file. 

        'Just save the location of the user's selected item for furthere requirement 
        Dim seleceditem_location As Integer = Song_ListBox.SelectedIndex

        'Read the address from the "MyPlayFile.txt"
        Dim TextFileStream As System.IO.TextReader
        TextFileStream = System.IO.File.OpenText(System.AppDomain.CurrentDomain.BaseDirectory + "MyplayFile.txt")
        Dim MyFileContents As String = TextFileStream.ReadToEnd
        TextFileStream.Close()

        'Cheack its correct 
        If System.IO.Path.IsPathRooted(MyFileContents) = False Then
            MessageBox.Show("The path specified is Invalid")
            Return False
            Exit Function
        Else
            'Get the file list in the directory
            Dim FileAddresList() = System.IO.Directory.GetFiles(MyFileContents)
            Song_ListBox.Items.Clear()

            'Cheack the directory isn't empty
            If FileAddresList.Length > 0 Then

                'Lode the file list is into the Song_ListBox 
                For Each file In FileAddresList

                    'I did  not use the line,
                    '
                    '           Song_ListBox.Items.AddRange(FileAddresList)
                    '
                    'because I wanted to remove the extention behind the file names.

                    If System.IO.Path.GetFileName(file).Contains(".mp3") = False Then

                    Else
                        Song_ListBox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
                    End If



                Next
            Else
                'The directory is empty
                MsgBox("The directory specified is empty.", MsgBoxStyle.Exclamation, "Directory is Empty")
                Return False
                Exit Function
            End If

        End If

        'All done
        Return True

        Try
            'I don't want the user to search for the location where he/she left, after refreshing or again re-loading the list. Thus,
            'using the saved loction in seleceditem_location
            Song_ListBox.SelectedIndex = seleceditem_location
        Catch ex As ArgumentOutOfRangeException
            'In Case thats the last Item in Song_ListBox
        End Try
    End Function

    Public Sub DecreaseVolume()
        Dim CurrentVolume As Integer = MyPlayer.settings.volume
        MyPlayer.settings.volume = CurrentVolume - 10
        VerticalProgressBar1.Value = MyPlayer.settings.volume
    End Sub

    Public Sub IncreaseVolume()
        Dim CurrentVolume As Integer = MyPlayer.settings.volume
        MyPlayer.settings.volume = CurrentVolume + 10
        VerticalProgressBar1.Value = MyPlayer.settings.volume
    End Sub

    Public Sub PlaySong(ByVal Name As String)
        Dim TextFileStream As System.IO.TextReader
        TextFileStream = System.IO.File.OpenText(System.AppDomain.CurrentDomain.BaseDirectory + "MyplayFile.txt")
        Dim MyFileContents As String = TextFileStream.ReadToEnd
        TextFileStream.Close()

        MyPlayer.URL = MyFileContents + "/" + Name + ".mp3"
        MyPlayer.Ctlcontrols.play()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh_Button.Click
        LodeSongList()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(MyPlayer.Ctlcontrols.currentPosition)
        MsgBox("The Controls are as follows:- " + vbNewLine + vbNewLine + "Next Song - D" + vbNewLine + "Previous Song - A" + vbNewLine + "Volume + - W" + vbNewLine + "Volume - - S")

    End Sub

    Private Sub Lisener_TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Lisener_TextBox.KeyPress
        'Get the KeyChar pressed by the User then act for it
        Select Case e.KeyChar
            Case "D"
                'if the user press the 'D' Button, go to the next song
                Try
                    'Select the next ListItem in Song_ListBox 
                    Dim CurrentIndex = Song_ListBox.SelectedIndex
                    Song_ListBox.SelectedIndex = CurrentIndex + 1

                    'Now, play the selected song
                    PlaySong(Song_ListBox.SelectedItem)

                Catch ex As ArgumentOutOfRangeException

                    'If the SelectedItem is the last Item in the ListBox then Skip this action

                Catch ex As Exception

                    'Things don't go right all the time. Just a small error sound is enought.
                    System.Media.SystemSounds.Exclamation.Play()

                End Try
            Case "d"
                'The same thing is given here, for more explanaion, see above
                Try
                    Dim CurrentIndex = Song_ListBox.SelectedIndex
                    Song_ListBox.SelectedIndex = CurrentIndex + 1

                    PlaySong(Song_ListBox.SelectedItem)

                Catch ex As ArgumentOutOfRangeException

                Catch ex As Exception
                    System.Media.SystemSounds.Exclamation.Play()
                End Try

            Case "A"
                'If the User press the 'A' button, go to the previous song 

                Try
                    'Select the previous ListItem in Song_ListBox 
                    Dim CurrentIndex = Song_ListBox.SelectedIndex
                    Song_ListBox.SelectedIndex = CurrentIndex - 1

                    'Now, play the selected song
                    PlaySong(Song_ListBox.SelectedItem)

                Catch ex As ArgumentOutOfRangeException

                    'If the SelectedItem is the very frist Item in the ListBox then Skip this action

                Catch ex As Exception

                    'Things don't go right all the time. Just a small error sound is enought.
                    System.Media.SystemSounds.Exclamation.Play()

                End Try

            Case "a"
                'The same thing is given here, for more explanaion, see above
                Try
                    Dim CurrentIndex = Song_ListBox.SelectedIndex
                    Song_ListBox.SelectedIndex = CurrentIndex - 1
                    PlaySong(Song_ListBox.SelectedItem)
                Catch ex As ArgumentOutOfRangeException

                Catch ex As Exception
                    System.Media.SystemSounds.Exclamation.Play()
                End Try

            Case "S"
                DecreaseVolume()
            Case "s"
                DecreaseVolume()
            Case "W"
                IncreaseVolume()
            Case "w"
                IncreaseVolume()
            Case "l"
                DeletSelectedSong()
            Case "L"
                DeletSelectedSong()
            Case "e"
                Application.SetSuspendState(PowerState.Hibernate, False, False)
            Case "E"
                Application.SetSuspendState(PowerState.Hibernate, False, False)
            Case Else
                System.Media.SystemSounds.Exclamation.Play()
                e.Handled = False
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If HasDuplicates() = True Then
            Me.Close()
        End If

        PlayAllTimer.Start()

        MyPLay_Lode()
    End Sub

    Public Sub MyPLay_Lode()
        'The font is big so the window should be big
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = Windows.Forms.FormWindowState.Maximized


        VerticalProgressBar1.Value = MyPlayer.settings.volume

        'If the file "MyPlayFile.txt" does not exist, then ask for the address
        If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "MyplayFile.txt") Then
            'If It exits
            Try
                LodeSongList()
                PlaySong(Song_ListBox.Items.Item(0))
            Catch ex As Exception
                If MsgBox("There was an error while loding the Song List. Relocationg the Directory to search in, might solve the problem." + vbNewLine + _
                      vbNewLine + "Do you want to relocate the directory?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    FristStart_Dialog.ShowDialog()

                Else

                    Me.Show()

                End If
            End Try
        Else
            'If not
            FristStart_Dialog.ShowDialog()
        End If
    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        MsgBox(e.KeyCode)
    End Sub

    Private Sub Lisener_TextBox_FontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lisener_TextBox.FontChanged
        If Lisener_TextBox.Focused = False Then
            Lisener_TextBox.Focus()
        End If
    End Sub

    Private Sub Song_ListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song_ListBox.SelectedIndexChanged
        PlaySong(Song_ListBox.SelectedItem)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PlayAllTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayAllTimer.Tick
        If (MyPlayer.Ctlcontrols.currentPosition.Equals(MyPlayer.Ctlcontrols.currentItem.duration)) Then

            Try
                Dim CurrentIndex = Song_ListBox.SelectedIndex
                Song_ListBox.SelectedIndex = CurrentIndex + 1

                PlaySong(Song_ListBox.SelectedItem)

            Catch ex As ArgumentOutOfRangeException

            Catch ex As Exception
                System.Media.SystemSounds.Exclamation.Play()
            End Try

        End If
    End Sub
End Class