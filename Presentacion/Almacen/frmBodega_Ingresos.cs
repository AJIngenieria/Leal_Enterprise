﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace Presentacion
{
    public partial class frmBodega_Ingresos : Form
    {
        private DataTable DtDetalle = new DataTable();

        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        //private string Campo = "Campo Obligatorio - Leal Enterprise";
        
        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        public frmBodega_Ingresos()
        {
            InitializeComponent();
        }

        private void frmBodega_Ingresos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();
            this.CrearTabla();

            //Focus a Texboxt y Combobox
            this.TBCodigoID.Focus();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos

            this.TBCodigoID.ReadOnly = false;
            this.TBCodigoID.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo_Proveedor.ReadOnly = false;
            this.TBCodigo_Proveedor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBProveedor.Enabled = false;
            this.TBProveedor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo_Bodega.ReadOnly = false;
            this.TBCodigo_Bodega.BackColor = Color.FromArgb(3, 155, 229);
            this.TBBodega.Enabled = false;
            this.TBBodega.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo_Producto.ReadOnly = false;
            this.TBCodigo_Producto.BackColor = Color.FromArgb(3, 155, 229);
            this.CBMoneda.Enabled = true;
            this.CBMoneda.BackColor = Color.FromArgb(3, 155, 229);
            this.CBComprobante.Enabled = false;
            this.CBComprobante.BackColor = Color.FromArgb(3, 155, 229);
            
            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos

                //this.CBProveedor.SelectedIndex = 0;
                //this.CBComprobante.SelectedIndex = 0;

                //this.TBComprobante.Clear();
                //this.TBValorDeCompra.Clear();
                //this.TBStockInicial.Clear();
                //this.TBStockActual.Clear();

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBIdproducto.Focus();
            }
        }

        private void Botones()
        {
            if (Digitar)
            {
                ////El boton btnGuardar Mantendra su imagen original
                //this.btnGuardar.Enabled = true;
                //this.btnGuardar.Image = Properties.Resources.BV_Guardar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
            else if (!Digitar)
            {
                ////El boton btnGuardar cambiara su imagen original de Guardar a Editar
                //this.btnGuardar.Enabled = true;
                //this.btnGuardar.Image = Properties.Resources.BV_Editar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnImprimir.Enabled = false;
            }
        }

        private void CrearTabla()
        {
            try
            {
                this.DtDetalle.Columns.Add("Idproducto", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("Codigo", System.Type.GetType("System.String"));
                this.DtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
                this.DtDetalle.Columns.Add("Medida", System.Type.GetType("System.String"));
                this.DtDetalle.Columns.Add("Cajas", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("U. Cajas", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("U. Total", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("V. Compra", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("V. Venta", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Int32"));
                this.DtDetalle.Columns.Add("Total", System.Type.GetType("System.Int32"));

                //Medidas de las Columnas
                this.DGDetalleDeIngreso.DataSource = this.DtDetalle;

                this.DGDetalleDeIngreso.Columns[0].Visible = false;
                this.DGDetalleDeIngreso.Columns[0].HeaderText = "Idproducto";
                this.DGDetalleDeIngreso.Columns[0].Width = 70;
                this.DGDetalleDeIngreso.Columns[1].HeaderText = "Codigo";
                this.DGDetalleDeIngreso.Columns[1].Width = 85;
                this.DGDetalleDeIngreso.Columns[2].HeaderText = "Descripcion";
                this.DGDetalleDeIngreso.Columns[2].Width = 300;
                this.DGDetalleDeIngreso.Columns[3].HeaderText = "Medida";
                this.DGDetalleDeIngreso.Columns[3].Width = 55;
                this.DGDetalleDeIngreso.Columns[4].HeaderText = "Cajas";
                this.DGDetalleDeIngreso.Columns[4].Width = 50;
                this.DGDetalleDeIngreso.Columns[5].HeaderText = "U. Cajas";
                this.DGDetalleDeIngreso.Columns[4].Width = 70;
                this.DGDetalleDeIngreso.Columns[6].HeaderText = "U. Total";
                this.DGDetalleDeIngreso.Columns[6].Width = 75;
                this.DGDetalleDeIngreso.Columns[7].HeaderText = "V. Compra";
                this.DGDetalleDeIngreso.Columns[7].Width = 90;
                this.DGDetalleDeIngreso.Columns[8].HeaderText = "V. Venta";
                this.DGDetalleDeIngreso.Columns[8].Width = 90;
                this.DGDetalleDeIngreso.Columns[9].HeaderText = "Descuento";
                this.DGDetalleDeIngreso.Columns[9].Width = 85;
                this.DGDetalleDeIngreso.Columns[10].HeaderText = "Total";
                this.DGDetalleDeIngreso.Columns[10].Width = 85;

                //Se Desabilita las columnas especificadas para evitar la edicion
                //Del Campo por parte del Usuario
                this.DGDetalleDeIngreso.Columns[0].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[1].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[2].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[3].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[6].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[10].ReadOnly = true;

                //Formato de Celdas
                this.DGDetalleDeIngreso.Columns[7].DefaultCellStyle.Format = "##,##0.00";
                this.DGDetalleDeIngreso.Columns[8].DefaultCellStyle.Format = "##,##0.00";
                this.DGDetalleDeIngreso.Columns[10].DefaultCellStyle.Format = "##,##0.00";

                //Aliniacion de las Celdas de Cada Columna
                this.DGDetalleDeIngreso.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Alineacion de los Encabezados de Cada Columna
                this.DGDetalleDeIngreso.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalleDeIngreso.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        public void Agregar_Detalle(int idproducto, string codigo, string nombre, int precio)
        {
            try
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["Idproducto"] = idproducto;
                Fila["Codigo"] = codigo;
                Fila["Descripcion"] = nombre;
                Fila["V. Compra"] = precio;
                this.DtDetalle.Rows.Add(Fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void Agregar_DetalleFiltro(int idproducto, string codigo, string producto, int precio)
        {
            try
            {
                this.DGDetalleDeIngreso.Columns[0].HeaderText = "Idproducto";
                this.DGDetalleDeIngreso.Columns[0].Width = 90;
                this.DGDetalleDeIngreso.Columns[1].HeaderText = "Codigo";
                this.DGDetalleDeIngreso.Columns[1].Width = 90;
                this.DGDetalleDeIngreso.Columns[2].HeaderText = "Producto";
                this.DGDetalleDeIngreso.Columns[2].Width = 305;
                this.DGDetalleDeIngreso.Columns[3].HeaderText = "Cantidad";
                this.DGDetalleDeIngreso.Columns[3].Width = 80;
                this.DGDetalleDeIngreso.Columns[4].HeaderText = "Precio";
                this.DGDetalleDeIngreso.Columns[4].Width = 90;
                this.DGDetalleDeIngreso.Columns[5].HeaderText = "Total";
                this.DGDetalleDeIngreso.Columns[5].Width = 90;

                this.DGDetalleDeIngreso.Columns[0].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[1].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[2].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[3].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[6].ReadOnly = true;
                this.DGDetalleDeIngreso.Columns[10].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Guardar_SQL()
        {
            try
            {
                //string rptaDatosBasicos = "";

                //// <<<<<<------ Panel Datos Basicos ------>>>>>

                //if (this.TBTipo.Text == Campo)
                //{
                //    MensajeError("Ingrese el tipo del Cliente a registrar");
                //}
                //else if (this.TBDescripcion.Text == Campo)
                //{
                //    MensajeError("Ingrese la descripcion del Cliente a registrar");
                //}
                //else if (this.TBCodigo.Text == Campo)
                //{
                //    MensajeError("Ingrese el Codigo del tipo de Cliente");
                //}

                //else
                //{
                //    if (this.Digitar)
                //    {
                //        rptaDatosBasicos = fTipoDeCliente.Guardar_DatosBasicos

                //            (
                //                 //Datos Auxiliares
                //                 1,

                //                 //Panel Datos Basicos
                //                 this.TBCodigo.Text, this.TBTipo.Text, this.TBDescripcion.Text, this.TBObservacion.Text,

                //                 //
                //                 1
                //            );
                //    }

                //    else
                //    {
                //        rptaDatosBasicos = fTipoDeCliente.Editar_DatosBasicos

                //            (
                //                 //Datos Auxiliares
                //                 2, Convert.ToInt32(this.TBIdtipodecliente.Text),

                //                 //Panel Datos Basicos
                //                 this.TBCodigo.Text, this.TBTipo.Text, this.TBDescripcion.Text, this.TBObservacion.Text,

                //                 //
                //                 1
                //            );
                //    }

                //    if (rptaDatosBasicos.Equals("OK"))
                //    {
                //        if (this.Digitar)
                //        {
                //            this.MensajeOk("Registro Exitoso");
                //        }

                //        else
                //        {
                //            this.MensajeOk("Registro Actualizado");
                //        }
                //    }

                //    else
                //    {
                //        this.MensajeError(rptaDatosBasicos);
                //    }

                //    //Llamada de Clase
                //    this.Digitar = false;
                //    this.Limpiar_Datos();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void TBProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //if (e.KeyCode==Keys.Enter)
                //{
                //    DataTable Tabla = new DataTable();
                //    Tabla = fProductos.Buscar(this.TBProducto.Text.Trim(), 4);
                //    if (Tabla.Rows.Count <= 0)
                //    {
                //        this.MensajeError("no existe");
                //    }
                //    else
                //    {
                //        this.Agregar_Detalle
                //            (
                //                Convert.ToInt32(Tabla.Rows[0][1]),
                //                Convert.ToString(Tabla.Rows[0][2]),
                //                Convert.ToInt32(Tabla.Rows[0][3])
                //                //Convert.ToInt32(Tabla.Rows[0][3]),
                //                //Convert.ToInt32(Tabla.Rows[0][4])
                //            ); 
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Bodega_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Producto_Click(object sender, EventArgs e)
        {
            frmFiltro_Producto frmFiltro_Producto = new frmFiltro_Producto();
            frmFiltro_Producto.ShowDialog();
        }

        private void btnExaminar_Moneda_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Comprobante_Click(object sender, EventArgs e)
        {

        }
        
        private void TBCodigo_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fProveedor.Buscar(this.TBCodigo_Bodega.Text.Trim(), 4);
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("El proveedor que desea agregar no se encuentra registrada en su Base de Datos");
                    }
                    else
                    {
                        //Captura de Valores en la Base de Datos
                        this.TBProveedor.Text = Convert.ToString(Tabla.Rows[0][1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBCodigo_Bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataTable Tabla = new DataTable();
                Tabla = fBodega.Buscar(this.TBCodigo_Bodega.Text.Trim(), 4);
                if (Tabla.Rows.Count <= 0)
                {
                    this.MensajeError("La Bodega que desea agregar no se encuentra registrada en su Base de Datos");
                }
                else
                {
                    this.TBBodega.Text = Convert.ToString(Tabla.Rows[0][1]);
                }
            }
        }

        private void TBCodigo_Moneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (e.KeyChar == Convert.ToChar(Keys.Enter))
                //{
                //    DataTable Tabla = new DataTable();
                //    Tabla = fProductos.Buscar(this.TBCodigo_Producto.Text.Trim(), 4);
                //    if (Tabla.Rows.Count <= 0)
                //    {
                //        this.MensajeError("El producto el cual desea agregar no se encuentra registrado en su Base de Datos");
                //    }
                //    else
                //    {
                //        this.Agregar_Detalle
                //            (
                //                Convert.ToInt32(Tabla.Rows[0][0]),
                //                Convert.ToString(Tabla.Rows[0][1]),
                //                Convert.ToString(Tabla.Rows[0][2]),
                //                Convert.ToInt32(Tabla.Rows[0][3])
                //            );
                //        this.TBCodigo_Producto.Clear();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBCodigo_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fProductos.Buscar(this.TBCodigo_Producto.Text.Trim(), 4);
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("El producto el cual desea agregar no se encuentra registrado en su Base de Datos");
                    }
                    else
                    {
                        this.Agregar_Detalle
                            (
                                Convert.ToInt32(Tabla.Rows[0][0]),
                                Convert.ToString(Tabla.Rows[0][1]),
                                Convert.ToString(Tabla.Rows[0][2]),
                                Convert.ToInt32(Tabla.Rows[0][3])
                            );
                        this.TBCodigo_Producto.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBCodigoID_Enter(object sender, EventArgs e)
        {
            this.TBCodigoID.BackColor = Color.Azure;
        }

        private void TBCodigo_Proveedor_Enter(object sender, EventArgs e)
        {
            this.TBCodigo_Proveedor.BackColor = Color.Azure;
        }

        private void TBCodigo_Bodega_Enter(object sender, EventArgs e)
        {
            this.TBCodigo_Bodega.BackColor = Color.Azure;
        }

        private void TBCodigo_Producto_Enter(object sender, EventArgs e)
        {
            this.TBCodigo_Producto.BackColor = Color.Azure;
        }

        private void TBProveedor_Enter(object sender, EventArgs e)
        {
            this.TBProveedor.BackColor = Color.Azure;
        }

        private void TBBodega_Enter(object sender, EventArgs e)
        {
            this.TBBodega.BackColor = Color.Azure;
        }
      
        private void TBCodigo_Proveedor_Leave(object sender, EventArgs e)
        {
            this.TBCodigo_Proveedor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigoID_Leave(object sender, EventArgs e)
        {
            this.TBCodigoID.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBProveedor_Leave(object sender, EventArgs e)
        {
            this.TBProveedor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBodega_Leave(object sender, EventArgs e)
        {
            this.TBBodega.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigo_Bodega_Leave(object sender, EventArgs e)
        {
            this.TBCodigo_Bodega.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigo_Producto_Leave(object sender, EventArgs e)
        {
            this.TBCodigo_Producto.BackColor = Color.FromArgb(3, 155, 229);
        }

    }
}