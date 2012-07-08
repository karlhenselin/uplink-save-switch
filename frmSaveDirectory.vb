Imports System.Windows.Forms

Public Class frmSaveDirectory

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmSaveDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OSversionMajor As Integer = Environment.OSVersion.Version.Major '5 XP 6 Vista/7
        Dim OSversionMinor As Integer = Environment.OSVersion.Version.Minor '1 XP, 0 Vista, 1 7

        Select Case OSversionMajor
            Case 5
                cmbOS.SelectedIndex = cmbOS.FindStringExact("XP")
            Case 6
                Select Case OSversionMinor
                    Case 0
                        cmbOS.SelectedIndex = cmbOS.FindStringExact("Vista")
                    Case 1
                        cmbOS.SelectedIndex = cmbOS.FindStringExact("7")
                End Select
        End Select

        If Environment.Is64BitOperatingSystem Then
            rdo64.Select()
        End If

        Call generateDirectoryString()
    End Sub

    Sub generateDirectoryString()
        Dim dString As String = ""
        Dim sVirtualStore = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString.Replace("Roaming", "Local")

        If chkSteam.Checked Then
            dString = "C:\Program Files\Steam\steamapps\common\Uplink\users"
            cmbOS.Enabled = False
        Else
            cmbOS.Enabled = True
            Select Case cmbOS.SelectedItem.ToString()
                Case "XP"
                    dString = "C:\Program Files\Uplink\users"
                Case "Vista"
                    dString = sVirtualStore & "\Program Files\Uplink\users"
                Case "7"
                    dString = sVirtualStore & "\Program Files\Uplink\users"
            End Select
        End If

        If rdo64.Checked Then
            dString = dString.Replace("Program Files", "Program Files (x86)")
        End If

        txtDirectory.Text = dString
    End Sub

    Private Sub SelectedChanged(sender As Object, e As EventArgs) Handles cmbOS.SelectedIndexChanged, rdo64.CheckedChanged, rdo86.CheckedChanged, chkSteam.CheckedChanged
        Call generateDirectoryString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim FolderBrowserDialog As New FolderBrowserDialog
        With FolderBrowserDialog
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = "c:\"
            .Description = "Select the save directory"
            If .ShowDialog = DialogResult.OK Then
                txtDirectory.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IO.Directory.Exists(txtDirectory.Text) Then
            My.Settings.strSaveDirectory = txtDirectory.Text
            My.Settings.Save()
            Me.Close()
            frmMain.refreshLists()
        Else
            MessageBox.Show("The selected directory does not exist")
        End If
    End Sub
End Class
