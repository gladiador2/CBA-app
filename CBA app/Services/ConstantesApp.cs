using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA_app.Services
{
    public static class ConstantesApp
    {
        public const string URL_API = "https://cbaflow.psf.com.py/psfback_webservices/rest.asmx/";
        public const int TIEMPO_ESPERA = 50000;
        public const string RUTA_LOGS = "logs/";
        public const string FORMATO_FECHA = "yyyy-MM-dd HH:mm:ss";

        public static class Hashes
        {
            public const string EntidadesLogin = "a81e6b49-b6b8-4f8d-8b2b-1dce7611196d";

            // Articulos
            public const string ArticulosFamiliasBuscar = "bf9d5089-dfef-413f-92b4-3f0e52de8011";
            public const string ArticulosFamiliasGuardar = "b9880ced-fcca-4c3f-befa-2427d1eb3c55";
            public const string ArticulosFamiliasInactivar = "37f62c07-bb97-4050-8d8e-5cfedf0255e0";
            public const string ArticulosGruposBuscar = "d79ac858-d175-486a-a874-64b27df5dafe";
            public const string ArticulosGruposGuardar = "b85cbfcc-c0d4-4b7c-9ad3-759954d6930d";
            public const string ArticulosGruposInactivar = "7f936e7e-c647-4f1d-87e1-05f267eb1770";
            public const string ArticulosSubgruposBuscar = "9c8955bc-cb31-45ec-8b7a-2b713c8eb3ab";
            public const string ArticulosSubgruposGuardar = "7af9f93e-bd1f-4055-a52b-1b05a4974817";
            public const string ArticulosSubgruposInactivar = "2873fda3-6100-4cc8-a8d1-f694f88c1687";

            // Logistica
            public const string LogisticaGetDepositosPorUsuario = "90ff5c1c-7cf4-4426-a1ef-1def52f778b9";
            public const string LogisticaGetContenedoresPorDeposito = "9aa73723-dad2-4761-8ea4-ebb0e287ea98";
            public const string LogisticaCambiarEstadoContenedor = "e500ba76-c048-4dc4-9176-01b06bf5df78";
            public const string Logisticagetlineas = "a21337f5-7118-4b3f-84ce-bcf5ef42a593";
            public const string LogisticaGetLineas = "0b82af24-c0b1-4b29-848f-14d5ef0e6729";
            public const string LogisticaGetPuertos = "507b11c3-99ab-4e74-a04e-7ffa102a1493";
            public const string LogisticaEliminarMovimiento = "69ba73bb-6f4f-4ebd-80ac-0b1608c0d422";
            public const string LogisticaGuardarMovimiento = "75b6cebb-afe8-4af2-8792-c2d4520d239c";
            public const string LogisticaGetMovimientoPuertaPorId = "118801dd-f5f5-4583-98cf-e2ff48b5a272";

            // Entidades
            public const string entidadesPersonasBuscar = "2b1b5f1c-eaf1-4e4a-bf43-8ddd41ee0028";

            // Datos Aduanas
            public const string LogisticaDatosAduanas = "59f84d61-8381-4346-ae40-94acdb52c9a6";

            // Datos PE por Linea
            public const string LogisticaGetLineasPorUsuario = "f927f4f1-2b2d-461f-a78c-62ba7791a34e";
            public const string LogisticaGetPreembarquesSinIntercambioPorLinea = "32d7d995-54c3-473a-b063-f1d2170d0e63";
            public const string LogisticaGetPreembarquesInformePorLinea = "b9c2ee24-b9ff-403a-bf1a-48cd86823188";
        }

        public static class SiNoDefiniciones
        {
            public const string SI = "S";
            public const string NO = "N";
        }

        public static class EstructuraJSON
        {
            public static class Nodos
            {
                public const string mensaje = "mensaje";
                public const string error = "error";
                public const string codigo = "codigo";
                public const string datos = "datos";
                
            }
        }
        public static class SiNoCombo
        {
            public static readonly List<object> Values = new List<object>
        {
            new { value = SiNoDefiniciones.SI, label = "Sí" },
            new { value = SiNoDefiniciones.NO, label = "No" }
        };
        }

        public static class LogisticaPredioEstadoReparacion
        {
            public static readonly List<object> Values = new List<object>
        {
            new { value = "N/A", label = "N/A" },
            new { value = "PENDIENTE", label = "Pendiente" },
            new { value = "EN_REPARACION", label = "En reparación" },
            new { value = "REPARADO", label = "Reparado" }
        };
        }

        public static class LogisticaClaseContenedor
        {
            public static readonly List<object> Values = new List<object>
        {
            new { value = "A", label = "A" },
            new { value = "B", label = "B" },
            new { value = "C", label = "C" },
            new { value = "D", label = "D" }
        };
        }

        public const int LengthOfTextSearch = 3;

        public static class ExcepcionesRestError
        {
            public const int NO_AUTENTICADO = 401;
            public const int TOKEN_EXPIRADO = 440;
            public const int TOKEN_REQUERIDO = 460;
            public const int TOKEN_INVALIDO = 461;
            public const int ERROR_CLIENTE = 462;
        }
    }

}
