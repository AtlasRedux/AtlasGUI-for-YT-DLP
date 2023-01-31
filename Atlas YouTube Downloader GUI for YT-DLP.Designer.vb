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
        Me.Resolution = New System.Windows.Forms.ListBox()
        Me.URL1 = New System.Windows.Forms.TextBox()
        Me.StartDownload = New System.Windows.Forms.Button()
        Me.LagringsMappeTB = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.URL1Paste = New System.Windows.Forms.Button()
        Me.URL2Paste = New System.Windows.Forms.Button()
        Me.URL2 = New System.Windows.Forms.TextBox()
        Me.URL4Paste = New System.Windows.Forms.Button()
        Me.URL4 = New System.Windows.Forms.TextBox()
        Me.URL3Paste = New System.Windows.Forms.Button()
        Me.URL3 = New System.Windows.Forms.TextBox()
        Me.URL8Paste = New System.Windows.Forms.Button()
        Me.URL8 = New System.Windows.Forms.TextBox()
        Me.URL7Paste = New System.Windows.Forms.Button()
        Me.URL7 = New System.Windows.Forms.TextBox()
        Me.URL6Paste = New System.Windows.Forms.Button()
        Me.URL6 = New System.Windows.Forms.TextBox()
        Me.URL5Paste = New System.Windows.Forms.Button()
        Me.URL5 = New System.Windows.Forms.TextBox()
        Me.URL10Paste = New System.Windows.Forms.Button()
        Me.URL10 = New System.Windows.Forms.TextBox()
        Me.URL9Paste = New System.Windows.Forms.Button()
        Me.URL9 = New System.Windows.Forms.TextBox()
        Me.FolderDefaulter = New System.Windows.Forms.Button()
        Me.ResDefaulter = New System.Windows.Forms.Button()
        Me.TextBoxFolderQ = New System.Windows.Forms.TextBox()
        Me.TextBoxResQ = New System.Windows.Forms.TextBox()
        Me.ResetURLs = New System.Windows.Forms.Button()
        Me.SillyLittleTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SetAudioOnly = New System.Windows.Forms.CheckBox()
        Me.URL1Name = New System.Windows.Forms.TextBox()
        Me.InfoPasteURL = New System.Windows.Forms.TextBox()
        Me.InfoManualURL = New System.Windows.Forms.TextBox()
        Me.InfoFileName = New System.Windows.Forms.TextBox()
        Me.URL2Name = New System.Windows.Forms.TextBox()
        Me.URL4Name = New System.Windows.Forms.TextBox()
        Me.URL3Name = New System.Windows.Forms.TextBox()
        Me.URL8Name = New System.Windows.Forms.TextBox()
        Me.URL7Name = New System.Windows.Forms.TextBox()
        Me.URL6Name = New System.Windows.Forms.TextBox()
        Me.URL5Name = New System.Windows.Forms.TextBox()
        Me.URL10Name = New System.Windows.Forms.TextBox()
        Me.URL9Name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Resolution
        '
        Me.Resolution.FormattingEnabled = True
        Me.Resolution.ItemHeight = 32
        Me.Resolution.Items.AddRange(New Object() {"144", "240", "360", "480", "720", "1080", "1440", "2160"})
        Me.Resolution.Location = New System.Drawing.Point(96, 392)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Size = New System.Drawing.Size(65, 260)
        Me.Resolution.TabIndex = 0
        '
        'URL1
        '
        Me.URL1.Location = New System.Drawing.Point(399, 85)
        Me.URL1.Name = "URL1"
        Me.URL1.Size = New System.Drawing.Size(1177, 39)
        Me.URL1.TabIndex = 1
        '
        'StartDownload
        '
        Me.StartDownload.BackColor = System.Drawing.Color.Green
        Me.StartDownload.ForeColor = System.Drawing.Color.Black
        Me.StartDownload.Location = New System.Drawing.Point(868, 1020)
        Me.StartDownload.Name = "StartDownload"
        Me.StartDownload.Size = New System.Drawing.Size(150, 46)
        Me.StartDownload.TabIndex = 2
        Me.StartDownload.Text = "Start download"
        Me.StartDownload.UseVisualStyleBackColor = False
        '
        'LagringsMappeTB
        '
        Me.LagringsMappeTB.Location = New System.Drawing.Point(399, 945)
        Me.LagringsMappeTB.Name = "LagringsMappeTB"
        Me.LagringsMappeTB.Size = New System.Drawing.Size(949, 39)
        Me.LagringsMappeTB.TabIndex = 3
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.BackColor = System.Drawing.Color.Black
        Me.SelectFolderButton.ForeColor = System.Drawing.Color.Black
        Me.SelectFolderButton.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_open_file_folder_48
        Me.SelectFolderButton.Location = New System.Drawing.Point(310, 935)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(57, 60)
        Me.SelectFolderButton.TabIndex = 4
        Me.SelectFolderButton.UseVisualStyleBackColor = False
        '
        'URL1Paste
        '
        Me.URL1Paste.ForeColor = System.Drawing.Color.Black
        Me.URL1Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL1Paste.Location = New System.Drawing.Point(296, 76)
        Me.URL1Paste.Name = "URL1Paste"
        Me.URL1Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL1Paste.TabIndex = 5
        Me.URL1Paste.UseVisualStyleBackColor = True
        '
        'URL2Paste
        '
        Me.URL2Paste.ForeColor = System.Drawing.Color.Black
        Me.URL2Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL2Paste.Location = New System.Drawing.Point(296, 162)
        Me.URL2Paste.Name = "URL2Paste"
        Me.URL2Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL2Paste.TabIndex = 7
        Me.URL2Paste.UseVisualStyleBackColor = True
        '
        'URL2
        '
        Me.URL2.Location = New System.Drawing.Point(399, 171)
        Me.URL2.Name = "URL2"
        Me.URL2.Size = New System.Drawing.Size(1177, 39)
        Me.URL2.TabIndex = 6
        '
        'URL4Paste
        '
        Me.URL4Paste.ForeColor = System.Drawing.Color.Black
        Me.URL4Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL4Paste.Location = New System.Drawing.Point(296, 336)
        Me.URL4Paste.Name = "URL4Paste"
        Me.URL4Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL4Paste.TabIndex = 11
        Me.URL4Paste.UseVisualStyleBackColor = True
        '
        'URL4
        '
        Me.URL4.Location = New System.Drawing.Point(399, 345)
        Me.URL4.Name = "URL4"
        Me.URL4.Size = New System.Drawing.Size(1177, 39)
        Me.URL4.TabIndex = 10
        '
        'URL3Paste
        '
        Me.URL3Paste.ForeColor = System.Drawing.Color.Black
        Me.URL3Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL3Paste.Location = New System.Drawing.Point(296, 250)
        Me.URL3Paste.Name = "URL3Paste"
        Me.URL3Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL3Paste.TabIndex = 9
        Me.URL3Paste.UseVisualStyleBackColor = True
        '
        'URL3
        '
        Me.URL3.Location = New System.Drawing.Point(399, 259)
        Me.URL3.Name = "URL3"
        Me.URL3.Size = New System.Drawing.Size(1177, 39)
        Me.URL3.TabIndex = 8
        '
        'URL8Paste
        '
        Me.URL8Paste.ForeColor = System.Drawing.Color.Black
        Me.URL8Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL8Paste.Location = New System.Drawing.Point(296, 681)
        Me.URL8Paste.Name = "URL8Paste"
        Me.URL8Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL8Paste.TabIndex = 19
        Me.URL8Paste.UseVisualStyleBackColor = True
        '
        'URL8
        '
        Me.URL8.Location = New System.Drawing.Point(399, 690)
        Me.URL8.Name = "URL8"
        Me.URL8.Size = New System.Drawing.Size(1177, 39)
        Me.URL8.TabIndex = 18
        '
        'URL7Paste
        '
        Me.URL7Paste.ForeColor = System.Drawing.Color.Black
        Me.URL7Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL7Paste.Location = New System.Drawing.Point(296, 595)
        Me.URL7Paste.Name = "URL7Paste"
        Me.URL7Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL7Paste.TabIndex = 17
        Me.URL7Paste.UseVisualStyleBackColor = True
        '
        'URL7
        '
        Me.URL7.Location = New System.Drawing.Point(399, 604)
        Me.URL7.Name = "URL7"
        Me.URL7.Size = New System.Drawing.Size(1177, 39)
        Me.URL7.TabIndex = 16
        '
        'URL6Paste
        '
        Me.URL6Paste.ForeColor = System.Drawing.Color.Black
        Me.URL6Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL6Paste.Location = New System.Drawing.Point(296, 507)
        Me.URL6Paste.Name = "URL6Paste"
        Me.URL6Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL6Paste.TabIndex = 15
        Me.URL6Paste.UseVisualStyleBackColor = True
        '
        'URL6
        '
        Me.URL6.Location = New System.Drawing.Point(399, 516)
        Me.URL6.Name = "URL6"
        Me.URL6.Size = New System.Drawing.Size(1177, 39)
        Me.URL6.TabIndex = 14
        '
        'URL5Paste
        '
        Me.URL5Paste.ForeColor = System.Drawing.Color.Black
        Me.URL5Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL5Paste.Location = New System.Drawing.Point(296, 421)
        Me.URL5Paste.Name = "URL5Paste"
        Me.URL5Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL5Paste.TabIndex = 13
        Me.URL5Paste.UseVisualStyleBackColor = True
        '
        'URL5
        '
        Me.URL5.Location = New System.Drawing.Point(399, 430)
        Me.URL5.Name = "URL5"
        Me.URL5.Size = New System.Drawing.Size(1177, 39)
        Me.URL5.TabIndex = 12
        '
        'URL10Paste
        '
        Me.URL10Paste.ForeColor = System.Drawing.Color.Black
        Me.URL10Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL10Paste.Location = New System.Drawing.Point(296, 850)
        Me.URL10Paste.Name = "URL10Paste"
        Me.URL10Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL10Paste.TabIndex = 23
        Me.URL10Paste.UseVisualStyleBackColor = True
        '
        'URL10
        '
        Me.URL10.Location = New System.Drawing.Point(399, 859)
        Me.URL10.Name = "URL10"
        Me.URL10.Size = New System.Drawing.Size(1177, 39)
        Me.URL10.TabIndex = 22
        '
        'URL9Paste
        '
        Me.URL9Paste.ForeColor = System.Drawing.Color.Black
        Me.URL9Paste.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.icons8_paste_40
        Me.URL9Paste.Location = New System.Drawing.Point(296, 764)
        Me.URL9Paste.Name = "URL9Paste"
        Me.URL9Paste.Size = New System.Drawing.Size(71, 57)
        Me.URL9Paste.TabIndex = 21
        Me.URL9Paste.UseVisualStyleBackColor = True
        '
        'URL9
        '
        Me.URL9.Location = New System.Drawing.Point(399, 773)
        Me.URL9.Name = "URL9"
        Me.URL9.Size = New System.Drawing.Size(1177, 39)
        Me.URL9.TabIndex = 20
        '
        'FolderDefaulter
        '
        Me.FolderDefaulter.ForeColor = System.Drawing.Color.DimGray
        Me.FolderDefaulter.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.checked
        Me.FolderDefaulter.Location = New System.Drawing.Point(1429, 942)
        Me.FolderDefaulter.Name = "FolderDefaulter"
        Me.FolderDefaulter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FolderDefaulter.Size = New System.Drawing.Size(66, 53)
        Me.FolderDefaulter.TabIndex = 24
        Me.FolderDefaulter.UseVisualStyleBackColor = True
        '
        'ResDefaulter
        '
        Me.ResDefaulter.ForeColor = System.Drawing.Color.DimGray
        Me.ResDefaulter.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.checked
        Me.ResDefaulter.Location = New System.Drawing.Point(96, 777)
        Me.ResDefaulter.Name = "ResDefaulter"
        Me.ResDefaulter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResDefaulter.Size = New System.Drawing.Size(66, 53)
        Me.ResDefaulter.TabIndex = 25
        Me.ResDefaulter.UseVisualStyleBackColor = True
        '
        'TextBoxFolderQ
        '
        Me.TextBoxFolderQ.BackColor = System.Drawing.Color.Black
        Me.TextBoxFolderQ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFolderQ.ForeColor = System.Drawing.Color.White
        Me.TextBoxFolderQ.Location = New System.Drawing.Point(1324, 904)
        Me.TextBoxFolderQ.Name = "TextBoxFolderQ"
        Me.TextBoxFolderQ.Size = New System.Drawing.Size(314, 32)
        Me.TextBoxFolderQ.TabIndex = 26
        Me.TextBoxFolderQ.Text = "Current folder is default!"
        '
        'TextBoxResQ
        '
        Me.TextBoxResQ.BackColor = System.Drawing.Color.Black
        Me.TextBoxResQ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResQ.ForeColor = System.Drawing.Color.White
        Me.TextBoxResQ.Location = New System.Drawing.Point(56, 702)
        Me.TextBoxResQ.Multiline = True
        Me.TextBoxResQ.Name = "TextBoxResQ"
        Me.TextBoxResQ.Size = New System.Drawing.Size(154, 70)
        Me.TextBoxResQ.TabIndex = 27
        Me.TextBoxResQ.Text = "Current res." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is default!"
        '
        'ResetURLs
        '
        Me.ResetURLs.Image = Global.AtlasRedux_YT_DLP_GUI.My.Resources.Resources.cross
        Me.ResetURLs.Location = New System.Drawing.Point(2158, 1052)
        Me.ResetURLs.Name = "ResetURLs"
        Me.ResetURLs.Size = New System.Drawing.Size(55, 46)
        Me.ResetURLs.TabIndex = 28
        Me.ResetURLs.UseVisualStyleBackColor = True
        '
        'SillyLittleTextBox
        '
        Me.SillyLittleTextBox.BackColor = System.Drawing.Color.Black
        Me.SillyLittleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SillyLittleTextBox.ForeColor = System.Drawing.Color.White
        Me.SillyLittleTextBox.Location = New System.Drawing.Point(1858, 1059)
        Me.SillyLittleTextBox.Name = "SillyLittleTextBox"
        Me.SillyLittleTextBox.Size = New System.Drawing.Size(294, 32)
        Me.SillyLittleTextBox.TabIndex = 29
        Me.SillyLittleTextBox.Text = "Click X to reset URL inputs:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(68, 317)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 69)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.Text = "Select max" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "resolution."
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.ForeColor = System.Drawing.Color.Red
        Me.TextBox3.Location = New System.Drawing.Point(12, 1084)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(503, 32)
        Me.TextBox3.TabIndex = 32
        Me.TextBox3.Text = "Atlas' YouTube Downloader GUI for YT-DLP (C)"
        '
        'SetAudioOnly
        '
        Me.SetAudioOnly.AutoSize = True
        Me.SetAudioOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SetAudioOnly.Location = New System.Drawing.Point(399, 1011)
        Me.SetAudioOnly.Name = "SetAudioOnly"
        Me.SetAudioOnly.Size = New System.Drawing.Size(177, 36)
        Me.SetAudioOnly.TabIndex = 33
        Me.SetAudioOnly.Text = "Audio Only?"
        Me.SetAudioOnly.UseVisualStyleBackColor = True
        '
        'URL1Name
        '
        Me.URL1Name.BackColor = System.Drawing.Color.Black
        Me.URL1Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL1Name.ForeColor = System.Drawing.Color.White
        Me.URL1Name.Location = New System.Drawing.Point(1582, 88)
        Me.URL1Name.Name = "URL1Name"
        Me.URL1Name.ReadOnly = True
        Me.URL1Name.Size = New System.Drawing.Size(631, 32)
        Me.URL1Name.TabIndex = 34
        '
        'InfoPasteURL
        '
        Me.InfoPasteURL.BackColor = System.Drawing.Color.Black
        Me.InfoPasteURL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoPasteURL.ForeColor = System.Drawing.Color.White
        Me.InfoPasteURL.Location = New System.Drawing.Point(273, 31)
        Me.InfoPasteURL.Name = "InfoPasteURL"
        Me.InfoPasteURL.Size = New System.Drawing.Size(116, 32)
        Me.InfoPasteURL.TabIndex = 35
        Me.InfoPasteURL.Text = "Paste URL"
        '
        'InfoManualURL
        '
        Me.InfoManualURL.BackColor = System.Drawing.Color.Black
        Me.InfoManualURL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoManualURL.ForeColor = System.Drawing.Color.White
        Me.InfoManualURL.Location = New System.Drawing.Point(609, 31)
        Me.InfoManualURL.Name = "InfoManualURL"
        Me.InfoManualURL.Size = New System.Drawing.Size(765, 32)
        Me.InfoManualURL.TabIndex = 36
        Me.InfoManualURL.Text = "Manually writing URL does not check for filename or update filename."
        '
        'InfoFileName
        '
        Me.InfoFileName.BackColor = System.Drawing.Color.Black
        Me.InfoFileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoFileName.ForeColor = System.Drawing.Color.White
        Me.InfoFileName.Location = New System.Drawing.Point(1858, 31)
        Me.InfoFileName.Name = "InfoFileName"
        Me.InfoFileName.Size = New System.Drawing.Size(116, 32)
        Me.InfoFileName.TabIndex = 37
        Me.InfoFileName.Text = "Filename"
        '
        'URL2Name
        '
        Me.URL2Name.BackColor = System.Drawing.Color.Black
        Me.URL2Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL2Name.ForeColor = System.Drawing.Color.White
        Me.URL2Name.Location = New System.Drawing.Point(1582, 174)
        Me.URL2Name.Name = "URL2Name"
        Me.URL2Name.ReadOnly = True
        Me.URL2Name.Size = New System.Drawing.Size(631, 32)
        Me.URL2Name.TabIndex = 38
        '
        'URL4Name
        '
        Me.URL4Name.BackColor = System.Drawing.Color.Black
        Me.URL4Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL4Name.ForeColor = System.Drawing.Color.White
        Me.URL4Name.Location = New System.Drawing.Point(1582, 348)
        Me.URL4Name.Name = "URL4Name"
        Me.URL4Name.ReadOnly = True
        Me.URL4Name.Size = New System.Drawing.Size(631, 32)
        Me.URL4Name.TabIndex = 40
        '
        'URL3Name
        '
        Me.URL3Name.BackColor = System.Drawing.Color.Black
        Me.URL3Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL3Name.ForeColor = System.Drawing.Color.White
        Me.URL3Name.Location = New System.Drawing.Point(1582, 262)
        Me.URL3Name.Name = "URL3Name"
        Me.URL3Name.ReadOnly = True
        Me.URL3Name.Size = New System.Drawing.Size(631, 32)
        Me.URL3Name.TabIndex = 39
        '
        'URL8Name
        '
        Me.URL8Name.BackColor = System.Drawing.Color.Black
        Me.URL8Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL8Name.ForeColor = System.Drawing.Color.White
        Me.URL8Name.Location = New System.Drawing.Point(1582, 693)
        Me.URL8Name.Name = "URL8Name"
        Me.URL8Name.ReadOnly = True
        Me.URL8Name.Size = New System.Drawing.Size(631, 32)
        Me.URL8Name.TabIndex = 45
        '
        'URL7Name
        '
        Me.URL7Name.BackColor = System.Drawing.Color.Black
        Me.URL7Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL7Name.ForeColor = System.Drawing.Color.White
        Me.URL7Name.Location = New System.Drawing.Point(1582, 607)
        Me.URL7Name.Name = "URL7Name"
        Me.URL7Name.ReadOnly = True
        Me.URL7Name.Size = New System.Drawing.Size(631, 32)
        Me.URL7Name.TabIndex = 44
        '
        'URL6Name
        '
        Me.URL6Name.BackColor = System.Drawing.Color.Black
        Me.URL6Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL6Name.ForeColor = System.Drawing.Color.White
        Me.URL6Name.Location = New System.Drawing.Point(1582, 519)
        Me.URL6Name.Name = "URL6Name"
        Me.URL6Name.ReadOnly = True
        Me.URL6Name.Size = New System.Drawing.Size(631, 32)
        Me.URL6Name.TabIndex = 43
        '
        'URL5Name
        '
        Me.URL5Name.BackColor = System.Drawing.Color.Black
        Me.URL5Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL5Name.ForeColor = System.Drawing.Color.White
        Me.URL5Name.Location = New System.Drawing.Point(1582, 433)
        Me.URL5Name.Name = "URL5Name"
        Me.URL5Name.ReadOnly = True
        Me.URL5Name.Size = New System.Drawing.Size(631, 32)
        Me.URL5Name.TabIndex = 41
        '
        'URL10Name
        '
        Me.URL10Name.BackColor = System.Drawing.Color.Black
        Me.URL10Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL10Name.ForeColor = System.Drawing.Color.White
        Me.URL10Name.Location = New System.Drawing.Point(1582, 862)
        Me.URL10Name.Name = "URL10Name"
        Me.URL10Name.ReadOnly = True
        Me.URL10Name.Size = New System.Drawing.Size(631, 32)
        Me.URL10Name.TabIndex = 47
        '
        'URL9Name
        '
        Me.URL9Name.BackColor = System.Drawing.Color.Black
        Me.URL9Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URL9Name.ForeColor = System.Drawing.Color.White
        Me.URL9Name.Location = New System.Drawing.Point(1582, 776)
        Me.URL9Name.Name = "URL9Name"
        Me.URL9Name.ReadOnly = True
        Me.URL9Name.Size = New System.Drawing.Size(631, 32)
        Me.URL9Name.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(2234, 1128)
        Me.Controls.Add(Me.URL10Name)
        Me.Controls.Add(Me.URL9Name)
        Me.Controls.Add(Me.URL8Name)
        Me.Controls.Add(Me.URL7Name)
        Me.Controls.Add(Me.URL6Name)
        Me.Controls.Add(Me.URL5Name)
        Me.Controls.Add(Me.URL4Name)
        Me.Controls.Add(Me.URL3Name)
        Me.Controls.Add(Me.URL2Name)
        Me.Controls.Add(Me.InfoFileName)
        Me.Controls.Add(Me.InfoManualURL)
        Me.Controls.Add(Me.InfoPasteURL)
        Me.Controls.Add(Me.URL1Name)
        Me.Controls.Add(Me.SetAudioOnly)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.SillyLittleTextBox)
        Me.Controls.Add(Me.ResetURLs)
        Me.Controls.Add(Me.TextBoxResQ)
        Me.Controls.Add(Me.TextBoxFolderQ)
        Me.Controls.Add(Me.ResDefaulter)
        Me.Controls.Add(Me.FolderDefaulter)
        Me.Controls.Add(Me.URL10Paste)
        Me.Controls.Add(Me.URL10)
        Me.Controls.Add(Me.URL9Paste)
        Me.Controls.Add(Me.URL9)
        Me.Controls.Add(Me.URL8Paste)
        Me.Controls.Add(Me.URL8)
        Me.Controls.Add(Me.URL7Paste)
        Me.Controls.Add(Me.URL7)
        Me.Controls.Add(Me.URL6Paste)
        Me.Controls.Add(Me.URL6)
        Me.Controls.Add(Me.URL5Paste)
        Me.Controls.Add(Me.URL5)
        Me.Controls.Add(Me.URL4Paste)
        Me.Controls.Add(Me.URL4)
        Me.Controls.Add(Me.URL3Paste)
        Me.Controls.Add(Me.URL3)
        Me.Controls.Add(Me.URL2Paste)
        Me.Controls.Add(Me.URL2)
        Me.Controls.Add(Me.URL1Paste)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.LagringsMappeTB)
        Me.Controls.Add(Me.StartDownload)
        Me.Controls.Add(Me.URL1)
        Me.Controls.Add(Me.Resolution)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
