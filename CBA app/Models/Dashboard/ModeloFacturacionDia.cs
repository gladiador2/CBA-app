using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA_app.Models.Dashboard
{
    public  class ModeloFacturacionDia
    {

        public static class Rootobject
        {
            public static Dato[] datos { get; set; }
            public static Resumen resumen { get; set; }
            public static string mensaje { get; set; }
        }

        public  class Resumen
        {
        }

        public  class Dato
        {
            public  int orden { get; set; }
            public  Cotizacion cotizacion { get; set; }
            public  Detalle detalle { get; set; }
            public  float total { get; set; }
        }

        public  class Cotizacion
        {
            public  string fecha { get; set; }
            public  float monto { get; set; }
        }

        public  class Detalle
        {
            public  Contado contado { get; set; }
            public  Credito credito { get; set; }
        }

        public class Contado
        {
            public  float guaranies { get; set; }
            public  float dolares { get; set; }
        }

        public class Credito
        {
            public  float guaranies { get; set; }
            public  float dolares { get; set; }
        }

    }
}
