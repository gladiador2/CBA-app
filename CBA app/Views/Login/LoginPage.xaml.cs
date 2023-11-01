using CBA_app.ViewModels.Startup;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;

using CBA_app.Models;
using CBA_app.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using CBA_app.Services;

namespace CBA_app.Views.Login;

public partial class LoginPage : ContentPage
{
    ModeloSession mSession = new ModeloSession();
    //ModeloUsuario userDetails = new ModeloUsuario();
    string token;
    private string urlApi = "https://cbaflow.psf.com.py/psfback_webservices/rest.asmx/EntidadesLogin";
    public LoginPage(LoginPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;


    }
    

    #region Commands
    private void OnIngresar(object sender, EventArgs e)
    {
        Login();
    }
    
    public async void Login()
    {
        if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
        {
            

            
            var session = await Loguin();
            if (session != null)
            {
                


                // calling api 


               
                await AppConstant.AddFlyoutMenusDetails();
            }
            else
            {
                
                await DisplayAlert("Login", "No puede iniciar session", "ok");
            }


        }


    }
    #endregion

    public async Task<ModeloSession> Loguin()
    {
        var jsonData = new JsonData
        {
            usuario = txtUsuario.Text,
            contrasenha = txtContraseña.Text,
            hash = "a81e6b49-b6b8-4f8d-8b2b-1dce7611196d",
            sucursal = "-1"
        };

        // Serializar el objeto JSON a una cadena
        var json = JsonConvert.SerializeObject(jsonData);

        // Crear el contenido de la solicitud con el tipo de datos adecuado
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var client = new HttpClient();
        var response = await client.PostAsync(urlApi, content);
        // Verificar si la respuesta fue exitosa
        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            JsonNode nodos = JsonNode.Parse(responseBody);

            if (nodos["usuario"] != null)
            {
             
                JsonNode usuario = nodos["usuario"];
               // Ousuario = System.Text.Json.JsonSerializer.Deserialize<Ousuario>(usuario.ToString());
                mSession = System.Text.Json.JsonSerializer.Deserialize<ModeloSession>(nodos.ToString());
               var userDetails = System.Text.Json.JsonSerializer.Deserialize<ModeloUsuario>(usuario.ToString());
                // Crear un JsonDocument a partir de la cadena JSON
                using JsonDocument doc = JsonDocument.Parse(responseBody);

                // Obtener la raíz del documento JSON
                JsonElement root = doc.RootElement;

                // Obtener el valor del token como una cadena
                userDetails.token = root.GetProperty("token").GetString();
                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                   
                }

                string userDetailStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails
                    ), userDetailStr);
                App.UserDetails = userDetails;
                return mSession;
            }
            else
            {
                return null;
            }
        }
        else
        {

            return null;
        }

    }
    public class JsonData
    {
        public string usuario { get; set; }
        public string contrasenha { get; set; }
        public string hash { get; set; }
        public string sucursal { get; set; }
    }
}