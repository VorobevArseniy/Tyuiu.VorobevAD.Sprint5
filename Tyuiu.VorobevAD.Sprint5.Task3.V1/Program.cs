using Tyuiu.VorobevAD.Sprint5.Task3.V1.Lib;

namespace Tyuiu.VorobevAD.Sprint5.Task3.V1;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        ds.SaveToFileTextData(3);
        Console.WriteLine("Hello, World!");
    }
}
