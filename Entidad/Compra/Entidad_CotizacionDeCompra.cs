using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Entidad
{
    public class Entidad_CotizacionDeCompra
    {
        //Llaves primarias
        private int idcotizacion;

        //Llaves Auxiliares
        private int iddetalle;
        private int idbodega;
        private int idproveedor;

        //Datos Basicos
        private string codigo;
        private string descripcion;
        private string descuento;
        private string precioFinal;
        private string estado;

        //Datos Auxiliares
        private int auto;
        private DataTable cotizacion_Detalles;

        public int Idcotizacion { get => idcotizacion; set => idcotizacion = value; }
        public int Iddetalle { get => iddetalle; set => iddetalle = value; }
        public int Idbodega { get => idbodega; set => idbodega = value; }
        public int Idproveedor { get => idproveedor; set => idproveedor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public int Auto { get => auto; set => auto = value; }
        public string Estado { get => estado; set => estado = value; }
        public DataTable Cotizacion_Detalles { get => cotizacion_Detalles; set => cotizacion_Detalles = value; }
    }
}
