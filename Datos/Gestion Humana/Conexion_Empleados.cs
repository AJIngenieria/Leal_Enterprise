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
    public class Conexion_Empleados
    {
        public DataTable Lista()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Empleado", SqlCon);
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
                SqlCommand Comando = new SqlCommand("Consulta.Empleado", SqlCon);
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

        public string Guardar_DatosBasicos(Entidad_Empleados Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Gestion.LI_Empleado", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Empleado", SqlDbType.VarChar).Value = Obj.Empleado;
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = Obj.Documento;
                Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Obj.Ciudad;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@Movil", SqlDbType.VarChar).Value = Obj.Movil;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = Obj.Email;
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;                
                Comando.Parameters.Add("@Estado", SqlDbType.Int).Value = Obj.Estado;

                //Panel - Datos Financieros - Otros
                Comando.Parameters.Add("@ComisionDeVenta", SqlDbType.VarChar).Value = Obj.ComisionDeVenta;
                Comando.Parameters.Add("@DescuentoDeCompra", SqlDbType.VarChar).Value = Obj.DescuentoDeCompra;
                Comando.Parameters.Add("@Profesion", SqlDbType.VarChar).Value = Obj.Profesion;
                Comando.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Obj.Cargo;
                Comando.Parameters.Add("@BancoPrincipal", SqlDbType.VarChar).Value = Obj.Bancoprincipal;
                Comando.Parameters.Add("@BancoAuxiliar", SqlDbType.VarChar).Value = Obj.Bancoauxiliar;
                Comando.Parameters.Add("@NumCuentaPrincipal ", SqlDbType.VarChar).Value = Obj.CuentaPrincipal;
                Comando.Parameters.Add("@NumCuentaAuxiliar", SqlDbType.VarChar).Value = Obj.CuentaAuxiliar;
                Comando.Parameters.Add("@Iddepartamento", SqlDbType.VarChar).Value = Obj.Iddepartamento;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Error al Realizar el Registro";
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
        public string Editar_DatosBasicos(Entidad_Empleados Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Gestion.LI_Empleado", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Empleado", SqlDbType.VarChar).Value = Obj.Empleado;
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = Obj.Documento;
                Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Obj.Ciudad;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@Movil", SqlDbType.VarChar).Value = Obj.Movil;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = Obj.Email;
                Comando.Parameters.Add("@Direccion01", SqlDbType.VarChar).Value = Obj.Direccion01;
                Comando.Parameters.Add("@Direccion02", SqlDbType.VarChar).Value = Obj.Direccion02;
                Comando.Parameters.Add("@Estado", SqlDbType.Int).Value = Obj.Estado;

                //Panel - Datos Financieros - Otros
                Comando.Parameters.Add("@ComisionDeVenta", SqlDbType.VarChar).Value = Obj.ComisionDeVenta;
                Comando.Parameters.Add("@DescuentoDeCompra", SqlDbType.VarChar).Value = Obj.DescuentoDeCompra;
                Comando.Parameters.Add("@Profesion", SqlDbType.VarChar).Value = Obj.Profesion;
                Comando.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Obj.Cargo;
                Comando.Parameters.Add("@BancoPrincipal", SqlDbType.VarChar).Value = Obj.Bancoprincipal;
                Comando.Parameters.Add("@BancoAuxiliar", SqlDbType.VarChar).Value = Obj.Bancoauxiliar;
                Comando.Parameters.Add("@NumCuentaPrincipal ", SqlDbType.VarChar).Value = Obj.CuentaPrincipal;
                Comando.Parameters.Add("@NumCuentaAuxiliar", SqlDbType.VarChar).Value = Obj.CuentaAuxiliar;
                Comando.Parameters.Add("@Iddepartamento", SqlDbType.VarChar).Value = Obj.Iddepartamento;

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
                SqlCommand Comando = new SqlCommand("Consulta.Empleado", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Auto;
                Comando.Parameters.Add("@Idempleado", SqlDbType.Int).Value = IDEliminar_Sql;

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
