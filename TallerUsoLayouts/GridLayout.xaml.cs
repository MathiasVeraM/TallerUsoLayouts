namespace TallerUsoLayouts;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private async void StackLayout_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new StackLayout());
    }
}