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
    public class Conexion_Producto
    {
        public DataTable Lista()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Producto", SqlCon);
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
                SqlCommand Comando = new SqlCommand("Consulta.Producto", SqlCon);
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

        public string Guardar_DatosBasicos(Entidad_Productos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Produccion.LI_Producto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Idmarca", SqlDbType.Int).Value = Obj.Idmarca;
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = Obj.Idbodega;
                Comando.Parameters.Add("@Idproveedor", SqlDbType.Int).Value = Obj.Idproveedor;
                Comando.Parameters.Add("@Idimpuesto", SqlDbType.Int).Value = Obj.Idimpuesto;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Obj.Producto;
                Comando.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Obj.Referencia;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = Obj.Lote;
                Comando.Parameters.Add("@Presentacion", SqlDbType.VarChar).Value = Obj.Presentacion;
                Comando.Parameters.Add("@Origen", SqlDbType.VarChar).Value = Obj.Origen;
                Comando.Parameters.Add("@Grupo", SqlDbType.VarChar).Value = Obj.Grupo;
                Comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = Obj.Tipo;
                Comando.Parameters.Add("@Empaque", SqlDbType.VarChar).Value = Obj.Empaque;

                //
                Comando.Parameters.Add("@ProductoOfertable", SqlDbType.VarChar).Value = Obj.ProductoOfertable;
                Comando.Parameters.Add("@ValorFinal", SqlDbType.VarChar).Value = Obj.ValorFinal;
                Comando.Parameters.Add("@ValorCompraMinima", SqlDbType.VarChar).Value = Obj.ValorCompraMinima;
                Comando.Parameters.Add("@ValorCompraMaxima", SqlDbType.VarChar).Value = Obj.ValorCompraMaxima;
                Comando.Parameters.Add("@Valor01", SqlDbType.VarChar).Value = Obj.Valor01;
                Comando.Parameters.Add("@Valor02", SqlDbType.VarChar).Value = Obj.Valor02;
                Comando.Parameters.Add("@Valor03", SqlDbType.VarChar).Value = Obj.Valor03;
                Comando.Parameters.Add("@Oferta01", SqlDbType.VarChar).Value = Obj.Oferta01;
                Comando.Parameters.Add("@Oferta02", SqlDbType.VarChar).Value = Obj.Oferta02;
                Comando.Parameters.Add("@Oferta03", SqlDbType.VarChar).Value = Obj.Oferta03;

                //
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@Estante", SqlDbType.VarChar).Value = Obj.Estante;
                Comando.Parameters.Add("@Nivel", SqlDbType.VarChar).Value = Obj.Nivel;
                Comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = Obj.Imagen;
                Comando.Parameters.Add("@Unidaddeventa", SqlDbType.VarChar).Value = Obj.Unidaddeventa;
                Comando.Parameters.Add("@CantidadCompraMinima", SqlDbType.VarChar).Value = Obj.CantidadCompraMinima;
                Comando.Parameters.Add("@CantidadCompraMaxima", SqlDbType.VarChar).Value = Obj.CantidadCompraMaxima;
                Comando.Parameters.Add("@CantidadMinimaCliente", SqlDbType.VarChar).Value = Obj.CantidadMinimaCliente;
                Comando.Parameters.Add("@CantidadMaximaCliente", SqlDbType.VarChar).Value = Obj.CantidadMaximaCliente;
                Comando.Parameters.Add("@Vencimiento", SqlDbType.VarChar).Value = Obj.Vencimiento;
                Comando.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime).Value = Obj.FechaVencimiento;
                Comando.Parameters.Add("@UnidadDePeso", SqlDbType.VarChar).Value = Obj.UnidadDePeso;
                Comando.Parameters.Add("@Peso", SqlDbType.VarChar).Value = Obj.Peso;
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
        public string Editar_DatosBasicos(Entidad_Productos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Produccion.LI_Producto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Idmarca", SqlDbType.Int).Value = Obj.Idmarca;
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = Obj.Idbodega;
                Comando.Parameters.Add("@Idproveedor", SqlDbType.Int).Value = Obj.Idproveedor;
                Comando.Parameters.Add("@Idimpuesto", SqlDbType.Int).Value = Obj.Idimpuesto;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Obj.Producto;
                Comando.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Obj.Referencia;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = Obj.Lote;
                Comando.Parameters.Add("@Presentacion", SqlDbType.VarChar).Value = Obj.Presentacion;
                Comando.Parameters.Add("@Origen", SqlDbType.VarChar).Value = Obj.Origen;
                Comando.Parameters.Add("@Grupo", SqlDbType.VarChar).Value = Obj.Grupo;
                Comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = Obj.Tipo;
                Comando.Parameters.Add("@Empaque", SqlDbType.VarChar).Value = Obj.Empaque;

                //
                Comando.Parameters.Add("@ProductoOfertable", SqlDbType.VarChar).Value = Obj.ProductoOfertable;
                Comando.Parameters.Add("@ValorFinal", SqlDbType.VarChar).Value = Obj.ValorFinal;
                Comando.Parameters.Add("@ValorCompraMinima", SqlDbType.VarChar).Value = Obj.ValorCompraMinima;
                Comando.Parameters.Add("@ValorCompraMaxima", SqlDbType.VarChar).Value = Obj.ValorCompraMaxima;
                Comando.Parameters.Add("@Valor01", SqlDbType.VarChar).Value = Obj.Valor01;
                Comando.Parameters.Add("@Valor02", SqlDbType.VarChar).Value = Obj.Valor02;
                Comando.Parameters.Add("@Valor03", SqlDbType.VarChar).Value = Obj.Valor03;
                Comando.Parameters.Add("@Oferta01", SqlDbType.VarChar).Value = Obj.Oferta01;
                Comando.Parameters.Add("@Oferta02", SqlDbType.VarChar).Value = Obj.Oferta02;
                Comando.Parameters.Add("@Oferta03", SqlDbType.VarChar).Value = Obj.Oferta03;

                //
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@Estante", SqlDbType.VarChar).Value = Obj.Estante;
                Comando.Parameters.Add("@Nivel", SqlDbType.VarChar).Value = Obj.Nivel;
                Comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = Obj.Imagen;
                Comando.Parameters.Add("@Unidaddeventa", SqlDbType.VarChar).Value = Obj.Unidaddeventa;
                Comando.Parameters.Add("@CantidadCompraMinima", SqlDbType.VarChar).Value = Obj.CantidadCompraMinima;
                Comando.Parameters.Add("@CantidadCompraMaxima", SqlDbType.VarChar).Value = Obj.CantidadCompraMaxima;
                Comando.Parameters.Add("@CantidadMinimaCliente", SqlDbType.VarChar).Value = Obj.CantidadMinimaCliente;
                Comando.Parameters.Add("@CantidadMaximaCliente", SqlDbType.VarChar).Value = Obj.CantidadMaximaCliente;
                Comando.Parameters.Add("@Vencimiento", SqlDbType.VarChar).Value = Obj.Vencimiento;
                Comando.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime).Value = Obj.FechaVencimiento;
                Comando.Parameters.Add("@UnidadDePeso", SqlDbType.VarChar).Value = Obj.UnidadDePeso;
                Comando.Parameters.Add("@Peso", SqlDbType.VarChar).Value = Obj.Peso;
                Comando.Parameters.Add("@Estado", SqlDbType.Int).Value = Obj.Estado;

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

        public string Eliminar(int IDEliminar_Sql, int Auto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion_SQLServer.getInstancia().Conexion();
                SqlCommand Comando = new SqlCommand("Consulta.Producto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Panel Datos Basicos
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Auto;
                Comando.Parameters.Add("@Idservicio", SqlDbType.Int).Value = IDEliminar_Sql;

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
