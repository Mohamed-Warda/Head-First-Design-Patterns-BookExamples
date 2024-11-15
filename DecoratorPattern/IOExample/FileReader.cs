namespace DecoratorPattern.IOExample;

public class FileReader:IFileReader
{
    private readonly string _filePath;

    public FileReader(string filePath)
    {
        _filePath = filePath;
    }

    public string Read()
    {
        using (var fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
        using (var reader = new StreamReader(fileStream))
        {
            return reader.ReadToEnd();
        }
    }
}