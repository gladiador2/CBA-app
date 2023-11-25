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
        ModeloStockContenedoresPorFecha.Datos[] StockContenedoresPorFecha = await GetStockContenedoresPorFecha();
        if (StockContenedoresPorFecha != null)
        {
            setStockContenedoresPorFecha(StockContenedoresPorFecha);
            ModeloGIOdelDia.Dato[] GioDelDia = await GetMovimientosGio();
            if (GioDelDia != null)
                setGioPorFecha(GioDelDia);
            ModeloFacturacionDia.Dato[] facturacioDia = await GetfacturacionDia();
            if (facturacioDia != null)
                setfacturacionDia(facturacioDia);
        }
        
        loading.IsVisible = false;
        ContenedorPrincipal.IsVisible = true;
    }


    #region stockContenedoresPorFecha 
    public void setStockContenedoresPorFecha(ModeloStockContenedoresPorFecha.Datos[] dato)
    {
        lblExportacion.Text = SepararMiles( dato[0].exportacion.ToString());
        lblImportacion.Text = SepararMiles( dato[0].importacion.ToString());
        lblVacio.Text = SepararMiles(dato[0].vacio.ToString());
        lbltotal.Text = SepararMiles(dato[0].total.ToString());
    }
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
        lblGif.Text = SepararMiles(dato[0].gif.ToString());
        lblgie.Text = SepararMiles(dato[0].gie.ToString());
        lblgoe.Text = SepararMiles(dato[0].goe.ToString());
        lblgof.Text = SepararMiles(dato[0].gof.ToString());
        lblGIOTotal.Text = SepararMiles(dato[0].total.ToString());
    }
    #endregion movimientosGio

    #region facturacion del dia
    public void setfacturacionDia(ModeloFacturacionDia.Dato[] dato)
    {
        lblCoticacion.Text = "Facturación del día Cotización: "+ SepararMilesYDecimales(dato[0].cotizacion.monto.ToString()); 
        lblContadoGuaranies.Text = SepararMiles(dato[0].detalle.contado.guaranies.ToString());
        lblContadoDolares.Text = SepararMilesYDecimales(dato[0].detalle.contado.dolares.ToString());
        lblCreditoGuaranies.Text = SepararMiles(dato[0].detalle.credito.guaranies.ToString());
        lblContadoDolares.Text = SepararMilesYDecimales(dato[0].detalle.credito.dolares.ToString());
        lblTotalDolares.Text = SepararMilesYDecimales(dato[0].total.ToString());
        
    }
    public async Task<ModeloFacturacionDia.Dato[]> GetfacturacionDia()
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
                hash = "2df6a01e-235c-4111-9d78-a326662a81e2"
            };

            // Serializar el objeto JSON a una cadena
            var json = JsonConvert.SerializeObject(jsonData);

            JsonNode datos = await validarPromesa.requestWithPromise(json, "DashboardLogisticaGetFacturacionPorFecha");
            if (datos != null)
            {
                var respuesta = System.Text.Json.JsonSerializer.Deserialize<ModeloFacturacionDia.Dato[]>(datos.ToString());
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
    public static string SepararMiles(string numero)
    {
        if (string.IsNullOrEmpty(numero))
            return numero;

        int puntoDecimal = numero.IndexOf('.');
        int inicio = (puntoDecimal >= 0) ? puntoDecimal : numero.Length;
        int contador = 0;
        string resultado = "";

        for (int i = inicio - 1; i >= 0; i--)
        {
            resultado = numero[i] + resultado;
            contador++;

            if (contador == 3 && i > 0)
            {
                resultado = "." + resultado;
                contador = 0;
            }
        }

        if (puntoDecimal >= 0)
            resultado += numero.Substring(puntoDecimal);

        return resultado;
    }

    public static string SepararMilesYDecimales(string numero)
    {
        if (string.IsNullOrEmpty(numero))
            return numero;

        decimal valorDecimal;

        if (!decimal.TryParse(numero, out valorDecimal))
            return numero;

        return valorDecimal.ToString("#,##0.00");
    }
}



