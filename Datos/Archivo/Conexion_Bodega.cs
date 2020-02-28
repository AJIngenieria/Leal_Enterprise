using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion_Bodega
    {
        public DataTable Lista()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        public DataTable Buscar(string Valor, int Auto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Auto;
                Comando.Parameters.Add("@Filtro", SqlDbType.VarChar).Value = Valor;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        public string Guardar_DatosBasicos(Entidad_Bodega Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Almacen.LI_Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Idsucurzal", SqlDbType.Int).Value = Obj.Idsucurzal;
                Comando.Parameters.Add("@Bodega", SqlDbType.VarChar).Value = Obj.Bodega;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@Director", SqlDbType.VarChar).Value = Obj.Director;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Obj.Ciudad;
                Comando.Parameters.Add("@Movil", SqlDbType.VarChar).Value = Obj.Movil;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Obj.Correo;

                //Panel Datos Auxiliares
                Comando.Parameters.Add("@Recepcion", SqlDbType.VarChar).Value = Obj.Recepcion;
                Comando.Parameters.Add("@Despacho", SqlDbType.VarChar).Value = Obj.Despacho;
                Comando.Parameters.Add("@InicioLaboral", SqlDbType.VarChar).Value = Obj.InicioLaboral;
                Comando.Parameters.Add("@FinLaboral", SqlDbType.VarChar).Value = Obj.FinLaboral;
                Comando.Parameters.Add("@Medidas", SqlDbType.VarChar).Value = Obj.Dimensiones;
                Comando.Parameters.Add("@DiaDePagos", SqlDbType.VarChar).Value = Obj.DiaDePagos;
                Comando.Parameters.Add("@DiaDeDespacho", SqlDbType.VarChar).Value = Obj.DiaDeDespacho;
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;
                
                //Panel Equipos Electronicos
                Comando.Parameters.Add("@PC", SqlDbType.VarChar).Value = Obj.PCDeMeza;
                Comando.Parameters.Add("@Portatiles", SqlDbType.VarChar).Value = Obj.PCPortatiles;
                Comando.Parameters.Add("@Laser", SqlDbType.VarChar).Value = Obj.ImpresoraLaser;
                Comando.Parameters.Add("@Cartucho", SqlDbType.VarChar).Value = Obj.ImpresoraCartucho;
                Comando.Parameters.Add("@Tickets", SqlDbType.VarChar).Value = Obj.ImpresoraTiquetes;
                Comando.Parameters.Add("@Marquilladora", SqlDbType.VarChar).Value = Obj.Marquilladora;
                Comando.Parameters.Add("@Celulares", SqlDbType.VarChar).Value = Obj.Celulares;
                Comando.Parameters.Add("@Balanza_Digital", SqlDbType.VarChar).Value = Obj.BalanzaDigital;
                Comando.Parameters.Add("@Balanza_Manual", SqlDbType.VarChar).Value = Obj.BalanzaManual;
                Comando.Parameters.Add("@Monta_Carga", SqlDbType.VarChar).Value = Obj.MontaCarga;
                
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() != 1 ? "OK" : "Error al Realizar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
        public string Editar_DatosBasicos(Entidad_Bodega Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Almacen.LI_Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = Obj.Idbodega;
                Comando.Parameters.Add("@Idsucurzal", SqlDbType.Int).Value = Obj.Idsucurzal;
                Comando.Parameters.Add("@Bodega", SqlDbType.VarChar).Value = Obj.Bodega;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@Director", SqlDbType.VarChar).Value = Obj.Director;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Obj.Ciudad;
                Comando.Parameters.Add("@Movil", SqlDbType.VarChar).Value = Obj.Movil;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Obj.Correo;

                //Panel Datos Auxiliares
                Comando.Parameters.Add("@Recepcion", SqlDbType.VarChar).Value = Obj.Recepcion;
                Comando.Parameters.Add("@Despacho", SqlDbType.VarChar).Value = Obj.Despacho;
                Comando.Parameters.Add("@InicioLaboral", SqlDbType.VarChar).Value = Obj.InicioLaboral;
                Comando.Parameters.Add("@FinLaboral", SqlDbType.VarChar).Value = Obj.FinLaboral;
                Comando.Parameters.Add("@Medidas", SqlDbType.VarChar).Value = Obj.Dimensiones;
                Comando.Parameters.Add("@DiaDePagos", SqlDbType.VarChar).Value = Obj.DiaDePagos;
                Comando.Parameters.Add("@DiaDeDespacho", SqlDbType.VarChar).Value = Obj.DiaDeDespacho;
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;

                //Panel Equipos Electronicos
                Comando.Parameters.Add("@PC", SqlDbType.VarChar).Value = Obj.PCDeMeza;
                Comando.Parameters.Add("@Portatiles", SqlDbType.VarChar).Value = Obj.PCPortatiles;
                Comando.Parameters.Add("@Laser", SqlDbType.VarChar).Value = Obj.ImpresoraLaser;
                Comando.Parameters.Add("@Cartucho", SqlDbType.VarChar).Value = Obj.ImpresoraCartucho;
                Comando.Parameters.Add("@Tickets", SqlDbType.VarChar).Value = Obj.ImpresoraTiquetes;
                Comando.Parameters.Add("@Marquilladora", SqlDbType.VarChar).Value = Obj.Marquilladora;
                Comando.Parameters.Add("@Celulares", SqlDbType.VarChar).Value = Obj.Celulares;
                Comando.Parameters.Add("@Balanza_Digital", SqlDbType.VarChar).Value = Obj.BalanzaDigital;
                Comando.Parameters.Add("@Balanza_Manual", SqlDbType.VarChar).Value = Obj.BalanzaManual;
                Comando.Parameters.Add("@Monta_Carga", SqlDbType.VarChar).Value = Obj.MontaCarga;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() != 1 ? "OK" : "Error al Actualizar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }

        public string Eliminar(int IDEliminar_Sql, int auto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Eliminar", SqlDbType.Int).Value = auto;
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = IDEliminar_Sql;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Error al Eliminar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
    }
}
