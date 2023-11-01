
namespace CBA_app.Models
{
    public  class ModeloSession
    {


        public  class Root
        {
            public Usuario usuario { get; set; }
            public string mensaje { get; set; }
            public string token { get; set; }
        }
        
        public class Usuario
        {
            public float id { get; set; }
            public Sucursal sucursal { get; set; }
            public string nombre { get; set; }
            public string[] roles { get; set; }
            public DateTime fecha_caducidad_pass { get; set; }
            public DateTime fecha_ultimo_login { get; set; }
            public string email { get; set; }
            public string usuario { get; set; }
            public string apellido { get; set; }
        }

        public class Sucursal
        {
            public string nombre { get; set; }
            public string abreviatura { get; set; }
            public float id { get; set; }
        }
        


    }
}
