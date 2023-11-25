// Importación de los espacios de nombres necesarios
using CBA_app.Views.Dashboard;
using CBA_app.Views.ControlOperaciones;
using CBA_app.Views.Login;
using CBA_app.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declaración del espacio de nombres y clase para AppConstant
namespace CBA_app.Models
{
    public class AppConstant
    {
        // Método asíncrono para agregar detalles a los menús desplegables (flyout)
        public async static Task AddFlyoutMenusDetails()
        {
            // Estableciendo el FlyoutHeader del actual AppShell como una nueva instancia de FlyoutHeader
            AppShell.Current.FlyoutHeader = new FlyoutHeader();

            // Recuperando información sobre el panel de control del administrador desde los elementos (items) de AppShell
            var adminDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(DashboardPage)).FirstOrDefault();

            // Si se encuentra información del panel de control del administrador, eliminarlo de los elementos (items) de AppShell
            if (adminDashboardInfo != null)
                AppShell.Current.Items.Remove(adminDashboardInfo);

            // Creando un nuevo FlyoutItem para el panel de control
            var flyoutItem = new FlyoutItem()
            {
                Title = "Dashboard",
                Route = nameof(DashboardPage),
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                Items =
                {
                    // Agregando elementos ShellContent para el panel de control y el control de operaciones
                    new ShellContent
                    {
                        Icon = Icons.Dashboard,
                        Title = "Dashboard",
                        ContentTemplate = new DataTemplate(typeof(DashboardPage)),
                    },
                    new ShellContent
                    {
                        Icon = Icons.AboutUs,
                        Title = "Control de operaciones",
                        ContentTemplate = new DataTemplate(typeof(ControlOperacionesPage)),
                    }
                }
            };

            // Verificando si el flyoutItem aún no está en los elementos (items) de AppShell
            if (!AppShell.Current.Items.Contains(flyoutItem))
            {
                // Agregando el flyoutItem a los elementos (items) de AppShell
                AppShell.Current.Items.Add(flyoutItem);

                // Manejando la navegación según la plataforma
                if (DeviceInfo.Platform == DevicePlatform.WinUI)
                {
                    // Para la plataforma WinUI, utilizar Dispatcher para navegar a DashboardPage
                    AppShell.Current.Dispatcher.Dispatch(async () =>
                    {
                        await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
                    });
                }
                else
                {
                    // Para otras plataformas, navegar directamente a DashboardPage
                    await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
                }
            }
        }
    }
}
