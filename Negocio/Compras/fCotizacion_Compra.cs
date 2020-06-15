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
    public class fCotizacion_Compra
    {
        public static DataTable Buscar(string filtro, int auto)
        {
            Conexion_CotizacionDeCompra Datos = new Conexion_CotizacionDeCompra();
            return Datos.Buscar(filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (

                //Datos Auxiliares y Llaves Primaria
                int idbodega, int idproveedor,

                //Datos Basicos
                string codigo, string descripcion,
                decimal precio_final, string descuento,

                //Datos Auxiliares
                DataTable Detalles, int auto
            )
        {
            Conexion_CotizacionDeCompra Datos = new Conexion_CotizacionDeCompra();
            Entidad_CotizacionDeCompra Obj = new Entidad_CotizacionDeCompra();

            //Datos Auxiliares y Llaves Primaria
            Obj.Idbodega = idbodega;
            Obj.Idproveedor = idproveedor;

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Descripcion = descripcion;
            Obj.PrecioFinal = precio_final;
            Obj.Descuento = descuento;
            
            //Datos Auxiliares
            Obj.Auto = auto;
            Obj.Cotizacion_Detalles = Detalles;

            return Datos.Guardar_DatosBasicos(Obj);
        }
    }
}
