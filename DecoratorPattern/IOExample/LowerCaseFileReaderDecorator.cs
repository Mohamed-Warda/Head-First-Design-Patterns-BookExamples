namespace DecoratorPattern.IOExample;

public class LowerCaseFileReaderDecorator: FileReaderDecorator
{
    public LowerCaseFileReaderDecorator(IFileReader fileReader) : base(fileReader)
    {
    }


    public override string Read()
    {
      var content = FileReader.Read();
      return content.ToLower();
    }
}