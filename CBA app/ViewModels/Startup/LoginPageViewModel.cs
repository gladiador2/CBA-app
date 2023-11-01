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


namespace CBA_app.ViewModels.Startup

{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        

        private string urlApi = "https://cbaflow.psf.com.py/psfback_webservices/rest.asmx/EntidadesLogin";

       
        
        public async Task<ModeloSession> Loguin()
        {
            var jsonData = new JsonData
            {
                usuario = Email,
                contrasenha = Password,
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

                    var sesion = System.Text.Json.JsonSerializer.Deserialize<ModeloSession>(nodos.ToString());
                    return sesion;
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
}
