namespace TallerUsoLayouts;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private async void FlexLayoutButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FlexLayout());
    }
}