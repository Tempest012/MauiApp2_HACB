namespace MauiApp2_HACB;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Dejesar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}