Imports System.CodeDom
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics.CodeAnalysis
Imports System.Diagnostics.Eventing
Imports System.Dynamic
Imports System.Linq.Expressions
Imports System.Reflection.Metadata.Ecma335
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Security
Imports System.Transactions
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Xml
Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Versioning
Imports System.IO

Public Class Form1

    Public Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim versionchecker As New HttpClient
        Dim versionnumber = versionchecker.GetStringAsync("https://www.youtubetransfer.com/AtlasGUI.NewestVersion").Result
        Dim UpdateOrNot As Integer

        If versionnumber <> My.Settings.localversion Then
            UpdateOrNot = MsgBox("New version available. Do you want to download the latest version?", vbQuestion + vbYesNo + vbDefaultButton2, "Version Checker")
            If UpdateOrNot = vbYes Then
                My.Settings.localversion = versionnumber
                Process.Start("AtlasGUIUpdate.bat")
                Close()
            End If
        End If

        Dim tempname As String

        Dim TitleDuh As String = "Atlas' Youtube Downloader GUI for YT-DLP"
        Me.Text = TitleDuh + "        " + "Version: " + My.Settings.localversion

        Dim UpdateDependencies As New ProcessStartInfo("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "echo Updating dependencies, please wait..." + "&" + "yt-dlp.exe -U ") REM -q
        REM UpdateDependencies.CreateNoWindow = True
        Process.Start(UpdateDependencies)

        URL1Paste.FlatStyle = FlatStyle.Flat
        URL1Paste.FlatAppearance.BorderSize = 0
        URL2Paste.FlatStyle = FlatStyle.Flat
        URL2Paste.FlatAppearance.BorderSize = 0
        URL3Paste.FlatStyle = FlatStyle.Flat
        URL3Paste.FlatAppearance.BorderSize = 0
        URL4Paste.FlatStyle = FlatStyle.Flat
        URL4Paste.FlatAppearance.BorderSize = 0
        URL5Paste.FlatStyle = FlatStyle.Flat
        URL5Paste.FlatAppearance.BorderSize = 0
        URL6Paste.FlatStyle = FlatStyle.Flat
        URL6Paste.FlatAppearance.BorderSize = 0
        URL7Paste.FlatStyle = FlatStyle.Flat
        URL7Paste.FlatAppearance.BorderSize = 0
        URL8Paste.FlatStyle = FlatStyle.Flat
        URL8Paste.FlatAppearance.BorderSize = 0
        URL9Paste.FlatStyle = FlatStyle.Flat
        URL9Paste.FlatAppearance.BorderSize = 0
        URL10Paste.FlatStyle = FlatStyle.Flat
        URL10Paste.FlatAppearance.BorderSize = 0
        SelectFolderButton.FlatStyle = FlatStyle.Flat
        SelectFolderButton.FlatAppearance.BorderSize = 0
        LagringsMappeTB.Text = My.Settings.defaultfolder
        Resolution.SelectedIndex = My.Settings.defaultresolution
        ResDefaulter.Image = My.Resources.checked
        FolderDefaulter.Image = My.Resources.checked
        TextBoxFolderQ.Text = "Current folder is default!"
        TextBoxResQ.Text = "Current res." & Environment.NewLine & "is default!"
        LagringsMappeTB.Text = My.Settings.defaultfolder
        Resolution.SelectedIndex = My.Settings.defaultresolution

    End Sub

    Public Sub StartDownload_Click(sender As Object, e As EventArgs) Handles StartDownload.Click
        RunTheThing.RunCommandCom("")
    End Sub

    Public Sub URL1Paste_Click(sender As Object, e As EventArgs) Handles URL1Paste.Click
        URL1.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL1.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL1Name.ForeColor = Color.Green
        URL1Name.Text = std_out.ReadToEnd()
        If URL1Name.Text = "" Then
            URL1Name.Text = "VIDEO NOT FOUND!"
            URL1Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL2Paste_Click(sender As Object, e As EventArgs) Handles URL2Paste.Click
        URL2.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL2.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL2Name.ForeColor = Color.Green
        URL2Name.Text = std_out.ReadToEnd()
        If URL2Name.Text = "" Then
            URL2Name.Text = "VIDEO NOT FOUND!"
            URL2Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL3Paste_Click(sender As Object, e As EventArgs) Handles URL3Paste.Click
        URL3.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL3.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL3Name.ForeColor = Color.Green
        URL3Name.Text = std_out.ReadToEnd()
        If URL3Name.Text = "" Then
            URL3Name.Text = "VIDEO NOT FOUND!"
            URL3Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL4Paste_Click(sender As Object, e As EventArgs) Handles URL4Paste.Click
        URL4.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL4.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL4Name.ForeColor = Color.Green
        URL4Name.Text = std_out.ReadToEnd()
        If URL4Name.Text = "" Then
            URL4Name.Text = "VIDEO NOT FOUND!"
            URL4Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL5Paste_Click(sender As Object, e As EventArgs) Handles URL5Paste.Click
        URL5.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL5.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL5Name.ForeColor = Color.Green
        URL5Name.Text = std_out.ReadToEnd()
        If URL5Name.Text = "" Then
            URL5Name.Text = "VIDEO NOT FOUND!"
            URL5Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL6Paste_Click(sender As Object, e As EventArgs) Handles URL6Paste.Click
        URL6.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL6.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL6Name.ForeColor = Color.Green
        URL6Name.Text = std_out.ReadToEnd()
        If URL6Name.Text = "" Then
            URL6Name.Text = "VIDEO NOT FOUND!"
            URL6Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL7Paste_Click(sender As Object, e As EventArgs) Handles URL7Paste.Click
        URL7.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL7.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL7Name.ForeColor = Color.Green
        URL7Name.Text = std_out.ReadToEnd()
        If URL7Name.Text = "" Then
            URL7Name.Text = "VIDEO NOT FOUND!"
            URL7Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL8Paste_Click(sender As Object, e As EventArgs) Handles URL8Paste.Click
        URL8.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL8.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL8Name.ForeColor = Color.Green
        URL8Name.Text = std_out.ReadToEnd()
        If URL8Name.Text = "" Then
            URL8Name.Text = "VIDEO NOT FOUND!"
            URL8Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL9Paste_Click(sender As Object, e As EventArgs) Handles URL9Paste.Click
        URL9.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL9.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL9Name.ForeColor = Color.Green
        URL9Name.Text = std_out.ReadToEnd()
        If URL9Name.Text = "" Then
            URL9Name.Text = "VIDEO NOT FOUND!"
            URL9Name.ForeColor = Color.Red
        End If
    End Sub
    Private Sub URL10Paste_Click(sender As Object, e As EventArgs) Handles URL10Paste.Click
        URL10.Text = Clipboard.GetText

        Dim start_info As New ProcessStartInfo("yt-dlp", "--print filename " + URL10.Text)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True
        Dim tempnamefinder As New Process()
        tempnamefinder.StartInfo = start_info

        tempnamefinder.Start()

        Dim std_out As StreamReader = tempnamefinder.StandardOutput()
        Dim std_err As StreamReader = tempnamefinder.StandardError()

        URL10Name.ForeColor = Color.Green
        URL10Name.Text = std_out.ReadToEnd()
        If URL10Name.Text = "" Then
            URL10Name.Text = "VIDEO NOT FOUND!"
            URL10Name.ForeColor = Color.Red
        End If
    End Sub

    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        FolderBrowserDialog1.ShowDialog()
        LagringsMappeTB.Text = FolderBrowserDialog1.SelectedPath
        TextBoxFolderQ.Text = "Set folder as default?"
        FolderDefaulter.Image = My.Resources.savefolder
    End Sub

    Private Sub LagringsMappeTB_TextChanged(sender As Object, e As EventArgs) Handles LagringsMappeTB.TextChanged
        TextBoxFolderQ.Text = "Set folder as default?"
        FolderDefaulter.Image = My.Resources.savefolder
    End Sub

    Private Sub FolderDefaulter_Click_1(sender As Object, e As EventArgs) Handles FolderDefaulter.Click
        My.Settings.defaultfolder = LagringsMappeTB.Text
        My.Settings.Save()
        TextBoxFolderQ.Text = "Current folder is default!"
        FolderDefaulter.Image = My.Resources.checked
    End Sub

    Private Sub Resolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Resolution.SelectedIndexChanged
        TextBoxResQ.Text = "Set res." & Environment.NewLine & "as default?"
        ResDefaulter.Image = My.Resources.savefolder
    End Sub

    Private Sub ResDefaulter_Click(sender As Object, e As EventArgs) Handles ResDefaulter.Click
        TextBoxResQ.Text = "Current res." & Environment.NewLine & "is default!"
        ResDefaulter.Image = My.Resources.checked
        My.Settings.defaultresolution = Resolution.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub ResetURLs_Click(sender As Object, e As EventArgs) Handles ResetURLs.Click
        URL1.Text = Nothing
        URL2.Text = Nothing
        URL3.Text = Nothing
        URL4.Text = Nothing
        URL5.Text = Nothing
        URL6.Text = Nothing
        URL7.Text = Nothing
        URL8.Text = Nothing
        URL9.Text = Nothing
        URL10.Text = Nothing
        URL1Name.Text = Nothing
        URL2Name.Text = Nothing
        URL3Name.Text = Nothing
        URL4Name.Text = Nothing
        URL5Name.Text = Nothing
        URL6Name.Text = Nothing
        URL7Name.Text = Nothing
        URL8Name.Text = Nothing
        URL9Name.Text = Nothing
        URL10Name.Text = Nothing
    End Sub

End Class

Public Class RunTheThing
    Shared Sub RunCommandCom(argses As String)
        Dim SelectedResolution As String = Form1.Resolution.SelectedItem.ToString
        Dim LagringsMappe As String = Form1.LagringsMappeTB.Text
        Dim SetAudioOnly As Boolean = Form1.SetAudioOnly.Checked
        Dim URL1Temp As String = Form1.URL1.Text
        Dim URL2Temp As String = Form1.URL2.Text
        Dim URL3Temp As String = Form1.URL3.Text
        Dim URL4Temp As String = Form1.URL4.Text
        Dim URL5Temp As String = Form1.URL5.Text
        Dim URL6Temp As String = Form1.URL6.Text
        Dim URL7Temp As String = Form1.URL7.Text
        Dim URL8Temp As String = Form1.URL8.Text
        Dim URL9Temp As String = Form1.URL9.Text
        Dim URL10Temp As String = Form1.URL10.Text
        Dim URL1Done As String = URL1Temp
        Dim URL2Done As String = URL2Temp
        Dim URL3Done As String = URL3Temp
        Dim URL4Done As String = URL4Temp
        Dim URL5Done As String = URL5Temp
        Dim URL6Done As String = URL6Temp
        Dim URL7Done As String = URL7Temp
        Dim URL8Done As String = URL8Temp
        Dim URL9Done As String = URL9Temp
        Dim URL10Done As String = URL10Temp
        Dim urlpos As Integer = InStr(URL1Temp, "&")
        If urlpos > 0 Then URL1Done = URL1Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL2Temp, "&")
        If urlpos > 0 Then URL2Done = URL2Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL3Temp, "&")
        If urlpos > 0 Then URL3Done = URL3Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL4Temp, "&")
        If urlpos > 0 Then URL4Done = URL4Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL5Temp, "&")
        If urlpos > 0 Then URL5Done = URL5Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL6Temp, "&")
        If urlpos > 0 Then URL6Done = URL6Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL7Temp, "&")
        If urlpos > 0 Then URL7Done = URL7Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL8Temp, "&")
        If urlpos > 0 Then URL8Done = URL8Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL9Temp, "&")
        If urlpos > 0 Then URL9Done = URL9Temp.Insert(urlpos - 1, "^")
        urlpos = InStr(URL10Temp, "&")
        If urlpos > 0 Then URL10Done = URL10Temp.Insert(urlpos - 1, "^")

        REM If SetAudioOnly = False Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL1Done + "" + " " + "" + URL2Done + "" + " " + "" + URL3Done + "" + " " + "" + URL4Done + "" + " " + "" + URL5Done + "" + " " + "" + URL6Done + "" + " " + "" + URL7Done + "" + " " + "" + URL8Done + "" + " " + "" + URL9Done + "" + " " + "" + URL10Done + "")
        If SetAudioOnly = False Then
            If Form1.URL1Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL1Done)
            If Form1.URL2Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL2Done)
            If Form1.URL3Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL3Done)
            If Form1.URL4Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL4Done)
            If Form1.URL5Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL5Done)
            If Form1.URL6Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL6Done)
            If Form1.URL7Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL7Done)
            If Form1.URL8Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL8Done)
            If Form1.URL9Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL9Done)
            If Form1.URL10Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe" + " -S " + "" + "res:" + SelectedResolution + ",fps" + "" + " " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL10Done)
        End If

        REM If SetAudioOnly = True Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL1Done + "" + " " + "" + URL2Done + "" + " " + "" + URL3Done + "" + " " + "" + URL4Done + "" + " " + "" + URL5Done + "" + " " + "" + URL6Done + "" + " " + "" + URL7Done + "" + " " + "" + URL8Done + "" + " " + "" + URL9Done + "" + " " + "" + URL10Done + "")
        If SetAudioOnly = True Then
            If Form1.URL1Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL1Done)
            If Form1.URL2Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL2Done)
            If Form1.URL3Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL3Done)
            If Form1.URL4Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL4Done)
            If Form1.URL5Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL5Done)
            If Form1.URL6Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL6Done)
            If Form1.URL7Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL7Done)
            If Form1.URL8Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL8Done)
            If Form1.URL9Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL9Done)
            If Form1.URL10Name.Text <> "" Then Process.Start("cmd", "/C Title Atlas' Youtube Downloader GUI for YT-DLP V2.0" + "&" + "Setlocal EnableDelayedExpansion" + "&" + "yt-dlp.exe -U -q " + "&" + "yt-dlp.exe -f ba " + "--yes-playlist " + "-P " + "" + LagringsMappe + "" + " " + "" + URL10Done)
        End If
    End Sub
End Class