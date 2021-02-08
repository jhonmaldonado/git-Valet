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
    public class D_Personal
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FdicoDB"].ConnectionString);
        public List<E_Personal> ListarPersonal(int Status)
        {
            string Query = "SELECT * FROM VP_Personal WHERE VP_IdStatus = @IDSTATUS;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDSTATUS", Status);

            LeerFilas = cmd.ExecuteReader();

            List<E_Personal> Listar = new List<E_Personal>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Personal
                {
                    VP_IdPersonal = LeerFilas.GetInt32(0),
                    VP_Id = LeerFilas.GetString(1),
                    VP_IdPerfil = LeerFilas.GetInt32(2),
                    VP_IdStatus = LeerFilas.GetInt32(3),
                    Nombres = LeerFilas.GetString(4),
                    Apellidos = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    CodigoTarjeta = LeerFilas.GetString(7),
                    RH = LeerFilas.GetString(8),
                    PersonaContacto = LeerFilas.GetString(9),
                    Telefono_PersonaContacto = LeerFilas.GetString(10)
                });
            }
            conexion.Close();
            LeerFilas.Close();  
            return Listar;
        }        
        public void InsertarPersonal(E_Personal Personal)
        {
            string Query = @"INSERT INTO [dbo].[VP_Personal]
                            ([VP_IdPerfil],[VP_IdStatus],[Nombres],[Apellidos],[Telefono],[CodigoTarjeta],[RH],[PersonaContacto],[Telefono_PersonaContacto])
                            VALUES
                            (@VP_IdPerfil,@VP_IdStatus,@Nombres,@Apellidos,@Telefono,@CodigoTarjeta,@RH,@PersonaContacto,@Telefono_PersonaContacto);";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdPerfil", Personal.VP_IdPerfil);
            cmd.Parameters.AddWithValue("@VP_IdStatus", Personal.VP_IdStatus);
            cmd.Parameters.AddWithValue("@Nombres", Personal.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", Personal.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Personal.Telefono);
            cmd.Parameters.AddWithValue("@CodigoTarjeta", Personal.CodigoTarjeta);
            cmd.Parameters.AddWithValue("@RH", Personal.RH);
            cmd.Parameters.AddWithValue("@PersonaContacto", Personal.PersonaContacto);
            cmd.Parameters.AddWithValue("@Telefono_PersonaContacto", Personal.Telefono_PersonaContacto);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EditarPersonal(E_Personal Personal)
        {
            string Query = @"UPDATE [dbo].[VP_Personal]
                               SET [VP_IdPerfil] = @VP_IdPerfil
                                  ,[VP_IdStatus] = @VP_IdStatus
                                  ,[Nombres] = @Nombres
                                  ,[Apellidos] = @Apellidos
                                  ,[Telefono] = @Telefono
                                  ,[CodigoTarjeta] = @CodigoTarjeta
                                  ,[RH] = @RH
                                  ,[PersonaContacto] = @PersonaContacto
                                  ,[Telefono_PersonaContacto] = @Telefono_PersonaContacto
                             WHERE [VP_IdPersonal] = @VP_IdPersonal;";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdPersonal", Personal.VP_IdPersonal);
            cmd.Parameters.AddWithValue("@VP_IdPerfil", Personal.VP_IdPerfil);
            cmd.Parameters.AddWithValue("@VP_IdStatus", Personal.VP_IdStatus);
            cmd.Parameters.AddWithValue("@Nombres", Personal.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", Personal.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Personal.Telefono);
            cmd.Parameters.AddWithValue("@CodigoTarjeta", Personal.CodigoTarjeta);
            cmd.Parameters.AddWithValue("@RH", Personal.RH);
            cmd.Parameters.AddWithValue("@PersonaContacto", Personal.PersonaContacto);
            cmd.Parameters.AddWithValue("@Telefono_PersonaContacto", Personal.Telefono_PersonaContacto);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}

