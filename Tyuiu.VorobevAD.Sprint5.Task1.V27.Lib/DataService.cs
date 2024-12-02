using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevAD.Sprint5.Task1.V27.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task1V27
{
	public string SaveToFileTextData(int startValue, int stopValue)
	{
		return Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
		throw new NotImplementedException();
	}
}
