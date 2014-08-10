Imports MktvdbQuery
Public Class MKTV_Search
    Dim videolist As ListView
    Dim fcast As Form1

    Private Sub SearchOK_Click(sender As Object, e As EventArgs) Handles SearchOK.Click
        For Each f As Form In My.Application.OpenForms

            If Not f.InvokeRequired Then
                If f.Text = "The Mario Kart 8 App" Then
                    'Dim fcast As New Form1
                    fcast = f
                    videolist = fcast.VideoList
                End If
            End If
        Next
        Dim search As New MktvDatabaseSearch(DateOlder.Value, DateNewer.Value, GameMode.Text, Track.Text, Character.Text, MiiName.Text, NNID.Text, Community.Text)
        fcast.youtube = search.Videos
        videolist.Items.Clear()
        For Each video As VideoObject In search.Videos
            Dim item As ListViewItem = New ListViewItem
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems(0).Text = video.uploadTime.ToString
            item.SubItems(1).Text = video.miiName
            item.SubItems(2).Text = video.nnid
            item.SubItems(3).Text = video.track
            item.SubItems(5).Text = video.gameMode
            item.SubItems(4).Text = video.character
            videolist.Items.Add(item)
        Next
        videolist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        fcast.AreFavShown = False
        fcast.RemoveFav.Enabled = False
        fcast.SaveFav.Enabled = True
        fcast.ShowFav.Enabled = True
        Me.Close()
    End Sub

    Private Sub MKTV_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class