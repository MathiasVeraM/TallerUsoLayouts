namespace TallerUsoLayouts;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
    }

    private async void img1_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void img2_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void img3_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}