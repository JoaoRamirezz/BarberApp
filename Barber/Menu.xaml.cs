namespace Barber;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void OnAgendaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Marcar");
    }

    private async void OnCortesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Cortes");
    }

    void GridArea_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
    }
}
