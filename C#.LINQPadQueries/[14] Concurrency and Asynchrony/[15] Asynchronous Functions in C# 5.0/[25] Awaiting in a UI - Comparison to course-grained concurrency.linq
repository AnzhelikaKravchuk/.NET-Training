<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\UIAutomationProvider.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationUI.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\System.Printing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\ReachFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\UIAutomationTypes.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
	new TestUI().ShowDialog();
}

class TestUI : Window		// Notice how the window becomes unresponsive while working
{
	Button button = new Button { Content = "Go" };
	TextBlock results = new TextBlock();
		
	public TestUI()
	{
		var panel = new StackPanel();
		panel.Children.Add (button);
		panel.Children.Add (results);
		Content = panel;
		button.Click += (sender, args) =>
		{
			button.IsEnabled = false;
			Task.Run (() => Go());
		};
	}
		
	void Go()
	{
		// Notice the race condition (run it and look at what's wrong with the results):
		for (int i = 1; i < 5; i++)
		{
			int result = GetPrimesCount (i * 1000000, 1000000);
			Dispatcher.BeginInvoke (new Action (() =>
				results.Text += result + " primes between " + (i*1000000) + " and " + ((i+1)*1000000-1) + Environment.NewLine));
		}
		Dispatcher.BeginInvoke (new Action (() => button.IsEnabled = true));
	}
		
	int GetPrimesCount (int start, int count)
	{
		return
			ParallelEnumerable.Range (start, count).Count (n => 
				Enumerable.Range (2, (int) Math.Sqrt(n)-1).All (i => n % i > 0));
	}
}