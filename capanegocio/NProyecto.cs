using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using System.Data;

namespace capanegocio
{
    public class NProyecto
    {
        public static string insertarproyecto(string titulo, string observaciones, DateTime fecha)
        {
            DProyecto objeto = new DProyecto();
            objeto.Titulo = titulo;
            objeto.Observaciones = observaciones;
            objeto.Fecha = fecha;

            return objeto.insertarproyecto(objeto);
        }

        public static string editarproyecto(int id, string titulo, string observaciones, DateTime fecha)
        {
            DProyecto objeto = new DProyecto();
            objeto.Id = id;
            objeto.Titulo = titulo;
            objeto.Observaciones = observaciones;
            objeto.Fecha = fecha;

            return objeto.editarproyecto(objeto);
        }

        public static string eliminarproyecto(int id)
        {
            DProyecto objeto = new DProyecto();
            objeto.Id = id;

            return objeto.eliminarproyecto(objeto);
        }

        public static DataTable mostrarproyectos()
        {
            DProyecto objeto = new DProyecto();
            return objeto.mostrarproyectos(objeto);
        }

        public static DataTable buscarproyectoCodigo(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarproyecto_codigo(objeto);
        }

        public static DataTable buscarproyectoTitulo(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarproyecto_titulo(objeto);
        }

        public static DataTable buscarproyectoObservaciones(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarproyecto_observaciones(objeto);
        }
    }
}
