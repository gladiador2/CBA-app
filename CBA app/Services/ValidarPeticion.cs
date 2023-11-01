using CBA_app.ViewModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using CBA_app.Services;
using CBA_app.Models;

using CBA_app.Views.Login;

namespace CBA_app.Services
{
     
    public class ValidarPeticion
    {
        public async Task<JsonNode> requestWithPromise(string jsonData, string urlApi) 
        {
            try
            {
                

                

                // Crear el contenido de la solicitud con el tipo de datos adecuado
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var client = new HttpClient();
               
                var responseTask = client.PostAsync(ConstantesApp.URL_API + urlApi, content);
                if (await Task.WhenAny(responseTask, Task.Delay(ConstantesApp.TIEMPO_ESPERA)) == responseTask)
                {
                    var response = await responseTask;
                   // Verificar si la respuesta fue exitosa
                    if (response.IsSuccessStatusCode)
                    {

                        var responseBody = await response.Content.ReadAsStringAsync();
                        //doc Json
                        using JsonDocument doc = JsonDocument.Parse(responseBody);

                        //NOdo raiz
                        JsonNode nodos = JsonNode.Parse(responseBody);
                        // Obtener la raíz del documento JSON
                        JsonElement root = doc.RootElement;

                        //mensaje de error
                        string mensaje = string.Empty;
                        if (doc.RootElement.TryGetProperty(ConstantesApp.EstructuraJSON.Nodos.mensaje, out _))
                            mensaje = root.GetProperty(ConstantesApp.EstructuraJSON.Nodos.mensaje).GetString();
                        //Existe error
                        string error = string.Empty;
                        if (doc.RootElement.TryGetProperty(ConstantesApp.EstructuraJSON.Nodos.error, out _))
                            error = root.GetProperty(ConstantesApp.EstructuraJSON.Nodos.error).GetString();
                        Int64 codigo = 0;
                        if (doc.RootElement.TryGetProperty(ConstantesApp.EstructuraJSON.Nodos.codigo, out _))
                            codigo = root.GetProperty(ConstantesApp.EstructuraJSON.Nodos.codigo).GetInt64();

                        if (doc.RootElement.TryGetProperty(ConstantesApp.EstructuraJSON.Nodos.datos, out _))
                        {
                            JsonNode datos = nodos[ConstantesApp.EstructuraJSON.Nodos.datos];
                            return datos;
                        }
                        else
                        {
                            if (mensaje != string.Empty && error == Definiciones.SiNo.No)
                            {
                                await App.Current.MainPage.DisplayAlert(string.Empty, mensaje, "Aceptar");
                                return null;
                            }
                            if (mensaje != string.Empty && error == Definiciones.SiNo.Si)
                            {
                                await App.Current.MainPage.DisplayAlert("Error", mensaje, "Aceptar");
                                //440 session finalizada
                                //461 session invalida
                                if (codigo == ConstantesApp.ExcepcionesRestError.NO_AUTENTICADO
                                    || codigo == ConstantesApp.ExcepcionesRestError.TOKEN_INVALIDO
                                    || codigo == ConstantesApp.ExcepcionesRestError.TOKEN_EXPIRADO
                                    || codigo == ConstantesApp.ExcepcionesRestError.TOKEN_REQUERIDO)
                                {
                                    if (Preferences.ContainsKey(nameof(App.UserDetails)))
                                    {
                                        Preferences.Remove(nameof(App.UserDetails));
                                    }
                                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                                }
                                return null;
                            }
                            return null;
                        }
                    }
                    else
                    {
                        // Mostrar mensaje de error en un DisplayAlert
                        await App.Current.MainPage.DisplayAlert("Error", "Ocurrió un error al obtener los datos.", "Aceptar");
                        return null;
                    }
                }
                else
                {
                    
                    await App.Current.MainPage.DisplayAlert("Advertencia", "Se ha superado el tiempo de espera. ¿Desea seguir esperando?", "Sí", "No");

                
                    return null;
                }

            }
            catch (Exception ex)
            {
                
                await App.Current.MainPage.DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "Aceptar");
                return null;
            }
        }
    }
}
