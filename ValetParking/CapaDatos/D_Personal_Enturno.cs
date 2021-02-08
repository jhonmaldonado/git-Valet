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
    public class D_Personal_Enturno
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FdicoDB"].ConnectionString);
        public List<E_Personal_Enturno> ListarPersonal_Enturno()
        {
            string Query = "SELECT * FROM VP_Personal_Enturno;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();          

            LeerFilas = cmd.ExecuteReader();

            List<E_Personal_Enturno> Listar = new List<E_Personal_Enturno>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Personal_Enturno
                {
                    Fecha = LeerFilas.GetDateTime(0),
                    VP_IdPersonal = LeerFilas.GetInt32(1)                    
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }
        public void InsertarPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            string Query = @"INSERT INTO [dbo].[VP_Personal_Enturno]
                            ([Fecha] ,[VP_IdPersonal])
                            VALUES
                            (@Fecha, @VP_IdPersonal);";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@Fecha", Personal_Enturno.Fecha);
            cmd.Parameters.AddWithValue("@VP_IdPersonal", Personal_Enturno.VP_IdPersonal);            
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void ActualizarPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            string Query = @"UPDATE [dbo].[VP_Personal_Enturno] SET Fecha = @Fecha
                            WHERE VP_IdPersonal = @VP_IdPersonal;";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdPersonal", Personal_Enturno.VP_IdPersonal);
            cmd.Parameters.AddWithValue("@Fecha", Personal_Enturno.Fecha);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EliminarPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            string Query = @"DELETE FROM [dbo].[VP_Personal_Enturno]
                            WHERE VP_IdPersonal = @VP_IdPersonal;";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();  
            
            cmd.Parameters.AddWithValue("@VP_IdPersonal", Personal_Enturno.VP_IdPersonal);            
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
