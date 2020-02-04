using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
    public class fOrigen
    {
        public static DataTable Lista()
        {
            Conexion_Origen Datos = new Conexion_Origen();
            return Datos.Lista();
        }

        public static DataTable Buscar(string filtro, int auto)
        {
            Conexion_Origen Datos = new Conexion_Origen();
            return Datos.Buscar(filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto,

                //Datos Basicos
                string origen, string descripcion, string observacion, int estado
            )
        {
            Conexion_Origen Datos = new Conexion_Origen();
            Entidad_Origen Obj = new Entidad_Origen();

            Obj.Origen = origen;
            Obj.Descripcion = descripcion;
            Obj.Observacion = observacion;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto, int idorigen,

                //Datos Basicos
                string origen, string descripcion, string observacion, int estado
            )
        {
            Conexion_Origen Datos = new Conexion_Origen();
            Entidad_Origen Obj = new Entidad_Origen();

            Obj.Idorigen = idorigen;
            Obj.Origen = origen;
            Obj.Descripcion = descripcion;
            Obj.Observacion = observacion;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar(int IDEliminar_SQL, int auto)
        {
            Conexion_Origen Datos = new Conexion_Origen();
            return Datos.Eliminar(IDEliminar_SQL, auto);
        }
    }
}
