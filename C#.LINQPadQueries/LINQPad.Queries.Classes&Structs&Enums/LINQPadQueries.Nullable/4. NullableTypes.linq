<Query Kind="Program" />

void Main()
{
    Person turing = new Person("Alan Turing",
                            new DateTime(1912, 6, 23),
                            new DateTime(1954, 6, 7));
    Person knuth = new Person("Donald Knuth",
                            new DateTime(1938, 1, 10),
                            null);
}

class Person
{
    DateTime birth;
    DateTime? death;
    string name;

    public TimeSpan Age
    {
        get
        {
            if (death == null)
            {
                return DateTime.Now - birth;
            }
            else
            {
                return death.Value - birth;
            }
        }
    }

    public Person(string name,
                  DateTime birth,
                  DateTime? death)
    {
        this.birth = birth;
        this.death = death;
        this.name = name;
    }
}