
namespace CBA_app.Models.Dashboard
{
   public class ModeloStockContenedoresPorFecha
    {

        public static class Rootobject
        {
            public static Datos[] datos { get; set; }
            public static Resumen resumen { get; set; }
            public static string mensaje { get; set; }
        }

        public class Resumen
        {
        }

        public class Datos
        {
            public int orden { get; set; }
            public float importacion { get; set; }
            public float exportacion { get; set; }
            public float vacio { get; set; }
            public float total { get; set; }
        }

    }
}
