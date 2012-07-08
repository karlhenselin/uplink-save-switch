Imports System.IO

Public Class frmMain
    Dim backupPath As String = My.Application.Info.DirectoryPath & "\backups"
    Dim savesPath As String = "C:/blankpathUSS"
    Dim DirInfoBackups As New DirectoryInfo(backupPath)
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.strSaveDirectory <> "" Then
            savesPath = My.Settings.strSaveDirectory
        End If
        If Not DirInfoBackups.Exists() Then
            DirInfoBackups.Create()
        End If
        Call refreshLists()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim saveFile As FileInfo = New FileInfo(savesPath & "\" & lstSaves.SelectedItem & ".usr")
        saveFile.CopyTo(backupPath & "\" & lstSaves.SelectedItem.ToString.Replace(".usr", "") & "  " & DateTime.Now.ToString("d-M-yyyy HH-mm-ss") & ".bak")

        Call refreshLists()
    End Sub

    Sub refreshLists()
        If My.Settings.strSaveDirectory <> "" Then
            savesPath = My.Settings.strSaveDirectory
        End If
        Dim DirInfoSaves As New DirectoryInfo(savesPath)
        lstSaves.Items.Clear()
        lstBackups.Items.Clear()

        Dim backupCount As Integer = 0
        Dim saveCount As Integer = 0

        Dim saveFiles = DirInfoSaves.EnumerateFiles("*.usr")
        For Each f As FileInfo In saveFiles
            lstSaves.Items.Add(f.Name.ToString.Replace(".usr", ""))
            saveCount += 1
        Next

        Dim backupFiles = DirInfoBackups.EnumerateFiles("*.bak")
        For Each f As FileInfo In backupFiles
            lstBackups.Items.Add(f.Name.ToString.Replace(".bak", "")).ToString.Replace(".bak", "")
            backupCount += 1
        Next

        If saveCount > 0 Then
            btnBackup.Enabled = True
        Else
            btnBackup.Enabled = False
        End If

        If backupCount > 0 Then
            btnRestore.Enabled = True
        Else
            btnRestore.Enabled = False
        End If

        StatusLabel.Text = saveCount & " saves and " & backupCount & " backups loaded"

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim newFileName = lstBackups.SelectedItem.ToString.Split("  ")(0) & ".usr"
        Dim originalFile As FileInfo = New FileInfo(savesPath & "\" & newFileName)
        If originalFile.Exists Then
            originalFile.CopyTo(savesPath & "\" & newFileName & ".bak")
            originalFile.Delete()
            Dim saveFile As FileInfo = New FileInfo(backupPath & "\" & lstBackups.SelectedItem & ".bak")
            saveFile.CopyTo(savesPath & "\" & newFileName)
            Dim backupFile As FileInfo = New FileInfo(savesPath & "\" & newFileName & ".bak")
            backupFile.Delete()
        End If
        Call refreshLists()
    End Sub
End Class
