using System;
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
            this.TBCodigo.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos

            this.TBCodigo.ReadOnly = false;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNu_Comprobante.ReadOnly = false;
            this.TBNu_Comprobante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorDeCompra.ReadOnly = false;
            this.TBValorDeCompra.BackColor = Color.FromArgb(3, 155, 229);
            this.TBStockInicial.ReadOnly = false;
            this.TBStockInicial.BackColor = Color.FromArgb(3, 155, 229);
            this.TBStockActual.ReadOnly = false;
            this.TBStockActual.BackColor = Color.FromArgb(3, 155, 229);

            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos

                this.CBProveedor.SelectedIndex = 0;
                this.CBComprobante.SelectedIndex = 0;

                this.TBCodigo.Clear();
                this.TBNu_Comprobante.Clear();
                this.TBValorDeCompra.Clear();
                this.TBStockInicial.Clear();
                this.TBStockActual.Clear();

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBCodigo.Focus();
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
            this.DtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            //this.DtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("Articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("Valor", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("Total", System.Type.GetType("System.Int32"));

            DGDetalleDeIngreso.DataSource = this.DtDetalle;

            this.DGDetalleDeIngreso.Columns[0].Visible = false;
            //this.DGDetalleDeIngreso.Columns[1].HeaderText = "Codigo";
            //this.DGDetalleDeIngreso.Columns[1].Width = 90;
            this.DGDetalleDeIngreso.Columns[1].HeaderText = "Articulo";
            this.DGDetalleDeIngreso.Columns[1].Width = 305;
            this.DGDetalleDeIngreso.Columns[2].HeaderText = "Cantidad";
            this.DGDetalleDeIngreso.Columns[2].Width = 80;
            this.DGDetalleDeIngreso.Columns[3].HeaderText = "Valor";
            this.DGDetalleDeIngreso.Columns[3].Width = 90;
            this.DGDetalleDeIngreso.Columns[4].HeaderText = "Total";
            this.DGDetalleDeIngreso.Columns[4].Width = 90;

            this.DGDetalleDeIngreso.Columns[1].ReadOnly = true;
            this.DGDetalleDeIngreso.Columns[2].ReadOnly = true;
            //this.DGDetalleDeIngreso.Columns[5].ReadOnly = true;
        }
        
        public void Agregar_Detalle
            (
                int idarticulo, string nombre

            //int cantidad, int precio
            )
        {
            DataRow Fila = DtDetalle.NewRow();
            Fila["Codigo"] = idarticulo;
            //Fila["Codigo"] = codigo;
            Fila["Articulo"] = nombre;
            //Fila["Cantidad"] = cantidad;
            //Fila["Valor"] = precio;
            //Fila["Total"] = precio;
            this.DtDetalle.Rows.Add(Fila);
        }

        private void Agregar_DetalleFiltro(int idarticulo, string codigo, string producto, string precio)
        {
            
            this.DGDetalleDeIngreso.Columns[1].HeaderText = "Codigo";
            this.DGDetalleDeIngreso.Columns[1].Width = 90;
            this.DGDetalleDeIngreso.Columns[2].HeaderText = "Producto";
            this.DGDetalleDeIngreso.Columns[2].Width = 305;
            this.DGDetalleDeIngreso.Columns[3].HeaderText = "Cantidad";
            this.DGDetalleDeIngreso.Columns[3].Width = 80;
            this.DGDetalleDeIngreso.Columns[4].HeaderText = "Valor";
            this.DGDetalleDeIngreso.Columns[4].Width = 90;
            this.DGDetalleDeIngreso.Columns[5].HeaderText = "Total";
            this.DGDetalleDeIngreso.Columns[5].Width = 90;

            this.DGDetalleDeIngreso.Columns[1].ReadOnly = true;
            this.DGDetalleDeIngreso.Columns[2].ReadOnly = true;
            this.DGDetalleDeIngreso.Columns[5].ReadOnly = true;
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


        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fProductos.Buscar(this.TBCodigo.Text.Trim(), 4);
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("no existe");
                    }
                    else
                    {
                        this.Agregar_Detalle
                            (
                                Convert.ToInt32(Tabla.Rows[0][0]),
                                Convert.ToString(Tabla.Rows[0][1])
                                //Convert.ToString(Tabla.Rows[0][2])
                                //Convert.ToInt32(Tabla.Rows[0][3]),
                                //Convert.ToInt32(Tabla.Rows[0][4])
                            ); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //******************* FOCUS LEAVE *******************
        private void TBNu_Comprobante_Enter(object sender, EventArgs e)
        {
            this.TBNu_Comprobante.BackColor = Color.Azure;
        }

        private void TBCodigo_Enter(object sender, EventArgs e)
        {
            this.TBCodigo.BackColor = Color.Azure;
        }

        private void TBValorDeCompra_Enter(object sender, EventArgs e)
        {
            this.TBValorDeCompra.BackColor = Color.Azure;
        }

        private void TBStockInicial_Enter(object sender, EventArgs e)
        {
            this.TBStockInicial.BackColor = Color.Azure;
        }

        private void TBStockActual_Enter(object sender, EventArgs e)
        {
            this.TBStockActual.BackColor = Color.Azure;
        }

        //******************* FOCUS LEAVE *******************
        private void TBNu_Comprobante_Leave(object sender, EventArgs e)
        {
            this.TBNu_Comprobante.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigo_Leave(object sender, EventArgs e)
        {
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBValorDeCompra_Leave(object sender, EventArgs e)
        {
            this.TBValorDeCompra.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBStockInicial_Leave(object sender, EventArgs e)
        {
            this.TBStockInicial.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBStockActual_Leave(object sender, EventArgs e)
        {
            this.TBStockActual.BackColor = Color.FromArgb(3, 155, 229);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmFiltro_Producto frmFiltro_Producto = new frmFiltro_Producto();
            frmFiltro_Producto.ShowDialog();
        }
    }
}
