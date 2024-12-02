using Tyuiu.VorobevAD.Sprint5.Task0.V1.Lib;

namespace Tyuiu.VorobevAD.Sprint5.Task0.V1;

class Program
{
    static void Main(string[] args)
    {
        DataService obj = new();
        obj.SaveToFileTextData(2);
    }
}
