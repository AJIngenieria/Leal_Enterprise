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
                int idmarca, int idbodega, int idproveedor, int idimpuesto,

                //Datos Basicos
                string codigo, string producto, string referencia, string descripcion, string lote, string presentacion, DateTime vencimiento,

                //Precios
                string productoOfertable, string valorFinal, string valorCompraMinima, string valorCompraMaxima, string valor01,
                string valor02, string valor03, string oferta01, string oferta02, string oferta03,

                //Ubicacion[]
                string ubicacion, string estante, string nivel, byte[] imagen,

                //Canrtidades
                string cantidadCompraMinima, string cantidadCompraMaxima, string cantidadMinimaCliente, string cantidadMaximaCliente,
                string vence, DateTime fechaVencimiento, string unidaddeventa, string unidadDePeso, string peso,

                //Panel Cantidad 02
                int idorigen, int idgrupo, int idtipo, int idempaque,

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

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Lote = lote;
            Obj.Presentacion = presentacion;
            Obj.Vencimiento = vencimiento;

            //Precios
            Obj.ProductoOfertable = productoOfertable;
            Obj.ValorFinal = valorFinal;
            Obj.ValorCompraMinima = valorCompraMinima;
            Obj.ValorCompraMaxima = valorCompraMaxima;
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

            //Canrtidades
            Obj.CantidadCompraMinima = cantidadCompraMinima;
            Obj.CantidadCompraMaxima = cantidadCompraMaxima;
            Obj.CantidadMinimaCliente = cantidadMinimaCliente;
            Obj.CantidadMaximaCliente = cantidadMaximaCliente;
            Obj.Vence = vence;
            Obj.FechaVencimiento = fechaVencimiento;
            Obj.Unidaddeventa = unidaddeventa;
            Obj.UnidadDePeso = unidadDePeso;
            Obj.Peso = peso;

            //Panel Cantidad 02
            Obj.Idorigen = idorigen;
            Obj.Idgrupo = idgrupo;
            Obj.Iftipo = idtipo;
            Obj.Idempaque = idempaque;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (

                //Datos Auxiliares y Llaves Primaria
                int idmarca, int idbodega, int idproveedor, int idimpuesto,

                //Datos Basicos
                string codigo, string producto, string referencia, string descripcion, string lote, string presentacion, DateTime vencimiento,

                //Precios
                string productoOfertable, string valorFinal, string valorCompraMinima, string valorCompraMaxima, string valor01,
                string valor02, string valor03, string oferta01, string oferta02, string oferta03,

                //Ubicacion[]
                string ubicacion, string estante, string nivel, byte[] imagen,

                //Canrtidades
                string cantidadCompraMinima, string cantidadCompraMaxima, string cantidadMinimaCliente, string cantidadMaximaCliente,
                string vence, DateTime fechaVencimiento, string unidaddeventa, string unidadDePeso, string peso,

                //Panel Cantidad 02
                int idorigen, int idgrupo, int idtipo, int idempaque,

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

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Producto = producto;
            Obj.Referencia = referencia;
            Obj.Descripcion = descripcion;
            Obj.Lote = lote;
            Obj.Presentacion = presentacion;
            Obj.Vencimiento = vencimiento;

            //Precios
            Obj.ProductoOfertable = productoOfertable;
            Obj.ValorFinal = valorFinal;
            Obj.ValorCompraMinima = valorCompraMinima;
            Obj.ValorCompraMaxima = valorCompraMaxima;
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

            //Canrtidades
            Obj.CantidadCompraMinima = cantidadCompraMinima;
            Obj.CantidadCompraMaxima = cantidadCompraMaxima;
            Obj.CantidadMinimaCliente = cantidadMinimaCliente;
            Obj.CantidadMaximaCliente = cantidadMaximaCliente;
            Obj.Vence = vence;
            Obj.FechaVencimiento = fechaVencimiento;
            Obj.Unidaddeventa = unidaddeventa;
            Obj.UnidadDePeso = unidadDePeso;
            Obj.Peso = peso;

            //Panel Cantidad 02
            Obj.Idorigen = idorigen;
            Obj.Idgrupo = idgrupo;
            Obj.Iftipo = idtipo;
            Obj.Idempaque = idempaque;

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
