<Query Kind="Statements" />


{
	Action[] actions = new Action[3];

	for (int i = 0; i < 3; i++)
		actions [i] = () => Console.Write (i);
	
	foreach (Action a in actions) a(); 
}
"".Dump();
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