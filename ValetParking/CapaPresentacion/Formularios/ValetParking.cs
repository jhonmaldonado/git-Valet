using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class ValetParking : Form
    {
        E_Movimiento_PL objEntidad_Movimiento_PL = new E_Movimiento_PL();
        N_Movimiento_PL objNegocio_Movimiento_PL = new N_Movimiento_PL();
        public List<String> TarjetasActivas;
        public List<E_Personal> Personal = new List<E_Personal>();
        public List<E_Ger> Devices = new List<E_Ger>();
        public List<E_Personal_Enturno> Enturno = new List<E_Personal_Enturno>();
        public List<Clases.P_DBEstacionados> ListaEstacionados = new List<Clases.P_DBEstacionados>();

        DataTable Entradas = new DataTable();
        DataTable Estacionados = new DataTable();
        DataTable Saliendo = new DataTable();
        DataTable Turnos = new DataTable();
        DataGridViewRow rowSalidas, rowEntradas;
        Int16 DGSelected = 0; //1 DGEntradas, 2 DGEstacionados, 3 DGSalidas

        public ValetParking()
        {
            InitializeComponent();
        }
        public void CreateTables()
        {
            try
            {                
                //Entradas de vehículos
                Entradas.Columns.Add("Hora Entrada", typeof(string));
                Entradas.Columns.Add("Placa", typeof(string));
                Entradas.Columns.Add("Número de Tiquete", typeof(string));
                Entradas.Columns.Add("Dispositivo Entrada", typeof(string));
                Entradas.Columns.Add("DisositivoNr", typeof(Int16));
                Entradas.Columns.Add("Carpark", typeof(Int16));

                //Vehiculos estacionados
                Estacionados.Columns.Add("Llave", typeof(string));
                Estacionados.Columns.Add("Placa", typeof(string));
                Estacionados.Columns.Add("Número de Tiquete", typeof(string));
                Estacionados.Columns.Add("Zona", typeof(string));
                Estacionados.Columns.Add("Valet Recepción", typeof(string));
                Estacionados.Columns.Add("VP_Id_CupoLlave", typeof(int));
                Estacionados.Columns.Add("VP_IdPersonal_Asignado", typeof(int));
                Estacionados.Columns.Add("VP_IdZona", typeof(int));

                //Entrega de Vehículos
                Saliendo.Columns.Add("Tiempo Entrega", typeof(string));
                Saliendo.Columns.Add("Hora Pago", typeof(string));
                Saliendo.Columns.Add("Dispositivo de Pago", typeof(string));
                Saliendo.Columns.Add("Placa", typeof(string));
                Saliendo.Columns.Add("Número de Tiquete", typeof(string));
                Saliendo.Columns.Add("Valet Recepción", typeof(string));
                Saliendo.Columns.Add("Valet Asignado", typeof(string));
                Saliendo.Columns.Add("Valet Entrega", typeof(string));
                Saliendo.Columns.Add("Zona", typeof(string));
                Saliendo.Columns.Add("Parqueadero", typeof(string));
                Saliendo.Columns.Add("DisositivoNr", typeof(int));
                Saliendo.Columns.Add("VP_IdPersonal_Asignado", typeof(int));
                Saliendo.Columns.Add("VP_IdZona", typeof(int));

                //Turnos
                Turnos.Columns.Add("Siguiente Valet", typeof(string));
                Turnos.Columns.Add("VP_IdPersonal", typeof(int));
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - CreateTables " + ex.ToString());
            }
        }

        #region "Actualizar DatagridView"
        public void ActualizarDGEntradas()
        {
            try
            {
                Entradas.Clear();
                foreach (var Entry in Clases.P_StatusActual.Pendientes)
                {
                    DataRow NewEntrada = Entradas.NewRow();
                    NewEntrada[0] = Entry.Fecha.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
                    NewEntrada[1] = Entry.Placa;
                    NewEntrada[2] = Entry.TicketNumber;
                    NewEntrada[3] = Entry.Dispositivo;
                    NewEntrada[4] = Entry.DisositivoNr;
                    NewEntrada[5] = Entry.Carpark;
                    Entradas.Rows.Add(NewEntrada);
                }

                Entradas.DefaultView.Sort = "Hora Entrada asc, Dispositivo Entrada desc";
                DGEntradas.DataSource = Entradas.DefaultView;
                DGEntradas.Columns[4].Visible = false;
                DGEntradas.Columns[5].Visible = false;
                DGEntradas.ClearSelection();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ActualizarDGEntradas " + ex.ToString());
            }
        }
        public void ActualizarDGEstacionados()
        {
            try
            {
                Estacionados.Clear();
                foreach (var veh in ListaEstacionados)
                {
                    DataRow NewEstacionado = Estacionados.NewRow();
                    NewEstacionado[0] = veh.Llave;
                    NewEstacionado[1] = veh.Placa;
                    NewEstacionado[2] = veh.TicketNumber;
                    NewEstacionado[3] = veh.Zona;
                    NewEstacionado[4] = veh.ValetRecepcion;
                    NewEstacionado[5] = veh.VP_Id_CupoLlave;
                    NewEstacionado[6] = veh.VP_IdPersonal_Asignado;
                    NewEstacionado[7] = veh.VP_IdZona;
                    Estacionados.Rows.Add(NewEstacionado);
                }

                Estacionados.DefaultView.Sort = "Llave asc";
                DGEstacionados.DataSource = Estacionados.DefaultView;
                DGEstacionados.Columns[5].Visible = false;
                DGEstacionados.Columns[6].Visible = false;
                DGEstacionados.Columns[7].Visible = false;
                DGEstacionados.ClearSelection();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ActualizarDGEstacionados " + ex.ToString());
            }
        }
        public void ActualizarDGSalidas()
        {
            try
            {
                Saliendo.Clear();
                foreach (var Exit in Clases.P_StatusActual.SalidasPendientes)
                {
                    DataRow NewSalida = Saliendo.NewRow();
                    NewSalida[0] = string.Format("{0:0}", Exit.TiempoEntrega.Minutes) + ":" + string.Format("{0:0}", Exit.TiempoEntrega.Seconds);
                    NewSalida[1] = Exit.Fecha.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
                    NewSalida[2] = Exit.Dispositivo;
                    NewSalida[3] = Exit.Placa;
                    NewSalida[4] = Exit.TicketNumber;
                    NewSalida[5] = Exit.ValetRecepcion;
                    NewSalida[6] = Exit.ValetAsignado;
                    NewSalida[7] = Exit.ValetEntrega;
                    NewSalida[8] = Exit.Zona;
                    NewSalida[9] = Exit.Carpark;
                    NewSalida[10] = Exit.DisositivoNr;
                    NewSalida[11] = Exit.IdValetEntrega;
                    NewSalida[12] = Exit.IdZona;
                    Saliendo.Rows.Add(NewSalida);
                }

                Saliendo.DefaultView.Sort = "Hora Pago asc, Valet Entrega asc";
                DGSalidas.DataSource = Saliendo.DefaultView;
                DGSalidas.Columns[9].Visible = false;
                DGSalidas.Columns[10].Visible = false;
                DGSalidas.Columns[11].Visible = false;
                DGSalidas.Columns[12].Visible = false;
                DGSalidas.ClearSelection();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ActualizarDGSalidas " + ex.ToString());
            }
        }
        private void ActualizarDGTurnos()
        {
            try
            {
                Turnos.Clear();
                var Empleadosturnos = from turno in Enturno
                                      join persona in Personal on turno.VP_IdPersonal equals persona.VP_IdPersonal
                                      orderby turno.Fecha ascending
                                      select new
                                      {
                                          persona.VP_IdPersonal,
                                          Nombre = persona.Nombres.Substring(0, 3).ToUpper() + persona.Apellidos.Substring(0, 3).ToUpper()
                                      };

                foreach (var turno in Empleadosturnos)
                {
                    Turnos.Rows.Add(turno.Nombre, turno.VP_IdPersonal);
                }

                DGTurnos.DataSource = Turnos.DefaultView;
                DGTurnos.Columns[1].Visible = false;
                DGTurnos.ClearSelection();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ActualizarDGTurnos " + ex.ToString());
            }
        }
        #endregion

        #region "CargaDatos"
        private void ConsultarDevices()
        {
            N_Movimiento_PL objMovimientoPL = new N_Movimiento_PL();
            Devices = objMovimientoPL.ListandoDevices();
        }
        private void FiltrarStatus(string TextoStatus)
        {
            try
            {
                int Status = (from status in Clases.P_ListasStatus.StatusActDeact.AsEnumerable()
                              where status.Status == TextoStatus
                              select status.IdStatus).FirstOrDefault();

                tarjetasactivas(Status);
                CargarEmpleados(Status);
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - FiltrarStatus " + ex.ToString());
            }
        }
        public void tarjetasactivas(int Status)
        {
            try
            {
                N_Personal objPersonal = new N_Personal();
                TarjetasActivas = (from pers in objPersonal.ListandoPersonal(Status)
                                   select
                                   pers.CodigoTarjeta
                                ).ToList();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - tarjetasactivas " + ex.ToString());
            }
        }
        public void CargarEmpleados(int Status)
        {
            try
            {
                N_Personal objPersonal = new N_Personal();
                Personal = (from pers in objPersonal.ListandoPersonal(Status)
                            select new E_Personal
                            {
                                VP_IdPersonal = pers.VP_IdPersonal,
                                VP_Id = pers.VP_Id,
                                VP_IdPerfil = pers.VP_IdPerfil,
                                VP_IdStatus = pers.VP_IdStatus,
                                Nombres = pers.Nombres,
                                Apellidos = pers.Apellidos,
                                Telefono = pers.Telefono,
                                CodigoTarjeta = pers.CodigoTarjeta,
                                RH = pers.RH,
                                PersonaContacto = pers.PersonaContacto,
                                Telefono_PersonaContacto = pers.Telefono_PersonaContacto
                            }).ToList();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - CargarEmpleados " + ex.ToString());
            }
        }
        public void CargarEmpleadosEnturno()
        {
            try
            {                
                N_Personal_Enturno objPersonal_Enturno = new N_Personal_Enturno();
                Enturno = (from pers in objPersonal_Enturno.ListandoPersonal_Enturno()
                           orderby pers.Fecha ascending
                           select new E_Personal_Enturno
                           {
                               Fecha = pers.Fecha,
                               VP_IdPersonal = pers.VP_IdPersonal
                           }).ToList();
                ActualizarDGTurnos();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - CargarEmpleadosEnturno " + ex.ToString());
            }
        }
        #endregion

        private TimeSpan CalcularTiempoRestante(DateTime fechapago)
        {
            TimeSpan restante = TimeSpan.FromSeconds(0);
            try
            {
                restante = fechapago - DateTime.Now;
                restante += TimeSpan.FromMinutes(15);
                return restante;
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - CalcularTiempoRestante " + ex.ToString());
            }
            return restante;
        }
        private string ConsultardispositivoPL(Int16 GerNr)
        {
            string device = (from ger in Devices
                             where ger.GerNr == GerNr
                             select ger.GerBez).FirstOrDefault();
            return device;
        }
        private void ConsultarEntrantes(Int16 seconds)
        {
            try
            {
                N_Movimiento_PL objMovimiento_PL = new N_Movimiento_PL();
                var NewEntries = (from entries in objMovimiento_PL.ListandoMovimientos_EntryExit(seconds)
                                  where entries.MovementType == 0
                                  orderby entries.DeviceNumber, entries.Fecha
                                  select new Clases.P_DBEntries
                                  {
                                      Fecha = entries.Fecha,
                                      Placa = entries.Placa,
                                      TicketNumber = entries.NumeroTiquete,
                                      Dispositivo = entries.DeviceName,
                                      DisositivoNr = entries.DeviceNumber,
                                      Carpark = entries.Carpark
                                  });
                foreach (var Entry in NewEntries)
                {
                    if (!Clases.P_StatusActual.Pendientes.Exists(x => x.TicketNumber.Contains(Entry.TicketNumber)) && !ListaEstacionados.Exists(z => z.TicketNumber.Contains(Entry.TicketNumber)) &&
                        !Clases.P_StatusActual.SalidasPendientes.Exists(x => x.TicketNumber.Contains(Entry.TicketNumber)) && !ListaEstacionados.Exists(z => z.TicketNumber.Contains(Entry.TicketNumber)))
                        Clases.P_StatusActual.Pendientes.Add(Entry);
                }
                ActualizarDGEntradas();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ConsultarEntrantes " + ex.ToString());
            }
        }
        private void ConsultarEstacionados()
        {
            try
            {
                int recepcion = (from tiposm in Clases.P_ListasStatus.TipoMovimiento
                                 where tiposm.Status == "Recepcion"
                                 select tiposm.IdStatus).FirstOrDefault();

                int entrega = (from tiposm in Clases.P_ListasStatus.TipoMovimiento
                               where tiposm.Status == "Entrega"
                               select tiposm.IdStatus).FirstOrDefault();

                N_Movimiento objMovimiento = new N_Movimiento();
                List<E_Movimiento> Movimientos = (from mov in objMovimiento.ListandoMovimientos()
                                                  select mov).ToList();

                List<E_Movimiento> Recepciones = (from recep in Movimientos
                                                  where recep.VP_IdTipo_Movimiento == recepcion
                                                  select recep).ToList();

                List<E_Movimiento> Entregas = (from entreg in Movimientos
                                               where entreg.VP_IdTipo_Movimiento == entrega
                                               select entreg).ToList();

                ListaEstacionados = (from estac in Recepciones
                                     join zona in Clases.P_ListasStatus.Zonasparking on estac.VP_IdZona equals zona.VP_Id_ZonaParking
                                     join llave in Clases.P_ListasStatus.Cuposllaves on estac.VP_Id_CupoLlave equals llave.VP_Id_CupoLlave
                                     join personal in Personal on estac.VP_IdPersonal_Asignado equals personal.VP_IdPersonal
                                     where !Entregas.Exists(x => x.TicketNumber == estac.TicketNumber)
                                     select new Clases.P_DBEstacionados
                                     {
                                         Llave = llave.Cupo,
                                         Placa = estac.PlateNumber,
                                         TicketNumber = estac.TicketNumber,
                                         Zona = zona.Nombre,
                                         ValetRecepcion = personal.Nombres.Substring(0, 3).ToUpper() + personal.Apellidos.Substring(0, 3).ToUpper(),
                                         VP_Id_CupoLlave = estac.VP_Id_CupoLlave,
                                         VP_IdPersonal_Asignado = estac.VP_IdPersonal_Asignado,
                                         VP_IdZona = estac.VP_IdZona
                                     }).ToList();

                ActualizarDGEstacionados();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ConsultarEstacionados " + ex.ToString());
            }
        }
        private void ConsultarTransaccionesRegistradas()
        {
            try
            {
                DateTime fecha = DateTime.Now;
                E_Movimiento E_objMovimiento = new E_Movimiento();
                N_Movimiento N_objMovimiento = new N_Movimiento();

                //Verifica los que ya tienen registro de inicio de entrega
                int tipoMovRrecepcion = (from mov in Clases.P_ListasStatus.TipoMovimiento
                                         where mov.Status == "Recepcion"
                                         select mov.IdStatus).FirstOrDefault();
                int tipoMovEntrega = (from mov in Clases.P_ListasStatus.TipoMovimiento
                                      where mov.Status == "Entrega"
                                      select mov.IdStatus).FirstOrDefault();

                int tipoStatus = (from status in Clases.P_ListasStatus.StatusMovimiento
                                  where status.Status == "Entregado"
                                  select status.IdStatus).FirstOrDefault();

                //Consulto movimientos de las ultimas 24 horas en DB
                List<E_Movimiento> MovimientoUltDia = (from mobimiento in N_objMovimiento.ListandoMovimientos()
                                                       select mobimiento).ToList();

                var Entregando = (from entregando in MovimientoUltDia
                                  join zona in Clases.P_ListasStatus.Zonasparking on entregando.VP_IdZona equals zona.VP_Id_ZonaParking
                                  where entregando.VP_IdTipo_Movimiento == tipoMovEntrega && entregando.VP_IdStatus != tipoStatus
                                  orderby entregando.FechaInicioProceso ascending
                                  select new Clases.P_DBExit
                                  {
                                      VP_IdMovimiento = entregando.VP_IdMovimiento,
                                      TiempoEntrega = CalcularTiempoRestante(entregando.FechaInicioProceso),
                                      Fecha = entregando.FechaInicioProceso,
                                      Placa = entregando.PlateNumber,
                                      TicketNumber = entregando.TicketNumber,
                                      Zona = zona.Nombre,
                                      IdZona = zona.VP_Id_ZonaParking,
                                      IdValetEntrega = entregando.VP_IdPersonal_Servicio,
                                      IdValetAsignado = entregando.VP_IdPersonal_Asignado,
                                      IdValetRecepcion = 0,
                                      ValetEntrega = "",
                                      ValetAsignado = "",
                                      ValetRecepcion = "",
                                      Dispositivo = ConsultardispositivoPL(entregando.Device),
                                      DisositivoNr = entregando.Device,
                                      Carpark = entregando.Carpark
                                  });

                var Recepcion = (from recepcion in MovimientoUltDia
                                 where recepcion.VP_IdTipo_Movimiento == tipoMovRrecepcion
                                 select recepcion);

                Clases.P_StatusActual.SalidasPendientes.Clear();
                foreach (var veh in Entregando)
                {
                    string asignado = (from persona in Personal
                                       where persona.VP_IdPersonal == veh.IdValetAsignado
                                       select persona.Nombres.Substring(0, 3).ToUpper() + persona.Apellidos.Substring(0, 3).ToUpper()).FirstOrDefault();
                    string servicio = (from persona in Personal
                                       where persona.VP_IdPersonal == veh.IdValetEntrega
                                       select persona.Nombres.Substring(0, 3).ToUpper() + persona.Apellidos.Substring(0, 3).ToUpper()).FirstOrDefault();

                    string recepcion = (from recep in Recepcion
                                        join persona in Personal on recep.VP_IdPersonal_Servicio equals persona.VP_IdPersonal
                                        where recep.TicketNumber == veh.TicketNumber
                                        select persona.Nombres.Substring(0, 3).ToUpper() + persona.Apellidos.Substring(0, 3).ToUpper()
                                       ).FirstOrDefault();

                    veh.ValetAsignado = asignado;
                    veh.ValetEntrega = servicio;
                    veh.ValetRecepcion = recepcion;

                    Clases.P_StatusActual.SalidasPendientes.Add(veh);
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ConsultarTransaccionesRegistradas " + ex.ToString());
            }
        }
        private void ConsultarTransacciones(Int16 seconds)
        {
            try
            {
                ConsultarTransaccionesRegistradas();
                N_Movimiento_PL N_objMovimiento_PL = new N_Movimiento_PL();
                N_Personal_Enturno N_objPersonal = new N_Personal_Enturno();
                //Verifica las nuevas entregas
                var NewPayments = (from payment in N_objMovimiento_PL.ListandoMovimientos_Transaction(seconds)
                                   join estacionados in ListaEstacionados on payment.NumeroTiquete equals estacionados.TicketNumber
                                   join zona in Clases.P_ListasStatus.Zonasparking on estacionados.VP_IdZona equals zona.VP_Id_ZonaParking
                                   orderby payment.Fecha descending
                                   select new Clases.P_DBExit
                                   {
                                       TiempoEntrega = CalcularTiempoRestante(payment.Fecha),
                                       Fecha = payment.Fecha,
                                       Placa = payment.Placa,
                                       TicketNumber = payment.NumeroTiquete,
                                       Zona = zona.Nombre,
                                       IdZona = zona.VP_Id_ZonaParking,
                                       IdValetEntrega = 0,
                                       IdValetRecepcion = 0,
                                       IdValetAsignado = estacionados.VP_IdPersonal_Asignado,
                                       ValetEntrega = "",
                                       ValetRecepcion = "",
                                       ValetAsignado = estacionados.ValetRecepcion,
                                       Dispositivo = payment.DeviceName,
                                       DisositivoNr = payment.DeviceNumber,
                                       Carpark = payment.Carpark,
                                       IdCupoLlave = estacionados.VP_Id_CupoLlave
                                   });

                foreach (var Payment in NewPayments)
                {
                    foreach (var turno in Enturno)
                    {
                        string sigturno = (from persona in Personal
                                           where persona.VP_IdPersonal == turno.VP_IdPersonal
                                           select persona.Nombres.Substring(0, 3).ToUpper() + persona.Apellidos.Substring(0, 3).ToUpper()).FirstOrDefault();

                        Payment.IdValetAsignado = turno.VP_IdPersonal;
                        Payment.ValetAsignado = sigturno;

                        //Actualiza turno   
                        turno.Fecha = DateTime.Now; //Actualiza fecha indicando que el empleado usó su turno y vuelve a la cola
                        N_objPersonal.ActualizandoPersonal_Enturno(turno);
                        CargarEmpleadosEnturno(); //Actualiza lista de personal en turno y datagridview
                        break;
                    }
                    if (!Clases.P_StatusActual.SalidasPendientes.Exists(x => x.TicketNumber.Contains(Payment.TicketNumber)))
                    {
                        RegistrarSalida(Payment, "Entrega", "Creado", true); //Se inserta movimiento como creado.  
                        ConsultarTransaccionesRegistradas(); //Consulta nuevamente listado de movimientos.
                    }
                }
                ActualizarDGSalidas();
                ConsultarEstacionados(); //Actualiza estacionados.
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - ConsultarTransacciones " + ex.ToString());
            }
        }
        private void LimpiarEntrantes(Int16 minutes)
        {
            try
            {
                DateTime time = DateTime.Now.AddMinutes(minutes);

                if (Clases.P_StatusActual.Pendientes.Count > 0)
                {
                    for (int i = 0; i < Clases.P_StatusActual.Pendientes.Count; i++)
                    {
                        if (Clases.P_StatusActual.Pendientes[i].Fecha < time)
                        {
                            Clases.P_StatusActual.Pendientes.RemoveAt(i);
                        }
                    }
                    ActualizarDGEntradas();
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - LimpiarEntrantes " + ex.ToString());
            }
        }
        private void tMovimientos_Tick(object sender, EventArgs e)
        {
            ConsultarEntrantes(-16); //Consulta vehículos entrando en los ultimos 16 segundos.  
            ConsultarTransacciones(-16); //Consulta pagos en los ultimos 16 segundos.  
        }
        private void tLimpiar_Tick(object sender, EventArgs e)
        {
            LimpiarEntrantes(-15); //Retira de la lista lo vehículos de más de 15 minutos.
        }
        private void ValetParking_Load(object sender, EventArgs e)
        {
            CreateTables();
            ConsultarDevices(); //Trae lista dispositivos Parking Logic
            FiltrarStatus("Activo"); //Consulta lista de empleados y tarjetas activas.
            CargarEmpleadosEnturno(); //Consulta personal en turno.
            ConsultarEstacionados(); //Consulta vehículos estacionados.
            ConsultarTransacciones(-900); //Consulta pagos de los últimos 15 minutos.
            ConsultarEntrantes(-900); //Consulta vehículos entrando en los ultimos 15 minutos.            
        }
        private void DGEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string TarjetaValet = "";
            try
            {
                DGSelected = 1;
                rowEntradas = DGEntradas.Rows[e.RowIndex];
                LeerTarjeta LeerTarjeta = new LeerTarjeta("Por favor acerque una tarjeta al lector.", TarjetasActivas, false);
                if (LeerTarjeta.ShowDialog() == DialogResult.OK)
                {
                    TarjetaValet = LeerTarjeta.Tarjeta;//lee la propiedad
                }

                int idpersonal = 0;
                foreach (var employed in Personal)
                {
                    if (employed.CodigoTarjeta == TarjetaValet)
                    {
                        idpersonal = employed.VP_IdPersonal;
                        break;
                    }
                }

                if (Enturno.Exists(x => x.VP_IdPersonal == idpersonal))
                {
                    RegistrarEntrada(idpersonal);
                    ConsultarEstacionados();
                }
                else if (!string.IsNullOrEmpty(TarjetaValet))
                {
                    MessageErrorOk Message = new MessageErrorOk("Usted no se encuentra en turno.", 3);
                    Message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - DGEntradas_CellDoubleClick " + ex.ToString());
            }            
        }
        private void DGSalidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string TarjetaValet = "";
            try
            {
                N_Personal_Enturno N_objPersonal = new N_Personal_Enturno();
                DGSelected = 3;
                rowSalidas = DGSalidas.Rows[e.RowIndex];
                LeerTarjeta LeerTarjeta = new LeerTarjeta("Por favor acerque una tarjeta al lector.", TarjetasActivas, false);
                if (LeerTarjeta.ShowDialog() == DialogResult.OK)
                {
                    TarjetaValet = LeerTarjeta.Tarjeta;//lee la propiedad
                }

                int idpersonal = 0;
                foreach (var employed in Personal)
                {
                    if (employed.CodigoTarjeta == TarjetaValet)
                    {
                        idpersonal = employed.VP_IdPersonal;
                        break;
                    }
                }

                Clases.P_DBExit objExit = new Clases.P_DBExit();
                if (Enturno.Exists(x => x.VP_IdPersonal == idpersonal))
                {
                    objExit = (from act in Clases.P_StatusActual.SalidasPendientes
                               where act.TicketNumber == rowSalidas.Cells[4].Value.ToString() //Numtiquete
                               select act).FirstOrDefault();
                    objExit.IdValetEntrega = idpersonal;
                    RegistrarSalida(objExit, "Entrega", "Procesado", false); //Se inserta movimiento como creado. 

                    foreach (var turno in Enturno)
                    {
                        //Actualiza turno 
                        if (turno.VP_IdPersonal == idpersonal)
                        {
                            turno.Fecha = DateTime.Now; //Actualiza fecha indicando que el empleado usó su turno y vuelve a la cola
                            N_objPersonal.ActualizandoPersonal_Enturno(turno);
                            CargarEmpleadosEnturno(); //Actualiza lista de personal en turno y datagridview
                            break;
                        }
                    }

                    ConsultarTransacciones(-16);
                }
                else if (!string.IsNullOrEmpty(TarjetaValet))
                {
                    MessageErrorOk Message = new MessageErrorOk("Usted no se encuentra en turno.", 3);
                    Message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - DGSalidas_CellDoubleClick " + ex.ToString());
            }            
        }
        private void LimpiarVehículoRecepcion(string ticketnumber)
        {
            try
            {
                if (Clases.P_StatusActual.Pendientes.Count > 0)
                {
                    for (int i = 0; i < Clases.P_StatusActual.Pendientes.Count; i++)
                    {
                        if (Clases.P_StatusActual.Pendientes[i].TicketNumber == ticketnumber)
                        {
                            Clases.P_StatusActual.Pendientes.RemoveAt(i);
                        }
                    }
                    ActualizarDGEntradas();
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - LimpiarVehículoRecepcion " + ex.ToString());
            }
        }
        private void RegistrarEntrada(int idpersonal)
        {
            try
            {
                int IdStatus = (from statusm in Clases.P_ListasStatus.StatusMovimiento
                                where statusm.Status == "Procesado"
                                select statusm.IdStatus).FirstOrDefault();

                int IdMovimiento = (from tiposm in Clases.P_ListasStatus.TipoMovimiento
                                    where tiposm.Status == "Recepcion"
                                    select tiposm.IdStatus).FirstOrDefault();

                //Pendiente
                int IdZona = (from zonasp in Clases.P_ListasStatus.Zonasparking
                              where zonasp.Nombre == "Verde"
                              select zonasp.VP_Id_ZonaParking).FirstOrDefault();


                int[] IdLlaves = (from llave in Clases.P_ListasStatus.Cuposllaves
                                  orderby llave.VP_Id_CupoLlave ascending
                                  select llave.VP_Id_CupoLlave).ToArray();
                int idLlave = 0;
                foreach (int Llave in IdLlaves)
                {
                    if (!ListaEstacionados.Exists(x => x.VP_Id_CupoLlave == Llave))
                    {
                        idLlave = Llave;
                        break;
                    }
                }

                DateTime fecha = DateTime.Now;
                E_Movimiento objEntidad_Movimiento = new E_Movimiento();
                objEntidad_Movimiento = (from pendientes in Clases.P_StatusActual.Pendientes
                                         where pendientes.TicketNumber == Convert.ToString(rowEntradas.Cells[2].Value) //Número de Tiquete
                                         select new E_Movimiento
                                         {
                                             VP_IdTipo_Movimiento = IdMovimiento,
                                             VP_Id_CupoLlave = idLlave,
                                             VP_IdPersonal_Asignado = idpersonal,
                                             VP_IdPersonal_Servicio = idpersonal,
                                             VP_IdZona = IdZona, //Pendiente
                                             VP_IdStatus = IdStatus,
                                             FechaInicioProceso = pendientes.Fecha,
                                             FechaFinProceso = fecha,
                                             PlateNumber = pendientes.Placa,
                                             TicketNumber = pendientes.TicketNumber,
                                             Device = pendientes.DisositivoNr,
                                             Carpark = pendientes.Carpark,
                                         }).FirstOrDefault();

                N_Movimiento objNegocio_Movimiento = new N_Movimiento();
                objNegocio_Movimiento.InsertandoMovimiento(objEntidad_Movimiento);

                LimpiarVehículoRecepcion(Convert.ToString(rowEntradas.Cells[2].Value)); //Limpia vehiculo de la lista de entrantes
            }
            catch (Exception ex)
            {
                MessageErrorOk Message = new MessageErrorOk("Error al intentar realizar recepción del vehículo.", 1);
                Message.ShowDialog();
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - RegistrarEntrada " + ex.ToString());
            }
        }
        private void RegistrarSalida(Clases.P_DBExit Salida, string TextoMovmiento, string TextoStatus, bool Insert)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                E_Movimiento E_objMovimiento = new E_Movimiento();
                N_Movimiento N_objMovimiento = new N_Movimiento();

                int tipoMov = (from mov in Clases.P_ListasStatus.TipoMovimiento
                               where mov.Status == TextoMovmiento
                               select mov.IdStatus).FirstOrDefault();

                int tipoStatus = (from status in Clases.P_ListasStatus.StatusMovimiento
                                  where status.Status == TextoStatus
                                  select status.IdStatus).FirstOrDefault();

                E_objMovimiento.VP_IdMovimiento = Salida.VP_IdMovimiento;
                E_objMovimiento.VP_IdTipo_Movimiento = tipoMov;
                E_objMovimiento.VP_Id_CupoLlave = Salida.IdCupoLlave;
                E_objMovimiento.VP_IdPersonal_Asignado = Salida.IdValetAsignado;
                E_objMovimiento.VP_IdPersonal_Servicio = Salida.IdValetEntrega;
                E_objMovimiento.VP_IdZona = Salida.IdZona;
                E_objMovimiento.VP_IdStatus = tipoStatus; //Estatus Creado
                E_objMovimiento.FechaInicioProceso = fecha;
                E_objMovimiento.FechaFinProceso = fecha;
                E_objMovimiento.PlateNumber = Salida.Placa;
                E_objMovimiento.TicketNumber = Salida.TicketNumber;
                E_objMovimiento.Device = Salida.DisositivoNr;
                E_objMovimiento.Carpark = Salida.Carpark;

                if (Insert)
                {
                    N_objMovimiento.InsertandoMovimiento(E_objMovimiento); //Se inserta movimiento
                }
                else
                {
                    N_objMovimiento.EditandoMovimiento(E_objMovimiento); //Se inserta movimiento
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - RegistrarSalida " + ex.ToString());
            }
        }

        //Entrar o Salir de turno
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                N_Personal_Enturno N_objPersonal = new N_Personal_Enturno();
                string TarjetaValet = "";
                LeerTarjeta LeerTarjeta = new LeerTarjeta("Por favor acerque una tarjeta al lector.", TarjetasActivas, false);
                if (LeerTarjeta.ShowDialog() == DialogResult.OK)
                {
                    TarjetaValet = LeerTarjeta.Tarjeta;//lee la propiedad
                }
                else
                {
                    return;
                }

                var PersonalEnTurno = (from enturno in Enturno
                                       join persona in Personal on enturno.VP_IdPersonal equals persona.VP_IdPersonal
                                       where persona.CodigoTarjeta == TarjetaValet
                                       select persona).FirstOrDefault();

                if (PersonalEnTurno != null)
                {
                    var TurnoEliminar = (from enturno in Enturno
                                         join persona in Personal on enturno.VP_IdPersonal equals persona.VP_IdPersonal
                                         where persona.CodigoTarjeta == TarjetaValet
                                         select enturno).FirstOrDefault();

                    //Persona se encuentra en turno
                    MessageSiNo Mensaje = new MessageSiNo("¿Quiere salir de turno sr(a) " + PersonalEnTurno.Nombres + " " + PersonalEnTurno.Apellidos + "?");
                    if (Mensaje.ShowDialog() == DialogResult.Yes)
                    {
                        //Sale de turno                    
                        N_objPersonal.EliminandoPersonal_Enturno(TurnoEliminar);
                    }
                }
                else
                {
                    var TurnoInsertar = (from persona in Personal
                                         where persona.CodigoTarjeta == TarjetaValet
                                         select new E_Personal_Enturno
                                         {
                                             Fecha = fecha,
                                             VP_IdPersonal = persona.VP_IdPersonal
                                         }).FirstOrDefault();

                    var PersonalNuevoTurno = (from persona in Personal
                                              where persona.CodigoTarjeta == TarjetaValet
                                              select persona).FirstOrDefault();

                    //Persona entrará a turno
                    MessageErrorOk Mensaje = new MessageErrorOk("Bienvenido sr(a) " + PersonalNuevoTurno.Nombres + " " + PersonalNuevoTurno.Apellidos + Environment.NewLine + "Se inició turno con éxito.", 2);
                    Mensaje.ShowDialog();
                    //Sale de turno
                    N_objPersonal.InsertandoPersonal_Enturno(TurnoInsertar);
                }
                CargarEmpleadosEnturno();
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - EntraroSalirTurno " + ex.ToString());
            }
        }
        private void DGTURNOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGTurnos.ClearSelection();
        }

        //Limpia selección cuando se carga formulario.
        private void tLimpiarSeleccion_Tick(object sender, EventArgs e)
        {
            DGEntradas.ClearSelection();
            DGEstacionados.ClearSelection();
            DGSalidas.ClearSelection();
            DGTurnos.ClearSelection();
            tLimpiarSeleccion.Enabled = false;
        }
        private void tRelojSalidas_Tick(object sender, EventArgs e)
        {
            try
            {                
                foreach (DataGridViewRow RowItem in DGSalidas.Rows)
                {
                    string TicketNumber = RowItem.Cells[4].Value.ToString();
                    foreach (var pendiente in Clases.P_StatusActual.SalidasPendientes)
                    {
                        if (pendiente.TicketNumber == TicketNumber && pendiente.TiempoEntrega > TimeSpan.FromSeconds(-1))
                        {
                            pendiente.TiempoEntrega += TimeSpan.FromSeconds(-1);
                            break;
                        }
                    }

                    TimeSpan tiemporestante = (from pendientes in Clases.P_StatusActual.SalidasPendientes
                                               where pendientes.TicketNumber == TicketNumber
                                               select pendientes.TiempoEntrega).FirstOrDefault();
                    //Pinta texto si quedan menos de cinco minutos
                    if (tiemporestante < TimeSpan.FromMinutes(5))
                    {
                        foreach (DataGridViewCell Cell in RowItem.Cells)
                        {
                            Cell.Style.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        foreach (DataGridViewCell Cell in RowItem.Cells)
                        {
                            Cell.Style.ForeColor = Color.Black;
                        }
                    }
                    RowItem.Cells[0].Value = tiemporestante.Minutes.ToString("D2") + ":" + tiemporestante.Seconds.ToString("D2");
                }
            }
            catch (Exception ex)
            {
                //Entrada de LOG                
                Clases.P_LogWriter objLog = new Clases.P_LogWriter("ValetParking - tRelojSalidas " + ex.ToString());
            }
        }
    }
}
