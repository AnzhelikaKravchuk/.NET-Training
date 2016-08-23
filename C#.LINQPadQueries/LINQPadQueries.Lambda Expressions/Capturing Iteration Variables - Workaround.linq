<Query Kind="Statements" />

Action[] actions = new Action[3];

for (int i = 0; i < 3; i++)
{
	int loopScopedi = i;
	actions [i] = () => Console.WriteLine (loopScopedi);
}

foreach (Action a in actions) a();