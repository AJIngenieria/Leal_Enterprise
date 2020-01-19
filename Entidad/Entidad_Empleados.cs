using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Empleados
    {
        //Llaves primarias       

        private int _Idempleado;

        //Datos Basicos
        private string _Codigo;
        private string _Empleado;
        private string _Documento;
        private string _Cargo;
        private string _Pais;
        private string _Ciudad;
        private string _Profesion;
        private string _Telefono;
        private string _Movil;
        private string _Direccion01;
        private string _Direccion02;
        private string _Email;
        private int _Estado;

        //Datos Financieros - Otros

        private string _Bancoprincipal;
        private string _Bancoauxiliar;
        private int _Iddepartamento;
        private string _ComisionDeVenta;
        private string _DescuentoDeCompra;
        private string _CuentaPrincipal;
        private string _CuentaAuxiliar;
        private string _NumeroDeCuentaPrincipal;
        private string _NumeroDeCuentaAuxiliar;
                
        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Profesion { get => _Profesion; set => _Profesion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Iddepartamento { get => _Iddepartamento; set => _Iddepartamento = value; }
        public string ComisionDeVenta { get => _ComisionDeVenta; set => _ComisionDeVenta = value; }
        public string DescuentoDeCompra { get => _DescuentoDeCompra; set => _DescuentoDeCompra = value; }
        public string CuentaPrincipal { get => _CuentaPrincipal; set => _CuentaPrincipal = value; }
        public string CuentaAuxiliar { get => _CuentaAuxiliar; set => _CuentaAuxiliar = value; }
        public string NumeroDeCuentaPrincipal { get => _NumeroDeCuentaPrincipal; set => _NumeroDeCuentaPrincipal = value; }
        public string NumeroDeCuentaAuxiliar { get => _NumeroDeCuentaAuxiliar; set => _NumeroDeCuentaAuxiliar = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Bancoprincipal { get => _Bancoprincipal; set => _Bancoprincipal = value; }
        public string Bancoauxiliar { get => _Bancoauxiliar; set => _Bancoauxiliar = value; }
    }
}
