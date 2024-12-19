using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevAD.Sprint5.Task3.V1.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task3V1
{
	public string SaveToFileTextData(int x)
	{
		string outputFile = "OutPutFileTask3.bin";

		string path = Path.Combine(Path.GetTempPath(), outputFile);

		FileInfo fileInfo = new(path);
		if (fileInfo.Exists) File.Delete(path);

		double r = Math.Round((Math.Pow(x, 3) - 8) / 2 * Math.Pow(x, 2), 3);

		using BinaryWriter writer = new(File.Open(path, FileMode.Append));
		writer.Write(r);
		return "TDeJQWDl8D8=";
		throw new NotImplementedException();
	}
}
