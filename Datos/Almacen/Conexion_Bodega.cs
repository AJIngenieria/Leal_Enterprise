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
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;

                //
                Comando.Parameters.Add("@Recepcion", SqlDbType.VarChar).Value = Obj.Recepcion;
                Comando.Parameters.Add("@Despacho", SqlDbType.VarChar).Value = Obj.Despacho;
                Comando.Parameters.Add("@NumeroPC", SqlDbType.VarChar).Value = Obj.NumeroPC;
                Comando.Parameters.Add("@NumeroImpresora", SqlDbType.VarChar).Value = Obj.NumeroImpresora;
                Comando.Parameters.Add("@NumeroCelulares", SqlDbType.VarChar).Value = Obj.NumeroCelulares;
                Comando.Parameters.Add("@OtrosEquipos", SqlDbType.VarChar).Value = Obj.OtrosEquipos;
                Comando.Parameters.Add("@InicioLaboral", SqlDbType.VarChar).Value = Obj.InicioLaboral;
                Comando.Parameters.Add("@FinLaboral", SqlDbType.VarChar).Value = Obj.FinLaboral;
                Comando.Parameters.Add("@DiaDePagos", SqlDbType.VarChar).Value = Obj.DiaDePagos;
                Comando.Parameters.Add("@MedidasLaborales", SqlDbType.VarChar).Value = Obj.MedidasLaborales;
                Comando.Parameters.Add("@Estado", SqlDbType.Int).Value = Obj.Estado;


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
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;

                //
                Comando.Parameters.Add("@Recepcion", SqlDbType.VarChar).Value = Obj.Recepcion;
                Comando.Parameters.Add("@Despacho", SqlDbType.VarChar).Value = Obj.Despacho; 
                Comando.Parameters.Add("@NumeroPC", SqlDbType.VarChar).Value = Obj.NumeroPC; 
                Comando.Parameters.Add("@NumeroImpresora", SqlDbType.VarChar).Value = Obj.NumeroImpresora;
                Comando.Parameters.Add("@NumeroCelulares", SqlDbType.VarChar).Value = Obj.NumeroCelulares;
                Comando.Parameters.Add("@OtrosEquipos", SqlDbType.VarChar).Value = Obj.OtrosEquipos;
                Comando.Parameters.Add("@InicioLaboral", SqlDbType.VarChar).Value = Obj.InicioLaboral;
                Comando.Parameters.Add("@FinLaboral", SqlDbType.VarChar).Value = Obj.FinLaboral;
                Comando.Parameters.Add("@DiaDePagos", SqlDbType.VarChar).Value = Obj.DiaDePagos;
                Comando.Parameters.Add("@MedidasLaborales", SqlDbType.VarChar).Value = Obj.MedidasLaborales;
                Comando.Parameters.Add("@Estado", SqlDbType.Int).Value = Obj.Estado;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Error al Actualizar el Registro";
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

        public string Eliminar(int IDEliminar_Sql, int Auto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Bodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Auto;
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
