<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Resolution = New ListBox()
        URL1 = New TextBox()
        StartDownload = New Button()
        LagringsMappeTB = New TextBox()
        SelectFolderButton = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        URL1Paste = New Button()
        URL2Paste = New Button()
        URL2 = New TextBox()
        URL4Paste = New Button()
        URL4 = New TextBox()
        URL3Paste = New Button()
        URL3 = New TextBox()
        URL8Paste = New Button()
        URL8 = New TextBox()
        URL7Paste = New Button()
        URL7 = New TextBox()
        URL6Paste = New Button()
        URL6 = New TextBox()
        URL5Paste = New Button()
        URL5 = New TextBox()
        URL10Paste = New Button()
        URL10 = New TextBox()
        URL9Paste = New Button()
        URL9 = New TextBox()
        FolderDefaulter = New Button()
        ResDefaulter = New Button()
        TextBoxFolderQ = New TextBox()
        TextBoxResQ = New TextBox()
        ResetURLs = New Button()
        SillyLittleTextBox = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SetAudioOnly = New CheckBox()
        URL1Name = New TextBox()
        InfoPasteURL = New TextBox()
        InfoManualURL = New TextBox()
        InfoFileName = New TextBox()
        URL2Name = New TextBox()
        URL4Name = New TextBox()
        URL3Name = New TextBox()
        URL8Name = New TextBox()
        URL7Name = New TextBox()
        URL6Name = New TextBox()
        URL5Name = New TextBox()
        URL10Name = New TextBox()
        URL9Name = New TextBox()
        SuspendLayout()
        ' 
        ' Resolution
        ' 
        Resolution.FormattingEnabled = True
        Resolution.ItemHeight = 30
        Resolution.Items.AddRange(New Object() {"144", "240", "360", "480", "720", "1080", "1440", "2160"})
        Resolution.Location = New Point(89, 368)
        Resolution.Name = "Resolution"
        Resolution.Size = New Size(60, 244)
        Resolution.TabIndex = 0
        ' 
        ' URL1
        ' 
        URL1.Location = New Point(368, 80)
        URL1.Name = "URL1"
        URL1.Size = New Size(1087, 35)
        URL1.TabIndex = 1
        ' 
        ' StartDownload
        ' 
        StartDownload.BackColor = Color.Green
        StartDownload.ForeColor = Color.Black
        StartDownload.Location = New Point(801, 956)
        StartDownload.Name = "StartDownload"
        StartDownload.Size = New Size(138, 43)
        StartDownload.TabIndex = 2
        StartDownload.Text = "Start download"
        StartDownload.UseVisualStyleBackColor = False
        ' 
        ' LagringsMappeTB
        ' 
        LagringsMappeTB.Location = New Point(368, 886)
        LagringsMappeTB.Name = "LagringsMappeTB"
        LagringsMappeTB.Size = New Size(876, 35)
        LagringsMappeTB.TabIndex = 3
        ' 
        ' SelectFolderButton
        ' 
        SelectFolderButton.BackColor = Color.Black
        SelectFolderButton.ForeColor = Color.Black
        SelectFolderButton.Image = My.Resources.Resources.icons8_open_file_folder_48
        SelectFolderButton.Location = New Point(286, 877)
        SelectFolderButton.Name = "SelectFolderButton"
        SelectFolderButton.Size = New Size(53, 56)
        SelectFolderButton.TabIndex = 4
        SelectFolderButton.UseVisualStyleBackColor = False
        ' 
        ' URL1Paste
        ' 
        URL1Paste.ForeColor = Color.Black
        URL1Paste.Image = My.Resources.Resources.icons8_paste_40
        URL1Paste.Location = New Point(273, 71)
        URL1Paste.Name = "URL1Paste"
        URL1Paste.Size = New Size(66, 53)
        URL1Paste.TabIndex = 5
        URL1Paste.UseVisualStyleBackColor = True
        ' 
        ' URL2Paste
        ' 
        URL2Paste.ForeColor = Color.Black
        URL2Paste.Image = My.Resources.Resources.icons8_paste_40
        URL2Paste.Location = New Point(273, 152)
        URL2Paste.Name = "URL2Paste"
        URL2Paste.Size = New Size(66, 53)
        URL2Paste.TabIndex = 7
        URL2Paste.UseVisualStyleBackColor = True
        ' 
        ' URL2
        ' 
        URL2.Location = New Point(368, 160)
        URL2.Name = "URL2"
        URL2.Size = New Size(1087, 35)
        URL2.TabIndex = 6
        ' 
        ' URL4Paste
        ' 
        URL4Paste.ForeColor = Color.Black
        URL4Paste.Image = My.Resources.Resources.icons8_paste_40
        URL4Paste.Location = New Point(273, 315)
        URL4Paste.Name = "URL4Paste"
        URL4Paste.Size = New Size(66, 53)
        URL4Paste.TabIndex = 11
        URL4Paste.UseVisualStyleBackColor = True
        ' 
        ' URL4
        ' 
        URL4.Location = New Point(368, 323)
        URL4.Name = "URL4"
        URL4.Size = New Size(1087, 35)
        URL4.TabIndex = 10
        ' 
        ' URL3Paste
        ' 
        URL3Paste.ForeColor = Color.Black
        URL3Paste.Image = My.Resources.Resources.icons8_paste_40
        URL3Paste.Location = New Point(273, 234)
        URL3Paste.Name = "URL3Paste"
        URL3Paste.Size = New Size(66, 53)
        URL3Paste.TabIndex = 9
        URL3Paste.UseVisualStyleBackColor = True
        ' 
        ' URL3
        ' 
        URL3.Location = New Point(368, 243)
        URL3.Name = "URL3"
        URL3.Size = New Size(1087, 35)
        URL3.TabIndex = 8
        ' 
        ' URL8Paste
        ' 
        URL8Paste.ForeColor = Color.Black
        URL8Paste.Image = My.Resources.Resources.icons8_paste_40
        URL8Paste.Location = New Point(273, 638)
        URL8Paste.Name = "URL8Paste"
        URL8Paste.Size = New Size(66, 53)
        URL8Paste.TabIndex = 19
        URL8Paste.UseVisualStyleBackColor = True
        ' 
        ' URL8
        ' 
        URL8.Location = New Point(368, 647)
        URL8.Name = "URL8"
        URL8.Size = New Size(1087, 35)
        URL8.TabIndex = 18
        ' 
        ' URL7Paste
        ' 
        URL7Paste.ForeColor = Color.Black
        URL7Paste.Image = My.Resources.Resources.icons8_paste_40
        URL7Paste.Location = New Point(273, 558)
        URL7Paste.Name = "URL7Paste"
        URL7Paste.Size = New Size(66, 53)
        URL7Paste.TabIndex = 17
        URL7Paste.UseVisualStyleBackColor = True
        ' 
        ' URL7
        ' 
        URL7.Location = New Point(368, 566)
        URL7.Name = "URL7"
        URL7.Size = New Size(1087, 35)
        URL7.TabIndex = 16
        ' 
        ' URL6Paste
        ' 
        URL6Paste.ForeColor = Color.Black
        URL6Paste.Image = My.Resources.Resources.icons8_paste_40
        URL6Paste.Location = New Point(273, 475)
        URL6Paste.Name = "URL6Paste"
        URL6Paste.Size = New Size(66, 53)
        URL6Paste.TabIndex = 15
        URL6Paste.UseVisualStyleBackColor = True
        ' 
        ' URL6
        ' 
        URL6.Location = New Point(368, 484)
        URL6.Name = "URL6"
        URL6.Size = New Size(1087, 35)
        URL6.TabIndex = 14
        ' 
        ' URL5Paste
        ' 
        URL5Paste.ForeColor = Color.Black
        URL5Paste.Image = My.Resources.Resources.icons8_paste_40
        URL5Paste.Location = New Point(273, 395)
        URL5Paste.Name = "URL5Paste"
        URL5Paste.Size = New Size(66, 53)
        URL5Paste.TabIndex = 13
        URL5Paste.UseVisualStyleBackColor = True
        ' 
        ' URL5
        ' 
        URL5.Location = New Point(368, 403)
        URL5.Name = "URL5"
        URL5.Size = New Size(1087, 35)
        URL5.TabIndex = 12
        ' 
        ' URL10Paste
        ' 
        URL10Paste.ForeColor = Color.Black
        URL10Paste.Image = My.Resources.Resources.icons8_paste_40
        URL10Paste.Location = New Point(273, 797)
        URL10Paste.Name = "URL10Paste"
        URL10Paste.Size = New Size(66, 53)
        URL10Paste.TabIndex = 23
        URL10Paste.UseVisualStyleBackColor = True
        ' 
        ' URL10
        ' 
        URL10.Location = New Point(368, 805)
        URL10.Name = "URL10"
        URL10.Size = New Size(1087, 35)
        URL10.TabIndex = 22
        ' 
        ' URL9Paste
        ' 
        URL9Paste.ForeColor = Color.Black
        URL9Paste.Image = My.Resources.Resources.icons8_paste_40
        URL9Paste.Location = New Point(273, 716)
        URL9Paste.Name = "URL9Paste"
        URL9Paste.Size = New Size(66, 53)
        URL9Paste.TabIndex = 21
        URL9Paste.UseVisualStyleBackColor = True
        ' 
        ' URL9
        ' 
        URL9.Location = New Point(368, 725)
        URL9.Name = "URL9"
        URL9.Size = New Size(1087, 35)
        URL9.TabIndex = 20
        ' 
        ' FolderDefaulter
        ' 
        FolderDefaulter.ForeColor = Color.DimGray
        FolderDefaulter.Image = My.Resources.Resources.checked
        FolderDefaulter.Location = New Point(1319, 883)
        FolderDefaulter.Name = "FolderDefaulter"
        FolderDefaulter.RightToLeft = RightToLeft.No
        FolderDefaulter.Size = New Size(61, 50)
        FolderDefaulter.TabIndex = 24
        FolderDefaulter.UseVisualStyleBackColor = True
        ' 
        ' ResDefaulter
        ' 
        ResDefaulter.ForeColor = Color.DimGray
        ResDefaulter.Image = My.Resources.Resources.checked
        ResDefaulter.Location = New Point(89, 728)
        ResDefaulter.Name = "ResDefaulter"
        ResDefaulter.RightToLeft = RightToLeft.No
        ResDefaulter.Size = New Size(61, 50)
        ResDefaulter.TabIndex = 25
        ResDefaulter.UseVisualStyleBackColor = True
        ' 
        ' TextBoxFolderQ
        ' 
        TextBoxFolderQ.BackColor = Color.Black
        TextBoxFolderQ.BorderStyle = BorderStyle.None
        TextBoxFolderQ.ForeColor = Color.White
        TextBoxFolderQ.Location = New Point(1222, 848)
        TextBoxFolderQ.Name = "TextBoxFolderQ"
        TextBoxFolderQ.Size = New Size(290, 28)
        TextBoxFolderQ.TabIndex = 26
        TextBoxFolderQ.Text = "Current folder is default!"
        ' 
        ' TextBoxResQ
        ' 
        TextBoxResQ.BackColor = Color.Black
        TextBoxResQ.BorderStyle = BorderStyle.None
        TextBoxResQ.ForeColor = Color.White
        TextBoxResQ.Location = New Point(52, 658)
        TextBoxResQ.Multiline = True
        TextBoxResQ.Name = "TextBoxResQ"
        TextBoxResQ.Size = New Size(142, 66)
        TextBoxResQ.TabIndex = 27
        TextBoxResQ.Text = "Current res." & vbCrLf & "is default!"
        ' 
        ' ResetURLs
        ' 
        ResetURLs.Image = My.Resources.Resources.cross
        ResetURLs.Location = New Point(1992, 986)
        ResetURLs.Name = "ResetURLs"
        ResetURLs.Size = New Size(51, 43)
        ResetURLs.TabIndex = 28
        ResetURLs.UseVisualStyleBackColor = True
        ' 
        ' SillyLittleTextBox
        ' 
        SillyLittleTextBox.BackColor = Color.Black
        SillyLittleTextBox.BorderStyle = BorderStyle.None
        SillyLittleTextBox.ForeColor = Color.White
        SillyLittleTextBox.Location = New Point(1715, 993)
        SillyLittleTextBox.Name = "SillyLittleTextBox"
        SillyLittleTextBox.Size = New Size(271, 28)
        SillyLittleTextBox.TabIndex = 29
        SillyLittleTextBox.Text = "Click X to reset URL inputs:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(63, 297)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(123, 65)
        TextBox2.TabIndex = 31
        TextBox2.Text = "Select max" & vbCrLf & "resolution."
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Black
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.ForeColor = Color.Red
        TextBox3.Location = New Point(11, 1016)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(464, 28)
        TextBox3.TabIndex = 32
        TextBox3.Text = "Atlas' YouTube Downloader GUI for YT-DLP (C)"
        ' 
        ' SetAudioOnly
        ' 
        SetAudioOnly.AutoSize = True
        SetAudioOnly.CheckAlign = ContentAlignment.MiddleRight
        SetAudioOnly.Location = New Point(368, 948)
        SetAudioOnly.Name = "SetAudioOnly"
        SetAudioOnly.Size = New Size(152, 34)
        SetAudioOnly.TabIndex = 33
        SetAudioOnly.Text = "Audio Only?"
        SetAudioOnly.UseVisualStyleBackColor = True
        ' 
        ' URL1Name
        ' 
        URL1Name.BackColor = Color.Black
        URL1Name.BorderStyle = BorderStyle.None
        URL1Name.ForeColor = Color.White
        URL1Name.Location = New Point(1460, 82)
        URL1Name.Name = "URL1Name"
        URL1Name.ReadOnly = True
        URL1Name.Size = New Size(582, 28)
        URL1Name.TabIndex = 34
        ' 
        ' InfoPasteURL
        ' 
        InfoPasteURL.BackColor = Color.Black
        InfoPasteURL.BorderStyle = BorderStyle.None
        InfoPasteURL.ForeColor = Color.White
        InfoPasteURL.Location = New Point(252, 29)
        InfoPasteURL.Name = "InfoPasteURL"
        InfoPasteURL.Size = New Size(107, 28)
        InfoPasteURL.TabIndex = 35
        InfoPasteURL.Text = "Paste URL"
        ' 
        ' InfoManualURL
        ' 
        InfoManualURL.BackColor = Color.Black
        InfoManualURL.BorderStyle = BorderStyle.None
        InfoManualURL.ForeColor = Color.White
        InfoManualURL.Location = New Point(562, 29)
        InfoManualURL.Name = "InfoManualURL"
        InfoManualURL.Size = New Size(706, 28)
        InfoManualURL.TabIndex = 36
        InfoManualURL.Text = "Manually writing URL does not check for filename or update filename."
        ' 
        ' InfoFileName
        ' 
        InfoFileName.BackColor = Color.Black
        InfoFileName.BorderStyle = BorderStyle.None
        InfoFileName.ForeColor = Color.White
        InfoFileName.Location = New Point(1715, 29)
        InfoFileName.Name = "InfoFileName"
        InfoFileName.Size = New Size(107, 28)
        InfoFileName.TabIndex = 37
        InfoFileName.Text = "Filename"
        ' 
        ' URL2Name
        ' 
        URL2Name.BackColor = Color.Black
        URL2Name.BorderStyle = BorderStyle.None
        URL2Name.ForeColor = Color.White
        URL2Name.Location = New Point(1460, 163)
        URL2Name.Name = "URL2Name"
        URL2Name.ReadOnly = True
        URL2Name.Size = New Size(582, 28)
        URL2Name.TabIndex = 38
        ' 
        ' URL4Name
        ' 
        URL4Name.BackColor = Color.Black
        URL4Name.BorderStyle = BorderStyle.None
        URL4Name.ForeColor = Color.White
        URL4Name.Location = New Point(1460, 326)
        URL4Name.Name = "URL4Name"
        URL4Name.ReadOnly = True
        URL4Name.Size = New Size(582, 28)
        URL4Name.TabIndex = 40
        ' 
        ' URL3Name
        ' 
        URL3Name.BackColor = Color.Black
        URL3Name.BorderStyle = BorderStyle.None
        URL3Name.ForeColor = Color.White
        URL3Name.Location = New Point(1460, 246)
        URL3Name.Name = "URL3Name"
        URL3Name.ReadOnly = True
        URL3Name.Size = New Size(582, 28)
        URL3Name.TabIndex = 39
        ' 
        ' URL8Name
        ' 
        URL8Name.BackColor = Color.Black
        URL8Name.BorderStyle = BorderStyle.None
        URL8Name.ForeColor = Color.White
        URL8Name.Location = New Point(1460, 650)
        URL8Name.Name = "URL8Name"
        URL8Name.ReadOnly = True
        URL8Name.Size = New Size(582, 28)
        URL8Name.TabIndex = 45
        ' 
        ' URL7Name
        ' 
        URL7Name.BackColor = Color.Black
        URL7Name.BorderStyle = BorderStyle.None
        URL7Name.ForeColor = Color.White
        URL7Name.Location = New Point(1460, 569)
        URL7Name.Name = "URL7Name"
        URL7Name.ReadOnly = True
        URL7Name.Size = New Size(582, 28)
        URL7Name.TabIndex = 44
        ' 
        ' URL6Name
        ' 
        URL6Name.BackColor = Color.Black
        URL6Name.BorderStyle = BorderStyle.None
        URL6Name.ForeColor = Color.White
        URL6Name.Location = New Point(1460, 487)
        URL6Name.Name = "URL6Name"
        URL6Name.ReadOnly = True
        URL6Name.Size = New Size(582, 28)
        URL6Name.TabIndex = 43
        ' 
        ' URL5Name
        ' 
        URL5Name.BackColor = Color.Black
        URL5Name.BorderStyle = BorderStyle.None
        URL5Name.ForeColor = Color.White
        URL5Name.Location = New Point(1460, 406)
        URL5Name.Name = "URL5Name"
        URL5Name.ReadOnly = True
        URL5Name.Size = New Size(582, 28)
        URL5Name.TabIndex = 41
        ' 
        ' URL10Name
        ' 
        URL10Name.BackColor = Color.Black
        URL10Name.BorderStyle = BorderStyle.None
        URL10Name.ForeColor = Color.White
        URL10Name.Location = New Point(1460, 808)
        URL10Name.Name = "URL10Name"
        URL10Name.ReadOnly = True
        URL10Name.Size = New Size(582, 28)
        URL10Name.TabIndex = 47
        ' 
        ' URL9Name
        ' 
        URL9Name.BackColor = Color.Black
        URL9Name.BorderStyle = BorderStyle.None
        URL9Name.ForeColor = Color.White
        URL9Name.Location = New Point(1460, 728)
        URL9Name.Name = "URL9Name"
        URL9Name.ReadOnly = True
        URL9Name.Size = New Size(582, 28)
        URL9Name.TabIndex = 46
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(2062, 1058)
        Controls.Add(URL10Name)
        Controls.Add(URL9Name)
        Controls.Add(URL8Name)
        Controls.Add(URL7Name)
        Controls.Add(URL6Name)
        Controls.Add(URL5Name)
        Controls.Add(URL4Name)
        Controls.Add(URL3Name)
        Controls.Add(URL2Name)
        Controls.Add(InfoFileName)
        Controls.Add(InfoManualURL)
        Controls.Add(InfoPasteURL)
        Controls.Add(URL1Name)
        Controls.Add(SetAudioOnly)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(SillyLittleTextBox)
        Controls.Add(ResetURLs)
        Controls.Add(TextBoxResQ)
        Controls.Add(TextBoxFolderQ)
        Controls.Add(ResDefaulter)
        Controls.Add(FolderDefaulter)
        Controls.Add(URL10Paste)
        Controls.Add(URL10)
        Controls.Add(URL9Paste)
        Controls.Add(URL9)
        Controls.Add(URL8Paste)
        Controls.Add(URL8)
        Controls.Add(URL7Paste)
        Controls.Add(URL7)
        Controls.Add(URL6Paste)
        Controls.Add(URL6)
        Controls.Add(URL5Paste)
        Controls.Add(URL5)
        Controls.Add(URL4Paste)
        Controls.Add(URL4)
        Controls.Add(URL3Paste)
        Controls.Add(URL3)
        Controls.Add(URL2Paste)
        Controls.Add(URL2)
        Controls.Add(URL1Paste)
        Controls.Add(SelectFolderButton)
        Controls.Add(LagringsMappeTB)
        Controls.Add(StartDownload)
        Controls.Add(URL1)
        Controls.Add(Resolution)
        ForeColor = Color.White
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Resolution As ListBox
    Friend WithEvents URL1 As TextBox
    Friend WithEvents StartDownload As Button
    Friend WithEvents LagringsMappeTB As TextBox
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents URL1Paste As Button
    Friend WithEvents URL2Paste As Button
    Friend WithEvents URL2 As TextBox
    Friend WithEvents URL4Paste As Button
    Friend WithEvents URL4 As TextBox
    Friend WithEvents URL3Paste As Button
    Friend WithEvents URL3 As TextBox
    Friend WithEvents URL8Paste As Button
    Friend WithEvents URL8 As TextBox
    Friend WithEvents URL7Paste As Button
    Friend WithEvents URL7 As TextBox
    Friend WithEvents URL6Paste As Button
    Friend WithEvents URL6 As TextBox
    Friend WithEvents URL5Paste As Button
    Friend WithEvents URL5 As TextBox
    Friend WithEvents URL10Paste As Button
    Friend WithEvents URL10 As TextBox
    Friend WithEvents URL9Paste As Button
    Friend WithEvents URL9 As TextBox
    Friend WithEvents FolderDefaulter As Button
    Friend WithEvents ResDefaulter As Button
    Friend WithEvents TextBoxFolderQ As TextBox
    Friend WithEvents TextBoxResQ As TextBox
    Friend WithEvents ResetURLs As Button
    Friend WithEvents SillyLittleTextBox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SetAudioOnly As CheckBox
    Friend WithEvents URL1Name As TextBox
    Friend WithEvents InfoPasteURL As TextBox
    Friend WithEvents InfoManualURL As TextBox
    Friend WithEvents InfoFileName As TextBox
    Friend WithEvents URL2Name As TextBox
    Friend WithEvents URL4Name As TextBox
    Friend WithEvents URL3Name As TextBox
    Friend WithEvents URL8Name As TextBox
    Friend WithEvents URL7Name As TextBox
    Friend WithEvents URL6Name As TextBox
    Friend WithEvents URL5Name As TextBox
    Friend WithEvents URL10Name As TextBox
    Friend WithEvents URL9Name As TextBox
End Class
