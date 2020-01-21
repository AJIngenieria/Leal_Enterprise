using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Productos
    {
        //Llave primaria
        private int _Idproducto;

        //Llaves Auxiliares
        private int _Idmarca;
        private int _Idbodega;
        private int _Idproveedor;
        private int _Idimpuesto;

        //Datos Basicos
        private string _Codigo;
        private string _Producto;
        private string _Referencia;
        private string _Descripcion;
        private string _Lote;
        private string _Presentacion;
        private string _Origen;
        private string _Grupo;
        private string _Tipo;
        private string _Empaque;
        private int _Estado;

        //Precios
        private string _ProductoOfertable;
        private string _ValorFinal;
        private string _ValorCompraMinima;
        private string _ValorCompraMaxima;
        private string _Valor01;
        private string _Valor02;
        private string _Valor03;
        private string _Oferta01;
        private string _Oferta02;
        private string _Oferta03;

        //Ubicacion[]
        private string _Ubicacion;
        private string _Estante;
        private string _Nivel;
        private byte[] _Imagen;

        //Otros Datos
        private string _Unidaddeventa;
        private string _CantidadCompraMinima;
        private string _CantidadCompraMaxima;
        private string _CantidadMinimaCliente;
        private string _CantidadMaximaCliente;
        private string _Vencimiento;
        private DateTime _FechaVencimiento;
        private string _UnidadDePeso;
        private string _Peso;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Lote { get => _Lote; set => _Lote = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public string Origen { get => _Origen; set => _Origen = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Empaque { get => _Empaque; set => _Empaque = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string ProductoOfertable { get => _ProductoOfertable; set => _ProductoOfertable = value; }
        public string ValorFinal { get => _ValorFinal; set => _ValorFinal = value; }
        public string ValorCompraMinima { get => _ValorCompraMinima; set => _ValorCompraMinima = value; }
        public string ValorCompraMaxima { get => _ValorCompraMaxima; set => _ValorCompraMaxima = value; }
        public string Valor01 { get => _Valor01; set => _Valor01 = value; }
        public string Valor02 { get => _Valor02; set => _Valor02 = value; }
        public string Valor03 { get => _Valor03; set => _Valor03 = value; }
        public string Oferta01 { get => _Oferta01; set => _Oferta01 = value; }
        public string Oferta02 { get => _Oferta02; set => _Oferta02 = value; }
        public string Oferta03 { get => _Oferta03; set => _Oferta03 = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
        public string Estante { get => _Estante; set => _Estante = value; }
        public string Nivel { get => _Nivel; set => _Nivel = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public string Unidaddeventa { get => _Unidaddeventa; set => _Unidaddeventa = value; }
        public string CantidadCompraMinima { get => _CantidadCompraMinima; set => _CantidadCompraMinima = value; }
        public string CantidadCompraMaxima { get => _CantidadCompraMaxima; set => _CantidadCompraMaxima = value; }
        public string CantidadMinimaCliente { get => _CantidadMinimaCliente; set => _CantidadMinimaCliente = value; }
        public string CantidadMaximaCliente { get => _CantidadMaximaCliente; set => _CantidadMaximaCliente = value; }
        public string Vencimiento { get => _Vencimiento; set => _Vencimiento = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public string UnidadDePeso { get => _UnidadDePeso; set => _UnidadDePeso = value; }
        public string Peso { get => _Peso; set => _Peso = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
    }
}
