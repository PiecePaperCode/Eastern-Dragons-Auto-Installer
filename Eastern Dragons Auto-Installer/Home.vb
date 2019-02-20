Public Class Home
    Public CurrentFSXPath As String = ""
    Public EffectsFSXPath As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dir As New IO.DirectoryInfo("C:\Program Files (x86)\Steam\steamapps\common\FSX")
        If dir.Exists Then
            Install("C:\Program Files (x86)\Steam\steamapps\common\FSX")
        Else
            Dim ofd As New FolderBrowserDialog With {.ShowNewFolderButton = False, .RootFolder = Environment.SpecialFolder.Desktop, .Description = "Please select FSX Root Folder"}
            If ofd.ShowDialog() = DialogResult.OK Then

                Install(ofd.SelectedPath)

            End If
        End If
    End Sub

    Function Install(path)
        Dim dir As New IO.DirectoryInfo(path & "\SimObjects\Airplanes")
        If dir.Exists Then
            CurrentFSXPath = path & "\SimObjects\Airplanes"
            EffectsFSXPath = path & "\effects"
        Else
            MessageBox.Show("Invalid Path Please Select the FSX Root Folder like D:/FSX")
            Exit Function
        End If

        Dim Airplanes As String = Application.StartupPath() & "\Airplanes"
        Dim CVN76 As String = Airplanes & "\CVN76"
        Dim EHOPS_F18 As String = Airplanes & "\EHOPS_F18"
        Dim KC_135T As String = Airplanes & "\KC_135T"
        Dim U_S_S_Fitzgerald As String = Airplanes & "\U_S_S_Fitzgerald"

        Label_Rich.Text = ""
        Try
            My.Computer.FileSystem.DeleteDirectory(CurrentFSXPath & "\CVN76", True)
            My.Computer.FileSystem.DeleteDirectory(CurrentFSXPath & "\EHOPS-F18", True)
            My.Computer.FileSystem.DeleteDirectory(CurrentFSXPath & "\KC-135T", True)
            My.Computer.FileSystem.DeleteDirectory(CurrentFSXPath & "\U.S.S.Fitzgerald", True)
        Catch ex As Exception
            Label_Rich.Text &= "Installing New Planes" & vbCrLf
        End Try

        My.Computer.FileSystem.CopyDirectory(CVN76, CurrentFSXPath & "\CVN76", True)
        ProgressBar1.Value = 25
        Label_Rich.Text &= "Installed CVN76" & vbCrLf


        My.Computer.FileSystem.CopyDirectory(EHOPS_F18, CurrentFSXPath & "\EHOPS-F18", True)
        ProgressBar1.Value = 50
        Label_Rich.Text &= "Installed EHOPS_F18" & vbCrLf


        My.Computer.FileSystem.CopyDirectory(KC_135T, CurrentFSXPath & "\KC-135T", True)
        ProgressBar1.Value = 75
        Label_Rich.Text &= "Installed KC_135T" & vbCrLf

        My.Computer.FileSystem.CopyDirectory(U_S_S_Fitzgerald, CurrentFSXPath & "\U.S.S.Fitzgerald", True)
        Try
            My.Computer.FileSystem.CopyFile(U_S_S_Fitzgerald & "\fx_Ship_smoke.fx", EffectsFSXPath & "\fx_Ship_smoke.fx")
        Catch ex As Exception
            My.Computer.FileSystem.DeleteFile(EffectsFSXPath & "\fx_Ship_smoke.fx")
        End Try
        ProgressBar1.Value = 100
        Label_Rich.Text &= "Installed U.S.S.Fitzgerald" & vbCrLf



        MessageBox.Show("Installed :)")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Credits.Show()
    End Sub
End Class
