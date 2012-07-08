Imports System.IO

Public Class frmMain
    Dim backupPath As String = My.Application.Info.DirectoryPath & "\backups"
    Dim savesPath As String = "C:\Program Files (x86)\Steam\steamapps\common\Uplink\users"
    Dim DirInfoSaves As New DirectoryInfo(savesPath)
    Dim DirInfoBackups As New DirectoryInfo(backupPath)
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DirInfoBackups.Exists() Then
            DirInfoBackups.Create()
        End If
        Call refreshLists()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim saveFile As FileInfo = New FileInfo(savesPath & "\" & lstSaves.SelectedItem & ".usr")
        saveFile.CopyTo(backupPath & "\" & lstSaves.SelectedItem.ToString.Replace(".usr", "") & " " & DateTime.Now.ToString("d-M-yyyy HH-mm-ss") & ".bak")

        Call refreshLists()
    End Sub

    Sub refreshLists()
        lstSaves.Items.Clear()
        lstBackups.Items.Clear()
        Dim saveFiles = DirInfoSaves.EnumerateFiles("*.usr")
        For Each f As FileInfo In saveFiles
            lstSaves.Items.Add(f.Name.ToString.Replace(".usr", ""))
        Next

        Dim backupFiles = DirInfoBackups.EnumerateFiles("*.bak")
        For Each f As FileInfo In backupFiles
            lstBackups.Items.Add(f.Name.ToString.Replace(".bak", "")).ToString.Replace(".bak", "")
        Next
    End Sub
End Class
