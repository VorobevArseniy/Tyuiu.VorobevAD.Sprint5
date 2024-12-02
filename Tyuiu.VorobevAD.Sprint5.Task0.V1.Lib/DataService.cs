using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevAD.Sprint5.Task0.V1.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task0V1
{
	public string SaveToFileTextData(int x)
	{
		string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

		double y = Math.Round(Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4, 2);

		File.WriteAllText(path, y.ToString());


		return "C:/User/temp" + path;

		throw new NotImplementedException();
	}
}
