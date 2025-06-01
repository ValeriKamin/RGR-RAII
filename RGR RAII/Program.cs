using System;
using System.IO;

public class FileHandler : IDisposable
{
    private FileStream fileStream;


    public FileHandler(string path)
    {
        Console.WriteLine("Вiдкриття файлу");
        fileStream = new FileStream(path, FileMode.Create);
    }

    public void Write(string text)
    {
        using StreamWriter writer = new StreamWriter(fileStream);
        writer.WriteLine(text);
        Console.WriteLine("Запис завершено.");
    }

    public void Dispose()
    {
        Console.WriteLine("Закриття файлу...");
        fileStream?.Dispose();
    }
}

class Program
{
    static void Main()
    {
        using var handler = new FileHandler("example.txt");
        handler.Write("RAII в .NET через using та IDisposable");
    }
}
