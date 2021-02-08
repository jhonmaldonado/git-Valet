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
    public class D_Parametros
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FdicoDB"].ConnectionString);
        public List<E_Parametros> ListarParametros(bool Estado)
        {
            string Query = "SELECT * FROM VP_Parametros WHERE VP_Estado = @VP_Estado;";
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();
            
            cmd.Parameters.AddWithValue("@VP_Estado", Estado);
            LeerFilas = cmd.ExecuteReader();

            List<E_Parametros> Listar = new List<E_Parametros>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Parametros
                {
                    VP_IdParametro = LeerFilas.GetInt32(0),
                    VP_TipoParametro = LeerFilas.GetString(1),
                    VP_Estado = LeerFilas.GetBoolean(2),
                    VP_Parametro1 = LeerFilas.GetString(3),
                    VP_Parametro2 = LeerFilas.GetString(4),
                    VP_Parametro3 = LeerFilas.GetString(5)
                });
            }
            conexion.Close();
            LeerFilas.Close();  

            return Listar;
        }
        public void InsertarParametro(E_Parametros Parametro)
        {
            string Query = @"INSERT INTO [dbo].[VP_Parametros]([VP_TipoParametro],[VP_Estado],[VP_Parametro1],[VP_Parametro2],[VP_Parametro3])
                            VALUES
                            (@VP_TipoParametro,@VP_Estado,@VP_Parametro1,@VP_Parametro2,@VP_Parametro3);";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_TipoParametro", Parametro.VP_TipoParametro);
            cmd.Parameters.AddWithValue("@VP_Estado", Parametro.VP_Estado);
            cmd.Parameters.AddWithValue("@VP_Parametro1", Parametro.VP_Parametro1);
            cmd.Parameters.AddWithValue("@VP_Parametro2", Parametro.VP_Parametro2);
            cmd.Parameters.AddWithValue("@VP_Parametro3", Parametro.VP_Parametro3);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EditarParametro(E_Parametros Parametro)
        {
            string Query = @"UPDATE [dbo].[VP_Parametros]
                               SET [VP_TipoParametro] = @VP_TipoParametro
                                  ,[VP_Estado] = @VP_Estado
                                  ,[VP_Parametro1] = @VP_Parametro1
                                  ,[VP_Parametro2] = @VP_Parametro2
                                  ,[VP_Parametro3] = @VP_Parametro3
                             WHERE VP_IdParametro = @VP_IdParametro;";
            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdParametro", Parametro.VP_IdParametro);
            cmd.Parameters.AddWithValue("@VP_TipoParametro", Parametro.VP_TipoParametro);
            cmd.Parameters.AddWithValue("@VP_Estado", Parametro.VP_Estado);
            cmd.Parameters.AddWithValue("@VP_Parametro1", Parametro.VP_Parametro1);
            cmd.Parameters.AddWithValue("@VP_Parametro2", Parametro.VP_Parametro2);
            cmd.Parameters.AddWithValue("@VP_Parametro3", Parametro.VP_Parametro3);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        public void EliminarParametro(E_Parametros Parametro)
        {
            string Query = @"DELETE FROM [dbo].[VP_Parametros]
                            WHERE VP_IdParametro = @VP_IdParametro;";

            SqlCommand cmd = new SqlCommand(Query, conexion);

            conexion.Open();

            cmd.Parameters.AddWithValue("@VP_IdParametro", Parametro.VP_IdParametro);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
