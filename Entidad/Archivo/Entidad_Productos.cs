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
        private int _Idgrupo;
        private int _Idtipo;
        private int _Idlote;
        private int _Idproveedor;
        private int _Idimpuesto;
        private int _Idempaque;

        //Datos Basicos
        private string _Codigo;
        private string _Producto;
        private string _Referencia;
        private string _Descripcion;
        private string _Presentacion;
        private string _Unidad;
        private string _PesoUnidad;

        private int _ManejaVencimiento;
        private int _ManejaImpuesto;
        private int _Importado;
        private int _Exportado;
        private int _Ofertable;

        //Valores
        private string _ValorFinal;
        private string _ValorDeCompra;
        private string _ValorDeVenta;
        private string _CantidadMinima;
        private string _CantidadMaxima;
        private string _ValorImportacion;
        private string _ValorExportacion;
        private string _GastosDeEnvio;
        private string _OtrosGastos;

        //Ubicacion[]
        private string _Ubicacion;
        private string _Estante;
        private string _Nivel;
        private byte[] _Imagen;

        //Panel Lote
        private string _Lote;
        private string _Lote_ValorInicial;
        private DateTime _FechaVencimiento;

        //Panel Codigo de Barra
        private string _CodigoDeBarra;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idgrupo { get => _Idgrupo; set => _Idgrupo = value; }
        public int Idtipo { get => _Idtipo; set => _Idtipo = value; }
        public int Idlote { get => _Idlote; set => _Idlote = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string PesoUnidad { get => _PesoUnidad; set => _PesoUnidad = value; }
        public int ManejaVencimiento { get => _ManejaVencimiento; set => _ManejaVencimiento = value; }
        public int ManejaImpuesto { get => _ManejaImpuesto; set => _ManejaImpuesto = value; }
        public int Importado { get => _Importado; set => _Importado = value; }
        public int Exportado { get => _Exportado; set => _Exportado = value; }
        public int Ofertable { get => _Ofertable; set => _Ofertable = value; }
        public string ValorFinal { get => _ValorFinal; set => _ValorFinal = value; }
        public string ValorDeCompra { get => _ValorDeCompra; set => _ValorDeCompra = value; }
        public string ValorDeVenta { get => _ValorDeVenta; set => _ValorDeVenta = value; }
        public string CantidadMinima { get => _CantidadMinima; set => _CantidadMinima = value; }
        public string CantidadMaxima { get => _CantidadMaxima; set => _CantidadMaxima = value; }
        public string ValorImportacion { get => _ValorImportacion; set => _ValorImportacion = value; }
        public string ValorExportacion { get => _ValorExportacion; set => _ValorExportacion = value; }
        public string GastosDeEnvio { get => _GastosDeEnvio; set => _GastosDeEnvio = value; }
        public string OtrosGastos { get => _OtrosGastos; set => _OtrosGastos = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
        public string Estante { get => _Estante; set => _Estante = value; }
        public string Nivel { get => _Nivel; set => _Nivel = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public string Lote { get => _Lote; set => _Lote = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Idempaque { get => _Idempaque; set => _Idempaque = value; }
        public string CodigoDeBarra { get => _CodigoDeBarra; set => _CodigoDeBarra = value; }
        public string Lote_ValorInicial { get => _Lote_ValorInicial; set => _Lote_ValorInicial = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
    }
}
