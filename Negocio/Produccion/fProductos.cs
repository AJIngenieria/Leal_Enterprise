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
                int estado, int idmarca, int idbodega,
                int idproveedor, int idimpuesto,

                //Datos Basicos 
                string codigo, string producto, string referencia, string descripcion, string lote,
                string presentacion, string origen, string grupo, string tipo, string empaque,

                //Precios
                string productoOfertable, string valorFinal, string valorcompraminima, string valorcompramaxima,
                string valor01, string valor02, string valor03, string oferta01,
                string oferta02, string oferta03,

                //Ubicacion[]
                string ubicacion, string estante, string nivel,

                //Otros Datos
                string unidaddeventa, string cantidadcompraminima, string cantidadcompramaxima,
                string cantidadminimacliente, string cantidadmaximacliente, string vencimiento,
                DateTime fechavencimiento, string unidaddepeso, string peso, byte[] imagen,

                //
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

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Lote = lote;
            Obj.Presentacion = presentacion;
            Obj.Origen = origen;
            Obj.Grupo = grupo;
            Obj.Tipo = tipo;
            Obj.Empaque = empaque;

            //Precios
            Obj.ProductoOfertable = productoOfertable;
            Obj.ValorFinal = valorFinal;
            Obj.ValorCompraMinima = valorcompraminima;
            Obj.ValorCompraMaxima = valorcompramaxima;
            Obj.Valor01 = valor01;
            Obj.Valor02 = valor02;
            Obj.Valor03 = valor03;
            Obj.Oferta01 = oferta01;
            Obj.Oferta02 = oferta02;
            Obj.Oferta03 = oferta03;

            //Ubicacion[]
            Obj.Ubicacion = ubicacion;
            Obj.Estante = estante;
            Obj.Nivel = nivel;
            Obj.Imagen = imagen;

            //Otros Datos
            Obj.Unidaddeventa = unidaddeventa;
            Obj.CantidadCompraMinima = cantidadcompraminima;
            Obj.CantidadCompraMaxima = cantidadcompramaxima;
            Obj.CantidadMinimaCliente = cantidadminimacliente;
            Obj.CantidadMaximaCliente = cantidadmaximacliente;
            Obj.Vencimiento = vencimiento;
            Obj.FechaVencimiento = fechavencimiento;
            Obj.UnidadDePeso = unidaddepeso;
            Obj.Peso = peso;

            Obj.Estado = estado;
            Obj.Auto = auto;

            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                
                //Datos Auxiliares y Llaves Primaria
                int estado, int idproducto, int idmarca, int idbodega,
                int idproveedor, int idimpuesto,

                //Datos Basicos 
                string codigo, string producto, string referencia, string descripcion, string lote,
                string presentacion, string origen, string grupo, string tipo, string empaque,

                //Precios
                string productoOfertable, string valorFinal, string valorcompraminima, string valorcompramaxima,
                string valor01, string valor02, string valor03, string oferta01,
                string oferta02, string oferta03,

                //Ubicacion[]
                string ubicacion, string estante, string nivel,

                //Otros Datos
                string unidaddeventa, string cantidadcompraminima, string cantidadcompramaxima,
                string cantidadminimacliente, string cantidadmaximacliente, string vencimiento,
                DateTime fechavencimiento, string unidaddepeso, string peso, byte[] imagen,

                //
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

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Lote = lote;
            Obj.Presentacion = presentacion;
            Obj.Origen = origen;
            Obj.Grupo = grupo;
            Obj.Tipo = tipo;
            Obj.Empaque = empaque;

            //Precios
            Obj.ProductoOfertable = productoOfertable;
            Obj.ValorFinal = valorFinal;
            Obj.ValorCompraMinima = valorcompraminima;
            Obj.ValorCompraMaxima = valorcompramaxima;
            Obj.Valor01 = valor01;
            Obj.Valor02 = valor02;
            Obj.Valor03 = valor03;
            Obj.Oferta01 = oferta01;
            Obj.Oferta02 = oferta02;
            Obj.Oferta03 = oferta03;

            //Ubicacion[]
            Obj.Ubicacion = ubicacion;
            Obj.Estante = estante;
            Obj.Nivel = nivel;
            Obj.Imagen = imagen;

            //Otros Datos
            Obj.Unidaddeventa = unidaddeventa;
            Obj.CantidadCompraMinima = cantidadcompraminima;
            Obj.CantidadCompraMaxima = cantidadcompramaxima;
            Obj.CantidadMinimaCliente = cantidadminimacliente;
            Obj.CantidadMaximaCliente = cantidadmaximacliente;
            Obj.Vencimiento = vencimiento;
            Obj.FechaVencimiento = fechavencimiento;
            Obj.UnidadDePeso = unidaddepeso;
            Obj.Peso = peso;

            Obj.Estado = estado;
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
