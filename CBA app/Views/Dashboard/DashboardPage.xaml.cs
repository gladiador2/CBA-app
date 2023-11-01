using CBA_app.ViewModels.Dashboard;
using CBA_app.ViewModels.Startup;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;

using CBA_app.Models.Dashboard;
using CBA_app.Views.Dashboard;
using CBA_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using CBA_app.Services;
using CBA_app.Models;
using System.Runtime.CompilerServices;
using Microsoft.Toolkit.Mvvm.DependencyInjection;


namespace CBA_app.Views.Dashboard;

public partial class DashboardPage : ContentPage
{

    
    ValidarPeticion validarPromesa = new ValidarPeticion();


    public DashboardPage(DashboardPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        loading.IsVisible = true;
        ContenedorPrincipal.IsVisible = false;
        var StockContenedoresPorFecha = await GetStockContenedoresPorFecha();
        if (StockContenedoresPorFecha != null)
        {
            setStockContenedoresPorFecha(StockContenedoresPorFecha);
            var GioDelDia = await GetMovimientosGio();
            if (GioDelDia != null)
                setGioPorFecha(GioDelDia);
        }
        
        loading.IsVisible = false;
        ContenedorPrincipal.IsVisible = true;
    }
   
    public void setStockContenedoresPorFecha(ModeloStockContenedoresPorFecha.Datos[] dato)
    {
        lblExportacion.Text = dato[0].exportacion.ToString();
        lblImportacion.Text = dato[0].importacion.ToString();
        lblVacio.Text = dato[0].vacio.ToString();
        lbltotal.Text = dato[0].total.ToString();
    }
    #region stockContenedoresPorFecha 
    public async Task<ModeloStockContenedoresPorFecha.Datos[]> GetStockContenedoresPorFecha()
    {
        try
        {
            var jsonData = new
            {
                sesion = new
                {
                    usuario_id = App.UserDetails.id,
                    token = App.UserDetails.token
                },
                fecha = DateTime.Now,
                hash = "877b878a-3263-4c51-8a31-105246775932"
            };

            // Serializar el objeto JSON a una cadena
            var json = JsonConvert.SerializeObject(jsonData);
            
            JsonNode datos = await validarPromesa.requestWithPromise(json, "DashboardLogisticaGetStockContenedoresPorFecha");
            if (datos != null)
            {
                var respuesta = System.Text.Json.JsonSerializer.Deserialize<ModeloStockContenedoresPorFecha.Datos[]>(datos.ToString());
                return respuesta;
            }
            return null;
            
           
        }
        catch (Exception ex)
        {
            // Mostrar mensaje de error en un DisplayAlert
            await App.Current.MainPage.DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "Aceptar");
            return null;
        }
    }
    #endregion stockContenedoresPorFecha
    #region movimientosGio
    public async Task<ModeloGIOdelDia.Dato[]> GetMovimientosGio()

    {
        try
        {
            var jsonData = new
            {
                sesion = new
                {
                    usuario_id = App.UserDetails.id,
                    token = App.UserDetails.token
                },
                fecha_hasta = DateTime.Now,
                fecha_desde = DateTime.Now,
                hash = "dceaff6e-9f7f-433d-bdd8-51c5a283b7fc"
            };

            // Serializar el objeto JSON a una cadena
            var json = JsonConvert.SerializeObject(jsonData);
            JsonNode datos =  await validarPromesa.requestWithPromise(json, "DashboardLogisticaGetMovimientosGIOPorFecha");
            if (datos != null)
            {
                var respuesta = System.Text.Json.JsonSerializer.Deserialize<ModeloGIOdelDia.Dato[]>(datos.ToString());
                return respuesta;
            }
            return null;
           
        }
        catch (Exception ex)
        {
            // Mostrar mensaje de error en un DisplayAlert
            await App.Current.MainPage.DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "Aceptar");
            return null;
        }
    }
    public void setGioPorFecha(ModeloGIOdelDia.Dato[] dato)
    {
        lblGif.Text = dato[0].gif.ToString();
        lblgie.Text = dato[0].gie.ToString();
        lblgoe.Text = dato[0].goe.ToString();
        lblgof.Text = dato[0].gof.ToString();
        lblGIOTotal.Text = dato[0].total.ToString();
    }
    #endregion movimientosGio
}