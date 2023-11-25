using Microsoft.Maui.Controls;
using CBA_app.Templates;
using System.Text;

namespace CBA_app.Views.ControlOperaciones;

public partial class ControlOperacionesPage : ContentPage
{
    public ControlOperacionesPage()
    {
        
        InitializeComponent();
  
    }


    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        // L�gica para manejar la pulsaci�n del bot�n de b�squeda
        SetupToolbarItems();
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        // L�gica para manejar cambios en el texto de b�squeda
    }

    protected override void OnAppearing()
    {
        // Configurar los elementos de la barra de herramientas al aparecer la p�gina
        SetupToolbarItems();
    }

    private void SetupToolbarItems()
    {
        // Limpiar la barra de herramientas
        ToolbarItems.Clear();

        // Si el SearchHandler est� cerrado, agregar el bot�n "Buscar"
        var NuevoItem = new ToolbarItem
        {
            Text = "Agregar nuevo registro",
            IconImageSource = "nuevo_blanco.svg",
            
            Command = new Command(() => NuevoHandler())

        };

        ToolbarItems.Add(NuevoItem);

    }
    private async void NuevoHandler()
    {
        
        SetupToolbarItems();
        await Navigation.PushAsync(new ControlOperacionesPage());
        //await Navigation.PopAsync();
        // Aqu� puedes agregar cualquier l�gica adicional que desees ejecutar cuando se cierra el SearchHandler
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new FiltrosPage());
        //await Shell.Current.GoToAsync("app://cba_app/filtros");
        
    }

    private async void btnNuevo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditarPage());
    }

    private void btnBuscar_Clicked(object sender, EventArgs e)
    {
        lblTitulo.IsVisible = false;
        btnAtras.IsVisible= false;
        btnBuscar.IsVisible= false;
        FrameBtnFiltros.IsVisible= true;
        FrameSeach.IsVisible= true;
        btnCerrarSearch.IsVisible= true;
        searchOperaciones.Focus();
    }

    private void btnCerrarSearch_Clicked(object sender, EventArgs e)
    {
        lblTitulo.IsVisible = true;
        btnAtras.IsVisible = true;
        btnBuscar.IsVisible = true;
        FrameBtnFiltros.IsVisible = false;
        FrameSeach.IsVisible = false;
        btnCerrarSearch.IsVisible = false;
    }
}
