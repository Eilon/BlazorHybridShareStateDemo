namespace BlazorHybridShareStateDemo;

public partial class App : Application
{
	public App(MySharedState mySharedState)
	{
		InitializeComponent();

		MainPage = new MainPage(mySharedState);
	}
}
