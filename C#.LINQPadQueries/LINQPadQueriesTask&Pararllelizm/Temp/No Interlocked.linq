<Query Kind="Program" />

static int value = 0;

static void Inc()
{
	for (int i = 0; i < 10000000; i++)
	{
		value++;
	}
}
 
static void Dec()
{
	for (int i = 0; i < 10000000; i++)
	{
		value--;
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