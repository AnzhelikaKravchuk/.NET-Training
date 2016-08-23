<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

//using Fabrikam.Extensions in VS

void Main()
{
	int[] m = { 3, 4, 6 };
	//ArrayHelper.Sum(m).Dump();
	m.Sum().Dump();
	
}

//namespace Fabrikam.Extensions
//{
	public static class ArrayHelper
	{
		public static int Sum(this int[] array)
		{
			var result = 0;
			foreach (var item in array)
			{
				result += item;
			}
			return result;
		}
	}
//}