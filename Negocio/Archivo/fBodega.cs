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
    public class fBodega
    {
        public static DataTable Lista()
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Lista();
        }

        public static DataTable Buscar(string Filtro, int auto)
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Buscar(Filtro, auto);
        }

        public static string Guardar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto,

                //Datos Basicos
                int idsucurzal, string bodega, string documento, string descripcion, string director, string ciudad, string movil,
                string telefono, string correo, string direccion01, string direccion02, 
                
                string recepcion, string despacho, string iniciolaboral,
                string finlaboral, string diadepagos, string diadedespacho, string dimensiones,

                //
                string pcdemeza, string pcportatiles, string impresoralaser, string impresoracartucho, string impresoratiquetes, string marquilladora,
                string celulares, string balanzadigital, string balanzamanual, string montacarga
            )
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            Entidad_Bodega Obj = new Entidad_Bodega();
            
            //Llaves Auxiliares
            Obj.Idsucurzal = idsucurzal;

            //Datos Basicos
            Obj.Bodega = bodega;
            Obj.Documento = documento;
            Obj.Descripcion = descripcion;
            Obj.Director = director;
            Obj.Ciudad = ciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;
            
            //Datos Auxiliares Bodega
            Obj.Recepcion = recepcion;
            Obj.Despacho = despacho;
            Obj.InicioLaboral = iniciolaboral;
            Obj.FinLaboral = finlaboral;
            Obj.Dimensiones = dimensiones;
            Obj.DiaDePagos = diadepagos;
            Obj.DiaDeDespacho = diadedespacho;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;

            //Equipos Electronicos
            Obj.PCDeMeza = pcdemeza;
            Obj.PCPortatiles = pcportatiles;
            Obj.ImpresoraLaser = impresoralaser;
            Obj.ImpresoraCartucho = impresoracartucho;
            Obj.ImpresoraTiquetes = impresoratiquetes;
            Obj.Marquilladora = marquilladora;
            Obj.Celulares = celulares;
            Obj.BalanzaDigital = balanzadigital;
            Obj.BalanzaManual = balanzamanual;
            Obj.MontaCarga = montacarga;

            Obj.Auto = auto;
            return Datos.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Datos Auxiliares y Llaves Primaria
                int auto, int idbodega,

                //Datos Basicos
                int idsucurzal, string bodega, string documento, string descripcion, string director, string ciudad, string movil,
                string telefono, string correo, string direccion01, string direccion02,

                string recepcion, string despacho, string iniciolaboral,
                string finlaboral, string diadepagos, string diadedespacho, string dimensiones,

                //
                string pcdemeza, string pcportatiles, string impresoralaser, string impresoracartucho, string impresoratiquetes, string marquilladora,
                string celulares, string balanzadigital, string balanzamanual, string montacarga
            )
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            Entidad_Bodega Obj = new Entidad_Bodega();

            //Llaves Auxiliares
            Obj.Idbodega = idbodega;
            Obj.Idsucurzal = idsucurzal;

            //Datos Basicos
            Obj.Bodega = bodega;
            Obj.Documento = documento;
            Obj.Descripcion = descripcion;
            Obj.Director = director;
            Obj.Ciudad = ciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;

            //Datos Auxiliares Bodega
            Obj.Recepcion = recepcion;
            Obj.Despacho = despacho;
            Obj.InicioLaboral = iniciolaboral;
            Obj.FinLaboral = finlaboral;
            Obj.Dimensiones = dimensiones;
            Obj.DiaDePagos = diadepagos;
            Obj.DiaDeDespacho = diadedespacho;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;

            //Equipos Electronicos
            Obj.PCDeMeza = pcdemeza;
            Obj.PCPortatiles = pcportatiles;
            Obj.ImpresoraLaser = impresoralaser;
            Obj.ImpresoraCartucho = impresoracartucho;
            Obj.ImpresoraTiquetes = impresoratiquetes;
            Obj.Marquilladora = marquilladora;
            Obj.Celulares = celulares;
            Obj.BalanzaDigital = balanzadigital;
            Obj.BalanzaManual = balanzamanual;
            Obj.MontaCarga = montacarga;

            Obj.Auto = auto;
            return Datos.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar(int IDEliminar_SQL, int auto)
        {
            Conexion_Bodega Datos = new Conexion_Bodega();
            return Datos.Eliminar(IDEliminar_SQL, auto);
        }
    }
}
