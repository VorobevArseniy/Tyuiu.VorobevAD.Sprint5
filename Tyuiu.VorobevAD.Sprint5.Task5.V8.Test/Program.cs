using Tyuiu.VorobevAD.Sprint5.Task3.V1.Lib;

namespace Tyuiu.VorobevAD.Sprint5.Task3.V1;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();

        Console.WriteLine(ds.SaveToFileTextData(3));
    }
}
