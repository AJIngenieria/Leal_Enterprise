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
    public class fBodega
    {
        public static DataTable Lista()
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Lista();
        }

        public static DataTable Buscar(string filtro, int auto)
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Buscar(filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto,

                //Datos Basicos
                int idsucurzal, string bodega, string descripcion, string director, string ciudad, string movil,
                string telefono, string correo, string direccion01, string direccion02, string recepcion, string despacho,
                string numerodepc, string numerodecelulares, string numerodeimpresoras, string otrosequipos, string iniciolaboral,
                string finlaboral, string diadepagos, string medidasgenerales,
                int estado
            )
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            Entidad_Bodega Obj = new Entidad_Bodega();

            Obj.Idsucurzal = idsucurzal;
            Obj.Bodega = bodega;
            Obj.Descripcion = descripcion;
            Obj.Director = director;
            Obj.Ciudad = ciudad;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;

            //
            Obj.Recepcion = recepcion;
            Obj.Despacho = despacho;
            Obj.NumeroPC = numerodepc;
            Obj.NumeroCelulares = numerodecelulares;
            Obj.NumeroImpresora = numerodeimpresoras;
            Obj.OtrosEquipos = otrosequipos;
            Obj.InicioLaboral = iniciolaboral;
            Obj.FinLaboral = finlaboral;
            Obj.DiaDePagos = diadepagos;
            Obj.MedidasLaborales = medidasgenerales;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto, int idbodega,

                //Datos Basicos
                int idsucurzal, string bodega, string descripcion, string director, string ciudad, string movil,
                string telefono, string correo, string direccion01, string direccion02, string recepcion, string despacho,
                string numerodepc, string numerodecelulares, string numerodeimpresoras, string otrosequipos, string iniciolaboral,
                string finlaboral, string diadepagos, string medidasgenerales,
                int estado
            )
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            Entidad_Bodega Obj = new Entidad_Bodega();

            Obj.Idbodega = idbodega;
            Obj.Idsucurzal = idsucurzal;
            Obj.Bodega = bodega;
            Obj.Descripcion = descripcion;
            Obj.Director = director;
            Obj.Ciudad = ciudad;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;

            //
            Obj.Recepcion = recepcion;
            Obj.Despacho = despacho;
            Obj.NumeroPC = numerodepc;
            Obj.NumeroCelulares = numerodecelulares;
            Obj.NumeroImpresora = numerodeimpresoras;
            Obj.OtrosEquipos = otrosequipos;
            Obj.InicioLaboral = iniciolaboral;
            Obj.FinLaboral = finlaboral;
            Obj.DiaDePagos = diadepagos;
            Obj.MedidasLaborales = medidasgenerales;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar(int IDEliminar_SQL, int auto)
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Eliminar(IDEliminar_SQL, auto);
        }
    }
}
