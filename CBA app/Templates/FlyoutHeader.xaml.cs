namespace CBA_app.Templates;

public partial class FlyoutHeader : ContentView
{
	public FlyoutHeader()
	{
		InitializeComponent();

        if (App.UserDetails != null)
        {
            lblUserName.Text = "  " + App.UserDetails.nombre +" "+ App.UserDetails.apellido + " 🟢";
           
        }
    }
}