
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Dim request As New System.Net.WebClient
        request.DownloadString("http://winepicgaming.de/mkapp/version.txt")

        Dim reply As String = request.DownloadString("http://winepicgaming.de/mkapp/version.txt")

        If Not reply = "1.0.2.1" Then
            Dim p As New Process()
            p.StartInfo.FileName = "updater.exe"
            p.Start()
            End
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MsgBox("This feature is currently under test conditions. To check for updates, click 'Visit Thread' to go and check for new updates.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://www.mariokartwii.com/threads/139519-The-Mario-Kart-8-App")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dialog1.Show()
    End Sub
End Class


