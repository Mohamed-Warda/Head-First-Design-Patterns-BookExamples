namespace DecoratorPattern.IOExample;

public abstract class FileReaderDecorator : IFileReader
{
    protected readonly IFileReader FileReader;

    protected FileReaderDecorator(IFileReader fileReader)
    {
        FileReader = fileReader;
    }

    public abstract string Read();
}