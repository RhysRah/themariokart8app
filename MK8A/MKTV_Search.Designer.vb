<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MKTV_Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MKTV_Search))
        Me.DateNewer = New System.Windows.Forms.DateTimePicker()
        Me.DateOlder = New System.Windows.Forms.DateTimePicker()
        Me.NNID = New System.Windows.Forms.TextBox()
        Me.MiiName = New System.Windows.Forms.TextBox()
        Me.Community = New System.Windows.Forms.TextBox()
        Me.Track = New System.Windows.Forms.ComboBox()
        Me.Character = New System.Windows.Forms.ComboBox()
        Me.GameMode = New System.Windows.Forms.ComboBox()
        Me.SearchOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateNewer
        '
        Me.DateNewer.CustomFormat = "dd/mm/yyyy hh:mm"
        Me.DateNewer.Location = New System.Drawing.Point(12, 42)
        Me.DateNewer.Name = "DateNewer"
        Me.DateNewer.Size = New System.Drawing.Size(213, 22)
        Me.DateNewer.TabIndex = 0
        Me.DateNewer.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'DateOlder
        '
        Me.DateOlder.CustomFormat = "dd/mm/yyyy hh:mm"
        Me.DateOlder.Location = New System.Drawing.Point(321, 42)
        Me.DateOlder.Name = "DateOlder"
        Me.DateOlder.Size = New System.Drawing.Size(213, 22)
        Me.DateOlder.TabIndex = 1
        '
        'NNID
        '
        Me.NNID.Location = New System.Drawing.Point(125, 91)
        Me.NNID.Name = "NNID"
        Me.NNID.Size = New System.Drawing.Size(100, 22)
        Me.NNID.TabIndex = 2
        '
        'MiiName
        '
        Me.MiiName.Location = New System.Drawing.Point(125, 128)
        Me.MiiName.Name = "MiiName"
        Me.MiiName.Size = New System.Drawing.Size(100, 22)
        Me.MiiName.TabIndex = 3
        '
        'Community
        '
        Me.Community.Location = New System.Drawing.Point(125, 165)
        Me.Community.Name = "Community"
        Me.Community.Size = New System.Drawing.Size(100, 22)
        Me.Community.TabIndex = 4
        '
        'Track
        '
        Me.Track.FormattingEnabled = True
        Me.Track.Items.AddRange(New Object() {"", "Mario Kart Stadium", "Water Park", "Sweet Sweet Canyon", "Thwomp Ruins", "Mario Circuit", "Toad Harbor", "Twisted Mansion", "Shy Guy Falls", "Sunshine Airport", "Dolphin Shoals", "Electrodrome", "Mount Wario", "Cloudtop Cruise", "Bone-Dry Dunes", "Bowser's Castle", "Rainbow Road", "Wii Moo Moo Meadows", "GBA Mario Circuit", "DS Cheep Cheep Beach", "N64 Toad's Turnpike", "GCN Dry Dry Desert", "SNES Donut Plains 3", "N64 Royal Raceway", "3DS DK Jungle", "DS Wario Stadium", "GCN Sherbet Land", "3DS Music Park", "N64 Yoshi Valley", "DS Tick-Tock Clock", "3DS Piranha Plant Slide", "Wii Grumble Volcano", "N64 Rainbow Road"})
        Me.Track.Location = New System.Drawing.Point(413, 88)
        Me.Track.Name = "Track"
        Me.Track.Size = New System.Drawing.Size(121, 24)
        Me.Track.TabIndex = 5
        '
        'Character
        '
        Me.Character.FormattingEnabled = True
        Me.Character.Items.AddRange(New Object() {"", "Baby Rosalina", "Iggy ", "Larry ", "Lemmy", "Ludwig", "Morton", "Pink Gold Peach", "Roy", "Wendy", "Baby Daisy", "Baby Luigi", "Baby Mario", "Baby Peach", "Bowser", "Donkey Kong", "Koopa Troopa", "Lakitu", "Luigi", "Mario", "Metal Mario", "Mii", "Princess Daisy", "Princess Peach", "Rosalina", "Shy Guy", "Toad", "Toadette", "Waluigi", "Wario", "Yoshi"})
        Me.Character.Location = New System.Drawing.Point(413, 128)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(121, 24)
        Me.Character.TabIndex = 6
        '
        'GameMode
        '
        Me.GameMode.FormattingEnabled = True
        Me.GameMode.Items.AddRange(New Object() {"", "Grand Prix", "Time Trials", "VS Race", "Battle", "Tournament"})
        Me.GameMode.Location = New System.Drawing.Point(413, 167)
        Me.GameMode.Name = "GameMode"
        Me.GameMode.Size = New System.Drawing.Size(121, 24)
        Me.GameMode.TabIndex = 7
        '
        'SearchOK
        '
        Me.SearchOK.Location = New System.Drawing.Point(3, 234)
        Me.SearchOK.Name = "SearchOK"
        Me.SearchOK.Size = New System.Drawing.Size(538, 33)
        Me.SearchOK.TabIndex = 8
        Me.SearchOK.Text = "OK"
        Me.SearchOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NNID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mii Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tournament"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 28)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Track"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(316, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Character"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(348, 28)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Having a field blank doesn't search for it."
        '
        'MKTV_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 272)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchOK)
        Me.Controls.Add(Me.GameMode)
        Me.Controls.Add(Me.Character)
        Me.Controls.Add(Me.Track)
        Me.Controls.Add(Me.Community)
        Me.Controls.Add(Me.MiiName)
        Me.Controls.Add(Me.NNID)
        Me.Controls.Add(Me.DateOlder)
        Me.Controls.Add(Me.DateNewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MKTV_Search"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateNewer As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateOlder As System.Windows.Forms.DateTimePicker
    Friend WithEvents NNID As System.Windows.Forms.TextBox
    Friend WithEvents MiiName As System.Windows.Forms.TextBox
    Friend WithEvents Community As System.Windows.Forms.TextBox
    Friend WithEvents Track As System.Windows.Forms.ComboBox
    Friend WithEvents Character As System.Windows.Forms.ComboBox
    Friend WithEvents GameMode As System.Windows.Forms.ComboBox
    Friend WithEvents SearchOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
