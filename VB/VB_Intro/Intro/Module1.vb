Module Module1





    ' my functions

    Sub web(index, url)
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(url)
        Dim fs = CreateObject("Scripting.FileSystemObject")
        Dim a = fs.CreateTextFile("~\Desktop\datatest" + index.ToString() + ".html", True)
        a.WriteLine(result)
        a.Close


    End Sub

    Sub CreateAfile(filename)
        Dim fs = CreateObject("Scripting.FileSystemObject")
        Dim a = fs.CreateTextFile("~\" + filename + ".txt", True)
        a.WriteLine("This is a test.")
        a.Close
    End Sub

    Sub CreateAfile2(data, options)

        Dim fs = CreateObject("Scripting.FileSystemObject")
        Dim a = fs.CreateTextFile("~\Desktop\data" + options + ".html", True)
        a.WriteLine(data)
        a.Close


    End Sub

    Sub makeone(data, option_)

    End Sub
    Sub Main()
        Dim articles = {"http://localhost:4444/", "http://localhost/"}

        For index = 0 To articles.GetUpperBound(0)
            Dim curr = articles.ElementAt(index)
            'Console.Write(index.ToString() + " : " + curr + vbNewLine)
            web(index, curr)

        Next
        Console.WriteLine("Press Enter to finish" + vbNewLine)
        Console.ReadKey()
    End Sub

End Module
