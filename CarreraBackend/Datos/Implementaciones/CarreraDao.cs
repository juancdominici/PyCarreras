using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CarreraBackend.Servicios;
using CarreraBackend.Entidades;
using CarreraBackend.Datos.Interfaces;

namespace CarreraBackend.Datos.Implementaciones
{
    class CarreraDao : ICarreraDao
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-37D06RA;Initial Catalog=DB_CARRERA;Integrated Security=True");
        public bool Delete(int nro)
        {
            SqlTransaction t = null;
            int affected = 0;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_REGISTRAR_BAJA_CARRERA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID_CARRERA", nro); //falta nueva carrera
                affected = comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return affected == 1;

        }

        public List<Carrera> GetByFilters(List<Parametro> criterios)
        {
            List<Carrera> lst = new List<Carrera>();
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_CONSULTAR_CARRERA", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                tabla.Load(comando.ExecuteReader());

                foreach (DataRow row in tabla.Rows)
                {
                    Carrera carrera = new Carrera();
                    carrera.Nombre = row["N_CARRERA"].ToString();
                    carrera.Titulo = row["N_TITULO"].ToString();

                    lst.Add(carrera);
                }

                conexion.Close();
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }


        public Carrera GetById(int id)
        {
            Carrera carrera = new Carrera();
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_CARRERA_POR_ID";
            comando.Parameters.AddWithValue("@nro", id);
            SqlDataReader reader = comando.ExecuteReader();
            bool esPrimerRegistro = true;

            while (reader.Read())
            {
                if (esPrimerRegistro)
                {
                    carrera.Nombre = reader["N_CARRERA"].ToString();
                    carrera.Titulo = reader["N_TITULO"].ToString();
                    esPrimerRegistro = false;
                }
                DetalleCarrera detalleCarrera = new DetalleCarrera();
                Materia asignatura = new Materia();
                asignatura.Nombre = reader["N_MATERIA"].ToString();
                detalleCarrera.AnioCursado = Convert.ToDateTime(reader["ANIO_CURSADO"]);
                detalleCarrera.Materia = asignatura;
                detalleCarrera.Cuatrimestre = Convert.ToInt32(reader["CUATRIMESTRE"]);
                esPrimerRegistro = false;
                carrera.AgregarDetalle(detalleCarrera);
            }
            return carrera;
        }

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
                Materia asignatura = new Materia();
                asignatura.Nombre = row["N_MATERIA"].ToString();

                lst.Add(asignatura);
            }
            return lst;
        }

        public bool Save(Carrera carrera)
        {
            SqlTransaction t = null;

            bool flag = true;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_INSERTAR_MAESTRO", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@N_CARRERA", carrera.Nombre);
                comando.Parameters.AddWithValue("N_TITULO", carrera.Titulo);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID_CARRERA";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();

                int nro_carrera = (int)param.Value;
                int nroDetalle = 0;

                foreach (DetalleCarrera d in carrera.Detalles)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = t;
                    cmd.Parameters.AddWithValue("@ID_CARRERA", nro_carrera);
                    cmd.Parameters.AddWithValue("@ID_DETALLE", ++nroDetalle);
                    cmd.Parameters.AddWithValue("@ANIO_CURSADO", d.AnioCursado);
                    cmd.Parameters.AddWithValue("@CUATRIMESTRE", d.Cuatrimestre);
                    cmd.Parameters.AddWithValue("@ID_MATERIA", d.Materia.Nombre);
                    cmd.ExecuteNonQuery();
                }
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
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PROXIMO_ID";

                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                cnn.Close();

                return (int)param.Value;
            }
            catch (SqlException ex)
            {

                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
        }
    }
}