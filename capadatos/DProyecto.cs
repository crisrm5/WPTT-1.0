using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace capadatos
{
    public class DProyecto
    {
        private int _id;
        private string _codigo_proyecto;
        private string _titulo;
        private string _observaciones;
        private DateTime _fecha;//TODO pendiente por confirmar la compatibilidad con la hora dentro de este campo y ver la base de datos.proyecto.fecha
        private string _textobuscar;

        public int Id { get => _id; set => _id = value; }
        public string Codigo_proyecto { get => _codigo_proyecto; set => _codigo_proyecto = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DProyecto()
        {

        }

        public DProyecto(int id, string codigo_proyecto, string titulo, string observaciones, DateTime fecha, string textobuscar)
        {
            Id = id;
            Codigo_proyecto = codigo_proyecto;
            Titulo = titulo;
            Observaciones = observaciones;
            Fecha = fecha;
            Textobuscar = textobuscar;
        }


        //Método insertar proyecto
        public string insertarproyecto(DProyecto proyecto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);


                //titulo
                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.NVarChar;
                ParTitulo.Size = 1024;
                ParTitulo.Value = proyecto.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);


                //observaciones
                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParObservaciones.Value = proyecto.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                //fecha
                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                //ParFecha.SqlDbType = SqlDbType.SmallDateTime;
                ParFecha.SqlDbType = SqlDbType.DateTime;
                //ParFecha.Size = 1024;
                ParFecha.Value = proyecto.Fecha;
                SqlCmd.Parameters.Add(ParFecha);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible insertar el Proyecto";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        //Método editar Proyecto
        public string editarproyecto(DProyecto proyecto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = proyecto.Id;
                SqlCmd.Parameters.Add(ParId);


                //titulo
                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.NVarChar;
                ParTitulo.Size = 1024;
                ParTitulo.Value = proyecto.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);


                //observaciones
                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParObservaciones.Value = proyecto.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                //fecha
                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFecha.Value = proyecto.Observaciones;
                SqlCmd.Parameters.Add(ParFecha);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible actualizar el Proyecto";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        //Método eliminar proyecto
        public string eliminarproyecto(DProyecto proyecto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = proyecto.Id;
                SqlCmd.Parameters.Add(ParId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible eliminar el Proyecto";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        //Método mostrar proyectos
        public DataTable mostrarproyectos(DProyecto objeto)
        {
            DataTable dtresultado = new DataTable("proyecto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }

        //Método buscar proyecto por codigo
        public DataTable buscarproyecto(DProyecto proyecto)
        {
            DataTable dtresultado = new DataTable("proyecto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por codigo
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = proyecto.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }



    }
}
