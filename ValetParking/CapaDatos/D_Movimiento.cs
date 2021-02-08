using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Movimiento
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FdicoDB"].ConnectionString);
        public List<E_Movimiento> ListarMovimiento()
        {
            string Query = "SELECT * FROM VP_Movimiento WHERE FechaInicioProceso > DATEADD(dd, -1, Getdate());";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open(); 
            
            LeerFilas = cmd.ExecuteReader();

            List<E_Movimiento> Listar = new List<E_Movimiento>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Movimiento
                {
                    VP_IdMovimiento = LeerFilas.GetInt32(0),
                    VP_IdTipo_Movimiento = LeerFilas.GetInt32(1),
                    VP_Id_CupoLlave = LeerFilas.GetInt32(2),
                    VP_IdPersonal_Asignado = LeerFilas.GetInt32(3),
                    VP_IdPersonal_Servicio = LeerFilas.GetInt32(4),
                    VP_IdZona = LeerFilas.GetInt32(5),
                    VP_IdStatus = LeerFilas.GetInt32(6),
                    FechaInicioProceso = LeerFilas.GetDateTime(7),
                    FechaFinProceso = LeerFilas.GetDateTime(8),
                    PlateNumber = LeerFilas.GetString(9),
                    TicketNumber = LeerFilas.GetString(10),
                    Device = LeerFilas.GetInt16(11),
                    Carpark = LeerFilas.GetByte(12)
                });
            }
            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }
        public void InsertarMovimiento(E_Movimiento Movimiento)
        {
            string Query = @"INSERT INTO [dbo].[VP_Movimiento]
                            ([VP_IdTipo_Movimiento],[VP_Id_CupoLlave],[VP_IdPersonal_Asignado],[VP_IdPersonal_Servicio],[VP_IdZona],[VP_IdStatus],[FechaInicioProceso],[FechaFinProceso],[PlateNumber],[TicketNumber],[Device],[Carpark])
                            VALUES
                            (@VP_IdTipo_Movimiento,@VP_Id_CupoLlave,@VP_IdPersonal_Asignado,@VP_IdPersonal_Servicio,@VP_IdZona,@VP_IdStatus,@FechaInicioProceso,@FechaFinProceso,@PlateNumber,@TicketNumber,@Device,@Carpark);";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdTipo_Movimiento", Movimiento.VP_IdTipo_Movimiento);
            cmd.Parameters.AddWithValue("@VP_Id_CupoLlave", Movimiento.VP_Id_CupoLlave);
            cmd.Parameters.AddWithValue("@VP_IdPersonal_Asignado", Movimiento.VP_IdPersonal_Asignado);
            cmd.Parameters.AddWithValue("@VP_IdPersonal_Servicio", Movimiento.VP_IdPersonal_Servicio);
            cmd.Parameters.AddWithValue("@VP_IdZona", Movimiento.VP_IdZona);
            cmd.Parameters.AddWithValue("@VP_IdStatus", Movimiento.VP_IdStatus);
            cmd.Parameters.AddWithValue("@FechaInicioProceso", Movimiento.FechaInicioProceso);
            cmd.Parameters.AddWithValue("@FechaFinProceso", Movimiento.FechaFinProceso);
            cmd.Parameters.AddWithValue("@PlateNumber", Movimiento.PlateNumber);
            cmd.Parameters.AddWithValue("@TicketNumber", Movimiento.TicketNumber);
            cmd.Parameters.AddWithValue("@Device", Movimiento.Device);
            cmd.Parameters.AddWithValue("@Carpark", Movimiento.Carpark);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EditarMovimiento(E_Movimiento Movimiento)
        {
            string Query = @"UPDATE [dbo].[VP_Movimiento]
                            SET [VP_IdTipo_Movimiento] = @VP_IdTipo_Movimiento
                                ,[VP_Id_CupoLlave] = @VP_Id_CupoLlave
                                ,[VP_IdPersonal_Asignado] = @VP_IdPersonal_Asignado
                                ,[VP_IdPersonal_Servicio] = @VP_IdPersonal_Servicio
                                ,[VP_IdZona] = @VP_IdZona
                                ,[VP_IdStatus] = @VP_IdStatus
                                ,[FechaInicioProceso] = @FechaInicioProceso
                                ,[FechaFinProceso] = @FechaFinProceso
                                ,[PlateNumber] = @PlateNumber
                                ,[TicketNumber] = @TicketNumber
                                ,[Device] = @Device
                                ,[Carpark] = @Carpark
                            WHERE VP_IdMovimiento = @VP_IdMovimiento;";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdMovimiento", Movimiento.VP_IdMovimiento);
            cmd.Parameters.AddWithValue("@VP_IdTipo_Movimiento", Movimiento.VP_IdTipo_Movimiento);
            cmd.Parameters.AddWithValue("@VP_Id_CupoLlave", Movimiento.VP_Id_CupoLlave);
            cmd.Parameters.AddWithValue("@VP_IdPersonal_Asignado", Movimiento.VP_IdPersonal_Asignado);
            cmd.Parameters.AddWithValue("@VP_IdPersonal_Servicio", Movimiento.VP_IdPersonal_Servicio);
            cmd.Parameters.AddWithValue("@VP_IdZona", Movimiento.VP_IdZona);
            cmd.Parameters.AddWithValue("@VP_IdStatus", Movimiento.VP_IdStatus);
            cmd.Parameters.AddWithValue("@FechaInicioProceso", Movimiento.FechaInicioProceso);
            cmd.Parameters.AddWithValue("@FechaFinProceso", Movimiento.FechaFinProceso);
            cmd.Parameters.AddWithValue("@PlateNumber", Movimiento.PlateNumber);
            cmd.Parameters.AddWithValue("@TicketNumber", Movimiento.TicketNumber);
            cmd.Parameters.AddWithValue("@Device", Movimiento.Device);
            cmd.Parameters.AddWithValue("@Carpark", Movimiento.Carpark);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EliminarMovimiento(E_Movimiento Movimiento)
        {
            string Query = @"DELETE FROM [dbo].[VP_Movimiento]
                            WHERE VP_IdMovimiento = @VP_IdMovimiento;";

            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdMovimiento", Movimiento.VP_IdMovimiento);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
