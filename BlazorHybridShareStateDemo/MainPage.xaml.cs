namespace BlazorHybridShareStateDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;

		UpdateLabelText();
	}

    private void UpdateLabelText()
    {
        LabelText = $"Count is: {currentCount++}";
        OnPropertyChanged(nameof(LabelText));
    }

    private int currentCount;
	public string LabelText { get; set; }

	private void Button_Clicked(object sender, EventArgs e)
    {
        UpdateLabelText();
    }
}
