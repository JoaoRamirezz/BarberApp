namespace Barber;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("Menu", typeof(Menu));
        Routing.RegisterRoute("Login", typeof(Login));
        Routing.RegisterRoute("Cortes", typeof(Cortes));
        Routing.RegisterRoute("Marcar", typeof(Marcar));
    }
}

