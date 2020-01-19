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
    public class fGestion_Empleados
    {
        public static DataTable Lista()
        {
            Conexion_Empleados Datos = new Conexion_Empleados();
            return Datos.Lista();
        }

        public static DataTable Buscar(string filtro, int auto)
        {
            Conexion_Empleados Datos = new Conexion_Empleados();
            return Datos.Buscar(filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto, int iddepartamento,

                //Datos Basicos
                string codigo, string empleado, string documento, string cargo, string pais, string ciudad,
                string profesion, string telefono, string movil, string email, string direccion01, string direccion02,

                string bancoprincipal, string bancoauxiliar, string comisiondeventa,
                string descuentodecompra, string numerodecuentaprincipal, string numerodecuentaauxiliar,

                int estado
            )
        {
            Conexion_Empleados Datos = new Conexion_Empleados();
            Entidad_Empleados Obj = new Entidad_Empleados();

            Obj.Bancoprincipal = bancoprincipal;
            Obj.Bancoauxiliar = bancoauxiliar;
            Obj.Iddepartamento = iddepartamento;
            Obj.Codigo = codigo;
            Obj.Empleado = empleado;
            Obj.Documento = documento;
            Obj.Cargo = cargo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Profesion = profesion;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.ComisionDeVenta = comisiondeventa;
            Obj.DescuentoDeCompra = descuentodecompra;
            Obj.NumeroDeCuentaPrincipal = numerodecuentaprincipal;
            Obj.NumeroDeCuentaAuxiliar = numerodecuentaauxiliar;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto, int idempleado, int iddepartamento,

                //Datos Basicos
                string codigo, string empleado, string documento, string cargo, string pais, string ciudad,
                string profesion, string telefono, string movil, string email, string direccion01, string direccion02,

                string bancoprincipal, string bancoauxiliar, string comisiondeventa,
                string descuentodecompra, string numerodecuentaprincipal, string numerodecuentaauxiliar,

                int estado
            )
        {
            Conexion_Empleados Datos = new Conexion_Empleados();
            Entidad_Empleados Obj = new Entidad_Empleados();

            Obj.Idempleado = idempleado;
            Obj.Iddepartamento = iddepartamento;
            Obj.Bancoprincipal = bancoprincipal;
            Obj.Bancoauxiliar = bancoauxiliar;
            Obj.Codigo = codigo;
            Obj.Empleado = empleado;
            Obj.Documento = documento;
            Obj.Cargo = cargo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Profesion = profesion;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.ComisionDeVenta = comisiondeventa;
            Obj.DescuentoDeCompra = descuentodecompra;
            Obj.NumeroDeCuentaPrincipal = numerodecuentaprincipal;
            Obj.NumeroDeCuentaAuxiliar = numerodecuentaauxiliar;
            Obj.Estado = estado;

            Obj.Auto = auto;
            return Datos.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar(int IDEliminar_SQL, int auto)
        {
            Conexion_Empleados Datos = new Conexion_Empleados();
            return Datos.Eliminar(IDEliminar_SQL, auto);
        }
    }
}
