﻿Imports MktvdbQuery
Imports Newtonsoft.Json
Imports Microsoft.Win32

Public Class Form1
    Dim track1 As Integer
    Dim track2 As Integer
    Dim track3 As Integer
    Dim track4 As Integer
    Dim miiverseurl As String

    Public youtube As List(Of VideoObject)
    Public favourites As List(Of VideoObject)
    Public AreFavShown As Boolean


#Region "Main Menu"
    Private Sub WindowLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args As String() = Environment.GetCommandLineArgs

        Me.Show()
        Try
            If args.Length > 1 Then
                Dim data As String() = args(1).Split(":")
                MKTVDBExternalCall(data(1), data(2))
            End If
        Catch ex As Exception
        End Try

        Dim CurrentVersion As String = "1.2.0.0"

        LatestVersion.Text = CurrentVersion

        Dim request As New System.Net.WebClient

        Try
            Dim reply As String = request.DownloadString("http://winepicgaming.de/mkapp/version.txt")

            If Not reply = CurrentVersion Then
                CheckUpdates.Text = "Update Available"
            Else
                CheckUpdates.Visible = False
            End If

        Catch ex As Exception
            CheckUpdates.Text = "Check for Updates"
        End Try

        favourites = New List(Of VideoObject)

        If IsRegistryKeySet() Then
            MKTVDB.Text = "Uninstall MKTVDB Handler"
        End If
    End Sub

    Private Sub CheckUpdates_Click(sender As Object, e As EventArgs) Handles CheckUpdates.Click
        If CheckUpdates.Text = "Update Available" Then
            System.Diagnostics.Process.Start("GUI_Updater.exe")
            End
        End If
    End Sub

    Private Sub ViewThread(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://www.mariokartwii.com/threads/139519-The-Mario-Kart-8-App")
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles Button6.Click
        AboutBox1.Show()
    End Sub

    Private Sub Quit(sender As Object, e As EventArgs) Handles Button7.Click
        Dialog1.Show()
    End Sub
#End Region

#Region "Stat Calculator"

    Private Sub CalculateStats(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Baby Mario" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Baby Luigi" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Baby Peach" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Baby Daisy" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Baby Rosalina" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Lemmy" Then
            Label19.Text = "2.25"
            Label26.Text = "2.75"
            Label42.Text = "2.25"
            Label38.Text = "2.5"
            Label34.Text = "3.25"
            Label30.Text = "2.25"
            Label46.Text = "4.75"
            Label50.Text = "4.75"
            Label54.Text = "4.5"
            Label58.Text = "5"
            Label62.Text = "4.5"
            Label66.Text = "3"
        End If

        If ComboBox1.Text = "Toad" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Koopa Troopa" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.25"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Shy Guy" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Lakitu" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Toadette" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Wendy" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Larry" Then
            Label19.Text = "2.75"
            Label26.Text = "3.25"
            Label42.Text = "2.75"
            Label38.Text = "3"
            Label34.Text = "3"
            Label30.Text = "2.75"
            Label46.Text = "4.25"
            Label50.Text = "4.24"
            Label54.Text = "4"
            Label58.Text = "4.5"
            Label62.Text = "4.25"
            Label66.Text = "2.75"
        End If

        If ComboBox1.Text = "Yoshi" Then
            Label19.Text = "3.25"
            Label26.Text = "3.75"
            Label42.Text = "3.25"
            Label38.Text = "3.5"
            Label34.Text = "2.75"
            Label30.Text = "3.25"
            Label46.Text = "3.75"
            Label50.Text = "3.75"
            Label54.Text = "3.5"
            Label58.Text = "4"
            Label62.Text = "4"
            Label66.Text = "2.5"
        End If

        If ComboBox1.Text = "Daisy" Then
            Label19.Text = "3.25"
            Label26.Text = "3.75"
            Label42.Text = "3.25"
            Label38.Text = "3.5"
            Label34.Text = "2.75"
            Label30.Text = "3.25"
            Label46.Text = "3.75"
            Label50.Text = "3.75"
            Label54.Text = "3.5"
            Label58.Text = "4"
            Label62.Text = "4"
            Label66.Text = "2.5"
        End If

        If ComboBox1.Text = "Peach" Then
            Label19.Text = "3.25"
            Label26.Text = "3.75"
            Label42.Text = "3.25"
            Label38.Text = "3.5"
            Label34.Text = "2.75"
            Label30.Text = "3.25"
            Label46.Text = "3.75"
            Label50.Text = "3.75"
            Label54.Text = "3.5"
            Label58.Text = "4"
            Label62.Text = "4"
            Label66.Text = "2.5"
        End If

        If ComboBox1.Text = "Mario" Then
            Label19.Text = "3.75"
            Label26.Text = "4.25"
            Label42.Text = "3.75"
            Label38.Text = "4"
            Label34.Text = "2.5"
            Label30.Text = "3.75"
            Label46.Text = "3.25"
            Label50.Text = "3.25"
            Label54.Text = "3"
            Label58.Text = "3.5"
            Label62.Text = "3.75"
            Label66.Text = "2.25"
        End If

        If ComboBox1.Text = "Luigi" Then
            Label19.Text = "3.75"
            Label26.Text = "4.25"
            Label42.Text = "3.75"
            Label38.Text = "4"
            Label34.Text = "2.5"
            Label30.Text = "3.75"
            Label46.Text = "3.25"
            Label50.Text = "3.25"
            Label54.Text = "3"
            Label58.Text = "3.5"
            Label62.Text = "3.75"
            Label66.Text = "2.25"
        End If

        If ComboBox1.Text = "Ludwig" Then
            Label19.Text = "3.75"
            Label26.Text = "4.25"
            Label42.Text = "3.75"
            Label38.Text = "4"
            Label34.Text = "2.5"
            Label30.Text = "3.75"
            Label46.Text = "3.25"
            Label50.Text = "3.25"
            Label54.Text = "3"
            Label58.Text = "3.5"
            Label62.Text = "3.75"
            Label66.Text = "2.25"
        End If

        If ComboBox1.Text = "Iggy" Then
            Label19.Text = "3.75"
            Label26.Text = "4.25"
            Label42.Text = "3.75"
            Label38.Text = "4"
            Label34.Text = "2.5"
            Label30.Text = "3.75"
            Label46.Text = "3.25"
            Label50.Text = "3.25"
            Label54.Text = "3"
            Label58.Text = "3.5"
            Label62.Text = "3.75"
            Label66.Text = "2.25"
        End If

        If ComboBox1.Text = "Donkey Kong" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2.25"
            Label30.Text = "4.25"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "2"
        End If

        If ComboBox1.Text = "Waluigi" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2.25"
            Label30.Text = "4.25"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "2"
        End If

        If ComboBox1.Text = "Rosalina" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2.25"
            Label30.Text = "4.25"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "2"
        End If

        If ComboBox1.Text = "Roy" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2.25"
            Label30.Text = "4.25"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "2"
        End If

        If ComboBox1.Text = "Metal Mario" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2"
            Label30.Text = "4.75"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "1.75"
        End If

        If ComboBox1.Text = "Pink Gold Peach" Then
            Label19.Text = "4.25"
            Label26.Text = "4.75"
            Label42.Text = "4.25"
            Label38.Text = "4.5"
            Label34.Text = "2"
            Label30.Text = "4.75"
            Label46.Text = "2.75"
            Label50.Text = "2.75"
            Label54.Text = "2.5"
            Label58.Text = "3"
            Label62.Text = "3.5"
            Label66.Text = "1.75"
        End If

        If ComboBox1.Text = "Bowser" Then
            Label19.Text = "4.75"
            Label26.Text = "5.25"
            Label42.Text = "4.75"
            Label38.Text = "5"
            Label34.Text = "2"
            Label30.Text = "4.75"
            Label46.Text = "2.25"
            Label50.Text = "2.25"
            Label54.Text = "2"
            Label58.Text = "2.5"
            Label62.Text = "3.25"
            Label66.Text = "1.75"
        End If

        If ComboBox1.Text = "Wario" Then
            Label19.Text = "4.75"
            Label26.Text = "5.25"
            Label42.Text = "4.75"
            Label38.Text = "5"
            Label34.Text = "2"
            Label30.Text = "4.75"
            Label46.Text = "2.25"
            Label50.Text = "2.25"
            Label54.Text = "2"
            Label58.Text = "2.5"
            Label62.Text = "3.25"
            Label66.Text = "1.75"
        End If

        If ComboBox1.Text = "Morton" Then
            Label19.Text = "4.75"
            Label26.Text = "5.25"
            Label42.Text = "4.75"
            Label38.Text = "5"
            Label34.Text = "2"
            Label30.Text = "4.75"
            Label46.Text = "2.25"
            Label50.Text = "2.25"
            Label54.Text = "2"
            Label58.Text = "2.5"
            Label62.Text = "3.25"
            Label66.Text = "1.75"
        End If

        If ComboBox2.Text = "Standard Kart" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Pipe Frame" Then
            Label22.Text = "0"
            Label23.Text = "0.25"
            Label39.Text = "0.25"
            Label35.Text = "-0.25"
            Label31.Text = "0.25"
            Label27.Text = "-0.25"
            Label43.Text = "0.5"
            Label47.Text = "0.5"
            Label51.Text = "0.5"
            Label55.Text = "0.25"
            Label59.Text = "-0.5"
            Label63.Text = "0.25"
        End If

        If ComboBox2.Text = "Mach 8" Then
            Label22.Text = "0.5"
            Label23.Text = "0.25"
            Label39.Text = "0.5"
            Label35.Text = "0.25"
            Label31.Text = "-0.25"
            Label27.Text = "0.25"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "-0.25"
            Label59.Text = "-1"
            Label63.Text = "-0.5"
        End If

        If ComboBox2.Text = "Steel Driver" Then
            Label22.Text = "0"
            Label23.Text = "0.5"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "-0.5"
            Label27.Text = "0.5"
            Label43.Text = "-0.5"
            Label47.Text = "0.75"
            Label51.Text = "-0.25"
            Label55.Text = "-0.75"
            Label59.Text = "0.5"
            Label63.Text = "-0.75"
        End If

        If ComboBox2.Text = "Cat Cruiser" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Prancer" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Sneeker/Bounder" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Circuit Special" Then
            Label22.Text = "0.5"
            Label23.Text = "0.25"
            Label39.Text = "0.5"
            Label35.Text = "0.25"
            Label31.Text = "-0.25"
            Label27.Text = "0.25"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "-0.25"
            Label59.Text = "-1"
            Label63.Text = "-0.5"
        End If

        If ComboBox2.Text = "Sports Coupe/Sports Coupé" Then
            Label22.Text = "0.5"
            Label23.Text = "0.25"
            Label39.Text = "0.5"
            Label35.Text = "0.25"
            Label31.Text = "-0.25"
            Label27.Text = "0.25"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "-0.25"
            Label59.Text = "-1"
            Label63.Text = "-0.5"
        End If

        If ComboBox2.Text = "Gold Standard/Gold Kart" Then
            Label22.Text = "0.5"
            Label23.Text = "0.25"
            Label39.Text = "0.5"
            Label35.Text = "0.25"
            Label31.Text = "-0.25"
            Label27.Text = "0.25"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "-0.25"
            Label59.Text = "-1"
            Label63.Text = "-0.5"
        End If

        If ComboBox2.Text = "Tri-Speeder" Then
            Label22.Text = "0"
            Label23.Text = "0.5"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "-0.5"
            Label27.Text = "0.5"
            Label43.Text = "-0.5"
            Label47.Text = "0.75"
            Label51.Text = "-0.25"
            Label55.Text = "-0.75"
            Label59.Text = "0.5"
            Label63.Text = "-0.75"
        End If

        If ComboBox2.Text = "Badwagon" Then
            Label22.Text = "0"
            Label23.Text = "0.5"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "-0.5"
            Label27.Text = "0.5"
            Label43.Text = "-0.5"
            Label47.Text = "0.75"
            Label51.Text = "-0.25"
            Label55.Text = "-0.75"
            Label59.Text = "0.5"
            Label63.Text = "-0.75"
        End If

        If ComboBox2.Text = "Biddybuggy/Buggybug" Then
            Label22.Text = "-0.75"
            Label23.Text = "0.5"
            Label39.Text = "0.5"
            Label35.Text = "-1"
            Label31.Text = "1.25"
            Label27.Text = "-0.5"
            Label43.Text = "0.5"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0"
            Label59.Text = "-0.25"
            Label63.Text = "1"
        End If

        If ComboBox2.Text = "Landship" Then
            Label22.Text = "-0.75"
            Label23.Text = "0.5"
            Label39.Text = "0.5"
            Label35.Text = "-1"
            Label31.Text = "1.25"
            Label27.Text = "-0.5"
            Label43.Text = "0.5"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0"
            Label59.Text = "-0.25"
            Label63.Text = "1"
        End If

        If ComboBox2.Text = "Standard Bike" Then
            Label22.Text = "0"
            Label23.Text = "0.25"
            Label39.Text = "0.25"
            Label35.Text = "-0.25"
            Label31.Text = "0.25"
            Label27.Text = "-0.25"
            Label43.Text = "0.5"
            Label47.Text = "0.5"
            Label51.Text = "0.5"
            Label55.Text = "0.25"
            Label59.Text = "-0.5"
            Label63.Text = "0.25"
        End If

        If ComboBox2.Text = "Sport Bike" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "0.75"
            Label27.Text = "-0.25"
            Label43.Text = "0.75"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0.5"
            Label59.Text = "-1.25"
            Label63.Text = "0.5"
        End If

        If ComboBox2.Text = "Comet" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "0.75"
            Label27.Text = "-0.25"
            Label43.Text = "0.75"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0.5"
            Label59.Text = "-1.25"
            Label63.Text = "0.5"
        End If

        If ComboBox2.Text = "Jet Bike" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "0.75"
            Label27.Text = "-0.25"
            Label43.Text = "0.75"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0.5"
            Label59.Text = "-1.25"
            Label63.Text = "0.5"
        End If

        If ComboBox2.Text = "Yoshi Bike" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "0.75"
            Label27.Text = "-0.25"
            Label43.Text = "0.75"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0.5"
            Label59.Text = "-1.25"
            Label63.Text = "0.5"
        End If

        If ComboBox2.Text = "Flame Rider" Then
            Label22.Text = "0"
            Label23.Text = "0.25"
            Label39.Text = "0.25"
            Label35.Text = "-0.25"
            Label31.Text = "0.25"
            Label27.Text = "-0.25"
            Label43.Text = "0.5"
            Label47.Text = "0.5"
            Label51.Text = "0.5"
            Label55.Text = "0.25"
            Label59.Text = "-0.5"
            Label63.Text = "0.25"
        End If

        If ComboBox2.Text = "Varmint" Then
            Label22.Text = "0"
            Label23.Text = "0.25"
            Label39.Text = "0.25"
            Label35.Text = "-0.25"
            Label31.Text = "0.25"
            Label27.Text = "-0.25"
            Label43.Text = "0.5"
            Label47.Text = "0.5"
            Label51.Text = "0.5"
            Label55.Text = "0.25"
            Label59.Text = "-0.5"
            Label63.Text = "0.25"
        End If

        If ComboBox2.Text = "The Duke" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Mr. Scooty/Mr Scooty" Then
            Label22.Text = "-0.75"
            Label23.Text = "0.5"
            Label39.Text = "0.5"
            Label35.Text = "-1"
            Label31.Text = "1.25"
            Label27.Text = "-0.5"
            Label43.Text = "0.5"
            Label47.Text = "0.75"
            Label51.Text = "0.75"
            Label55.Text = "0"
            Label59.Text = "-0.25"
            Label63.Text = "1"
        End If

        If ComboBox2.Text = "Teddy Buggy" Then
            Label22.Text = "0"
            Label23.Text = "0"
            Label39.Text = "0"
            Label35.Text = "0"
            Label31.Text = "0"
            Label27.Text = "0"
            Label43.Text = "0"
            Label47.Text = "0"
            Label51.Text = "0"
            Label55.Text = "0"
            Label59.Text = "0"
            Label63.Text = "0"
        End If

        If ComboBox2.Text = "Standard ATV/Standard Quad" Then
            Label22.Text = "0"
            Label23.Text = "0.5"
            Label39.Text = "0"
            Label35.Text = "-0.25"
            Label31.Text = "-0.5"
            Label27.Text = "0.5"
            Label43.Text = "-0.5"
            Label47.Text = "0.75"
            Label51.Text = "-0.25"
            Label55.Text = "-0.75"
            Label59.Text = "0.5"
            Label63.Text = "-0.75"
        End If

        If ComboBox2.Text = "Wild Wiggler" Then
            Label22.Text = "0"
            Label23.Text = "0.25"
            Label39.Text = "0.25"
            Label35.Text = "-0.25"
            Label31.Text = "0.25"
            Label27.Text = "-0.25"
            Label43.Text = "0.5"
            Label47.Text = "0.5"
            Label51.Text = "0.5"
            Label55.Text = "0.25"
            Label59.Text = "-0.5"
            Label63.Text = "0.25"
        End If

        If ComboBox3.Text = "Standard/Normal" Then
            Label20.Text = "0"
            Label25.Text = "0"
            Label41.Text = "0"
            Label37.Text = "0"
            Label33.Text = "0"
            Label29.Text = "0"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "0"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Off-Road" Then
            Label20.Text = "0"
            Label25.Text = "0"
            Label41.Text = "0"
            Label37.Text = "0"
            Label33.Text = "0"
            Label29.Text = "0"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "0"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Retro Off-Road" Then
            Label20.Text = "0"
            Label25.Text = "0"
            Label41.Text = "0"
            Label37.Text = "0"
            Label33.Text = "0"
            Label29.Text = "0"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "0"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Blue Standard/Normal Blue" Then
            Label20.Text = "0"
            Label25.Text = "0"
            Label41.Text = "0"
            Label37.Text = "0"
            Label33.Text = "0"
            Label29.Text = "0"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "0"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Monster" Then
            Label20.Text = "0"
            Label25.Text = "-0.5"
            Label41.Text = "-0.5"
            Label37.Text = "0"
            Label33.Text = "-0.5"
            Label29.Text = "0.5"
            Label45.Text = "-0.75"
            Label49.Text = "-0.75"
            Label53.Text = "-0.75"
            Label57.Text = "-0.75"
            Label61.Text = "0.75"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Hot Monster/Funky Monster" Then
            Label20.Text = "0"
            Label25.Text = "-0.5"
            Label41.Text = "-0.5"
            Label37.Text = "0"
            Label33.Text = "-0.5"
            Label29.Text = "0.5"
            Label45.Text = "-0.75"
            Label49.Text = "-0.75"
            Label53.Text = "-0.75"
            Label57.Text = "-0.75"
            Label61.Text = "0.75"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Roller" Then
            Label20.Text = "-0.5"
            Label25.Text = "0"
            Label41.Text = "0.5"
            Label37.Text = "-0.5"
            Label33.Text = "1"
            Label29.Text = "-0.5"
            Label45.Text = "0.25"
            Label49.Text = "0.25"
            Label53.Text = "0.25"
            Label57.Text = "0.25"
            Label61.Text = "-0.25"
            Label65.Text = "1.5"
        End If

        If ComboBox3.Text = "Button" Then
            Label20.Text = "-0.5"
            Label25.Text = "0"
            Label41.Text = "0.5"
            Label37.Text = "-0.5"
            Label33.Text = "1"
            Label29.Text = "-0.5"
            Label45.Text = "0.25"
            Label49.Text = "0.25"
            Label53.Text = "0.25"
            Label57.Text = "0.25"
            Label61.Text = "-0.25"
            Label65.Text = "1.5"
        End If

        If ComboBox3.Text = "Azure Roller" Then
            Label20.Text = "-0.5"
            Label25.Text = "0"
            Label41.Text = "0.5"
            Label37.Text = "-0.5"
            Label33.Text = "1"
            Label29.Text = "-0.5"
            Label45.Text = "0.25"
            Label49.Text = "0.25"
            Label53.Text = "0.25"
            Label57.Text = "0.25"
            Label61.Text = "-0.25"
            Label65.Text = "1.5"
        End If

        If ComboBox3.Text = "Slim" Then
            Label20.Text = "0.25"
            Label25.Text = "-0.25"
            Label41.Text = "0.25"
            Label37.Text = "0.25"
            Label33.Text = "-0.25"
            Label29.Text = "0"
            Label45.Text = "0.25"
            Label49.Text = "0.25"
            Label53.Text = "0.25"
            Label57.Text = "0.25"
            Label61.Text = "-0.5"
            Label65.Text = "0.25"
        End If

        If ComboBox3.Text = "Crimson Slim" Then
            Label20.Text = "0.25"
            Label25.Text = "-0.25"
            Label41.Text = "0.25"
            Label37.Text = "0.25"
            Label33.Text = "-0.25"
            Label29.Text = "0"
            Label45.Text = "0.25"
            Label49.Text = "0.25"
            Label53.Text = "0.25"
            Label57.Text = "0.25"
            Label61.Text = "-0.5"
            Label65.Text = "0.25"
        End If

        If ComboBox3.Text = "Slick" Then
            Label20.Text = "0.5"
            Label25.Text = "-1"
            Label41.Text = "0.5"
            Label37.Text = "0.5"
            Label33.Text = "-0.25"
            Label29.Text = "0.25"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "-1"
            Label65.Text = "0.25"
        End If

        If ComboBox3.Text = "Cyber Slick" Then
            Label20.Text = "0.5"
            Label25.Text = "-1"
            Label41.Text = "0.5"
            Label37.Text = "0.5"
            Label33.Text = "-0.25"
            Label29.Text = "0.25"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "-1"
            Label65.Text = "0.25"
        End If

        If ComboBox3.Text = "Metal" Then
            Label20.Text = "0.25"
            Label25.Text = "-0.25"
            Label41.Text = "0.25"
            Label37.Text = "0.25"
            Label33.Text = "-0.5"
            Label29.Text = "0.5"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "-0.5"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Gold Tires/Gold Wheels" Then
            Label20.Text = "0.25"
            Label25.Text = "-0.25"
            Label41.Text = "0.25"
            Label37.Text = "0.25"
            Label33.Text = "-0.5"
            Label29.Text = "0.5"
            Label45.Text = "0"
            Label49.Text = "0"
            Label53.Text = "0"
            Label57.Text = "0"
            Label61.Text = "-0.5"
            Label65.Text = "0"
        End If

        If ComboBox3.Text = "Sponge" Then
            Label20.Text = "-0.25"
            Label25.Text = "-1"
            Label41.Text = "0.25"
            Label37.Text = "-0.25"
            Label33.Text = "0.25"
            Label29.Text = "-0.25"
            Label45.Text = "-0.25"
            Label49.Text = "-0.5"
            Label53.Text = "0"
            Label57.Text = "-0.25"
            Label61.Text = "0.5"
            Label65.Text = "0.75"
        End If

        If ComboBox3.Text = "Wood/Wooden" Then
            Label20.Text = "-0.25"
            Label25.Text = "-1"
            Label41.Text = "0.25"
            Label37.Text = "-0.25"
            Label33.Text = "0.25"
            Label29.Text = "-0.25"
            Label45.Text = "-0.25"
            Label49.Text = "-0.5"
            Label53.Text = "0"
            Label57.Text = "-0.25"
            Label61.Text = "0.5"
            Label65.Text = "0.75"
        End If

        If ComboBox3.Text = "Cushion" Then
            Label20.Text = "-0.25"
            Label25.Text = "-1"
            Label41.Text = "0.25"
            Label37.Text = "-0.25"
            Label33.Text = "0.25"
            Label29.Text = "-0.25"
            Label45.Text = "-0.25"
            Label49.Text = "-0.5"
            Label53.Text = "0"
            Label57.Text = "-0.25"
            Label61.Text = "0.5"
            Label65.Text = "0.75"
        End If

        If ComboBox4.Text = "Super Glider" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "0"
            Label36.Text = "0"
            Label32.Text = "0"
            Label28.Text = "0"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0"
        End If

        If ComboBox4.Text = "Wario Wing" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "0"
            Label36.Text = "0"
            Label32.Text = "0"
            Label28.Text = "0"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0"
        End If

        If ComboBox4.Text = "Waddle Wing" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "0"
            Label36.Text = "0"
            Label32.Text = "0"
            Label28.Text = "0"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0"
        End If

        If ComboBox4.Text = "Plane Glider" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "0"
            Label36.Text = "0"
            Label32.Text = "0"
            Label28.Text = "0"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0"
        End If

        If ComboBox4.Text = "Gold Glider" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "0"
            Label36.Text = "0"
            Label32.Text = "0"
            Label28.Text = "0"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0"
        End If

        If ComboBox4.Text = "Peach Parasol" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "Parachute" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "Parafoil" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "Flower Glider" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "Bowser Kite" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "MKTV Parafoil" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        If ComboBox4.Text = "Cloud Glider" Then
            Label21.Text = "0"
            Label24.Text = "0"
            Label40.Text = "-0.25"
            Label36.Text = "0"
            Label32.Text = "0.25"
            Label28.Text = "-0.25"
            Label44.Text = "0"
            Label48.Text = "0"
            Label52.Text = "0.25"
            Label56.Text = "0"
            Label60.Text = "0"
            Label64.Text = "0.25"
        End If

        Select Case ComboBox1.Text + ComboBox2.Text + ComboBox3.Text + ComboBox4.Text
            Case ""
                MsgBox("None of the categories have been filled in.")
        End Select

        Label67.Text = Val(Label21.Text) + Val(Label20.Text) + Val(Label22.Text) + Val(Label19.Text)
        Label68.Text = Val(Label26.Text) + Val(Label32.Text) + Val(Label35.Text) + Val(Label24.Text)
        Label69.Text = Val(Label42.Text) + Val(Label39.Text) + Val(Label41.Text) + Val(Label40.Text)
        Label70.Text = Val(Label38.Text) + Val(Label37.Text) + Val(Label36.Text) + Val(Label35.Text)
        Label71.Text = Val(Label34.Text) + Val(Label33.Text) + Val(Label32.Text) + Val(Label31.Text)
        Label72.Text = Val(Label30.Text) + Val(Label29.Text) + Val(Label28.Text) + Val(Label27.Text)
        Label73.Text = Val(Label46.Text) + Val(Label45.Text) + Val(Label44.Text) + Val(Label43.Text)
        Label74.Text = Val(Label50.Text) + Val(Label49.Text) + Val(Label48.Text) + Val(Label47.Text)
        Label75.Text = Val(Label54.Text) + Val(Label53.Text) + Val(Label52.Text) + Val(Label51.Text)
        Label76.Text = Val(Label58.Text) + Val(Label57.Text) + Val(Label56.Text) + Val(Label55.Text)
        Label77.Text = Val(Label62.Text) + Val(Label61.Text) + Val(Label60.Text) + Val(Label59.Text)
        Label78.Text = Val(Label66.Text) + Val(Label65.Text) + Val(Label64.Text) + Val(Label63.Text)

    End Sub

#End Region

#Region "Clan War Table"

    Private Sub ScreenshotInstructions(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("PLEASE CLOSE THIS WINDOW BEFORE DOING THIS! To capture the table, press Alt+PrtScr on your keyboard, then copy it into a paint program, and then save it as a .png ")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim tag As String
        tag = TextBox4.Text
        Label85.Text = tag
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim tag2 As String
        tag2 = TextBox3.Text
        Label87.Text = tag2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox29.Text = Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text)
        TextBox30.Text = Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text)
        TextBox31.Text = Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text)
        TextBox32.Text = Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text)
        TextBox33.Text = Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text)
        TextBox34.Text = Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox28.Text)
        TextBox46.Text = Val(TextBox64.Text) + Val(TextBox63.Text) + Val(TextBox62.Text)
        TextBox45.Text = Val(TextBox61.Text) + Val(TextBox60.Text) + Val(TextBox59.Text)
        TextBox44.Text = Val(TextBox58.Text) + Val(TextBox57.Text) + Val(TextBox56.Text)
        TextBox43.Text = Val(TextBox55.Text) + Val(TextBox54.Text) + Val(TextBox53.Text)
        TextBox42.Text = Val(TextBox52.Text) + Val(TextBox51.Text) + Val(TextBox50.Text)
        TextBox41.Text = Val(TextBox49.Text) + Val(TextBox48.Text) + Val(TextBox47.Text)

        TextBox65.Text = Val(TextBox11.Text) + Val(TextBox14.Text) + Val(TextBox17.Text) + Val(TextBox20.Text) + Val(TextBox23.Text) + Val(TextBox26.Text)
        TextBox66.Text = Val(TextBox12.Text) + Val(TextBox15.Text) + Val(TextBox18.Text) + Val(TextBox21.Text) + Val(TextBox24.Text) + Val(TextBox27.Text)
        TextBox67.Text = Val(TextBox13.Text) + Val(TextBox16.Text) + Val(TextBox19.Text) + Val(TextBox22.Text) + Val(TextBox25.Text) + Val(TextBox28.Text)

        TextBox68.Text = Val(TextBox64.Text) + Val(TextBox61.Text) + Val(TextBox58.Text) + Val(TextBox55.Text) + Val(TextBox52.Text) + Val(TextBox49.Text)
        TextBox69.Text = Val(TextBox63.Text) + Val(TextBox60.Text) + Val(TextBox57.Text) + Val(TextBox54.Text) + Val(TextBox51.Text) + Val(TextBox48.Text)
        TextBox70.Text = Val(TextBox62.Text) + Val(TextBox59.Text) + Val(TextBox56.Text) + Val(TextBox53.Text) + Val(TextBox50.Text) + Val(TextBox47.Text)

        Label100.Text = Val(TextBox65.Text) + Val(TextBox66.Text) + Val(TextBox67.Text)
        Label101.Text = Val(TextBox68.Text) + Val(TextBox69.Text) + Val(TextBox70.Text)

    End Sub
#End Region

#Region "Time Trial Viewer"

    Private Sub StartTTViewer(sender As Object, e As EventArgs) Handles TabPage4.Enter
        PictureBox10.Image = My.Resources.MK8__Mario_Kart_Stadium
        PictureBox11.Image = My.Resources.MK8__Water_Park
        PictureBox12.Image = My.Resources.MK8__Sweet_Sweet_Canyon
        PictureBox13.Image = My.Resources.MK8__Thwomp_Ruins

        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        track1 = 27
        track2 = 28
        track3 = 19
        track4 = 17
        LoadRanks(track1)
        PictureBox10.BorderStyle = BorderStyle.Fixed3D
        PictureBox11.BorderStyle = BorderStyle.None
        PictureBox12.BorderStyle = BorderStyle.None
        PictureBox13.BorderStyle = BorderStyle.None
    End Sub

    Private Sub LoadMushroomCup(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__Mario_Kart_Stadium
        PictureBox11.Image = My.Resources.MK8__Water_Park
        PictureBox12.Image = My.Resources.MK8__Sweet_Sweet_Canyon
        PictureBox13.Image = My.Resources.MK8__Thwomp_Ruins
        track1 = 27
        track2 = 28
        track3 = 19
        track4 = 17
        ResetBorders()
    End Sub

    Private Sub LoadFlowerCup(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__Mario_Circuit
        PictureBox11.Image = My.Resources.MK8__Toad_Harbor
        PictureBox12.Image = My.Resources.MK8__Twisted_Mansion
        PictureBox13.Image = My.Resources.MK8__Shy_Guy_Falls
        track1 = 16
        track2 = 18
        track3 = 20
        track4 = 21
        ResetBorders()
    End Sub

    Private Sub LoadStarCup(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__Sunshine_Airport
        PictureBox11.Image = My.Resources.MK8__Dolphin_Shoals
        PictureBox12.Image = My.Resources.MK8__Electrodrome
        PictureBox13.Image = My.Resources.MK8__Mount_Wario
        track1 = 26
        track2 = 29
        track3 = 25
        track4 = 24
        ResetBorders()
    End Sub

    Private Sub LoadSpecialCup(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__Cloudtop_Cruise
        PictureBox11.Image = My.Resources.MK8__Bone_Dry_Dunes
        PictureBox12.Image = My.Resources.MK8__Bowser_s_Castle
        PictureBox13.Image = My.Resources.MK8__Rainbow_Road
        track1 = 23
        track2 = 22
        track3 = 30
        track4 = 31
        ResetBorders()
    End Sub

    Private Sub LoadShellCup(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__Wii_Moo_Moo_Meadows
        PictureBox11.Image = My.Resources.MK8__GBA_Mario_Circuit
        PictureBox12.Image = My.Resources.MK8__DS_Cheep_Cheep_Beach
        PictureBox13.Image = My.Resources.MK8__N64_Toad_s_Turnpike
        track1 = 33
        track2 = 38
        track3 = 36
        track4 = 35
        ResetBorders()
    End Sub

    Private Sub LoadBananaCup(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__GCN_Dry_Dry_Desert
        PictureBox11.Image = My.Resources.MK8__SNES_Donut_Plains_3
        PictureBox12.Image = My.Resources.MK8__N64_Royal_Raceway
        PictureBox13.Image = My.Resources.MK8__3DS_DK_Jungle
        track1 = 42
        track2 = 41
        track3 = 34
        track4 = 32
        ResetBorders()
    End Sub

    Private Sub LoadLeafCup(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__DS_Wario_Stadium
        PictureBox11.Image = My.Resources.MK8__GCN_Sherbet_Land
        PictureBox12.Image = My.Resources.MK8__3DS_Music_Park
        PictureBox13.Image = My.Resources.MK8__N64_Yoshi_Valley
        track1 = 46
        track2 = 37
        track3 = 39
        track4 = 45
        ResetBorders()
    End Sub

    Private Sub LoadLightningCup(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.Image = My.Resources.MK8__DS_Tick_Tock_Clock
        PictureBox11.Image = My.Resources.MK8__3DS_Piranha_Plant_Slide
        PictureBox12.Image = My.Resources.MK8__Wii_Grumble_Volcano
        PictureBox13.Image = My.Resources.MK8__N64_Rainbow_Road
        track1 = 44
        track2 = 43
        track3 = 40
        track4 = 47
        ResetBorders()
    End Sub

    Private Sub LoadTrack1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        LoadRanks(track1)
        PictureBox10.BorderStyle = BorderStyle.Fixed3D
        PictureBox11.BorderStyle = BorderStyle.None
        PictureBox12.BorderStyle = BorderStyle.None
        PictureBox13.BorderStyle = BorderStyle.None
    End Sub
    Private Sub LoadTrack2(sender As Object, e As EventArgs) Handles PictureBox11.Click
        LoadRanks(track2)
        PictureBox10.BorderStyle = BorderStyle.None
        PictureBox11.BorderStyle = BorderStyle.Fixed3D
        PictureBox12.BorderStyle = BorderStyle.None
        PictureBox13.BorderStyle = BorderStyle.None
    End Sub

    Private Sub LoadTrack3(sender As Object, e As EventArgs) Handles PictureBox12.Click
        LoadRanks(track3)
        PictureBox10.BorderStyle = BorderStyle.None
        PictureBox11.BorderStyle = BorderStyle.None
        PictureBox12.BorderStyle = BorderStyle.Fixed3D
        PictureBox13.BorderStyle = BorderStyle.None
    End Sub

    Private Sub LoadTrack4(sender As Object, e As EventArgs) Handles PictureBox13.Click
        LoadRanks(track4)
        PictureBox10.BorderStyle = BorderStyle.None
        PictureBox11.BorderStyle = BorderStyle.None
        PictureBox12.BorderStyle = BorderStyle.None
        PictureBox13.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub LoadRanks(ByVal ID As Integer)
        Dim downloader As New TimeTrialDownloader(ID)
        Rank1Mii.SizeMode = PictureBoxSizeMode.StretchImage
        Rank2Mii.SizeMode = PictureBoxSizeMode.StretchImage
        Rank3Mii.SizeMode = PictureBoxSizeMode.StretchImage
        Rank4Mii.SizeMode = PictureBoxSizeMode.StretchImage
        Rank5Mii.SizeMode = PictureBoxSizeMode.StretchImage
        Rank6Mii.SizeMode = PictureBoxSizeMode.StretchImage

        Rank1Mii.ImageLocation = downloader.Scores(0).iconUrl
        TopRankName1.Text = downloader.Scores(0).playerName
        TopRankTime1.Text = downloader.Scores(0).time
        NNID1.Text = downloader.Scores(0).playerNNID

        Rank2Mii.ImageLocation = downloader.Scores(1).iconUrl
        TopRankName2.Text = downloader.Scores(1).playerName
        TopRankTime2.Text = downloader.Scores(1).time
        NNID2.Text = downloader.Scores(1).playerNNID

        Rank3Mii.ImageLocation = downloader.Scores(2).iconUrl
        TopRankName3.Text = downloader.Scores(2).playerName
        TopRankTime3.Text = downloader.Scores(2).time
        NNID3.Text = downloader.Scores(2).playerNNID

        Rank4Mii.ImageLocation = downloader.Scores(3).iconUrl
        TopRankName4.Text = downloader.Scores(3).playerName
        TopRankTime4.Text = downloader.Scores(3).time
        NNID4.Text = downloader.Scores(3).playerNNID

        Rank5Mii.ImageLocation = downloader.Scores(4).iconUrl
        TopRankName5.Text = downloader.Scores(4).playerName
        TopRankTime5.Text = downloader.Scores(4).time
        NNID5.Text = downloader.Scores(4).playerNNID

        Rank6Mii.ImageLocation = downloader.Scores(5).iconUrl
        TopRankName6.Text = downloader.Scores(5).playerName
        TopRankTime6.Text = downloader.Scores(5).time
        NNID6.Text = downloader.Scores(5).playerNNID
    End Sub

    Private Sub ResetBorders()
        PictureBox10.BorderStyle = BorderStyle.None
        PictureBox11.BorderStyle = BorderStyle.None
        PictureBox12.BorderStyle = BorderStyle.None
        PictureBox13.BorderStyle = BorderStyle.None
    End Sub

#End Region

#Region "MKTV Database"


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles SearchMKTV.Click
        MKTV_Search.Show()


    End Sub

    Private Sub showvideo(ByVal Video As VideoObject)
        miiverseurl = Video.miiverseUrl

        TrackMKTV.SizeMode = PictureBoxSizeMode.StretchImage
        MiiIconMKTV.SizeMode = PictureBoxSizeMode.StretchImage
        CharacterMKTV.SizeMode = PictureBoxSizeMode.StretchImage
        Select Case Video.track
            Case "Mario Kart Stadium"
                TrackMKTV.Image = My.Resources.MK8__Mario_Kart_Stadium
            Case "Water Park"
                TrackMKTV.Image = My.Resources.MK8__Water_Park
            Case "Sweet Sweet Canyon"
                TrackMKTV.Image = My.Resources.MK8__Sweet_Sweet_Canyon
            Case "Thwomp Ruins"
                TrackMKTV.Image = My.Resources.MK8__Thwomp_Ruins
            Case "Mario Circuit"
                TrackMKTV.Image = My.Resources.MK8__Mario_Circuit
            Case "Toad Harbor"
                TrackMKTV.Image = My.Resources.MK8__Toad_Harbor
            Case "Twisted Mansion"
                TrackMKTV.Image = My.Resources.MK8__Twisted_Mansion
            Case "Shy Guy Falls"
                TrackMKTV.Image = My.Resources.MK8__Shy_Guy_Falls
            Case "Sunshine Airport"
                TrackMKTV.Image = My.Resources.MK8__Sunshine_Airport
            Case "Dolphin Shoals"
                TrackMKTV.Image = My.Resources.MK8__Dolphin_Shoals
            Case "Electrodrome"
                TrackMKTV.Image = My.Resources.MK8__Electrodrome
            Case "Mount Wario"
                TrackMKTV.Image = My.Resources.MK8__Mount_Wario
            Case "Cloudtop Cruise"
                TrackMKTV.Image = My.Resources.MK8__Cloudtop_Cruise
            Case "Bone-Dry Dunes"
                TrackMKTV.Image = My.Resources.MK8__Bone_Dry_Dunes
            Case "Bowser's Castle"
                TrackMKTV.Image = My.Resources.MK8__Bowser_s_Castle
            Case "Rainbow Road"
                TrackMKTV.Image = My.Resources.MK8__Rainbow_Road
            Case "Wii Moo Moo Meadows"
                TrackMKTV.Image = My.Resources.MK8__Wii_Moo_Moo_Meadows
            Case "GBA Mario Circuit"
                TrackMKTV.Image = My.Resources.MK8__GBA_Mario_Circuit
            Case "DS Cheep Cheep Beach"
                TrackMKTV.Image = My.Resources.MK8__DS_Cheep_Cheep_Beach
            Case "N64 Toad's Turnpike"
                TrackMKTV.Image = My.Resources.MK8__N64_Toad_s_Turnpike
            Case "GCN Dry Dry Desert"
                TrackMKTV.Image = My.Resources.MK8__GCN_Dry_Dry_Desert
            Case "SNES Donut Plains 3"
                TrackMKTV.Image = My.Resources.MK8__SNES_Donut_Plains_3
            Case "N64 Royal Raceway"
                TrackMKTV.Image = My.Resources.MK8__N64_Royal_Raceway
            Case "3DS DK Jungle"
                TrackMKTV.Image = My.Resources.MK8__3DS_DK_Jungle
            Case "DS Wario Stadium"
                TrackMKTV.Image = My.Resources.MK8__DS_Wario_Stadium
            Case "GCN Sherbet Land"
                TrackMKTV.Image = My.Resources.MK8__GCN_Sherbet_Land
            Case "3DS Music Park"
                TrackMKTV.Image = My.Resources.MK8__3DS_Music_Park
            Case "N64 Yoshi Valley"
                TrackMKTV.Image = My.Resources.MK8__N64_Yoshi_Valley
            Case "DS Tick-Tock Clock"
                TrackMKTV.Image = My.Resources.MK8__DS_Tick_Tock_Clock
            Case "3DS Piranha Plant Slide"
                TrackMKTV.Image = My.Resources.MK8__3DS_Piranha_Plant_Slide
            Case "Wii Grumble Volcano"
                TrackMKTV.Image = My.Resources.MK8__Wii_Grumble_Volcano
            Case "N64 Rainbow Road"
                TrackMKTV.Image = My.Resources.MK8__N64_Rainbow_Road
        End Select

        MiiIconMKTV.ImageLocation = Video.miiIconUrl
        CharacterMKTV.ImageLocation = "http://winepicgaming.de/mkapp/images/" & Video.character & ".png"
        MiiNameMKTV.Text = Video.miiName
        NNIDMKTV.Text = "NNID: " & Video.nnid
        GameModeMKTV.Text = Video.gameMode
        VideoViewer.Navigate("http://www.youtube.com/embed/" & Video.youtubeId)
        If miiverseurl = "None" Then
            MiiverseLink.Visible = False
        Else
            MiiverseLink.Visible = True
        End If
    End Sub

    Private Sub VideoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VideoList.SelectedIndexChanged
        Try
            Dim i As Integer = VideoList.FocusedItem.Index
            showvideo(youtube(i))
        Catch ex As Exception

        End Try

    End Sub


    Private Sub MiiverseLink_Click(sender As Object, e As EventArgs) Handles MiiverseLink.Click
        System.Diagnostics.Process.Start(miiverseurl)
    End Sub

    Private Sub LoadFavourites()
        Dim json As String
        Try
            json = System.IO.File.ReadAllText("favourites.json")
            favourites = JsonConvert.DeserializeObject(Of List(Of VideoObject))(json)
        Catch ex As Exception
            MsgBox("No favourites have been added")
        End Try
        VideoList.Items.Clear()
        For Each video As VideoObject In favourites
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
            item.SubItems(4).Text = video.gameMode
            item.SubItems(5).Text = video.character
            VideoList.Items.Add(item)
        Next
        VideoList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        AreFavShown = True
        SaveFav.Enabled = False
        RemoveFav.Enabled = True
        ShowFav.Enabled = False
        youtube = favourites
    End Sub

    Private Sub SaveFavourites()
        Dim json As String = JsonConvert.SerializeObject(favourites)
        System.IO.File.WriteAllText("favourites.json", json)
    End Sub

    Private Sub ShowFav_Click(sender As Object, e As EventArgs) Handles ShowFav.Click
        LoadFavourites()
    End Sub

    Private Sub SaveFav_Click(sender As Object, e As EventArgs) Handles SaveFav.Click
        Try
            Dim i As Integer = VideoList.FocusedItem.Index
            favourites.Add(youtube(i))
            SaveFavourites()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveFav_Click(sender As Object, e As EventArgs) Handles RemoveFav.Click
        Try
            Dim i As Integer = VideoList.FocusedItem.Index
            favourites.Remove(favourites(i))
            SaveFavourites()
            LoadFavourites()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MKTVDB.Click
        If IsRegistryKeySet() Then
            Dim result As MsgBoxResult = MsgBox("This will uninstall the MKTV Database Handler from your PC. Make sure this app has Administrator rights as this will apply changes to your Windows Registry. Do you want to continue?", MsgBoxStyle.YesNo, "MKTVDB Handler installation")
            If result = MsgBoxResult.Yes Then
                Try
                    Registry.ClassesRoot.DeleteSubKeyTree("mktvdb")
                Catch ex As Exception
                    MsgBox("Uninstall failed. Are you running as Admin? No changes were made to your registry.")
                End Try

            End If
        Else
            Dim result As MsgBoxResult = MsgBox("This will install the MKTV Database Handler to your PC. Make sure this app has Administrator rights as this will apply changes to your Windows Registry. Do you want to continue?", MsgBoxStyle.YesNo, "MKTVDB Handler installation")
            If result = MsgBoxResult.Yes Then
                Try
                    Dim key As RegistryKey = Registry.ClassesRoot.CreateSubKey("mktvdb")
                    key.SetValue("URL Protocol", "")
                    key.CreateSubKey("DefaultIcon").SetValue("", Application.ExecutablePath & ",1")
                    key.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command").SetValue("", """" & Application.ExecutablePath & """ ""%1""")
                Catch ex As Exception
                    MsgBox("Installation failed. Are you running as Admin? No changes were made to your registry.")
                End Try
            End If
        End If

        If IsRegistryKeySet() Then
            MKTVDB.Text = "Uninstall MKTVDB Handler"
        Else
            MKTVDB.Text = "Install MKTVDB Handler"
        End If
    End Sub

    Private Sub MKTVDBExternalCall(Optional ByVal NNID As String = "", Optional ByVal YoutubeID As String = "")
        Homepage.SelectTab(4)
        Dim query As New MktvDirectQuery(YoutubeID, NNID)
        youtube = query.Videos
        For Each video As VideoObject In query.Videos
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
            item.SubItems(4).Text = video.gameMode
            item.SubItems(5).Text = video.character
            VideoList.Items.Add(item)
        Next
        VideoList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        If Not YoutubeID = "" Then
            Try
                VideoList.Items(0).Focused = True
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region

    Private Function IsRegistryKeySet() As Boolean
        If My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\mktvdb", "URL Protocol", Nothing) Is Nothing Then
            Return False
        End If
        Return True
    End Function
End Class




