﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Bodega
    {
        //Llave primaria
        private int _Idbodega;

        //Llaves Auxiliares
        private int _Idsucurzal;

        //Datos Basicos
        private string _Bodega;
        private string _Descripcion;
        private string _Director;
        private string _Ciudad;
        private string _Telefono;
        private string _Movil;
        private string _Correo;
        private int _Estado;

        //Datos Auxiliares Bodega
        private string _Recepcion;
        private string _Despacho;
        private string _InicioLaboral;
        private string _FinLaboral;
        private string _Dimensiones;
        private string _DiaDePagos;
        private string _DiaDeDespacho;
        private string _Direccion01;
        private string _Direccion02;

        //Equipos Electronicos
        private string _PCDeMeza;
        private string _PCPortatiles;
        private string _ImpresoraLaser;
        private string _ImpresoraCartucho;
        private string _ImpresoraTiquetes;
        private string _Marquilladora;
        private string _Celulares;
        private string _BalanzaDigital;
        private string _BalanzaManual;
        private string _MontaCarga;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idsucurzal { get => _Idsucurzal; set => _Idsucurzal = value; }
        public string Bodega { get => _Bodega; set => _Bodega = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Director { get => _Director; set => _Director = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Recepcion { get => _Recepcion; set => _Recepcion = value; }
        public string Despacho { get => _Despacho; set => _Despacho = value; }
        public string InicioLaboral { get => _InicioLaboral; set => _InicioLaboral = value; }
        public string FinLaboral { get => _FinLaboral; set => _FinLaboral = value; }
        public string Dimensiones { get => _Dimensiones; set => _Dimensiones = value; }
        public string DiaDePagos { get => _DiaDePagos; set => _DiaDePagos = value; }
        public string DiaDeDespacho { get => _DiaDeDespacho; set => _DiaDeDespacho = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string PCDeMeza { get => _PCDeMeza; set => _PCDeMeza = value; }
        public string PCPortatiles { get => _PCPortatiles; set => _PCPortatiles = value; }
        public string ImpresoraLaser { get => _ImpresoraLaser; set => _ImpresoraLaser = value; }
        public string ImpresoraCartucho { get => _ImpresoraCartucho; set => _ImpresoraCartucho = value; }
        public string ImpresoraTiquetes { get => _ImpresoraTiquetes; set => _ImpresoraTiquetes = value; }
        public string Celulares { get => _Celulares; set => _Celulares = value; }
        public string BalanzaDigital { get => _BalanzaDigital; set => _BalanzaDigital = value; }
        public string BalanzaManual { get => _BalanzaManual; set => _BalanzaManual = value; }
        public string MontaCarga { get => _MontaCarga; set => _MontaCarga = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Marquilladora { get => _Marquilladora; set => _Marquilladora = value; }
    }
}
