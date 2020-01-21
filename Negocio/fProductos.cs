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
                int estado,

                //Datos Basicos
                string codigo, string nombre, string documento, string telefono, string movil,
                string correo, string pais, string ciudad, string departamento,

                //
                string pais_de, string ciudad_de,
                string direccionprincipal_de, string direccion01_de, string direccion02_de,

                //
                string bancoprincipal, string bancoauxiliar, string cuenta01, string cuenta02,
                string creditominimo, string creditomaximo,
                int auto
            )
        {
            Conexion_Producto Datos = new Conexion_Producto();
            Entidad_Productos Obj = new Entidad_Productos();

            Obj.Codigo = codigo;
            Obj.Cliente = nombre;
            Obj.Documento = documento;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Departamento = departamento;

            //
            Obj.Pais_Envios = pais_de;
            Obj.Ciudad_Envios = ciudad_de;
            Obj.DireccionPrincipal_Envios = direccionprincipal_de;
            Obj.Direccion01_Envios = direccion01_de;
            Obj.Direccion02_Envios = direccion02_de;

            //
            Obj.BancoPrincipal = bancoprincipal;
            Obj.BancoAuxiliar = bancoauxiliar;
            Obj.Cuenta01 = cuenta01;
            Obj.Cuenta02 = cuenta02;
            Obj.CreditoMinimo = creditominimo;
            Obj.CreditoMaximo = creditomaximo;

            Obj.Estado = estado;
            Obj.Auto = auto;
            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                ///Datos Auxiliares y Llaves Primaria
                int estado, int idcliente,

                //Datos Basicos
                string codigo, string nombre, string documento, string telefono, string movil,
                string correo, string pais, string ciudad, string departamento,

                //
                string pais_de, string ciudad_de,
                string direccionprincipal_de, string direccion01_de, string direccion02_de,

                //
                string bancoprincipal, string bancoauxiliar, string cuenta01, string cuenta02,
                string creditominimo, string creditomaximo,
                int auto
            )
        {
            Conexion_Producto Datos = new Conexion_Producto();
            Entidad_Productos Obj = new Entidad_Productos();

            Obj.Idcliente = idcliente;
            Obj.Codigo = codigo;
            Obj.Cliente = nombre;
            Obj.Documento = documento;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Departamento = departamento;

            //
            Obj.Pais_Envios = pais_de;
            Obj.Ciudad_Envios = ciudad_de;
            Obj.DireccionPrincipal_Envios = direccionprincipal_de;
            Obj.Direccion01_Envios = direccion01_de;
            Obj.Direccion02_Envios = direccion02_de;

            //
            Obj.BancoPrincipal = bancoprincipal;
            Obj.BancoAuxiliar = bancoauxiliar;
            Obj.Cuenta01 = cuenta01;
            Obj.Cuenta02 = cuenta02;
            Obj.CreditoMinimo = creditominimo;
            Obj.CreditoMaximo = creditomaximo;

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
