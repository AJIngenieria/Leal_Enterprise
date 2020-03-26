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
    public class fProductos
    {
        public static DataTable Lista()
        {
            Conexion_Producto Datos = new Conexion_Producto();
            return Datos.Lista();
        }

        public static DataTable Buscar(string filtro, int auto)
        {
            Conexion_Producto Datos = new Conexion_Producto();
            return Datos.Buscar(filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (

                //Datos Auxiliares y Llaves Primaria
                int idmarca, int idbodega, int idproveedor, int idimpuesto, int idempaque,int idgrupo, int idtipo,

                //Datos Basicos
                string codigo, string producto, string referencia, string descripcion,
                string presentacion, string unidad, string pesounidad,

                int manejavencimiento, int manejaimpuesto, int importado, int exportado, int ofertable,

                //Precios
                string valorfinal, string valordecompra, string valordeventa, string cantidadminima,
                string cantidadmaxima, string valorimportacion, string valorexportacion, string gastosdeenvio,
                string otrosgastos,

                //Ubicacion[]
                string ubicacion, string estante, string nivel, byte[] imagen,

                //Lote
                string lote, string lote_valorinicial, DateTime lote_fechavencimiento,

                //Panel Codigo de Barra
                string codigodebarra,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Producto Datos = new Conexion_Producto();
            Entidad_Productos Obj = new Entidad_Productos();

            //Datos Auxiliares y Llaves Primaria
            Obj.Idmarca = idmarca;
            Obj.Idbodega = idbodega;
            Obj.Idproveedor = idproveedor;
            Obj.Idimpuesto = idimpuesto;
            Obj.Idempaque = idempaque;
            Obj.Idgrupo = idgrupo;
            Obj.Idtipo = idtipo;

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Presentacion = presentacion;
            Obj.Unidad = unidad;
            Obj.PesoUnidad = pesounidad;

            Obj.ManejaVencimiento = manejavencimiento;
            Obj.ManejaImpuesto = manejaimpuesto;
            Obj.Importado = importado;
            Obj.Exportado = exportado;
            Obj.Ofertable = ofertable;

            //Valores
            Obj.ValorFinal = valorfinal;
            Obj.ValorDeCompra = valordecompra;
            Obj.ValorDeVenta = valordeventa;
            Obj.CantidadMinima = cantidadminima;
            Obj.CantidadMaxima = cantidadmaxima;
            Obj.ValorImportacion = valorimportacion;
            Obj.ValorExportacion = valorexportacion;
            Obj.GastosDeEnvio = gastosdeenvio;
            Obj.OtrosGastos = otrosgastos;

            //Ubicacion[]
            Obj.Ubicacion = ubicacion;
            Obj.Estante = estante;
            Obj.Nivel = nivel;
            Obj.Imagen = imagen;

            //Panel Lote
            Obj.Lote = lote;
            Obj.Lote_ValorInicial = lote_valorinicial;
            Obj.FechaVencimiento = lote_fechavencimiento;

            //Panel Codigo de Barra
            Obj.CodigoDeBarra = codigodebarra;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                

                //Datos Auxiliares y Llaves Primaria
                int idproducto, int idmarca, int idbodega, int idproveedor, int idimpuesto, int idempaque, int idgrupo, int idtipo,

                //Datos Basicos
                string codigo, string producto, string referencia, string descripcion,
                string presentacion, string unidad, string pesounidad,
                int manejavencimiento, int manejaimpuesto, int importado, int exportado, int ofertable,

                //Precios
                string valorfinal, string valordecompra, string valordeventa, string cantidadminima,
                string cantidadmaxima, string valorimportacion, string valorexportacion, string gastosdeenvio,
                string otrosgastos,

                //Ubicacion[]
                string ubicacion, string estante, string nivel, byte[] imagen,
                
                //Lote
                string lote, string lote_valorinicial, DateTime lote_fechavencimiento,

                //Panel Codigo de Barra
                string codigodebarra,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Producto Datos = new Conexion_Producto();
            Entidad_Productos Obj = new Entidad_Productos();

            //Datos Auxiliares y Llaves Primaria
            Obj.Idproducto = idproducto;
            Obj.Idmarca = idmarca;
            Obj.Idbodega = idbodega;
            Obj.Idproveedor = idproveedor;
            Obj.Idimpuesto = idimpuesto;
            Obj.Idempaque = idempaque;
            Obj.Idgrupo = idgrupo;
            Obj.Idtipo = idtipo;

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Presentacion = presentacion;
            Obj.Unidad = unidad;
            Obj.PesoUnidad = pesounidad;

            Obj.ManejaVencimiento = manejavencimiento;
            Obj.ManejaImpuesto = manejaimpuesto;
            Obj.Importado = importado;
            Obj.Exportado = exportado;
            Obj.Ofertable = ofertable;

            //Valores
            Obj.ValorFinal = valorfinal;
            Obj.ValorDeCompra = valordecompra;
            Obj.ValorDeVenta = valordeventa;
            Obj.CantidadMinima = cantidadminima;
            Obj.CantidadMaxima = cantidadmaxima;
            Obj.ValorImportacion = valorimportacion;
            Obj.ValorExportacion = valorexportacion;
            Obj.GastosDeEnvio = gastosdeenvio;
            Obj.OtrosGastos = otrosgastos;

            //Ubicacion[]
            Obj.Ubicacion = ubicacion;
            Obj.Estante = estante;
            Obj.Nivel = nivel;
            Obj.Imagen = imagen;

            //Panel Lote
            Obj.Lote = lote;
            Obj.Lote_ValorInicial = lote_valorinicial;
            Obj.FechaVencimiento = lote_fechavencimiento;

            //Panel Codigo de Barra
            Obj.CodigoDeBarra = codigodebarra;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Datos.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar(int IDEliminar_SQL, int auto)
        {
            Conexion_Producto Datos = new Conexion_Producto();
            return Datos.Eliminar(IDEliminar_SQL, auto);
        }
    }
}
