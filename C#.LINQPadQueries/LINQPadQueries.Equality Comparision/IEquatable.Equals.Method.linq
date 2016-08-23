<Query Kind="Program" />

//bool Equals(T other)
//http://msdn.microsoft.com/ru-ru/library/ms131190(v=vs.110).aspx
//http://msdn.microsoft.com/ru-ru/library/ms131190(v=vs.110).aspx

void Main()
{
	Person p1 = new Person() {SSN="199-29-3999"};
	Person p2 = new Person() {SSN="199-29-3999"};;
	(p1 == p2).Dump();
	p1.GetHashCode().Dump();
	p2.GetHashCode().Dump();
}

public class Person : IEquatable<Person>
{
	private string uniqueSsn;
	private string lName;
	public Person()
	{

	}
	public Person(string lastName, string ssn)
	{
		this.SSN = ssn;
		this.LastName = lastName;
	}

	public string SSN
	{
		get { return this.uniqueSsn; }
		set
		{
			if (Regex.IsMatch(value, @"\d{9}"))
				uniqueSsn = String.Format("{0}-(1}-{2}", value.Substring(0, 3),
														 value.Substring(3, 2),
														 value.Substring(5, 4));
			else if (Regex.IsMatch(value, @"\d{3}-\d{2}-\d{4}"))
				uniqueSsn = value;
			else
				throw new FormatException("The social security number has an invalid format.");
		}
	}

	public string LastName
	{
		get { return this.lName; }
		set
		{
			if (String.IsNullOrEmpty(value))
				throw new ArgumentException("The last name cannot be null or empty.");
			else
				this.lName = value;
		}
	}

	public bool Equals(Person other)
	{
		if (other == null)
			return false;

		if (this.uniqueSsn == other.uniqueSsn)
			return true;
		else
			return false;
	}

	public override bool Equals(Object obj)
	{
		if (obj == null)
			return false;

		Person personObj = obj as Person;
		if (personObj == null)
			return false;
		else
			return Equals(personObj);
	}

	//алгоритм хеширования изменился использует 
	//manage идентификатор потока, в котором 
	//выполняется метод
	public override int GetHashCode()
	{
		return this.SSN.GetHashCode();
	}

	public static bool operator ==(Person person1, Person person2)
	{
		if (ReferenceEquals(person1, person2)) return true;
		if (ReferenceEquals(person1, null)) return false;

		return person1.Equals(person2);
	}

	public static bool operator !=(Person person1, Person person2)
	{
		if (person1 == null || person2 == null)
			return !Object.Equals(person1, person2);

		return !(person1.Equals(person2));
	}
}