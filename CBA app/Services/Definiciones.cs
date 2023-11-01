using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA_app.Services
{
    public abstract class Definiciones
    {
        public const decimal IdNull = Definiciones.Error.Valor.EnteroPositivo;

        #region Variables de sistema
        public abstract class VariablesDeSistema
        {
            /// <summary>
            /// Cantidad de dias de antiguedad que puede tener una cotizacion para ser utilizada. Tipo decimal
            /// </summary>
            public const decimal CotizacionDiasMaximoAntiguedad = 1;

            /// <summary>
            /// Estrategia de comision utilizada para vendedores en las notas de pedido de clientes. Clase Definiciones.TiposComision
            /// </summary>
            public const decimal EstrategiaComision = 2;

            /// <summary>
            /// Cantidad de bytes maxima que puede tener un archivo chico. Tipo decimal
            /// </summary>
            public const decimal TamanhoArchivoChico = 3;

            /// <summary>
            /// Cantidad de bytes maxima que puede tener un archivo medianos. Tipo decimal
            /// </summary>
            public const decimal TamanhoArchivoMediano = 4;

            /// <summary>
            /// Cantidad de bytes maxima que puede tener un archivo grande. Tipo decimal
            /// </summary>
            public const decimal TamanhoArchivoGrande = 5;

            /// <summary>
            /// Es o no necesaria la aprobacion del ingreso para articulos. Clase Definiciones.SiNo
            /// </summary>
            public const decimal AprobacionIngresoArticulos = 6;

            /// <summary>
            /// Es o no necesaria la aprobacion del ingreso para personas. Clase Definiciones.SiNo
            /// </summary>
            public const decimal AprobacionIngresoPersonas = 7;

            /// <summary>
            /// Es o no necesaria la aprobacion del ingreso para funcionarios. Clase Definiciones.SiNo
            /// </summary>
            public const decimal AprobacionIngresoFuncionarios = 8;

            /// <summary>
            /// Monto en dolares a partir del cual una Orden de Pago debe respaldar al caso de Cambio de Divisa
            /// </summary>
            public const decimal CambiosDivisaMaximoDolaresSinOrdenPago = 9;

            /// <summary>
            /// Monto maximo en dolares que puede ser pagado en un caso de Egreso Vario de Caja
            /// </summary>
            public const decimal EgresoVarioMaximoDolaresEgreso = 10;

            /// <summary>
            /// Abreviatura de la sucursal principal de la entidad
            /// </summary>
            public const decimal AbreviaturaSucursalPrincipal = 11;
            /// <summary>
            /// Monto del salario minimo fijado por el pais de la entidad
            /// </summary>
            public const decimal SalarioMinimoMonto = 12;
            /// <summary>
            /// Moneda en que se expresa el salario
            /// </summary>
            public const decimal SalarioMinimoMoneda = 13;

            /// <summary>
            /// Contabilidad. Cantidad de dias de margen sobre la fecha fin del periodo para poder agregar movimientos.
            /// </summary>
            public const decimal CTBAsientosCrearDiasLuegoFechaFinalPeriodo = 14;

            /// <summary>
            /// Contabilidad. Margen en dias durante el cual un asiento puede ser creado en un periodo aun no iniciado
            /// </summary>
            public const decimal CTBAsientosCrearDiasAntesFechaInicioPeriodo = 15;

            /// <summary>
            /// Porcentaje de aportes como IPS que realiza la empresa
            /// </summary>
            public const decimal FuncionariosLiquidacionesAportesEmpresaPorcentaje = 16;

            /// <summary>
            /// Porcentaje del IVA que se retiene a los proveedores
            /// </summary>
            public const decimal CondicionPagoContado = 17;
            /// La condicion de pago por defecto a ser utilizada en la factura tipo Credito
            /// </summary>
            /// 
            public const decimal CondicionPagoCredito = 18;
            /// Permitir la impresion de una FC Cliente solo si existe un caso de reparto que la vincule
            /// </summary>
            public const decimal FCClienteImpresionDependienteReparto = 19;

            /// <summary>
            /// Aumento maximo porcentual de la linea de credito, entre 0 y 100
            /// </summary>
            public const decimal AumentoLineaCredito = 20;

            /// <summary>
            /// Relacion minima entre precio y costo para que se considere rentable
            /// </summary>
            public const decimal MargenRentabilidad = 21;

            /// <summary>
            /// S/N segun el job mensual deba o no anular las notas de pedido no aprobadas a fin de mes
            /// </summary>
            public const decimal AnularNotasPedidoAlCambiarMes = 22;

            /// <summary>
            /// Cantidad maxima de dias que una NC Personas puede estar en estado pendiente
            /// </summary>
            public const decimal NCPersonasDiasPendiente = 23;

            /// <summary>
            /// Indica el tiempo máximo que un vendedor debe estar sin levantar un pedido de un cliente que le fue asignado
            /// </summary>
            public const decimal VendedorDiasSinPedidoCliente = 24;

            /// <summary>
            /// Porcentaje máximo (0 a 100) en que puede diferir la cotización cargada por el usuario de la definida en el sistema
            /// </summary>
            public const decimal CotizacionPorcentajeMaximoPuedeDiferir = 25;

            /// <summary>
            /// Normal = 0.  ParaBajo=1 (floor ). ParaArriba = 2 (ceil ).
            /// </summary>
            public const decimal TipoDeRedondeo = 26;
            /// <summary>
            /// Fifo = 0.  Ponderado=1 
            /// </summary>
            public const decimal TipoCosto = 27;
            /// <summary>
            /// Por Factura de Proveedor = 0  Por Flujo de Ingreso de Stock=1 
            /// </summary>
            public const decimal AfectarStock = 28;

            /// <summary>
            /// Porcentaje de influencia de la calidad de la venta por objetivo
            /// </summary>
            public const decimal ObjetivosPorcentajeInfluenciaCalidad = 29;
            /// <summary>
            /// Porcentaje de influencia de la cantidad de la venta por objetivo
            /// </summary>
            public const decimal ObjetivosPorcentajeInfluenciaCantidad = 30;

            /// <summary>
            /// El precio es modificado por: 0 = modulo precios; 1 = flujo Listas Precio Modificar; 2 = WebService
            /// </summary>
            public const decimal EstrategiaPrecio = 31;

            /// <summary>
            /// Moneda en la cual se expresa el valor de la variable RetencionProveedoresDesdeMonto
            /// </summary>
            public const decimal RetencionProveedoresMonedaMonto = 32;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas debido a un movimiento de otro flujo como Descuento de Doc. o Credito
            /// </summary>
            public const decimal FCClientePorGananciaOtroFlujoArticulo = 33;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas como comprobante de pago capital
            /// </summary>
            public const decimal FCClienteComoComprobantePagoCapitalArticulo = 34;

            /// <summary>
            /// Indica el ID de la bonificación familiar
            /// </summary>
            public const decimal RRHHBonificacionFamiliar = 35;

            /// <summary>
            /// Id del Cliente actual
            /// </summary>
            public const decimal Cliente = 36;

            /// <summary>
            /// S/N segun el job mensual deba o no anular los creditos de personas en borrador o pendiente a fin de mes
            /// </summary>
            public const decimal AnularCreditosPersonasAlCambiarMes = 37;

            /// <summary>
            /// Contrasenha para encriptar
            /// </summary>
            public const decimal ContrasenhaEncriptacion = 38;

            /// <summary>
            /// S/N segun el cliente tenga habilitados los recomendadores
            /// </summary>
            public const decimal RecomendadoresHabilitar = 39;

            /// <summary>
            /// Cantidad de dias de atraso que diferencia pasar a Devengado o En Suspenso
            /// </summary>
            /// 

            public const decimal DevengamientoLimiteDiasEnSuspenso = 41;

            /// <summary>
            /// S o N según se deba controlar la línea de crédito
            /// </summary>
            public const decimal CreditosPersonaControlLineaCredito = 42;

            /// <summary>
            /// Creditos de persona. Porcentaje de interes del gasto administrativo por defecto
            /// </summary>
            /// 
            public const decimal CreditosPersonasPorcentajeGastoAdministrativoImpuesto = 43;

            /// <summary>
            /// S = cada region es una empresa disinta; N = El nombre de la empresa está en la variable de sistema NombreEmpresa
            /// </summary>
            /// 
            public const decimal RegionRepresentaEmpresa = 44;

            /// <summary>
            /// S o N segun el credito preseleccione la afeccion de la linea de credito
            /// </summary>
            /// 
            public const decimal CreditosPersonaAfectarLineaCredito = 45;

            /// <summary>
            ///Porcentaje de adelanto definido por defecto 
            /// </summary>
            /// 
            public const decimal PorcentajeAdelantoFuncionario = 46;

            /// <summary>
            /// Tiempo de vigencia en dias de las lineas de credito temporales
            /// </summary>
            /// 
            public const decimal VigenciaLineaCreditoTemporal = 47;

            /// <summary>
            /// A partir de cuantos dias antes de la fecha de vencimiento se dice que el lote esta por vencer
            /// </summary>
            /// 
            public const decimal TiempoAdvertenciaVencimientoLote = 48;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas como comprobante de gasto administrativo
            /// </summary>
            /// 
            public const decimal FCClienteComoComprobantePagoGastoAdminArticulo = 49;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas como comprobante de gasto de cobranza
            /// </summary>
            /// 
            public const decimal FCClienteComoComprobantePagoGastoCobranza = 50;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas como comprobante de interes punitorio
            /// </summary>
            /// 
            public const decimal FCClienteComoComprobantePagoInteresPunitorio = 51;

            /// <summary>
            /// Porcentaje del IVA que se retiene a las personas
            /// </summary>
            /// 
            public const decimal RetencionPersonasPorcentaje = 52;

            /// <summary>
            /// Monto de factura a partir de la cual se retiene
            /// </summary>
            /// 
            public const decimal RetencionPersonasDesdeMonto = 53;

            /// <summary>
            /// Moneda en la cual se expresa el valor de la variable RetencionPersonasDesdeMonto
            /// </summary>
            /// 
            public const decimal RetencionPersonasMonedaMonto = 54;

            /// <summary>
            /// Cantidad de dias de atraso a partir del cual debe aplicarse mora por cuotas de un credito
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarMoraCreditoDesdeDias = 55;

            /// <summary>
            /// Cantidad de dias de atraso a partir del cual debe aplicarse mora por cuotas de una factura
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarMoraFCDesdeDias = 56;

            /// <summary>
            /// Cantidad de dias de atraso a partir del cual debe aplicarse mora por un descuento de documento
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarMoraDescuentoDocDesdeDias = 57;

            /// <summary>
            /// Cantidad de dias de atraso a partir de la cual debe aplicarse interes punitorio por cuotas de un credito
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarInteresPunitorioCreditoDesdeDias = 58;

            /// <summary>
            /// Cantidad de dias de atraso a partir de la cual debe aplicarse interes punitorio por cuotas de una factura
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarInteresPunitorioFCDesdeDias = 59;

            /// <summary>
            /// Cantidad de dias de atraso a partir de la cual debe aplicarse interes punitorio por un descuento de documento
            /// </summary>
            /// 
            public const decimal PagoDePersonasAplicarInteresPunitorioDescuentoDocDesdeDias = 60;

            /// <summary>
            /// Porcentaje del interes corriente que debe aplicarse como interes punitorio
            /// </summary>
            /// 
            public const decimal PagoDePersonasPorcentajeInteresPunitorioSobreMora = 61;

            /// <summary>
            /// Indica la politica de movimiento de stock a ser utilizada. Temprano=1  Tarde=2 Intemedio=3
            /// </summary>
            /// 
            public const decimal PoliticaMovimientoStock = 62;

            /// <summary>
            /// Descuento de Documentos Cliente. Porcentaje de interes por defecto
            /// </summary>
            /// 
            public const decimal DescuentoDocClientesPorcentajeInteres = 63;

            /// <summary>
            /// Descuento de Documentos Cliente. Porcentaje de impuesto del interés por defecto
            /// </summary>
            /// 
            public const decimal DescuentoDocClientesPorcentajeInteresImpuesto = 64;

            /// <summary>
            /// Descuento de Documentos Cliente. Porcentaje de gasto administrativo por defecto
            /// </summary>
            /// 
            public const decimal DescuentoDocClientesPorcentajeGastoAdministrativo = 65;

            /// <summary>
            /// Descuento de Documentos Cliente. Porcentaje de interés del gasto administrativo por defecto
            /// </summary>
            /// 
            public const decimal DescuentoDocClientesPorcentajeGastoAdministrativoImpuesto = 66;

            /// <summary>
            /// Descuento de Documentos Cliente. Porcentaje de mora diaria
            /// </summary>
            /// 
            public const decimal DescuentoDocClientesPorcentajeMora = 67;

            /// <summary>
            ///Verifica que el RUC sea único para cada cliente  S=Si N=No 
            /// </summary>
            /// 
            public const decimal VerificarUnicidadRUC = 68;

            /// <summary>
            ///Watchdog. La notificacion de actividad esta o no activo 
            /// </summary>
            /// 
            public const decimal WatchdogActivo = 69;

            /// <summary>
            ///Watchdog. Intervalo en minutos entre avisos de actividad
            /// </summary>
            /// 
            public const decimal WatchdogIntervalo = 70;

            /// <summary>
            ///Watchdog. Direccion donde se consume el web service
            /// </summary>
            /// 
            public const decimal WatchdogURL = 71;

            /// <summary>
            ///Watchdog. TnsName de la base de datos
            /// </summary>
            /// 
            public const decimal TnsName = 72;

            /// <summary>
            ///Creditos Personas. Monto al que se redondean las cuotas si estan en guaranies
            /// </summary>
            /// 
            public const decimal CreditosPersonasMontoRedondearCuotasGs = 73;

            /// <summary>
            /// Marcaciones. Cadena de conexion a base de datos
            /// </summary>
            public const decimal MarcacionesCadenaConexion = 74;

            /// <summary>
            ///Marcaciones. Nombre de tabla de donde se obtienen los datos
            /// </summary>
            /// 
            public const decimal MarcacionesTabla = 75;

            /// <summary>
            /// Flujo tramites. Cantidad de dias entre actividades para considerar que el traminte no esta avanzando
            /// </summary>
            public const decimal TramiteDiasSinActividad = 76;

            /// <summary>
            /// Flujo Presupuestos. S o N segun el caso deba pasarse automaticamente a pendiente luego de crearse
            /// </summary>
            public const decimal PresupuestosAvanzarBorradorAPendienteAlCrearCaso = 77;

            /// <summary>
            ///S o N segun la factura preseleccione la afeccion de la linea de credito.
            /// </summary>
            public const decimal FCClienteAfectarLineaCredito = 78;

            /// <summary>
            ///Es o no necesaria la aprobacion del ingreso para proveedores. Clase Definiciones.SiNo.
            /// </summary>
            public const decimal AprobacionIngresoProveedores = 79;

            /// <summary>
            ///Articulo a ser utilizado como detalle si el presupuesto del que se toman los detalles usa observacion sin articulo
            /// </summary>
            public const decimal PlanesFacturacionArticuloSiPresupuestoOmite = 80;

            /// <summary>
            ///Cantidad de días que se consideran laborales en el mes
            /// </summary>
            public const decimal DiasLaboralesMes = 81;

            /// <summary>
            ///Cantidad de horas que se consideran laborales en el día
            /// </summary>
            public const decimal HorasLaboralesDia = 82;

            /// <summary>
            ///Direccion base donde se consumen los webservices
            /// </summary>
            public const decimal WebservicesURL = 83;

            /// <summary>
            ///Articulo a ser utilizado como detalle en las FC Clientes emitidas como comprobante de pago mora
            /// </summary>
            public const decimal FCClienteComoComprobantePagoMoraArticulo = 84;

            /// <summary>
            ///Flujo pago de personas, al calcular los dias de atraso tener en cuenta los posibles feriados del calendario
            /// </summary>
            public const decimal PagoPersonasVerificarCalendarioParaAtraso = 85;

            /// <summary>
            ///Permite agregar articulos al flujo Pedido de Clientes sin importar su existencia en Stock S=Si/N=No
            /// </summary>
            public const decimal VerificarExistenciaStockPedidoCliente = 86;

            /// <summary>
            ///Direccion alternativa donde se consumen los webservices
            /// </summary>
            public const decimal WebservicesURL2 = 87;

            /// <summary>
            ///Identifica cual es la condicióm de pago por defecto.
            /// </summary>
            public const decimal CondicionDePagoPorDefecto = 88;

            /// <summary>
            /// Indica si se debe actualizar la fecha de un flujo al imprimir por primera vez.
            /// </summary>
            public const decimal ReportesActualizarImpreso = 90;

            /// <summary>
            /// Pago de personas. Indica si el recibo excluye los valores nota de credito y anticipo de la sumatoria de valores 
            /// </summary>
            public const decimal PagoPersonasReciboExcluirValores = 91;

            /// <summary>
            /// Reparto. Define si es necesario la utilizaciòn de la Caja de sucursal en caso de reparto S=Si ,N=No
            /// </summary>
            public const decimal UtilizarCajaEnReparto = 92;

            /// <summary>
            /// Nombre legal de la empresa
            /// </summary>
            public const decimal NombreEmpresa = 93;

            /// <summary>
            /// Id del articulo que se utiliza en el modulo de Presupuestos para registrar gastos e ingresos de por garantia
            /// </summary>
            public const decimal PresupuestosGarantiaArticulo = 94;

            /// <summary>
            /// Id del articulo que se utiliza en el modulo de Presupuestos para registrar gastos e ingresos de por garantia
            /// </summary>
            public const decimal FacturaClientePorcentajeMora = 95;

            /// <summary>
            /// El procentaje maximo que puede tomar un descuento
            /// </summary>
            public const decimal MaximoProcentajeDescuento = 96;

            /// <summary>
            /// URL para migrar datos al Market2
            /// </summary>
            public const decimal MigracionMK2 = 97;

            /// <summary>
            /// Enumeracion {AsociacionDirecta = 0, AsociacionPorZonaDeCobranza = 1}
            /// La forma en que se asocia la zona de cobranza con el cliente
            /// </summary>
            public const decimal TipoDeAsociacionCobranza = 98;

            /// <summary>
            /// Maximo numero de cobradores por una zona de cobranza, -1 indica no controlar
            /// </summary>
            public const decimal MaxCobradoresPorZona = 99;

            /// <summary>
            /// Maximo numero de vendedores por una zona de cobranza, -1 indica no controlar
            /// </summary>
            public const decimal MaxVendedoresPorZona = 100;

            /// <summary>
            /// Guarda el codigo de la persona cargada en el sistema que se utilizara para transferir las cuentas incobrables
            /// </summary>
            public const decimal PersonaParaIncobrables = 101;

            /// <summary>
            /// ID del articulo utilizado para facturar recargos financieros
            /// </summary>
            public const decimal FCClienteArticuloPorRecargoFinanciero = 102;

            /// <summary>
            /// Porcentaje del recargo financiero a ser aplicado a los articulos marcados con recargo
            /// </summary>
            public const decimal FCClientePorcentajeRecargoFinanciero = 103;

            /// <summary>
            /// URL del servidor jsreport
            /// </summary>
            public const decimal DireccionServidorJsreport = 104;

            /// <summary>
            /// Indica si la politica de la Nota de Credito es General o Especifica
            /// 1 o 2. 1 = General; 2 = Especifica
            /// </summary>
            public const decimal PoliticaNotaCredito = 105;

            /// <summary>
            /// Indica si se van a crear codigos de reingreso en las Notas de Créditos 
            /// S o N. S = se crearan los codigos; N = no se crearan los codigos
            /// </summary>
            public const decimal CreacionCodigoReingreso = 106;

            /// <summary>
            /// S o N segun se deba validar el nro documento externo con el sub-sistema del cliente
            /// </summary>
            public const decimal FCClienteValidarNroDocumentoExterno = 107;

            /// <summary>
            /// S o N segun se generará una cuota distinta al final a tal modo a ajustar 
            /// la diferencia que queda a causa de los decimales
            /// </summary>
            public const decimal CalendarioPagosRedondearCuotas = 108;

            /// <summary>
            /// S o N según se deba controlar la línea de crédito en la FC
            /// </summary>
            public const decimal FCControlLineaCredito = 109;

            /// <summary>
            /// S o N según se deba controlar la línea de crédito en la Nota de Pedido
            /// </summary>
            public const decimal NotaPedidoControlLineaCredito = 110;

            /// <summary>
            /// Pago de personas, politica de recargo. 0 = calculado por CBAFlow, 1 = calculado por webservice
            /// Los valores posibles se definen en Definiciones.PoliticasRecargo
            /// </summary>
            public const decimal PagoDePersonasPoliticaRecargo = 111;

            /// <summary>
            /// FC Clientes. S/N segun el campo Vendedor sea obligatorio
            /// </summary>
            public const decimal FacturaClienteVendedorObligatorio = 112;

            /// <summary>
            /// FC Clientes. S/N según el campo SucursalVenta sea obligatorio.
            /// </summary>
            public const decimal FCClienteUtilizarSucursalVenta = 113;


            /// <summary>
            /// Indica la cantidad máxima de cobradores externos por zona, -1 indica no controlar
            /// </summary>
            public const decimal MaxCobradoresExternoPorZona = 114;

            /// <summary>
            /// Maximo numero de promotores por una zona de cobranza, -1 indica no controlar
            /// </summary>
            public const decimal MaxPromotoresPorZona = 115;

            /// <summary>
            /// Inicializar a que se controle o no la cantidad minima y descuento maximo segun lista de precios
            /// </summary>
            public const decimal ListaPreciosInicializarControlCantidadYDto = 116;

            /// <summary>
            /// S o N indica si en los flujos se mostrará el check de usar activos tildado por defecto o no
            /// </summary>
            public const decimal FlujosUsarActivoPorDefecto = 117;

            /// <summary>
            /// URL del servidor Django
            /// </summary>
            public const decimal DireccionServidorDjango = 118;

            /// <summary>
            /// URL del servidor WebSocket Node.js
            /// </summary>
            public const decimal DireccionServidorWebSocketNodeJs = 119;

            /// <summary>
            /// S o N según deba generarse una orden de pago al pasar el caso de descuento de documentos cliente a APROBADO
            /// </summary>
            public const decimal DescuentoDocumentosClienteGenerarOPAlAprobar = 121;

            /// <summary>
            /// S o N según deba controlarse al momento de guardar un documento a ser pagado, que no existen cuotas anteriores con saldo
            /// </summary>
            public const decimal PagoDePersonasControlarCuotasPreviasConSaldo = 122;

            /// <summary>
            /// URL del servidor Latex
            /// </summary>
            public const decimal DireccionServidorLatex = 123;

            /// <summary>
            /// Tipo de cliente por defecto al crear personas
            /// </summary>
            public const decimal PersonasTipoClienteIdPorDefecto = 124;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal FCClienteMargenDiasPuedeAvanzar = 125;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal FCProveedorMargenDiasPuedeAvanzar = 126;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal NCPersonasMargenDiasPuedeAvanzar = 127;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal NDPersonasMargenDiasPuedeAvanzar = 128;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal NCProveedorMargenDiasPuedeAvanzar = 129;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal NDProveedorMargenDiasPuedeAvanzar = 130;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal DepositoBancarioMargenDiasPuedeAvanzar = 131;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal PagoDePersonasMargenDiasPuedeAvanzar = 132;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal OrdenesPagoMargenDiasPuedeAvanzar = 133;

            /// <summary>
            /// Id de la persona a ser utilizada como cliente mostrador (tambien llamado cliente ocasional)
            /// </summary>
            public const decimal PersonaClienteMostrador = 134;

            /// <summary>
            /// S o N segun el campo saldo cierre deba cargarse de forma automatica en la UI de caja de sucursal
            /// </summary>
            public const decimal CajasSucursalSaldoCierreAutomatico = 135;

            /// <summary>
            /// Modo en que se ejecuta el sistema. 0 = no usar; 1 = solo lectura; 2= lecutra/escritura
            /// </summary>
            public const decimal SistemaModo = 136;

            /// <summary>
            /// Indica si los campos de la dirección principal de la persona son obligatorias  Si = S; No = N
            /// </summary>
            public const decimal PersonasDireccionPrincipalEsObligatoria = 137;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal AjustesBancariosMargenDiasPuedeAvanzar = 138;

            /// <summary>
            /// S o N según deba controlarse al momento de guardar un documento a ser pagado, que no existen cuotas con vto anterior de cualquier documento
            /// </summary>
            public const decimal PagoDePersonasControlarCuotasMenorVto = 139;

            /// <summary>
            /// Fecha del ultimo upgrade (ej. formato 31/01/2015 15:01:15)
            /// </summary>
            public const decimal SistemaFechaUltimoUpgrade = 140;

            /// <summary>
            /// URL del servidor ReportLab
            /// </summary>
            public const decimal DireccionServidorReportLab = 141;

            /// <summary>
            /// Articulo a ser utilizado como detalle en las FC Clientes emitidas debido a una consolidación de deuda.
            /// </summary>
            public const decimal FCClienteArticuloPorConsolidacionDeuda = 142;

            /// <summary>
            /// La condicion de pago por defecto a ser utilizada en la factura tipo Contado
            /// </summary>
            public const decimal CondicionPagoContadoCompra = 143;

            /// <summary>
            /// Indica si debe controlar la repeticion de un lote de las facturas y notas de pedidos S=Si N=No
            /// </summary>
            public const decimal ControlarRepeticionEnDetallesDeVentas = 144;

            /// <summary>
            /// S = inicializar a modo automatico; N = inicializar a modo manual
            /// </summary>
            public const decimal PagoDePersonasModoAgregarDocumentoAutomatico = 145;

            /// <summary>
            /// S = se muestran los campos; N = no se muestran y se toma la fecha de fectura
            /// </summary>
            public const decimal FCProveedorUsarFechaPedidoYRecepcion = 146;

            /// <summary>
            /// 0=no agrupar (por caso); 1=agrupar por dia; 2=agrupar por mes; 
            /// </summary>
            public const decimal RetencionProveedoresPoliticaAgrupamientoContado = 147;

            /// <summary>
            /// 0=no agrupar (por caso); 1=agrupar por dia; 2=agrupar por mes; 
            /// </summary>
            public const decimal RetencionProveedoresPoliticaAgrupamientoCredito = 148;

            /// <summary>
            /// S/N segun un caso en la moneda A pueda utilizar una lista de precios en la moneda B
            /// </summary>
            public const decimal ListaPreciosRestringirPorMoneda = 149;

            /// <summary>
            /// S/N segun deba generarse el asiento automatico de una transferencia bancaria cuando el origen es una cuenta de un cliente
            /// </summary>
            public const decimal CTBAsientoTransferenciaBancariaGenerarOrigenCliente = 150;

            /// <summary>
            /// Indica la cantidad de días en las que se puede crear un caso con fecha futura
            /// </summary>
            public const decimal CantidadDiasFechaAFuturo = 151;

            /// <summary>
            /// S/N según se haya generado el archivo para el tesaka
            /// </summary>
            public const decimal ActualizarRetencionesDeclaradas = 152;

            /// <summary>
            /// Indica el Id del Articulo que corresponde a los trabajos realizados
            /// </summary>
            public const decimal ArticuloTrabajosRealizados = 153;

            /// <summary>
            /// Indica el Id del Articulo que corresponde a los reajustes de las facturas
            /// </summary>
            public const decimal ArticuloReajuste = 154;

            /// <summary>
            /// Indica el Id del Articulo que corresponde a los Anticipos
            /// </summary>
            public const decimal ArticuloAnticipo = 155;

            /// <summary>
            /// Indica el Id del Articulo que corresponde a las Penalizaciones'
            /// </summary>
            public const decimal ArticuloPenalizacion = 156;

            /// <summary>
            /// IIndica el Id del Articulo que corresponde a las Retenciones por Fondo Reparo
            /// </summary>
            public const decimal ArticuloRetencionFondoReparo = 157;

            /// <summary>
            /// Indica el Id del Articulo que corresponde a las Notas de Credito
            /// </summary>
            public const decimal ArticuloRetencionNotaCredito = 158;

            /// <summary>
            /// 0=tomar solo documentos del caso; 1=tomar documentos de otros casos del mismo dia; 2=tomar documentos de otros casos del mismo mes;
            /// </summary>
            public const decimal RetencionProveedoresPoliticaCasosAConsiderarContado = 159;

            /// <summary>
            /// 0=tomar solo documentos del caso; 1=tomar documentos de otros casos del mismo dia; 2=tomar documentos de otros casos del mismo mes;
            /// </summary>
            public const decimal RetencionProveedoresPoliticaCasosAConsiderarCredito = 160;

            /// <summary>
            /// S=usar la moneda de la factura; N=usar la moneda del pais;
            /// </summary>
            public const decimal RetencionProveedoresUsarMonedaFactura = 161;

            /// <summary>
            /// S=considerar credito y contado por separado; N=considerar en forma indistinta a la condicion de pago;
            /// </summary>
            public const decimal RetencionProveedoresDiferenciarCreditoYContado = 162;

            /// <summary>
            /// 0=total de la factura; 1=total cuota; 2=monto pago
            /// </summary>
            public const decimal RetencionProveedoresPoliticaMonto = 163;

            /// <summary>
            /// 0=total de la factura; 1=total cuota; 2=monto pago
            /// </summary>
            public const decimal RetencionProveedoresPoliticaMontoRetencion = 164;

            /// <summary>
            /// S=tomar monto neto; N=tomar neto menos impuesto
            /// </summary>
            public const decimal RetencionProveedoresIncluirIVAAlVerificarMinimo = 165;

            /// <summary>
            /// Indica el ID del descuento que corresponde al IPS
            /// </summary>
            public const decimal RrhhDescuentoIPS = 166;

            /// <summary>
            /// S o N, Indica si se descuenta o no IPS 
            /// </summary>
            public const decimal RrhhDescuentoCobroIPS = 167;

            /// <summary>
            /// URL del webservice de cotizaciones
            /// </summary>
            public const decimal CotizacionWebServiceDireccion = 168;

            /// <summary>
            /// S o N segun las retenciones que se emitan deban ser unicamente sobre documentos que participan del caso de pago
            /// </summary>
            public const decimal RetencionProveedoresRetenerSoloDocumentosDelCaso = 169;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal TransferenciaStockMargenDiasPuedeAvanzar = 170;


            /// <summary>
            /// Indicará si el importe en letras de los cheques se muestra en mayúscula
            /// </summary>
            public const decimal ImpresionChequesMontoEnLetraMayuscula = 171;

            /// <summary>
            /// S o N segun deba controlarse la unicidad de codigo
            /// </summary>
            public const decimal PersonasControlarUnicidadCodigo = 172;

            /// <summary>
            /// S o N segun deba controlarse la unicidad de codigo
            /// </summary>
            public const decimal ProveedoresControlarUnicidadCodigo = 173;

            /// <summary>
            /// S o N segun deba inicializarse el campo en la ficha de proveedores
            /// </summary>
            public const decimal ProveedoresAgenteRetencion = 174;

            /// <summary>
            /// S o N segun deba inicializarse el campo en la ficha de personas
            /// </summary>
            public const decimal PersonasAgenteRetencion = 175;

            /// <summary>
            /// S o N segun deba controlarse que dos centros de costo no puedan tener el mismo nombre
            /// </summary>
            public const decimal CentrosCostoControlarUnicidadNombre = 176;

            /// <summary>
            /// S o N segun deba especificarse el vehiculo en el flujo Transferencia de Stock
            /// </summary>
            public const decimal StockTransferenciaEspecificarVehiculo = 177;

            /// <summary>
            /// S o N segun deba hallarse el total por el precio en el flujo Ordenes de Servicio
            /// </summary>
            public const decimal OrdenesDeServicioTotalPorPrecio = 178;

            /// <summary>
            /// id del business, identificador de la instanacia de 24Seven
            /// </summary>
            public const decimal VeinticuatroSevenIdBusiness = 179;

            /// <summary>
            /// 24Seven. URL del webmethod para afectar stock
            /// </summary>
            public const decimal VeinticuatroSevenURLAfectarStock = 180;

            /// <summary>
            /// hash utilizado como contraseña en 24Seven
            /// </summary>
            public const decimal VeinticuatroSevenHash = 181;

            /// <summary>
            /// S o N segun deba controlarse la unicidad del campo cuando esta definido
            /// </summary>
            public const decimal FCClienteValidarNroDocumentoExternoUnico = 182;

            /// <summary>
            /// Nombre del puerto, utilizado por ejemplo en los EDI
            /// </summary>
            public const decimal LogisticaPuertoNombre = 183;

            /// <summary>
            /// FC Clientes. S/N segun el campo Canal de Ventas sea obligatorio cuando hay un vendedor definido
            /// </summary>
            public const decimal FacturaClienteCanalVentasObligatorioSiHayVendedor = 184;

            /// <summary>
            /// Id del texto predefinid a ser utilizado en el movimiento de fondo fijo al ser creado desde el pago a contratistas
            /// </summary>
            public const decimal PagoContratistasMovimientoFondoFijoTextoPredefinido = 185;

            /// <summary>
            /// S=siempre se usa la fecha de la factura; N=fecha de factura si contado, de pago si es credito;
            /// </summary>
            public const decimal RetencionProveedoresUsarFechaFactura = 186;

            /// <summary>
            /// Indica si es obligatorio o no el cód. del reloj marcador para importación de entradas
            /// </summary>
            public const decimal RrhhRelojMarcador = 187;

            /// <summary>
            /// Direccion del microservicio Clio - Minio
            /// </summary>
            public const decimal ClioURL = 188;

            /// <summary>
            /// Generacion del ingreso de Stock en forma temprana, de borrador a pendiente en la FC Proveedor
            /// </summary>
            public const decimal GeneracionTempranaIngresoStock = 189;

            /// <summary>
            /// Conjunto de recomendadores de articulos
            /// </summary>
            public const decimal Recomendadores = 190;

            /// <summary>
            /// S o N según deba calcularse o no
            /// </summary>
            public const decimal CalcularCuentaDeResultado = 191;

            /// <summary>
            /// Id de cuenta de resultado
            /// </summary>
            public const decimal CuentaDeResultado = 192;

            /// <summary>
            /// S o N segun se impida que una cuenta creada en una region sea cobrada o pagada desde otra region
            /// </summary>
            public const decimal RegionCtacteIndependiente = 193;

            /// <summary>
            /// S o N segun el PPP sea calculado por region o para todas las regiones
            /// </summary>
            public const decimal RegionArticulosCostosIndependiente = 194;

            /// <summary>
            /// 0 = no modificar; 1 = todo mayusculas
            /// </summary>
            public const decimal TextoPoliticaMayusculas = 195;

            /// <summary>
            /// Cantidad mínima de caracteres para la búsqueda 
            /// </summary>
            public const decimal BusquedaCantidadMinimaCaracteres = 196;

            /// <summary>
            /// Define si la factura será enviada al cliente cuando pase al estado CAJA
            /// </summary>
            public const decimal FCClienteEnvioEmailCliente = 197;

            /// <summary>
            /// S o N segun se deba validar el nro documento externo con el sub-sistema del cliente
            /// </summary>
            public const decimal CreditosValidarNroDocumentoExterno = 198;

            /// <summary>
            /// S o N segun vendedor sea requerido en la ficha de la persona
            /// </summary>
            public const decimal PersonasVendedorObligatorio = 199;

            /// <summary>
            /// S o N segun se impida que los articulos de una region sean utilizados por otra
            /// </summary>
            public const decimal RegionArticuloIndependiente = 200;

            /// <summary>
            /// Créditos de persona. Cantidad de cuotas no vencidas a las que no deben aplicarse el descuento por cancelacion anticipada
            /// </summary>
            public const decimal CreditosPersonasCancelacionAnticipadaCuotasSinVencer = 201;

            /// <summary>
            /// Articulos Financieros. Restringir la seleccion del articulo por persona asociada
            /// </summary>
            public const decimal ArticulosFinancierosRestringirPersona = 202;

            /// <summary>
            /// Dias a partir del cual se considera que los datos de la persona estan desactualizados
            /// </summary>
            public const decimal PersonasDiasActualizacionDatosVigencia = 203;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal CreditosMargenDiasPuedeAvanzar = 204;

            /// <summary>
            /// ‘S’= Verificar la Reserva /‘N’ =No Verificar la Reserva
            /// </summary>
            public const decimal VerificarStockReservaEnNotaDePedido = 205;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal RemisionesMargenDiasPuedeAvanzar = 206;

            /// <summary>
            ///Permite agregar articulos al flujo Factura de Clientes sin importar su existencia en Stock S=Si/N=No
            /// </summary>
            public const decimal VerificarExistenciaStockFacturaCliente = 207;

            /// <summary>
            /// URL del servidor Matricial
            /// </summary>
            public const decimal DireccionServidorMatricial = 208;

            /// <summary>
            /// S/N segun se requiera que el caso este aprobado por los departamentos precio y credito
            /// </summary>
            public const decimal PedidoDeClienteVerificarAprobacionPrecioYCredito = 209;

            /// <summary>
            /// S o N segun se deba validar el nro documento externo con el sub-sistema del cliente
            /// </summary>
            public const decimal RefinanciacionDeudasValidarNroDocumentoExterno = 210;

            /// <summary>
            /// S o N segun se deba validar el nro documento externo con el sub-sistema del cliente
            /// </summary>
            public const decimal AplicacionDocumentosValidarNroDocumentoExterno = 211;

            /// <summary>
            /// S o N según se deba crear una NC por los intereses no devengados descontados
            /// </summary>
            public const decimal CreditosPersonaCancelacionCrearNotaCreditoPorDescuento = 212;

            /// <summary>
            /// Indica si se debe actualizar la fecha de la transferencia al imprimir por primera vez.
            /// </summary>
            public const decimal ReportesActualizarImpresoStockTransferencia = 213;

            /// <summary>
            /// Cantidad de días pasado el mes del caso que se consideran para permitir el avance de estado
            /// </summary>
            public const decimal MovimientoFondoFijoMargenDiasPuedeAvanzar = 214;

            /// <summary>
            /// S = utilizar fecha en que el usuario realiza la acción, N = utilizar fecha del movimiento original
            /// </summary>
            public const decimal CuentaBancariaMovimientoReversionFechaAccion = 215;

            /// <summary>
            /// El valor es la serializacion de un objeto que contiene los requisitos minimos
            /// </summary>
            public const decimal ContrasenhaRequerimientosMinimos = 216;

            /// <summary>
            /// Cantidad de dias que deben pasar sin login de un usuario para inactivarlo. Cero significa no controlar
            /// </summary>
            public const decimal UsuarioInactivarSiDiasSinLogin = 217;

            /// <summary>
            /// Indica si se mostrará el formulario en FC Cliente para confirmación de pago en efectivo de factura contado
            /// </summary>
            public const decimal FCClienteContadoGenerarPagoPersona = 218;

            /// <summary>
            /// S = habilita imprimir recibo manual en pago de persona, N = no habilita imprimir recibo manual
            /// </summary>
            public const decimal PagoDePersonasImprimirReciboManual = 219;

            /// <summary>
            /// Pasillos donde se ubica el stock
            /// </summary>
            public const decimal StockPasillo = 220;

            /// <summary>
            /// Estantes donde se ubica el stock
            /// </summary>
            public const decimal StockEstante = 221;

            /// <summary>
            /// Niveles donde se ubica el stock
            /// </summary>
            public const decimal StockNivel = 222;

            /// <summary>
            /// Columnas donde se ubica el stock
            /// </summary>
            public const decimal StockColumna = 223;

            /// <summary>
            /// URL del servidor de reportes Jasper
            /// </summary>
            public const decimal DireccionServidorJasperReport = 224;

            /// <summary>
            /// Indica la carpera reservado para el cliente
            /// </summary>
            public const decimal JasperReportFolder = 225;

            /// <summary>
            /// S o N para para reportes en Crystal exportados en PDF
            /// </summary>
            public const decimal ReportePrevisualizar = 227;

            /// <summary>
            /// S o N para enviar notificaciones al clientes al pasar de estado la factura cliente
            /// </summary>
            public const decimal NotificarFacturasPendienteCaja = 228;

            /// <summary>
            /// Indica en horas validez del token
            /// </summary>
            public const decimal ValidezToken = 229;

            /// <summary>
            /// Indica los Estado que puede tener el detalle en la orden de servicio
            /// </summary>
            public const decimal EstadoDetalleOrdenServicio = 230;

            /// <summary>
            /// Codigo de articulo que representa ordenes de servicio
            /// </summary>
            public const decimal OrdenDeServicioArticuloGenerico = 231;

            /// <summary>
            /// S = Solo trae los articulos del cliente cuando se factura. N = Trae todos los articulos.
            /// </summary>
            public const decimal FCClienteFiltrarArticuloCliente = 232;

            /// <summary>
            /// S o N para generar una Orden de Servicio si el Presupuesto pasa a APROBADO.
            /// </summary>
            public const decimal PresupuestosGenerarOrdenDeServicio = 233;

            /// <summary>
            /// S si sabado es dia laboral, N si no es dia laboral.
            /// </summary>
            public const decimal FuncionariosVacacionesSabadoLaboral = 234;

            /// <summary>
            /// Indique S/N si se utilizaran(visible) los campos extendidos de los Lotes
            /// </summary>
            public const decimal ArticulosLotesUtilizarPropiedadesExendidas = 235;

            /// <summary>
            /// Indique S/N  si se generarán automáticamente los lotes a partir de los datos del ingreso de insumos 
            /// </summary>
            public const decimal ArticulosLotesGenerarDesdeFlujo = 236;

            /// <summary>
            /// Indique S/N para validar al aprobar el caso que el campo de caso asociado tenga valor
            /// </summary>
            public const decimal UsoInsumoObligatorioCasoAsociado = 237;
        }
        #endregion Variables de sistema

        #region Hechauka

        public abstract class ReporteHechauka
        {
            public const string VENTA = "Ventas";
            public const string COMPRA = "Compras";
            public const string RETENCION = "Retencion";
        }

        public abstract class ActivosRubros
        {
            public const decimal MueblesYUtiles = 1;
            public const decimal Hardware = 2;
            public const decimal Software = 3;
            public const decimal EquiposDeOficina = 4;
            public const decimal Rodados = 5;
            public const decimal Motocicletas = 6;
            public const decimal Instalaciones = 7;
            public const decimal CartelesYLetreros = 8;
            public const decimal MejorasPredioAjeno = 9;
            public const decimal InmueblesLotes = 10;
            public const decimal InmueblesRurales = 11;
            public const decimal InmueblesUrbanos = 12;
        }

        public abstract class TiposActivos
        {
            public const decimal Vario = 1;
            public const decimal Vehiculo = 2;
            public const decimal Inmueble = 3;
        }

        #endregion Hechauka

        #region Marangatu
        public abstract class ReportesMarangatu
        {
            public const string VENTA = "V";
            public const string COMPRA = "C";
            public const string INGRESO = "I";
            public const string EGRESO = "E";
        }

        public abstract class TipoComprobanteSet
        {
            public const decimal FACTURA = 109;
            public const decimal EGRESOS = 201;

        }
        #endregion Marangatu

        #region Reporte Ordenamiento

        public abstract class ReporteOrdenamiento
        {
            public const int Fecha = 0;
            public const int NroComprobante = 1;
            public const int PersonaNombre = 2;
            public const int SalarioBruto = 3;
            public const int Departamento = 4;
        }

        #endregion Reporte Pago de personas

        #region Tesaka

        public abstract class ReporteTesaka
        {
            public const string RETENCION = "Retencion";
        }

        #endregion Hechauka

        #region EstadosCajaSucursal
        public abstract class EstadosCajaSucursal
        {
            public const string Abierta = "ABIERTA";
            public const string Cerrada = "CERRADA";
            public const string Aceptada = "ACEPTADA";
            public const string Remitida = "REMITIDA";
        }
        #endregion EstadosCajaSucursal

        #region Error
        public abstract class Error
        {
            public abstract class Valor
            {
                public const decimal EnteroPositivo = -1;
                public const int IntPositivo = -1;
            }
        }
        #endregion Error

        #region Log
        public abstract class Log
        {
            public const string RegistroBorrado = "Registro borrado";
            public const string RegistroNuevo = "Registro nuevo";
            public const string LoginFallaUsuarioInexistente = "Usuario Inexistente";
            public const string LoginFallaIpNoValida = "IP no válida";
            public const string LoginFallaHorarioNoValido = "Acceso en horario no válido";
        }
        #endregion Log

        #region Flujos
        public abstract class Flujo
        {
            public abstract class AjusteDeStock
            {
                public static decimal ID = 1;
                public static string permisoCreacion = "AJUSTE STOCK CREAR";
            }
            public abstract class AnticipoAProveedor
            {
                public static decimal ID = 2;
                public static string permisoCreacion = "ANTICIPOS PROVEEDOR CREAR";
            }
            public abstract class AnticipoDeCliente
            {
                public static decimal ID = 3;
                public static string permisoCreacion = "ANTICIPOS PERSONA CREAR";
            }
            public abstract class CambioDeDivisa
            {
                public static decimal ID = 4;
                public static string permisoCreacion = "CAMBIOS DIVISA CREAR";
            }
            public abstract class CustodiaDeValores
            {
                public static decimal ID = 5;
                public static string permisoCreacion = "CUSTODIA VALORES CREAR";
            }
            public abstract class DepositoBancario
            {
                public static decimal ID = 6;
                public static string permisoCreacion = "DEPOSITOS BANCARIOS CREAR";
            }
            public abstract class DescuentoDeDocumento
            {
                public static decimal ID = 7;
                public static string permisoCreacion = "DESCUENTO DOCUMENTOS CREAR";
            }
            public abstract class EgresoVarioDeCaja
            {
                public static decimal ID = 8;
                public static string permisoCreacion = "EGRESOS VARIOS CAJA CREAR";
            }
            public abstract class FacturaCliente
            {
                public static decimal ID = 9;
                public static string permisoCreacion = "FC CLIENTE CREAR";
            }
            public abstract class FacturaProveedor
            {
                public static decimal ID = 10;
                public static string permisoCreacion = "FC PROVEEDOR CREAR";
            }
            public abstract class MovimientoVarioDeTesoreria
            {
                public static decimal ID = 11;
                public static string permisoCreacion = "MOVIMIENTO VARIO TESORERIA CREAR";
            }
            public abstract class NotaCreditoCliente
            {
                public static decimal ID = 12;
                public static string permisoCreacion = "NOTAS CREDITO PERSONA CREAR";
            }
            public abstract class NotaCreditoProveedor
            {
                public static decimal ID = 13;
                public static string permisoCreacion = "NOTAS CREDITO PROVEEDOR CREAR";
            }
            public abstract class NotaDebitoCliente
            {
                public static decimal ID = 14;
                public static string permisoCreacion = "NOTAS DEBITO PERSONA CREAR";
            }
            public abstract class NotaDebitoProveedor
            {
                public static decimal ID = 15;
                public static string permisoCreacion = "NOTAS DEBITO PROVEEDOR CREAR";
            }
            public abstract class NotaDePedido
            {
                public static decimal ID = 16;
                public static string permisoCreacion = "PEDIDOS CLIENTE CREAR";
            }
            public abstract class OrdenDePago
            {
                public static decimal ID = 18;
                public static string permisoCreacion = "ORDENES PAGO CREAR";
            }
            /*public abstract class PlanillaDePagos{ 
	            public static decimal ID = 19; 
	            public static string permisoCreacion = "";
            }*/
            public abstract class Reparto
            {
                public static decimal ID = 20;
                public static string permisoCreacion = "REPARTO CREAR";
            }
            public abstract class TransferenciaBancaria
            {
                public static decimal ID = 21;
                public static string permisoCreacion = "TRANSFERENCIAS BANCARIAS CREAR";
            }
            public abstract class TransferenciaDeArticulo
            {
                public static decimal ID = 22;
                public static string permisoCreacion = "TRANSFERENCIAS STOCK CREAR";
            }
            public abstract class AsignacionDeCargos
            {
                public static decimal ID = 23;
                public static string permisoCreacion = "ASIGNACION CARGOS CREAR";
            }
            public abstract class Encuesta
            {
                public static decimal ID = 24;
                public static string permisoCreacion = "ENCUESTA CREAR";
            }
            public abstract class Sugerencia
            {
                public static decimal ID = 25;
                public static string permisoCreacion = "";
            }
            public abstract class Usuario
            {
                public static decimal ID = 26;
                public static string permisoCreacion = "USUARIOS CREAR";
            }
            public abstract class AjusteBancario
            {
                public static decimal ID = 27;
                public static string permisoCreacion = "AJUSTES BANCARIOS CREAR";
            }
            public abstract class TransferenciaDeCajaDeTesoreria
            {
                public static decimal ID = 28;
                public static string permisoCreacion = "TRANSFERENCIA CAJAS TESORERIA CREAR";
            }
            public abstract class Presupuesto
            {
                public static decimal ID = 29;
                public static string permisoCreacion = "PRESUPUESTOS CREAR";
            }
            public abstract class Contrato
            {
                public static decimal ID = 30;
                public static string permisoCreacion = "CONTRATOS CREAR";
            }
            public abstract class AdelantoAFuncionario
            {
                public static decimal ID = 31;
                public static string permisoCreacion = "ADELANTO FUNCIONARIO CREAR";
            }
            public abstract class PlanillaDeLiquidacion
            {
                public static decimal ID = 32;
                public static string permisoCreacion = "PLANILLA DE LIQUIDACIONES CREAR";
            }
            public abstract class PagoDePersona
            {
                public static decimal ID = 33;
                public static string permisoCreacion = "PAGOS DE PERSONA CREAR";
            }
            public abstract class IngresoDeStock
            {
                public static decimal ID = 34;
                public static string permisoCreacion = "INGRESO DE STOCK CREAR";
            }
            public abstract class UsoDeInsumos
            {
                public static decimal ID = 35;
                public static string permisoCreacion = "USO DE INSUMOS CREAR";
            }
            public abstract class StockInventario
            {
                public static decimal ID = 36;
                public static string permisoCreacion = "STOCK INVENTARIO CREAR";
            }
            public abstract class ModificacionAListaDePrecios
            {
                public static decimal ID = 37;
                public static string permisoCreacion = "LISTA PRECIOS MODIFICAR CREAR";
            }
            public abstract class CreditoAPersona
            {
                public static decimal ID = 38;
                public static string permisoCreacion = "CREDITOS CREAR";
            }
            public abstract class TransferenciaDeCtactePersona
            {
                public static decimal ID = 39;
                public static string permisoCreacion = "TRANSFERENCIA DE CTACTE PERSONA CREAR";
            }
            public abstract class PlanillaDeCobranza
            {
                public static decimal ID = 40;
                public static string permisoCreacion = "PLANILLA DE COBRANZA CREAR";
            }
            public abstract class CreditoDeProveedor
            {
                public static decimal ID = 41;
                public static string permisoCreacion = "CREDITOS PROVEEDORES CREAR";
            }
            public abstract class CanjeDeValores
            {
                public static decimal ID = 42;
                public static string permisoCreacion = "CANJES DE VALORES CREAR";
            }
            public abstract class DescuentoDeDocumentosACliente
            {
                public static decimal ID = 43;
                public static string permisoCreacion = "DESCUENTO DOCUMENTOS CLIENTE CREAR";
            }
            public abstract class OrdenDeServicio
            {
                public static decimal ID = 44;
                public static string permisoCreacion = "ORDENES SERVICIO CREAR";
            }
            public abstract class Tramite
            {
                public static decimal ID = 45;
                public static string permisoCreacion = "TRAMITES CREAR";
            }
            public abstract class PlanDeFacturacion
            {
                public static decimal ID = 46;
                public static string permisoCreacion = "PLANES FACTURACION CREAR";
            }
            public abstract class DesembolsoDeGiros
            {
                public static decimal ID = 47;
                public static string permisoCreacion = "DESEMBOLSOS GIROS CREAR";
            }
            public abstract class AplicacionDocumentos
            {
                public static decimal ID = 48;
                public static string permisoCreacion = "APLICACION DOCUMENTOS CREAR";
            }
            public abstract class MovimientoDeFondoFijo
            {
                public static decimal ID = 49;
                public static string permisoCreacion = "MOVIMIENTO FONDO FIJO CREAR";
            }
            public abstract class RefinanciacionDeDeudas
            {
                public static decimal ID = 50;
                public static string permisoCreacion = "REFINANCIACION DE DEUDAS CREAR";
            }
            public abstract class RendicionDeCobradores
            {
                public static decimal ID = 51;
                public static string permisoCreacion = "RENDICION DE COBRADORES CREAR";
            }
            public abstract class TransferenciaCajasSucursal
            {
                public static decimal ID = 52;
                public static string permisoCreacion = "TRANSFERENCIA CAJAS SUCURSAL CREAR";
            }
            public abstract class Remision
            {
                public static decimal ID = 53;
                public static string permisoCreacion = "REMISIONES CREAR";
            }
            public abstract class OrdenDeCompra
            {
                public static decimal ID = 54;
                public static string permisoCreacion = "ORDENES COMPRA CREAR";
            }
            public abstract class RecalendarizacionMasivaDeudas
            {
                public static decimal ID = 55;
                public static string permisoCreacion = "RECALENDARIZACION MASIVA DEUDAS CREAR";
            }
            public abstract class IngresoDeInsumos
            {
                public static decimal ID = 56;
                public static string permisoCreacion = "INGRESO INSUMOS CREAR";
            }

            public abstract class EgresoDeProductos
            {
                public static decimal ID = 57;
                public static string permisoCreacion = "EGRESO PRODUCTOS CREAR";
            }

            public static string[] permisosFlujos()
            {
                return new string[]{
                    AjusteDeStock.permisoCreacion,
                    AnticipoAProveedor.permisoCreacion,
                    AnticipoDeCliente.permisoCreacion,
                    CambioDeDivisa.permisoCreacion,
                    CustodiaDeValores.permisoCreacion,
                    DepositoBancario.permisoCreacion,
                    DescuentoDeDocumento.permisoCreacion,
                    EgresoVarioDeCaja.permisoCreacion,
                    FacturaCliente.permisoCreacion,
                    FacturaProveedor.permisoCreacion,
                    MovimientoVarioDeTesoreria.permisoCreacion,
                    NotaCreditoCliente.permisoCreacion,
                    NotaCreditoProveedor.permisoCreacion,
                    NotaDebitoCliente.permisoCreacion,
                    NotaDebitoProveedor.permisoCreacion,
                    NotaDePedido.permisoCreacion,
                    OrdenDePago.permisoCreacion,
                    //PlanillaDePagos.permisoCreacion,
                    Reparto.permisoCreacion,
                    TransferenciaBancaria.permisoCreacion,
                    TransferenciaDeArticulo.permisoCreacion,
                    AsignacionDeCargos.permisoCreacion,
                    Encuesta.permisoCreacion,
                    Sugerencia.permisoCreacion,
                    Usuario.permisoCreacion,
                    AjusteBancario.permisoCreacion,
                    TransferenciaDeCajaDeTesoreria.permisoCreacion,
                    Presupuesto.permisoCreacion,
                    Contrato.permisoCreacion,
                    AdelantoAFuncionario.permisoCreacion,
                    PlanillaDeLiquidacion.permisoCreacion,
                    PagoDePersona.permisoCreacion,
                    IngresoDeStock.permisoCreacion,
                    UsoDeInsumos.permisoCreacion,
                    StockInventario.permisoCreacion,
                    ModificacionAListaDePrecios.permisoCreacion,
                    CreditoAPersona.permisoCreacion,
                    TransferenciaDeCtactePersona.permisoCreacion,
                    PlanillaDeCobranza.permisoCreacion,
                    CreditoDeProveedor.permisoCreacion,
                    CanjeDeValores.permisoCreacion,
                    DescuentoDeDocumentosACliente.permisoCreacion,
                    OrdenDeServicio.permisoCreacion,
                    Tramite.permisoCreacion,
                    PlanDeFacturacion.permisoCreacion,
                    DesembolsoDeGiros.permisoCreacion,
                    AplicacionDocumentos.permisoCreacion,
                    MovimientoDeFondoFijo.permisoCreacion,
                    RefinanciacionDeDeudas.permisoCreacion,
                    RendicionDeCobradores.permisoCreacion,
                    TransferenciaCajasSucursal.permisoCreacion,
                    Remision.permisoCreacion,
                    OrdenDeCompra.permisoCreacion,
                    RecalendarizacionMasivaDeudas.permisoCreacion,
                    IngresoDeInsumos.permisoCreacion,
                    EgresoDeProductos.permisoCreacion
                };
            }
        }
        #endregion Flujos

        #region Genero
        public abstract class Genero
        {
            public const string Femenino = "F";
            public const string Masculino = "M";
            public static string GetNombre(string genero)
            {
                if (genero.Equals("M")) return "Masculino";
                if (genero.Equals("F")) return "Femenino";
                return null;
            }
        }
        #endregion Genero

        #region GrupoSanguineo
        public abstract class GrupoSanguineo
        {
            public const string APositivo = "A+";
            public const string ANegativo = "A-";
            public const string ABPositivo = "AB+";
            public const string ABNegativo = "AB-";
            public const string BPositivo = "B+";
            public const string BNegativo = "B-";
            public const string CeroPositivo = "0+";
            public const string CeroNegativo = "0-";
            public const string NoAplica = "N/A";
        }
        #endregion GrupoSanguineo

        #region SiNo
        public abstract class SiNo
        {
            public const string Si = "S";
            public const string No = "N";

            public static string GetNombre(string estado)
            {
                if (estado == Si) return "Si";
                if (estado == No) return "No";
                return null;
            }
            public static string Convertir(bool estado)
            {
                return estado ? Si : No;
            }
            public static bool Convertir(string estado)
            {
                if (estado == Si) return true;
                if (estado == No) return false;

                throw new ArgumentException(string.Format("El valor debe ser {0} o {1}", Si, No));
            }
        }
        #endregion SiNo

        #region ObjetivoBusqueda
        public abstract class ObjetivoBusqueda
        {
            public const string Codigo = "Código";
            public const string Texto = "Texto";
            public const string Flexible = "Flexible";
        }
        #endregion SiNo

        #region FechaFormatoISO
        public const string FechaFormatoISO = "yyyyMMdd";
        #endregion FechaFormatoISO

        #region Paises
        public abstract class Paises
        {
            public const decimal Paraguay = 1;
        }
        #endregion Paises

        #region Monedas
        public abstract class Monedas
        {
            public const decimal Guaranies = 1;
            public const decimal Dolares = 2;
            public const decimal Francos_Suizos = 3;
            public const decimal Euros = 4;
            public const decimal Reales = 5;
        }
        #endregion Monedas

        #region MonedasDeniminaciones
        public abstract class MonedasDenominaciones
        {
            public const decimal Billete = 1;
            public const decimal Moneda = 2;
            public const decimal Cupon = 3;
        }
        #endregion MonedasDeniminaciones

        #region TiposComision
        public abstract class TiposComision
        {
            public const string ComisionPorVenta = "VENTA";
            public const string ComisionPorCobro = "COBRO";
            public const string ComisionPorObjetivo = "OBJETIVO";
        }
        #endregion TiposComision

        #region TiposDocumentoIdentidad
        public abstract class TiposDocumentoIdentidad
        {
            public const string CI = "CI";
            public const string PASAPORTE = "PASAPORTE";
            public const string RUC = "RUC";
        }
        #endregion TiposDocumentoIdentidad

        #region Profesiones
        public abstract class Profesiones
        {
            public const string NoAplica = "N/A";
        }
        #endregion Profesiones

        #region TiposIntervalo
        public abstract class TiposIntervalo
        {
            public const string Horas = "H";
            public const string Dias = "D";
            public const string Semanas = "S";
            public const string Meses = "M";
            public const string Anhos = "A";
        }
        #endregion TiposIntervalo

        #region TextoPoliticasMayusculas
        public class TextoPoliticasMayusculas
        {
            public const int NoCambiar = 0;
            public const int TodoMayusculas = 1;
        }
        #endregion TextoPoliticasMayusculas

        #region TipoImpuesto
        public class TipoImpuesto
        {
            public const int Basico = 1;
            public const int Motos = 2;
            public const int Inmuebles = 3;
        }
        #endregion TipoImpuesto

        #region Tratamientos
        public abstract class Tratamientos
        {
            public const string Senhor = "SR.";
            public const string Senhora = "SRA.";
        }
        #endregion Tratamientos

        #region Errores de oracle
        public abstract class OracleNumeroExcepcion
        {
            public const int UNIQUE_KEY = 1;
            public const int INTEGRITY_CONSTRAINT = 2292;
            public const int ACCION_PROHIBIDA = 20000;
            public const int COMPROBANTE_DUPLICADO = 20003;
            public const int COMPROBANTE_SALTEADO = 20004;

            #region stock
            public const int STOCK_INCONSISTENCIA = 20001;
            public const int STOCK_EXISTENCIA_INSUFICIENTE = 20002;
            #endregion stock

            #region contabilidad
            public const int CONTABILIDAD_NUMERO_DUPLICADO = 20005;
            #endregion contabilidad
        }
        #endregion Errores de oracle

        #region Autonumeraciones o Talonarios
        public abstract class Talonarios
        {
            public enum TipoTalonario : int
            {
                no_usar = 0,
                RECIBO = 1,
                TALONARIO_OFICIAL = 2,
                TALONARIO_INTERNO = 3,
                CHEQUERA = 4,
                RETENCION = 5,
            }
        }
        #endregion Talonarios

        #region TiposPersonas
        public abstract class TiposPersonas
        {
            public const string Fisica = "F";
            public const string Juridica = "J";

            public static string GetNombre(string tipoPersona)
            {
                if (tipoPersona == Fisica) return "Física";
                if (tipoPersona == Juridica) return "Jurídica";

                return null;
            }
        }
        #endregion TiposPersonas

        #region TiposCliente
        public abstract class TiposCliente
        {
            public const decimal NoAplica = 1;
        }
        #endregion TiposCliente

        #region TiposArticuloFinancieroRango
        public enum TiposArticuloFinancieroRango : int
        {
            InteresCorriente = 1,
            GastoAdministrativo = 2,
            Seguro = 3,
            DiasDeGracia = 4,
            Corretaje = 5,
            ComisionAdministrativa = 6,
            BonificacionOrdenCompra = 7,
            DescuentoCancelacionAnticipada = 8,
            OrdenDeCompra = 9,
            MontoPorCuotaBase = 10,
            Otros = 11,
            Mora = 12,
        }
        #endregion TiposArticuloFinancieroRango

        #region TiposArticuloConjunto
        public enum TiposArticuloConjunto : int
        {
            PorDefecto = 0,
            ResultadoBusqueda = 1,
            Recomendado = 2,
            Destacado = 3,
        }
        #endregion TiposArticuloConjunto

        #region TiposRelacionesPersonas
        public abstract class TiposRelacionesPersonas
        {
            public const int Dependiente = 1;
        }
        #endregion TiposRelacionesPersonas

        #region EstadosMorosidad
        public abstract class EstadosMorosidad
        {
            public const decimal NoAplica = 0;
        }
        #endregion EstadosMorosidad

        #region PersonasNivelesCredito
        public abstract class PersonasNivelesCredito
        {
            public const decimal A = 1;
            public const decimal B = 2;
            public const decimal C = 3;
            public const decimal D = 4;
        }
        #endregion PersonasNivelesCredito

        #region TiposMensajesSistema
        public abstract class TiposMensajesSistema
        {
            public const decimal AvisoCliente = 1;
            public const decimal AvisoIT = 2;
            public const decimal AdvertenciaPersona = 3;
            public const decimal AdvertenciaProveedor = 4;
            public const decimal AdvertenciaFuncionario = 5;
            public const decimal AdvertenciaArticulo = 6;
            public const decimal PromocionArticulo = 7;
        }
        #endregion TiposMensajesSistema

        #region AlarmasTiposEnvio
        public abstract class AlarmasTiposEnvio
        {
            public const decimal MensajeDeSistema = 0;
            public const decimal Email = 1;
        }
        #endregion TiposMensajesSistema

        #region TiposCalendario
        public abstract class TiposCalendario
        {
            public const string Mensual = "M";
            public const string Trimestral = "T";
            public const string Cuatrimestral = "C";
            public const string Semestral = "S";

            public static string GetNombre(string calendario)
            {
                if (calendario == Mensual) return "Mensual";
                if (calendario == Trimestral) return "Trimestral";
                if (calendario == Cuatrimestral) return "Cuatrimestral";
                if (calendario == Semestral) return "Semestral";
                return null;
            }
        }
        #endregion TiposCalendario

        #region TiposCredito
        public abstract class TiposCredito
        {
            public const int Frances = 1;
            public const int Aleman = 2;
            public const int Americano = 3;
            public const int InteresDirecto = 4;
        }
        #endregion TiposCredito

        #region CreditosPoliticaFacturacion
        public abstract class CreditosPoliticaFacturacion
        {
            public const int Desembolso = 0;
            public const int Devengamiento = 1;
            public const int Pago = 2;
            public const int NoFacturar = 3;
            public const int CancelacionAnticipada = 4;
        }
        #endregion CreditosPoliticaFacturacion

        #region ArticulosFinancierosPoliticaRangoDias
        public abstract class ArticulosFinancierosPoliticaRangoDias
        {
            public const int DiasRealesHastaVencimiento = 0;
            public const int CantidadCuotasPorTreinta = 1;
        }
        #endregion ArticulosFinancierosPoliticaRangoDias

        #region TiposRetenciones
        public abstract class TiposRetenciones
        {
            public const int IVA = 1;
            public const int Renta = 2;
            public const int SICP = 3;
        }
        #endregion TiposRetenciones

        #region TiposMontosAAplicarRetenciones
        public abstract class TiposMontosAAplicarRetenciones
        {
            public const int IVA = 1;
            public const int TotalSinIVA = 2;
        }
        #endregion TiposMontosAAplicarRetenciones

        #region OrdenPagoRetencionPoliticaContado
        public abstract class OrdenPagoRetencionPoliticaContado
        {
            public const int AgruparPorFecha = 1;
            public const int AgruparPorCaso = 2;
        }
        #endregion OrdenPagoRetencionPoliticaContado

        #region OrdenPagoRetencionPoliticaCredito
        public abstract class OrdenPagoRetencionPoliticaCredito
        {
            public const int AgruparPorDia = 1;
            public const int AgruparPorMes = 2;
        }
        #endregion OrdenPagoRetencionPoliticaCredito

        #region TipoFechaFiltro
        public abstract class TipoFechaFiltro
        {
            public const int RangoDeFecha = 0;
            public const int NDiasAtras = 1;
            public const int RangoDeFechaCreacion = 2;
            public const int NDiasAtrasFechaCreacion = 3;
            public const string StringFechaDesde = "FECHA_DESDE";
            public const string StringFechaHasta = "FECHA_HASTA";
        }
        #endregion TipoFechaFiltro

        #region Estado
        public abstract class Estado
        {
            public const string Activo = "A";
            public const string Inactivo = "I";

            public static string GetNombre(string estado)
            {
                if (estado == Activo) return "Activo";
                if (estado == Inactivo) return "Inactivo";
                return null;
            }
        }
        #endregion Estado

        #region Usuarios
        public abstract class Usuarios
        {
            public const decimal Soporte = 1;
        }
        #endregion Usuarios

        #region EstadosFlujos
        public abstract class EstadosFlujos
        {
            public const string Abierto = "ABIERTO";
            public const string Anulado = "ANULADO";
            public const string Aprobado = "APROBADO";
            public const string Borrador = "BORRADOR";
            public const string Caja = "CAJA";
            public const string Cerrado = "CERRADO";
            public const string Devolucion = "DEVOLUCION";
            public const string Ejecutado = "EJECUTADO";
            public const string EnProceso = "EN-PROCESO";
            public const string EnReparto = "EN-REPARTO";
            public const string EnRevision = "EN-REVISION";
            public const string Generacion = "GENERACION";
            public const string ParaReparto = "PARA-REPARTO";
            public const string Pendiente = "PENDIENTE";
            public const string PreAprobado = "PRE-APROBADO";
            public const string Preparado = "PREPARADO";
            public const string Proforma = "PROFORMA";
            public const string Rechazado = "RECHAZADO";
            public const string Rendicion = "RENDICION";
            public const string Viajando = "VIAJANDO";
            public const string Aplicacion = "APLICACION";
            public const string Vigente = "VIGENTE";

            public static string GetDescripcion(string estadoId)
            {
                switch (estadoId)
                {
                    case Abierto:
                        return "ABIERTO";
                    case Anulado:
                        return "ANULADO";
                    case Aprobado:
                        return "APROBADO";
                    case Borrador:
                        return "BORRADOR";
                    case Caja:
                        return "CAJA";
                    case Cerrado:
                        return "CERRADO";
                    case Devolucion:
                        return "DEVOLUCION";
                    case EnReparto:
                        return "EN-REPARTO";
                    case EnRevision:
                        return "EN-REVISION";
                    case Generacion:
                        return "GENERACION";
                    case ParaReparto:
                        return "PARA-REPARTO";
                    case Pendiente:
                        return "PENDIENTE";
                    case PreAprobado:
                        return "PRE-APROBADO";
                    case Preparado:
                        return "PREPARADO";
                    case Proforma:
                        return "PROFORMA";
                    case Rechazado:
                        return "RECHAZADO";
                    case Rendicion:
                        return "RENDICION";
                    case Viajando:
                        return "VIAJANDO";
                    case Aplicacion:
                        return "APLICACION";
                    case Ejecutado:
                        return "EJECUTADO";
                }
                return null;
            }
        }
        #endregion EstadosFlujos

        #region Stock
        public abstract class Stock
        {
            #region TipoMovimiento
            public abstract class TipoMovimiento
            {
                public const string ExistenciaInicial = "EXISTENCIA_INICIAL";
                public const string Compra = "COMPRA";
                public const string AjustePositivo = "AJUSTE_POSITIVO";
                public const string TransferenciaEntrada = "TRANSFERENCIA_ENTRADA";
                public const string NotaCreditoCliente = "NOTA_CREDITO_CLIENTE";
                public const string NotaDebitoProveedor = "NOTA_DEBITO_PROVEEODR";
                public const string Transito = "TRANSITO";
                public const string Industrializacion = "INDUSTRIALIZACION";
                public const string PuntoMinimo = "PUNTO_MINIMO";
                public const string Venta = "VENTA";
                public const string TransferenciaSalida = "TRANSFERENCIA_SALIDA";
                public const string AjusteNegativo = "AJUSTE_NEGATIVO";
                public const string NotaDebitoCliente = "NOTA_DEBITO_CLIENTE";
                public const string NotaCreditoProveedor = "NOTA_CREDITO_PROVEEDOR";
                public const string CombosCreados = "COMBOS_CREADOS";
                public const string CombosEliminado = "COMBOS_ElIMINADOS";
                public const string UsoDeInsumo = "USO_DE_INSUMO";
                public const string Remision = "REMISION";
                public static string GetAbreviatura(string movimiento)
                {
                    if (movimiento.Equals(ExistenciaInicial))
                        return "Inicial";
                    if (movimiento.Equals(Compra))
                        return "Compra";
                    if (movimiento.Equals(AjustePositivo))
                        return "Ajuste Pos.";
                    if (movimiento.Equals(TransferenciaEntrada))
                        return "Transf.Ent.";
                    if (movimiento.Equals(NotaCreditoCliente))
                        return "NC Cliente";
                    if (movimiento.Equals(NotaDebitoProveedor))
                        return "ND Prov.";
                    if (movimiento.Equals(Transito))
                        return "Transito";
                    if (movimiento.Equals(Industrializacion))
                        return "Industrializ";
                    if (movimiento.Equals(PuntoMinimo))
                        return "Mínimo";
                    if (movimiento.Equals(Venta))
                        return "Venta";
                    if (movimiento.Equals(TransferenciaSalida))
                        return "Transf.Sal.";
                    if (movimiento.Equals(AjusteNegativo))
                        return "Ajuste Neg.";
                    if (movimiento.Equals(NotaDebitoCliente))
                        return "ND Cliente";
                    if (movimiento.Equals(NotaCreditoProveedor))
                        return "NC Prov.";
                    if (movimiento.Equals(CombosCreados))
                        return "Comb.Creado.";
                    if (movimiento.Equals(CombosEliminado))
                        return "Comb.Elim.";
                    if (movimiento.Equals(UsoDeInsumo))
                        return "Uso Ins.";
                    if (movimiento.Equals(Remision))
                        return "Remisión";

                    return string.Empty;
                }
            }
            #endregion TipoMovimiento

            #region Politicas
            public abstract class Politicas
            {
                public const decimal Temprano = 1;
                public const decimal Tardia = 2;
                public const decimal Intermedio = 3;
            }
            #endregion Politicas
        }
        #endregion Stock

        #region Costos
        public abstract class Costos
        {
            public abstract class TipoActualizacion
            {
                public const int Aumentar = 1;
                public const int Disminuir = 2;
            }
        }
        #endregion Costos

        #region UnidadesMedida
        public abstract class UnidadesMedida
        {
            public abstract class Descripcion
            {
                public const string Unidades = "UNIDADES";
                public const string Metros = "METROS";
                public const string Yardas = "YARDAS";
                public const string Pies = "PIES";
                public const string Kilogramos = "KILOGRAMOS";
                public const string Litros = "LITROS";
                public const string Mililitros = "MILILITROS";
                public const string Gramos = "GRAMOS";
            }
            public abstract class Simbolo
            {
                public const string Unidades = "U";
                public const string Metros = "m";
                public const string Yardas = "yd";
                public const string Pies = "ft";
                public const string Kilogramos = "Kg";
                public const string Litros = "lts";
                public const string Mililitros = "ml";
                public const string Gramos = "grs";
            }
        }
        #endregion UnidadesMedida

        #region EncuestasTiposPreguntas
        public abstract class EncuestasTiposPreguntas
        {
            public const int Lista = 1;
            public const int RespuestaUnica = 2;
            public const int RespuestasMultiples = 3;
            public const int SiNo = 4;
            public const int Texto = 5;
            public const int VerdaderoFalso = 6;
        }
        #endregion EncuestasTiposPreguntas

        #region TiposAdjunto
        public abstract class TiposAdjunto
        {
            public const int Indefinido = 1;
            public const int Anexo = 2;
            public const int Fotografia = 3;
            public const int Presupuesto = 4;
        }
        #endregion TiposAdjunto

        #region TiposArancel
        public abstract class TiposArancel
        {
            public const string DerechoExmamen = "DERECHO EXAMEN";
            public const string Matricula = "MATRICULA";
            public const string HoraCatedra = "HORA CATEDRA";
            public const string Certificado = "CERTIFICADO";
            public const string Otros = "OTROS";
        }
        #endregion TiposArancel

        #region TiposEscalaPremios
        public abstract class TiposEscalaPremios
        {
            public const decimal Cobranza = 1;
            public const decimal Venta = 2;
        }
        #endregion TiposEscalaPremios

        #region TiposOrdenesPago
        public abstract class TiposOrdenesPago
        {
            public const int PagoAProveedor = 1;
            public const int ReposicionFondoFijo = 2;
            public const int RespaldoAnticipoProveedor = 3;
            public const int RespaldoCambioDivisa = 4;
            public const int RespaldoTransferenciaBancaria = 5;
            public const int RespaldoTransferenciaTesoreria = 6;
            public const int RespaldoCustodiaValores = 7;
            public const int AdelantoFuncionario = 8;
            public const int PagoFuncionarios = 9;
            public const int RespaldoDescuentoDocumentos = 10;
            public const int RespaldoAjusteBancario = 11;
            public const int PagoAPersona = 12;
        }
        #endregion TiposOrdenesPago

        #region TiposAjusteStock
        public abstract class TiposAjusteStock
        {
            public const int AjustePositivo = 1;
            public const int AjusteNegativo = 2;
        }
        #endregion TiposAjusteStock

        #region TiposDetalleFacturaProveedor
        public abstract class TiposDetalleFacturaProveedor
        {
            public const int Estandar = 1;
            public const int SoloIVA = 2;
        }
        #endregion TiposDetalleFacturaProveedor

        #region CuentaCorrienteValores
        public abstract class CuentaCorrienteValores
        {
            public const int Efectivo = 1;
            public const int Cheque = 2;
            public const int TarjetaDeCredito = 3;
            public const int Pagare = 4;
            public const int Anticipo = 5;
            public const int NotaDeCredito = 6;
            public const int DepositoBancario = 7;
            public const int TransferenciaBancaria = 8;
            public const int OrdenDePago = 9;
            public const int RetencionIVA = 10;
            public const int AjusteBancario = 11;
            public const int DescuentoDocumentos = 12;
            public const int Factura = 13;
            public const int Credito = 14;
            public const int LetraDeCambio = 15;
            public const int TransferenciaCtacte = 16;
            public const int Giro = 17;
            public const int NotaDeDebito = 18;
            public const int Ajuste = 19;
            public const int RetencionRenta = 20;
            public const int RetencionSECP = 21;
            public const int DebitoAutomatico = 22;
            public const int EgresoVarioCaja = 23;
        }
        #endregion CuentaCorrienteValores

        #region CuentaCorrienteConceptos
        public abstract class CuentaCorrienteConceptos
        {
            public const decimal DebitoPorFlujo = 1;
            public const decimal CreditoPorFlujo = 2;
            public const decimal Financiacion = 3;
            public const decimal DebitoPorPago = 4;
            public const decimal CreditoPorPago = 5;
            public const decimal Vuelto = 6;
            public const decimal TransferenciaDeFondoFijo = 7;
            public const decimal DebitoTransferenciaDeCtaCte = 8;
            public const decimal CreditoTransferenciaDeCtaCte = 9;
            public const decimal Compensacion = 10;
            public const decimal Recargo = 11;
            public const decimal EntregaInicial = 12;
            public const decimal EgresoPorTransferencia = 13;
            public const decimal IngresoPorTransferencia = 14;
            public const decimal SaldoCaja = 15;
        }
        #endregion CuentaCorrienteConceptos

        #region CuentaCorrienteCajaSucursalEstados
        public abstract class CuentaCorrienteCajaSucursalEstados
        {
            public const string Abierta = "ABIERTA";
            public const string Cerrada = "CERRADA";
            public const string Remitida = "REMITIDA";
            public const string Aceptada = "ACEPTADA";
        }
        #endregion CuentaCorrienteCajaSucursalEstados

        #region CuentaCorrienteChequesEstados
        public abstract class CuentaCorrienteChequesEstados
        {
            public const decimal AlDia = 1;
            public const decimal Adelantado = 2;
            public const decimal Retenido = 3;
            public const decimal Rechazado = 4;
            public const decimal Incobrable = 5;
            public const decimal Judicial = 6;
            public const decimal Depositado = 7;
            public const decimal Negociado = 8;
            public const decimal Custodia = 9;
            public const decimal Canjeado = 10;
            public const decimal Anulado = 11;
            public const decimal Utilizado = 12;
            public const decimal Efectivizado = 13;
            public const decimal ParaDeposito = 14;
            public const decimal ParaCanje = 15;
        }
        #endregion CuentaCorrienteChequesEstados

        #region Reportes
        public abstract class Reportes
        {
            public const string CrystalExtension = ".rpt";
            public const string LatexExtension = ".tex";
            public const string LatexNamespace = "CBA.FlowV2.Reportes.Reportes.Latex.Templates.";

            public abstract class Entidades //prefijo 1
            {
                public const int Personas = 101;
                public const int Usuarios = 103;
                public const int Productos = 104;
                public const int Proveedores = 105;
                public const int Autonumeraciones = 106;
                public const int Vehiculos = 107;
                public const int ProductosResumido = 108;
                public const int FuncionariosConImagen = 109;
                public const int PerfilesRolesUsuario = 110;
                public const int ListadoArticulos = 111;
                public const int Articulos = 112;
                public const int ArticulosCSV = 113;
            }
            public abstract class Tesoreria //prefijo 2
            {
                public const int CtactePersonas = 201;
                public const int PlanillaCierreCaja = 202;
                public const int CtacteCajasSucursales = 203;
                public const int AnticipoPersonas = 204;
                public const int DepositosBancarios = 205;
                public const int FacturasdePersonas = 206;
                public const int FacturasdePersonasResumido = 207;
                public const int CtacteProveedores = 208;
                public const int Recibo = 209;
                public const int Cotizaciones = 210;
                public const int RecibosEmitidos = 211;
                public const int CotizacionesGrafico = 212;
                public const int ChequesGirados = 213;
                public const int ChequesRecibidos = 214;
                public const int CtactePersonasResumido = 215;
                public const int CtacteBancarias = 216;
                public const int CtacteBancariasResumido = 217;
                public const int OrdenesPago = 218;
                public const int FacturasDeProveedores = 219;
                public const int FacturasDeProveedoresResumido = 220;
                public const int CtacteCajasTesoreria = 221;
                public const int CtacteCajasTesoreriaResumido = 222;
                public const int AjustesBancarios = 223;
                public const int TransferenciasBancarias = 224;
                public const int TransferenciasTesoreria = 225;
                public const int TransferenciasTesoreriaResumido = 226;
                public const int CtacteBancariasExtracto = 227;
                public const int AnticipoProveedores = 228;
                public const int CambiosDivisa = 229;
                public const int CambiosDivisaResumido = 230;
                public const int CtactePagosPersonas = 231;
                public const int CtacteFondosFijos = 232;
                public const int CtacteFondosFijosExtracto = 233;
                public const int MovimientosVariosTesoreria = 234;
                public const int NotasCreditoPersona = 235;
                public const int NotasDebitoPersona = 236;
                public const int EgresosVariosCaja = 237;
                public const int NotasDebitoProveedor = 238;
                public const int NotasCreditoProveedor = 239;
                public const int DescuentoDocumentos = 240;
                public const int CustodiaValores = 241;
                public const int RetencionesEmitidas = 242;
                public const int RetencionesRecibidas = 243;
                public const int Contratos = 244;
                public const int ContratosDetalle = 245;
                public const int FacturasdePersonasImpresion = 246;
                public const int CambiosDivisaFormularioInterno = 247;
                public const int Retencion = 248;
                public const int Pagare = 249;
                public const int CreditosPersonasContrato = 250;
                public const int CreditosPersonasLiquidacion = 251;
                public const int CreditosPersonasJuridicasContrato = 252;
                public const int AnticipoPersonasResumido = 253;
                public const int DepositosBancariosResumido = 254;
                public const int CtacteProveedoresResumido = 255;
                public const int PagarePersonaJuridica = 256;
                public const int CreditoPersonas = 257;
                public const int CreditoPersonasCaso = 304;
                public const int DescuentoDocumentosContratoPersonaFisica = 258;
                public const int DescuentoDocumentosContratoPersonaJuridica = 259;
                public const int NotaCreditoPersonaCaso = 260;
                public const int PlanillaDeCobranza = 261;
                public const int PlanillaDeCobrosRealizados = 262;
                public const int CuentasACobrar = 263;
                public const int OrdenDePagoImpresion = 264;
                public const int SolicitudDeCredito = 265;
                public const int DeudasIncobrables = 266;
                public const int FacturasAgrupadasdePersonasImpresion = 267;
                public const int ListadoCorrelatividadDocumentos = 268;
                public const int PlanillaCierreCajaDetallado = 269;
                public const int CustodiaValoresCaso = 270;
                public const int ChequesPendientesDeposito = 271;
                public const int FacturasdeProveedoresCaso = 272;
                public const int ArqueoFondoFijo = 273;
                public const int CuentasACobrarAnual = 274;
                public const int DepositoBancarioCaso = 275;
                public const int TransferenciaCajasSucursal = 276;
                public const int AjustesBancariosCaso = 277;
                public const int MovimientoFondoFijoCaso = 278;
                public const int CreditoProveedoresCaso = 279;
                public const int TransferenciasBancariasCaso = 280;
                public const int CostosDeVentasPorArticulo = 281;
                public const int ResumenDeCuentasCorrientesDeudoras = 282;
                public const int ChequeraDePagos = 283;
                public const int MovimientoDeCajas = 284;
                public const int EgresoVarioCajaCaso = 285;
                public const int SaldoDeClientes = 286;
                public const int CreditosPersonasLiquidacionAnticipada = 287;
                public const int DescuentoDocumentosCaso = 288;
                public const int DescuentoDocumentosListadoCheques = 289;
                public const int MovimientoVarioTesoreriaCaso = 290;
                public const int VentasPorPeriodo = 291;
                public const int CustodiaValoresListadoCheques = 292;
                public const int TransferenciaCajasTesoreria = 293;
                public const int NotaCreditoProveedoresCaso = 294;
                public const int CajaComposicion = 295;
                public const int GirosExtracto = 296;
                public const int AnticipoProveedorCaso = 297;
                public const int OperacionesPorConcepto = 298;
                public const int AutoFacturasProveedor = 299;
                public const int CuentasACobrarRango = 300;
                public const int PlanillaCobranza = 305;
                public const int PlanesDeFacturacion = 306;
                public const int IntegradoGastos = 307;
                public const int ConsultaCostoMercaderias = 308;
                public const int RecalendarizacionMasivaDeudas = 309;
                public const int Presupuesto = 410;
            }
            public abstract class Auditoria //prefijo 3
            {
                public const int Modificaciones = 301;
                public const int MensajesSistema = 302;
                public const int IniciosSesion = 303;
            }
            public abstract class RRHH //prefijo 4
            {
                public const int Sugerencias = 401;
                public const int Encuestas = 402;
                public const int Descuentos = 403;
                public const int Bonificaciones = 404;
                public const int PlanillasLiquidacionesFiltradas = 405;
                public const int PlanillasLiquidaciones = 406;
                public const int Liquidacion = 407;
                public const int LegajoFuncionario = 408;
                public const int PresupuestosListado = 409;
                public const int LegajoPersona = 411;
                public const int EncuestaRespuestas = 412;
                public const int Funcionarios = 413;
                public const int FuncionariosAdelantos = 414;
                public const int FuncionariosVentasYDevoluciones = 415;
                public const int ReciboSueldo = 416;
                public const int PlanillaComisionesDevueltas = 417;
                public const int PlanillaComisionesGeneradas = 418;
                public const int PlanillaComisionesPorVendedor = 419;
                public const int FuncionariosHorariosAsignados = 420;
                public const int ReciboAdelantoFuncionario = 421;
            }
            public abstract class Stock //prefijo 5
            {
                public const int PedidosPersonas = 501;
                public const int PedidosPersonasResumido = 502;
                public const int StockTransferencias = 503;
                public const int StockTransferenciasResumido = 504;
                public const int StockAjustes = 505;
                public const int StockAjustesResumido = 506;
                public const int StockMovimientos = 507;
                public const int stockMovimientosResumido = 508;
                public const int Repartos = 509;
                public const int RepartosResumido = 510;
                public const int NotaDePedido = 511;
                public const int RollosNotaPedido = 512;
                public const int PedidosClientesGrupos = 513;
                public const int RepartosDetalles = 514;
                public const int StockTransferenciasRemision = 515;
                public const int StockTransferenciasArtciculosListadoControl = 516;
                public const int StockPlanillaParaInventario = 517;
                public const int StockPlanillaDiferenciasInventario = 518;
                public const int ExistenciaStock = 519;
                public const int StockHistoricoValorizado = 520;
                public const int StockHistoricoValorizadoDetallado = 521;
                public const int StockArticulosDetalle = 522;
                public const int UsoDeInsumosCaso = 523;
                public const int UsoDeInsumos = 524;
                public const int IngresoStockCaso = 525;
                public const int IngresoStock = 526;
                public const int AjusteStockCaso = 527;
                public const int ExistenciaUbicacion = 528;
                public const int Remisiones = 529;
                public const int OrdenDeProduccion = 530;
                public const int EgresoProductosListadoCargas = 531;
                public const int OrdenSalidaMercaderia = 532;

            }
            public abstract class Contabilidad //prefijo 6
            {
                public const int PlanCuentas = 601;
                public const int BalanceGeneral = 602;
                public const int BalanceGeneralRes173 = 603;
                public const int LibroVentas = 604;
                public const int LibroDiario = 605;
                public const int LibroMayor = 606;
                public const int LibroIVACompras = 607;
                public const int LibroIVAVentas = 608;
                public const int BalanceSumas = 609;
                public const int BalanceSaldos = 610;
                public const int BalanceComparativo = 611;
                public const int LibroDiarioResumido = 612;
                public const int LibroInventario = 613;
                public const int EstadoDeResultados = 614;
                public const int FlujoDeCaja = 615;
                public const int LibroMayorResumido = 616;
                public const int EjecucionPresupuestaria = 617;
                public const int Devengamientos = 618;
                public const int CuadroDeRevaluoYDepreciacionesDeBienes = 619;
                public const int CasosSinAsiento = 620;
            }
            public abstract class Chequeras //prefijo 7
            {
                public const int ChequeContinentalGuaranies = 701;
                public const int ChequeContinentalDolares = 702;
                public const int ChequeBNFGuaranies = 703;
                //public const int ChequeBNFDolares = 704;
                public const int ChequeFamiliarGuaranies = 705;
                //public const int ChequeFamiliarDolares = 706;
                public const int ChequeItauGuaranies = 707;
                public const int ChequeItauDolares = 708;
                public const int ChequeCitibankGuaranies = 709;
                //public const int ChequeCitibankDolares = 710;
                public const int ChequeVisionGuaranies = 711;
                //public const int ChequeVisionDolares = 712;
                public const int ChequeRegionalGuaranies = 713;
                public const int ChequeRegionalDolares = 714;
                public const int ChequeGNBGuaranies = 715;
                //public const int ChequeGNBDolares = 716;
                public const int ChequeSudamerisGuaranies = 717;
                //public const int ChequeSudamerisDolares = 718;
                public const int ChequeBBVAGuaranies = 719;
                public const int ChequeBBVADolares = 720;
                public const int ChequeAmambayGuaranies = 721;
                //public const int ChequeAmambayDolares = 722;
                public const int ChequeAtlasGuaranies = 722;
                public const int ChequeZamphiropolosGeneral = 723;
            }
            public abstract class Comercial //prefijo 8
            {
                public const int PersonasLineaCreditoGuiadoCredito = 801;
                public const int PersonasLineaCreditoGuiadoLinea = 802;
                public const int ListaPreciosArticulos = 803;
                public const int OrdenServicio = 804;
                public const int OrdenesServicioResumido = 805;
                public const int PlanFacturacion = 806;
                public const int Tramites = 807;
                public const int PresupuestosDevolucionGarantia = 808;
                public const int OrdenesServicioPorTramite = 809;
                public const int ResumenComercialResumido = 811;
                public const int Rendimiento = 812;
                public const int VentasDevoluciones = 813;
                public const int EstadisticasCompras = 814;
                public const int ValorizacionPPP = 815;
                public const int RendicionCobradores = 816;
                public const int GraficoUtilidad = 817;
                public const int VentasPorVendedorPorArticulo = 818;
                public const int OrdenesServicioPorTramiteListado = 819;
                public const int VentasPorVendedorPorValor = 820;
                public const int ListadoFacturasCliente = 821;
                public const int ExplotacionCarteraVendedor = 822;
                public const int EvolucionLineaCreditoCSV = 823;
                public const int PrediccionLineaCreditoCSV = 824;
                public const int VentasPorVendedorPorCliente = 825;
                public const int ObjetivoVendedorPorCliente = 826;
                public const int ResumenComercialDetallado = 827;
                public const int RecibosNoRendidosCobrador = 828;
                public const int NotaEnvio = 829;
                public const int OrdenCompra = 830;
                public const int ComprasVentasConsolidado = 831;
                public const int OrdenesServicioDetalles = 832;
                public const int Transacciones = 833;
                public const int ExplotacionCarteraPorFamilia = 834;
                public const int TramiteCaso = 835;
                public const int InformeGerencial = 836;
                public const int CrmHilos = 837;
                public const int ListaPreciosModificar = 838;
                public const int OrdenesCompraResumido = 839;
                public const int OrdenesCompraDetallado = 840;
            }
            public abstract class PlanillaCheques //prefijo 9
            {
                public const int PlanillaChequesPrueba = 901;
                public const int PlanillaBancoChequesRegional = 902;
            }
            public abstract class Logistica //prefijo 10
            {
                public const int ReciboDeIntercambioEquipos = 1001;
                public const int ComprobanteMovimientoGIO = 1002;
                public const int AutorizacionDeSalidaDeContenedores = 1003;
                public const int ComprobantePesajeBascula = 1004;
                public const int ManifiestoResumido = 1005;
                public const int PreEmbarqueResumido = 1006;
                public const int ListadoMovimientoGio = 1007;
                public const int StockContnedores = 1008;
                public const int IngresoImportacionTerrestre = 1009;
                public const int ItemsIngresosDepositos = 1010;
                public const int BoletaSalidaImportacionTerrestre = 1011;
                public const int SalidaImportacionTerrestre = 1012;
            }
            public class ColumnasCampos
            {
                public static string ValoresString = "dataTable"; //Cuando todos los lugares en duro hayan sido actualizados cambiar el nombre a _valores_string_
                public static string Datos = "datos";
                public static string ValoresDataTable = "_valores_datatable_";
                public static string NombreReporte = "nombreReporte";
            }
            public class Constantes
            {
                public static int MaximoNumeroRowsParaMostrarCSV = 10000;
            }
        }
        #endregion Reportes

        #region TiposReporte
        public abstract class TiposReporte
        {
            public const int Entidades = 1;
            public const int Tesoreria = 2;
            public const int Auditoria = 3;
            public const int RRHH = 4;
            public const int Stock = 5;
            public const int Contabilidad = 6;
            public const int Chequeras = 7;
            public const int Comercial = 8;
            public const int PlanillasCheques = 9;
        }
        #endregion TiposReporte

        #region FormatosReporte
        public abstract class FormatosReporte
        {
            public const int CrystalReports = 1;
            public const int Latex = 2;
            public const int Matricial = 3;
            public const int Chart = 4;
            public const int ExportarTXT = 5;
            public const int JSReport = 6;
            public const int ReportLab = 7;
            public const int JasperReport = 8;
        }
        #endregion FormatosReporte

        #region TiposEventoCalendario
        public abstract class TiposEventoCalendario
        {
            public const string Feriado = "FERIADO";
            public const string Asueto = "ASUETO";
            public const string Reunion = "REUNION";
            public const string Extension_De_Tolerancia = "EXTENSION DE TOLERANCIA";

        }
        #endregion TiposEventoCalendario

        #region Impuestos
        public abstract class Impuestos
        {
            public const decimal IVA_10 = 1;
            public const decimal IVA_5 = 2;
            public const decimal Exenta = 3;
        }
        #endregion Impuestos

        #region TiposMovimientosCaja
        public abstract class TiposMovimientosCaja
        {
            public const string Ingreso = "I";
            public const string Egreso = "E";
        }
        #endregion TiposMovimientosCaja

        #region Tablas
        public abstract class Tablas
        {
            public const string Personas = "PERSONAS";
            public const string Funcionarios = "FUNCIONARIOS";
            public const string Proveedores = "PROVEEDORES";
            public const string PresupuestosDetalles = "PRESUPUESTOS_DETALLE";
            public const string CtaCteRetencionesEmitidas = "CTACTE_RETENCIONES_EMITIDAS";
            public const string Articulos = "ARTICULOS";
            public const string TramitesActividades = "TRAMITES_ACTIVIDADES";
            public const string Ninguna = "Ninguna";
        }
        #endregion Tablas

        #region TipoDatos
        public abstract class TipoDatos
        {
            public const string Numerico = "Numerico";
            public const string Cadena = "Cadena";
            public const string Fecha = "Fecha";
        }
        #endregion TipoDatos

        #region TipoDatoColumna
        public abstract class TipoDatoColumna
        {
            public const string Nvarchar2 = "NVARCHAR2";
            public const string Number = "NUMBER";
            public const string Char = "CHAR";
            public const string Clob = "CLOB";
            public const string Date = "DATE";
            public const string Varchar2 = "VARCHAR2";
            public const string Blob = "BLOB";
            public const string Referencia = "REFERENCIA";
        }
        #endregion TipoDatoColumna

        #region TipoSalario
        public abstract class TipoSalario
        {
            public const int Mensual = 1;
            public const int Jornalero = 2;
            public const int Quincenal = 3;
            public const int Destajo = 4;
            public const int Comisionista = 5;
            public const int Semanal = 6;

            public static string getTipo(int tipo)
            {
                if (tipo == Mensual) return "Mensual";
                if (tipo == Jornalero) return "Jornalero";
                if (tipo == Quincenal) return "Quincenal";
                if (tipo == Destajo) return "Destajo";
                if (tipo == Comisionista) return "Comisionista";
                if (tipo == Semanal) return "Semanal";

                return string.Empty;
            }
        }
        #endregion TipoSalario

        #region TipoAlarma
        public abstract class TipoAlarma
        {
            public const decimal campoValor = 1;
            public const decimal tiempo = 2;
            public const decimal registroNuevo = 3;
            public const decimal sql = 4;
        }
        #endregion TipoAlarma

        #region TipoDeAsociacionCobranza
        public abstract class TipoDeAsociacionCobranza
        {
            public const decimal Directa = 0;
            public const decimal IndirectaPorZonaDeCobranza = 1;
        }
        #endregion TipoDeAsociacionCobranza

        #region TipoRangoAlarma
        public abstract class TipoRangoAlarma
        {
            public const decimal Interior = 1;
            public const decimal Exterior = 2;
            public const decimal Unico = 3;
        }
        #endregion TipoRangoAlarma

        #region Tipos de Legajo
        public abstract class TipoLegajo
        {
            public const int General = 0;
            public const int DePersonas = 1;
            public const int DeProveedores = 2;
            public const int DeActivos = 3;
        }
        #endregion Tipos de Legajo

        #region TipoEntradaLegajo
        public abstract class TipoEntradaLegajo
        {
            public const decimal Ingreso = 1;
            public const decimal IngresoSeguro = 2;
            public const decimal Salida = 3;
            public const decimal Vacaciones = 5;
        }
        #endregion TipoEntradaLegajo

        #region TipoDescuento
        public abstract class TipoDescuento
        {
            public const decimal AdelantoSalario = 1;
            public const decimal Comision = 2;
            public const decimal Penalizacion = 3;
            public const decimal GastoTelefonia = 4;
            public const decimal MovimientoADestiempo = 5;
        }
        #endregion TipoDescuento

        #region TipoBonificacion
        public abstract class TipoBonificacion
        {
            public const decimal Comision = 1;
        }
        #endregion TipoBonificacion

        #region TipoItemLiquidacion
        public abstract class TipoItemLiquidacion
        {
            public const decimal Bonificacion = 1;
            public const decimal Descuento = 2;
            public const decimal CtaCte = 3;
            public const decimal MontoManual = 4;
        }
        #endregion TipoItemLiquidacion

        #region TipoLiquidacion
        public abstract class TipoLiquidacion
        {
            public const int Salario = 1;
            public const int Aguinaldo = 2;
            public const int Despido = 3;
            public const int Complementario = 4;
        }
        #endregion TipoLiquidacion

        #region TipoFactura
        public abstract class TipoFactura
        {
            public const string Credito = "CREDITO";
            public const string Contado = "CONTADO";
        }
        #endregion TipoFactura

        #region TipoFacturaProveedor
        public abstract class TipoFacturaProveedor
        {
            public const decimal Gastos = 1;
            public const decimal CompraArticulos = 2;
            public const decimal PagoTerceros = 3;
            public const decimal GastosDeDespacho = 4;
            public const decimal Autofactura = 5;
        }
        #endregion TipoFacturaProveedor

        #region TipoPanelControl
        public abstract class TipoPanelControl
        {
            public const decimal Gerencia = 1;
            public const decimal ManejoLotes = 2;
            public const decimal Tesoreria = 3;
            public const decimal Comercial = 4;
            public const decimal Varios = 5;
            public const decimal IT = 6;
        }
        #endregion TipoPanelControl

        #region TipoRecargo
        public abstract class TipoRecargo
        {
            public const decimal Mora = 1;
            public const decimal InteresPunitorio = 2;
            public const decimal GastoCobranza = 3;
        }
        #endregion TipoRecargo

        #region PanelControl
        public abstract class PanelControl
        {
            public const int GestionDeCasosPorLote = 1;
            public const int GestionDeChequesRecibidosPorLote = 2;
            public const int GestionCasosAsignados = 3;
            public const int DBActividad = 4;
        }
        #endregion PanelControl

        #region ComboTipoOperacion
        public abstract class ComboTipoOperacion
        {
            public const string Generar = "G";
            public const string Eliminar = "E";
        }
        #endregion ComboTipoOperacion

        #region OrdenOperacion
        public abstract class OrdenOperacion
        {
            public const decimal Subir = 1;
            public const decimal Bajar = 0;
        }
        #endregion OrdenOperacion

        #region TipoContrato
        public abstract class TipoContrato
        {
            public const string Cliente = "C";
            public const string Proveedor = "P";
        }
        #endregion TipoContrato

        #region ContratoEstado
        public abstract class ContratoEstado
        {
            public const string NoIniciado = "No Iniciado";
            public const string EnProceso = "En Proceso";
            public const string Finalizado = "Finalizado";
        }
        #endregion ContratoEstado

        #region CondicionPago
        public abstract class CondicionPago
        {
            public const decimal Contado = 1;
        }

        #endregion CondicionPago

        #region CondicionPagoTipo
        public abstract class CondicionPagoTipo
        {
            public const string CONTADO = "CONTADO";
            public const string CREDITO = "CREDITO";
        }

        #endregion CondicionPago

        #region CondicionPagoTipoCalculo
        public abstract class CondicionPagoTipoCalculo
        {
            public const string Dias = "D";
            public const string Meses = "M";
        }

        #endregion CondicionPagoTipoCalculo

        #region TipoTextoPredefinido
        public abstract class TipoTextoPredefinido
        {
            public const decimal PedidosCliente = 1;
            public const decimal ComentarioCambioEstado = 2;
            public const decimal UsoDeInsumos = 3;
            public const decimal NotasDeCredito = 4;
            public const decimal MotivosBloqueoPersonas = 5;
            public const decimal CreditosTiposIngreso = 6;
            public const decimal CreditosTiposEgreso = 7;
            public const decimal MotivosCasosJudicializados = 8;
            public const decimal OrdenesDeServicio = 9;
            public const decimal AjustesBancarios = 10;
            public const decimal ComentarioCambioEstadoAsignacionUsuario = 11;
            public const decimal MedidaCautelarTipo = 12;
            public const decimal MotivoRechazoCheque = 13;
            public const decimal ComplejidadServicio = 14;
            public const decimal TipoPresupuesto = 15;
            public const decimal AreasDeDerecho = 16;
            public const decimal TipoDeDocumento = 17;
            public const decimal TipoDeMarca = 18;
            public const decimal TipoDeEstimacionResultadoJuicios = 19;
            public const decimal TipoInmueble = 20;
            public const decimal DisponibilidadInmueble = 21;
            public const decimal MotivosAnulacionPedidosCliente = 22;
            public const decimal MedidaCautelarTipoBien = 23;
            public const decimal IngresoFondoFijo = 24;
            public const decimal EgresoFondoFijo = 25;
            public const decimal FacturaProveedorDetalleTipo = 26;
            public const decimal NotasDeCreditoProveedor = 27;
            public const decimal TransferenciaBancaria = 28;
            public const decimal MovimientosVariosTesoreria = 29;
            public const decimal AsignacionDocumentos = 30;
            public const decimal ComposicionMonedaAumenta = 31;
            public const decimal ComposicionMonedaDisminuye = 32;
            public const decimal ComposicionMonedaPendientes = 33;
            public const decimal DepositoBancario = 34;
            public const decimal TransferenciasCajaSucursal = 35;
            public const decimal CasosEtiquetas = 36;
            public const decimal Personas = 37;
            public const decimal DepositoBancarioDetalle = 38;
            public const decimal ArticulosEtiquetas = 39;
            public const decimal GruposContables = 40;
            public const decimal OrdenesPago = 41;
            public const decimal PagosPersona = 42;
            public const decimal TransferenciaArticulos = 43;
            public const decimal CajaSucursalReservas = 44;
            public const decimal TramitesActividadesTipoActividad = 45;
            public const decimal CRMHilos = 46;
            public const decimal LogisticaBoletaSalidaReimpresion = 47;
            public const decimal AnticiposPersona = 48;
            public const decimal Remisiones = 49;
            public const decimal IngresoStock = 50;
            public const decimal AjusteStock = 57;
        }
        #endregion TipoTextoPredefinido

        #region TextoPredefinido
        public abstract class TextoPredefinido
        {
            public abstract class MotivosBloqueoPersonas
            {
                public const string LineaCreditoTemporal = "Linea de Credito Temporal";
            }
            public abstract class AjustesBancarios
            {
                public const string ChequeRechazado = "Cheque Rechazado";
            }
            public abstract class NotasCredito
            {
                public const string Migracion = "Migración";
            }
            public abstract class AnticiposPersonas
            {
                public const string VueltoConvertidoAAnticipo = "Vuelto convertido a anticipo";
            }
        }
        #endregion TextoPredefinido

        #region TipoRedondeo
        public abstract class TipoRedondeo
        {
            public const decimal SinRedondeo = 0;
            public const decimal RedondeoParaAbajo = 1;
            public const decimal RedondeoParaArriba = 2;
            public const decimal RedondeoEstandar = 3;
        }
        #endregion TipoRedondeo

        #region TipoCosto
        public abstract class TipoCosto
        {
            public const decimal Fifo = 0;
            public const decimal Ponderado = 1;
            public const decimal Lifo = 2;
        }
        #endregion TipoCosto

        #region AfectarStock
        public abstract class AfectarStock
        {
            public const decimal PorFacturaProveedor = 0;
            public const decimal PorIngresoStock = 1;
        }
        #endregion AfectarStock

        #region EstadosDocumentacion
        public abstract class EstadosDocumentacion
        {
            public const decimal EnOrden = 1;
            public const decimal FaltaRegistroFirma = 2;
            public const decimal FaltanDocumentos = 3;
        }
        #endregion

        #region TipoCuentaBancaria
        public abstract class TipoCuentaBancaria
        {
            public const decimal Normal = 1;
            public const decimal Directivo = 2;
        }
        #endregion TipoCuentaBancaria

        #region TipoEDI
        public abstract class TipoEDI
        {
            public const string CODECO = "CODECO";
            public const string COARRI = "COARRI";
        }
        #endregion TipoEDI

        #region AccionPorLote
        public abstract class AccionPorLote
        {
            public const int CambiarEstado = 1;
            public const int Borrar = 2;
            public const int CrearCasoDepositoBancario = 3;
            public const int CrearCasoDescuentoDocumentos = 4;
            public const int CrearCasoCustodiaValores = 5;
            public const int CrearCasoMovimientoVarioCajaTesoreria = 6;
            public const int CrearCasoTransferenciaCajaTesoreria = 7;
            public const int Efectivizar = 8;
            public const int AsignarFuncionario = 9;
            public const int CrearCasoCanjeValores = 10;
            public const int Rechazar = 11;
            public const int AsignarCustodiaDocumentos = 12;
            public const int Imprimir = 13;
            public const int CambiarFecha = 14;
            public const int GenerarFacturaProveedor = 15;
            public const int GenerarOP = 16;
            public const int ImprimirRecibo = 17;
            public const int ImprimirCheque = 18;
            public const int DescargarFormatoBancoChequeGirado = 19;
        }
        #endregion TipoCuentaBancaria

        #region TipoEmpleoPersona
        public abstract class TipoEmpleoPersona
        {
            public const string Privado = "PRI";
            public const string Publico = "PUB";
            public const string Mixto = "MIX";
        }
        #endregion TipoEmpleoPersona

        #region EstadosDeposito
        public abstract class EstadosDeposito
        {
            public const string ParaPreparar = "PARA_PREPARAR";
            public const string Asignado = "ASIGNADO";
            public const string EnPreparacion = "EN_PREPARACION";
            public const string Preparado = "PREPARADO";
        }
        #endregion EstadosDeposito

        #region Clientes
        public abstract class Clientes
        {
            public const int CBA = 1;
            public const int CGL = 2;
            public const int Inmobiliaria = 3;
            public const int ACredito = 4;
            public const int ServiciosJuridicos = 5;
            public const int Minipymes = 6;
            public const int ElectrobanSolucionEfectiva = 7;
            public const int Zapping = 8;
            public const int Electroban = 9;
            public const int AT = 10;
            public const int Biggie = 11;
            public const int TyC = 12;
            public const int Documenta = 13;
            public const int cidesa = 14;
            public const int connecting = 15; // Pertenece a Cidesa
            public const int PST = 16; // Puerto Seguro Terrestre
            public const int PSF = 17; // Puerto Seguro Fluvial
            public const int LaVeronica = 18; // Pertenece a PSF - PST
            public const int SolucionesInmobiliarias = 19; // Pertenece a PSF - PST
            public const int ParaguayOnlineShopping = 20;
            public const int ConsumerInsights = 21;
            public const int MarianaMendelzon = 22;
            public const int Apro = 23;
            public const int ParaguayMovil = 24;
            public const int Autotec = 25;
            public const int CentroImport = 26;
            public const int MRKostianovsky = 27;
            public const int Telexpar = 28;
            public const int Mottsa = 29;
            public const int Rolding = 30;
            public const int CasaRica = 31;
        }
        #endregion Clientes

        #region Tipos de Sub entradas Legajo de Personas
        public abstract class TiposSubEntradasConfiguraciones
        {
            public abstract class ColumnasNombresTablaTipos
            {
                public const string IdNombreCol = "ID";
                public const string DescripcionNombreCol = "DESCRIPCION_TIPO";
            }

            public abstract class ColumnasNombresTablaMes
            {
                public const string IdNombreCol = "ID";
                public const string DescripcionNombreCol = "DESCRIPCION_MES";
            }
            public abstract class IdTipos
            {
                public const decimal IdDia = 1;
                public const decimal IdMes = 2;
                public const decimal IdAnho = 3;
                public const decimal IdHora = 4;
                public const decimal IdMonto = 5;
            }
            public static DataTable GetTablaTipos()
            {
                //
                // Here we create a DataTable with two columns.
                //
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("DESCRIPCION_TIPO", typeof(string));
                //
                // Here we add five DataRows.
                //
                table.Rows.Add(1, "DIA");
                table.Rows.Add(2, "MES");
                table.Rows.Add(3, "AÑO");
                table.Rows.Add(4, "HORA");
                table.Rows.Add(5, "MONTO");
                return table;
            }
            public static DataTable GetTablaTiposMes()
            {
                //
                // Here we create a DataTable with two columns.
                //
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("DESCRIPCION_MES", typeof(string));
                //
                // Here we add five DataRows.
                //
                table.Rows.Add(1, "ENERO");
                table.Rows.Add(2, "FEBRERO");
                table.Rows.Add(3, "MARZO");
                table.Rows.Add(4, "ABRIL");
                table.Rows.Add(5, "MAYO");
                table.Rows.Add(6, "JUNIO");
                table.Rows.Add(7, "JULIO");
                table.Rows.Add(8, "AGOSTO");
                table.Rows.Add(9, "SEPTIEMBRE");
                table.Rows.Add(10, "OCTUBRE");
                table.Rows.Add(11, "NOVIEMBRE");
                table.Rows.Add(12, "DICIEMBRE");

                return table;
            }
        }
        #endregion Tipos de Sub entredas Legajo de Personas

        #region TiposDetallesPersonalizado
        public abstract class TiposDetallesPersonalizado
        {
            public const decimal Direccion = 1;
            public const decimal ReferenciasCreditoTerceros = 2;
            public const decimal ReferenciasPersonales = 3;
            public const decimal ProveedorPersonaAutorizada = 4;
            public const decimal SolicitudReferenciaProveedor = 5;
            public const decimal ProveedorPuedePedirReferencias = 6;
            public const decimal ReferenciasLaborales = 7;
            public const decimal BuscarAlquilar = 8;
        }
        #endregion TiposDetallesPersonalizado

        #region CiclosFacturacion
        public abstract class CiclosFacturacion
        {
            public const decimal Anual = 1;
            public const decimal Mensual = 2;
            public const decimal Semanal = 3;
            public const decimal Diario = 4;
        }
        #endregion CiclosFacturacion

        #region EstadosCivil
        public abstract class EstadosCivil
        {
            public const string Soltero = "SOLTERO";
            public const string Soltera = "SOLTERA";
            public const string Casado = "CASADO";
            public const string Casada = "CASADA";
        }
        #endregion EstadosCivil

        #region TipoFuncionarioComision
        public abstract class TipoFuncionarioComision
        {
            public const string Promotor = "PROMOTOR";
            public const string Vendedor = "VENDEDOR";
            public const string Cobrador = "COBRADOR";
            public const string CobradorExterno = "COBRADOR EXTERNO";
            public const string Depositero = "DEPOSITERO";
            public const string Chofer = "CHOFER";

            public static string[] Tipos = new string[] { Promotor, Vendedor, Cobrador, CobradorExterno, Depositero, Chofer };
        }
        #endregion TipoFuncionarioComision

        #region DiasSemana
        public abstract class DiasSemana
        {
            public static string Lunes_Nombre = "LUNES";
            public static string Martes_Nombre = "MARTES";
            public static string Miercoles_Nombre = "MIERCOLES";
            public static string Jueves_Nombre = "JUEVES";
            public static string Viernes_Nombre = "VIERNES";
            public static string Sabado_Nombre = "SABADO";
            public static string Domingo_Nombre = "DOMINGO";
        }
        #endregion DiasSemana

        #region CalificacionMarcaciones
        public abstract class CalificacionMarcaciones
        {
            public static int Indefinido = 0;
            public static int ATiempo = 1;
            public static int EnMargen = 2;
            public static int ADestiempo = 3;
        }
        #endregion EstadosMarcaciones

        #region TipoMovimientoMarcaciones
        public abstract class TipoMovimientoMarcaciones
        {
            public static string Entrada = "E";
            public static string Salida = "S";
            public static string Otros = "O";
        }
        #endregion TipoMovimientoMarcaciones

        #region TiposOperacion
        public abstract class TiposOperacion
        {
            public static int DocumentoAnexado = 1;
            public static int DocumentoBorrado = 2;
            public static int Comentario = 3;
            public static int CasoCreado = 4;
            public static int Transicion = 5;
        }
        #endregion TiposOperacion

        #region TiposGeneracionAutonumeraciones
        public abstract class TiposGeneracionAutonumeraciones
        {
            public static string Automatico_Nombre = "AUTOMATICO";
            public static string Manual_Nombre = "MANUAL";
        }
        #endregion TiposGeneracionAutonumeraciones

        #region Webservices
        public abstract class Webservices
        {
            public static int Watchdog = 1;
            public static int PlanesFacturacionGenerarFacturas = 2;
            public static int AsientosAutomaticosGenerarPorTransicion = 3;
            public static int AsientosAutomaticosGenerarPorChequeRecibidoCambioEstado = 4;
            public static int EvaluarAlarmas = 5;
            public static int EntidadesPersonasCrearPersona = 6;
            public static int CtacteRecibosEmitidosCrear = 7;
            public static int EntidadesFuncionariosCrearFuncionario = 8;
            public static int FacturasProveedoresCrear = 9;
            public static int CtactePagosDePersonasRedDePagosCrear = 10;
            public static int EntidadesPersonasModificarDatosPersona = 11;
            public static int EntidadesAutonumeracionesActualizarFechaFin = 12;
            public static int CreditosCrear = 13;
            public static int EntidadesFuncionariosModificarDatosFuncionario = 14;
            public static int EntidadesFuncionariosGetIdPorNroDocumento = 15;
            public static int EntidadesFuncionariosGetIdPorCodigo = 16;
            public static int EntidadesPersonasGetIdPorNroDocumento = 17;
            public static int EntidadesPersonasGetIdPorCodigo = 18;
            public static int EntidadesProveedoresGetIdPorNroDocumento = 19;
            public static int EntidadesProveedoresGetIdPorCodigo = 20;
            public static int EntidadesDispositivosLogin = 21;
            public static int EntidadesUsuariosSucursales = 22;
            public static int CasosGetPorFlujoYSucursal = 23;
            public static int EntidadesFlujos = 24;
            public static int ConfiguracionesGetFiltros = 25;
            public static int ConfiguracionesGuardarFiltro = 26;
            public static int CasosGetFlujoCaja = 27;
            public static int ConfiguracionesBorarFiltro = 28;
            public static int StockSeguimientoArticulo = 29;
            public static int AutomatizacionTareasProgramadas = 30;
            public static int LogisticaBuquesIntercambiosContenedoresPendientes = 31;
            public static int RolesTiene = 32;
            public static int LosgiticaGetContenedoresPendientesPorIntercambio = 33;
            public static int LogisticaIntercambiosNoFinalizadosPorBuque = 34;
            public static int LogisticaCrearIntercambioEquipos = 35;
            public static int LogisticaContenedoresIncluidosIntercambio = 36;
            public static int LogisticaGetDetallesContenedor = 37;
            public static int LogisticaGuardaDetallesContenedor = 38;
            public static int EntidadesComentariosGetCaso = 39;
            public static int EntidadesComentariosGetId = 40;
            public static int FacturasClientesCrear = 41;
            public static int EntidadesComentariosCrear = 42;
            public static int EntidadesFichaGet = 43;
            public static int LogisticaGetMovimientosGIO = 44;
            public static int LogisticaGetContenedorPorNumero = 45;
            public static int LogisticaGuardarContenedor = 46;
            public static int LogisticaGetMovimientoPuerta = 47;
            public static int LogisticaGuardarMovimiento = 48;
            public static int EntidadesFichaSet = 49;
            public static int LogisticaGetDatosParaContenedores = 50;
            public static int LogisticaGetNombreChofer = 51;
            public static int CTBPlanesCuentasGet = 52;
            public static int CTBEjerciciosGet = 53;
            public static int CTBCuentasGet = 54;
            public static int CTBCuentasSumaGet = 55;
            public static int CtactePersonasGet = 56;
            public static int LogisticaGetConfiguracionesTara = 57;
            public static int StockCatalogosDetallesGet = 58;
            public static int EntidadesRedesSocialesAuthInteractuar = 59;
            public static int LogisticaGuardarTaraCamion = 60;
            public static int LogisticaPesoDesdeBascula = 61;
            public static int LogisticaGetPuertos = 62;
            public static int LogisticaGetBasculas = 63;
            public static int LogisticasEnviarInformes = 64;
            public static int LogisticaGetOperacionesContenedores = 65;
            public static int LogisticaGetOperacionPorId = 66;
            public static int LogisticaGuardarOperacion = 67;
            public static int CreditosGetValoresFinancieros = 68;
            public static int EntidadesLogin = 69;
            public static int LogisticaLeerCoparn = 70;
            public static int TransferenciaStockCrear = 71;
            public static int EntidadesArticulosLoteCrear = 72;
            public static int EntidadesVehiculosGet = 73;
            public static int EntidadesActivosGet = 74;
            public static int EntidadesInmuebleGetPorId = 75;
            public static int EntidadesVehiculoGetPorId = 76;
            public static int CasoRequisitoFlujoSet = 77;
            public static int EntidadesPersonaBuscar = 78;
            public static int RefinanciacionDeudasCrear = 79;
            public static int AsientosAutomaticosGenerarPorTransicionRest = 80;
            public static int EntidadesRolesGet = 81;
            public static int ContabilidadAsientosBorrar = 82;
            public static int LogisticaGetListadoIngresoImportTerrestre = 83;
            public static int LogisticaGuardarIngresoImportTerrestre = 84;
            public static int LogisticaGetIngresoImportTerrestre = 85;
            public static int LogisticaGetTiposVehiculos = 86;
            public static int ContabilidadAsientosBuscar = 92;
            public static int ContabilidadEDIGuardar = 94;
            public static int ContabilidadEDIEliminar = 95;
            public static int ArticulosFamiliasBuscar = 96;
            public static int ArticulosFamiliasGuardar = 97;
            public static int ArticulosFamiliasInactivar = 98;
            public static int ArticulosGruposBuscar = 99;
            public static int ArticulosGruposGuardar = 100;
            public static int ArticulosGruposInactivar = 101;
            public static int ArticulosSubgruposBuscar = 102;
            public static int ArticulosSubgruposGuardar = 103;
            public static int ArticulosSubgruposInactivar = 104;
        }
        #endregion Webservices

        #region Contabilidad
        public abstract class Contabilidad
        {
            #region TiposAsientosAutomaticosRelacionesColumnaPrioridad
            public abstract class TiposAsientosAutomaticosRelacionesColumnaPrioridad
            {
                public const int Moneda = 1;
                public const int Sucursal = 2;
                public const int StockDeposito = 3;
                public const int CtacteBancaria = 4;
                public const int Proveedor = 5;
                public const int Persona = 6;
                public const int Funcionario = 7;
                public const int ArticuloFamilia = 8;
                public const int ArticuloGrupo = 9;
                public const int ArticuloSubGrupo = 10;
                public const int Articulo = 11;
                public const int CtacteValor = 12;
                public const int TextoPredefinido = 13;
                public const int FondoFijo = 14;
                public const int TipoNotaCredito = 15;
                public const int TipoCliente = 16;
                public const int FuncionarioBonificacion = 17;
                public const int FuncionarioDescuento = 18;
                public const int Rubro = 19;
                public const int PersonaRelacionada = 20;
                public const int CanalDeVenta = 21;
                public const int CtaCteCajaTesoreria = 22;
                public const int ActivoRubro = 23;
                public const int Impuesto = 24;
                public const int ProveedorRelacionado = 25;
                public const int ProcesadoraTarjeta = 26;

                public static DataTable GetDataTable()
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(decimal));
                    dt.Columns.Add("nombre", typeof(string));

                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ActivoRubro, "Activo Rubro");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ArticuloFamilia, "Artículo Familia");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ArticuloGrupo, "Artículo Grupo");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ArticuloSubGrupo, "Artículo Sugrupo");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Articulo, "Artículo");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.CanalDeVenta, "Canal de Venta");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.CtacteBancaria, "Cuenta Bancaria");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.CtaCteCajaTesoreria, "Caja Tesoreria");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.StockDeposito, "Depósito de Stock");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.FondoFijo, "Fondo Fijo");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Funcionario, "Funcionario");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Impuesto, "Impuesto");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Moneda, "Moneda");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Persona, "Persona");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.PersonaRelacionada, "Persona Relacionada");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ProcesadoraTarjeta, "Procesadora TC");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Proveedor, "Proveedor");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.ProveedorRelacionado, "Proveedor Relacionado");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Sucursal, "Sucursal");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.CtacteValor, "Tipo Valor");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.TextoPredefinido, "Texto Predefinido");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.TipoNotaCredito, "Tipo de Nota de Crédito");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.TipoCliente, "Tipo de Cliente");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.FuncionarioBonificacion, "Funcionario Bonificación");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.FuncionarioDescuento, "Funcionario Descuento");
                    dt.Rows.Add(Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesColumnaPrioridad.Rubro, "Rubro");

                    return dt;
                }
            }
            #endregion TiposAsientosAutomaticosRelacionesColumnaPrioridad

            #region TiposAsientosAutomaticosRelacionesCentroCostoPrioridad
            public abstract class TiposAsientosAutomaticosRelacionesCentroCostoPrioridad
            {
                public const int DefinidoPorUsuario = 1;
                public const int Sucursal = 2;
                public const int Region = 3;
                public const int Persona = 4;
                public const int Funcionario = 5;
                public const int Proveedor = 6;
                public const int Deposito = 7;
                public const int Articulo = 8;
                public const int TextoPredefinido = 9;
                public const int Activo = 10;
                public const int SucursalRelacionada = 11;

                public static DataTable GetDataTable()
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(decimal));
                    dt.Columns.Add("nombre", typeof(string));

                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.DefinidoPorUsuario, "Definido por Usuario");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Sucursal, "Sucursal");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.SucursalRelacionada, "Sucursal Relacionada");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Region, "Región");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Persona, "Persona");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Funcionario, "Funcionario");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Proveedor, "Proveedor");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Deposito, "Depósito");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Articulo, "Artículo");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.TextoPredefinido, "Texto Predefinido");
                    dt.Rows.Add((decimal)Definiciones.Contabilidad.TiposAsientosAutomaticosRelacionesCentroCostoPrioridad.Activo, "Activo");

                    return dt;
                }
            }
            #endregion TiposAsientosAutomaticosRelacionesCentroCostoPrioridad

            #region AsientosAutomaticosAcciones
            public abstract class AsientosAutomaticos
            {
                public const int StockTransferencia_Aprobado_a_Viajando = 1;
                public const int StockTransferencia_EnRevision_a_Cerrado = 2;
                public const int TransferenciaBancaria_Aprobado_a_Cerrado = 3;
                public const int FCProveedores_EnRevision_a_Aprobado = 4;
                public const int FCProveedores_Pendiente_a_Aprobado = 5;
                public const int IngresoStock_Pendiente_a_Aprobado = 6;
                public const int DepositoBancario_PreAprobado_a_Aprobado = 7;
                public const int FCClientes_Pendiente_a_Caja = 8;
                public const int FCClientes_EnReparto_a_Caja = 9;
                public const int FCClientes_Caja_a_Anualdo = 10;
                public const int NotaDebitoPersona_Pendiente_a_Aprobado = 11;
                public const int NotaDebitoProveedor_Pendiente_a_Aprobado = 12;
                public const int PagoDePersonas_Borrador_a_Aprobado = 13;
                public const int AjusteStock_Pendiente_a_Aprobado = 14;
                public const int UsoDeInsumos_Pendiente_a_Aprobado = 15;
                public const int NotaCreditoPersona_PreAprobado_a_Aprobado = 16;
                public const int NotaCreditoProveedor_Pendiente_a_Aprobado = 17;
                public const int AnticipoProveedor_Aprobado_a_Aplicacion = 18;
                public const int AnticipoPersona_Pendiente_a_Aprobado = 19;
                public const int OrdenDePago_Aprobado_a_Generacion = 20;
                public const int OrdenDePago_Generacion_a_Anulado = 21;
                public const int OrdenDePago_Generacion_a_Cerrado = 22;
                public const int AjusteBancario_Aprobado_a_Cerrado = 23;
                public const int MovimientoFondoFijo_Pendiente_a_Aprobado = 24;
                public const int MovimientoVarioTesoreria_Pendiente_a_Aprobado = 25;
                public const int EgresoVarioCaja_Pendiente_a_Aprobado = 26;
                public const int TransferenciaCajasSucursal_EnProceso_a_Cerrado = 27;
                public const int MovimientoVarioTesoreria_Aprobado_a_Anulado = 28;
                public const int CreditoProveedor_Pendiente_a_Aprobado = 29;
                public const int AplicacionDocumentos_Pendiente_a_Aprobado = 30;
                public const int TransferenciaCuentaCorriente_Pendiente_a_Aprobado = 31;
                public const int OrdenDePago_Aprobado_a_Generacion_UNIFICADO = 32;
                public const int OrdenDePago_Generacion_a_Anulado_UNIFICADO = 33;
                public const int PlanillaLiquidaciones_Pendiente_a_Aprobado = 34;
                public const int PagoDePersonas_Aprobado_a_Borrador = 35;
                public const int FCProveedores_Aprobado_a_Pendiente = 36;
                public const int CreditoCliente_Aprobado_a_Vigente = 37;
                public const int CreditoCliente_EnRevision_a_Vigente = 38;
                public const int Remisiones_Pendiente_a_Aprobado = 39;
                public const int Remisiones_Aprobado_a_Anulado = 40;

                public const int ChequeRecibido_Adelantado_a_AlDia = 1001;
                public const int ChequeRecibido_AlDia_a_Efectivizado = 1002;
                public const int ChequeRecibido_Custodia_a_Depositado = 1003;
                public const int ChequeRecibido_Negociado_a_Depositado = 1004;
                public const int ChequeRecibido_Depositado_a_Rechazado = 1005;
                public const int DevengamientoCreado = 1006;
                public const int RevaluoDepreciacion = 1007;
            }
            #endregion AsientosAutomaticosAcciones

            #region AsientosAutomaticosDetalle
            public abstract class AsientosAutomaticosDetalle
            {
                #region StockTransferencia_Aprobado_a_Viajando
                public abstract class StockTransferencia_Aprobado_a_Viajando
                {
                    public const int Activo_AumentarMercaderiaEnTransito = 101;
                    public const int Activo_DisminuirMercaderiaSaliente = 102;
                }
                #endregion StockTransferencia_Aprobado_a_Viajando

                #region StockTransferencia_EnRevision_a_Cerrado
                public abstract class StockTransferencia_EnRevision_a_Cerrado
                {
                    public const int Activo_AumentarMercaderiaEntrante = 201;
                    public const int Activo_DisminuirMercaderiaEnTransito = 202;
                }
                #endregion StockTransferencia_EnRevision_a_Cerrado

                #region TransferenciaBancaria_Aprobado_a_Cerrado
                public abstract class TransferenciaBancaria_Aprobado_a_Cerrado
                {
                    public const int Activo_AumentarBancoCuentaDestino = 301;
                    public const int Pasivo_AumentarCuentasAPagar = 302;
                    public const int Egreso_AumentarGastosGeneralesPorGastoTransaccion = 303;
                    public const int Activo_DisminuirBancoCuentaOrigen = 304;
                    public const int Activo_AumentarAnticiposATercerosACobrar = 305;
                }
                #endregion TransferenciaBancaria_Aprobado_a_Cerrado

                #region FCProveedores_EnRevision_a_Aprobado
                public abstract class FCProveedores_EnRevision_a_Aprobado
                {
                    public const int Activo_AumentarMercaderiaEnProceso = 401;
                    public const int Egreso_AumentarGastosEnProceso = 402;
                    public const int Activo_AumentarCreditoFiscal5 = 403;
                    public const int Activo_AumentarCreditoFiscal10 = 404;
                    public const int Pasivo_AumentarProveedoresLocales = 405;
                    public const int Pasivo_AumentarProveedoresExterior = 406;
                    public const int Ingreso_AumentarDescuentosObtenidos = 407;
                    public const int Activo_AumentarMercaderia = 408;
                    public const int Activo_AumentarClientes = 409;
                    public const int Activo_AumentarPagosARecuperar = 410;
                    public const int Activo_AumentarCajaPorPagosTercerosPorCreditoFiscal = 411;
                    public const int Pasivo_AumentarProveeodoresPorPagosTercerosPorCreditoFiscal = 412;
                    public const int Pasivo_AumentarCuandoNoAfectaCtacte = 413;
                }
                #endregion FCProveedores_EnRevision_a_Aprobado

                #region FCProveedores_Pendiente_a_Aprobado
                public abstract class FCProveedores_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarMercaderiaEnProceso = 501;
                    public const int Egreso_AumentarGastosEnProceso = 502;
                    public const int Activo_AumentarCreditoFiscal5 = 503;
                    public const int Activo_AumentarCreditoFiscal10 = 504;
                    public const int Pasivo_AumentarProveedoresLocales = 505;
                    public const int Pasivo_AumentarProveedoresExterior = 506;
                    public const int Ingreso_AumentarDescuentosObtenidos = 507;
                    public const int Activo_AumentarMercaderia = 508;
                    public const int Activo_AumentarClientes = 509;
                    public const int Activo_AumentarPagosARecuperar = 510;
                    public const int Activo_AumentarCajaPorPagosTercerosPorCreditoFiscal = 511;
                    public const int Pasivo_AumentarProveeodoresPorPagosTercerosPorCreditoFiscal = 512;
                    public const int PagoContratista = 513;
                    public const int PagoContratistaFondoReparo = 514;
                    public const int AumentarPagosEnProceso = 515;
                }
                #endregion FCProveedores_Pendiente_a_Aprobado

                #region FCProveedores_Aprobado_a_Pendiente
                public abstract class FCProveedores_Aprobado_a_Pendiente
                {
                    public const int Activo_DisminuirMercaderiaEnProceso = 3601;
                    public const int Egreso_DisminuirGastosEnProceso = 3602;
                    public const int Activo_DisminuirCreditoFiscal5 = 3603;
                    public const int Activo_DisminuirCreditoFiscal10 = 3604;
                    public const int Pasivo_DisminuirProveedoresLocales = 3605;
                    public const int Pasivo_DisminuirProveedoresExterior = 3606;
                    public const int Ingreso_DisminuirDescuentosObtenidos = 3607;
                    public const int Activo_DisminuirMercaderia = 3608;
                    public const int Activo_DisminuirClientes = 3609;
                    public const int Activo_DisminuirPagosARecuperar = 3610;
                    public const int Activo_DisminuirCajaPorPagosTercerosPorCreditoFiscal = 3611;
                    public const int Pasivo_DisminuirProveeodoresPorPagosTercerosPorCreditoFiscal = 3612;
                    public const int PagoContratista = 3613;
                    public const int PagoContratistaFondoReparo = 3614;
                    public const int DisminuirPagosEnProceso = 3615;

                }
                #endregion FCProveedores_Aprobado_a_Pendiente

                #region IngresoStock_Pendiente_a_Aprobado
                public abstract class IngresoStock_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarMercaderia = 601;
                    public const int Activo_DisminuirMercaderiaEnProceso = 603;
                }
                #endregion IngresoStock_Pendiente_a_Aprobado

                #region DepositoBancario_PreAprobado_a_Aprobado
                public abstract class DepositoBancario_PreAprobado_a_Aprobado
                {
                    public const int Activo_AumentarBancos = 701;
                    public const int Activo_DisminuirCajaTesoreria = 702;
                    public const int Activo_DisminuirCajaSucursal = 703;
                }
                #endregion DepositoBancario_PreAprobado_a_Aprobado

                #region FCClientes_Pendiente_a_Caja
                public abstract class FCClientes_Pendiente_a_Caja
                {
                    public const int Activo_AumentarClientes = 801;
                    public const int Activo_AumentarRecaudacionesEnProceso = 802;
                    public const int Egreso_AumentarDescuentosRealizados = 803;
                    public const int Ingreso_AumentarIngresoPorVentaContado = 804;
                    public const int Pasivo_AumentarDebitoFiscal5 = 805;
                    public const int Pasivo_AumentarDebitoFiscal10 = 806;
                    public const int Egreso_AumentarCostoPorVenta = 807;
                    public const int Activo_DisminuirMercaderias = 808;
                    public const int PrestamosAClientes = 809;
                    public const int InteresesACobrar = 810;
                    public const int Ingreso_AumentarIngresoPorVentaCredito = 811;
                }
                #endregion FCClientes_Pendiente_a_Caja

                #region FCClientes_EnReparto_a_Caja
                public abstract class FCClientes_EnReparto_a_Caja
                {
                    public const int Activo_AumentarClientes = 901;
                    public const int Activo_AumentarRecaudacionesEnProceso = 902;
                    public const int Egreso_AumentarDescuentosRealizados = 903;
                    public const int Ingreso_AumentarIngresoPorVentaContado = 904;
                    public const int Pasivo_AumentarDebitoFiscal5 = 905;
                    public const int Pasivo_AumentarDebitoFiscal10 = 906;
                    public const int Egreso_AumentarCostoPorVenta = 907;
                    public const int Activo_DisminuirMercaderias = 908;
                    public const int PrestamosAClientes = 909;
                    public const int InteresesACobrar = 910;
                    public const int Ingreso_AumentarIngresoPorVentaCredito = 911;
                }
                #endregion FCClientes_EnReparto_a_Caja

                #region FCClientes_Caja_a_Anualdo
                public abstract class FCClientes_Caja_a_Anulado
                {
                    public const int Activo_DisminuirClientes = 1001;
                    public const int Activo_DisminuirRecaudacionesEnProceso = 1002;
                    public const int Egreso_DisminuirDescuentosRealizados = 1003;
                    public const int Ingreso_DisminuirIngresoPorVentaContado = 1004;
                    public const int Pasivo_DisminuirDebitoFiscal5 = 1005;
                    public const int Pasivo_DisminuirDebitoFiscal10 = 1006;
                    public const int Egreso_DisminuirCostoPorVenta = 1007;
                    public const int Activo_AumentarMercaderias = 1008;
                    public const int PrestamosAClientes = 1009;
                    public const int InteresesACobrar = 1010;
                    public const int Ingreso_DisminuirIngresoPorVentaCredito = 1011;
                }
                #endregion FCClientes_Caja_a_Anualdo

                #region NotaDebitoPersona_Pendiente_a_Aprobado
                public abstract class NotaDebitoPersona_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarClientes = 1101;
                    public const int Ingreso_AumentarIngresoPorVenta = 1102;
                    public const int Pasivo_AumentarDebitoFiscal5 = 1103;
                    public const int Pasivo_AumentarDebitoFiscal10 = 1104;
                }
                #endregion NotaDebitoPersona_Pendiente_a_Aprobado

                #region NotaDebitoProveedor_Pendiente_a_Aprobado
                public abstract class NotaDebitoProveedor_Pendiente_a_Aprobado
                {
                    public const int Egreso_AumentarGastosEnProceso = 1201;
                    public const int Activo_AumentarCreditoFiscal5 = 1202;
                    public const int Activo_AumentarCreditoFiscal10 = 1203;
                    public const int Pasivo_AumentarProveedoresLocales = 1204;
                    public const int Pasivo_AumentarProveedoresExterior = 1205;
                }
                #endregion NotaDebitoProveedor_Pendiente_a_Aprobado

                #region PagoDePersonas_Borrador_a_Aprobado
                public abstract class PagoDePersonas_Borrador_a_Aprobado
                {
                    public const int Activo_AumentarDisponibilidadesValoresVencidos = 1301;
                    public const int Activo_AumentarDisponibilidadesValoresAVencer = 1302;
                    public const int Activo_DisminuirRecaudacionesEnProceso = 1303;
                    public const int Activo_DisminuirClientes = 1304;
                    public const int Activo_DisminuirDisponibilidadesPorVuelto = 1305;
                    public const int FacturasProveedor = 1306;
                    public const int PrestamosAClientesNoVencidos = 1307;
                    public const int InteresesACobrarNoVencidos = 1308;
                    public const int PrestamosAClientesVencidos = 1309;
                    public const int InteresesACobrarVencidos = 1310;
                    public const int DiferenciaDeCambio = 1311;
                }
                #endregion PagoDePersonas_Borrador_a_Aprobado

                #region PagoDePersonas_Aprobado_a_Borrador
                public abstract class PagoDePersonas_Aprobado_a_Borrador
                {
                    public const int Activo_DisminuirDisponibilidadesValoresVencidos = 3501;
                    public const int Activo_DisminuirDisponibilidadesValoresAVencer = 3502;
                    public const int Activo_AumentarRecaudacionesEnProceso = 3503;
                    public const int Activo_AumentarClientes = 3504;
                    public const int Activo_AumentarDisponibilidadesPorVuelto = 3505;
                    public const int FacturasProveedor = 3506;
                    public const int PrestamosAClientesNoVencidos = 3507;
                    public const int InteresesACobrarNoVencidos = 3508;
                    public const int PrestamosAClientesVencidos = 3509;
                    public const int InteresesACobrarVencidos = 3510;
                    public const int DiferenciaDeCambio = 3511;
                }
                #endregion PagoDePersonas_Aprobado_a_Borrador

                #region AjusteStock_Pendiente_a_Aprobado
                public abstract class AjusteStock_Pendiente_a_Aprobado
                {
                    public const int Egreso_AumentarEgresoPorAjusteNegativo = 1401;
                    public const int Activo_DisminuirMercaderiasPorAjusteNegativo = 1402;
                    public const int Activo_AumentarMercaderiasPorAjustePositivo = 1403;
                    public const int Ingreso_AumentarEgresoPorAjustePositivo = 1404;
                }
                #endregion AjusteStock_Pendiente_a_Aprobado

                #region UsoDeInsumos_Pendiente_a_Aprobado
                public abstract class UsoDeInsumos_Pendiente_a_Aprobado
                {
                    public const int Egreso_AumentarEgresoPorUsoDeInsumos = 1501;
                    public const int Activo_DisminuirMercaderiasPorUsoDeInsumos = 1502;
                }
                #endregion UsoDeInsumos_Pendiente_a_Aprobado

                #region NotaCreditoPersona_PreAprobado_a_Aprobado
                public abstract class NotaCreditoPersona_PreAprobado_a_Aprobado
                {
                    public const int Pasivo_DisminuirDebitoFiscal5 = 1601;
                    public const int Pasivo_DisminuirDebitoFiscal10 = 1602;
                    public const int Egreso_AumentarDevolucionesClientes = 1603;
                    public const int Pasivo_AumentarDevolucionesClientesPorFCContado = 1604;
                    public const int Egreso_DisminuirDescuentosRealizados = 1605;
                    public const int Activo_AumentarMercaderias = 1606;
                    public const int Egreso_DisminuirCostoPorVenta = 1607;
                    public const int Pasivo_AumentarDevolucionesClientesPorFCCredito = 1608;
                }
                #endregion NotaCreditoPersona_PreAprobado_a_Aprobado

                #region NotaCreditoProveedor_Pendiente_a_Aprobado
                public abstract class NotaCreditoProveedor_Pendiente_a_Aprobado
                {
                    public const int Pasivo_DisminuirProveedoresLocales = 1701;
                    public const int Pasivo_DisminuirProveedoresExterior = 1702;
                    public const int Ingreso_DisminuirDescuentosObtenidos = 1703;
                    public const int Activo_DisminuirMercaderia = 1704;
                    public const int Egreso_DisminuirGastosEnProceso = 1705;
                    public const int Activo_DisminuirCreditoFiscal5 = 1706;
                    public const int Activo_DisminuirCreditoFiscal10 = 1707;
                }
                #endregion NotaCreditoProveedor_Pendiente_a_Aprobado

                #region AnticipoProveedor_Aprobado_a_Aplicacion
                public abstract class AnticipoProveedor_Aprobado_a_Aplicacion
                {
                    public const int Activo_AumentarAnticiposAProveedor = 1801;
                    public const int Egreso_DisminuirGastosEnProceso = 1802;
                }
                #endregion AnticipoProveedor_Aprobado_a_Aplicacion

                #region AnticipoPersona_Pendiente_a_Aprobado
                public abstract class AnticipoPersona_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarCaja = 1901;
                    public const int Pasivo_AumentarAnticiposRecibidos = 1902;
                }
                #endregion AnticipoPersona_Pendiente_a_Aprobado

                #region OrdenDePago_Aprobado_a_Generacion
                public abstract class OrdenDePago_Aprobado_a_Generacion
                {
                    public const int Egreso_AumentarPagosEnProceso = 2001;
                    public const int Activo_DisminuirCaja = 2002;
                }
                #endregion OrdenDePago_Aprobado_a_Generacion

                #region OrdenDePago_Generacion_a_Anulado
                public abstract class OrdenDePago_Generacion_a_Anulado
                {
                    public const int Activo_AumentarCaja = 2101;
                    public const int Egreso_DisminuirPagosEnProceso = 2102;
                }
                #endregion OrdenDePago_Generacion_a_Anulado

                #region OrdenDePago_Generacion_a_Cerrado
                public abstract class OrdenDePago_Generacion_a_Cerrado
                {
                    public const int Egreso_DisminuirPagosEnProceso = 2201;
                    public const int Pasivo_DisminuirProvedoresPorPagoProveedorExtranjero = 2202;
                    public const int Pasivo_DisminuirProvedoresPorPagoProveedorLocal = 2203;
                    public const int Activo_AumentarFondoFijoPorReposicion = 2204;
                    public const int Activo_AumentarPagoFuncionarios = 2205;
                    public const int Activo_AumentarAnticipoFuncionarios = 2206;
                    public const int Activo_AumentarAnticipoProveedores = 2207;
                    public const int Activo_AumentarPorCambioDivisa = 2208;
                    public const int Activo_AumentarPorCustodiaValores = 2209;
                    public const int Activo_AumentarPorDescuentoDocumentos = 2210;
                    public const int Activo_AumentarPorTransferenciaBancaria = 2211;
                    public const int Activo_AumentarPorTransferenciaTesoreria = 2212;
                    public const int Activo_AumentarPorAjusteBancario = 2213;
                    public const int Activo_AumentarClientesPorPagoPersonas = 2214;
                    public const int DiferenciaDeTotales = 2215;
                    public const int Activo_AumentarCreditoPorPagoPersonas = 2216;
                }
                #endregion OrdenDePago_Generacion_a_Cerrado

                #region OrdenDePago_Aprobado_a_Generacion_UNIFICADO
                public abstract class OrdenDePago_Aprobado_a_Generacion_UNIFICADO
                {
                    public const int Activo_DisminuirCaja = 3201;
                    public const int Pasivo_DisminuirProvedoresPorPagoProveedorExtranjero = 3202;
                    public const int Pasivo_DisminuirProvedoresPorPagoProveedorLocal = 3203;
                    public const int Activo_AumentarFondoFijoPorReposicion = 3204;
                    public const int Activo_AumentarPagoFuncionarios = 3205;
                    public const int Activo_AumentarAnticipoFuncionarios = 3206;
                    public const int Activo_AumentarAnticipoProveedores = 3207;
                    public const int Activo_AumentarPorCambioDivisa = 3208;
                    public const int Activo_AumentarPorCustodiaValores = 3209;
                    public const int Activo_AumentarPorDescuentoDocumentos = 3210;
                    public const int Activo_AumentarPorTransferenciaBancaria = 3211;
                    public const int Activo_AumentarPorTransferenciaTesoreria = 3212;
                    public const int Activo_AumentarPorAjusteBancario = 3213;
                    public const int Activo_AumentarClientesPorPagoPersonas = 3214;
                    public const int DiferenciaDeTotales = 3215;
                    public const int Activo_AumentarCreditoPorPagoPersonas = 3216;
                    public const int DisminuirPagosEnProceso = 3217;
                }
                #endregion OrdenDePago_Aprobado_a_Generacion_UNIFICADO

                #region OrdenDePago_Generacion_a_Anulado_UNIFICADO
                public abstract class OrdenDePago_Generacion_a_Anulado_UNIFICADO
                {
                    public const int Activo_AumentarCaja = 3301;
                    public const int Pasivo_AumentarProvedoresPorPagoProveedorExtranjero = 3302;
                    public const int Pasivo_AumentarProvedoresPorPagoProveedorLocal = 3303;
                    public const int Activo_DisminuirFondoFijoPorReposicion = 3304;
                    public const int Activo_DisminuirPagoFuncionarios = 3305;
                    public const int Activo_DisminuirAnticipoFuncionarios = 3306;
                    public const int Activo_DisminuirAnticipoProveedores = 3307;
                    public const int Activo_DisminuirPorCambioDivisa = 3308;
                    public const int Activo_DisminuirPorCustodiaValores = 3309;
                    public const int Activo_DisminuirPorDescuentoDocumentos = 3310;
                    public const int Activo_DisminuirPorTransferenciaBancaria = 3311;
                    public const int Activo_DisminuirPorTransferenciaTesoreria = 3312;
                    public const int Activo_DisminuirPorAjusteBancario = 3313;
                    public const int Activo_DisminuirClientesPorPagoPersonas = 3314;
                    public const int DiferenciaDeTotales = 3315;
                    public const int Activo_DisminuirCreditoPorPagoPersonas = 3316;
                    public const int AumentarPagosEnProceso = 3317;
                }
                #endregion OrdenDePago_Generacion_a_Anulado_UNIFICADO

                #region AjusteBancario_Aprobado_a_Cerrado
                public abstract class AjusteBancario_Aprobado_a_Cerrado
                {
                    public const int Activo_AumentarBancoPorAjustePositivo = 2301;
                    public const int Activo_AumentarCajaPorAjusteNegativo = 2302;
                    public const int Activo_DisminuirBancoPorAjusteNegativo = 2303;
                    public const int Activo_DisminuirCajaPorAjustePositivo = 2304;
                }
                #endregion AjusteBancario_Aprobado_a_Cerrado

                #region MovimientoFondoFijo_Pendiente_a_Aprobado
                public abstract class MovimientoFondoFijo_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarFondoFijoPorIngreso = 2401;
                    public const int Egreso_DisminuirGastosEnProcesoPorEgreso = 2402;
                    public const int Activo_DisminuirRecaudacionesADepositarPorIngreso = 2403;
                    public const int Activo_DisminuirFondoFijoPorEgreso = 2404;
                    public const int PagoContratista = 2405;
                    public const int PagoContratistaFondoReparo = 2406;
                }
                #endregion MovimientoFondoFijo_Pendiente_a_Aprobado

                #region MovimientoVarioTesoreria_Pendiente_a_Aprobado
                public abstract class MovimientoVarioTesoreria_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarCajaPorIngreso = 2501;
                    public const int Egreso_DisminuirGastosEnProcesoPorIngreso = 2502;
                    public const int Egreso_AumentarGastosEnProcesoPorIngreso = 2503;
                    public const int Activo_DisminuirCajaPorEgreso = 2504;
                }
                #endregion MovimientoVarioTesoreria_Pendiente_a_Aprobado

                #region MovimientoVarioTesoreria_Aprobado_a_Anulado
                public abstract class MovimientoVarioTesoreria_Aprobado_a_Anulado
                {
                    public const int Activo_DisminuirCajaPorIngreso = 2801;
                    public const int Egreso_AumentarGastosEnProcesoPorIngreso = 2802;
                    public const int Egreso_DisminuirGastosEnProcesoPorIngreso = 2803;
                    public const int Activo_AumentarCajaPorEgreso = 2804;
                }
                #endregion MovimientoVarioTesoreria_Aprobado_a_Anulado

                #region EgresoVarioCaja_Pendiente_a_Aprobado
                public abstract class EgresoVarioCaja_Pendiente_a_Aprobado
                {
                    public const int Pasivo_DisminuirProveedoresNacionales = 2601;
                    public const int Pasivo_DisminuirProveedoresExtranjeros = 2602;
                    public const int Activo_DisminuirFondoFijo = 2603;
                    public const int Activo_AumentarClientesPorPagoAPersona = 2604;
                    public const int Activo_AumentarCreditoPorPagoAPersona = 2605;
                    public const int DiferenciaDeCambio = 2606;
                }
                #endregion EgresoVarioCaja_Pendiente_a_Aprobado

                #region TransferenciaCajasSucursal_EnProceso_a_Cerrado
                public abstract class TransferenciaCajasSucursal_EnProceso_a_Cerrado
                {
                    public const int Activo_AumentarPorIngreso = 2701;
                    public const int Activo_DisminuirPorEgreso = 2702;
                    public const int Activo_AumentarPorIngresoDestino = 2703;
                    public const int Activo_DisminuirPorEgresoDestino = 2704;
                    public const int Activo_AumentarPrestamo = 2705;
                    public const int Activo_DisminuirPrestamo = 2706;
                }
                #endregion TransferenciaCajasSucursal_PreAprobado_a_Cerrado

                #region CreditoProveedor_Pendiente_a_Aprobado
                public abstract class CreditoProveedor_Pendiente_a_Aprobado
                {
                    public const int Activo_AumentarCuentaTransitoria = 2901;
                    public const int Pasivo_AumentarCapital = 2902;
                    public const int Pasivo_AumentarInteres = 2903;
                }
                #endregion CreditoProveedor_Pendiente_a_Aprobado

                #region CreditoCliente_Aprobado_a_Vigente
                public abstract class CreditoCliente_Aprobado_a_Vigente
                {
                    public const int Activo_AumentarPrestamosAClientes = 3701;
                    public const int Activo_AumentarInteresDevengado = 3702;
                    public const int Activo_AumentarInteresDevengadoNoVencido = 3703;
                    public const int Activo_AumentarCapitalADesembolsar = 3704;
                    public const int Activo_AumentarRecaudacionesEnProceso = 3705;
                }
                #endregion CreditoCliente_Aprobado_a_Vigente

                #region CreditoCliente_EnRevision_a_Vigente
                public abstract class CreditoCliente_EnRevision_a_Vigente
                {
                    public const int AumentarDescuentoInteresesADevengar = 3801;
                    public const int DisminuirADevengarVigente = 3802;
                }
                #endregion CreditoCliente_EnRevision_a_Vigente

                #region TransferenciaCuentaCorriente_Pendiente_a_Aprobado
                public abstract class TransferenciaCuentaCorriente_Pendiente_a_Aprobado
                {
                    public const int Pasivo_DisminuirGarantiasRecibidas = 3101;
                    public const int Ingreso_AumentarIngresosVarios = 3102;
                }
                #endregion TransferenciaCuentaCorriente_Pendiente_a_Aprobado

                #region AplicacionDocumentos_Pendiente_a_Aprobado
                public abstract class AplicacionDocumentos_Pendiente_a_Aprobado
                {
                    public const int Pasivo_DisminuirProveedores = 3001;
                    public const int Activo_DisminuirClientes = 3002;
                    public const int Pasivo_DisminuirAnticipo = 3003;
                    public const int PrestamosAClientesNoVencidos = 3007;
                    public const int InteresesACobrarNoVencidos = 3008;
                    public const int PrestamosAClientesVencidos = 3009;
                    public const int InteresesACobrarVencidos = 3010;
                }
                #endregion #region AplicacionDocumentos_Pendiente_a_Aprobado

                #region PlanillaLiquidaciones_Pendiente_a_Aprobado
                public abstract class PlanillaLiquidaciones_Pendiente_a_Aprobado
                {
                    public const int Pasivo_AumentarPagoFuncionarios = 3401;
                    public const int Pasivo_AumentarAportesEmpresa = 3402;
                    public const int Egreso_AumentarPagoFuncionarios = 3403;
                    public const int Egreso_AumentarAportesEmpresa = 3404;
                    public const int Ingreso_AumentarPorDescuentos = 3405;
                }
                #endregion #region PlanillaLiquidaciones_Pendiente_a_Aprobado

                #region Remisiones_Pendiente_a_Aprobado
                public abstract class Remisiones_Pendiente_a_Aprobado
                {
                    public const int Egreso_AumentarCostoDeVenta = 3901;
                    public const int Activo_DisminuirMercaderias = 3902;
                }
                #endregion Remisiones_Pendiente_a_Aprobado

                #region Remisiones_Aprobado_a_Anulado
                public abstract class Remisiones_Aprobado_a_Anulado
                {
                    public const int Egreso_DisminuirCostoDeVenta = 4001;
                    public const int Activo_AumentarMercaderias = 4002;
                }
                #endregion Remisiones_Aprobado_a_Anulado

                #region ChequeRecibido_Adelantado_a_AlDia
                public abstract class ChequeRecibido_Adelantado_a_AlDia
                {
                    public const int Activo_DisminuirCaja = 100101;
                    public const int Activo_AumentarCaja = 100102;
                }
                #endregion ChequeRecibido_Adelantado_a_AlDia

                #region ChequeRecibido_AlDia_a_Efectivizado
                public abstract class ChequeRecibido_AlDia_a_Efectivizado
                {
                    public const int Activo_DisminuirCaja = 100201;
                    public const int Activo_AumentarCaja = 100202;
                }
                #endregion ChequeRecibido_AlDia_a_Efectivizado

                #region ChequeRecibido_Custodia_a_Depositado
                public abstract class ChequeRecibido_Custodia_a_Depositado
                {
                    public const int Activo_DisminuirCaja = 100301;
                    public const int Activo_AumentarCaja = 100302;
                }
                #endregion ChequeRecibido_Custodia_a_Depositado

                #region ChequeRecibido_Negociado_a_Depositado
                public abstract class ChequeRecibido_Negociado_a_Depositado
                {
                    public const int Activo_DisminuirNegociado = 100401;
                    public const int Activo_AumentarBanco = 100402;
                }
                #endregion ChequeRecibido_Negociado_a_Depositado

                #region ChequeRecibido_Depositado_a_Rechazado
                public abstract class ChequeRecibido_Depositado_a_Rechazado
                {
                    public const int Activo_DisminuirBanco = 100501;
                    public const int Activo_AumentarCaja = 100502;
                }
                #endregion ChequeRecibido_Depositado_a_Rechazado

                #region DevengamientoCreado
                public abstract class DevengamientoCreado
                {
                    public const int AumentarADevengarVigente = 100601;
                    public const int DisminuirADevengarVigente = 100602;
                    public const int AumentarADevengarVencido = 100603;
                    public const int DisminuirADevengarVencido = 100604;
                    public const int AumentarDevengado = 100605;
                    public const int DisminuirDevengado = 100606;
                    public const int AumentarEnSuspenso = 100607;
                    public const int DisminuirEnSuspenso = 100608;
                    public const int AumentarCapitalACobrarVigente = 100609;
                    public const int DisminuirCapitalACobrarVigente = 100610;
                    public const int AumentarCapitalACobrarVencido = 100611;
                    public const int DisminuirCapitalACobrarVencido = 100612;
                    public const int AumentarInteresACobrarVigente = 100613;
                    public const int DisminuirInteresACobrarVigente = 100614;
                    public const int AumentarInteresACobrarVencido = 100615;
                    public const int DisminuirInteresACobrarVencido = 100616;
                }
                #endregion DevengamientoCreado

                #region RevaluoDepreciacion
                public abstract class RevaluoDepreciacion
                {
                    public const int RubrosRevaluo = 100701;
                    public const int ReservaDelRevalúo = 100702;
                    public const int Depreciacion = 100703;
                    public const int DepreciacionAcumulada = 100704;
                }
                #endregion RevaluoDepreciacion
            }
            #endregion AsientosAutomaticosDetalle

            #region ClavesDatos
            public abstract class ClavesDatos
            {
                public const string Cabecera = "cabecera";
                public const string Detalles = "detalles";
                public const string Documentos = "documentos";
                public const string Valores = "valores";
            }
            #endregion ClavesDatos
        }
        #endregion Contabilidad

        #region CamposConfigurables
        public abstract class CamposConfigurablesItems
        {
            public abstract class TablaArticulos
            {
                public const int TabCaracteristicasCampoProcedencia = 1;
                public const int TabCaracteristicasCampoCantidadPorCaja = 9;
                public const int TabBasicoCampoFamilia = 21;
                public const int TabBasicoCampoGrupo = 22;
                public const int TabBasicoCampoNoReponer = 23;
                public const int TabBasicoCampoArancel = 24;
            }
            public abstract class TablaSucursales
            {
                public const int CampoPais = 2;
            }
            public abstract class TablaBancos
            {
                public const int CampoPais = 3;
            }
            public abstract class TablaFuncionarios
            {
                public const int TabBasicoCampoNacionalidad = 4;
                public const int TabContactoCampoCiudadPrincipal = 11;
                public const int TabContactoCampoCiudadSecundaria = 12;
                public const int TabContactoEmergenciaCampoCiudad = 13;
                public const int TabContactoCampoDepartamentoPrincipal = 14;
                public const int TabContactoCampoDepartamentoSecundario = 15;
                public const int TabContactoEmergenciaCampoDepartamento = 16;
                public const int TabContactoCampoBarrioPrincipal = 17;
                public const int TabContactoCampoBarrioSecundario = 18;
                public const int TabContactoEmergenciaCampoBarrio = 19;
                public const int TabContactoCampoPaisResidencia = 20;
                public const int TabLaboralCampoMoneda = 29;
            }
            public abstract class TablaPersonas
            {
                public const int TabBasicoCampoNacionalidad = 5;
                public const int TabContactosCampoPais = 6;
                public const int TabContactoCampoDepartamentoPrincipal = 31;
                public const int TabContactoCampoDepartamentoSecundario = 32;
                public const int TabContactoCampoCiudadPrincipal = 33;
                public const int TabContactoCampoCiudadSecundaria = 34;
                public const int TabContactoCampoBarrioPrincipal = 35;
                public const int TabContactoCampoBarrioSecundario = 36;
                public const int TabContactoCampoDepartamentoCobranza = 37;
                public const int TabContactoCampoCiudadCobranza = 38;
                public const int TabContactoCampoBarrioCobranza = 39;
                public const int TabBasicoEstadoMorosidad = 78;
                public const int TabBasicoTipoCliente = 77;
                public const int TabBasicoEsContribuyente = 79;
            }
            public abstract class TablaProveedores
            {
                public const int TabContactoCampoPais = 7;
            }
            public abstract class FlujoAjusteDeStock
            {
                public const int CampoMoneda = 8;
            }
            public abstract class TablaEjercicios
            {
                public const int CampoPais = 10;
            }
            public abstract class TablaDescuentos
            {
                public const int CampoMoneda = 25;
            }
            public abstract class TablaFuncionariosAdelantos
            {
                public const int TabBasicoCampoMoneda = 26;
            }
            public abstract class TablaFuncionariosDescuentos
            {
                public const int TabDescuentosCampoMoneda = 27;
                public const int TabConsumoCampoMoneda = 30;
            }
            public abstract class FlujoPlanillaLiquidaciones
            {
                public const int CampoMoneda = 28;
            }
            public abstract class FlujoCreditos
            {
                public const int TabBasicoCampoMoneda = 40;
                public const int TabBasicoCampoDesembolsarParaCliente = 80;
            }
            public abstract class FlujoFacturasCliente
            {
                public const int TabFacturaCampoMoneda = 41;
                public const int AfectaEnFcCliente = 90;
                public const int ImpresoraComprobanteLegal = 92;
            }
            public abstract class FlujoPedidosCliente
            {
                public const int TabBasicoCampoMoneda = 42;
            }
            public abstract class FlujoPlanesFacturacion
            {
                public const int TabBasicoCampoMoneda = 43;
            }
            public abstract class FlujoPresupuestos
            {
                public const int TabBasicoCampoMoneda = 44;
            }
            public abstract class FlujoFacturasProveedor
            {
                public const int TabBasicoCampoCondicionPago = 45;
                public const int TabAvanzadoCampoPagoDesdeFondoFijo = 68;
                public const int TabAvanzadoCampoTipo = 69;
                public const int DetallesAgregarSoloObservacion = 71;
                public const int AfectaEnFcProveedor = 91;
            }
            public abstract class TablaFondosFijos
            {
                public const int CampoMoneda = 46;
            }
            public abstract class FlujoPlanillaDePagos
            {
                public const int CampoMoneda = 47;
            }
            public abstract class FlujoNotaDeCreditoPersona
            {
                public const int TabBasicoCampoMoneda = 48;
            }
            public abstract class FlujoNotaDeDebitoPersona
            {
                public const int TabBasicoCampoMoneda = 49;
            }
            public abstract class FlujoTransferenciaDeDeuda
            {
                public const int CampoMoneda = 50;
            }
            public abstract class FlujoCreditosProveedores
            {
                public const int TabBasicoCampoMoneda = 51;
            }
            public abstract class FlujoNotaDeDebitoProveedor
            {
                public const int TabBasicoCampoMoneda = 52;
            }
            public abstract class FlujoNotaDeCreditoProveedor
            {
                public const int TabBasicoCampoMoneda = 53;
            }
            public abstract class FlujoMovimientoVariosTesoreria
            {
                public const int TabEfectivoCampoMoneda = 54;
            }
            public abstract class FlujoOrdenDePago
            {
                public const int TabBasicoCampoMoneda = 55;
                public const int TabValoresEfectivoCampoMoneda = 56;
            }
            public abstract class FlujoAnticipoDePersona
            {
                public const int TabBasicoCampoMoneda = 57;
                public const int TabEfectivoCampoMoneda = 58;
                public const int TabChequeCampoMoneda = 59;
            }
            public abstract class FlujoPagoDePersona
            {
                public const int CabeceraCampoMoneda = 60;
                public const int TabEfectivoCampoMoneda = 61;
                public const int TabChequeCampoMoneda = 62;
                public const int TabRedesPagoCampoMoneda = 72;
            }
            public abstract class FlujoEgresoVarioDeCaja
            {
                public const int TabBasicoCampoMoneda = 63;
            }
            public abstract class TablaInmuebles
            {
                public const int TabUbicacionPais = 64;
                public const int TabUbicacionDepartamento = 65;
                public const int TabUbicacionCiudad = 66;
                public const int TabUbicacionBarrio = 67;
            }
            public abstract class FlujoIngresoStock
            {
                public const int CampoAplicarProrrateo = 70;
            }
            public abstract class FlujoDesembolsosGiros
            {
                public const int TabBasicoMoneda = 73;
                public const int TabDetallesMoneda = 74;
                public const int TabValoresEfectivoMoneda = 75;
                public const int TabValoresChequeMoneda = 76;
            }
            public abstract class TablaCtacteCajasSucursal
            {
                public const int CampoFuncionarioCajero = 81;
            }
            public abstract class TablaReportes
            {
                public const int FCClienteImpresion = 88;
                public const int NCClienteImpresion = 89;
            }
            public abstract class BuscadorObjetivoBusqueda
            {
                public const int Persona = 82;
                public const int Proveedor = 83;
                public const int Funcionario = 84;
                public const int Usuario = 85;
                public const int Articulo = 86;
            }
        }
        public abstract class CamposConfigurablesGrupos
        {
            public const int Paises = 1;
            public const int Ciudades = 2;
            public const int Departamentos = 3;
            public const int Barrios = 4;
            public const int Monedas = 5;
            public const int ArticulosFamilias = 6;
            public const int ArticulosGrupos = 7;
            public const int ArticulosNoReponer = 8;
            public const int ArticulosCantidadPorCaja = 9;
            public const int ArticulosArancel = 10;
            public const int FormasDePago = 11;
            public const int Temas = 12;
            public const int PagoDesdeFondoFijo = 13;
            public const int TipoFCProveedor = 14;
            public const int AplicarProrrateo = 15;
            public const int AgregarSoloInformacion = 16;
            public const int Impresoras = 17;
            public const int EstadoMorosidad = 18;
            public const int TipoCliente = 19;
            public const int EsContribuyente = 20;
            public const int Funcionario = 21;
            public const int HechaukaNombreAgente = 22;
            public const int HechaukaRucAgente = 23;
            public const int HechaukaNombreRepresentante = 24;
            public const int HechaukaRucRepresentante = 25;
            public const int BuscadorObjetivoBusqueda = 26;
            public const int ReporteFormato = 27;
            public const int PagoPersonaReciboPorDocumentos = 28;
            public const int MFFGenerarAdelantosDeFuncionarios = 30;
            public const int ContabilidadRepresentanteLegal = 31;
            public const int ContabilidadNombreContador = 32;
            public const int ContabilidadRucContador = 33;
            public const int ImpresoraTipoYNombre = 34;
            public const int MFFGenerarAnticipoProveedor = 35;
        }
        #endregion CamposConfigurables

        #region WebserviceRetorno
        public abstract class WebserviceRetorno
        {
            public static string Exito = "Éxito";
            public static string Fallo = "Fallo";
        }
        #endregion WebserviceRetorno

        #region Mensajes
        public abstract class Mensajes
        {
            public const string Exito = "Éxito";
            public const string Existe = "Existe";
            public const string NoExiste = "No Existe";
            public const string CamposVacios = "Tiene campos vacios";
            public const string SesionInvalida = "Sesión inválida";
        }
        #endregion Mensajes

        #region DescuentoDocumentosReportesTXT
        public abstract class DescuentoDocumentosReportesTXT
        {
            public const int Itau = 1;
            public const int Regional = 2;
        }
        #endregion DescuentoDocumentosReportesTXT

        #region PoliticasPrimerDesembolso
        public abstract class PoliticasPrimerDesembolso
        {
            public const int FechaDeGiro = 0;
            public const int PrimerDiaDelMes = 1;
        }
        #endregion PoliticasPrimerDesembolso

        #region PoliticasRecargo
        public abstract class PoliticasRecargo
        {
            public const int CBAFlow = 0;
            public const int Webservice = 1;
        }
        #endregion PoliticasRecargo

        #region MensajesGenerales
        public abstract class MensajesGenerales
        {
            public const string SinDatos = "S/D";
        }
        #endregion MensajesGenerales

        #region TiposNotasCredito
        public abstract class TiposNotasCredito
        {
            public const int EstandarCBA = 0;
            public const int Descuento = 1;
            public const int CambioTitular = 2;
            public const int RecuperoMercaderia = 3;
            public const int ErrorFacturacion = 4;
            public const int RefinanciacionDeuda = 5;
            public const int CambioMercaderia = 6;
            public const int DevolucionMercaderia = 7;
            public const int DesperfectoMercaderia = 8;
            public const int ReconocimientoGarantia = 9;
            public const int Fraude = 10;
            public const int FaltaDocumentacionCredito = 11;
            public const int ExtravioDocumento = 12;
            public const int FaltanteMercaderia = 13;
            public const int ErrorChassis = 14;
            public const int UnificacionDeuda = 15;
            public const int PromoQuita = 16;
        }
        #endregion TiposNotasCredito

        #region PoliticasNotasCredito
        public abstract class PoliticasNotasCredito
        {
            public const int General = 1;
            public const int Especifica = 2;
        }
        #endregion PoliticasNotasCredito

        #region CreacionCodigoReingreso
        public abstract class CreacionCodigoReingreso
        {
            public const string Crear = "S";
            public const string NoCrear = "N";
        }
        #endregion CreacionCodigoReingreso

        #region EstrategiaPrecio
        public abstract class EstrategiaPrecio
        {
            public const int ModuloPrecios = 0;
            public const int FlujoModificacionListaPrecios = 1;
            public const int WebService = 2;
        }
        #endregion EstrategiaPrecio

        #region TipoProrrateo
        public abstract class TipoProrrateo
        {
            public const int Proporcional = 0;
            public const int Personalizado = 1;
        }
        #endregion TipoProrrateo

        #region CondicionPagoUso
        public abstract class CondicionPagoUso
        {
            public const int Venta = 0;
            public const int Compra = 1;
        }
        #endregion CondicionPagoUso

        #region Prefijos para Nros de Celulares
        public static class EmpresasCelulares
        {
            public static string EmpresaVox = "VOX";
            public static string EmpresaPersonal = "PERSONAL";
            public static string EmpresaTigo = "TIGO";
            public static string EmpresaClaro = "CLARO";

            public static class DiccionarioPrefijos
            {
                public static string[] PrefijosVox =
                {
                    "0961", "0962", "0963", "0964", "0965", "0966", "0967","+595961", "+595962", "+595963", "+595964", "+595965", "+595966", "+595967"
                };

                public static string[] PrefijosPersonal =
                {
                    "0971", "0972", "0973", "0974", "0975", "0976", "0977", "+595971", "+595972", "+595973", "+595974", "+595975", "+595976", "+595977"
                };

                public static string[] PrefijosTigo =
                {
                    "0981", "0982", "0983", "0984", "0985", "0986", "0987", "+595981", "+595982", "+595983", "+595984", "+595985", "+595986", "+595987"
                };

                public static string[] PrefijosClaro =
                {
                    "0991", "0992", "0993", "0994", "0995", "0996", "0997", "+595991", "+595992", "+595993", "+595994", "+595995", "+595996", "+595997"
                };
            }
        }
        #endregion Prefijos para Nros de Celulares

        #region Impresoras
        public static ReadOnlyCollection<string> Impresoras = new ReadOnlyCollection<string>(new List<String>()
        {
            "Epson LX-300",
            "Epson LX-300+II",
            "Epson LX-350",
            "Epson LX-300+II CHEQUES",
            "Epson TM-U220"
        });

        public class Impresora
        {
            public string Tipo; //LX-300, etc.
            public string Nombre; //Nombre en el sistema operativo

            public Impresora()
            {
                Tipo = string.Empty;
                Nombre = string.Empty;
            }
        }
        #endregion Impresoras

        #region SistemaModo
        public abstract class SistemaModo
        {
            public const int Bloqueado = 0;
            public const int SoloLectura = 1;
            public const int LecturaEscritura = 2;
        }
        #endregion TipoProrrateo

        #region TipoComprobanteAplicable
        public abstract class TipoComprobanteAplicable
        {
            public const int Persona = 0;
            public const int Proveedor = 1;
        }
        #endregion TipoComprobanteAplicable

        #region TipoOperacion
        public abstract class TipoOperacion
        {
            public const int CasoCreado = 4;
            public const int PasoEstado = 5;
        }
        #endregion TipoOperacion

        #region RetencionProveedoresPoliticaAgrupamiento
        public abstract class RetencionProveedoresPoliticaAgrupamiento
        {
            public const int Caso = 0;
            public const int Dia = 1;
            public const int Mes = 2;
        }
        #endregion RetencionProveedoresPoliticaAgrupamiento

        #region RetencionProveedoresPoliticaCasosAConsiderar
        public abstract class RetencionProveedoresPoliticaCasosAConsiderar
        {
            public const int Caso = 0;
            public const int Dia = 1;
            public const int Mes = 2;
        }
        #endregion RetencionProveedoresPoliticaCasosAConsiderar

        #region RetencionProveedoresPoliticaMonto
        public abstract class RetencionProveedoresPoliticaMonto
        {
            public const int TotalFactura = 0;
            public const int TotalCuota = 1;
            public const int MontoPagado = 2;
        }
        #endregion RetencionProveedoresPoliticaMonto

        #region Tipo Anticipo
        public abstract class TipoAnticipo
        {
            public const string Anticipo = "Anticipo";
            public const string PagoParcial = "Pago Parcial";
            public const string PagoTotal = "Pago Total";
        }
        #endregion Tipo Anticipo

        #region Logistica
        #region Contenedores
        public abstract class MovimientosContenedores
        {
            /*
            Infull - Ingreso por Muelle Cargado
            InEmpty - Ingreso por Muelle Vacio
            OutFull - Salida por Muelle Cargado
            OutEmpty - Salida por Muelle Vacio
            GIE - Ingreso por tierra vacio
            GIF - Ingreso por tierra cargado
            GOE - Salida por tierra vacio
            GOF - Salida por tierra cargado
            Consolidaciones
            Desconsolicaciones
            */
            public const string InFull = "InFull";
            public const string InEmpty = "InEmpty";
            public const string OutFull = "OutFull";
            public const string OutEmpty = "OutEmpty";
            public const string GIE = "GIE";
            public const string GIF = "GIF";
            public const string GOE = "GOE";
            public const string GOF = "GOF";
            public const string Consolidacion = "Consolidacion";
            public const string Desconsolidacion = "Desconsolidacion";
            public const string Verificacion = "Verificacion";
            public const string DesconsolidacionParcial = "Desc. Parcial";
            public const string Creacion = "Creacion";
            public const string Modificacion = "Modificacion";
            public const string Vermas = "Vermas"; //No es realmente un tipo de movimiento sino el EDI extra por GIF
            public const string Desbloqueo = "Desbloqueo";
            public const string Bloqueo = "Bloqueo";
            public const string Retiro = "Retiro";
            public const string Vaciamiento = "Vaciamiento";
        }
        public abstract class ClasificacionContenedores
        {
            //HC, RHC, ST, OT, FR, DC, RF, TK, MAFI
            public const string HC = "HC";
            public const string RHC = "RHC";
            public const string ST = "ST";
            public const string OT = "OT";
            public const string FR = "FR";
            public const string DC = "DC";
            public const string RF = "RF";
            public const string TK = "TK";
            public const string MAFI = "MAFI";
        }
        public abstract class TamanoContenedores
        {
            public const decimal VeintePies = 20;
            public const decimal CuarentaPies = 40;
        }
        public abstract class TipoContedores
        {
            public const decimal HighCube20 = 1;
            public const decimal Standar20 = 2;
            public const decimal OpenTop20 = 3;
            public const decimal Reefer20 = 4;
            public const decimal Tank20 = 5;
            public const decimal FlatRack20 = 6;
            public const decimal HighCube4 = 10;
            public const decimal Standar40 = 11;
            public const decimal OpenTop40 = 12;
            public const decimal Reefer40 = 13;
            public const decimal FlatRack40 = 15;
            public const decimal ReeferHighCube40 = 16;
            public const decimal Cisterna = 17;
            public const decimal Furgon = 18;
            public const decimal Encarpado = 19;
        }

        public abstract class Lineas
        {
            public const decimal CMA = 8;
            public const decimal MAERSK = 7;
        }
        public abstract class TipoEquipos
        {
            public const string Contenedor = "Contenedor";
            public const string Vehiculos = "Vehículos";
            public const string Granel = "Granel";
            public const string Proyecto = "Proyecto";
            public const string Otros = "Otros";

        }
        public abstract class TipoMovimientoPuerto
        {
            public const string Entrada = "Entrada";
            public const string Salida = "Salida";

        }
        public abstract class TipoMovimientoContenedorPatio
        {
            public const string Cargados = "Cargados";
            public const string Vacios = "Vacios";
            public const string Removidos = "Removidos";
            public const string Poscionamiento = "Poscionamiento";
        }
        public abstract class ServicioOperacionesLugar
        {
            public const string Muelle = "Muelle";
            public const string Patio = "Patio";
            public const string Otro = "Otro";
        }
        public abstract class TipoDetaleServicioOperaciones
        {
            public const string Equipos = "Equipos";
            public const string Reefer = "Reefer";
            public const string Otro = "Servicios";
        }
        public abstract class TipoOperacionMuelle
        {
            public const string Carga = "Carga";
            public const string Descarga = "Descarga";
            public const string Otro = "Otro";
        }
        public abstract class EstadoContenedores
        {
            public const string Cargado = "Cargado";
            public const string Vacio = "Vacio";
            public const string Consolidacion = "Consolidacion";
            public const string Desconsolidacion = "Desconsolidacion";
        }
        public abstract class ClasesContenedores
        {
            public const string A = "A";
            public const string B = "B";
            public const string C = "C";
            public const string D = "D";
        }
        public abstract class EstadoContenedoresNominados
        {
            public const string Nominados = "Nominado";
            public const string Entregados = "Entregado";
            public const string Disponibles = "Disponible";
            public const string Devueltos = "Devuelto";
            public const string Consolidados = "Consolidado";
            public const string EnPreEmbarque = "En Pre Embarque";
            public const string Embarcado = "Embarcado";
        }
        public class PartesContenedores
        {
            public const string Fondo = "Fondo";
            public const string Piso = "Piso";
            public const string Techo = "Techo";
            public const string Izquierdo = "Izquierdo";
            public const string Derecho = "Derecho";
            public const string Puerta = "Puerta";
            public const string Parte = "parte";

            public static DataTable CargarPartes()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(Definiciones.PartesContenedores.Parte, typeof(string));

                dt.Rows.Add(Definiciones.PartesContenedores.Puerta);
                dt.Rows.Add(Definiciones.PartesContenedores.Fondo);
                dt.Rows.Add(Definiciones.PartesContenedores.Piso);
                dt.Rows.Add(Definiciones.PartesContenedores.Techo);
                dt.Rows.Add(Definiciones.PartesContenedores.Izquierdo);
                dt.Rows.Add(Definiciones.PartesContenedores.Derecho);
                return dt;
            }

        }
        #endregion Contenedores

        #region Importaciones

        public abstract class SituacionSalidaItems
        {
            public const string EnEspera = "EN ESPERA";
            public const string Deposito = "DEPOSITO";
            public const string Retirado = "RETIRADO";
        }
        public abstract class ItemsTipoRetiro
        {
            public const string Total = "TOTAL";
            public const string Parcial = "PARCIAL";

        }
        public abstract class ImportacionesTipos
        {
            public const string Fluvial = "Fluvial";
            public const string Terrestre = "Terrestre";
            public const string Aereo = "Aereo";
        }
        public abstract class TiposCargas
        {
            public const string FCL = "FCL";
            public const string LCL = "LCL";
        }

        public abstract class EstadosVehiculos
        {
            public const string Nuevo = "Nuevo";
            public const string Usado = "Usado";
        }
        public abstract class ConocimientosBlBm
        {
            public const string BL = "BL";
            public const string BM = "BM";
        }
        public abstract class ConocimientosContenidos
        {
            public const string Varios = "Varios";
            public const string Vehiculos = "Vehículos";
        }
        public abstract class ConocimientosContenidosEmbarque
        {
            public const string RORO = "RORO";
            public const string Desconsolidacion = "Desconsolidacion";

        }
        public abstract class TipoBloqueoContenedores
        {
            public const string Bloqueado = "Bloqueado";
            public const string Retiro = "Retiro";
            public const string Vaciamiento = "Vaciamiento";
            public const string Liberado = "Liberado";

        }
        #endregion Importaciones

        #region TipoNominaContenendores
        public abstract class TipoNominaContenendores
        {
            public const string GOE = "GOE";
            public const string Embarque = "Embarque";
            public const string Consolidacion = "Consolidacion";

        }
        #endregion TipoNominaContenendores

        #region Tarifario Tipo de valor
        public abstract class TarifarioTipoValor
        {
            public const string CIF = "CIF";
            public const string FOB = "FOB";
        }
        #endregion Tarifario Tipo de valor

        public abstract class EIRDetallesOPeracion
        {
            public const string Agregar = "Agregar";
            public const string Eliminar = "Eliminar";
        }
        public abstract class TiposInspeccionesObservaciones
        {
            public const string Contenedores = "Contenedores";
            public const string Vehiculos = "Vehículos";
            public const string Otros = "Otros";
        }
        public abstract class IntercambioNotificacionesTipos
        {
            public const string Persona = "Persona";
            public const string Linea = "Linea";
            public const string Armador = "Armador";
        }

        #endregion Logistica

        #region TareasProgramadasTipo
        public abstract class TareasProgramadasTipo
        {
            public const int ContabilidadAsientosBorrar = 1;
            public const int ContabilidadAsientosRegenerar = 2;
            public const int TransaccionesImportar = 3;
            public const int ContabilidadDevengamientoCrear = 4;
        }
        #endregion TareasProgramadasTipo

        #region Tipos de reglas por llegadas tardías
        public abstract class TiposDeReglasPorLlegadasTardias
        {
            public const decimal Puntos = 1;
            public const decimal Tiempo = 2;
            public const decimal MinutosDeRetraso = 3;
        }
        #endregion Tipos de reglas por llegadas tardías

        #region Redes Sociales
        public abstract class RedesSociales
        {
            public const int Facebook = 1;
            public const int Chatbot = 2;
            public const int VeinticuatroSeven = 3;
        }
        #endregion Redes Sociales

        #region CanalesComunicacion
        public abstract class CanalesComunicacion
        {
            public const int Notificador = 0;
            public const int NotificadorImportante = 1;
            public const int Email = 2;
            public const int SMS = 3;
        }
        #endregion CanalesComunicacion

        #region Recomendadores
        public abstract class Recomendadores
        {
            public const int PorArticulo = 0;
            public const int PorPersona = 1;
        }
        #endregion Recomendadores

        #region TiposCuentasTransferenciasBancarias
        public abstract class TiposCuentasTransferenciasBancarias
        {
            public const int Empresa = 1;
            public const int Externa = 2;
            public const int Cliente = 3;
            public const int Proveedor = 4;
            public const int Funcionario = 5;
        }
        #endregion TiposCuentasTransferenciasBancarias

        #region Parse
        public abstract class ParseUtil
        {
            public const string Usuario = "@";
        }
        #endregion Parse

        #region ExcepcionesRestError
        public abstract class ExcepcionesRestError
        {
            public const int NO_AUTENTICADO = 401;
            public const int TOKEN_EXPIRADO = 440;
            public const int TOKEN_REQUERIDO = 460;
            public const int TOKEN_INVALIDO = 461;
            public const int ERROR_CLIENTE = 462;
        }
        #endregion ExcepcionesRestError
    }
}



