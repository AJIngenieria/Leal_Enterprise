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
    public partial class frmFiltro_Producto : Form
    {
        public frmFiltro_Producto()
        {
            InitializeComponent();
        }

        private void frmFiltro_Producto_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Habilitar();

            //Focus a Texboxt y Combobox
            this.TBBuscar.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
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

        private void Habilitar()
        {
            this.TBCodigo.ReadOnly = true;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNombre.ReadOnly = true;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBReferencia.ReadOnly = true;
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescripcion01.ReadOnly = true;
            this.TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPresentacion.ReadOnly = true;
            this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMarca.ReadOnly = true;
            this.TBMarca.BackColor = Color.FromArgb(3, 155, 229);
            this.TBGrupo.ReadOnly = true;
            this.TBGrupo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBUnidad.ReadOnly = true;
            this.TBUnidad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBUnidadDeVenta.ReadOnly = true;
            this.TBUnidadDeVenta.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMininoCliente.ReadOnly = true;
            this.TBMininoCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMaximoCliente.ReadOnly = true;
            this.TBMaximoCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMinimoMayorista.ReadOnly = true;
            this.TBMinimoMayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMaximaMayorista.ReadOnly = true;
            this.TBMaximaMayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBBodega.ReadOnly = true;
            this.TBBodega.BackColor = Color.FromArgb(3, 155, 229);
            this.TBStock.ReadOnly = true;
            this.TBStock.BackColor = Color.FromArgb(3, 155, 229);
            this.TBlote.ReadOnly = true;
            this.TBlote.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            this.TBCodigo.Clear();
            this.TBNombre.Clear();
            this.TBReferencia.Clear();
            this.TBDescripcion01.Clear();
            this.TBPresentacion.Clear();
            this.TBMarca.Clear();
            this.TBGrupo.Clear();
            this.TBUnidad.Clear();
            this.TBUnidadDeVenta.Clear();
            this.TBMininoCliente.Clear();
            this.TBMaximoCliente.Clear();
            this.TBMinimoMayorista.Clear();
            this.TBMaximaMayorista.Clear();
            this.TBBodega.Clear();
            this.TBStock.Clear();
            this.TBlote.Clear();
        }
    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmInventario_Ingreso frmBI = new frmInventario_Ingreso();

                //string Codigo, Nombre;
                //int precio;

                frmInventario_Ingreso form = frmInventario_Ingreso.GetInstancia();
                string Idproducto;
                Idproducto = this.DGFiltro_Resultados.CurrentRow.Cells["Codigo"].Value.ToString();
                //par2 = Convert.ToString(this.DGVResultados.CurrentRow.Cells["1"].Value);
                form.setProducto(Idproducto);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBBuscar.Text != "")
                {
                    this.DGFiltro_Resultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 4);
                    this.DGFiltro_Resultados.Columns[0].Visible = false;

                    this.lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGFiltro_Resultados.Rows.Count);

                    this.btnAgregar.Enabled = true;
                    this.DGFiltro_Resultados.Enabled = true;
                }
                else
                {
                    this.Limpiar_Datos();

                    //Se Limpian las Filas y Columnas de la tabla
                    this.DGFiltro_Resultados.DataSource = null;
                    this.DGFiltro_Resultados.Enabled = false;
                    this.lblTotal.Text = "Datos Registrados: 0";

                    this.btnAgregar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void DGFiltro_Resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TBCodigo.Text = this.DGFiltro_Resultados.CurrentRow.Cells["Codigo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }
    }
}
