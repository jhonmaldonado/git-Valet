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
    public class D_Movimiento_PL
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ParkDB"].ConnectionString);
        public List<E_Movimiento_PL> ListarMovimiento_PL_EntryExit(Int32 seconds)
        {
            string Query = @"SELECT SDKARTEBEWEGUNG.Ztpkt AS Fecha, dbo.sd_cardno(dbo.SDKARTEBEWEGUNG.KartePhNr, dbo.SDKARTEBEWEGUNG.KarteZtpkt, dbo.SDKARTEBEWEGUNG.KarteKartenNr) AS NumeroTiquete,
                            Kennzeichen AS Placa,
                            GerNr AS DeviceNumber,
                            GerBez AS DeviceName,
                            Bewegung AS MovementType,
							PhNr AS Carpark
                            FROM SDKARTEBEWEGUNG WITH(NOLOCK)
                            WHERE Bewegung IN (0,4) AND AbweisungsNr = 0  AND SDKARTEBEWEGUNG.Ztpkt BETWEEN DATEADD (SECOND , @Seconds , GETDATE()) AND GETDATE()
                            ORDER BY Bewegung;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();
            cmd.Parameters.AddWithValue("@Seconds", seconds);

            LeerFilas = cmd.ExecuteReader();            

            List<E_Movimiento_PL> Listar = new List<E_Movimiento_PL>();  
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Movimiento_PL
                {
                    Fecha = LeerFilas.GetDateTime(0),
                    NumeroTiquete = LeerFilas.GetString(1),
                    Placa = LeerFilas.GetString(2),
                    DeviceNumber = LeerFilas.GetInt16(3),
                    DeviceName = LeerFilas.GetString(4),
                    MovementType = LeerFilas.GetByte(5),
                    Carpark = LeerFilas.GetByte(6)
                });
            }
            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }
        public List<E_Movimiento_PL> ListarMovimiento_PL_Transaction(Int32 seconds)
        {
            string Query = @"SELECT SDKARTEBEWEGUNG.Ztpkt AS Fecha, dbo.sd_cardno(dbo.SDKARTEBEWEGUNG.KartePhNr, dbo.SDKARTEBEWEGUNG.KarteZtpkt, dbo.SDKARTEBEWEGUNG.KarteKartenNr) AS NumeroTiquete,
                            Kennzeichen AS Placa,
                            GerNr AS DeviceNumber,
                            GerBez AS DeviceName,
                            Bewegung AS MovementType,
							PhNr AS Carpark
                            FROM SDKARTEBEWEGUNG WITH(NOLOCK)
                            WHERE Bewegung IN (1) AND AbweisungsNr = 0  AND SDKARTEBEWEGUNG.Ztpkt BETWEEN DATEADD (SECOND , @Seconds , GETDATE()) AND GETDATE()
                            ORDER BY Bewegung;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();
            cmd.Parameters.AddWithValue("@Seconds", seconds);

            LeerFilas = cmd.ExecuteReader();

            List<E_Movimiento_PL> Listar = new List<E_Movimiento_PL>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Movimiento_PL
                {
                    Fecha = LeerFilas.GetDateTime(0),
                    NumeroTiquete = LeerFilas.GetString(1),
                    Placa = LeerFilas.GetString(2),
                    DeviceNumber = LeerFilas.GetInt16(3),
                    DeviceName = LeerFilas.GetString(4),
                    MovementType = LeerFilas.GetByte(5),
                    Carpark = LeerFilas.GetByte(6)
                });
            }
            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }
        public List<E_Ger> ListarDevices()
        {
            string Query = @"SELECT GerNr, GerBez FROM GER;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();            

            LeerFilas = cmd.ExecuteReader();

            List<E_Ger> Listar = new List<E_Ger>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Ger
                {
                    GerNr = LeerFilas.GetInt16(0),
                    GerBez = LeerFilas.GetString(1)                   
                });
            }
            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }
    }    
}
