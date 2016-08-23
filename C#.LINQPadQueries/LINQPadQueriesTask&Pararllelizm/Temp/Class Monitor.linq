<Query Kind="Program" />

static int value = 0;

static object syncObject = new object();

static void Inc()
{
	for (int i = 0; i < 1000000; i++)
	{
		Monitor.Enter(syncObject);
		value = value + 1;
		Monitor.Exit(syncObject);
	}
}

static void Dec()
{
	for (int i = 0; i < 1000000; i++)
	{
		Monitor.Enter(syncObject);
		value = value - 1;
		Monitor.Exit(syncObject);
	}
}

static void Main()
{
	Thread inc = new Thread(new ThreadStart(Inc));
	Thread dec = new Thread(new ThreadStart(Dec));
	inc.Start();
	dec.Start();
	inc.Join();
	dec.Join();
	value.Dump("value = ");
}