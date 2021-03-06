﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Entidad
{
    public class Entidad_Productos
    {
        //Llave primaria
        private int _Idproducto;

        //Llaves Auxiliares
        private int _Idmarca;
        private int _Idgrupo;
        private int _Idtipo;
        private int _Idlote;
        private int _Idempaque;

        //Datos Basicos
        private string _Codigo;
        private string _Producto;
        private string _Referencia;
        private string _Descripcion;
        private string _Presentacion;
        private string _Unidad;
        private string _Comision;
        private int _Comision_Porcentaje;

        private int _ManejaVencimiento;
        private int _ManejaImpuesto;
        private int _Importado;
        private int _Exportado;
        private int _Ofertable;
        private int _ManejaComision;

        //Valores
        private string _Compra_Promedio;
        private string _Compra_Final;
        private string _Venta_Excento;
        private string _Venta_NoExcento;
        private string _Venta_Mayorista;
        private string _Fabricacion;
        private string _Materiales;
        private string _Exportacion;
        private string _Importacion;
        private string _Seguro;
        private string _Gastos;

        //Cantidades
        private string _Venta_MinimaCliente;
        private string _Venta_MaximaCliente;
        private string _Venta_MinimaMayorista;
        private string _Venta_MaximaMayorista;
        private string _Compra_MinimaCliente;
        private string _Compra_MaximaCliente;
        private string _Compra_MinimaMayorista;
        private string _Compra_MaximaMayorista;

        //Detalles de Productos
        private DataTable _Detalle_Lote;
        private DataTable _Detalle_Impuesto;
        private DataTable _Detalle_Igualdad;
        private DataTable _Detalle_Proveedor;
        private DataTable _Detalle_Ubicacion;
        private DataTable _Detalle_CodigoDeBarra;

        //Panel de Imagenes
        private byte[] _Imagen;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idgrupo { get => _Idgrupo; set => _Idgrupo = value; }
        public int Idtipo { get => _Idtipo; set => _Idtipo = value; }
        public int Idlote { get => _Idlote; set => _Idlote = value; }
        public int Idempaque { get => _Idempaque; set => _Idempaque = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string Comision { get => _Comision; set => _Comision = value; }
        public int Comision_Porcentaje { get => _Comision_Porcentaje; set => _Comision_Porcentaje = value; }
        public int ManejaVencimiento { get => _ManejaVencimiento; set => _ManejaVencimiento = value; }
        public int ManejaImpuesto { get => _ManejaImpuesto; set => _ManejaImpuesto = value; }
        public int Importado { get => _Importado; set => _Importado = value; }
        public int Exportado { get => _Exportado; set => _Exportado = value; }
        public int Ofertable { get => _Ofertable; set => _Ofertable = value; }
        public int ManejaComision { get => _ManejaComision; set => _ManejaComision = value; }
        public string Compra_Promedio { get => _Compra_Promedio; set => _Compra_Promedio = value; }
        public string Compra_Final { get => _Compra_Final; set => _Compra_Final = value; }
        public string Venta_Excento { get => _Venta_Excento; set => _Venta_Excento = value; }
        public string Venta_NoExcento { get => _Venta_NoExcento; set => _Venta_NoExcento = value; }
        public string Venta_Mayorista { get => _Venta_Mayorista; set => _Venta_Mayorista = value; }
        public string Fabricacion { get => _Fabricacion; set => _Fabricacion = value; }
        public string Materiales { get => _Materiales; set => _Materiales = value; }
        public string Exportacion { get => _Exportacion; set => _Exportacion = value; }
        public string Importacion { get => _Importacion; set => _Importacion = value; }
        public string Seguro { get => _Seguro; set => _Seguro = value; }
        public string Gastos { get => _Gastos; set => _Gastos = value; }
        public string Venta_MinimaCliente { get => _Venta_MinimaCliente; set => _Venta_MinimaCliente = value; }
        public string Venta_MaximaCliente { get => _Venta_MaximaCliente; set => _Venta_MaximaCliente = value; }
        public string Venta_MinimaMayorista { get => _Venta_MinimaMayorista; set => _Venta_MinimaMayorista = value; }
        public string Venta_MaximaMayorista { get => _Venta_MaximaMayorista; set => _Venta_MaximaMayorista = value; }
        public string Compra_MinimaCliente { get => _Compra_MinimaCliente; set => _Compra_MinimaCliente = value; }
        public string Compra_MaximaCliente { get => _Compra_MaximaCliente; set => _Compra_MaximaCliente = value; }
        public string Compra_MinimaMayorista { get => _Compra_MinimaMayorista; set => _Compra_MinimaMayorista = value; }
        public string Compra_MaximaMayorista { get => _Compra_MaximaMayorista; set => _Compra_MaximaMayorista = value; }
        public DataTable Detalle_Lote { get => _Detalle_Lote; set => _Detalle_Lote = value; }
        public DataTable Detalle_Impuesto { get => _Detalle_Impuesto; set => _Detalle_Impuesto = value; }
        public DataTable Detalle_Igualdad { get => _Detalle_Igualdad; set => _Detalle_Igualdad = value; }
        public DataTable Detalle_Proveedor { get => _Detalle_Proveedor; set => _Detalle_Proveedor = value; }
        public DataTable Detalle_Ubicacion { get => _Detalle_Ubicacion; set => _Detalle_Ubicacion = value; }
        public DataTable Detalle_CodigoDeBarra { get => _Detalle_CodigoDeBarra; set => _Detalle_CodigoDeBarra = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
    }
}
