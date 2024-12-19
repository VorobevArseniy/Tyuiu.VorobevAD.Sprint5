using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevAD.Sprint5.Task6.V24.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint5.ISprint5Task6V24
{
	public int LoadFromDataFile(string path)
	{
		int sum = 0;

		string str = File.ReadAllText(path);
		string[] chisla = str.Split(", ");

		for (int i = 0; i < chisla.Length; i++)
		{
			if (i == chisla.Length - 1) chisla[i] = chisla[i].Remove(chisla[i].Length - 1);
			if (chisla[i].Length == 4) sum++;
			Console.WriteLine(chisla[i]);
		}

		return sum;
		throw new NotImplementedException();
	}
}
