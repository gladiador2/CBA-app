using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA_app.Models.Dashboard
{
    public class ModeloGIOdelDia
    {

        public static class Rootobject
        {
            public static Dato[] datos { get; set; }
            public static Resumen resumen { get; set; }
            public static string mensaje { get; set; }
        }

        public class Resumen
        {
        }

        public class Dato
        {
            public int orden { get; set; }
            public float gof { get; set; }
            public float goe { get; set; }
            public float gif { get; set; }
            public float gie { get; set; }
            public float total { get; set; }
        }

    }
}
