namespace BlazorHybridShareStateDemo;

public partial class MainPage : ContentPage
{
	public MainPage(MySharedState mySharedState)
	{
		InitializeComponent();
		BindingContext = this;

        this.mySharedState = mySharedState;
        this.mySharedState.CountChanged += MySharedState_CountChanged;
        
        UpdateLabelText();
    }

    private void MySharedState_CountChanged(object sender, EventArgs e)
    {
        UpdateLabelText();
    }

    private void UpdateLabelText()
    {
        LabelText = $"Count is: {mySharedState.CurrentCount}";
        OnPropertyChanged(nameof(LabelText));
    }

    private readonly MySharedState mySharedState;

    public string LabelText { get; set; }

	private void Button_Clicked(object sender, EventArgs e)
    {
        mySharedState.IncrementCount();
        UpdateLabelText();
    }
}
