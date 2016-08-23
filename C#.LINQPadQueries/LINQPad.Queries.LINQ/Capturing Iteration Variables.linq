<Query Kind="Statements" />

// When you capture the iteration variable in a for-loop, C# treats that variable as though it was
// declared outside the loop. This means that the same variable is captured in each iteration:
{
	Action[] actions = new Action[3];

	for (int i = 0; i < 3; i++)
		actions [i] = () => Console.Write (i);
	
	foreach (Action a in actions) a();     // 333 (instead of 123)
}
Console.WriteLine();
// Each closure captures the same variable, i. When the delegates are later invoked, each delegate sees i’s value
// at time of invocation—which is 3. We can illustrate this better by expanding the for loop as follows:
{
	Action[] actions = new Action[3];
	int i = 0;
	actions[0] = () => Console.Write (i);
	i = 1;
	actions[1] = () => Console.Write (i);
	i = 2;
	actions[2] = () => Console.Write (i);
	i = 3;
	foreach (Action a in actions) a();    // 333
}