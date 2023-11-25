namespace CBA_app.Views.ControlOperaciones;

public partial class FiltrosPage : ContentPage
{
	public FiltrosPage()
	{
		InitializeComponent();
	}

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnAceptar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {

    }

    private void StepeerRegistros_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (StepeerRegistros != null)
        {
            txtCanRegistros.Text = StepeerRegistros.Value.ToString();
        }
    }
}