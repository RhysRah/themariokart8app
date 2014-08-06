Imports System.Net
Imports System.IO
Imports Ionic.Zip

Module Module1

    Sub Main()
        Dim downloader As New WebClient
        Console.WriteLine("Please wait, update is downloading.")
        downloader.DownloadFile(New Uri("http://winepicgaming.de/MKapp/update.zip"), "tmp")
        Console.WriteLine("Finished downloading, now extracting.")
        Dim file As ZipFile = ZipFile.Read("tmp")
        file.ExtractAll(My.Application.Info.DirectoryPath, ExtractExistingFileAction.OverwriteSilently)
        Console.WriteLine("Extraction is finished, the update was installed.")
        file.Dispose()
        My.Computer.FileSystem.DeleteFile("tmp")
        Console.WriteLine("Deleted temporary update files.")
        Console.WriteLine("Restarting app...")
        Dim p As New Process()
        p.StartInfo.FileName = "mk8a.exe"
        p.Start()
    End Sub

End Module
