using CarreraBackend.Datos.Interfaces;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Datos.Implementaciones
{
    class MateriaDao: IMateriaDao
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-37D06RA;Initial Catalog=DB_CARRERA;Integrated Security=True");

        public List<Materia> GetMaterias()
        {
            List<Materia> lst = new List<Materia>();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_CONSULTAR_MATERIAS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Materia asignatura = new Materia((int)row["ID_MATERIA"], row["N_MATERIA"].ToString());
                lst.Add(asignatura);
            }
            return lst;
        }
        public bool SaveMateria(Materia materia)
        {
            SqlTransaction t = null;

            bool flag = true;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_INSERTAR_MATERIA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOM_MATERIA", materia.Nombre);
                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch(Exception ex)
            {
                var e = ex;
                t.Rollback();
                flag = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return flag;
        }
        public bool UpdateMateria(Materia materia)
        {
            SqlTransaction t = null;

            bool flag = true;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_MATERIA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID_MATERIA", materia.Id);
                comando.Parameters.AddWithValue("@NOM_MATERIA", materia.Nombre);
                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                t.Rollback();
                flag = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return flag;
        }
        public bool DeleteMateria(Materia materia)
        {
            SqlTransaction t = null;

            bool flag = true;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_BORRAR_MATERIA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID_MATERIA", materia.Id);
                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                t.Rollback();
                flag = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return flag;
        }
        public int GetNumeroMateria()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PROXIMO_ID_MATERIAS";

                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conexion.Close();

                if (param.Value == System.DBNull.Value) return 1;
                return (int)param.Value;
            }
            catch (SqlException ex)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }
    }
}
