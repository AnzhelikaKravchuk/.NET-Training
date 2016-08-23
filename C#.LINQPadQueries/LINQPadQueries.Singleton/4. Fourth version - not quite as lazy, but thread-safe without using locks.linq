<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Fourth version
// Fourth version - not quite as lazy, but thread-safe without using locks
#endregion
//Почти «ленивая» реализация
public sealed class Singleton
{
	private static readonly Singleton instance = new Singleton();

	// Добавление явного статического конструктора приказывает компилятору 
	// не помечать тип атрибутом beforefieldinit
	static Singleton() { }

	private Singleton(){ }

	public static Singleton Instance
	{
		get
		{
			return instance;
		}
	}
}

void Main(){ }