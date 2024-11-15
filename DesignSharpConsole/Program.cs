using DecoratorPattern.IOExample;
using DecoratorPattern.StarbuzzExample;
using ObserverPattern.SimpleObservableExample;
using ObserverPattern.WeatherStationExample;

namespace DesignSharpConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\Users\\YN\\Desktop\\test.txt";
            IFileReader fileReader = new FileReader(filePath);
            fileReader = new LowerCaseFileReaderDecorator(fileReader);
            Console.WriteLine(fileReader.Read());


        }
    }
}
