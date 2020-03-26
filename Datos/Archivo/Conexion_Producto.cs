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
                SqlCommand Comando = new SqlCommand("Productos.LI_DatosBasicos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;

                //Panel Datos Basicos -- Campos Obligatorios
                Comando.Parameters.Add("@Idmarca", SqlDbType.Int).Value = Obj.Idmarca;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Obj.Producto;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;

                //Panel Datos Basicos -- Campos NO Obligatorios
                Comando.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Obj.Referencia;
                Comando.Parameters.Add("@Presentacion", SqlDbType.VarChar).Value = Obj.Presentacion;
                Comando.Parameters.Add("@Vencimiento", SqlDbType.Int).Value = Obj.ManejaVencimiento;
                Comando.Parameters.Add("@Importado", SqlDbType.Int).Value = Obj.Importado;
                Comando.Parameters.Add("@Exportado", SqlDbType.Int).Value = Obj.Exportado;
                Comando.Parameters.Add("@Impuesto", SqlDbType.Int).Value = Obj.ManejaImpuesto;
                Comando.Parameters.Add("@Ofertable", SqlDbType.Int).Value = Obj.Ofertable;
                Comando.Parameters.Add("@UnidadDeVenta", SqlDbType.VarChar).Value = Obj.Unidad;
                Comando.Parameters.Add("@Unidad_Valor", SqlDbType.VarChar).Value = Obj.PesoUnidad;

                Comando.Parameters.Add("@Idgrupo", SqlDbType.Int).Value = Obj.Idgrupo;
                Comando.Parameters.Add("@Idtipo", SqlDbType.Int).Value = Obj.Idtipo;
                Comando.Parameters.Add("@Idempaque", SqlDbType.Int).Value = Obj.Idempaque;
                Comando.Parameters.Add("@Idproveedor", SqlDbType.Int).Value = Obj.Idproveedor;
                Comando.Parameters.Add("@Idimpuesto", SqlDbType.Int).Value = Obj.Idimpuesto;

                //Panel Precios -- Campos Obligatorios

                Comando.Parameters.Add("@Compra", SqlDbType.VarChar).Value = Obj.ValorDeCompra;
                Comando.Parameters.Add("@Venta", SqlDbType.VarChar).Value = Obj.ValorDeVenta;
                Comando.Parameters.Add("@Imp_Venta", SqlDbType.VarChar).Value = Obj.ValorFinal;
                Comando.Parameters.Add("@Minimo", SqlDbType.VarChar).Value = Obj.CantidadMinima;
                Comando.Parameters.Add("@Maximo", SqlDbType.VarChar).Value = Obj.CantidadMaxima;
                Comando.Parameters.Add("@Importacion", SqlDbType.VarChar).Value = Obj.ValorImportacion;
                Comando.Parameters.Add("@Exportacion", SqlDbType.VarChar).Value = Obj.ValorExportacion;
                Comando.Parameters.Add("@Envio", SqlDbType.VarChar).Value = Obj.GastosDeEnvio;
                Comando.Parameters.Add("@Otros", SqlDbType.VarChar).Value = Obj.OtrosGastos;

                //Panel Ubicaciones -- Campos Obligatorios
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = Obj.Idbodega;

                //Panel Ubicaciones -- Campos NO Obligatorios
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@Estante", SqlDbType.VarChar).Value = Obj.Estante;
                Comando.Parameters.Add("@Nivel", SqlDbType.VarChar).Value = Obj.Nivel;
                Comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = Obj.Imagen;
                
                //Panel Lotes -- Campos NO Obligatorios
                Comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = Obj.Lote;
                Comando.Parameters.Add("@Lote_Valor", SqlDbType.VarChar).Value = Obj.Lote_ValorInicial;
                Comando.Parameters.Add("@Lote_vencimiento", SqlDbType.DateTime).Value = Obj.FechaVencimiento;

                //Panel Codigo de Barra -- Campos Obligatorios
                Comando.Parameters.Add("@Codigodebarra ", SqlDbType.VarChar).Value = Obj.CodigoDeBarra;                

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
                SqlCommand Comando = new SqlCommand("Productos.LI_DatosBasicos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Datos Auxiliares
                Comando.Parameters.Add("@Auto", SqlDbType.Int).Value = Obj.Auto;
                Comando.Parameters.Add("@Idproducto", SqlDbType.Int).Value = Obj.Idproducto;

                //Panel Datos Basicos -- Campos Obligatorios
                Comando.Parameters.Add("@Idmarca", SqlDbType.Int).Value = Obj.Idmarca;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Obj.Producto;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;

                //Panel Datos Basicos -- Campos NO Obligatorios
                Comando.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Obj.Referencia;
                Comando.Parameters.Add("@Presentacion", SqlDbType.VarChar).Value = Obj.Presentacion;
                Comando.Parameters.Add("@Vencimiento", SqlDbType.Int).Value = Obj.ManejaVencimiento;
                Comando.Parameters.Add("@Importado", SqlDbType.Int).Value = Obj.Importado;
                Comando.Parameters.Add("@Exportado", SqlDbType.Int).Value = Obj.Exportado;
                Comando.Parameters.Add("@Impuesto", SqlDbType.Int).Value = Obj.ManejaImpuesto;
                Comando.Parameters.Add("@Ofertable", SqlDbType.Int).Value = Obj.Ofertable;
                Comando.Parameters.Add("@UnidadDeVenta", SqlDbType.VarChar).Value = Obj.Unidad;
                Comando.Parameters.Add("@Unidad_Valor", SqlDbType.VarChar).Value = Obj.PesoUnidad;

                Comando.Parameters.Add("@Idgrupo", SqlDbType.Int).Value = Obj.Idgrupo;
                Comando.Parameters.Add("@Idtipo", SqlDbType.Int).Value = Obj.Idtipo;
                Comando.Parameters.Add("@Idempaque", SqlDbType.Int).Value = Obj.Idempaque;
                Comando.Parameters.Add("@Idproveedor", SqlDbType.Int).Value = Obj.Idproveedor;
                Comando.Parameters.Add("@Idimpuesto", SqlDbType.Int).Value = Obj.Idimpuesto;

                //Panel Precios -- Campos Obligatorios

                Comando.Parameters.Add("@Compra", SqlDbType.VarChar).Value = Obj.ValorDeCompra;
                Comando.Parameters.Add("@Venta", SqlDbType.VarChar).Value = Obj.ValorDeVenta;
                Comando.Parameters.Add("@Imp_Venta", SqlDbType.VarChar).Value = Obj.ValorFinal;
                Comando.Parameters.Add("@Minimo", SqlDbType.VarChar).Value = Obj.CantidadMinima;
                Comando.Parameters.Add("@Maximo", SqlDbType.VarChar).Value = Obj.CantidadMaxima;
                Comando.Parameters.Add("@Importacion", SqlDbType.VarChar).Value = Obj.ValorImportacion;
                Comando.Parameters.Add("@Exportacion", SqlDbType.VarChar).Value = Obj.ValorExportacion;
                Comando.Parameters.Add("@Envio", SqlDbType.VarChar).Value = Obj.GastosDeEnvio;
                Comando.Parameters.Add("@Otros", SqlDbType.VarChar).Value = Obj.OtrosGastos;

                //Panel Ubicaciones -- Campos Obligatorios
                Comando.Parameters.Add("@Idbodega", SqlDbType.Int).Value = Obj.Idbodega;

                //Panel Ubicaciones -- Campos NO Obligatorios
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@Estante", SqlDbType.VarChar).Value = Obj.Estante;
                Comando.Parameters.Add("@Nivel", SqlDbType.VarChar).Value = Obj.Nivel;
                Comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = Obj.Imagen;

                //Panel Lotes -- Campos NO Obligatorios
                Comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = Obj.Lote;
                Comando.Parameters.Add("@Lote_Valor", SqlDbType.VarChar).Value = Obj.Lote_ValorInicial;
                Comando.Parameters.Add("@Lote_vencimiento", SqlDbType.DateTime).Value = Obj.FechaVencimiento;

                //Panel Codigo de Barra -- Campos Obligatorios
                Comando.Parameters.Add("@Codigodebarra ", SqlDbType.VarChar).Value = Obj.CodigoDeBarra;

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
